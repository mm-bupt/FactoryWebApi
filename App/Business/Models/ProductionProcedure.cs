namespace FactoryWebApi.App.Business.Models
{
    public class ProductionProcedure
    {
        public int ProductionProcedureId {get;set;}
        public int ProductionId {get;set;}
        public int ProcedureId {get;set;}
        public int ManHour { get; set; }
    }
}