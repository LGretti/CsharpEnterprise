using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;


namespace WebApiAzureTables.Models
{
    public class Contato : ITableEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        // Propriedades automáticas        
        public string PartitionKey       { get; set; }
        public string RowKey             { get; set; }
        public DateTimeOffSet? TimeStamp { get; set; }
        public ETag ETag                 { get; set; }

    }
}