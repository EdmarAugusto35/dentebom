using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace server
{
    public partial class FrPaciente : Form, icadform
    {
        paciente objpaciente;
        conexao con = new conexao();
        public FrPaciente()
        {
            InitializeComponent();
            con = new conexao();
        }
        private void bloquearbotoes()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }
        private void bloquearbotoess()
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void bloquearB()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
        }
        public void limparcampos()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtcpf.Text = "";
            txtendereco.Text = "";
            txttelefone.Text = "";
        }
        private void desbloquearcampos()
        {
            txtid.ReadOnly = false;
            txtnome.ReadOnly = false;
            txtcpf.ReadOnly = false;
            txtendereco.ReadOnly = false;
            txttelefone.ReadOnly = false;
            bloquearbotoess();
        }
        private void bloquearcampos()
        {
            txtid.ReadOnly = true;
            txtnome.ReadOnly = true;
            txtcpf.ReadOnly = true;
            txtendereco.ReadOnly = true;
            txttelefone.ReadOnly = true;
        }
        public void lerdados()
        {
            objpaciente = new paciente();
            objpaciente.id = int.Parse(txtid.Text.Trim());
            objpaciente.nome = txtnome.Text;
            objpaciente.CPF = txtcpf.Text;
            objpaciente.endereco = txtendereco.Text;
            objpaciente.telefone = txttelefone.Text;
            objpaciente.dtNacimento = DataNc.Value;
        }
        public void atualizarGrid()
        {
            List<paciente> listPaciente = new List<paciente>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from tb_paciente");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    paciente paciente = new paciente();
                    paciente.id = reader.GetInt32(0);
                    paciente.nome = reader.GetString(1);
                    paciente.CPF = reader.GetString(2);
                    paciente.endereco = reader.GetString(3);
                    paciente.telefone = reader.GetString(4);
                    paciente.dtNacimento = reader.GetDateTime(5);
                    listPaciente.Add(paciente);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            DataFrmPaciente.DataSource = null;
            DataFrmPaciente.DataSource = listPaciente;

        }
        private void FrPaciente_Load(object sender, EventArgs e)
        {
            
            bloquearcampos();
            atualizarGrid();
            bloquearbotoess();

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            txtid.Focus();
            bloquearbotoes();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into tb_paciente values (" + objpaciente.id + ",'" 
                + objpaciente.nome + "','"
                + objpaciente.CPF + "','"
                + objpaciente.endereco + "','" 
                + objpaciente.telefone + "'," 
                + objpaciente.dtNacimento + ",)";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            bloquearcampos();
            atualizarGrid();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show(" click em um campo primeiro !");
            }
            else
            {
                String sql = "delete from tb_paciente where id = " + txtid.Text;
                con.executar(sql);
                atualizarGrid();
            }
        }
        private void DataFrmPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = DataFrmPaciente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = DataFrmPaciente.CurrentRow.Cells[1].Value.ToString();
            txtcpf.Text = DataFrmPaciente.CurrentRow.Cells[2].Value.ToString();
            txtendereco.Text = DataFrmPaciente.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = DataFrmPaciente.CurrentRow.Cells[4].Value.ToString();
            DataNc.Value = DateTime.Parse(DataFrmPaciente.CurrentRow.Cells[5].Value.ToString());
            atualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bloquearbotoess();
            bloquearB();
            MessageBox.Show("Deseja cancelar:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }
     
    }
}
