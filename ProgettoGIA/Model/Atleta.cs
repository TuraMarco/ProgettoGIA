﻿using System;

namespace ProgettoGIA.Model
{
    public class Atleta
    {
        //campi
        private readonly Guid _guid;
        private readonly string _nome;
        private readonly string _cognome;
        private readonly string _codiceFiscale;
        private readonly Sesso _sesso;
        private readonly DateTime _dataDiNascita;
        private readonly bool _istruttore;
        private readonly Società _società;
        private readonly DateTime _scadenzaCertificato;

        //property
        public Guid Guid => _guid;
        public string Nome => _nome;
        public string Cognome => _cognome;
        public string CF => _codiceFiscale;
        public Sesso Sesso => _sesso;
        public DateTime DataDiNascita => _dataDiNascita;
        public bool Istruttore => _istruttore;
        public Società SocietàDiAppeartenenza => _società;
        public DateTime ScadenzaCertificato => _scadenzaCertificato;
        

        //costruttore
        public Atleta(string nome, string cognome, string codiceFiscale, Sesso sesso, DateTime dataDiNascita, bool istruttore, Società società, DateTime scadenzaCertificato, Guid guid)
        {
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
            _sesso = sesso;
            _dataDiNascita = dataDiNascita;
            _istruttore = istruttore;
            _società = società;
            _scadenzaCertificato = scadenzaCertificato;

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
            if (_scadenzaCertificato.Millisecond >= new DateTime().Millisecond)
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
            DateTime temp = _dataDiNascita.AddYears(18);


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
            DateTime temp = _dataDiNascita.AddYears(14);
            

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