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
    public partial class UtmParamForm : Form
    {
        private readonly UtmParam _utmParam;
        public UtmParamForm(UtmParam utmParam)
        {
            _utmParam  = utmParam;
            InitializeComponent();
            InitializeModel();
        }
        private void InitializeModel()
        {
            TBFSRARID.Text = _utmParam.FSRARID;
            TBAddress.Text = _utmParam.ConnectionHost;
            TBPort.Text = _utmParam.ConnectionPort.ToString();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            _utmParam.FSRARID = TBFSRARID.Text;
            _utmParam.SetConnectionString(TBAddress.Text, int.Parse(TBPort.Text));
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
