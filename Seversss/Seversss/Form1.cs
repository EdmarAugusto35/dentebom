using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seversss
{
    public partial class Form1 : Form
    {
        conexao con ;


        public Form1()
        {
            InitializeComponent();

            con = new conexao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            con.conectar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
