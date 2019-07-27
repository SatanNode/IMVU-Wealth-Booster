using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace IMVUWealthBooster
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                Seal.InitializeForm("8S9UDWnRx5fIM0ARbQG8nVHkLSBEjz9ABNbOsP7LZuQ3j", "1.0", this, new Form1(), SealColours.Purple);
                
            }
        }

    }
}
