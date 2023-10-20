using API_AppMarciusMagazine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppMarciusMagazine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuPrincipal : ControllerBase
    {
        private readonly DbmarciusbrtsSemanalContext _dbContext;

        public MenuPrincipal(DbmarciusbrtsSemanalContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("menu-principal")]
        public async Task<List<TblAppMarciusMenuPrincipal>> ItensMenuPrincipal(string func)
        {
            try
            {
                if (!string.IsNullOrEmpty(func))
                {
                    return await _dbContext.TblAppMarciusMenuPrincipals
                                 .Where(x => x.BtnAtivo == true && (x.DepPermitidos.Contains(func))).OrderBy(y => y.TextoBtn)
                                 .ToListAsync();
                }

                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
