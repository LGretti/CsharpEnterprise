using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiAzureTables.Models;

namespace WebApiAzureTables.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tabelName;

        public ContatoController(IConfiguration configuration) {
            _connectionString = configuration.GetValue<string>("SAConnectionString");
            _tabelName        = configuration.GetValue<string>("AzureTableName");
        }

        private TableClient GetTableClient(){
            var serviceClient = new TableServiceClient(_connectionString); //iniciando o serviço table storage
            var tabelClient   = serviceClient.GetTableClient(_tabelName);  //iniciando a tabela

            tableClient.CreateIfNotExists(); //ele cria ela no azure
            return tableClient;
        }

        [HttpPost]
        public IACtionResult Criar (Contato contato) {
            var tableClient = GetTableClient();

            contato.RowKey = Guid.NewGuid().ToString(); //identificador global
            contato.PartitionKey = contato.RowKey;

            tableClient.UpsertEntity(contato); //substitui o metodo de inserir e atualizar
            return Ok(contato);
        }
    }
}