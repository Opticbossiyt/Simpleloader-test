using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoChanger.Auth.Encryption;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace UnoChanger.Auth
{
    class Auth
    {
        // bam so now the auth is encrypted but let me finish the login function <3
        public struct AuthServer
        {
            public static string Server { get; set; } = "IkKvqztEVZpL0hFvUYN06h6hJFgQYZucIYj76lPAAWayE44P+uPflfnIPiEOeLIuel4oRQcsk8oHHn35qfInofkRm9dRVOAAMlCV6XBa+MA=";

            public static string ServerKey { get; set; } = "b14ca5898a4e4133bbce2ea2315a1916";
        }

        public static bool LoginFunction(string HWID)
        {
            WebClient WebObject = new WebClient();

            try
            {
                string AuthList = WebObject.DownloadString(AuthEncryption.DecryptString(Auth.AuthServer.ServerKey, Auth.AuthServer.Server));
                if(AuthList.Contains(HWID))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Authentication Error : " + ex.Message, "Kuro - Auth");
                return false;
            }
        }
    }
}
