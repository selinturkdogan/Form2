namespace Selin_Türkdoğan_2103060004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFrenchFries_Click(object sender, EventArgs e)
        {

        }

        private void pbFries_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFriesPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtFries.Text);
            txtFries.Text = (++count).ToString();
        }

        private void btnFriesMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtFries.Text);
            if (count > 0)
                txtFries.Text = (--count).ToString();
        }

        private void btnCherryLimeadePlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtCherryLimeade.Text);
            txtCherryLimeade.Text = (++count).ToString();
        }

        private void btnCherryLimeadeMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtCherryLimeade.Text);
            if (count > 0)
                txtCherryLimeade.Text = (--count).ToString();
        }

        private void btnQuarterPounderPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtQuarterPounder.Text);
            txtQuarterPounder.Text = (++count).ToString();
        }

        private void btnQuarterPounderMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtQuarterPounder.Text);
            if (count > 0)
                txtQuarterPounder.Text = (--count).ToString();
        }


        private void btnBroccoliCheddarSoupPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtBroccoliCheddarSoup.Text);
            txtBroccoliCheddarSoup.Text = (++count).ToString();
        }

        private void btnBroccoliCheddarSoupMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtBroccoliCheddarSoup.Text);
            if (count > 0)
                txtBroccoliCheddarSoup.Text = (--count).ToString();
        }

        private void btnWhoperPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtBurgersKingWhoper.Text);
            txtBurgersKingWhoper.Text = (++count).ToString();
        }

        private void BtnBurgersKingMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtBurgersKingWhoper.Text);
            if (count > 0)
                txtBurgersKingWhoper.Text = (--count).ToString();
        }

        private void btnDoubleDelCheeseburgerPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtDoubleCheeseburger.Text);
            txtDoubleCheeseburger.Text = (++count).ToString();
        }

        private void btnDoubleCheeseburgerMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtDoubleCheeseburger.Text);
            if (count > 0)
                txtDoubleCheeseburger.Text = (--count).ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int friesPrice = 5;
            int cherryLimeadePrice = 4;
            int quarterPounderPrice = 15;

            
            int friesCount = int.Parse(txtFries.Text);
            int cherryLimeadeCount = int.Parse(txtCherryLimeade.Text);
            int quarterPounderCount = int.Parse(txtQuarterPounder.Text);

       
            int total = (friesCount * friesPrice) +
                        (cherryLimeadeCount * cherryLimeadePrice) +
                        (quarterPounderCount * quarterPounderPrice);

            
            lstSelectedItems.Items.Clear();
            if (friesCount > 0) lstSelectedItems.Items.Add($"French Fries x {friesCount}");
            if (cherryLimeadeCount > 0) lstSelectedItems.Items.Add($"Cherry Limeade x {cherryLimeadeCount}");
            if (quarterPounderCount > 0) lstSelectedItems.Items.Add($"Quarter Pounder x {quarterPounderCount}");

            lblTotalPrice.Text = $"Total Price: {total} $";
        }
    }
}
