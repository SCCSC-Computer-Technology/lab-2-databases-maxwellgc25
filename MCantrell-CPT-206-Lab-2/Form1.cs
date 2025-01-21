using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCantrell_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        //Max Cantrell
        //CPT 206 A80S
        //Ch12 Lab 2 City Populations
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityPopDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityPopDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityPopDataSet.City);

        }

        //close button
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.Dispose();
            this.Close();
        }

        //sort by city ascending button
        private void citySortBtn_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityOrder(this.cityPopDataSet.City);
        }

        //sort by population ascending button
        private void popAscBtn_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopAscOrder(this.cityPopDataSet.City);
        }

        //sort by population decending button
        private void popDscBtn_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopDscOrder(this.cityPopDataSet.City);
        }

        //get total population button
        private void totalPopBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population of all Citys: " + this.cityTableAdapter.TotalPopQuery());
        }

        //get average population button
        private void avgPopBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population of all Citys: " + this.cityTableAdapter.AvgPopQuery());
        }

        //get highest population button
        private void highPopBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Population of all Citys: " + this.cityTableAdapter.MaxPopQuery());
        }

        //get lowest population button
        private void lowPopBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest Population of all Citys: " + this.cityTableAdapter.MinPopQuery());
        }
    }
}
