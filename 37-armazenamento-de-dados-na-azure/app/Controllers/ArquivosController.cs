using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivosController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        // Injeção de dependência
        public ArquivosController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("BlobConnectionString");
            _containerName = configuration.GetValue<string>("BlobContainerName");
        }

        // POST: /Arquivos/Upload
        [HttpPost("Upload")]
        public IActionResult UploadArquivo(IFormFile arquivo) {
            BlobContainerClient containter = new(_connectionString, _containerName);
            BlobClient blob = containter.GetBlobClient(arquivo.FileName);

            using var data = arquivo.OpenReadStream();
            blob.Upload(data, new BlobUploadOptions {
                HttpHeaders = new BlobHttpHeaders {
                    ContentType = arquivo.ContentType
                }
            });

            return Ok(blob.Uri.ToString());
        }

        // GET: /Arquivos/Download/{nome}
        [HttpGet("Download/{nome}")]
        public IActionResult DownloadArquivo(string nome) {
            BlobContainerClient containter = new(_connectionString, _containerName);
            BlobClient blob = containter.GetBlobClient(nome);
            
            if (!blob.Exists()) {
                return NotFound();
            }

            //baixa a imagem e grava na retorno e retorna em um array
            var retorno = blob.DownloadContent();
            return File(retorno.Value.Content.ToArray(), retorno.Value.Details.ContentType, blob.Name);
        }

        // DELETE: /Arquivos/Deletar/{nome}
        [HttpDelete("Deletar/{nome}")]
        public IActionResult DeletarArquivo(string nome) {
            BlobContainerClient containter = new(_connectionString, _containerName);
            BlobClient blob = containter.GetBlobClient(nome);

            blob.DeleteIfExists();
            return Ok();
        }


        // GET: /Arquivos/Listar
        [HttpGet("Listar")]
        public IActionResult Listar() {
            List<BlobDto> blobsDto = new List<BlobDto>();
            BlobContainerClient container = new(_connectionString, _containerName);

            foreach (var blob in container.GetBlobs()) {
                blobsDto.Add(new BlobDto {
                    Nome = blob.Name,
                    Tipo = blob.Properties.ContentType,
                    Uri  = container.Uri.AbsoluteUri + "/" + blob.Name
                });
            }

            return Ok(blobsDto);
        }
    }
}