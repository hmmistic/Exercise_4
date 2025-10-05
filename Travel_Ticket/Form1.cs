namespace Travel_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuyTicket_Click(object sender, EventArgs e)
        {
            string? from = comboBox1.SelectedItem?.ToString();
            string? to = comboBox2.SelectedItem?.ToString();
            string date = maskedTextBox1.Text;
            string time = maskedTextBox2.Text;
            string location = textBox1.Text;
            string name = textBox3.Text;
            string serial = maskedTextBox4.Text;
            string phone = maskedTextBox3.Text;
            string email = textBox2.Text;

            string ticket = "Haradan: " + from +
                " Haraya: " + to +
                " Tarix: " + date +
                " Saat: " + time +
                " Yer: " + location +
                " Ad və soyad: " + name +
                " ŞV/seria: " + serial +
                " Telefon: " + phone +
                " Email: " + email;

            if (string.IsNullOrWhiteSpace(from) ||
                string.IsNullOrWhiteSpace(to) ||
                string.IsNullOrWhiteSpace(date) ||
                string.IsNullOrWhiteSpace(time) ||
                string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(serial) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(phone)) MessageBox.Show("Zəhmət olmasa xanaların düzgün doldurulduğundan əmin olun.");

            else listBox1.Items.Add(ticket);
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            string? temp = comboBox1.SelectedItem?.ToString();
            comboBox1.Text = comboBox2.SelectedItem?.ToString();
            comboBox2.Text = temp;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
