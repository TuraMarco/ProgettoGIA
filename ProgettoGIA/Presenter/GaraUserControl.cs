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
            _garaDataGridViewPresenter = new GaraDataGridViewPresenter(_garaDataGridView);
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
            _penalitàTextBox.Enabled = false;

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
            _penalitàTextBox.Enabled = true;

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
            _penalitàTextBox.Enabled = false;
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
            _penalitàTextBox.Clear();
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

            if (disciplinaSelected.Equals(Disciplina.STA))
            {
                _misurazioneLabel.Text = "MISURAZIONE (secondi)";
            }
            else
            {
                _misurazioneLabel.Text = "MISURAZIONE (metri)";
            }
        }
    }
}
