using System;
using System.Collections.Generic;
using FactoryWebApi.App.Business.Models;
using FactoryWebApi.App.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace FactoryWebApi.App.Controllers
{
    [Route("api/[controller]")]        
    public class MachinePartController : Controller
    {
        private readonly ProductionRepository _repository;
        public MachinePartController(ProductionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Production> Get()
        {
            return _repository.ListAll();
        }
        

        [HttpPost]
        public Production Add([FromBody]Production production)
        {
            return _repository.Add(new Production(){ Name = production.Name});
        }
    }
}