namespace UI
{
    partial class AdministracionCliente
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            TxtNumero = new Label();
            textBox3 = new TextBox();
            TxtCorreo = new Label();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnAnular = new Button();
            dataGridView1 = new DataGridView();
            GridClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 23);
            textBox2.TabIndex = 3;
            // 
            // TxtNumero
            // 
            TxtNumero.AutoSize = true;
            TxtNumero.Location = new Point(30, 95);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(114, 15);
            TxtNumero.TabIndex = 2;
            TxtNumero.Text = "Numero de telefono";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 23);
            textBox3.TabIndex = 5;
            // 
            // TxtCorreo
            // 
            TxtCorreo.AutoSize = true;
            TxtCorreo.Location = new Point(30, 164);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(43, 15);
            TxtCorreo.TabIndex = 4;
            TxtCorreo.Text = "Correo";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(30, 236);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 23);
            BtnNuevo.TabIndex = 6;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(154, 236);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnAnular
            // 
            BtnAnular.Location = new Point(273, 236);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(75, 23);
            BtnAnular.TabIndex = 8;
            BtnAnular.Text = "Anular";
            BtnAnular.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(336, 168);
            dataGridView1.TabIndex = 9;
            // 
            // GridClientes
            // 
            GridClientes.AutoSize = true;
            GridClientes.Location = new Point(30, 280);
            GridClientes.Name = "GridClientes";
            GridClientes.Size = new Size(106, 15);
            GridClientes.TabIndex = 10;
            GridClientes.Text = "Listado de Clientes";
            GridClientes.Click += Lista_Click;
            // 
            // AdministracionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 478);
            Controls.Add(GridClientes);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAnular);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(textBox3);
            Controls.Add(TxtCorreo);
            Controls.Add(textBox2);
            Controls.Add(TxtNumero);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AdministracionCliente";
            Text = "AdministracionCliente";
            Load += AdministracionCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label TxtNumero;
        private TextBox textBox3;
        private Label TxtCorreo;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnAnular;
        private DataGridView dataGridView1;
        private Label GridClientes;
    }
}