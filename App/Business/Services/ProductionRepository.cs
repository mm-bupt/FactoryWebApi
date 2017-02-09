using System;
using System.Collections.Generic;
using System.Linq;
using FactoryWebApi.App.Business.Models;

namespace FactoryWebApi.App.Business.Services
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly ProductionContext _context;

        public ProductionRepository(ProductionContext context)
        {
            _context = context;
        }

        public IEnumerable<Production> ListAll()
        {
            return _context.Productions.AsEnumerable();
        }
        public IEnumerable<Production> Find(string drawingNumber)
        {
            return _context.Productions
                .Where(b => b.DrawingNumber.Contains(drawingNumber))
                .OrderBy(b => b.DrawingNumber)
                .ToList();
        }

        public Production Add(Production production)
        {
            Production tmp = _context.Productions.Add(production).Entity;
            _context.SaveChanges();
            return tmp;
        }
    }
}