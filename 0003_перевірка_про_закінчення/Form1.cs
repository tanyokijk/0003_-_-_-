using System.Collections;
using System.Diagnostics;

namespace _0003_перевірка_про_закінчення
{
    public partial class Form1 : Form
    {
        private Process programProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process programProcess = new Process();
            Hashtable openWith = new Hashtable
            {

                { "Notepad", "notepad.exe" },
                { "Paint", "mspaint.exe" }
            };
            string text = listBox1.Text;
            string path = (string)openWith[text];
            programProcess.StartInfo = new ProcessStartInfo(path);
            try
            {
                programProcess.Start();
                programProcess.WaitForExit();
                if (programProcess.HasExited)
                {
                    MessageBox.Show("Програма завершила свою роботу", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завершенні процесу: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}