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
    public partial class SocietàUserControl : UserControl
    {
        Guid _guidSocietàSelezionata;
        SocietàDataGridViewPresenter _societàDataGridViewPresenter;


        public SocietàUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _societàDataGridViewPresenter = new SocietàDataGridViewPresenter(_societàGridView);
            _societàGridView.CurrentCell = null;
            _societàGridView.Columns["Guid"].Visible = false;

        }

        private void _addSocietàButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(_nomeSocietàTextBox.Text) || !String.IsNullOrEmpty(_sedeSocietàTextBox.Text))
            {
                Gara g = Gara.GetInstance();
                g.AddSocietà(new Società(_nomeSocietàTextBox.Text, _sedeSocietàTextBox.Text, Guid.Empty));
            }
            _nomeSocietàTextBox.Clear();
            _sedeSocietàTextBox.Clear();
        }

        private void _removeSocietàButton_Click(object sender, EventArgs e)
        {
            if (_societàGridView.CurrentCell == null)
            {
                MessageBox.Show("Si sta tentando di eliminare una società senza che sia selezionata, ritenta.", "Nessuna società selezionata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Società s = Gara.GetInstance().GetSocietàForID(_guidSocietàSelezionata);
            if (Gara.GetInstance().SocietàPossiedeAtleti(s))
            {
                MessageBox.Show("Si stà tentando di eliminare una società a cui sono associati degli atleti, l'operazione non puo essere portata a termine.", "Società associata ad Atleti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Gara.GetInstance().RemoveSocietà(s);

            _nomeSocietàTextBox.Clear();
            _sedeSocietàTextBox.Clear();

            _societàGridView.CurrentCell = null;
        }

        private void _editSocietàButton_Click(object sender, EventArgs e)
        {
            if (_societàGridView.CurrentCell == null)
            {
                MessageBox.Show("Si sta tentando di editare una società senza che sia selezionata, ritenta.", "Nessuna società selezionata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Società s = Gara.GetInstance().GetSocietàForID(_guidSocietàSelezionata);
            s.Nome = _nomeSocietàTextBox.Text;
            s.Sede = _sedeSocietàTextBox.Text;

            _nomeSocietàTextBox.Clear();
            _sedeSocietàTextBox.Clear();

            _societàGridView.CurrentCell = null;
        }

        private void _societàGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_societàGridView.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                if (rowIndex < 0)
                    return;

                DataGridViewRow row = _societàGridView.Rows[rowIndex];
               

                _nomeSocietàTextBox.Text = (string)row.Cells[0].Value;
                _sedeSocietàTextBox.Text = (string)row.Cells[1].Value;
                _guidSocietàSelezionata = (Guid)row.Cells[2].Value;
            }
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _nomeSocietàTextBox.Clear();
            _sedeSocietàTextBox.Clear();
        }
    }
}