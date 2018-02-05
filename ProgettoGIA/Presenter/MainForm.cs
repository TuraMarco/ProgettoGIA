using ProgettoGIA.Model;
using ProgettoGIA.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGIA.Presenter
{
    public partial class MainForm : Form
    {
        Gara _gara;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _gara = Gara.GetInstance();
        }

        private void _esportaGaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog _saveGaraDialog = new SaveFileDialog();
            _saveGaraDialog.Filter = "XML file|*.xml|Text file|*.txt";
            _saveGaraDialog.Title = "Salva Gara";
            _saveGaraDialog.ShowDialog();

            if (_saveGaraDialog.FileName != "")
            {
                _gara.SaveGara(new GaraPersisiter(_saveGaraDialog.FileName));
            }
        }

        private void _esportaSocietàAtletiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"SocietàAtleti.xml");
            File.Create(fileName).Close();
            _gara.SaveSocietàAtleti(new SocietàAtletiPersister(fileName));
        }
    }
}
