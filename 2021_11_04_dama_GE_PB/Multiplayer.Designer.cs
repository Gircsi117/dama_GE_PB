
namespace _2021_11_04_dama_GE_PB
{
    partial class Multiplayer
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
            this.infoPANEL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // infoPANEL
            // 
            this.infoPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infoPANEL.Location = new System.Drawing.Point(154, 26);
            this.infoPANEL.Name = "infoPANEL";
            this.infoPANEL.Size = new System.Drawing.Size(440, 468);
            this.infoPANEL.TabIndex = 0;
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.infoPANEL);
            this.Name = "Multiplayer";
            this.Size = new System.Drawing.Size(793, 553);
            this.Load += new System.EventHandler(this.Multiplayer_Load);
            this.Resize += new System.EventHandler(this.Multiplayer_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPANEL;
    }
}
