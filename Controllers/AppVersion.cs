using API_AppMarciusMagazine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppMarciusMagazine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppVersion : ControllerBase
    {
        private readonly DbContextApp _dbContext;

        public AppVersion(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("verifica-versao")]
        public async Task<IActionResult> VerificaVersao()
        {
            try
            {
                var ultimaLinha = await _dbContext.TblAppMarciusVersaos
                                    .OrderByDescending(x => x.Id)
                                    .FirstOrDefaultAsync();

                if (ultimaLinha == null)
                {
                    // Tratar o caso em que a tabela está vazia
                    return Ok(0);
                }

                return Ok(ultimaLinha);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("inserir-versao")]
        public async Task<IActionResult> InserirVersao(TblAppMarciusVersao versionInfo)
        {
            try
            {
                var novaVersao = new TblAppMarciusVersao
                {
                    Versao = versionInfo.Versao,
                    Data = versionInfo.Data
                };

                _dbContext.TblAppMarciusVersaos.Add(novaVersao);
                await _dbContext.SaveChangesAsync();

                return Ok(novaVersao);
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
