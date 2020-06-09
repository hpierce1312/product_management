//BUS 442 - Project 3
//Description - Product/Vendor Database App
//Developers - Hudson Pierce, Donnie Jenkins, Dawson Proctor
//Date - 12/5/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.pRODUCTBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.productDatabaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDatabaseDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.productDatabaseDataSet.VENDOR);
            // TODO: This line of code loads data into the 'productDatabaseDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.productDatabaseDataSet.PRODUCT);
        }

        private void clear()
        {
            //clear the listview
            listView.Items.Clear();
        }

        private void calculate()
        {
            clear();
            //declare variables
            double purchaseAmt = 0;
            double purchasesTotal = 0;
            double purchasesAvg = 0;
            int numOfPurchases = 0;
            int count = 1;
            //string[] fieldsArray = new string[2];
            string productName;

            //loop through data to get and display the purchase amount
            foreach (DataRow dr in productDatabaseDataSet.PRODUCT.Rows)
            {
                //get the purchase amount and product name for each row
                purchaseAmt = double.Parse(dr["YTDPurchases"].ToString());
                purchasesTotal += purchaseAmt;
                productName = dr["ProductName"].ToString();

                //create an array to store product name and purchase amount values
                string[] fieldsArray = new string[2];
                fieldsArray[0] = productName;
                fieldsArray[1] = purchaseAmt.ToString("C2");

                //display the purchase amount for each row in list view
                ListViewItem showsLVI = new ListViewItem(fieldsArray);
                listView.Items.Add(showsLVI);

                //variable to calculate the number of purchases
                numOfPurchases = count++;
            }

            //display the total purchase amount in label
            YTDTotalPurchaseLabel.Text = purchasesTotal.ToString("C2");

            //calculate the average purchase amount
            purchasesAvg = purchasesTotal / numOfPurchases;

            //display the average purchase amount in label
            YTDAveragePurchaseLabel.Text = purchasesAvg.ToString("C2");
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void ToolStripSearchButton_Click(object sender, EventArgs e)
        {
            //disable calculate button if search button is clicked
            calcBtn.Enabled = false;
        }

        private void sourcedInUSA()
        {
            //display products sourced in the USA
            this.pRODUCTTableAdapter.SortByUSA(this.productDatabaseDataSet.PRODUCT);
            calculate();
        }

        private void sourcedInChina()
        {
            //display products sourced in China
            this.pRODUCTTableAdapter.SortByChina(this.productDatabaseDataSet.PRODUCT);
            calculate();
        }

        private void sourcedInNY()
        {
            //display products sourced in New York
            this.pRODUCTTableAdapter.SortByNY(this.productDatabaseDataSet.PRODUCT);
            calculate();
        }

        private void ProductsSourcedInUSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourcedInUSA();
        }

        private void ProductsSourcedInChinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourcedInChina();
        }

        private void ProductsSourcedInNewYorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourcedInNY();
        }

        private void exit()
        {
            //exit the app with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void ToolStripFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                //search for product name via filter
                pRODUCTBindingSource.Filter = "ProductName LIKE '" + filterComboBox.Text + "*'";

                if (string.IsNullOrWhiteSpace(filterComboBox.Text))
                {
                    throw new Exception();
                }
            }

            catch
            {
                MessageBox.Show("No results for searched characters", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortByProductIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.SortByProductID(this.productDatabaseDataSet.PRODUCT);
        }

        private void SortByProductPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.SortByProductPrice(this.productDatabaseDataSet.PRODUCT);
        }

        private void SortByProductCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.SortByProductCost(this.productDatabaseDataSet.PRODUCT);
        }

        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.SortByProductName(this.productDatabaseDataSet.PRODUCT);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            clear();

            //return form's data back to original records after a search
            this.pRODUCTTableAdapter.Fill(this.productDatabaseDataSet.PRODUCT);

            //enable calculate button when refresh button is clicked
            calcBtn.Enabled = true;
        }
    }
}
