using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_11_04_dama_GE_PB
{
    public partial class PauseScreen : UserControl
    {
        public PauseScreen()
        {
            InitializeComponent();
        }

        private void PauseScreen_Load(object sender, EventArgs e)
        {
            global.meretez_alap(centerPANEL, this);
        }

        private void PauseScreen_SizeChanged(object sender, EventArgs e)
        {
            Button[] gombok = new Button[4] {contineueBTN, newgameBTN, screenBTN, menuBTN };
            int magas = 0;
            int egyseg = centerPANEL.Width / 24;

            for (int i = 0; i < gombok.Length; i++)
            {
                gombok[i].Size = new Size(egyseg * 18, egyseg * 3);
            }
            
        }
    }
}
