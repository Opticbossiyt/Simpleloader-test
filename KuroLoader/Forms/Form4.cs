using System;
using System.Windows.Forms;
using KeyAuth;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Net;
using ManualMapInjection.Injection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Web.Hosting;

namespace KuroLoader.Forms
{
    public partial class Form4 : Form
    {

        public static api KeyAuthApp = new api(
    name: "Uno",
    ownerid: "NlgtMgavSf",
    secret: "b6e90e5ce181a58a574349ce5c38edc0f8319c6540bc68cce4d99972dbd165e5",
    version: "1.0"
);

        public Form4()
        {
            InitializeComponent();
        }

        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }






        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = "Sub Until: " + expirydaysleft();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            checkonline();
            Thread.Sleep(100000);
            var dia = MessageBox.Show("Would you like to VAC bypass? it will lower your trust factor, you dont have to if you dont want to.", "Vision Bypasser", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dia == DialogResult.Yes)
            {
                MessageBox.Show("Starting VAC bypass");
                foreach (var process in Process.GetProcessesByName("steam"))
                {
                    process.Kill();
                }

            }
            Thread.Sleep(10000);
            Process.Start("steam://rungameid/730");
            Thread.Sleep(25800);
            WebClient wb = new WebClient();
            string mainpath = "C:\\Program Files (86)";
            wb.DownloadFile("https://raw.githubusercontent.com/Opticbossiyt/Simpleloader-test/main/csgo.dll", mainpath);
            var name = "csgo";
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            var path = mainpath;
            var file = File.ReadAllBytes(path);


            if (!File.Exists(path))
            {
                MessageBox.Show("Error 152", "Vision Loader");
                return;
            }

            //Injection, just leave this alone if you are a beginner
            var injector = new ManualMapInjector(target) { AsyncInjection = true };
            label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
            MessageBox.Show("Injected!!");

            if (System.IO.File.Exists(mainpath)) //Checking if the DLL exists
            {
                System.IO.File.Delete(mainpath); //Deleting the DLL
            }
            else
            {
                MessageBox.Show("Error 167", "Vision Loader");
            }
        }
        private void checkonline()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://google.com/"))
                    {
                        label5.ForeColor = Color.Green;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cheat current offline", "Vision Auth");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Green;
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var dia = MessageBox.Show("Are you sure you wan't to start cleaning?.", "Vision Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dia == DialogResult.Yes)
            {
                MessageBox.Show("Starting cleaning operation", "Admin");
                {
                    WebClient wb = new WebClient();
                    string mainpath = "C:\\Program Files (86)";
                    var path = mainpath;
                    wb.DownloadFile("https://raw.githubusercontent.com/Opticbossiyt/Simpleloader-test/main/Apex.bat", mainpath);
                    Process.Start("Apex.bat");


                    if (!File.Exists(path))
                    {
                        MessageBox.Show("Cleaner Handle Error, Open a ticket in discord", "Vision Loader");
                    }
                    else
                    {
                        MessageBox.Show("Make sure to have fun while using our software");
                    }
                }

            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            var dia = MessageBox.Show("Are you sure you wan't to start spoofing?.", "Vision Spoofer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dia == DialogResult.Yes)
            {
                MessageBox.Show("Starting spoofing operation", "Admin");
                {
                    //write spoofing code here
                    ////////////////
                    //////////////
                    ///
                    var dialog = MessageBox.Show("Do you want to spoof steam ID?", "Vision Spoofer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show("Spoofing steam ID");
                    }
                    else
                    {
                        MessageBox.Show("Spoofing ERROR 72", "Admin");
                    }
                    WebClient wb = new WebClient();
                    string mainpath = "C:\\Program Files (86)";
                    var path = mainpath;
                    wb.DownloadFile("", mainpath); //put code here
                    Process.Start("Apex");


                    if (!File.Exists(path))
                    {
                        MessageBox.Show("Cleaner Handle Error, Open a ticket in discord", "Vision Loader");
                    }
                }

            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Key Time Left";
            for (var i = 0; i < KeyAuthApp.user_data.subscriptions.Count; i++)
            {
                label8.Text = (" Subscription name: " + KeyAuthApp.user_data.subscriptions[i].subscription + " - Expires at: " + UnixTimeToDateTime(long.Parse(KeyAuthApp.user_data.subscriptions[i].expiry)) + " - Time left in seconds: " + KeyAuthApp.user_data.subscriptions[i].timeleft);
            }
        }

        private void Label9(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(KeyAuthApp.user_data.lastlogin)) 
               label9.Text = (" Last login at: " + UnixTimeToDateTime(long.Parse(KeyAuthApp.user_data.lastlogin)));
        }
    }
}


       








