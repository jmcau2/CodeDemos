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
using System.Diagnostics;
using Newtonsoft.Json;
using System.Xml;

namespace PeoriaTechnologyIntakeSheet
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            loadConfiguration();

            InitializeComponent();

            getInStoreComputerListing();

            getServiceCallsListing();

            
        }

        private void loadConfiguration()
        {
            try
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                XmlDocument doc = new XmlDocument();
                doc.Load(a.GetManifestResourceStream("PeoriaTechnologyIntakeSheet.config.xml"));
                
          

                XmlElement xmlRoot = doc.DocumentElement;
                XmlNodeList XmlNodes = xmlRoot.SelectNodes("/Root/Store");

                foreach (XmlNode node in XmlNodes)
                {


                    Config.DBURL = node["DBURL"].InnerText;
                    Config.DBToUse = node["DBToUse"].InnerText;
                    Config.DBPassword = node["DBPassword"].InnerText;
                    Config.DBUser = node["DBUser"].InnerText;
                    Config.PHPFolder = node["PHPFolder"].InnerText;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        private void intakeSheetButton_Click(object sender, EventArgs e)
        {
            intakeForm IntakeForm = new intakeForm(this, "", "", "", "", "", "", "", "", "", "", "", "", "");            
            IntakeForm.Show();
        }

       
            private void customerLookupButton_Click(object sender, EventArgs e)
        {
            
            CustomerLookupForm LookupForm = new CustomerLookupForm(this);  
            LookupForm.Show();           
        }

            private void serviceCallButton_Click(object sender, EventArgs e)
            {
                serviceCallForm SCF = new serviceCallForm(this, "", "", "", "", "", "", "", "", "", "", "", "");              
                SCF.Show();
            }

         
            private void databaseConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DBConfiguration dbConfig = new DBConfiguration();
                dbConfig.Show();              
            }

            private void upcomingServiceCallsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e){}
            

            public void getServiceCallsListing()
            {           
                        ServiceCalls serviceCalls = JsonConvert.DeserializeObject<ServiceCalls>(DataBase.Get("get_service_call_info.php", Config.dbConnectString()));
                        if (serviceCalls.ServiceCall != null)
                        {
                            int currentNumberofServiceCalls = serviceCalls.getSize() - 1;
                            for (int i = currentNumberofServiceCalls; i >= 0; i--)
                            {

                                this.upcomingServiceCallsDataGridView.Rows.Add(serviceCalls.ServiceCall[i].ID, serviceCalls.ServiceCall[i].First_Name, serviceCalls.ServiceCall[i].Last_Name, serviceCalls.ServiceCall[i].Phone_Number, serviceCalls.ServiceCall[i].Address, serviceCalls.ServiceCall[i].Appointment_Date, serviceCalls.ServiceCall[i].Time);

                            }
                        }
            }

            private void displayServerError()
            {
                MessageBox.Show("An error occured, this was most likely caused by a lack of an internet connection or an issue with the database.  Please make sure you are connected to the internet");
            }

            public void getInStoreComputerListing()
            {
                //This method will get the in store computers.  It uses the php script on the server to
                //Select * From the Customer Info Table and then only returns the values in the table
                //such as ID, Last Name, etc.  The incoming string is in JSON and as such has to be 
                //parsed so it is parsed into an object of custom type "Customers"

                
                        Customers customers = JsonConvert.DeserializeObject<Customers>(DataBase.Get("get_computers_in_store.php", Config.dbConnectString()));

                        int currentNumberofCustomers = customers.getSize() - 1;


                        //Looping through customers and adding each customer row one at a time
                        //to the Data Grid View
                        for (int i = currentNumberofCustomers; i >= 0; i--)
                        {
                            
                            this.inStoreDataGridView.Rows.Add(customers.Customer[i].ID, customers.Customer[i].Last_Name, customers.Customer[i].IncomingDate, customers.Customer[i].Phone_Number, customers.Customer[i].Equipment_Description);

                        }
                       
            }

            private void dispatchButton_Click(object sender, EventArgs e)
            {
                //The point here is to highlight the row and make it a different color so one
                //can tell which call someone is dispatched on.  Yellow will mean in progress.
                //the is finished flag will be set to 2 to represent an in progress service call.
                string id = upcomingServiceCallsDataGridView.Rows[upcomingServiceCallsDataGridView.CurrentRow.Index].Cells[0].Value.ToString();



                
               
                foreach (DataGridViewRow item in upcomingServiceCallsDataGridView.SelectedRows)
                {

                    string ID = item.Cells[0].Value.ToString();

                    


                    DataBase.destinationAddress = DataBase.Post(DataBase.serviceCallDispatchurl(), Config.dbConnectString() + "&isFinishedID=" + ID);

                    //Opens a window with a generated string in google maps.

                }

                System.Diagnostics.Process.Start(DataBase.destinationAddress);
                
            }
   
            

            private void programConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Program Configuration");
            }

            private void computerFinishedButton_Click(object sender, EventArgs e)
            {
             //Takes the selected row and grabs the ID number out of the front cell, then posts the data
             //to the php script on the server which then sets the isFinished flag in the database to 1
             //DataBase.Post method contains everything you need to post.
                    string id = inStoreDataGridView.Rows[inStoreDataGridView.CurrentRow.Index].Cells[0].Value.ToString();                    
                    MessageBox.Show(DataBase.Post(DataBase.computerIsFinishedurl(), Config.dbConnectString() + "&computerThatIsFinishedID=" + id));
                    RefreshForm();
               
            }

            private void inStoreDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void serviceCallCompleteButton_Click(object sender, EventArgs e)
            {
                //This Method Does the same thing as ComputerFinishedButton.  Uses a php script on the server
                //to set the isFinished Flag to 1 so that it no longer shows up in the table.
                //Database Configuration will be set up later in an xml file and will hopefully pull
                //the Database Credentials from it.
                string id = upcomingServiceCallsDataGridView.Rows[upcomingServiceCallsDataGridView.CurrentRow.Index].Cells[0].Value.ToString();

                MessageBox.Show(DataBase.Post(DataBase.serviceCallCompleteurl(), Config.dbConnectString() + "&computerThatIsFinishedID=" + id));

                RefreshForm();


            }

            private void refreshButton_Click(object sender, EventArgs e)
            {
                RefreshForm();
            }
          
            public void RefreshForm(){
                upcomingServiceCallsDataGridView.Rows.Clear();
                getServiceCallsListing();
                inStoreDataGridView.Rows.Clear();
                getInStoreComputerListing();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show(DataBase.Get("get_service_call_info.php", Config.dbConnectString()));
            }

            private void timeClockToolStripMenuItem_Click(object sender, EventArgs e)
            {
                TimeClock timeClock = new TimeClock();
                timeClock.Show();
            }

            private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Inventory inventory = new Inventory();
                inventory.Show();
            }
            
        }
    }

