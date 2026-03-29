using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BitFlash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbdrives.Items.Clear();

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                {
                    if (drive.DriveType == DriveType.Removable && drive.IsReady)
                    {
                        long SizeGB = drive.TotalSize / 1024 / 1024 / 1024;
                        string info = drive.Name + " (" + drive.VolumeLabel + ") - " + SizeGB + " ГБ";
                        cmbdrives.Items.Add(info);
                    }
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbdrives_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
