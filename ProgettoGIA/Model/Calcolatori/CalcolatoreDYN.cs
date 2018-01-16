namespace ProgettoGIA.Model.Calcolatori
{
    public class CalcolatoreDYN : ICalcolatore
    {
        private const float _COEFFICENTE = 1.2F;
        private const int _BONUS = 15;

        public void CalcolaPunteggio(Prestazione p)
        {
            if (p.Cartellino.Equals(Cartellino.BIANCHO))
            {
                float temp = (p.Misurazione * _COEFFICENTE) + _BONUS;

                //Atrezzature
                if (p.Atrezzatura_maschera)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_muta)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_tappanaso)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_zavorra)
                {
                    temp -= 5;
                }

                //Valurazioni tecniche
                temp = temp + p.ValutazioneTecnica_acquaticità + p.ValutazioneTecnica_assetto + p.ValutazioneTecnica_avanzamento + p.ValutazioneTecnica_virata;

                p.Punteggio = temp;
                p.IsCompletata = true;
            }
            else if (p.Cartellino.Equals(Cartellino.GIALLO))
            {
                float temp = (p.Misurazione * _COEFFICENTE) + _BONUS;

                //Atrezzature
                if (p.Atrezzatura_maschera)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_muta)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_tappanaso)
                {
                    temp -= 5;
                }
                if (p.Atrezzatura_zavorra)
                {
                    temp -= 5;
                }

                //Valurazioni tecniche
                temp = temp + p.ValutazioneTecnica_acquaticità + p.ValutazioneTecnica_assetto + p.ValutazioneTecnica_avanzamento + p.ValutazioneTecnica_virata;

                //Penalità percentuali
                temp = temp - (temp * (1 + p.Penalità));

                p.Punteggio = temp;
                p.IsCompletata = true;
            }
            else if (p.Cartellino.Equals(Cartellino.ROSSO))
            {
                p.Punteggio = 0;
                p.ValutazioneTecnica_acquaticità = 0;
                p.ValutazioneTecnica_assetto = 0;
                p.ValutazioneTecnica_avanzamento = 0;
                p.ValutazioneTecnica_virata = 0;
                p.Misurazione = 0;
                p.IsCompletata = true;
            }
        }
    }
}