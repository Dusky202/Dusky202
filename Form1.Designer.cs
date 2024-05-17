using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dusky202
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.SystemColors.Control;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLock.Image = global::Dusky202.Properties.Resources._2;
            this.btnLock.Location = new System.Drawing.Point(-1, -1);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(183, 184);
            this.btnLock.TabIndex = 1;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.FlatAppearance.BorderSize = 0;
            this.btnUnlock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnlock.Image = global::Dusky202.Properties.Resources._1;
            this.btnUnlock.Location = new System.Drawing.Point(-1, -1);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(183, 184);
            this.btnUnlock.TabIndex = 2;
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnlock);
            this.panel1.Controls.Add(this.btnLock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 181);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(180, 181);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Lock";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SetCircularButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Width = button.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);
        }

        #endregion

        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private Panel panel1;
    }
}

