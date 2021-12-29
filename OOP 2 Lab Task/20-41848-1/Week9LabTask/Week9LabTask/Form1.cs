using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9LabTask
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void yesFoolBtn_Click(object sender, EventArgs e)
        {
            FoolFormYes foolFormYes = new FoolFormYes();
            foolFormYes.Tag = this;
            foolFormYes.Show(this);
            this.Hide();
        }

        private void NotAFoolBtn_MouseEnter(object sender, EventArgs e)
        {
            NotAFoolBtn.Location = new Point(random.Next(500), random.Next(300));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Z)
            {
                NotAFoolForm notAFool = new NotAFoolForm();
                notAFool.Tag = this;
                notAFool.Show(this);
                this.Hide();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
