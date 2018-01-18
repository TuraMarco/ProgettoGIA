using ProgettoGIA.Model;
using System;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    internal class AtletaDataGridViewPresenter : Presenter<DataGridView>
    {
        private readonly DataGridView _dataGridView;

        public AtletaDataGridViewPresenter(DataGridView atletiGridView) : base(atletiGridView)
        {
            if (atletiGridView == null)
            {
                throw new ArgumentNullException("AtletiDataGridView");
            }
            _dataGridView = atletiGridView;
        }

        protected override void InitializeControl()
        {
            Control.DataSource = Gara.GetInstance().Atleti;
        }

        protected override void RefreshControl()
        {
            Control.DataSource = null;
            Control.DataSource = Gara.GetInstance().Atleti;
            _dataGridView.Columns["Guid"].Visible = false;
        }
    }
}