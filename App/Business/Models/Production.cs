using System.Collections.Generic;

namespace FactoryWebApi.App.Business.Models
{
    public partial  class Production
    {
        public Production()
        {
            ProductionProcedures = new HashSet<ProductionProcedure>();
        }

        public int Id {get;set;}
        public string DrawingNumber {get;set;}
        public string Name { get; set; }
        public string SpecificationMaterial { get; set;}
        public string CuttingSize { get; set; }

        public virtual ICollection<ProductionProcedure> ProductionProcedures { get;set;}
    }
}