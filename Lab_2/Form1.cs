namespace Lab_2
{
    public partial class Form1 : Form
    {
        EmployeeDBConn db = new EmployeeDBConn();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSucess = db.Insert(textBox4.Text, textBox3.Text, textBox2.Text, textBox1.Text);
            if (isSucess)
            {
                MessageBox.Show("Employee data inserted successfully.");

            }
            else
            {
                MessageBox.Show("Failed to insert employee data.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isSucess = db.Update(textBox4.Text, textBox3.Text, textBox2.Text, textBox1.Text);
            if (isSucess)
            {
                MessageBox.Show("Employee updated sucessfully.");
            }
            else
            {
                MessageBox.Show("Failed to update employee");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isSucess = db.Delete(textBox4.Text);
            if (isSucess)
            {
                MessageBox.Show("Employee data Deleted Sucessfully");
            }
            else
            {
                MessageBox.Show("Failed to delete employee");
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = db.FetchAll(textBox4.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
