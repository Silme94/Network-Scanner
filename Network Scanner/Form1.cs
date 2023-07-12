
using System.Buffers.Text;
using System.Collections.Concurrent;
using System.Net;

namespace Network_Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool isScaning = false;

        private void scanbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isScaning)
                {
                    isScaning = true;

                    if (subnettxtbox.Text == string.Empty)
                    {
                        throw new Exception("Subnet field is empty.");
                    }

                    string baseIP = subnettxtbox.Text;
                    Task.Run(() => { loop(baseIP, dataGridView1, statuslabel); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isScaning = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isScaning)
            {
                isScaning = false;
            }
        }

        private void loop(string baseIP, DataGridView dataGridView, Label status)
        {
            dataGridView.Invoke((MethodInvoker)delegate
            {
                dataGridView.Rows.Clear();
            });

            status.Invoke((MethodInvoker)delegate
            {
                status.Text = "Scaning...";
            });
            Thread.Sleep(2000);

            for (int i = 0; i <= 255; i++)
            {
                if (!isScaning)
                {
                    break;
                }

                status.Invoke((MethodInvoker)delegate
                {
                    status.Text = "Scaning : " + baseIP + i.ToString();
                });

                bool ping = Pinger.Try(baseIP + i.ToString());

                if (ping)
                {
                    string hostname = string.Empty;

                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(IPAddress.Parse(baseIP + i.ToString()));
                        hostname = hostEntry.HostName;
                    }
                    catch
                    {
                        hostname = "?";
                    }
                    dataGridView.Invoke((MethodInvoker)delegate
                    {
                        dataGridView.Rows.Add(baseIP + i.ToString(), hostname, "Active");
                    });
                }
            }

            status.Invoke((MethodInvoker)delegate
            {
                status.Text = "Scan completed.";
            });
            isScaning = false;
        }
    }
}