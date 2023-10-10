using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiAzureTables.Models;
using Azure;
using Azure.Data.Tables;

namespace WebApiAzureTables.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public ContatoController(IConfiguration configuration) {
            _connectionString = configuration.GetValue<string>("SAConnectionString");
            _tableName        = configuration.GetValue<string>("AzureTableName");
        }

        private TableClient GetTableClient(){
            var serviceClient = new TableServiceClient(_connectionString); //iniciando o serviço table storage
            var tableClient   = serviceClient.GetTableClient(_tableName);  //iniciando a tabela

            tableClient.CreateIfNotExists(); //ele cria ela no azure
            return tableClient;
        }

        [HttpPost]
        public IActionResult Criar (Contato contato) {
            var tableClient = GetTableClient();

            contato.RowKey = Guid.NewGuid().ToString(); //identificador global
            contato.PartitionKey = contato.RowKey;

            tableClient.UpsertEntity(contato); //substitui o metodo de inserir e atualizar
            return Ok(contato);
        }
    }
}