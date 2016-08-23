using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace PeoriaTechnologyIntakeSheet
{
    public partial class CustomerLookupForm : Form
    {
        
        //Initializing Form
        Form1 frm1;
        public CustomerLookupForm(Form1 parent)
        {
            frm1 = parent;
            populateList();
                                
        }

       
        //Populating the list of all the customers
        private void populateList()
        {
            //This particular line Deserializes a JSON response from the server.
            //It makes a Get Request and sends the DB connection info to a php script via a POST action, it POSTS
            //the connection string which is set in a XML configuration file.  From there the PHP script will ping the MYSQL DB
            //and then in turn the information is sent back to this application in JSON format and is deserialized into a list
            //of type Customers
            Customers currentCustomers = JsonConvert.DeserializeObject<Customers>(DataBase.Get("get_customer_info.php", Config.dbConnectString()));

            //We shrink the size by one to account for the 0 index beggining
            int currentCustomersSize = currentCustomers.getSize() - 1;

            //After the customers list has been retreived we open up the form, got to make sure we aren't passing a bunch of null values.
            InitializeComponent();
            
            //Adding the Customers to the datagrid view.
            for (int i = currentCustomersSize; i >= 0; i--)
            {

                this.dataGridView1.Rows.Add(currentCustomers.Customer[i].ID, currentCustomers.Customer[i].First_Name, currentCustomers.Customer[i].Last_Name, currentCustomers.Customer[i].Phone_Number, currentCustomers.Customer[i].EMail, currentCustomers.Customer[i].Address, currentCustomers.Customer[i].City, currentCustomers.Customer[i].State, currentCustomers.Customer[i].Zip, currentCustomers.Customer[i].Equipment_Description, currentCustomers.Customer[i].Accessories, currentCustomers.Customer[i].Description_Of_Problems, currentCustomers.Customer[i].IncomingDate);

            }   
        }

        //The datagrid view is set to select the entire row, from here we grab the customer info and load up the last invoice they had
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectCustomer();
        }

        //This has the same effect as the above double click, of course it's named button1
        private void button1_Click(object sender, EventArgs e)
        {
           selectCustomer();
        }

        //This clears out the list then re-runs the populate list method to reload any changes that may have occured since the
        //last load
        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            populateList();
        }

        //Grabs all of the information about the customer and slaps it into an editable form/invoice so you can close out, update, etc.
        private void selectCustomer()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DateTime today = DateTime.Today;


                string TodaysDate = today.ToString("d");

                string ID = row.Cells[0].Value.ToString();
                string FirstName = row.Cells[1].Value.ToString();
                string LastName = row.Cells[2].Value.ToString();
                string PhoneNumber = row.Cells[3].Value.ToString();
                string EMail = row.Cells[4].Value.ToString();
                string Address = row.Cells[5].Value.ToString();
                string City = row.Cells[6].Value.ToString();
                string State = row.Cells[7].Value.ToString();
                string Zip = row.Cells[8].Value.ToString();
                string EquipmentDescription = row.Cells[9].Value.ToString();
                string Accessories = row.Cells[10].Value.ToString();
                string DescriptionOfProblems = row.Cells[11].Value.ToString();
                string Date = row.Cells[12].Value.ToString();




                intakeForm IntakeForm;
                IntakeForm = new intakeForm(frm1, ID, FirstName, LastName, PhoneNumber, EMail, Address, City, State, Zip, EquipmentDescription, Accessories, TodaysDate + "- \r\n" + "\r\n" + "\r\n" + Date + "- \r\n " + DescriptionOfProblems, Date);

                IntakeForm.Show();
            }
        }

        private void CustomerLookupForm_Load(object sender, EventArgs e) { }
        

      
    }
}
