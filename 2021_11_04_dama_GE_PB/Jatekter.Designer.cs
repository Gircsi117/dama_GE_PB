
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
            this.SuspendLayout();
            // 
            // gamePANEL
            // 
            this.gamePANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamePANEL.Location = new System.Drawing.Point(3, 3);
            this.gamePANEL.Name = "gamePANEL";
            this.gamePANEL.Size = new System.Drawing.Size(448, 410);
            this.gamePANEL.TabIndex = 0;
            this.gamePANEL.Click += new System.EventHandler(this.gamePANEL_Click);
            // 
            // Jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.gamePANEL);
            this.Name = "Jatekter";
            this.Size = new System.Drawing.Size(568, 500);
            this.Load += new System.EventHandler(this.Jatekter_Load);
            this.SizeChanged += new System.EventHandler(this.Jatekter_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePANEL;
    }
}
