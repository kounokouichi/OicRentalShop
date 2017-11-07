using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//作成者：高野公一
//作成日：2017.6.02
namespace CS_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.CanGoBackChanged += new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            ReturntoolStripButton.Enabled = webBrowser1.CanGoBack;
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            MovetoolStripButton.Enabled = webBrowser1.CanGoForward;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Splash sp = new Splash();
                sp.Show();
                sp.Refresh();

                Application.DoEvents();
                Thread.Sleep(2000);

                sp.Close();
                sp.Dispose();
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gohome();
        }

        private void ReturntoolStripButton_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack==true)
            {
                webBrowser1.GoBack();
            }
        }

        private void gohome()
        {
            webBrowser1.Url = new Uri("http://www.oic.ac.jp/");
        }

        private void goul(string url)
        {
            webBrowser1.Url = new Uri(url);
        }


        private void MovetoolStripButton_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward==true)
            {
                webBrowser1.GoForward();
            }
        }

        private void HometoolStripButton_Click(object sender, EventArgs e)
        {
            gohome();
        }

        private void EntertoolStripButton_Click(object sender, EventArgs e)
        {
            gourl(toolStripTextBox1.Text);
        }

        private void gourl(string url)
        {
            webBrowser1.Url = new Uri(url);
        }

        private void yahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gourl("http://www.yahoo.co.jp/");
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gourl("http://www.google.co.jp/");
        }

        private void microsoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gourl("http://www.microsoft.co.jp/");
        }

        private void appleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gourl("http://www.apple.co.jp/");
        }

        private void iconFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gourl("http://www.iconfider.co.jp/");
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                gourl(toolStripTextBox1.Text);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
        }

        private void VersiontoolStripButton_Click(object sender, EventArgs e)
        {
                AboutBox1 abbox = new AboutBox1();
                abbox.ShowDialog();
            
        }

        public string url { get; set; }
    }
}
