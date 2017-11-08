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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            FrmCalcularViaje viaje = new FrmCalcularViaje();
            this.Hide();
            viaje.Show();
  
        }
    }
}
