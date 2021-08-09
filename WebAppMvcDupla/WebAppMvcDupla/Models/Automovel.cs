using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMvcDupla.Models
{
    public class Automovel : BaseModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindradas { get; set; }
        [Display(Name = "Quantidade de Rodas" )]
        public int QtRodas { get; set; }
    }
}