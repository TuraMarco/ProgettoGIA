namespace ProgettoGIA.Model
{
    public class Società
    {
        //campi
        private readonly string _nome;
        private readonly string _sede;

        //property
        public string Nome => _nome;
        public string Sede => _sede;

        //costruttore
        public Società(string nome, string sede)
        {
            _nome = nome;
            _sede = sede;
        }
    }
}