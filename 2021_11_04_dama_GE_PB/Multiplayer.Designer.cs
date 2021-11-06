
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
            this.felkialtoPANEL_1 = new System.Windows.Forms.Panel();
            this.felkialtoPANEL_2 = new System.Windows.Forms.Panel();
            this.downloadBTN = new System.Windows.Forms.Button();
            this.szovegLBL = new System.Windows.Forms.Label();
            this.infoPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPANEL
            // 
            this.infoPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.infoPANEL.Controls.Add(this.szovegLBL);
            this.infoPANEL.Controls.Add(this.downloadBTN);
            this.infoPANEL.Controls.Add(this.felkialtoPANEL_2);
            this.infoPANEL.Controls.Add(this.felkialtoPANEL_1);
            this.infoPANEL.Location = new System.Drawing.Point(154, 26);
            this.infoPANEL.Name = "infoPANEL";
            this.infoPANEL.Size = new System.Drawing.Size(440, 468);
            this.infoPANEL.TabIndex = 0;
            // 
            // felkialtoPANEL_1
            // 
            this.felkialtoPANEL_1.BackColor = System.Drawing.Color.Red;
            this.felkialtoPANEL_1.Location = new System.Drawing.Point(204, 3);
            this.felkialtoPANEL_1.Name = "felkialtoPANEL_1";
            this.felkialtoPANEL_1.Size = new System.Drawing.Size(45, 101);
            this.felkialtoPANEL_1.TabIndex = 0;
            // 
            // felkialtoPANEL_2
            // 
            this.felkialtoPANEL_2.BackColor = System.Drawing.Color.Red;
            this.felkialtoPANEL_2.Location = new System.Drawing.Point(204, 110);
            this.felkialtoPANEL_2.Name = "felkialtoPANEL_2";
            this.felkialtoPANEL_2.Size = new System.Drawing.Size(45, 41);
            this.felkialtoPANEL_2.TabIndex = 1;
            // 
            // downloadBTN
            // 
            this.downloadBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadBTN.BackColor = System.Drawing.Color.Lime;
            this.downloadBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downloadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadBTN.Location = new System.Drawing.Point(0, 349);
            this.downloadBTN.Name = "downloadBTN";
            this.downloadBTN.Size = new System.Drawing.Size(440, 119);
            this.downloadBTN.TabIndex = 5;
            this.downloadBTN.TabStop = false;
            this.downloadBTN.Text = "BUY NOW!";
            this.downloadBTN.UseVisualStyleBackColor = false;
            this.downloadBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.downloadBTN_MouseClick);
            // 
            // szovegLBL
            // 
            this.szovegLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szovegLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.szovegLBL.Location = new System.Drawing.Point(0, 225);
            this.szovegLBL.Name = "szovegLBL";
            this.szovegLBL.Size = new System.Drawing.Size(440, 124);
            this.szovegLBL.TabIndex = 6;
            this.szovegLBL.Text = "Ez a funkció a jelen verzióban nem elérhető.\r\nHa támogatni akarja a munkánkat, ké" +
    "rem vásárolja meg a telljes verziót.\r\n\r\nTeljes vezió: 49,99$\r\n\r\n";
            this.szovegLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.infoPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPANEL;
        private System.Windows.Forms.Panel felkialtoPANEL_2;
        private System.Windows.Forms.Panel felkialtoPANEL_1;
        private System.Windows.Forms.Button downloadBTN;
        private System.Windows.Forms.Label szovegLBL;
    }
}
