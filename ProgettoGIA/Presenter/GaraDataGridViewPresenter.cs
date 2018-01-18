using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    internal class GaraDataGridViewPresenter
    {
        //campi
        private TreeView _garaMaschileTreeView;
        private TreeView _garaFemminileTreeView;

        //costruttore
        public GaraDataGridViewPresenter(TreeView garaMaschileTreeView, TreeView garaFemminileTreeView)
        {
            if (garaMaschileTreeView == null || garaFemminileTreeView == null)
            {
                throw new ArgumentNullException("GaraMaschileDataGridViewPresenter");
            }

            Gara.GetInstance().Changed += Documento_Changed;

            //gara maschile
            _garaMaschileTreeView = garaMaschileTreeView;
            _garaMaschileTreeView.AfterSelect += GaraTreeView_AfterSelect;

            //gara femminile
            _garaFemminileTreeView = garaFemminileTreeView;
            _garaFemminileTreeView.AfterSelect += GaraTreeView_AfterSelect;

            RefreshTreeView();
        }

        private void GaraTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
        }

        //property
        public TreeView GaraMaschileTreeView
        {
            get { return _garaMaschileTreeView; }
        }
        public TreeView GaraFemminileTreeView
        {
            get { return _garaFemminileTreeView; }
        }
        public SpecialitàGara SpecialitàGaraMaschileCorrente
        {
            get
            {
                return (SpecialitàGara)((_garaMaschileTreeView.SelectedNode != null) ? _garaMaschileTreeView.SelectedNode.Tag : null);
            }
        }
        public SpecialitàGara SpecialitàGaraFemminileCorrente
        {
            get
            {
                return (SpecialitàGara)((_garaFemminileTreeView.SelectedNode != null) ? _garaFemminileTreeView.SelectedNode.Tag : null);
            }
        }

        private void Documento_Changed(object sender, EventArgs e)
        {
            RefreshTreeView();
        }

        protected void RefreshTreeView()
        {
            List<SpecialitàGara> specialitàGara = Gara.GetInstance().SpecialitàGara;

            //maschile
            SpecialitàGara specialitàMaschileCorrente = SpecialitàGaraMaschileCorrente;
            _garaMaschileTreeView.Nodes.Clear();

            //femminile
            SpecialitàGara specialitàFemminileCorrente = SpecialitàGaraFemminileCorrente;
            _garaFemminileTreeView.Nodes.Clear();
        }

        private void OnSpecialitàGaraCorrenteChanged()
        {
            throw new NotImplementedException();
        }

        
    }
}