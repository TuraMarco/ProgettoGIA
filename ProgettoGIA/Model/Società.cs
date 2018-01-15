using System;

namespace ProgettoGIA.Model
{
    public class Società
    {
        //campi
        private readonly string _nome;
        private readonly string _sede;
        private readonly Guid _guid;


        //property
        public string Nome => _nome;
        public string Sede => _sede;
        public Guid Guid => _guid;


        //costruttore
        public Società(string nome, string sede, Guid guid)
        {
            _nome = nome;
            _sede = sede;

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