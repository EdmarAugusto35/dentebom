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
    public partial class FrmConsulta : Form
    {
        Consulta objconsulta;
        conexao con = new conexao();
        public FrmConsulta()
        {

            InitializeComponent();
            con = new conexao();
        }
        private void limparcampos()
        {
            txtid.Text = "";
            txtMotivo.Text = "";
            txtMotivoR.Text = "";
            txtReceita.Text = "";
            txtDia.Text = "";

        }
        private void desbloquearcampos()
        {
            txtid.ReadOnly = false;
            txtMotivo.ReadOnly = false;
            txtMotivoR.ReadOnly = false;
            txtReceita.ReadOnly = false;
            txtDia.ReadOnly = false;
        }
        private void bloquearcampos()
        {
            txtid.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            txtMotivoR.ReadOnly = true;
            txtReceita.ReadOnly = true;
            txtDia.ReadOnly = true;
        }
        private void lerdados()
        {
            objconsulta = new Consulta();
            objconsulta.id = int.Parse(txtid.Text.Trim());
            objconsulta.receita = txtReceita.Text;
            objconsulta.motivoR = txtMotivoR.Text;
            objconsulta.motivo = txtMotivo.Text;
            //objconsulta.dtretorno = dataR.Value.Date;
            //objconsulta.dtconsulta = DataC.value.Date;
            objconsulta.diagnostico = txtDia.Text;

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            txtid.Focus();
        }
        private void atualizargrid()
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
                    consulta.dtretorno = reader.GetDateTime(5);
                    consulta.motivoR = reader.GetString(6);
                    consulta.diagnostico = reader.GetString(4);

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
            String sql = "insert into tb_consulta values(" + objconsulta.id + ",'" +
                objconsulta.receita + "','" +
                objconsulta.motivo + "','" +
                objconsulta.dtretorno + "','" +
                objconsulta.dtconsulta + "','" +
                objconsulta.motivoR + "','" +
                objconsulta.diagnostico + ")";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            bloquearcampos();
            atualizargrid();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            atualizargrid();
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
                String sql = "delete from tb_dentista where id = " + txtid.Text;
                con.executar(sql);
                atualizargrid();
            }
        }

        private void DataFrmConslta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = DataFrmConslta.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
