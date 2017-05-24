using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace AutoShutdownRestartSleep
{
    public partial class HomeForm : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            comboBox_Option.SelectedIndex = 0;
            cmb_Hours.SelectedIndex = 0;

            for (int i = 0; i <= 24; i++)
            {
                cmb_Hours.Items.Add(i);
            }
            cmb_Minites.SelectedIndex = 0;
            for (int i = 0; i < 61; i = i + 10)
            {
                cmb_Minites.Items.Add(i);
            }
        }
        private void comboBox_Option_TextChanged(object sender, EventArgs e)
        {
            string mode = comboBox_Option.Text;
            if (mode == "Shutdown")
            {
                DisableTime();
                int hours = Int32.Parse(cmb_Hours.Text);
                int minites = Int32.Parse(cmb_Minites.Text);
                int totalTime = (hours * 3600) + (minites * 60);
                Process.Start("shutdown", "/s /t " + totalTime + "");




                MessageBox.Show("Shutdown");
                //Process.Start("shutdown", "/s /t 0");
                //shutdown -s -t 0 - Shutdown
                //shutdown -r -t 0 - Restart
            }
            else if (mode == "Restart")
            {
                DisableTime();
                MessageBox.Show("Restart");
            }
            else if (mode == "Sleep")
            {
                DisableTime();
                MessageBox.Show("Sleep");
            }
        }

        private void DisableTime()
        {
            cmb_Hours.Enabled = false;
            cmb_Minites.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
