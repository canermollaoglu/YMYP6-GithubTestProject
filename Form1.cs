using GithubTestProject.Entities;

namespace GithubTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product urun = new Product()
            {
                ProductID = 1,
                ProductName = "Iphone 15 Pro Max",
                UnitPrice = 98500,
                UnitsInStock = 140
            };

            MessageBox.Show(urun.ProductName);

            if (urun.ProductName!=null)
            {
                MessageBox.Show("Test");
            }
        }
    }
}
