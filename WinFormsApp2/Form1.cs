
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";

            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при запуску Блокнота: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] notepadProcesses = Process.GetProcessesByName("notepad");
            foreach (Process process in notepadProcesses)
            {
                process.CloseMainWindow();
            }
        }
    }
}