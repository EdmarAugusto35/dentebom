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
    public partial class FrmConsulta : Form,icadform
    {
        Consulta objconsulta;
        conexao con = new conexao();
        public FrmConsulta()
        {

            InitializeComponent();
            con = new conexao();
        }
        private void bloquearbotoes()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
        }
        public void limparcampos()
        {
            txtid.Text = "";
            txtMotivo.Text = "";
            txtMotivoR.Text = "";
            txtReceita.Text = "";
            txtDia.Text = "";
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
            cmbDentista.Text = "";
            cmbPaciente.Text = "";
        }
        private void desbloquearcampos()
        {
            txtid.ReadOnly = false;
            txtMotivo.ReadOnly = false;
            txtMotivoR.ReadOnly = false;
            txtReceita.ReadOnly = false;
            txtDia.ReadOnly = false;
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
        }
        private void bloquearcampos  ()
        {
            txtid.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            txtMotivoR.ReadOnly = true;
            txtReceita.ReadOnly = true;
            txtDia.ReadOnly = true;
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
        }
        public void lerdados()
        {
            objconsulta = new Consulta();
            objconsulta.id = int.Parse(txtid.Text.Trim());
            objconsulta.motivo = txtMotivo.Text;
            objconsulta.dtconsulta = dataC.Value ;
            objconsulta.receita = txtReceita.Text;
            objconsulta.diagnostico = txtDia.Text;
            objconsulta.dtretorno= DataR.Value ;
            objconsulta.motivoR = txtMotivoR.Text;
            objconsulta.iddentista = int.Parse(cmbDentista.SelectedValue.ToString());
            objconsulta.idpaciente = int.Parse(cmbPaciente.SelectedValue.ToString());
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            bloquearbotoes();
            txtid.Focus();
        }
        private void carregarBoxs()
        {
            List<paciente> listPaciente = new  List<paciente>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select id, Nome from tb_paciente");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    paciente paciente = new paciente();
                    paciente.id = reader.GetInt32(0);
                    paciente.nome = reader.GetString(1);
                   
                    listPaciente.Add(paciente);
                }
                
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            cmbPaciente.DataSource = listPaciente;
            cmbPaciente.DisplayMember = "nome";
            cmbPaciente.ValueMember = "id";
        }
        private void carregarbox()
        {
            List<dentista> listadentista = new List<dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select id, nome from tb_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dentista dentista = new dentista();
                    dentista.id = reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);
                  
                    listadentista.Add(dentista);
                }   
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            cmbDentista.DataSource = listadentista;
            cmbDentista.DisplayMember = "nome";
            cmbDentista.ValueMember = "id";
        }
        public void atualizarGrid()
        {
            List<Consulta> listconsulta = new List<Consulta>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from tb_consulta");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.id = reader.GetInt32(0);
                    consulta.motivo = reader.GetString(1);
                    consulta.dtconsulta = reader.GetDateTime(2);
                    consulta.receita = reader.GetString(3);
                    consulta.diagnostico = reader.GetString(4);
                    consulta.dtretorno = reader.GetDateTime(5);
                    consulta.motivoR = reader.GetString(6);
                    consulta.iddentista = reader.GetInt32(8);
                    consulta.idpaciente = reader.GetInt32(7);
                    listconsulta.Add(consulta);
                    
                    
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
           
            DataFrmConslta.DataSource = null;
            DataFrmConslta.DataSource = listconsulta;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into tb_consulta values(" + objconsulta.id + ",'"
                +objconsulta.motivo + "','"
                +objconsulta.dtconsulta + "','"
                +objconsulta.receita + "','"
                +objconsulta.diagnostico + "','"
                +objconsulta.dtretorno+"','"
                +objconsulta.motivoR + "',"
                +objconsulta.iddentista+","
                +objconsulta.idpaciente+")";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            atualizarGrid();
            bloquearcampos();
           
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show(" click em um campo primeiro !");
            }
            else
            {
                String sql = "delete from tb_consulta where id = " + txtid.Text;
                con.executar(sql);
                atualizarGrid();
            }
        }
        private void DataFrmConslta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DataFrmConslta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = DataFrmConslta.CurrentRow.Cells[0].Value.ToString();
            txtMotivo.Text = DataFrmConslta.CurrentRow.Cells[1].Value.ToString();
            txtMotivoR.Text = DataFrmConslta.CurrentRow.Cells[6].Value.ToString();
            txtDia.Text = DataFrmConslta.CurrentRow.Cells[4].Value.ToString();
            txtReceita.Text = DataFrmConslta.CurrentRow.Cells[3].Value.ToString();
            dataC.Value = DateTime.Parse(DataFrmConslta.CurrentRow.Cells[2].Value.ToString());
            DataR.Value = DateTime.Parse(DataFrmConslta.CurrentRow.Cells[5].Value.ToString());
            cmbDentista.Text = DataFrmConslta.CurrentRow.Cells[8].Value.ToString();
            cmbPaciente.Text = DataFrmConslta.CurrentRow.Cells[7].Value.ToString();

            atualizarGrid();
        }
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            bloquearcampos();
            atualizarGrid();
            carregarbox();
            carregarBoxs();

        }
        private void cmbDentista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
