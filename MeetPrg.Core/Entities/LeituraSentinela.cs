namespace MeetPrg.Core.Entities
{
    public sealed class LeituraSentinela : Entity
    {
        public LeituraSentinela(Guid leitorId, DateTime dataDesignacao)
        {
            LeitorId = leitorId;
            DataDesignacao = dataDesignacao;
        }
        public void Atualizar(Guid leitorId, DateTime dataDesignacao)
        {
            LeitorId = leitorId;
            DataDesignacao = dataDesignacao;
        }

        public Guid LeitorId { get; private set; }

        public DateTime DataDesignacao { get; private set; }


    }
}
