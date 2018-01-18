using System;
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
        Dictionary<CheckBox, Disciplina> _dictionariDiscipline; 

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

            _atletiGridView.Columns["Guid"].Visible = false;

            _dictionariDiscipline = new Dictionary<CheckBox, Disciplina>();
            _dictionariDiscipline.Add(_cnfCheckBox, Disciplina.CNF);
            _dictionariDiscipline.Add(_cwmCheckBox, Disciplina.CWM);
            _dictionariDiscipline.Add(_fioCheckBox, Disciplina.FIO);
            _dictionariDiscipline.Add(_dymCheckBox, Disciplina.DYM);
            _dictionariDiscipline.Add(_dnfCheckBox, Disciplina.DNF);
            _dictionariDiscipline.Add(_dynCheckBox, Disciplina.DYN);
            _dictionariDiscipline.Add(_cwfCheckBox, Disciplina.CNF);
            _dictionariDiscipline.Add(_staCheckBox, Disciplina.CNF);
            _dictionariDiscipline.Add(_fimCheckBox, Disciplina.CNF);
            _dictionariDiscipline.Add(_camCheckBox, Disciplina.CNF);





        }

        private void _addAtletaButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_nomeTextBox.Text) || !String.IsNullOrEmpty(_cognomeTextBox.Text) || !String.IsNullOrEmpty(((Società)_societàComboBox.SelectedItem).ToString()) || !String.IsNullOrEmpty(_codiceFiscaleTextBox.Text))
            {
                Atleta a;
                Società s = Gara.GetInstance().GetSocietàForNomeSede(((Società)_societàComboBox.SelectedItem).ToString()); //porcata!!!!

                if (_maschioRadioButton.Enabled)
                {
                    a = new Atleta(_nomeTextBox.Text, _cognomeTextBox.Text, _codiceFiscaleTextBox.Text, Sesso.MASCHIO, _dataNascitaTimePicker.Value, _istruttoreCheckBox.Checked, s, _scadenzaCertificatoTimePicker.Value, Guid.Empty);
                }
                else
                {
                    a = new Atleta(_nomeTextBox.Text, _cognomeTextBox.Text, _codiceFiscaleTextBox.Text, Sesso.FEMMINA, _dataNascitaTimePicker.Value, _istruttoreCheckBox.Checked, s, _scadenzaCertificatoTimePicker.Value, Guid.Empty);
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
                MessageBox.Show("Si stà tentando di Aggiungere un utente con dati incompleti, l'operazione non puo essere portata a termine.", "Utente incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _nomeTextBox.Clear();
            _cognomeTextBox.Clear();
            _codiceFiscaleTextBox.Clear();
            _societàComboBox.SelectedIndex = 0;
            _dataNascitaTimePicker.Value = DateTime.Now;
            _scadenzaCertificatoTimePicker.Value = DateTime.Now;
            _maschioRadioButton.Select();
            _istruttoreCheckBox.Checked = false;
        }

        private void _removeAtletaButton_Click(object sender, EventArgs e)
        {
            Atleta a = Gara.GetInstance().GetAtletaForID(_guidAtletaSelezionata);

            Gara.GetInstance().RemoveAtleta(a);

            _nomeTextBox.Clear();
            _cognomeTextBox.Clear();
            _codiceFiscaleTextBox.Clear();
            _societàComboBox.SelectedIndex = 0;
            _dataNascitaTimePicker.Value = DateTime.Now;
            _scadenzaCertificatoTimePicker.Value = DateTime.Now;
            _maschioRadioButton.Select();
            _istruttoreCheckBox.Checked = false;
        }

        private void _editAtletaButton_Click(object sender, EventArgs e)
        {
            Atleta a = Gara.GetInstance().GetAtletaForID(_guidAtletaSelezionata);

            a.Nome = _nomeTextBox.Text;
            a.Cognome = _cognomeTextBox.Text;
            a.CodiceFiscale = _codiceFiscaleTextBox.Text;

            if (_maschioRadioButton.Checked)
            {
                a.Sesso = Sesso.MASCHIO;
            }
            else
            {
                a.Sesso = Sesso.FEMMINA;
            }
            a.DataDiNascita = _dataNascitaTimePicker.Value;
            a.Istruttore = _istruttoreCheckBox.Checked;
            a.Società = (Società)_societàComboBox.SelectedItem;
            a.ScadenzaCertificato = _scadenzaCertificatoTimePicker.Value;

            _nomeTextBox.Clear();
            _cognomeTextBox.Clear();
            _codiceFiscaleTextBox.Clear();
            _societàComboBox.SelectedIndex = 0;
            _dataNascitaTimePicker.Value = DateTime.Now;
            _scadenzaCertificatoTimePicker.Value = DateTime.Now;
            _maschioRadioButton.Select();
            _istruttoreCheckBox.Checked = false;
        }

        private void _atletiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (_atletiGridView.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = _atletiGridView.Rows[rowIndex];

                _guidAtletaSelezionata = (Guid)row.Cells[0].Value;
                _nomeTextBox.Text = (string)row.Cells[1].Value;
                _cognomeTextBox.Text = (string)row.Cells[2].Value;
                _codiceFiscaleTextBox.Text = (string)row.Cells[3].Value;

                if (((Sesso)row.Cells[4].Value).Equals(Sesso.MASCHIO))
                {
                    _maschioRadioButton.Select();
                }
                else
                {
                    _femminaRadioButton.Select();
                }
                _dataNascitaTimePicker.Value = (DateTime)row.Cells[5].Value;
                _istruttoreCheckBox.Checked = (bool)row.Cells[6].Value;
                _societàComboBox.SelectedItem = (Società)row.Cells[7].Value;
                _scadenzaCertificatoTimePicker.Value = (DateTime)row.Cells[8].Value;
            }
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _nomeTextBox.Clear();
            _cognomeTextBox.Clear();
            _codiceFiscaleTextBox.Clear();
            _societàComboBox.SelectedIndex = 0;
            _dataNascitaTimePicker.Value = DateTime.Now;
            _scadenzaCertificatoTimePicker.Value = DateTime.Now;
            _maschioRadioButton.Select();
            _istruttoreCheckBox.Checked = false;
        }

        private void _aggiungiAtletiAllaGaraButton_Click(object sender, EventArgs e)
        {
             
             
        }

        private void _rimuoviAtletiDallaGaraButton_Click(object sender, EventArgs e)
        {

        }
    }
}
