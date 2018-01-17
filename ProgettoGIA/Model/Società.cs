using System;

namespace ProgettoGIA.Model
{
    public class Società
    {
        //campi
        private string _nome;
        private string _sede;
        private readonly Guid _guid;

        //property
        public string Nome { get => _nome; set => _nome = value; }
        public string Sede { get => _sede; set => _sede = value; }
        public Guid Guid => _guid;

        //costruttore
        public Società(string nome, string sede, Guid guid)
        {
            Nome = nome;
            Sede = sede;

            if (Guid == Guid.Empty)
            {
                _guid = Guid.NewGuid();
            }
            else
            {
                _guid = guid;
            }
        }
    }
}