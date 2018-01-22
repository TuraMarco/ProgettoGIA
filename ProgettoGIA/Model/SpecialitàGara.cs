using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgettoGIA.Model
{
    public class SpecialitàGara
    {
        //campi
        private readonly Disciplina _disciplina;
        private readonly Dictionary<Atleta, Prestazione> _prestazioneMaschile;
        private readonly Dictionary<Atleta, Prestazione> _prestazioneFemminile;

        //property
        public Disciplina Disciplina => _disciplina;
        public Dictionary<Atleta, Prestazione> PrestazioneMaschile => _prestazioneMaschile;
        public Dictionary<Atleta, Prestazione> PrestazioneFemminile => _prestazioneFemminile;

        //costruttore
        public SpecialitàGara(Disciplina disciplina)
        {
            _disciplina = disciplina;
            _prestazioneMaschile = new Dictionary<Atleta, Prestazione>();
            _prestazioneFemminile = new Dictionary<Atleta, Prestazione>();
        }

        #region Metodi di Amministrazione

        public void AddAtleta(Atleta atleta)
        {
            if (!ExistAtletaInSG(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    PrestazioneMaschile.Add(atleta, new Prestazione(_disciplina));
                }
                else
                {
                    PrestazioneFemminile.Add(atleta, new Prestazione(_disciplina));
                }
            }
        }

        public void RemoveAtleta(Atleta atleta)
        {
            if (ExistAtletaInSG(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    PrestazioneMaschile.Remove(atleta);
                }
                else
                {
                    PrestazioneFemminile.Remove(atleta);
                }
            }
        }

        public void SetPrestazione(Atleta atleta, Prestazione prestazione)
        {
            prestazione.CalcolaPunteggio();
            if (GetPrestazione(atleta).Punteggio == 0)
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    PrestazioneMaschile[atleta] = prestazione;
                }
                else
                {
                    PrestazioneFemminile[atleta] = prestazione;
                }
            }
            else
            {
                throw new InvalidOperationException("Errore: L'atleta ha gia associata una prestazione alla disciplina" + _disciplina + ".\n");
            }
        }

        public Prestazione GetPrestazione(Atleta atleta)
        {
            if (ExistAtletaInSG(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    foreach (KeyValuePair<Atleta, Prestazione> pm in PrestazioneMaschile)
                    {
                        if (pm.Key.Guid.Equals(atleta.Guid))
                        {
                            return pm.Value;
                        }
                    }
                }
                else
                {
                    foreach (KeyValuePair<Atleta, Prestazione> pf in PrestazioneFemminile)
                    {
                        if (pf.Key.Guid.Equals(atleta.Guid))
                        {
                            return pf.Value;
                        }
                    }
                }
            }

            throw new InvalidOperationException("Errore: L'atleta non partecipa alla disciplina" + _disciplina + ".\n");
            
        }

        public List<Atleta> GetAllAtleti()
        {
            return new List<Atleta>(PrestazioneMaschile.Keys.Concat(PrestazioneFemminile.Keys));
        }

        #endregion
        #region Matodi di Utilità
        public bool ExistAtletaInSG(Atleta atleta)
        {
            bool exist = false;

            if (atleta.Sesso.Equals(Sesso.MASCHIO))
            {
                foreach (Atleta a in PrestazioneMaschile.Keys)
                {
                    if (a.Guid.Equals(atleta.Guid))
                    {
                        exist = true;
                    }
                }
            }
            else
            {
                foreach (Atleta a in PrestazioneFemminile.Keys)
                {
                    if (a.Guid.Equals(atleta.Guid))
                    {
                        exist = true;
                    }
                }
            }

            return exist;
        }
        #endregion
    }
}