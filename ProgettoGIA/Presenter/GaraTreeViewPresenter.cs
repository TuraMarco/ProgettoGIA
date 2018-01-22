using ProgettoGIA.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    internal class GaraTreeViewPresenter
    {
        //campi
        private readonly TreeView _garaTreeView;

        //evento
        public static event EventHandler SpecialitàGaraCorrenteChanged;

        //property
        public TreeView GaraTreeView => _garaTreeView;

        //costruttore
        public GaraTreeViewPresenter(TreeView garaTreeView)
        {
            if (garaTreeView == null)
            {
                throw new ArgumentNullException("GaraMaschileDataGridViewPresenter");
            }

            _garaTreeView = garaTreeView;
            _garaTreeView.AfterSelect += GaraTreeView_AfterSelect;
            Gara.GetInstance().Changed += Gara_changed;

            RefreshTreeView();
        }

        public SpecialitàGara SpecialitàGaraCorrente
        {
            get
            {
                return (SpecialitàGara)((GaraTreeView.SelectedNode != null) ? GaraTreeView.SelectedNode.Tag : null);
            }
        }

        private void GaraTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            OnSpecialitàGaraCorrenteChanged();
        }   

        private void Gara_changed(object sender, EventArgs e)
        {
            RefreshTreeView();
        }

        protected void RefreshTreeView()
        {
            List<SpecialitàGara> specialitàGaraList = Gara.GetInstance().SpecialitàGara;
            _garaTreeView.Nodes.Clear();

            TreeNode rootMaschio = new TreeNode(Sesso.MASCHIO.ToString());
            rootMaschio.Tag = Sesso.MASCHIO;
            TreeNode rootFemmina = new TreeNode(Sesso.FEMMINA.ToString());
            rootFemmina.Tag = Sesso.FEMMINA;

            _garaTreeView.Nodes.Add(rootMaschio);
            _garaTreeView.Nodes.Add(rootFemmina);


            foreach (SpecialitàGara sg in specialitàGaraList)
            {
                TreeNode _treeNodeMaschio = new TreeNode(sg.Disciplina.ToString());
                TreeNode _treeNodeFemmina = new TreeNode(sg.Disciplina.ToString());
                _treeNodeMaschio.Tag = sg.Disciplina;
                _treeNodeFemmina.Tag = sg.Disciplina;
                rootMaschio.Nodes.Add(_treeNodeMaschio);
                rootFemmina.Nodes.Add(_treeNodeFemmina);
            }
        }

        private void OnSpecialitàGaraCorrenteChanged()
        {
            Console.Write("SpecialitàGaraCorrenteChanged!!!\n");
            if (SpecialitàGaraCorrenteChanged != null)
            {
                SpecialitàGaraCorrenteChanged(this, EventArgs.Empty);
            }
        }   
    }
}