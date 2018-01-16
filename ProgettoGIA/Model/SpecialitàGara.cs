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
                    _prestazioneMaschile.Add(atleta, new Prestazione(_disciplina));
                }
                else
                {
                    _prestazioneFemminile.Add(atleta, new Prestazione(_disciplina));
                }
            }
        }

        public void RemoveAtleta(Atleta atleta)
        {
            if (ExistAtletaInSG(atleta))
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
            if (GetPrestazione(atleta).Punteggio == 0)
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
                throw new InvalidOperationException("Errore: L'atleta ha gia associata una prestazione alla disciplina" + _disciplina + ".\n");
            }
        }

        public Prestazione GetPrestazione(Atleta atleta)
        {
            if (ExistAtletaInSG(atleta))
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
                }
            }

            throw new InvalidOperationException("Errore: L'atleta non partecipa alla disciplina" + _disciplina + ".\n");
            
        }

        public List<Atleta> GetAllAtleti()
        {
            return new List<Atleta>(_prestazioneMaschile.Keys.Concat(_prestazioneFemminile.Keys));
        }

        #endregion
        #region Matodi di Utilità
        public bool ExistAtletaInSG(Atleta atleta)
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