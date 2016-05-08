using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeoriaTechnologyIntakeSheet
{
    public partial class TimeClock : Form
    {
        public TimeClock()
        {
            InitializeComponent();
        }

        private void employeeIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Config.dbConnectString());
           MessageBox.Show(DataBase.Post(DataBase.timeClockurl(), Config.dbConnectString() + "&employeeID=" + employeeIDBox.Text + "&clockAction=1"));
        }

        private void ClockOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataBase.Post(DataBase.timeClockurl(), Config.dbConnectString() + "&employeeID=" + employeeIDBox.Text + "&clockAction=0"));
        }
    }
}
