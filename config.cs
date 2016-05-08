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
using System.Xml.Serialization;
using System.Xml.Linq;


namespace PeoriaTechnologyIntakeSheet
{

    public static class Config
    {
        public static string DBURL { get; set; }
        public static string DBToUse { get; set; }
        public static string DBPassword { get; set; }
        public static string DBUser { get; set; }
        public static string PHPFolder { get; set; }

        public static string dbConnectString()
        {
            return "dbUser=" + Config.DBUser + "&dbPassword=" + Config.DBPassword + "&dbToUse=" + Config.DBToUse;
        }
    } 

    
    }



