using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Experimenta_Senac
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
                frmJogo novoJogo = new frmJogo(false, txtIP.Text);
                Visible = false;
                if (!novoJogo.IsDisposed)
                    novoJogo.ShowDialog();
                Visible = true;
        }

        private void btnHost_Click_1(object sender, EventArgs e)
        {
            frmJogo novoJogo = new frmJogo(true);
            Visible = false;
            if (!novoJogo.IsDisposed)
                novoJogo.ShowDialog();
            Visible = true;
        }
    }
}
