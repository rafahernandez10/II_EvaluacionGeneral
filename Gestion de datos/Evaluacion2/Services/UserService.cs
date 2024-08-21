using Evaluacion2.Models;
using Evaluacion2.Repositories;

namespace Evaluacion2.Services
{
    public class UserService
    {
        private readonly IUsuarioRepository _userRepository;

        public UserService(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            return _userRepository.GetAll();
        }

        public UsuarioModel GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Add(UsuarioModel user)
        {
            _userRepository.Add(user);
        }

        public void Update(UsuarioModel user)
        {
            _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

    }
}
