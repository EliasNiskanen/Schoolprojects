using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHenkilot : Form
    {
        public FrmHenkilot()
        {
            InitializeComponent();
        }
        public FrmHenkilot(LaskinLomake ll)
        {
            InitializeComponent();

            foreach (var item in ll.henkilot)
            {
                lbHenkilot.Items.Add(item.PalautaTiedot());
            }
        }

    }
}
