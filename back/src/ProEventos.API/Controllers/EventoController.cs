using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {



      public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
               EventoId = 1,
               Tema = "Angular e .NET core",
               Local = "Capoeiras-PE",
               Lote = "Primeiro lote",
               QtdPessoas = 34,
               DataEvento = "12/12/2003",
               ImagemURL = "Mikael.png"

            },
            new Evento(){
               EventoId = 2,
               Tema = "E sua novidades",
               Local = "Caetes-PE",
               Lote = "Primeiro segundo",
               QtdPessoas = 34,
               DataEvento = "12/12/2003",
               ImagemURL = "teste.png"

            }

         };
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);

        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}
