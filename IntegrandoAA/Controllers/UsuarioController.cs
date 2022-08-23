using IntegrandoAA.Model;
using IntegrandoAA.Repository;
using Microsoft.AspNetCore.Mvc;

namespace IntegrandoAA.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet (Name = "GetUsuarios")]
        public List<Usuario> GetUsuarios()
        {
            
            return UsuarioHandler.GetUsuarios(); 
        }
    } 
}
