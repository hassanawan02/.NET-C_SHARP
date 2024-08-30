namespace MyFirstActualProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            String text2 = textBox2.Text;
            if (text == null || text2 == null)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            if (float.TryParse(text, out float result) && float.TryParse(text2, out float result2))
            {
                if (Height == 0)
                {
                    MessageBox.Show("Height cannot be zero");
                    return;
                }
                float BMI = result / (result2 * result2);
                if (BMI < 18.5)
                {
                    MessageBox.Show("You have a BMI of " + BMI + ", which means you're underweight");
                } 
                else if (BMI >= 18.5 && BMI < 25)
                {
                    MessageBox.Show("You have a BMI of " + BMI + ", which means you have a normal weight");
                }
                else if (BMI >= 25 && BMI < 30)
                {
                    MessageBox.Show("You have a BMI of " + BMI + ", which means you're overweight");
                }
                else
                {
                    MessageBox.Show("You have a BMI of " + BMI + ", which means you're obese");
                }
            }
            else
            {
                MessageBox.Show("Enter valid numbers");
            }

        }

    }
}