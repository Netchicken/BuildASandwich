namespace BuildASandwich
{
    public partial class Form1 : Form
    {
        string toppings = "";
        string olives = "", carrot = "", lettuce = "", tomato = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void rbFeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFeta.Checked)
            {
                lblCheese.Text = rbFeta.Text;
            }
        }

        private void rbMozzarella_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMozzarella.Checked)
            {
                lblCheese.Text = rbMozzarella.Text;
            }
        }

        private void rbGouda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGouda.Checked)
            {
                lblCheese.Text = rbGouda.Text;
            }
        }

        private void rbWholemeal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWholemeal.Checked)
            {
                lblBread.Text = rbWholemeal.Text;
            }
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWhite.Checked)
            {
                lblBread.Text = rbWhite.Text;
            }
        }

        private void rbItalian_CheckedChanged(object sender, EventArgs e)
        {
            if (rbItalian.Checked)
            {
                lblBread.Text = rbItalian.Text;
            }
        }

        private void cbxOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOlives.Checked)
            {
                olives = cbxOlives.Text;
            }
            else
            {
                olives = "";
            }
            toppings = olives + " " + carrot + " " + lettuce + " " + tomato;
            lblTopping.Text = toppings;
        }

        private void cbxCarrot_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCarrot.Checked)
            {
                carrot = cbxCarrot.Text;
            }
            else
            {
                carrot = "";
            }
            toppings = olives + " " + carrot + " " + lettuce + " " + tomato;
            lblTopping.Text = toppings;
        }

        private void cbxLettuce_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLettuce.Checked)
            {
                lettuce = cbxLettuce.Text;
            }
            else
            {
                lettuce = "";
            }
            toppings = olives + " " + carrot + " " + lettuce + " " + tomato;
            lblTopping.Text = toppings;
        }

        private void cbxTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTomato.Checked)
            {
                tomato = cbxTomato.Text;
            }
            else
            {
                tomato = "";
            }
            toppings = olives + " " + carrot + " " + lettuce + " " + tomato;
            lblTopping.Text = toppings;
        }
    }
}
