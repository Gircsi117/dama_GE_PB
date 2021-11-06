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
    public partial class Multiplayer : UserControl
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            global.meretez_alap(infoPANEL, this);
        }

        private void Multiplayer_Resize(object sender, EventArgs e)
        {
            global.meretez_alap(infoPANEL, this);
        }
    }
}
