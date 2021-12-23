using AMcore.Core;
using AMcore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaUTMMon.Forms
{
    public partial class MainForm : Form
    {
        private readonly BL _bl;
        public MainForm(BL bl)
        {
            InitializeComponent();
            _bl = bl;
            utmParamsBindingSource.DataSource = _bl.UtmParams;
        }

        private void TSB_Add_Click(object sender, EventArgs e)
        {
            UtmParam utmParam = new ();
            UtmParamForm utmParamForm = new(utmParam);
            utmParamForm.ShowDialog(this);
            if (utmParamForm.DialogResult != DialogResult.OK)
                return;
            _bl.AddUtmParam(utmParam);
        }

        private void TSB_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
        }

        private void RefreshDataTable()
        {
            utmParamsBindingSource.ResetBindings(false);
        }
    }
}
