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
        Dictionary<Disciplina, CheckBox> _dictionariDiscipline; 

        public AtletiUserControl()
        {
            InitializeComponent();
        }

        //properti
        public DataGridView AtletaDataGrid => _atletiGridView;
        public Dictionary<Disciplina, CheckBox> DizionarioCheckBoxDiscipline => _dictionariDiscipline;

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

            _dictionariDiscipline = new Dictionary<Disciplina, CheckBox>();
            _dictionariDiscipline.Add(Disciplina.CNF, _cnfCheckBox);
            _dictionariDiscipline.Add(Disciplina.CWM, _cwmCheckBox);
            _dictionariDiscipline.Add(Disciplina.FIO, _fioCheckBox);
            _dictionariDiscipline.Add(Disciplina.DYM, _dymCheckBox);
            _dictionariDiscipline.Add(Disciplina.DNF, _dnfCheckBox);
            _dictionariDiscipline.Add(Disciplina.DYN, _dynCheckBox);
            _dictionariDiscipline.Add(Disciplina.CWF, _cwfCheckBox);
            _dictionariDiscipline.Add(Disciplina.STA, _staCheckBox);
            _dictionariDiscipline.Add(Disciplina.FIM, _fimCheckBox);
            _dictionariDiscipline.Add(Disciplina.CAM, _camCheckBox);

            foreach (KeyValuePair<Disciplina, CheckBox> kvp in _dictionariDiscipline)
            {
                kvp.Value.Enabled = false;
            }

            _iscrizioneGaraGroupBox.Enabled = false;
            _atletiGridView.CurrentCell = null;

            Gara.GetInstance().Changed += RefreshCheckBoxList;
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
            if (_atletiGridView.CurrentCell == null)
            {
                MessageBox.Show("Si sta tentando di eliminare un atleta senza che sia selezionata, ritenta.", "Nessun atleta selezionata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            _atletiGridView.CurrentCell = null;
        }

        private void _editAtletaButton_Click(object sender, EventArgs e)
        {
            if (_atletiGridView.CurrentCell == null)
            {
                MessageBox.Show("Si sta tentando di editare un atleta senza che sia selezionata, ritenta.", "Nessun atleta selezionata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            _atletiGridView.CurrentCell = null;
        }

        private void _atletiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (_atletiGridView.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                if(rowIndex < 0)
                {
                    return;
                }

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

                if (_guidAtletaSelezionata != null) { _iscrizioneGaraGroupBox.Enabled = true; }
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
            _iscrizioneGaraGroupBox.Enabled = false;
        }

        private void _aggiungiAtletiAllaGaraButton_Click(object sender, EventArgs e)
        {
            List<Disciplina> temp = new List<Disciplina>();

            if (_guidAtletaSelezionata != null)
            {
                foreach (KeyValuePair<Disciplina, CheckBox> kvp in _dictionariDiscipline )
                {
                    if (kvp.Value.Checked)
                    {
                        temp.Add(kvp.Key);
                    }
                }
            }

            Gara.GetInstance().AddAtletaToGara(Gara.GetInstance().GetAtletaForID(_guidAtletaSelezionata), temp); 
        }

        private void _rimuoviAtletiDallaGaraButton_Click(object sender, EventArgs e)
        {
            if (_guidAtletaSelezionata != null)
            {
                Gara.GetInstance().RemoveAtletaToGara(Gara.GetInstance().GetAtletaForID(_guidAtletaSelezionata));
            }
        }

        private void RefreshCheckBoxList(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Disciplina, CheckBox> kvp in _dictionariDiscipline)
            {
                if (Gara.GetInstance().GetSpecialitàGaraForDisciplina(kvp.Key) != null)
                {
                    kvp.Value.Enabled = true;
                }
                else
                {
                    kvp.Value.Enabled = false;
                }
            }
        }
    }
}
