namespace aApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblPreferencia = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblHistorial = new Label();
            lblDNI2 = new Label();
            lblEnviar = new Label();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtPreferencia = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtHistorial = new TextBox();
            btnAgregar = new Button();
            btnVer = new Button();
            btnEnviar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Green;
            lblTitulo.Location = new Point(336, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carga de clientes";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(40, 131);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(231, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblPreferencia
            // 
            lblPreferencia.AutoSize = true;
            lblPreferencia.ForeColor = Color.Green;
            lblPreferencia.Location = new Point(431, 131);
            lblPreferencia.Name = "lblPreferencia";
            lblPreferencia.Size = new Size(66, 15);
            lblPreferencia.TabIndex = 3;
            lblPreferencia.Text = "Preferencia";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Green;
            lblDireccion.Location = new Point(625, 131);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(119, 180);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Green;
            lblTelefono.Location = new Point(317, 180);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.Green;
            lblHistorial.Location = new Point(353, 228);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(180, 18);
            lblHistorial.TabIndex = 7;
            lblHistorial.Text = "Historial de Pedidos";
            // 
            // lblDNI2
            // 
            lblDNI2.AutoSize = true;
            lblDNI2.ForeColor = Color.Green;
            lblDNI2.Location = new Point(330, 272);
            lblDNI2.Name = "lblDNI2";
            lblDNI2.Size = new Size(27, 15);
            lblDNI2.TabIndex = 8;
            lblDNI2.Text = "DNI";
            // 
            // lblEnviar
            // 
            lblEnviar.AutoSize = true;
            lblEnviar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnviar.ForeColor = Color.Green;
            lblEnviar.Location = new Point(353, 313);
            lblEnviar.Name = "lblEnviar";
            lblEnviar.Size = new Size(167, 18);
            lblEnviar.TabIndex = 9;
            lblEnviar.Text = "Enviar notificacion";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(85, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(92, 23);
            txtDNI.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(288, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtPreferencia
            // 
            txtPreferencia.Location = new Point(503, 128);
            txtPreferencia.Name = "txtPreferencia";
            txtPreferencia.Size = new Size(100, 23);
            txtPreferencia.TabIndex = 12;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(688, 128);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(182, 177);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(389, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(389, 264);
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(100, 23);
            txtHistorial.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(516, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVer
            // 
            btnVer.ForeColor = Color.Green;
            btnVer.Location = new Point(516, 264);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 18;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.ForeColor = Color.Green;
            btnEnviar.Location = new Point(405, 343);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 19;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(220, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 82);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnEnviar);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(txtHistorial);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtPreferencia);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblEnviar);
            Controls.Add(lblDNI2);
            Controls.Add(lblHistorial);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblDireccion);
            Controls.Add(lblPreferencia);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblTitulo);
            ForeColor = Color.Green;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblPreferencia;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblHistorial;
        private Label lblDNI2;
        private Label lblEnviar;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtPreferencia;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtHistorial;
        private Button btnAgregar;
        private Button btnVer;
        private Button btnEnviar;
        private PictureBox pictureBox1;
    }
}
