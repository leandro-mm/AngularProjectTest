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
        public IEnumerable<Evento> ListEventos = new Evento []
            { 
                new Evento(){ Data= DateTime.Now.ToShortDateString(), Local="PoA/RS",EventoId=1,ImgURL="",QtdPessoas=45,Tema="Tema Exemplo"},
                new Evento(){ Data= DateTime.Now.ToShortDateString(), Local="PoA/RS",EventoId=2,ImgURL="",QtdPessoas=45,Tema="Tema Exemplo"}                
            };

        public TestController(){}

        [HttpGet]
        public IEnumerable<Evento> Get()
        {            
            return ListEventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {            
            return ListEventos.Where(evento => evento.EventoId == id).FirstOrDefault();
        }

        [HttpPost]
        public string Post()
        {            
            return"Post TestController";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {            
            return $"Put TestController id = {id}";
        }
    }
}
