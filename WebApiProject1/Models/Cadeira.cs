using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject1.Models
{
    public class Cadeira
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public double Altura { get; set; }
        public string Status { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public string Cor { get; set; }
    }
}