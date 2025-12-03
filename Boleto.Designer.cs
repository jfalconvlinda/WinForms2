namespace WinFormsApp2
{
    partial class Boleto
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAdulto = new TextBox();
            txtNino = new TextBox();
            txtTerceraEdad = new TextBox();
            txtTotal = new TextBox();
            label7 = new Label();
            btnComprar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 73);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 124);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 2;
            label2.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 3;
            label3.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(370, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(370, 139);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(150, 31);
            txtCedula.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(370, 192);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(693, 139);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 10;
            label4.Text = "Adulto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 73);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 10;
            label5.Text = "Niño";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 192);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 10;
            label6.Text = "TerceraEdad";
            // 
            // txtAdulto
            // 
            txtAdulto.Location = new Point(844, 133);
            txtAdulto.Name = "txtAdulto";
            txtAdulto.Size = new Size(150, 31);
            txtAdulto.TabIndex = 11;
            // 
            // txtNino
            // 
            txtNino.Location = new Point(844, 73);
            txtNino.Name = "txtNino";
            txtNino.Size = new Size(150, 31);
            txtNino.TabIndex = 11;
            // 
            // txtTerceraEdad
            // 
            txtTerceraEdad.Location = new Point(844, 192);
            txtTerceraEdad.Name = "txtTerceraEdad";
            txtTerceraEdad.Size = new Size(150, 31);
            txtTerceraEdad.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(526, 366);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 369);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 13;
            label7.Text = "Total";
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(286, 452);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(112, 34);
            btnComprar.TabIndex = 14;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(693, 452);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Boleto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1093, 638);
            Controls.Add(btnSalir);
            Controls.Add(btnComprar);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(txtNino);
            Controls.Add(txtTerceraEdad);
            Controls.Add(txtAdulto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Boleto";
            Text = "Boleto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAdulto;
        private TextBox txtNino;
        private TextBox txtTerceraEdad;
        private TextBox txtTotal;
        private Label label7;
        private Button btnComprar;
        private Button btnSalir;
    }
}