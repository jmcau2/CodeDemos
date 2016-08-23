using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

//A lot of sensitive information ahs been removed.


namespace PeoriaTechnologyIntakeSheet
{
    public partial class DBConfiguration : Form
    {
        public DBConfiguration()
        {
            InitializeComponent();
            loadCurrentSettings();
        }

    //Set to populate the text boxes in the configuration menu with the current settings.
        private void loadCurrentSettings()
        {
            dbURLTextBox.Text = Config.DBURL;
            dbToUseTextBox.Text = Config.DBToUse;
            dbPassword.Text = Config.DBPassword;
            dbUser.Text = Config.DBUser;
            phpFolderTextBox.Text = Config.PHPFolder;

        }

        //Re-writes the current settings in the xml file.
        private void updateConfig_Click(object sender, EventArgs e)
        {
            Config.DBURL = dbURLTextBox.Text;
            Config.DBToUse = dbToUseTextBox.Text;
            Config.DBUser = dbUser.Text;
            Config.DBPassword = dbPassword.Text;
            Config.PHPFolder = phpFolderTextBox.Text;

            XmlUpdate(dbURLTextBox.Text, dbToUseTextBox.Text, dbUser.Text, dbPassword.Text, phpFolderTextBox.Text);
            this.Close();
        }

        //This is tha action that actually rewrites the xml file
        private void XmlUpdate(string dbURL, string dbToUse, string dbUser, string dbPassword, string phpFolder)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            XmlDocument doc = new XmlDocument();
            doc.Load(a.GetManifestResourceStream("PeoriaTechnologyIntakeSheet.config.xml"));

            doc.SelectSingleNode("/Root/Store/DBURL").InnerText = dbURL;
            doc.SelectSingleNode("/Root/Store/DBToUse").InnerText = dbToUse;
            doc.SelectSingleNode("/Root/Store/DBPassword").InnerText = dbPassword;
            doc.SelectSingleNode("/Root/Store/DBUser").InnerText = dbUser;
            doc.SelectSingleNode("/Root/Store/PHPFolder").InnerText = phpFolder;
            doc.Save("config.xml");

        }

        private void dbURLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbToUseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void phpFolderTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
