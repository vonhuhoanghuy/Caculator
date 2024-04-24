using Tinhtoan;

namespace Caculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Chào các bạn", "Chào", MessageBoxButtons.OK);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            BackColor = Color.Red;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Đừng nhấp nữa", "Chào", MessageBoxButtons.OK);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn đóng không?", "Chào",
MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Tôi về rồi", "Chào", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDecimal(txtBK.Text)* Convert.ToDecimal(txtBK.Text) * Pi).ToString();
            txtBK.Focus();
        }
        const decimal Pi = 3.1415M;
        private void button2_Click(object sender, EventArgs e)
        {

            txtResult.Text = "";
            lblThongbao.Text = Utility.CheckDecimal(txtBK);
            if (lblThongbao.Text == "decimal")
                if (Convert.ToDecimal(txtBK.Text) >= 0)
                {
                    txtResult.Text = (2 * Convert.ToDecimal(txtBK.Text) * Pi).ToString();
                    lblThongbao.Text = "Hãy nhập bán kính";
                }
                else
                    lblThongbao.Text = "Sai! Hãy nhập số >=0 cho bán kính?";
            txtBK.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}