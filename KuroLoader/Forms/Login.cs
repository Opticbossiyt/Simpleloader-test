using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using System.IO;
using KuroLoader;
using KuroLoader.Forms;

namespace KuroLoader
{

    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
    name: "Uno",
    ownerid: "NlgtMgavSf",
    secret: "b6e90e5ce181a58a574349ce5c38edc0f8319c6540bc68cce4d99972dbd165e5",
    version: "1.0"
);


        public Login()
        {
            InitializeComponent();
        }
        Point lastpoint;

        

        public static bool SubExist(string name)
        {
            if (KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                LoaderUI main = new LoaderUI();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Authy didn't respond");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }


        
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var dia = MessageBox.Show("Would you like to save your username?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dia == DialogResult.Yes)
            {

                Directory.CreateDirectory("creds");
                string pass = password.Text;
                string path = @"Creds\\info.txt";
                File.WriteAllText(path, pass);

                string info = File.ReadAllText(@"creds\\info.txt");
                password.Text = info.ToString();
            }
            else
            {
                MessageBox.Show("Saving Error 52", "Admin");
            }

        }
        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            KeyAuthApp.init();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                button1.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(password.PasswordChar=='*')
            {
                button2.BringToFront();
                password.PasswordChar = '\0';
            }
        }
    }
}
