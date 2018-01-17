﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoGIA.Model;

namespace ProgettoGIA.Presenter
{
    public partial class AtletiUserControl : UserControl
    {
        Guid _guidAtletaSelezionata;
        AtletaDataGridViewPresenter _atletaDataGridViewPresenter;

        public AtletiUserControl()
        {
            InitializeComponent();
        }

        public DataGridView AtletaDataGrid => _atletiGridView;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _maschioRadioButton.Enabled = true;
            _atletaDataGridViewPresenter = new AtletaDataGridViewPresenter(_atletiGridView);
            _societàComboBox.Items.Add("");
            foreach (Società s in Gara.GetInstance().Società)
            {
                _societàComboBox.Items.Add(s);
            }
            _societàComboBox.SelectedIndex = 0;
        }

        private void _addAtletaButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_nomeTextBox.Text) || !String.IsNullOrEmpty(_cognomeTextBox.Text) || !String.IsNullOrEmpty(((Società)_societàComboBox.SelectedItem).ToString()) || !String.IsNullOrEmpty(_codiceFiscaleTextBox.Text))
            {
                Atleta a;
                Società s = Gara.GetInstance().GetSocietàForNomeSede(((Società)_societàComboBox.SelectedItem).ToString()); //porcata!!!!

                if (_maschioRadioButton.Enabled)
                {
                    a = new Atleta(_nomeTextBox.Text, _cognomeTextBox.Text, _codiceFiscaleTextBox.Text, Sesso.MASCHIO, _dataNascitaTimePicker.Value, _istruttoreCheckBox.Enabled, s, _scadenzaCertificatoTimePicker.Value, Guid.Empty);
                }
                else
                {
                    a = new Atleta(_nomeTextBox.Text, _cognomeTextBox.Text, _codiceFiscaleTextBox.Text, Sesso.FEMMINA, _dataNascitaTimePicker.Value, _istruttoreCheckBox.Enabled, s, _scadenzaCertificatoTimePicker.Value, Guid.Empty);
                }

                if (a.IsEtàInferiore14())
                {
                    MessageBox.Show("L'atleta che si stà tentando di inserire ha meno di 14 anni, quindi l'operazione non può essere completata.", "Atleta con età inferiore a 14 anni", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (a.IsEtàInferiore18())
                {
                    MessageBox.Show("L'atleta che si stà tentando di inserire ha meno di 18 anni, richiedere autorizzazione di un tutore prima di completare l'inserimento.", "Atleta con età inferiore a 18 anni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    Gara g = Gara.GetInstance();
                    g.AddAtleta(a);
                }
            }
            else
            {
                return;
            }

            _nomeTextBox.Clear();
            _cognomeTextBox.Clear();
            _codiceFiscaleTextBox.Clear();
            _societàComboBox.SelectedIndex = 0;
            _dataNascitaTimePicker.Value = DateTime.Now;
            _scadenzaCertificatoTimePicker.Value = DateTime.Now;
            _maschioRadioButton.Enabled = true;
            _istruttoreCheckBox.Enabled = false;
        }
    }
}
