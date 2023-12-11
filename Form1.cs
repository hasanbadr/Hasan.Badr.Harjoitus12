namespace Hasan.Badr.Harjoitus12
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "B", "A", "C", "D" };
        int laskuri = 0;
        int oikein = 0;

        public Form1()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(RadioButton_Checkedcanged);
            VastausBRB.CheckedChanged += new EventHandler(RadioButton_Checkedcanged);
            VastausCRB.CheckedChanged += new EventHandler(RadioButton_Checkedcanged);
            VastausDRB.CheckedChanged += new EventHandler(RadioButton_Checkedcanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RadioButton_Checkedcanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri <= 10)
            {
                RadioButton radiobutton = (RadioButton)sender;
                vastaukset[laskuri] = radiobutton.Text;
                kysymysLB.Text = "Vastaus" + (laskuri) + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}