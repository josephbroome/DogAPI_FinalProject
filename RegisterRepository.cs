using Dapper;
using DogAPI_FinalProject.Models;
using System.Data;

namespace DogAPI_FinalProject
{
    public class RegisterRepository: IRegisterRepository
    {
        private readonly IDbConnection _conn;

        public RegisterRepository(IDbConnection conn)
        {
            _conn = conn;
        }   

        public IEnumerable<RegisterModel> GetAllUsers()
        {
            return _conn.Query<RegisterModel>("SELECT * FROM user;");

        }

        public void RegisterUser(RegisterModel registerUser)
        {
            _conn.Execute("INSERT INTO user (EMAILID, PASSWORD) VALUES (@emailID, @password);",
                new
                {
                    emailID = registerUser.EmailID,
                    password = registerUser.Password,
                });

        }

        public RegisterModel AssignUser()
        {
            var newUser = new RegisterModel();

            return newUser;
        }
    }
}
