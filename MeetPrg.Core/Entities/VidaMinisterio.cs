namespace MeetPrg.Core.Entities
{
    public sealed class VidaMinisterio : Entity
    {

        public DateTime DataDesignacao { get; private set; }
        public Guid SemanaId { get; private set; }
        public string? Secao { get; private set; }
        public string? Parte { get; private set; }
       
        public Guid TitularA { get; private set; }
        public Guid AjudanteA { get; private set; }

         public Guid TitularB { get; private set; }
        public Guid AjudanteB { get; private set; }



    }

}
