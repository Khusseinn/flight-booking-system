namespace Fly_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Going To: " + comboBox1.Text + "-" + comboBox2.Text + " Date: " + dateTimePicker1.Text + " Time:" + maskedTextBox1.Text + " Passanger Info // Name Surname: " + textBox1.Text + " Serial Number: " + maskedTextBox2.Text + " Phone Number: " + maskedTextBox3.Text);
            MessageBox.Show("Passanger Registered Succesfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
