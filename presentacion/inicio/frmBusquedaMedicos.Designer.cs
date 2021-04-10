namespace presentacion.inicio
{
    partial class frmBusquedaMedicos
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
            this.btnIngresarPaciente = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombre_medico = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarPaciente
            // 
            this.btnIngresarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnIngresarPaciente.FlatAppearance.BorderSize = 0;
            this.btnIngresarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPaciente.Location = new System.Drawing.Point(411, 38);
            this.btnIngresarPaciente.Name = "btnIngresarPaciente";
            this.btnIngresarPaciente.Size = new System.Drawing.Size(48, 36);
            this.btnIngresarPaciente.TabIndex = 1;
            this.btnIngresarPaciente.Text = "...";
            this.btnIngresarPaciente.UseVisualStyleBackColor = false;
            this.btnIngresarPaciente.Click += new System.EventHandler(this.btnIngresarPaciente_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(19, 50);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(58, 17);
            this.label51.TabIndex = 42;
            this.label51.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.btnIngresarPaciente);
            this.groupBox4.Controls.Add(this.txtNombre_medico);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.groupBox4.Location = new System.Drawing.Point(2, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 89);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // txtNombre_medico
            // 
            this.txtNombre_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_medico.Location = new System.Drawing.Point(106, 44);
            this.txtNombre_medico.Name = "txtNombre_medico";
            this.txtNombre_medico.Size = new System.Drawing.Size(289, 26);
            this.txtNombre_medico.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(-244, 35);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(44, 13);
            this.label36.TabIndex = 41;
            this.label36.Text = "Nombre";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(-250, 84);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 13);
            this.label40.TabIndex = 38;
            this.label40.Text = "Calle";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Andalus", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.label44.Location = new System.Drawing.Point(250, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(206, 31);
            this.label44.TabIndex = 37;
            this.label44.Text = "Busqueda del Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("BatangChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(587, 1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busqueda Medico";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.White;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("BatangChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.Red;
            this.lblCerrar.Location = new System.Drawing.Point(761, 2);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblCerrar.Size = new System.Drawing.Size(23, 16);
            this.lblCerrar.TabIndex = 2;
            this.lblCerrar.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCerrar);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 101);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de hospital Universitario de Zurich";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::presentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 253);
            this.panel2.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(224, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBusquedaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaMedicos";
            this.Load += new System.EventHandler(this.frmBusquedaMedicos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresarPaciente;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombre_medico;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}