using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        
    }
}