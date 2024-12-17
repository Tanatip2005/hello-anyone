using System.Web;

namespace WinFormsApp1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
          string inputNum1 = Num1.Text;
          string inputNum2 = Num2.Text;
          int iNum1 =Int32.Parse(inputNum1);
          int iNum2 =Int32.Parse(inputNum2);
          int iResult = iNum1 + iNum2;
          result.Text = iResult.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            float iNum1 = Int32.Parse(inputNum1);
            float iNum2 = Int32.Parse(inputNum2);
            float iResult = iNum1 / iNum2;
            result.Text = iResult.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 - iNum2;
            result.Text = iResult.ToString();
        }

        private void result2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 * iNum2;
            result.Text = iResult.ToString();
        }
    }
    }

