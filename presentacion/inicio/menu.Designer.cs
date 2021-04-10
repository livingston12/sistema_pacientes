namespace presentacion.inicio
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picMedicos = new System.Windows.Forms.PictureBox();
            this.picPacientes = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pACIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGRESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDICOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGRESOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRDELSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picSalir);
            this.panel1.Controls.Add(this.picMedicos);
            this.panel1.Controls.Add(this.picPacientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 418);
            this.panel1.TabIndex = 0;
            // 
            // picSalir
            // 
            this.picSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = global::presentacion.Properties.Resources.salirdelsistema;
            this.picSalir.Location = new System.Drawing.Point(1, 336);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(93, 83);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 2;
            this.picSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.picSalir, "Salir del sistema");
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picMedicos
            // 
            this.picMedicos.BackColor = System.Drawing.Color.Transparent;
            this.picMedicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMedicos.Image = global::presentacion.Properties.Resources.medico;
            this.picMedicos.Location = new System.Drawing.Point(0, 155);
            this.picMedicos.Name = "picMedicos";
            this.picMedicos.Size = new System.Drawing.Size(93, 83);
            this.picMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedicos.TabIndex = 1;
            this.picMedicos.TabStop = false;
            this.toolTip1.SetToolTip(this.picMedicos, "Ingreso de Medicos");
            this.picMedicos.Click += new System.EventHandler(this.picMedicos_Click);
            // 
            // picPacientes
            // 
            this.picPacientes.BackColor = System.Drawing.SystemColors.Control;
            this.picPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPacientes.Image = global::presentacion.Properties.Resources.pacientes;
            this.picPacientes.Location = new System.Drawing.Point(0, 0);
            this.picPacientes.Name = "picPacientes";
            this.picPacientes.Size = new System.Drawing.Size(94, 83);
            this.picPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPacientes.TabIndex = 0;
            this.picPacientes.TabStop = false;
            this.toolTip1.SetToolTip(this.picPacientes, "Ingreso de pacientes");
            this.picPacientes.Click += new System.EventHandler(this.picPacientes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pACIENTESToolStripMenuItem,
            this.mEDICOSToolStripMenuItem,
            this.sALIRDELSISTEMAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pACIENTESToolStripMenuItem
            // 
            this.pACIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGRESOToolStripMenuItem,
            this.bUSCARToolStripMenuItem1});
            this.pACIENTESToolStripMenuItem.Image = global::presentacion.Properties.Resources.pacientes;
            this.pACIENTESToolStripMenuItem.Name = "pACIENTESToolStripMenuItem";
            this.pACIENTESToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.pACIENTESToolStripMenuItem.Text = "PACIENTES";
            // 
            // iNGRESOToolStripMenuItem
            // 
            this.iNGRESOToolStripMenuItem.Image = global::presentacion.Properties.Resources.iconoagregarPaciente;
            this.iNGRESOToolStripMenuItem.Name = "iNGRESOToolStripMenuItem";
            this.iNGRESOToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.iNGRESOToolStripMenuItem.Text = "INGRESO";
            this.iNGRESOToolStripMenuItem.Click += new System.EventHandler(this.iNGRESOToolStripMenuItem_Click);
            // 
            // bUSCARToolStripMenuItem1
            // 
            this.bUSCARToolStripMenuItem1.Image = global::presentacion.Properties.Resources.iconoBusquedaPaciente;
            this.bUSCARToolStripMenuItem1.Name = "bUSCARToolStripMenuItem1";
            this.bUSCARToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.bUSCARToolStripMenuItem1.Text = "BUSCAR";
            this.bUSCARToolStripMenuItem1.Click += new System.EventHandler(this.bUSCARToolStripMenuItem1_Click);
            // 
            // mEDICOSToolStripMenuItem
            // 
            this.mEDICOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGRESOToolStripMenuItem1,
            this.bUSCARToolStripMenuItem});
            this.mEDICOSToolStripMenuItem.Image = global::presentacion.Properties.Resources.medico;
            this.mEDICOSToolStripMenuItem.Name = "mEDICOSToolStripMenuItem";
            this.mEDICOSToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.mEDICOSToolStripMenuItem.Text = "MEDICOS";
            // 
            // iNGRESOToolStripMenuItem1
            // 
            this.iNGRESOToolStripMenuItem1.Image = global::presentacion.Properties.Resources.iconoagregarMedico;
            this.iNGRESOToolStripMenuItem1.Name = "iNGRESOToolStripMenuItem1";
            this.iNGRESOToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.iNGRESOToolStripMenuItem1.Text = "INGRESO";
            this.iNGRESOToolStripMenuItem1.Click += new System.EventHandler(this.iNGRESOToolStripMenuItem1_Click);
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.Image = global::presentacion.Properties.Resources.iconoBusquedaMedico;
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            this.bUSCARToolStripMenuItem.Click += new System.EventHandler(this.bUSCARToolStripMenuItem_Click);
            // 
            // sALIRDELSISTEMAToolStripMenuItem
            // 
            this.sALIRDELSISTEMAToolStripMenuItem.Image = global::presentacion.Properties.Resources.salirdelsistema;
            this.sALIRDELSISTEMAToolStripMenuItem.Name = "sALIRDELSISTEMAToolStripMenuItem";
            this.sALIRDELSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(158, 23);
            this.sALIRDELSISTEMAToolStripMenuItem.Text = "SALIR DEL SISTEMA";
            this.sALIRDELSISTEMAToolStripMenuItem.Click += new System.EventHandler(this.sALIRDELSISTEMAToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::presentacion.Properties.Resources.fondoUniversidad;
            this.pictureBox1.Location = new System.Drawing.Point(95, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(891, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pACIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEDICOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRDELSISTEMAToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem iNGRESOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNGRESOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picMedicos;
        private System.Windows.Forms.PictureBox picPacientes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}