namespace MeetPrg.Core.Entities
{
    public sealed class Indicador : Entity
    {
        public Indicador(Guid auditorioId, Guid entradaId, DateTime dataDesignacao)
        {
            AuditorioId = auditorioId;
            EntradaId = entradaId;
            DataDesignacao = dataDesignacao;
        }
        public void Atualizar(Guid auditorioId, Guid entradaId, DateTime dataDesignacao)
        {
            AuditorioId = auditorioId;
            EntradaId = entradaId;
            DataDesignacao = dataDesignacao;
        }

        public Guid AuditorioId { get; private set; }
        public Guid EntradaId { get; private set; }
        public DateTime DataDesignacao { get; private set; }

    }
}
