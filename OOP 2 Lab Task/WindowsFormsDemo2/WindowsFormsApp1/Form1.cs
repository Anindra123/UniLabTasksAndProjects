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
    public partial class Form1 : Form
    {

        private int impostaNo = 0;
        private int susP = 0;
        Random random = new Random();
        public Form1()
        {
            GenerateImposta();
            InitializeComponent();
            susPoints.Text = Convert.ToString(susP);

        }
        public void GenerateImposta()
        {
            impostaNo = random.Next(1, 4);
        }
        private void ShowFoundImposta()
        {
            FoundImposta foundImposta = new FoundImposta();
            foundImposta.Tag = this;
            foundImposta.Show(this);
            Hide();
        }
        private void ShowKilledCrewMate()
        {
            KilledCrewMate killedCrew = new KilledCrewMate();
            killedCrew.Tag = this;
            killedCrew.Show(this);
            Hide();
        }
        private void crew_mate_1_Click(object sender, EventArgs e)
        {
            if (impostaNo == 1)
            {
                ShowFoundImposta();
            }
            else
            {
                susP++;
                susPoints.Text = Convert.ToString(susP);
                ShowKilledCrewMate();
            }
        }

        private void crew_mate_2_Click(object sender, EventArgs e)
        {
            if (impostaNo == 2)
            {
                ShowFoundImposta();
            }
            else
            {
                susP++;
                susPoints.Text = Convert.ToString(susP);
                ShowKilledCrewMate();
            }
        }

        private void crew_mate_3_Click(object sender, EventArgs e)
        {
            if (impostaNo == 3)
            {
                ShowFoundImposta();
            }
            else
            {
                susP++;
                susPoints.Text = Convert.ToString(susP);
                ShowKilledCrewMate();
            }
        }
    }
}
