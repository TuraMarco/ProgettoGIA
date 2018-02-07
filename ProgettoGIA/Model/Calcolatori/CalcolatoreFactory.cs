using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGIA.Model.Calcolatori
{
    public static class CalcolatoreFactory
    {
        //campo
        private static readonly Dictionary<Disciplina, ICalcolatore> _calcolatori = new Dictionary<Disciplina, ICalcolatore>();

        #region Metodi

        public static ICalcolatore GetCalcolatore(Disciplina d)
        {
            if (!_calcolatori.ContainsKey(d))
            {
                _calcolatori.Add(d, CreateInstance(d));
            }
            return _calcolatori[d];
        }

        public static IEnumerable<ICalcolatore> GetCalcolatori() //non viene mai usata
        {
            return _calcolatori.Values;
        }

        private static ICalcolatore CreateInstance(Disciplina d)
        {
            switch (d)
            {
                case Disciplina.STA:
                    return new CalcolatoreSTA();
                case Disciplina.DYN:
                    return new CalcolatoreDYN();
                case Disciplina.DYM:
                    return new CalcolatoreDYM();
                case Disciplina.DNF:
                    return new CalcolatoreDNF();
                case Disciplina.FIO:
                    return new CalcolatoreFIO();
                case Disciplina.CWF:
                    return new CalcolatoreCWF();
                case Disciplina.CWM:
                    return new CalcolatoreCWM();
                case Disciplina.CNF:
                    return new CalcolatoreCNF();
                case Disciplina.FIM:
                    return new CalcolatoreFIM();
                case Disciplina.CAM:
                    return new CalcolatoreCAM();
                default:
                    throw new ArgumentException();
            }
        }

        #endregion
    }
}
