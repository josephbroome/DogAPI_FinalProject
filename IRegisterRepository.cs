using DogAPI_FinalProject.Models;

namespace DogAPI_FinalProject
{
    public interface IRegisterRepository
    {
        public IEnumerable<RegisterModel> GetAllUsers();

        public void RegisterUser(RegisterModel registerUser);

        public RegisterModel AssignUser();

    }
}
