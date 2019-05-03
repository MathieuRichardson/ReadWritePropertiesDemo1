using System;
using System.Data;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon myFirstBalloon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                myFirstBalloon = new Balloon()
                {
                    Colour = txtColor.Text.Trim(),
                    Diamiter = Convert.ToDecimal(txtDiameter.Text.Trim()),
                    Height = Convert.ToDecimal(txtHeight.Text.Trim())
                };
                //myFirstBalloon.Colour = txtColor.Text.Trim();
                //myFirstBalloon.Diamiter = Convert.ToDecimal(txtDiameter.Text.Trim());
                //myFirstBalloon.Height = Convert.ToDecimal(txtHeight.Text.Trim());

            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"color: {myFirstBalloon.Colour} " +
                $"\nHeight: {myFirstBalloon.Height.ToString()}" +
                $"\nDiameter: {myFirstBalloon.Diamiter.ToString()}";
        }
    }
}
