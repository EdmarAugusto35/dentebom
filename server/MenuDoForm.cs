using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class MenuDoForm : Form
    {
        public MenuDoForm()
        {
            InitializeComponent();
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            Form1 dentista = new Form1();
            dentista.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FrPaciente paciente = new FrPaciente();
            paciente.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta consultas = new FrmConsulta();
            consultas.Show();
        }

        private void tsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
