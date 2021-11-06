
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
            this.player1_PANEL = new System.Windows.Forms.Panel();
            this.player2_PANEL = new System.Windows.Forms.Panel();
            this.containerPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePANEL
            // 
            this.gamePANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamePANEL.Location = new System.Drawing.Point(70, 109);
            this.gamePANEL.Name = "gamePANEL";
            this.gamePANEL.Size = new System.Drawing.Size(391, 353);
            this.gamePANEL.TabIndex = 0;
            this.gamePANEL.Click += new System.EventHandler(this.gamePANEL_Click);
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
            // player1_PANEL
            // 
            this.player1_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player1_PANEL.Location = new System.Drawing.Point(92, 24);
            this.player1_PANEL.Name = "player1_PANEL";
            this.player1_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player1_PANEL.TabIndex = 1;
            // 
            // player2_PANEL
            // 
            this.player2_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player2_PANEL.Location = new System.Drawing.Point(317, 24);
            this.player2_PANEL.Name = "player2_PANEL";
            this.player2_PANEL.Size = new System.Drawing.Size(117, 48);
            this.player2_PANEL.TabIndex = 2;
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
            this.containerPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePANEL;
        private System.Windows.Forms.Panel containerPANEL;
        private System.Windows.Forms.Panel player2_PANEL;
        private System.Windows.Forms.Panel player1_PANEL;
    }
}
