using System;
using System.Collections.Generic;
using System.Text;

namespace BookDepo.ApiClient.Models.ApiModels
{
    public class Books
    { 
        public int Id { get; set; }

        public string? BookName { get; set; }

        public string? BookCode { get; set; }
        public decimal Price { get; set; }

        public int StockAvailable { get; set; }
    }
}
