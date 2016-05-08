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
        Form1 frm1;
        public CustomerLookupForm(Form1 parent)
        {
            frm1 = parent;
            populateList();
                                
        }

       

        private void populateList()
        {
            Customers currentCustomers = JsonConvert.DeserializeObject<Customers>(DataBase.Get("get_customer_info.php", Config.dbConnectString()));

            int currentCustomersSize = currentCustomers.getSize() - 1;

            InitializeComponent();
            for (int i = currentCustomersSize; i >= 0; i--)
            {

                this.dataGridView1.Rows.Add(currentCustomers.Customer[i].ID, currentCustomers.Customer[i].First_Name, currentCustomers.Customer[i].Last_Name, currentCustomers.Customer[i].Phone_Number, currentCustomers.Customer[i].EMail, currentCustomers.Customer[i].Address, currentCustomers.Customer[i].City, currentCustomers.Customer[i].State, currentCustomers.Customer[i].Zip, currentCustomers.Customer[i].Equipment_Description, currentCustomers.Customer[i].Accessories, currentCustomers.Customer[i].Description_Of_Problems, currentCustomers.Customer[i].IncomingDate);

            }   
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           selectCustomer();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            populateList();
        }

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
