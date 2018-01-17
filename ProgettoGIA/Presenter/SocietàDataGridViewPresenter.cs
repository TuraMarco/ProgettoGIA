using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    class SocietàDataGridViewPresenter : Presenter<DataGridView>
    {
        private readonly DataGridView _dataGridView;

        public SocietàDataGridViewPresenter(DataGridView dataGridView) : base(dataGridView)
        {
            if (dataGridView == null)
            {
                throw new ArgumentNullException("SocietàDataGridView");
            }
            _dataGridView = dataGridView;
        }

        protected override void InitializeControl()
        {
            Control.DataSource = Gara.GetInstance().Società;
        }

        protected override void RefreshControl()
        {
            Control.DataSource = null;
            Control.DataSource = Gara.GetInstance().Società;
        }
    }
}
