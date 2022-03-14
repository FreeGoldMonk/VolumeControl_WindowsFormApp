/*
//2022-03-13: https://www.dotnetcurry.com/ShowArticle.aspx?ID=431
//Programmatically Increase, Decrease and Mute the Volume
//Försökte, men denna appen fick jag inte att fungera
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VolumeControl_WindowsFormApp
{
    public partial class Form1 : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")] //c:\Windows\System32\user32.dll
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void btnDecVol_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void btnIncVol_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
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
            this.btnMute = new System.Windows.Forms.Button();
            this.btnDecVol = new System.Windows.Forms.Button();
            this.btnIncVol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(41, 24);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(187, 82);
            this.btnMute.TabIndex = 0;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            // 
            // btnDecVol
            // 
            this.btnDecVol.Location = new System.Drawing.Point(42, 153);
            this.btnDecVol.Name = "btnDecVol";
            this.btnDecVol.Size = new System.Drawing.Size(186, 76);
            this.btnDecVol.TabIndex = 1;
            this.btnDecVol.Text = "Decrese volume";
            this.btnDecVol.UseVisualStyleBackColor = true;
            // 
            // btnIncVol
            // 
            this.btnIncVol.Location = new System.Drawing.Point(42, 275);
            this.btnIncVol.Name = "btnIncVol";
            this.btnIncVol.Size = new System.Drawing.Size(189, 70);
            this.btnIncVol.TabIndex = 2;
            this.btnIncVol.Text = "Increase volume";
            this.btnIncVol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 439);
            this.Controls.Add(this.btnIncVol);
            this.Controls.Add(this.btnDecVol);
            this.Controls.Add(this.btnMute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMute;
        private Button btnDecVol;
        private Button btnIncVol;
    }
}
*/