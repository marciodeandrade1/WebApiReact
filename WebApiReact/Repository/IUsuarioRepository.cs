using WebApiReact.Models;

namespace WebApiReact.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuario(int id);
        Task<Usuario> AddUsuario(Usuario user);
        Task<Usuario> UpdateUsuario(Usuario user);
        Task DeleteUsuario(int id);
    }
}
