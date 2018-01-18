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
        public GaraUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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
    }
}
