using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_Teoria
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            this.Hide();
            usuario.Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            FrmAdministrar adm = new FrmAdministrar();
            this.Hide();
            adm.Show();
        }
    }
}
