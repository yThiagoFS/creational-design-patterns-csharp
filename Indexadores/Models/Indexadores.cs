namespace Indexadores.Models
{
    public class Indexadores
    {
        private List<Indexadores> _indexadores = new();

        public string Mensagem { get; set; }

        public Indexadores(string mensagem = "")
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
                Mensagem = mensagem;
        }

        public Indexadores this[int index]
        {
            get { return _indexadores[index]; } 
            set { this._indexadores.Add(value); }
        }
    }
}
