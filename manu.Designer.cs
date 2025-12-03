namespace WinFormsApp2
{
    partial class manu
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
            menuStrip2 = new MenuStrip();
            cuidadorToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            cajeraToolStripMenuItem = new ToolStripMenuItem();
            dueñoToolStripMenuItem = new ToolStripMenuItem();
            veterinarioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(255, 128, 255);
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { cuidadorToolStripMenuItem, empleadoToolStripMenuItem, cajeraToolStripMenuItem, dueñoToolStripMenuItem, veterinarioToolStripMenuItem, salirToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(186, 450);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // cuidadorToolStripMenuItem
            // 
            cuidadorToolStripMenuItem.Name = "cuidadorToolStripMenuItem";
            cuidadorToolStripMenuItem.Size = new Size(173, 29);
            cuidadorToolStripMenuItem.Text = "Cuidador";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(173, 29);
            empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // cajeraToolStripMenuItem
            // 
            cajeraToolStripMenuItem.Name = "cajeraToolStripMenuItem";
            cajeraToolStripMenuItem.Size = new Size(173, 29);
            cajeraToolStripMenuItem.Text = "Cajera";
            cajeraToolStripMenuItem.Click += cajeraToolStripMenuItem_Click;
            // 
            // dueñoToolStripMenuItem
            // 
            dueñoToolStripMenuItem.Name = "dueñoToolStripMenuItem";
            dueñoToolStripMenuItem.Size = new Size(173, 29);
            dueñoToolStripMenuItem.Text = "Dueño";
            dueñoToolStripMenuItem.Click += dueñoToolStripMenuItem_Click;
            // 
            // veterinarioToolStripMenuItem
            // 
            veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            veterinarioToolStripMenuItem.Size = new Size(173, 29);
            veterinarioToolStripMenuItem.Text = "Veterinario";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(173, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // manu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip2);
            Name = "manu";
            Text = "manu";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem cuidadorToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem cajeraToolStripMenuItem;
        private ToolStripMenuItem dueñoToolStripMenuItem;
        private ToolStripMenuItem veterinarioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}