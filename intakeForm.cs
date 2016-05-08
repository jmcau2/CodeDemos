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

//Abandon Hope all ye who enter

namespace PeoriaTechnologyIntakeSheet
{

  
    public partial class intakeForm : Form
    {
        //Initilizing Variables 
        

        //This is where the PHP file lives currently, at some point this needs to be bumped
        //to be set by the configuration file/setup
        string addCustomerPHPForm = Config.PHPFolder + "/add_customer.php";
       

        //intakeForm Constructor, allows variables to be passed if need be
        Form1 frm1;
        public intakeForm(Form1 parent, string ID, string FirstName, string LastName, string PhoneNumber, string EMail, 
            string Address, string City, string State, string Zip, string EquipmentDescription, string Accessories, 
            string DescriptionOfProblems, string IncomingDate){
        
            
        //If any data was passed to the form, this puts everything into their respective textboxes.
            InitializeComponent();

            frm1 = parent;
            incomingDateTextbox.Text = IncomingDate;
            customerIDLabel.Text = ID;
            firstNameTextBox.Text = FirstName;
            lastNameTextBox.Text = LastName;
            phoneNumberTextBox.Text = PhoneNumber;
            emailTextBox.Text = EMail;
            addressTextBox.Text = Address;
            cityTextBox.Text = City;
            stateTextBox.Text = State;
            zipTextBox.Text = Zip;
            equipmentDescriptionTextbox.Text = EquipmentDescription;
            accessoriesTextBox.Text = Accessories;
            descriptionOfProblemsTextBox.Text = DescriptionOfProblems;
         

        }

        //Textboxes, this is how the data is gathered.

        private void incomingDateTextbox_TextChanged(object sender, EventArgs e)
        {
            String incomingDate = incomingDateTextbox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            String password = passwordTextBox.Text;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            String firstName = passwordTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            String lastName = lastNameTextBox.Text;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            String phoneNumber = phoneNumberTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            String address = addressTextBox.Text;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            String city = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            String state = stateTextBox.Text;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            String zip = zipTextBox.Text;
        }

        private void equipmentDescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            String equipmentDescription = equipmentDescriptionTextbox.Text;
        }

        private void accessoriesTextBox_TextChanged(object sender, EventArgs e)
        {
            String accessories = accessoriesTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            String email = emailTextBox.Text;
        }

        //Save and Print button, should add/update the customer print out the work order and then close
        private void saveAndPrintButton_Click(object sender, EventArgs e)
        {
            DataBase.Post(addCustomerPHPForm, intakeFormInfoString());
            CaptureScreen();
            printDocument1.Print();
            frm1.RefreshForm();
            this.Close();
        }      


        Bitmap memoryImage;

        //Creates a bitmap of the work order in order to make it printable, I know, I'm lazy.  So sue me.
        private void CaptureScreen()
        {
            Graphics graphics = this.CreateGraphics();
            Size size = this.Size;
            Int32 theWidth = size.Width - 20;
            Int32 theHeight = size.Height - 80;
            memoryImage = new Bitmap(theWidth, theHeight, graphics);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, -15, -30, size);
        }

        

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void addUpdateCustomerButton_Click(object sender, EventArgs e)
        {
             
           MessageBox.Show(DataBase.Post(addCustomerPHPForm, intakeFormInfoString()));
           frm1.RefreshForm();
           this.Close();
        }

        //This method assembles the string to be sent for the request to the database.
        private string intakeFormInfoString()
        {
            

            return "ID="+ customerIDLabel.Text + "&" + Config.dbConnectString() + "&First_Name=" + firstNameTextBox.Text + "&Last_Name=" + lastNameTextBox.Text + "&Password=" + passwordTextBox.Text +
            "&Phone_Number=" + phoneNumberTextBox.Text + "&EMail=" + emailTextBox.Text + "&Address=" + addressTextBox.Text +
            "&City=" + cityTextBox.Text + "&State=" + stateTextBox.Text + "&Zip=" + zipTextBox.Text +
            "&Equipment_Description=" + equipmentDescriptionTextbox.Text + "&Accessories=" + accessoriesTextBox.Text +
            "&Description_of_Problems=" + descriptionOfProblemsTextBox.Text + "&IncomingDate=" + incomingDateTextbox.Text;
        }


       
    }
    
}
