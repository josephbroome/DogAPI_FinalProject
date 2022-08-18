using DogAPI_FinalProject.Models;

namespace DogAPI_FinalProject
{
    public interface IDogRepository
    {

        public DogAPIclient GetDog(string name);

    }
}
