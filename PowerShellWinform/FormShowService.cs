using System;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Windows.Forms;
using System.Threading;


namespace PowerShellWinform
{
    public partial class FormShowService : Form
    {
        private PowerShell PowerShellInstance { get; set; }
        private Collection<PSObject> PSOutput { get; set; }
        public string inputname { get; set; }
        public FormShowService()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormShowService_Load(object sender, EventArgs e)
        {
            PowerShellInstance = PowerShell.Create();
            //string script = "get-service -name dhcp";
            inputname = "dnscache";
            string gwmi_win32_service = "gwmi win32_Service";
            string nameservice = "Where-Object {$_.name -eq " + "\"" + inputname + "\"}";

            //string selectpathname = "select  pathname";



            string scriptget = gwmi_win32_service + "|" + nameservice;

            //string script = "gwmi win32_Service | Where-Object {$_.name -eq \"dhcp\"}";

            // this script has a sleep in it to simulate a long running script
            PowerShellInstance.AddScript(scriptget);
            //PowerShellInstance.AddParameter("param1", "dhcp");
            // begin invoke execution on the pipeline
            //IAsyncResult result = PowerShellInstance.BeginInvoke();

            PSOutput = PowerShellInstance.Invoke();
            labelServicename_value.Text = PSOutput[0].Members["Name"].Value.ToString().ToUpper();
            labelDisplayname_value.Text = PSOutput[0].Members["DisplayName"].Value.ToString().ToUpper();
            labelServicePath_value.Text = PSOutput[0].Members["Pathname"].Value.ToString();
            labelService_status_value.Text = PSOutput[0].Members["state"].Value.ToString();
            comboBoxSV_Startup_type_value.Items.Add(PSOutput[0].Members["StartMode"].Value.ToString());
            comboBoxSV_Startup_type_value.SelectedItem = PSOutput[0].Members["StartMode"].Value.ToString();

        }

        private void buttonSV_Start_Click(object sender, EventArgs e)
        {
            inputname = "dnscache";
            string gwmi_win32_service = "gwmi win32_Service";
            string nameservice = "Where-Object {$_.name -eq " + "\"" + inputname + "\"}";

            //string selectpathname = "select  pathname";



            string scriptget = gwmi_win32_service + "|" + nameservice;

            PowerShellInstance.AddScript("$a = " + scriptget);

            PSOutput = PowerShellInstance.Invoke();


            PowerShellInstance.AddScript("$a.StartService()");
            PSOutput = PowerShellInstance.Invoke();

            PowerShellInstance.AddScript("$a.State");
            PSOutput = PowerShellInstance.Invoke();
            int countcheck = 0;
            while (PSOutput[0].ToString() != "Running")
            {
                PowerShellInstance.AddScript("$a.State");
                PSOutput = PowerShellInstance.Invoke();
                countcheck++;
                Thread.Sleep(500);
                if (countcheck > 15 || PSOutput[0].ToString() == "Running")
                {
                    break;
                }
            }


            labelService_status_value.Text = PSOutput[0].ToString();
           
            MessageBox.Show("Service " + inputname + " đã mở!" , "Thông báo", MessageBoxButtons.OK);

        }

        private void buttonSV_Stop_Click(object sender, EventArgs e)
        {
            inputname = "dnscache";
            string gwmi_win32_service = "gwmi win32_Service";
            string nameservice = "Where-Object {$_.name -eq " + "\"" + inputname + "\"}";

            //string selectpathname = "select  pathname";



            string scriptget = gwmi_win32_service + "|" + nameservice;

            PowerShellInstance.AddScript("$a = " + scriptget);

            PSOutput = PowerShellInstance.Invoke();


            PowerShellInstance.AddScript("$a.StopService()");
            PSOutput = PowerShellInstance.Invoke();
            PowerShellInstance.AddScript("$a.State");
            PSOutput = PowerShellInstance.Invoke();
            int countcheck = 0;
            while (PSOutput[0].ToString() != "Stopped")
            {
                PowerShellInstance.AddScript("$a.State");
                PSOutput = PowerShellInstance.Invoke();
                countcheck++;
                Thread.Sleep(500);
                if (countcheck > 15 || PSOutput[0].ToString() != "Stopped")
                {
                    break;
                }
            }
           
            labelService_status_value.Text = PSOutput[0].ToString();

            MessageBox.Show("Service " + inputname + " đã đóng!", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonSV_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSV_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK);

            this.Close();
        }

        private void buttonSV_Apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
