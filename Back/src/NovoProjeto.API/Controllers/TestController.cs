using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NovoProjeto.API.Models;

namespace NovoProjeto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {       
        public NovoProjeto.API.Data.DataContext Context { get; set; }

        public TestController(NovoProjeto.API.Data.DataContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return Context.Eventos.Where(evento => evento.EventoId == id).FirstOrDefault();
        }

        [HttpPost]
        public string Post()
        {
            return "Post TestController";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put TestController id = {id}";
        }
    }
}
