namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowTab_Click(object sender, EventArgs e)
        {
            this.showTable();
        }

        private void showTable()
        {
            int n = Convert.ToInt32(this.textBoxNumero.Text);
            string table = "";

            for (int i = 1; i <= 10; i++) 
                table = table + " " + n + " x " + i + " = " + (n * i) + "\n";

            this.richTextBoxTabla.AppendText(table);

        }
    }
}
