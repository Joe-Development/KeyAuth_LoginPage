using KeyAuth;
using System;
using System.Windows.Forms;

namespace AgoraSpooferKeySYS
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api( // Make sure to set this to your KeyAuth API Setup
            name: "",
            ownerid: "",
            secret: "",
            version: ""
        );

        public Form1()
        {
            KeyAuthApp.init();
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string key = guna2TextBox1.Text;
            KeyAuthApp.license(key);
            if (!KeyAuthApp.response.success)
            {
                label1.Text = "STATUS: INVALID KEY PROVIDED";
            }
            else
            {
                label1.Text = "STATUS: VALID KEY PROVIDED";
                // Form2 main = new Form2(); Your going to want to set this to the new Form You want to open
                // main.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
