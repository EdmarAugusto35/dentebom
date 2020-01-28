namespace server
{
    partial class MenuDoForm
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
            this.btnDentista = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDentista
            // 
            this.btnDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDentista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDentista.ImageKey = "(none)";
            this.btnDentista.Location = new System.Drawing.Point(12, 85);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(193, 84);
            this.btnDentista.TabIndex = 0;
            this.btnDentista.Text = "Dentista";
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Image = global::server.Properties.Resources.pngtree_medical_advertising_poster_background_material_image_141130;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(12, 235);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPaciente.Size = new System.Drawing.Size(193, 81);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsulta.Image = global::server.Properties.Resources.pngtree_medical_advertising_poster_background_material_image_141130;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.Location = new System.Drawing.Point(12, 380);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(193, 76);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastrar,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tsair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(69, 20);
            this.Cadastrar.Text = "Cadastrar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Relatorio";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem2.Text = "Sobre";
            // 
            // tsair
            // 
            this.tsair.Name = "tsair";
            this.tsair.Size = new System.Drawing.Size(38, 20);
            this.tsair.Text = "Sair";
            this.tsair.Click += new System.EventHandler(this.tsair_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "dentista";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Consulta";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "Paciente";
            // 
            // MenuDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::server.Properties.Resources.pngtree_medical_advertising_poster_background_material_image_141130;
            this.ClientSize = new System.Drawing.Size(764, 551);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuDoForm";
            this.Text = "MenuDoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDentista;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsair;
    }
}