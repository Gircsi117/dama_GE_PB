
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.alapPANEl = new System.Windows.Forms.Panel();
            this.infoBTN = new System.Windows.Forms.Button();
            this.settingBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.p1TBOX = new System.Windows.Forms.TextBox();
            this.p2TBOX = new System.Windows.Forms.TextBox();
            this.cimLBL = new System.Windows.Forms.Label();
            this.alapPANEl.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBTN.Location = new System.Drawing.Point(176, 368);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(140, 38);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.TabStop = false;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBTN_MouseClick);
            // 
            // alapPANEl
            // 
            this.alapPANEl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.alapPANEl.Controls.Add(this.exitBTN);
            this.alapPANEl.Controls.Add(this.infoBTN);
            this.alapPANEl.Controls.Add(this.settingBTN);
            this.alapPANEl.Controls.Add(this.startBTN);
            this.alapPANEl.Controls.Add(this.p1TBOX);
            this.alapPANEl.Controls.Add(this.p2TBOX);
            this.alapPANEl.Controls.Add(this.cimLBL);
            this.alapPANEl.Location = new System.Drawing.Point(12, 12);
            this.alapPANEl.Name = "alapPANEl";
            this.alapPANEl.Size = new System.Drawing.Size(500, 500);
            this.alapPANEl.TabIndex = 2;
            // 
            // infoBTN
            // 
            this.infoBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoBTN.Location = new System.Drawing.Point(176, 296);
            this.infoBTN.Name = "infoBTN";
            this.infoBTN.Size = new System.Drawing.Size(140, 41);
            this.infoBTN.TabIndex = 6;
            this.infoBTN.TabStop = false;
            this.infoBTN.Text = "Info";
            this.infoBTN.UseVisualStyleBackColor = true;
            this.infoBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.infoBTN_MouseClick);
            // 
            // settingBTN
            // 
            this.settingBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingBTN.Location = new System.Drawing.Point(176, 250);
            this.settingBTN.Name = "settingBTN";
            this.settingBTN.Size = new System.Drawing.Size(140, 40);
            this.settingBTN.TabIndex = 5;
            this.settingBTN.TabStop = false;
            this.settingBTN.Text = "Settings";
            this.settingBTN.UseVisualStyleBackColor = true;
            this.settingBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingBTN_MouseClick);
            // 
            // startBTN
            // 
            this.startBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startBTN.Location = new System.Drawing.Point(176, 207);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(140, 37);
            this.startBTN.TabIndex = 4;
            this.startBTN.TabStop = false;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBTN_MouseClick);
            // 
            // p1TBOX
            // 
            this.p1TBOX.BackColor = System.Drawing.Color.Black;
            this.p1TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1TBOX.ForeColor = System.Drawing.Color.White;
            this.p1TBOX.Location = new System.Drawing.Point(31, 122);
            this.p1TBOX.Margin = new System.Windows.Forms.Padding(0);
            this.p1TBOX.Name = "p1TBOX";
            this.p1TBOX.Size = new System.Drawing.Size(191, 48);
            this.p1TBOX.TabIndex = 1;
            this.p1TBOX.TabStop = false;
            this.p1TBOX.Text = "Player1";
            this.p1TBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2TBOX
            // 
            this.p2TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2TBOX.Location = new System.Drawing.Point(278, 122);
            this.p2TBOX.Margin = new System.Windows.Forms.Padding(0);
            this.p2TBOX.Name = "p2TBOX";
            this.p2TBOX.Size = new System.Drawing.Size(191, 48);
            this.p2TBOX.TabIndex = 1;
            this.p2TBOX.TabStop = false;
            this.p2TBOX.Text = "Player2";
            this.p2TBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cimLBL
            // 
            this.cimLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cimLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimLBL.Location = new System.Drawing.Point(0, 0);
            this.cimLBL.Margin = new System.Windows.Forms.Padding(0);
            this.cimLBL.Name = "cimLBL";
            this.cimLBL.Size = new System.Drawing.Size(500, 88);
            this.cimLBL.TabIndex = 0;
            this.cimLBL.Text = "Dáma strike";
            this.cimLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1296, 680);
            this.Controls.Add(this.alapPANEl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.alapPANEl.ResumeLayout(false);
            this.alapPANEl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Panel alapPANEl;
        private System.Windows.Forms.TextBox p2TBOX;
        private System.Windows.Forms.TextBox p1TBOX;
        private System.Windows.Forms.Label cimLBL;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button settingBTN;
        private System.Windows.Forms.Button infoBTN;
    }
}

