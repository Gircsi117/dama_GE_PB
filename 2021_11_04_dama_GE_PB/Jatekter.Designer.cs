
namespace _2021_11_04_dama_GE_PB
{
    partial class Jatekter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamePANEL = new System.Windows.Forms.Panel();
            this.containerPANEL = new System.Windows.Forms.Panel();
            this.player2_PANEL = new System.Windows.Forms.Panel();
            this.p2LBL = new System.Windows.Forms.Label();
            this.player1_PANEL = new System.Windows.Forms.Panel();
            this.p1LBL = new System.Windows.Forms.Label();
            this.containerPANEL.SuspendLayout();
            this.player2_PANEL.SuspendLayout();
            this.player1_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePANEL
            // 
            this.gamePANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamePANEL.Location = new System.Drawing.Point(87, 111);
            this.gamePANEL.Name = "gamePANEL";
            this.gamePANEL.Size = new System.Drawing.Size(391, 353);
            this.gamePANEL.TabIndex = 0;
            // 
            // containerPANEL
            // 
            this.containerPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.containerPANEL.Controls.Add(this.player2_PANEL);
            this.containerPANEL.Controls.Add(this.player1_PANEL);
            this.containerPANEL.Controls.Add(this.gamePANEL);
            this.containerPANEL.Location = new System.Drawing.Point(102, 3);
            this.containerPANEL.Name = "containerPANEL";
            this.containerPANEL.Size = new System.Drawing.Size(556, 502);
            this.containerPANEL.TabIndex = 1;
            // 
            // player2_PANEL
            // 
            this.player2_PANEL.BackColor = System.Drawing.Color.White;
            this.player2_PANEL.Controls.Add(this.p2LBL);
            this.player2_PANEL.Location = new System.Drawing.Point(344, 24);
            this.player2_PANEL.Name = "player2_PANEL";
            this.player2_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player2_PANEL.TabIndex = 2;
            // 
            // p2LBL
            // 
            this.p2LBL.BackColor = System.Drawing.Color.White;
            this.p2LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2LBL.Location = new System.Drawing.Point(19, 7);
            this.p2LBL.Name = "p2LBL";
            this.p2LBL.Size = new System.Drawing.Size(82, 32);
            this.p2LBL.TabIndex = 4;
            this.p2LBL.Text = "label2";
            this.p2LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_PANEL
            // 
            this.player1_PANEL.BackColor = System.Drawing.Color.Black;
            this.player1_PANEL.Controls.Add(this.p1LBL);
            this.player1_PANEL.Location = new System.Drawing.Point(87, 24);
            this.player1_PANEL.Name = "player1_PANEL";
            this.player1_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player1_PANEL.TabIndex = 1;
            // 
            // p1LBL
            // 
            this.p1LBL.BackColor = System.Drawing.Color.Black;
            this.p1LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1LBL.ForeColor = System.Drawing.Color.White;
            this.p1LBL.Location = new System.Drawing.Point(16, 7);
            this.p1LBL.Name = "p1LBL";
            this.p1LBL.Size = new System.Drawing.Size(82, 32);
            this.p1LBL.TabIndex = 5;
            this.p1LBL.Text = "label1";
            this.p1LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.containerPANEL);
            this.Name = "Jatekter";
            this.Size = new System.Drawing.Size(780, 508);
            this.Load += new System.EventHandler(this.Jatekter_Load);
            this.SizeChanged += new System.EventHandler(this.Jatekter_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Jatekter_VisibleChanged);
            this.containerPANEL.ResumeLayout(false);
            this.player2_PANEL.ResumeLayout(false);
            this.player1_PANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePANEL;
        private System.Windows.Forms.Panel containerPANEL;
        private System.Windows.Forms.Panel player2_PANEL;
        private System.Windows.Forms.Panel player1_PANEL;
        private System.Windows.Forms.Label p2LBL;
        private System.Windows.Forms.Label p1LBL;
    }
}
