using KuroLoader.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuroLoader
{
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = ("Checking for Loader updates");
            panel2.Width = 20;
            await Task.Delay(1000);
            panel2.Width = 31;
            await Task.Delay(1000);
            panel2.Width = 52;
            await Task.Delay(1000);
            panel2.Width = 73;
            await Task.Delay(1000);
            panel2.Width = 80;
            panel2.Width = 125;
            await Task.Delay(1000);
            panel2.Width = 126;
            WebClient updatecheck = new WebClient();
            if (!updatecheck.DownloadString("https://raw.githubusercontent.com/Opticbossiyt/Simpleloader-test/main/updatecheck").Contains("1.0"))
            {
                label1.Text = ("LOADER ERROR 3");
                var dia = MessageBox.Show("Would you like to join our discord for the updated version", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dia == DialogResult.Yes)
                {
                    Process.Start("https://discord.gg/QHeNvGDxg7");
                }
                else
                {
                    var dialog = MessageBox.Show("are you sure nigga?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show("aight fat ass nigger", "Nigger Client");
                    }
                    else
                    {
                        MessageBox.Show("Thanks good sir", "Admin");
                    }
                }
                MessageBox.Show("Aight but thats on you");
                    
                await Task.Delay(1000);
                Application.Exit();
            }
            label1.Text = ("Checking for csgo updates");
            WebClient csgocheck = new WebClient();
            if (!csgocheck.DownloadString("https://raw.githubusercontent.com/Opticbossiyt/Simpleloader-test/main/csgoupdate").Contains("2023-04-01 "))
            {
                label1.Text = ("LOADER ERROR 1");
                MessageBox.Show("Outdated client, Would you like to join the discord server?", "Kuro Auth");
                Process.Start("https://discord.gg/QHeNvGDxg7");
                await Task.Delay(1000);
                Application.Exit();
            }
            panel2.Width = 150;
            await Task.Delay(1000);
            panel2.Width = 160;
            await Task.Delay(1000);
            panel2.Width = 165;
            await Task.Delay(1000);
            panel2.Width = 180;
            await Task.Delay(1000);
            label1.Text = ("Checking for missing files");
            panel2.Width = 181;
            await Task.Delay(1000);
            panel2.Width = 190;
            await Task.Delay(1000);
            label1.Text = ("Requesting miscrosofts latest pdb list");
            panel2.Width = 210;
            await Task.Delay(1000);
            label1.Text = ("Checking system requirements");
            panel2.Width = 240;
            await Task.Delay(1000);
            panel2.Width = 260;
            label1.Text = ("Checking for anti cheat installed");
            await Task.Delay(1000);
            panel2.Width = 300;
            await Task.Delay(1000);
            panel2.Width = 320;
            await Task.Delay(1000);
            panel2.Width = 330;
            await Task.Delay(1000);
            panel2.Width = 340;
            await Task.Delay(1000);
            panel2.Width = 350;
            await Task.Delay(1000);
            panel2.Width = 363;
            await Task.Delay(1000);
            panel2.Width = 367;
            await Task.Delay(1000);
            panel2.Width = 380;
            await Task.Delay(1000);
            panel2.Width = 389;
            await Task.Delay(1000);
            panel2.Width = 400;
            await Task.Delay(1000);
            panel2.Width = 410;
            await Task.Delay(1000);
            panel2.Width = 433;
            await Task.Delay(1000);
            panel2.Width = 460;
            await Task.Delay(1000);
            panel2.Width = 500;
            await Task.Delay(1000);
            panel2.Width = 521;
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Loading.");
            await Task.Delay(500);
            label1.Text = ("Loading..");
            await Task.Delay(500);
            label1.Text = ("Loading...");
            await Task.Delay(500);
            label1.Text = ("Loading");
            await Task.Delay(500);
            label1.Text = ("Done loading");
            await Task.Delay(3000);
            Form4 main = new Form4();
            main.Show();
            this.Hide();
        }

        private void LoaderUI_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
           
 
       
            




