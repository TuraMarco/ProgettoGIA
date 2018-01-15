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

        //costruttore
        public SpecialitàGara(Disciplina disciplina)
        {
            _disciplina = disciplina;
        }

        #region Metodi di Amministrazione

        public void AddAtleta(Atleta atleta)
        {
            if (!ExistAtleta(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    _prestazioneMaschile.Add(atleta, null);
                }
                else
                {
                    _prestazioneFemminile.Add(atleta, null);
                }
            }
        }

        public void RemoveAtleta(Atleta atleta)
        {
            if (ExistAtleta(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    _prestazioneMaschile.Remove(atleta);
                }
                else
                {
                    _prestazioneFemminile.Remove(atleta);
                }
            }
        }

        public void SetPrestazione(Atleta atleta, Prestazione prestazione)
        {
            prestazione.CalcolaPunteggio();
            if (GetPrestazione(atleta) == null)
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    _prestazioneMaschile[atleta] = prestazione;
                }
                else
                {
                    _prestazioneFemminile[atleta] = prestazione;
                }
            }
            else
            {
                throw new ArgumentException("L'atleta ha gia una prestazione per questa disciplina.\n");
            }
        }

        public Prestazione GetPrestazione(Atleta atleta)
        {
            if (ExistAtleta(atleta))
            {
                if (atleta.Sesso.Equals(Sesso.MASCHIO))
                {
                    foreach (KeyValuePair<Atleta, Prestazione> pm in _prestazioneMaschile)
                    {
                        if (pm.Key.Guid.Equals(atleta.Guid))
                        {
                            return pm.Value;
                        }
                    }
                    throw new ArgumentException("L'atleta non è iscritto alla specialità di gara.\n");
                }
                else
                {
                    foreach (KeyValuePair<Atleta, Prestazione> pf in _prestazioneFemminile)
                    {
                        if (pf.Key.Guid.Equals(atleta.Guid))
                        {
                            return pf.Value;
                        }
                    }
                    throw new ArgumentException("L'atleta non è iscritto alla specialità di gara.\n");
                }
            }
            else
            {
                throw new ArgumentException("L'atleta non è iscritto alla specialità di gara.\n");
            }
        }

        public List<Atleta> GetAllAtleti()
        {
            return new List<Atleta>(_prestazioneMaschile.Keys.Concat(_prestazioneFemminile.Keys));
        }

        #endregion
        #region Matodi di Utilità
        public bool ExistAtleta(Atleta atleta)
        {
            bool exist = false;

            if (atleta.Sesso.Equals(Sesso.MASCHIO))
            {
                foreach (Atleta a in _prestazioneMaschile.Keys)
                {
                    if (a.Guid.Equals(atleta.Guid))
                    {
                        exist = true;
                    }
                }
            }
            else
            {
                foreach (Atleta a in _prestazioneFemminile.Keys)
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