namespace ProgettoGIA.Model.Calcolatori
{
    public class CalcolatoreSTA : ICalcolatore
    {
        public const float _COEFFICENTE = 0.35F;

        public void CalcolaPunteggio(Prestazione p)
        {
            if (p.Cartellino.Equals(Cartellino.BIANCHO))
            {
                float temp = (p.Misurazione * _COEFFICENTE);

                //Valurazioni tecniche
                temp = temp + p.ValutazioneTecnica_acquaticità + p.ValutazioneTecnica_assetto + p.ValutazioneTecnica_avanzamento + p.ValutazioneTecnica_virata;

                p.Punteggio = temp;
                p.IsCompletata = true;
            }
            else if (p.Cartellino.Equals(Cartellino.GIALLO))
            {
                float temp = (p.Misurazione * _COEFFICENTE);     

                //Valurazioni tecniche
                temp = temp + p.ValutazioneTecnica_acquaticità + p.ValutazioneTecnica_assetto + p.ValutazioneTecnica_avanzamento + p.ValutazioneTecnica_virata;

                //Penalità percentuali
                temp = temp * (1 - ((float)p.Penalità / 100));

                p.Punteggio = temp;
                p.IsCompletata = true;
            }
            else if (p.Cartellino.Equals(Cartellino.ROSSO))
            {
                p.Misurazione = 0;
                p.ValutazioneTecnica_acquaticità = 0;
                p.ValutazioneTecnica_assetto = 0;
                p.ValutazioneTecnica_avanzamento = 0;
                p.ValutazioneTecnica_virata = 0;
                p.Punteggio = 0;
                p.IsCompletata = true;
            }
        }
    }
}