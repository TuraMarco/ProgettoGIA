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
    public partial class GaraUserControl : UserControl
    {
        private GaraTreeViewPresenter _garaTreeViewPresenter;
        private GaraDataGridViewPresenter _garaDataGridViewPresenter;

        private Guid _selectedAtletaGuid;
        private SpecialitàGara _selectedSpecialitàGara;
        private Sesso _selectedSesso;

        public GaraUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _specialitàComboBox.Items.Add(Disciplina.STA);
            _specialitàComboBox.Items.Add(Disciplina.DYN);
            _specialitàComboBox.Items.Add(Disciplina.DYM);
            _specialitàComboBox.Items.Add(Disciplina.DNF);
            _specialitàComboBox.Items.Add(Disciplina.FIO);
            _specialitàComboBox.Items.Add(Disciplina.CWF);
            _specialitàComboBox.Items.Add(Disciplina.CWM);
            _specialitàComboBox.Items.Add(Disciplina.CNF);
            _specialitàComboBox.Items.Add(Disciplina.FIM);
            _specialitàComboBox.Items.Add(Disciplina.CAM);

            _garaTreeViewPresenter = new GaraTreeViewPresenter(_garaTreeView);
            _garaDataGridViewPresenter = new GaraDataGridViewPresenter(_garaDataGridView, _garaTreeView);
        }

        private void _addSpecialitàButton_Click(object sender, EventArgs e)
        {
            Disciplina d = (Disciplina)_specialitàComboBox.SelectedItem;
            if (Gara.GetInstance().GetSpecialitàGaraForDisciplina(d) == null)
            {
                Gara.GetInstance().AddSpecialitàGara(d);
            }
            else
            {
                MessageBox.Show("Si sta tentando di inserire una disciplina già presente nella gara o sconosciuta, l'operazione verrà interrotta.", "Disciplina già presente in gara", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _removeSpecialitàButton_Click(object sender, EventArgs e)
        {
            Disciplina d = (Disciplina)_specialitàComboBox.SelectedItem;
            if (Gara.GetInstance().GetSpecialitàGaraForDisciplina(d) != null)
            {
                Gara.GetInstance().RemoveSpecialitàGara(d);
            }
            else
            {
                MessageBox.Show("Si sta tentando di eliminare una disciplina non presente nella gara o sconosciuta, l'operazione verrà interrotta.", "Disciplina non presente in gara", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _biancoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _penalitàUpDown.Enabled = false;

            _misurazioneUpDown.Enabled = true;
            _assettoUpDown.Enabled = true;
            _virataUpDown.Enabled = true;
            _avanzamentoUpDown.Enabled = true;
            _acquaticitàUpDown.Enabled = true;
            _mutaCheckBox.Enabled = true;
            _mascheraCheckBox.Enabled = true;
            _tappanasoCheckBox.Enabled = true;
            _zavorraCheckBox.Enabled = true;
        }

        private void _gialloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _penalitàUpDown.Enabled = true;

            _misurazioneUpDown.Enabled = true;
            _assettoUpDown.Enabled = true;
            _virataUpDown.Enabled = true;
            _avanzamentoUpDown.Enabled = true;
            _acquaticitàUpDown.Enabled = true;
            _mutaCheckBox.Enabled = true;
            _mascheraCheckBox.Enabled = true;
            _tappanasoCheckBox.Enabled = true;
            _zavorraCheckBox.Enabled = true;
        }

        private void _rossoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _misurazioneUpDown.Enabled = false;
            _assettoUpDown.Enabled = false;
            _virataUpDown.Enabled = false;
            _avanzamentoUpDown.Enabled = false;
            _acquaticitàUpDown.Enabled = false;
            _mutaCheckBox.Enabled = false;
            _mascheraCheckBox.Enabled = false;
            _tappanasoCheckBox.Enabled = false;
            _zavorraCheckBox.Enabled = false;
            _penalitàUpDown.Enabled = false;
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _misurazioneUpDown.Value = 0; ;
            _assettoUpDown.Value = 1;
            _virataUpDown.Value = 1;
            _avanzamentoUpDown.Value = 1;
            _acquaticitàUpDown.Value = 1;
            _mutaCheckBox.Checked = false;
            _mascheraCheckBox.Checked = false;
            _tappanasoCheckBox.Checked = false;
            _zavorraCheckBox.Checked = false;
            _biancoRadioButton.Checked = true;
            _penalitàUpDown.Value = 0;
            _punteggioTextBox.Clear();
        }

        private void _specialitàComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gara g = Gara.GetInstance();

            if (g.SpecialitàGara.Contains(g.GetSpecialitàGaraForDisciplina((Disciplina)_specialitàComboBox.SelectedItem)))
            {
                _addSpecialitàButton.Enabled = false;
                _removeSpecialitàButton.Enabled = true;
            }
            else
            {
                _addSpecialitàButton.Enabled = true;
                _removeSpecialitàButton.Enabled = false;
            }
        }

        private void _garaTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Sesso)
            {
                return;
            }

            Disciplina disciplinaSelected = ((Disciplina)e.Node.Tag);
            _selectedSpecialitàGara = Gara.GetInstance().GetSpecialitàGaraForDisciplina(disciplinaSelected);
            _selectedSesso = (Sesso)e.Node.Parent.Tag;

            if (disciplinaSelected.Equals(Disciplina.STA))
            {
                _misurazioneLabel.Text = "MISURAZIONE (secondi)";
            }
            else
            {
                _misurazioneLabel.Text = "MISURAZIONE (metri)";
            }
        }

        private void _garaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clearButton_Click(this, new EventArgs());

            int rowIndex = e.RowIndex;
            DataGridViewRow row = _garaDataGridView.Rows[rowIndex];

            _selectedAtletaGuid = (Guid)row.Cells[0].Value;

            AggiornaPrestazione();

            _nomeTextBox.Text = row.Cells[1].Value.ToString();
            _cognomeTextBox.Text = row.Cells[2].Value.ToString();
            _dataNascitaTextBox.Text = ((DateTime)row.Cells[5].Value).ToShortDateString();
            _cfTextBox.Text = row.Cells[3].Value.ToString();
            _societàTextBox.Text = row.Cells[7].Value.ToString();

            Atleta a = Gara.GetInstance().GetAtletaForID(_selectedAtletaGuid);
        }

        private void _calcolaPunteggioButton_Click(object sender, EventArgs e)
        {
            Atleta a = Gara.GetInstance().GetAtletaForID(_selectedAtletaGuid);

            if (_selectedSesso.Equals(Sesso.MASCHIO))
            {
                Prestazione p = _selectedSpecialitàGara.PrestazioneMaschile[a];

                p.Misurazione = (float)_misurazioneUpDown.Value;
                p.ValutazioneTecnica_assetto = (int)_assettoUpDown.Value;
                p.ValutazioneTecnica_virata = (int)_virataUpDown.Value;
                p.ValutazioneTecnica_avanzamento = (int)_avanzamentoUpDown.Value;
                p.ValutazioneTecnica_acquaticità = (int)_acquaticitàUpDown.Value;
                p.Atrezzatura_muta = _mutaCheckBox.Checked;
                p.Atrezzatura_maschera = _mascheraCheckBox.Checked;
                p.Atrezzatura_tappanaso = _tappanasoCheckBox.Checked;
                p.Atrezzatura_zavorra = _zavorraCheckBox.Checked;

                if (_biancoRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.BIANCHO;
                }
                else if (_gialloRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.GIALLO;
                    p.Penalità = (int)_penalitàUpDown.Value;
                }
                else if (_rossoRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.ROSSO;
                }

                p.CalcolaPunteggio();
                _punteggioTextBox.Text = p.Punteggio.ToString();
            }
            else
            {
                Prestazione p = _selectedSpecialitàGara.PrestazioneFemminile[a];

                p.Misurazione = (float)_misurazioneUpDown.Value;
                p.ValutazioneTecnica_assetto = (int)_assettoUpDown.Value;
                p.ValutazioneTecnica_virata = (int)_virataUpDown.Value;
                p.ValutazioneTecnica_avanzamento = (int)_avanzamentoUpDown.Value;
                p.ValutazioneTecnica_acquaticità = (int)_acquaticitàUpDown.Value;
                p.Atrezzatura_muta = _mutaCheckBox.Checked;
                p.Atrezzatura_maschera = _mascheraCheckBox.Checked;
                p.Atrezzatura_tappanaso = _tappanasoCheckBox.Checked;
                p.Atrezzatura_zavorra = _zavorraCheckBox.Checked;

                if (_biancoRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.BIANCHO;
                }
                else if (_gialloRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.GIALLO;
                    p.Penalità = (int)_penalitàUpDown.Value;
                }
                else if (_rossoRadioButton.Checked)
                {
                    p.Cartellino = Cartellino.ROSSO;
                }

                p.CalcolaPunteggio();
                _punteggioTextBox.Text = p.Punteggio.ToString();
            }
        }

        private void AggiornaPrestazione()
        {
            Atleta a = Gara.GetInstance().GetAtletaForID(_selectedAtletaGuid);

            if (_selectedSesso.Equals(Sesso.MASCHIO))
            {
                Prestazione p = _selectedSpecialitàGara.PrestazioneMaschile[a];

                if (p.IsCompletata)
                {
                    _misurazioneUpDown.Value = (Decimal)p.Misurazione;
                    _assettoUpDown.Value = p.ValutazioneTecnica_assetto;
                    _virataUpDown.Value = p.ValutazioneTecnica_virata;
                    _avanzamentoUpDown.Value = p.ValutazioneTecnica_avanzamento;
                    _acquaticitàUpDown.Value = p.ValutazioneTecnica_acquaticità;

                    _mutaCheckBox.Checked = p.Atrezzatura_muta;
                    _mascheraCheckBox.Checked = p.Atrezzatura_maschera;
                    _tappanasoCheckBox.Checked = p.Atrezzatura_tappanaso;
                    _zavorraCheckBox.Checked = p.Atrezzatura_zavorra;

                    if (p.Cartellino.Equals(Cartellino.BIANCHO))
                    {
                        _biancoRadioButton.Checked = true;
                    }
                    else if (p.Cartellino.Equals(Cartellino.GIALLO))
                    {
                        _gialloRadioButton.Checked = true;
                        _penalitàUpDown.Value = p.Penalità;
                    }
                    else if (p.Cartellino.Equals(Cartellino.ROSSO))
                    {
                        _rossoRadioButton.Checked = true;
                    }

                    _punteggioTextBox.Text = p.Punteggio.ToString();
                }    
            }
            else
            {
                Prestazione p = _selectedSpecialitàGara.PrestazioneFemminile[a];

                if (p.IsCompletata)
                {
                    _misurazioneUpDown.Value = (Decimal)p.Misurazione;
                    _assettoUpDown.Value = p.ValutazioneTecnica_assetto;
                    _virataUpDown.Value = p.ValutazioneTecnica_virata;
                    _avanzamentoUpDown.Value = p.ValutazioneTecnica_avanzamento;
                    _acquaticitàUpDown.Value = p.ValutazioneTecnica_acquaticità;

                    _mutaCheckBox.Checked = p.Atrezzatura_muta;
                    _mascheraCheckBox.Checked = p.Atrezzatura_maschera;
                    _tappanasoCheckBox.Checked = p.Atrezzatura_tappanaso;
                    _zavorraCheckBox.Checked = p.Atrezzatura_zavorra;

                    if (p.Cartellino.Equals(Cartellino.BIANCHO))
                    {
                        _biancoRadioButton.Checked = true;
                    }
                    else if (p.Cartellino.Equals(Cartellino.GIALLO))
                    {
                        _gialloRadioButton.Checked = true;
                        _penalitàUpDown.Value = p.Penalità;
                    }
                    else if (p.Cartellino.Equals(Cartellino.ROSSO))
                    {
                        _rossoRadioButton.Checked = true;
                    }

                    _punteggioTextBox.Text = p.Punteggio.ToString();
                }
            }
        }
    }
}
