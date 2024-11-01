
namespace FeiraTech.Domain.Repositorie.User
{
    public interface IUserReadOnlyRepository
    {
        public Task<bool> EmailIsExists(string email);


    }
}
