namespace Seversss
{
    partial class paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvarr = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnExcluirr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDpaciente = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lblDTnac = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtnome1 = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.DTnac = new System.Windows.Forms.DateTimePicker();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtIDpa = new System.Windows.Forms.TextBox();
            this.DTGRI = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(0, 0);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(105, 31);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "Cadastrar";
            this.btnnovo.UseVisualStyleBackColor = true;
            // 
            // btnsalvarr
            // 
            this.btnsalvarr.Location = new System.Drawing.Point(111, 0);
            this.btnsalvarr.Name = "btnsalvarr";
            this.btnsalvarr.Size = new System.Drawing.Size(103, 31);
            this.btnsalvarr.TabIndex = 1;
            this.btnsalvarr.Text = "Salvar";
            this.btnsalvarr.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(220, 0);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 31);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnExcluirr
            // 
            this.btnExcluirr.Location = new System.Drawing.Point(326, 0);
            this.btnExcluirr.Name = "btnExcluirr";
            this.btnExcluirr.Size = new System.Drawing.Size(95, 31);
            this.btnExcluirr.TabIndex = 3;
            this.btnExcluirr.Text = "Excluir";
            this.btnExcluirr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDpa);
            this.groupBox1.Controls.Add(this.lbltelefone);
            this.groupBox1.Controls.Add(this.DTnac);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(this.txtnome1);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lblDTnac);
            this.groupBox1.Controls.Add(this.lblendereco);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.lblIDpaciente);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lblIDpaciente
            // 
            this.lblIDpaciente.AutoSize = true;
            this.lblIDpaciente.Location = new System.Drawing.Point(6, 27);
            this.lblIDpaciente.Name = "lblIDpaciente";
            this.lblIDpaciente.Size = new System.Drawing.Size(18, 13);
            this.lblIDpaciente.TabIndex = 0;
            this.lblIDpaciente.Text = "ID";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(133, 27);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 53);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(6, 79);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(53, 13);
            this.lblendereco.TabIndex = 3;
            this.lblendereco.Text = "Endereço";
            // 
            // lblDTnac
            // 
            this.lblDTnac.AutoSize = true;
            this.lblDTnac.Location = new System.Drawing.Point(217, 109);
            this.lblDTnac.Name = "lblDTnac";
            this.lblDTnac.Size = new System.Drawing.Size(81, 13);
            this.lblDTnac.TabIndex = 4;
            this.lblDTnac.Text = "DataNacimento";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(183, 24);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(227, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtnome1
            // 
            this.txtnome1.Location = new System.Drawing.Point(38, 50);
            this.txtnome1.Name = "txtnome1";
            this.txtnome1.Size = new System.Drawing.Size(372, 20);
            this.txtnome1.TabIndex = 6;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(64, 79);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(346, 20);
            this.txtendereco.TabIndex = 7;
            this.txtendereco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(64, 109);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // DTnac
            // 
            this.DTnac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTnac.Location = new System.Drawing.Point(300, 105);
            this.DTnac.Name = "DTnac";
            this.DTnac.Size = new System.Drawing.Size(110, 20);
            this.DTnac.TabIndex = 9;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(6, 112);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(49, 13);
            this.lbltelefone.TabIndex = 10;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtIDpa
            // 
            this.txtIDpa.Location = new System.Drawing.Point(38, 24);
            this.txtIDpa.Name = "txtIDpa";
            this.txtIDpa.Size = new System.Drawing.Size(77, 20);
            this.txtIDpa.TabIndex = 11;
            // 
            // DTGRI
            // 
            this.DTGRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRI.Location = new System.Drawing.Point(0, 172);
            this.DTGRI.Name = "DTGRI";
            this.DTGRI.Size = new System.Drawing.Size(415, 123);
            this.DTGRI.TabIndex = 12;
            // 
            // paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 307);
            this.Controls.Add(this.DTGRI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluirr);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsalvarr);
            this.Controls.Add(this.btnnovo);
            this.Name = "paciente";
            this.Text = "paciente";
            this.Load += new System.EventHandler(this.paciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvarr;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnExcluirr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDpa;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.DateTimePicker DTnac;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtnome1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblDTnac;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblIDpaciente;
        private System.Windows.Forms.DataGridView DTGRI;
    }
}