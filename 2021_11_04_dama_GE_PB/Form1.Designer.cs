
namespace _2021_11_04_dama_GE_PB
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
            this.fullBTN = new System.Windows.Forms.Button();
            this.headerPANEL = new System.Windows.Forms.Panel();
            this.menu1 = new _2021_11_04_dama_GE_PB.Menu();
            this.headerPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullBTN
            // 
            this.fullBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullBTN.Location = new System.Drawing.Point(1142, 0);
            this.fullBTN.Name = "fullBTN";
            this.fullBTN.Size = new System.Drawing.Size(51, 30);
            this.fullBTN.TabIndex = 0;
            this.fullBTN.Text = "Full";
            this.fullBTN.UseVisualStyleBackColor = true;
            this.fullBTN.Click += new System.EventHandler(this.fullBTN_Click);
            // 
            // headerPANEL
            // 
            this.headerPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.headerPANEL.Controls.Add(this.fullBTN);
            this.headerPANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPANEL.Location = new System.Drawing.Point(0, 0);
            this.headerPANEL.Margin = new System.Windows.Forms.Padding(0);
            this.headerPANEL.Name = "headerPANEL";
            this.headerPANEL.Size = new System.Drawing.Size(1193, 30);
            this.headerPANEL.TabIndex = 3;
            this.headerPANEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseDown);
            this.headerPANEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseMove);
            this.headerPANEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseUp);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 30);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1193, 600);
            this.menu1.TabIndex = 4;
            this.menu1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_nezet);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1193, 630);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.headerPANEL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Menu menu1;
        private System.Windows.Forms.Button fullBTN;
        private System.Windows.Forms.Panel headerPANEL;
    }
}

