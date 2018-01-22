using ProgettoGIA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    internal class GaraDataGridViewPresenter
    {
        //campi
        private DataGridView _garaDataGridView;

        //costruttore
        public GaraDataGridViewPresenter(DataGridView garaDataGridView, TreeView garaTreeView)
        {
            if (garaDataGridView == null || garaTreeView == null)
            {
                throw new ArgumentNullException("GaraDataGridView");
            }

            _garaDataGridView = garaDataGridView;
            garaTreeView.AfterSelect += RefreshDataGridView;
        }


        private void RefreshDataGridView(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Sesso)
            {
                return;
            }

            SpecialitàGara sg = Gara.GetInstance().GetSpecialitàGaraForDisciplina((Disciplina)e.Node.Tag);
            Console.Write(sg.PrestazioneFemminile.Keys.GetType());

            if (e.Node.Parent.Tag.Equals(Sesso.MASCHIO))
            {
                _garaDataGridView.DataSource = sg.PrestazioneMaschile.Keys.ToList();
            }
            else if (e.Node.Parent.Tag.Equals(Sesso.FEMMINA))
            {
                _garaDataGridView.DataSource = sg.PrestazioneFemminile.Keys.ToList();
            }

            _garaDataGridView.Columns["Guid"].Visible = false;
            _garaDataGridView.Columns["Sesso"].Visible = false;
            _garaDataGridView.Columns["Istruttore"].Visible = false;
            _garaDataGridView.Columns["ScadenzaCertificato"].Visible = false;

        }
    }
}