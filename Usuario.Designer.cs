namespace WinFormsApp2
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            comboBox1 = new ComboBox();
            label8 = new Label();
            txtid = new TextBox();
            txtcedula = new TextBox();
            txtcorreo = new TextBox();
            txtedad = new TextBox();
            txtnombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnbloquear = new Button();
            btnConsultar = new Button();
            btnActualizar = new Button();
            btnIngresar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnUsuario = new Button();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TablaInformacion = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaInformacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.ForeColor = SystemColors.InactiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dueño", "Empleado", "Cajero", "Veterinario", "Salir" });
            comboBox1.Location = new Point(400, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(803, 33);
            comboBox1.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 255);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(-49, -12);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 43;
            label8.Text = "Perfil";
            // 
            // txtid
            // 
            txtid.BackColor = Color.Black;
            txtid.ForeColor = SystemColors.InactiveBorder;
            txtid.Location = new Point(488, 183);
            txtid.Name = "txtid";
            txtid.Size = new Size(150, 31);
            txtid.TabIndex = 42;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // txtcedula
            // 
            txtcedula.BackColor = Color.Black;
            txtcedula.ForeColor = SystemColors.InactiveBorder;
            txtcedula.Location = new Point(488, 229);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(150, 31);
            txtcedula.TabIndex = 41;
            // 
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.Black;
            txtcorreo.ForeColor = SystemColors.InactiveBorder;
            txtcorreo.Location = new Point(488, 277);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(150, 31);
            txtcorreo.TabIndex = 40;
            // 
            // txtedad
            // 
            txtedad.BackColor = Color.Black;
            txtedad.ForeColor = SystemColors.InactiveBorder;
            txtedad.Location = new Point(488, 403);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(150, 31);
            txtedad.TabIndex = 39;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.Black;
            txtnombre.ForeColor = SystemColors.InactiveBorder;
            txtnombre.Location = new Point(488, 340);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(150, 31);
            txtnombre.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Location = new Point(318, 403);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 37;
            label7.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Location = new Point(315, 340);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 36;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Location = new Point(315, 277);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 35;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Location = new Point(315, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 34;
            label4.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(315, 183);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 33;
            label3.Text = "Id:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnbloquear
            // 
            btnbloquear.BackColor = Color.Silver;
            btnbloquear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbloquear.Location = new Point(1050, 249);
            btnbloquear.Name = "btnbloquear";
            btnbloquear.Size = new Size(186, 88);
            btnbloquear.TabIndex = 31;
            btnbloquear.Text = "Bloquear usuarios";
            btnbloquear.UseVisualStyleBackColor = false;
            btnbloquear.Click += btnbloquear_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Silver;
            btnConsultar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(779, 249);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(253, 87);
            btnConsultar.TabIndex = 30;
            btnConsultar.Text = "Consultar todos los usuarios ";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(1050, 162);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 69);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar Informacion";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.BackColor = Color.Silver;
            btnIngresar.BackgroundImageLayout = ImageLayout.Center;
            btnIngresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(779, 159);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(253, 72);
            btnIngresar.TabIndex = 28;
            btnIngresar.Text = "Ingresar nuevos usuarios";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Id
            // 
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Nombre
            // 
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Login
            // 
            Login.HeaderText = "Login";
            Login.MinimumWidth = 8;
            Login.Name = "Login";
            Login.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Perfil";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Correo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(192, 192, 255);
            btnUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.Location = new Point(82, 565);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(112, 34);
            btnUsuario.TabIndex = 26;
            btnUsuario.Text = "Ingresar";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(59, 510);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 25;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(59, 413);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 24;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(-50, 341);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 23;
            label2.Text = "clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(-69, 237);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 22;
            label1.Text = "usuario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 255);
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(32, 24);
            label9.Name = "label9";
            label9.Size = new Size(78, 26);
            label9.TabIndex = 45;
            label9.Text = "Perfil:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(82, 363);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 46;
            label10.Text = "Usuario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(64, 466);
            label11.Name = "label11";
            label11.Size = new Size(130, 26);
            label11.TabIndex = 47;
            label11.Text = "Contraseña";
            // 
            // TablaInformacion
            // 
            TablaInformacion.BackgroundColor = Color.FromArgb(192, 255, 255);
            TablaInformacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaInformacion.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7 });
            TablaInformacion.GridColor = SystemColors.WindowText;
            TablaInformacion.Location = new Point(264, 510);
            TablaInformacion.Name = "TablaInformacion";
            TablaInformacion.RowHeadersWidth = 62;
            TablaInformacion.Size = new Size(968, 142);
            TablaInformacion.TabIndex = 49;
            TablaInformacion.CellClick += TablaInformacion_CellClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "id";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cedula";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Correo";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Nombre";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Edad";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Estado";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.CadetBlue;
            btnbuscar.Cursor = Cursors.AppStarting;
            btnbuscar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ImageAlign = ContentAlignment.BottomRight;
            btnbuscar.ImageKey = "(ninguna)";
            btnbuscar.Location = new Point(32, 73);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(332, 34);
            btnbuscar.TabIndex = 50;
            btnbuscar.Text = "Consultar todos los Usuarios:";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(400, 75);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(803, 31);
            txtbuscar.TabIndex = 51;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.PowderBlue;
            pictureBox2.Location = new Point(779, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 55);
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1248, 711);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(TablaInformacion);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(txtid);
            Controls.Add(txtcedula);
            Controls.Add(txtcorreo);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnbloquear);
            Controls.Add(btnConsultar);
            Controls.Add(btnActualizar);
            Controls.Add(btnIngresar);
            Controls.Add(btnUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Usuario";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaInformacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label8;
        private TextBox txtid;
        private TextBox txtcedula;
        private TextBox txtcorreo;
        private TextBox txtedad;
        private TextBox txtnombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnbloquear;
        private Button btnConsultar;
     
        private Button btnIngresar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Column1;
        private Button btnUsuario;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView TablaInformacion;
        private Button btnActualizar;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private PictureBox pictureBox2;
    }
}