namespace MeetPrg.Core.Entities
{
    public sealed class Semana : Entity
    {
        public Semana(string? descricao, bool especial)
        {
            Descricao = descricao;
            Especial = especial;
        }

        public string? Descricao { get; private set; }
        public bool Especial { get; private set; }
    

    }
}
