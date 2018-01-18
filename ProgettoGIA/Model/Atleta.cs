using System;

namespace ProgettoGIA.Model
{
    public class Atleta
    {
        //campi
        private readonly Guid _guid;
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private Sesso _sesso;
        private DateTime _dataDiNascita;
        private bool _istruttore;
        private Società _società;
        private DateTime _scadenzaCertificato;

        //property
        public Guid Guid => _guid;
        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string CodiceFiscale { get => _codiceFiscale; set => _codiceFiscale = value; }
        public Sesso Sesso { get => _sesso; set => _sesso = value; }
        public DateTime DataDiNascita { get => _dataDiNascita; set => _dataDiNascita = value; }
        public bool Istruttore { get => _istruttore; set => _istruttore = value; }
        public Società Società { get => _società; set => _società = value; }
        public DateTime ScadenzaCertificato { get => _scadenzaCertificato; set => _scadenzaCertificato = value; }

        //costruttore
        public Atleta(string nome, string cognome, string codiceFiscale, Sesso sesso, DateTime dataDiNascita, bool istruttore, Società società, DateTime scadenzaCertificato, Guid guid)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            DataDiNascita = dataDiNascita;
            Istruttore = istruttore;
            Società = società;
            ScadenzaCertificato = scadenzaCertificato;

            if (Guid == Guid.Empty)
            {
                _guid = Guid.NewGuid();
            }
            else
            {
                _guid = guid;
            }
        }

        public bool IsCertificatoValido()
        {
            if (ScadenzaCertificato.Millisecond >= new DateTime().Millisecond)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsEtàInferiore18()
        {
            //Da testare
            DateTime temp = DataDiNascita.AddYears(18);


            if (temp >= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEtàInferiore14()
        {
            //Da testare
            DateTime temp = DataDiNascita.AddYears(14);
            

            if (temp >= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}