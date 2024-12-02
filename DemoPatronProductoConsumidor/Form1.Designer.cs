namespace DemoPatronProductoConsumidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnRegistrar = new Button();
            txtTipoCosina = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            BtnProcesar = new Button();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(txtTipoCosina);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 204);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.Lime;
            BtnRegistrar.Cursor = Cursors.Hand;
            BtnRegistrar.FlatAppearance.BorderSize = 0;
            BtnRegistrar.FlatStyle = FlatStyle.Flat;
            BtnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(299, 158);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // txtTipoCosina
            // 
            txtTipoCosina.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTipoCosina.Location = new Point(69, 102);
            txtTipoCosina.Name = "txtTipoCosina";
            txtTipoCosina.Size = new Size(305, 25);
            txtTipoCosina.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold);
            label2.Location = new Point(69, 82);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Cosina :";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(69, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 25);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold);
            label1.Location = new Point(69, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres :";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(12, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 248);
            panel2.TabIndex = 1;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = Color.FromArgb(255, 128, 0);
            BtnProcesar.Cursor = Cursors.AppStarting;
            BtnProcesar.FlatAppearance.BorderSize = 0;
            BtnProcesar.FlatStyle = FlatStyle.Flat;
            BtnProcesar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProcesar.ForeColor = Color.White;
            BtnProcesar.Location = new Point(299, 222);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(75, 23);
            BtnProcesar.TabIndex = 2;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.Silver;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.GridColor = SystemColors.InactiveCaption;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(446, 248);
            dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 506);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostracion PatronProductor-Consumidor";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTipoCosina;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button BtnRegistrar;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Button BtnProcesar;
    }
}
