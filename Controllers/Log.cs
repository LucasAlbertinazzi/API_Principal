using API_AppMarciusMagazine.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_AppMarciusMagazine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Log : ControllerBase
    {
        private readonly DbmarciusbrtsSemanalContext _dbContext;

        public Log(DbmarciusbrtsSemanalContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("erro")]
        public async Task<IActionResult> SalvaLogErro(TblAppMarciusLog log)
        {
            try
            {
                var logerro = new TblAppMarciusLog
                {
                    Metodo = log.Metodo,
                    Erro = log.Erro,
                    TelaClasse = log.TelaClasse,
                    Dispositivo = log.Dispositivo,
                    Plataforma = log.Plataforma,
                    Versao = log.Versao,
                    Data = log.Data
                };

                _dbContext.TblAppMarciusLogs.Add(logerro);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                // Obtém a exceção interna, se houver
                var innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Erro ao salvar as alterações: {innerExceptionMessage}");
            }
        }
    }
}
