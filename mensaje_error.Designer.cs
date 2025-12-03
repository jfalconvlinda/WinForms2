namespace WinFormsApp2
{
    partial class mensaje_error
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
            btn_Salir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Black;
            btn_Salir.ForeColor = SystemColors.ButtonFace;
            btn_Salir.Location = new Point(303, 325);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(248, 64);
            btn_Salir.TabIndex = 0;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(332, 78);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Mensaje de Error";
            // 
            // mensaje_error
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Name = "mensaje_error";
            Text = "mensaje_error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Salir;
        private Label label1;
    }
}