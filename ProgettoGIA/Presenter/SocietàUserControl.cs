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
    public partial class SocietàUserControl : UserControl
    {
        Guid _guidSocietàSelezionata;
        SocietàDataGridViewPresenter _societàDataGridViewPresenter;


        public SocietàUserControl()
        {
            InitializeComponent();
        }

        public DataGridView SocietàDataGrid => _societàGridView;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _societàDataGridViewPresenter = new SocietàDataGridViewPresenter(_societàGridView);
        }

        private void _addSocietàButton_Click(object sender, EventArgs e)
        {
            if(_nomeSocietàTextBox.Text.Length != 0 || _sedeSocietàTextBox.Text.Length != 0)
            {
                Gara g = Gara.GetInstance();
                g.AddSocietà(new Società(_nomeSocietàTextBox.Text, _sedeSocietàTextBox.Text, Guid.Empty));
            }
            _nomeSocietàTextBox.Clear();
            _sedeSocietàTextBox.Clear();
        }

        private void _removeSocietàButton_Click(object sender, EventArgs e)
        {
            Gara.GetInstance().RemoveSocietà(Gara.GetInstance().GetSocietàForID(_guidSocietàSelezionata));
        }

        private void _societàGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_societàGridView.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = _societàGridView.Rows[rowIndex];
               

                _nomeSocietàTextBox.Text = (string)row.Cells[0].Value;
                _sedeSocietàTextBox.Text = (string)row.Cells[1].Value;
                _guidSocietàSelezionata = (Guid)row.Cells[2].Value;
            }
        }
    }
}