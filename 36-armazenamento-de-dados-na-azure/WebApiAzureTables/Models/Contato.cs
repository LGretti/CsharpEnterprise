using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;


namespace WebApiAzureTables.Models
{
    public class Contato : ITableEntity
    {
        // Propriedades automáticas        
        public string PartitionKey       { get; set; }
        public string RowKey             { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag                 { get; set; }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }




    }
}