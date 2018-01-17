using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    public abstract class Presenter<TControl> where TControl : Control
    {
        private readonly TControl _control;
        private readonly Gara _gara;

        public Presenter(TControl control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }
            
            _control = control;
            _gara = Gara.GetInstance();
            _gara.Changed += OnGaraChanged;
            InitializeControl();
        }

        public TControl Control
        {
            get { return _control; }
        }

        private void OnGaraChanged(object sender, EventArgs e)
        {
            RefreshControl();
        }

        protected virtual void InitializeControl(){}

        protected abstract void RefreshControl();
    }
}
