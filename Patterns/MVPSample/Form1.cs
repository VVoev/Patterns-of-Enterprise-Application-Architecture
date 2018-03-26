using MVPSample.Presenters;
using MVPSample.Views;
using System;
using System.Windows.Forms;

namespace MVPSample
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string AreaText
        {
            get
            {
                return lblArea.Text;
            }

            set
            {
                lblArea.Text = value;
            }
        }

        public string HeightText
        {
            get
            {
                return textHeight.Text;
            }

            set
            {
                textHeight.Text = value;
            }
        }

        public string WidthText
        {
            get
            {
                return textWidth.Text;
            }

            set
            {
                 textWidth.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}
