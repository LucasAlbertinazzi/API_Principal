using API_AppMarciusMagazine.Models;
using API_AppMarciusMagazine.Suporte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppMarciusMagazine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuario : ControllerBase
    {
        private readonly DbContextApp _dbContext;

        public Usuario(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("verifica-login")]
        public async Task<IActionResult> Verifica(Login login)
        {
            try
            {
                string senhacripto = Seguranca.Criptografar(login.senha);

                var usuario = await _dbContext.TblUsuarios.Where(x =>
                    x.Login == login.usuario && x.Email == senhacripto).FirstOrDefaultAsync();

                if (usuario != null && usuario.Codusuario > 0)
                {
                    return Ok(usuario);
                }

                return Unauthorized();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
