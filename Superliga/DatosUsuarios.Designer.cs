namespace Superliga
{
    partial class Usuarios
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
            this.grpDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantUsu = new System.Windows.Forms.Label();
            this.txtCantReg = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPromEdadRacing = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCasUniv = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHinchasRiver = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgClubes = new System.Windows.Forms.DataGridView();
            this.clubesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSociosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menorEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayorEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.grpDatosUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasUniv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClubes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosUsuarios
            // 
            this.grpDatosUsuarios.Controls.Add(this.btnRuta);
            this.grpDatosUsuarios.Controls.Add(this.txtRuta);
            this.grpDatosUsuarios.Controls.Add(this.lblRuta);
            this.grpDatosUsuarios.Controls.Add(this.groupBox3);
            this.grpDatosUsuarios.Controls.Add(this.groupBox1);
            this.grpDatosUsuarios.Controls.Add(this.panel2);
            this.grpDatosUsuarios.Controls.Add(this.panel1);
            this.grpDatosUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grpDatosUsuarios.Name = "grpDatosUsuarios";
            this.grpDatosUsuarios.Size = new System.Drawing.Size(706, 540);
            this.grpDatosUsuarios.TabIndex = 0;
            this.grpDatosUsuarios.TabStop = false;
            this.grpDatosUsuarios.Text = "Datos Usuarios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCantReg);
            this.panel1.Controls.Add(this.lblCantUsu);
            this.panel1.Location = new System.Drawing.Point(26, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblCantUsu
            // 
            this.lblCantUsu.AutoSize = true;
            this.lblCantUsu.Location = new System.Drawing.Point(19, 24);
            this.lblCantUsu.Name = "lblCantUsu";
            this.lblCantUsu.Size = new System.Drawing.Size(99, 13);
            this.lblCantUsu.TabIndex = 0;
            this.lblCantUsu.Text = "Cantidad Registros:";
            // 
            // txtCantReg
            // 
            this.txtCantReg.Enabled = false;
            this.txtCantReg.Location = new System.Drawing.Point(136, 21);
            this.txtCantReg.Name = "txtCantReg";
            this.txtCantReg.Size = new System.Drawing.Size(72, 20);
            this.txtCantReg.TabIndex = 1;
            this.txtCantReg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPromEdadRacing);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(347, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 64);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prom.Edad hinchas de Racing:";
            // 
            // txtPromEdadRacing
            // 
            this.txtPromEdadRacing.Enabled = false;
            this.txtPromEdadRacing.Location = new System.Drawing.Point(188, 21);
            this.txtPromEdadRacing.Name = "txtPromEdadRacing";
            this.txtPromEdadRacing.Size = new System.Drawing.Size(80, 20);
            this.txtPromEdadRacing.TabIndex = 2;
            this.txtPromEdadRacing.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHinchasRiver);
            this.groupBox1.Controls.Add(this.dgvCasUniv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeras 100 persona casadas y con estudio universitario:";
            // 
            // dgvCasUniv
            // 
            this.dgvCasUniv.AllowUserToAddRows = false;
            this.dgvCasUniv.AllowUserToDeleteRows = false;
            this.dgvCasUniv.AllowUserToResizeRows = false;
            this.dgvCasUniv.AutoGenerateColumns = false;
            this.dgvCasUniv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCasUniv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasUniv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn});
            this.dgvCasUniv.DataSource = this.usuarioBindingSource;
            this.dgvCasUniv.Location = new System.Drawing.Point(22, 32);
            this.dgvCasUniv.Name = "dgvCasUniv";
            this.dgvCasUniv.RowHeadersVisible = false;
            this.dgvCasUniv.Size = new System.Drawing.Size(306, 91);
            this.dgvCasUniv.TabIndex = 4;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Superliga.Entidades.Usuario);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Los 5 nombres mas comunes entre los hinchas de River:";
            // 
            // cmbHinchasRiver
            // 
            this.cmbHinchasRiver.FormattingEnabled = true;
            this.cmbHinchasRiver.Location = new System.Drawing.Point(437, 66);
            this.cmbHinchasRiver.Name = "cmbHinchasRiver";
            this.cmbHinchasRiver.Size = new System.Drawing.Size(119, 21);
            this.cmbHinchasRiver.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgClubes);
            this.groupBox3.Location = new System.Drawing.Point(26, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clubes";
            // 
            // dtgClubes
            // 
            this.dtgClubes.AllowUserToAddRows = false;
            this.dtgClubes.AllowUserToDeleteRows = false;
            this.dtgClubes.AllowUserToResizeRows = false;
            this.dtgClubes.AutoGenerateColumns = false;
            this.dtgClubes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClubes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipoDataGridViewTextBoxColumn1,
            this.cantidadSociosDataGridViewTextBoxColumn,
            this.promedioEdadDataGridViewTextBoxColumn,
            this.menorEdadDataGridViewTextBoxColumn,
            this.mayorEdadDataGridViewTextBoxColumn});
            this.dtgClubes.DataSource = this.clubesBindingSource;
            this.dtgClubes.Location = new System.Drawing.Point(79, 19);
            this.dtgClubes.Name = "dtgClubes";
            this.dtgClubes.RowHeadersVisible = false;
            this.dtgClubes.Size = new System.Drawing.Size(510, 145);
            this.dtgClubes.TabIndex = 0;
            // 
            // clubesBindingSource
            // 
            this.clubesBindingSource.DataSource = typeof(Superliga.Entidades.clubes);
            // 
            // equipoDataGridViewTextBoxColumn1
            // 
            this.equipoDataGridViewTextBoxColumn1.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn1.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn1.Name = "equipoDataGridViewTextBoxColumn1";
            // 
            // cantidadSociosDataGridViewTextBoxColumn
            // 
            this.cantidadSociosDataGridViewTextBoxColumn.DataPropertyName = "cantidadSocios";
            this.cantidadSociosDataGridViewTextBoxColumn.HeaderText = "CantidadSocios";
            this.cantidadSociosDataGridViewTextBoxColumn.Name = "cantidadSociosDataGridViewTextBoxColumn";
            // 
            // promedioEdadDataGridViewTextBoxColumn
            // 
            this.promedioEdadDataGridViewTextBoxColumn.DataPropertyName = "promedioEdad";
            this.promedioEdadDataGridViewTextBoxColumn.HeaderText = "PromedioEdad";
            this.promedioEdadDataGridViewTextBoxColumn.Name = "promedioEdadDataGridViewTextBoxColumn";
            // 
            // menorEdadDataGridViewTextBoxColumn
            // 
            this.menorEdadDataGridViewTextBoxColumn.DataPropertyName = "menorEdad";
            this.menorEdadDataGridViewTextBoxColumn.HeaderText = "MenorEdad";
            this.menorEdadDataGridViewTextBoxColumn.Name = "menorEdadDataGridViewTextBoxColumn";
            // 
            // mayorEdadDataGridViewTextBoxColumn
            // 
            this.mayorEdadDataGridViewTextBoxColumn.DataPropertyName = "mayorEdad";
            this.mayorEdadDataGridViewTextBoxColumn.HeaderText = "MayorEdad";
            this.mayorEdadDataGridViewTextBoxColumn.Name = "mayorEdadDataGridViewTextBoxColumn";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(45, 49);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(93, 46);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(287, 20);
            this.txtRuta.TabIndex = 2;
            this.txtRuta.TabStop = false;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(416, 44);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(138, 23);
            this.btnRuta.TabIndex = 5;
            this.btnRuta.Text = "Seleccione Archivo";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 564);
            this.Controls.Add(this.grpDatosUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.grpDatosUsuarios.ResumeLayout(false);
            this.grpDatosUsuarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasUniv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClubes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantReg;
        private System.Windows.Forms.Label lblCantUsu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPromEdadRacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCasUniv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHinchasRiver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgClubes;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSociosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menorEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayorEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clubesBindingSource;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

