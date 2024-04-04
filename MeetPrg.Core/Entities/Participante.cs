namespace MeetPrg.Core.Entities
{
    public sealed class Participante : Entity
    {
        public Participante(string? nome, bool dianteira, bool estudante, bool leitorEstudoDeLivro, bool leitorEstudoSentinela, bool indicador, bool volante, bool audioVideo)
        {
            Nome = nome;
            Dianteira = dianteira;
            Estudante = estudante;
            LeitorEstudoDeLivro = leitorEstudoDeLivro;
            LeitorEstudoSentinela = leitorEstudoSentinela;
            Indicador = indicador;
            Volante = volante;
            AudioVideo = audioVideo;
            UltimaAlteracao = DateTime.Now;
        }
        public void Atualizar(string? nome, bool dianteira, bool estudante, bool leitorEstudoDeLivro, bool leitorEstudoSentinela, bool indicador, bool volante, bool audioVideo)
        {
            Nome = nome;
            Dianteira = dianteira;
            Estudante = estudante;
            LeitorEstudoDeLivro = leitorEstudoDeLivro;
            LeitorEstudoSentinela = leitorEstudoSentinela;
            Indicador = indicador;
            Volante = volante;
            AudioVideo = audioVideo;
            UltimaAlteracao = DateTime.Now;
        }

        public string? Nome { get; private set; }
        public bool Dianteira { get; private set; }
        public bool Estudante { get; private set; }
        public bool LeitorEstudoDeLivro { get; private set; }
        public bool LeitorEstudoSentinela { get; private set; }
        public bool Indicador { get; private set; }
        public bool Volante { get; private set; }
        public bool AudioVideo { get; private set; }
        public DateTime UltimaAlteracao { get; private set; }

    }
}
