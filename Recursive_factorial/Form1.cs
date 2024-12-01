namespace Recursive_factorial
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
            number= 0;
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            number=Convert.ToInt32(txtNumber.Text);
            int result = CalculateFactorial(number);
            txtFactorial.Text = result.ToString();
        }

        public static int CalculateFactorial(int number )
        {
            if (number == 1)
            {
                return number;

            }

            else
            {
                
                return number * CalculateFactorial(number - 1);
            }
        }
    }
}
