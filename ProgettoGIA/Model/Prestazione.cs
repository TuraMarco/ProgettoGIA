using ProgettoGIA.Model.Calcolatori;
using System;

namespace ProgettoGIA.Model
{
    public class Prestazione
    {
        //campi
        private readonly Disciplina _disciplina;
        private float _misurazione;
        private int _valutazioneTecnica_assetto;
        private int _valutazioneTecnica_virata;
        private int _valutazioneTecnica_avanzamento;
        private int _valutazioneTecnica_acquaticità;
        private bool _atrezzatura_muta;
        private bool _atrezzatura_maschera;
        private bool _atrezzatura_tappanaso;
        private bool _atrezzatura_zavorra;
        private Cartellino _cartellino;
        private int _penalità;
        private float _punteggio;
        private bool _prestazioneCompletata;

        //property
        public Disciplina Disciplina => _disciplina;
        public float Misurazione { get => _misurazione; set => _misurazione = value; }
        public int ValutazioneTecnica_assetto { get => _valutazioneTecnica_assetto; set => _valutazioneTecnica_assetto = value; }
        public int ValutazioneTecnica_virata { get => _valutazioneTecnica_virata; set => _valutazioneTecnica_virata = value; }
        public int ValutazioneTecnica_avanzamento { get => _valutazioneTecnica_avanzamento; set => _valutazioneTecnica_avanzamento = value; }
        public int ValutazioneTecnica_acquaticità { get => _valutazioneTecnica_acquaticità; set => _valutazioneTecnica_acquaticità = value; }
        public bool Atrezzatura_muta { get => _atrezzatura_muta; set => _atrezzatura_muta = value; }
        public bool Atrezzatura_maschera { get => _atrezzatura_maschera; set => _atrezzatura_maschera = value; }
        public bool Atrezzatura_tappanaso { get => _atrezzatura_tappanaso; set => _atrezzatura_tappanaso = value; }
        public bool Atrezzatura_zavorra { get => _atrezzatura_zavorra; set => _atrezzatura_zavorra = value; }
        public Cartellino Cartellino { get => _cartellino; set => _cartellino = value; }
        public int Penalità { get => _penalità; set => _penalità = value; }
        public float Punteggio { get => _punteggio; set => _punteggio = value; }
        public bool IsCompletata { get => _prestazioneCompletata; set => _prestazioneCompletata = value; }

        //costruttore
        public Prestazione(Disciplina disciplina)
        {
            _disciplina = disciplina;
        }

        public void CalcolaPunteggio()
        {
            if (this.IsCompletata)
            {
                ICalcolatore c = CalcolatoreFactory.GetCalcolatore(_disciplina);
                c.CalcolaPunteggio(this);
            }
            else
            {
                throw new InvalidOperationException("Errore: La prestazione non è stata ancora completata, non potrà essere calcolato il punteggio.\n");
            }
        }
    }
}