using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            bntInicio = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 26);
            label1.TabIndex = 0;
            label1.Text = "La Ménagerie";
            // 
            // bntInicio
            // 
            bntInicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntInicio.Location = new Point(417, 404);
            bntInicio.Name = "bntInicio";
            bntInicio.Size = new Size(112, 34);
            bntInicio.TabIndex = 1;
            bntInicio.Text = "Inicio";
            bntInicio.UseVisualStyleBackColor = true;
            bntInicio.Click += bntInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bntInicio);
            Controls.Add(label1);
            Name = "Main";
            Text = "main";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Button bntInicio;
        private PictureBox pictureBox1;
    }
}
