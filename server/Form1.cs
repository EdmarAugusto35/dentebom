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
    public partial class Form1 : Form,icadform
    {
        dentista objdentista;
        conexao con = new conexao();
        public Form1()
        {
            InitializeComponent();
            con = new conexao();
        }
        private void bloquearbotoes()
        {
            btnnovo.Enabled = false;
            btnExcluir.Enabled = false;
            btncancelar.Enabled = true;
            btnsalvar.Enabled = true;
        }
        private void bloquearbotoess()
        {
            btnsalvar.Enabled = false;
            btncancelar.Enabled = false;
        }
        private void bloquearB()
        {
            btnnovo.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            bloquearbotoes();
            txtid.Focus();
        }
        public void limparcampos()
        {
            txtid.Text = "";
            txtNome.Text = "";
            txtCRO.Text = "";     
        }
        private void desbloquearcampos()
        {
            txtid.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtCRO.ReadOnly = false;
        }
        private void bloquearcampos()
        {
            txtid.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtCRO.ReadOnly = true;
            bloquearbotoess();
        }
        public void lerdados()
        {
            objdentista = new dentista();
            objdentista.id = int.Parse(txtid.Text.Trim());
            objdentista.nome = txtNome.Text;
            objdentista.CRO = txtCRO.Text;
            //13/01/2020
            objdentista.Instagram = chin.Checked ? 1 : 0;
            objdentista.facebook = chfc.Checked ? 1 : 0;
            objdentista.twitter = chtw.Checked ? 1 : 0;
            objdentista.linkedin = chlk.Checked ? 1 : 0;

            if (rbFeminino.Checked)
            {
                objdentista.sexo = "F";
            }
            else
            {
                objdentista.sexo = "M";
            }
            //objdentista.sexo = rbFeminino.Checked ? "F" : "M";
        }
        public void atualizarGrid()
        {
            List<dentista> listDentista = new List<dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from tb_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dentista dentista = new dentista();
                    dentista.id= reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);
                    dentista.CRO = reader.GetString(2);
                    dentista.sexo = reader.GetValue(3) == null ? "":reader.GetValue(3).ToString();
                    dentista.Instagram = reader.GetValue(4).ToString() ==   "True" ? 1 : 0;
                    dentista.twitter = reader.GetValue(5).ToString() ==   "True" ? 1 : 0;
                    dentista.facebook = reader.GetValue(6).ToString()  ==  "True" ? 1 : 0;
                    dentista.linkedin = reader.GetValue(7).ToString() == "True" ? 1 : 0;
                    listDentista.Add(dentista);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            DataFrmDentistas.DataSource = null;
            DataFrmDentistas.DataSource = listDentista;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            bloquearcampos();
            bloquearbotoess();

        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into tb_dentista values ("+objdentista.id+", '"
                +
                objdentista.nome+"', '"+
                objdentista.CRO+ "', '"+
                objdentista.sexo+"', "+
                objdentista.Instagram+", "+
                objdentista.facebook+", "+
                objdentista.twitter+", "+
                objdentista.linkedin+") ";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            bloquearcampos();
            atualizarGrid();

        }
        private void DataFrmDentistas_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            
        }
        private void DataFrmDentistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = DataFrmDentistas.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DataFrmDentistas.CurrentRow.Cells[1].Value.ToString();
            txtCRO.Text = DataFrmDentistas.CurrentRow.Cells[2].Value.ToString();
            rbFeminino.Checked = DataFrmDentistas.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            rbMasculino.Checked = DataFrmDentistas.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            chin.Checked = DataFrmDentistas.CurrentRow.Cells[4].Value.Equals(1) ;
            chtw.Checked = DataFrmDentistas.CurrentRow.Cells[5].Value.Equals(1);
            chfc.Checked = DataFrmDentistas.CurrentRow.Cells[6].Value.Equals(1);
            chlk.Checked = DataFrmDentistas.CurrentRow.Cells[7].Value.Equals(1);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show(" click em um campo primeiro !");
            }
            else {
                String sql = "delete from tb_dentista where id = "+ txtid.Text;
                con.executar(sql);
                atualizarGrid();
            }
        }
        private void txtCRO_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblid_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bloquearbotoess();
            bloquearB();


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

        }
