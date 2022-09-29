using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SshLink
{
    public partial class Form1 : Form
    {
        CsvFile file = new CsvFile("devices.csv");

        public Form1()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            string[][] records = file.ReadRecords();
            lstDeviceNames.Items.Clear();
            lstMac.Items.Clear();
            lstUser.Items.Clear();
            foreach(string[] record in records)
            {
                lstDeviceNames.Items.Add(record[0]);
                lstMac.Items.Add(record[1]);
                lstUser.Items.Add(record[2]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void submit()
        {
            string[] record = { txtName.Text, txtMac.Text, txtUser.Text };
            file.WriteRecord(record);
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.TextLength > 0 && txtUser.TextLength > 0 && txtMac.TextLength > 0)
            {
                submit();
            }
        }

        private void setListIndex(int index)
        {
            lstDeviceNames.SelectedIndex = index;
            lstMac.SelectedIndex = index;
            lstUser.SelectedIndex = index;
        }

        private void lstDeviceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            setListIndex(lstDeviceNames.SelectedIndex);
        }

        private void lstMac_SelectedIndexChanged(object sender, EventArgs e)
        {
            setListIndex(lstMac.SelectedIndex);
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            setListIndex(lstUser.SelectedIndex);
        }

        static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                //string batDir = string.Format(@"D:\");
                proc = new Process();
                //proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "Connect.bat";
                proc.StartInfo.Arguments = "\"" + lstMac.SelectedItem + "\" \"" + lstUser.SelectedItem + "\"";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                //MessageBox.Show("Bat file executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
                MessageBox.Show(ex.Message);
            }
            //ExecuteCommand("run Connect.bat " + lstMac.SelectedItem + " " + lstUser.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstMac.SelectedIndex;
            file.RemoveRecordAt(index);
            refresh();
        }
    }
}
