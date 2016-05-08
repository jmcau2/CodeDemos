using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace PeoriaTechnologyIntakeSheet
{

    //The strings that start with a capital letter refer to the strings that
    //are passed in via the constructor.  Lower case ones are the variables
    //used to construct the byte stream to hit the database.

    public partial class serviceCallForm : Form
    {
        //This the location of the php script that handles the addition or update
        //of a service call.  Needs to be bumped to be handled by config file.
        string serviceCallPhpForm = Config.PHPFolder + "/add_servicecall.php";

        Form1 frm1;

        public serviceCallForm(Form1 parent, string ID, string FirstName, string LastName, string PhoneNumber, string EMail,
            string Address, string City, string State, string Zip, string Time,
            string DescriptionOfProblems, string AppointmentDate)
        {


            //If any data was passed to the form, this puts everything into their respective textboxes.
            InitializeComponent();

            frm1 = parent;
            firstNameTextBox.Text = FirstName;
            lastNameTextBox.Text = LastName;
            phoneNumberTextBox.Text = PhoneNumber;
            addressTextBox.Text = Address;
            cityTextBox.Text = City;
            stateTextBox.Text = State;
            zipTextBox.Text = Zip;
            appointmentDateTextBox.Text = AppointmentDate;
            descriptionOfProblemsTextBox.Text = DescriptionOfProblems;
            timeTextBox.Text = Time;

        }

        

        private void addUpdateServiceCall_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show(DataBase.Post(serviceCallPhpForm, serviceCallInfoString()));
            
            frm1.RefreshForm();
            
            this.Close();

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
        }

        private void EMailTextBox_TextChanged(object sender, EventArgs e)
        {
            string eMail = EMailTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            string address = addressTextBox.Text;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            string city = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            string state = stateTextBox.Text;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            string zip = zipTextBox.Text;
        }

        private void appointmentDateTextBox_TextChanged(object sender, EventArgs e)
        {
            string appointmentDate = appointmentDateTextBox.Text;
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            string time = timeTextBox.Text;
        }

        private void descriptionOfProblemsTextBox_TextChanged(object sender, EventArgs e)
        {
            string descriptionOfProblems = descriptionOfProblemsTextBox.Text;
        }

        private void serviceCallCompleteButton_Click(object sender, EventArgs e)
        {

        }

        private string serviceCallInfoString()
        { 

            return "ID=" + serviceCallIDLabel.Text + "&" + Config.dbConnectString() + "&First_Name=" + firstNameTextBox.Text + "&Last_Name=" + lastNameTextBox.Text +
            "&Phone_Number=" + phoneNumberTextBox.Text + "&EMail=" + EMailTextBox.Text + "&Address=" + addressTextBox.Text +
            "&City=" + cityTextBox.Text + "&State=" + stateTextBox.Text + "&Zip=" + zipTextBox.Text +
            "&Time=" + timeTextBox.Text +
            "&Description_of_Problems=" + descriptionOfProblemsTextBox.Text + 
            "&Appointment_Date=" + appointmentDateTextBox.Text + "&isFinished=" + 0;
        }
    }
}
