using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getraenkemarkt
{
    public partial class Form1 : Form
    {
        Preise preis = new Preise();
        int count = 0;
        int count2 = 0;
        int FantaID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void ResetBTN_Click(object sender, EventArgs e)
        {
            AllReset();
        }

        public void AllReset()
        {
            FantaTBox.Text = "0";
            ColaTBox.Text = "0";
            BierTBox.Text = "0";
            MSteuerTxT.Text = "2€";
            FantaCHBox.Checked = false;
            ColaCHBox.Checked = false;
            BierCHBox.Checked = false;
        }
       
        public void line()
        {
            int count2 = 1;
            QuittungRichBox.AppendText("---------------------------------------------------------------------------" + Environment.NewLine);
        }

        public void total()
        {
            double fanta_l = Convert.ToDouble(FantaTBox.Text);
            double cola_l = Convert.ToDouble(ColaTBox.Text);
            double bier_l = Convert.ToDouble(BierTBox.Text);
          
            double G_Kosten = (fanta_l * preis.Fanta) + (cola_l * preis.Cola) + (bier_l * preis.Bier);
            double MwStr_Kosten = (G_Kosten + preis.MehrwertSteuer);
            QuittungRichBox.AppendText("  MwStr \t\t\t\t" + preis.MehrwertSteuer + " €" + Environment.NewLine);
            line();
            QuittungRichBox.AppendText("  Summe \t\t\t\t" + MwStr_Kosten + " €" + Environment.NewLine);
        }
        
        public void CheckBoxController()
        {
            if (FantaTBox.Text != "0")
            {
                count = 1;
                QuittungRichBox.AppendText("  Fanta \t\t\t\t" + FantaTBox.Text + Environment.NewLine);
            }
           
            if (ColaTBox.Text != "0")
            {
                QuittungRichBox.AppendText("  Cola \t\t\t\t" + ColaTBox.Text + Environment.NewLine);
            }

            if (BierTBox.Text != "0")
            {
                QuittungRichBox.AppendText("  Bier \t\t\t\t" + Convert.ToInt16(BierTBox.Text) + Environment.NewLine);
            }
        }
      

        public void UpdateArtical()
        {
            using (var db = new BeverageShopEntities())
            {
                
                bool isParsed = Int32.TryParse(testText.Text, out int Id);
                Int32.TryParse(FantaTBox.Text, out int NewMenge);
                //Int32.TryParse(Preis_txtBox.Text, out int Pd);
                beverage model = db.beverage.Where(x => x.beverage_ID == Id).FirstOrDefault();
               
                //if (model.beverageQuantity < NewMenge)
                //{
                //    MessageBox.Show("haaalllttt stttooopppp ");
                //    return;
                //}
                model.beverageQuantity -= NewMenge;
                db.SaveChanges();
                
                //else if (count == 2)
                //{
                //    model.beverageQuantity += NewMenge;
                //}
                
                
            }

        }

        private void QuittungBTN_Click(object sender, EventArgs e)
        {
            QuittungRichBox.AppendText("\t Drinkee Market \t\t" + Environment.NewLine);
            line();
            CheckBoxController();
            //UpdateArtical();
            //Form1_Load(sender, e);
            line();
            total();
            AllReset();
            
        }

        private void FantaTBox_Click(object sender, EventArgs e)
        {
            FantaCHBox.Checked = true;
        }

        private void ColaTBox_Click(object sender, EventArgs e)
        {
            ColaCHBox.Checked = true;
        }

        private void BierTBox_Click(object sender, EventArgs e)
        {
            BierCHBox.Checked = true;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            QuittungRichBox.Text = "";
            AllReset();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beverageShopDataSet1.beverage' table. You can move, or remove it, as needed.
            this.beverageTableAdapter.Fill(this.beverageShopDataSet1.beverage);
            // TODO: This line of code loads data into the 'beverageShopDataSet.beverage' table. You can move, or remove it, as needed.
            

        }

        private void FantaTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
