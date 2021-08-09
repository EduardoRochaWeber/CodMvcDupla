using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvcDupla.Models;
using WebAppMvcDupla.Repository;

namespace WebAppMvcDupla.Controllers
{
    public class CaminhaoController : BaseController<Caminhao,CaminhaoRepository>
    {
        public CaminhaoController() : base(new CaminhaoRepository())
        {
        }
    }
}