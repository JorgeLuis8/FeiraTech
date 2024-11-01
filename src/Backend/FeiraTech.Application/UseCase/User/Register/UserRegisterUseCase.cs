using AutoMapper;
using FeiraTech.Application.Services.Criptography;
using FeiraTech.Communication.Requests;
using FeiraTech.Communication.Response;
using FeiraTech.Domain.Repositorie;
using FeiraTech.Domain.Repositorie.User;


namespace FeiraTech.Application.UseCase.User.Register
{
    public class UserRegisterUseCase : IUserRegisterUseCase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;
        private readonly IUserReadOnlyRepository _userReadOnlyRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly PasswordEncripter _passwordHash;

        public UserRegisterUseCase(IMapper mapper,
            PasswordEncripter passwordHash,
            IUserReadOnlyRepository userReadOnlyRepository,
            IUserWriteOnlyRepository userWriteOnlyRepository,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _passwordHash = passwordHash;
            _userReadOnlyRepository = userReadOnlyRepository;
            _userWriteOnlyRepository = userWriteOnlyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson request) {
            //Validar a request, criar um função para validação dos dados.
            ValidateUser(request);
            //Mapear a request ém uma entidade
            var userEntity = _mapper.Map<Domain.Entity.User>(request);
            //Criptografar a senha
            userEntity.Password = _passwordHash.Encript(request.Password);
            //Adicionar o usuário no banco de dados
            await _userWriteOnlyRepository.Add(userEntity);
            //Commitar as operações
            await _unitOfWork.Commit();
            
            return new ResponseRegisterUserJson { Name = userEntity.Name };
        }

        public void ValidateUser(RequestRegisterUserJson request)
        {
            //Utilzar o FluentValidation para validar os dados
            var validation = new UserRegisterValidation();
            var result = validation.Validate(request);

            if (result.IsValid == false)
            {
                throw new Exception("Dados inválidos");
            }      

        }

    }
}
