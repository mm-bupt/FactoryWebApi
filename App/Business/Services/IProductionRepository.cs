using System.Collections.Generic;
using FactoryWebApi.App.Business.Models;

namespace FactoryWebApi.App.Business.Services
{
    public interface IProductionRepository
    {
        IEnumerable<Production> ListAll();
        IEnumerable<Production> Find(string drawingNumber);
        
        Production Add(Production production);
    }
}