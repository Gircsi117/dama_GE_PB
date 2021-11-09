
namespace _2021_11_04_dama_GE_PB
{
    partial class PauseScreen
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
            this.centerPANEL = new System.Windows.Forms.Panel();
            this.menuBTN = new System.Windows.Forms.Button();
            this.screenBTN = new System.Windows.Forms.Button();
            this.newgameBTN = new System.Windows.Forms.Button();
            this.contineueBTN = new System.Windows.Forms.Button();
            this.centerPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPANEL
            // 
            this.centerPANEL.Controls.Add(this.menuBTN);
            this.centerPANEL.Controls.Add(this.screenBTN);
            this.centerPANEL.Controls.Add(this.newgameBTN);
            this.centerPANEL.Controls.Add(this.contineueBTN);
            this.centerPANEL.Location = new System.Drawing.Point(127, 56);
            this.centerPANEL.Name = "centerPANEL";
            this.centerPANEL.Size = new System.Drawing.Size(422, 422);
            this.centerPANEL.TabIndex = 0;
            // 
            // menuBTN
            // 
            this.menuBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBTN.Location = new System.Drawing.Point(135, 287);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(140, 37);
            this.menuBTN.TabIndex = 8;
            this.menuBTN.TabStop = false;
            this.menuBTN.Text = "Back to menu";
            this.menuBTN.UseVisualStyleBackColor = true;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // screenBTN
            // 
            this.screenBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenBTN.Location = new System.Drawing.Point(135, 212);
            this.screenBTN.Name = "screenBTN";
            this.screenBTN.Size = new System.Drawing.Size(140, 37);
            this.screenBTN.TabIndex = 7;
            this.screenBTN.TabStop = false;
            this.screenBTN.Text = "Full screen";
            this.screenBTN.UseVisualStyleBackColor = true;
            this.screenBTN.Click += new System.EventHandler(this.screenBTN_Click);
            // 
            // newgameBTN
            // 
            this.newgameBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newgameBTN.Location = new System.Drawing.Point(135, 141);
            this.newgameBTN.Name = "newgameBTN";
            this.newgameBTN.Size = new System.Drawing.Size(140, 37);
            this.newgameBTN.TabIndex = 6;
            this.newgameBTN.TabStop = false;
            this.newgameBTN.Text = "New game";
            this.newgameBTN.UseVisualStyleBackColor = true;
            this.newgameBTN.Click += new System.EventHandler(this.newgameBTN_Click);
            // 
            // contineueBTN
            // 
            this.contineueBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contineueBTN.Location = new System.Drawing.Point(135, 68);
            this.contineueBTN.Name = "contineueBTN";
            this.contineueBTN.Size = new System.Drawing.Size(140, 37);
            this.contineueBTN.TabIndex = 5;
            this.contineueBTN.TabStop = false;
            this.contineueBTN.Text = "Continue";
            this.contineueBTN.UseVisualStyleBackColor = true;
            this.contineueBTN.Click += new System.EventHandler(this.contineueBTN_Click);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.centerPANEL);
            this.Name = "PauseScreen";
            this.Size = new System.Drawing.Size(680, 567);
            this.Load += new System.EventHandler(this.PauseScreen_Load);
            this.SizeChanged += new System.EventHandler(this.PauseScreen_SizeChanged);
            this.centerPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPANEL;
        private System.Windows.Forms.Button menuBTN;
        private System.Windows.Forms.Button screenBTN;
        private System.Windows.Forms.Button newgameBTN;
        private System.Windows.Forms.Button contineueBTN;
    }
}
