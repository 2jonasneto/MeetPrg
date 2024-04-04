namespace MeetPrg.Core.Entities
{
    public sealed class Volante : Entity
    {
        public Volante(Guid volante01, Guid volante02, DateTime dataDesignacao)
        {
            Volante01 = volante01;
            Volante02 = volante02;
            DataDesignacao = dataDesignacao;
        }
        public void Atualizar(Guid volante01, Guid volante02, DateTime dataDesignacao)
        {
            Volante01 = volante01;
            Volante02 = volante02;
            DataDesignacao = dataDesignacao;
        }
        public Guid Volante01 { get; private set; }
        public Guid Volante02 { get; private set; }
        public DateTime DataDesignacao { get; private set; }

    }
}
