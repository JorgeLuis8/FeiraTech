using AutoMapper;
using FeiraTech.Application.Services.Criptography;
using FeiraTech.Communication.Requests;
using FeiraTech.Communication.Response;


namespace FeiraTech.Application.UseCase.User.Register
{
    public class UserRegisterUseCase
    {
        private readonly IMapper _mapper;
        private readonly PasswordEncripter _passwordHash;
        public UserRegisterUseCase(IMapper mapper, PasswordEncripter passwordHash)
        {
            _mapper = mapper;
            _passwordHash = passwordHash;
        }

        public async Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson request) {
            //Validar a request, criar um função para validação dos dados.
            ValidateUser(request);
            //Mapear a request ém uma entidade
            var userEntity = _mapper.Map<Domain.Entity.User>(request);
            //Criptografar a senha
            userEntity.Password = _passwordHash.Encript(request.Password);
            //Adicionar o usuário no banco de dados

            //Commitar a transação




            return new ResponseRegisterUserJson();
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
