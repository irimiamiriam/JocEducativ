using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ.Forms
{
    public partial class SarpeEducativ : Form
    {
        public SarpeEducativ()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;

        }

        private void SarpeEducativ_Load(object sender, EventArgs e)
        {

        }
    }
}
