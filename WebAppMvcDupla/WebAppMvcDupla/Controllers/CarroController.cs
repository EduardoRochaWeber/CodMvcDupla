using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvcDupla.Models;
using WebAppMvcDupla.Repository;

namespace WebAppMvcDupla.Controllers
{
    public class CarroController : BaseController<Carro,CarroRepository>
    {
        public CarroController() : base(new CarroRepository())
        {
        }
        
    }
}