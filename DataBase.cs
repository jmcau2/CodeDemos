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
    class DataBase
    {

       //Storing all of the url strings that the program will use here in this class to keep it simple
        public static string computerIsFinishedurl()
        {
            return Config.PHPFolder + "/computerFinished.php";
        }

        public static string timeClockurl()
        {
            return Config.PHPFolder + "/timeClock.php";
        }

        public static string serviceCallDispatchurl()
        {
            return Config.PHPFolder + "/serviceCallDispatch.php";
        }

        public static string serviceCallCompleteurl()
        {
            return Config.PHPFolder + "/serviceCallComplete.php";
        }

        public static string destinationAddress{get; set;}
        
        //
        //Database Methods.
        //
        public static string Get(string phpFile, string dbCredentials)
        {
           //
            //The Post Method takes in one of the above URLS, and the the postData Takes in a string to 
            //access the database.  Proper formatting looks something like:
            //"ID="+ customerIDLabel.Text + "&dbUser=" + dbUser+"&dbPassword="+dbPassword+"&dbToUse="+dbToUse+ 
            //"&First_Name=" + firstNameTextBox.Text
            //This must stay in UTF8 and be sent via a stream.  ACII will make the SQL and PHP script freak out
            //
            string webpageContent = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(dbCredentials);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Config.PHPFolder + "/" + phpFile);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                using (Stream webpageStream = webRequest.GetRequestStream())
                {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        webpageContent = reader.ReadToEnd();
                        reader.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            return webpageContent;
            

              
        }

        public static string Post(string url, string postData)
        {
            //
            //The Post Method takes in one of the above URLS, and the the postData Takes in a string to 
            //access the database.  Proper formatting looks something like:
            //"ID="+ customerIDLabel.Text + "&dbUser=" + dbUser+"&dbPassword="+dbPassword+"&dbToUse="+dbToUse+ 
            //"&First_Name=" + firstNameTextBox.Text
            //This must stay in UTF8 and be sent via a stream.  ACII will make the SQL and PHP script freak out
            //
            string webpageContent = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                using (Stream webpageStream = webRequest.GetRequestStream())
                {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        webpageContent = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            return webpageContent;

        }
             
    }
}
