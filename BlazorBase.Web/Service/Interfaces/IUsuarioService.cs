using BlazorBase.Shared.Models;
using BlazorBase.Web.Service.Interfaces;

namespace BlazorBase.Web.Service
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        public Task<Usuario> AddUsuario();
        public Task<Usuario> CadastrarUsuario(Usuario usuaroObj);
        public Task<List<Usuario>> BuscarUsuarios();
    }
}
