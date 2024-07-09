using WebApiReact.Models;

namespace WebApiReact.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<Usuario> AddUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}
