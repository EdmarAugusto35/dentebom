namespace server
{
    partial class Form1
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chlk = new System.Windows.Forms.CheckBox();
            this.chtw = new System.Windows.Forms.CheckBox();
            this.chfc = new System.Windows.Forms.CheckBox();
            this.chin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRO = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.DataFrmDentistas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFrmDentistas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(6, 29);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(87, 35);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(99, 29);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(89, 35);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(196, 29);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 35);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(289, 29);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCRO);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(0, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMasculino);
            this.groupBox3.Controls.Add(this.rbFeminino);
            this.groupBox3.Location = new System.Drawing.Point(206, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 42);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(78, 15);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 10;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(9, 15);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 9;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chlk);
            this.groupBox4.Controls.Add(this.chtw);
            this.groupBox4.Controls.Add(this.chfc);
            this.groupBox4.Controls.Add(this.chin);
            this.groupBox4.Location = new System.Drawing.Point(6, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 79);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rede Sociais";
            // 
            // chlk
            // 
            this.chlk.AutoSize = true;
            this.chlk.Location = new System.Drawing.Point(114, 47);
            this.chlk.Name = "chlk";
            this.chlk.Size = new System.Drawing.Size(66, 17);
            this.chlk.TabIndex = 3;
            this.chlk.Text = "Linkedin";
            this.chlk.UseVisualStyleBackColor = true;
            // 
            // chtw
            // 
            this.chtw.AutoSize = true;
            this.chtw.Location = new System.Drawing.Point(114, 24);
            this.chtw.Name = "chtw";
            this.chtw.Size = new System.Drawing.Size(58, 17);
            this.chtw.TabIndex = 2;
            this.chtw.Text = "Twitter";
            this.chtw.UseVisualStyleBackColor = true;
            // 
            // chfc
            // 
            this.chfc.AutoSize = true;
            this.chfc.Location = new System.Drawing.Point(6, 47);
            this.chfc.Name = "chfc";
            this.chfc.Size = new System.Drawing.Size(74, 17);
            this.chfc.TabIndex = 1;
            this.chfc.Text = "Facebook";
            this.chfc.UseVisualStyleBackColor = true;
            this.chfc.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chin
            // 
            this.chin.AutoSize = true;
            this.chin.Location = new System.Drawing.Point(6, 24);
            this.chin.Name = "chin";
            this.chin.Size = new System.Drawing.Size(72, 17);
            this.chin.TabIndex = 0;
            this.chin.Text = "Instagram";
            this.chin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CRO";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(9, 31);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "ID";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCRO
            // 
            this.txtCRO.Location = new System.Drawing.Point(215, 28);
            this.txtCRO.Name = "txtCRO";
            this.txtCRO.Size = new System.Drawing.Size(159, 20);
            this.txtCRO.TabIndex = 1;
            this.txtCRO.TextChanged += new System.EventHandler(this.txtCRO_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(29, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(144, 20);
            this.txtid.TabIndex = 0;
            // 
            // DataFrmDentistas
            // 
            this.DataFrmDentistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFrmDentistas.Location = new System.Drawing.Point(12, 290);
            this.DataFrmDentistas.Name = "DataFrmDentistas";
            this.DataFrmDentistas.Size = new System.Drawing.Size(394, 169);
            this.DataFrmDentistas.TabIndex = 6;
            this.DataFrmDentistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFrmDentistas_CellClick);
            this.DataFrmDentistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFrmDentistas_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnovo);
            this.groupBox2.Controls.Add(this.btnsalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 476);
            this.Controls.Add(this.DataFrmDentistas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFrmDentistas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCRO;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView DataFrmDentistas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chlk;
        private System.Windows.Forms.CheckBox chtw;
        private System.Windows.Forms.CheckBox chfc;
        private System.Windows.Forms.CheckBox chin;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
    }
}

