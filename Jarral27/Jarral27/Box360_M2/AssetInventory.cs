using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box360_M2
{
    public partial class AssetInventory : Form
    {
        public AssetInventory()
        {
            InitializeComponent();
        }

        private void assetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBox360);

        }

        private void AssetInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBox360.Asset' table. You can move, or remove it, as needed.
            this.assetTableAdapter.Fill(this.dsBox360.Asset);

        }

        private void assetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AssetIdBtn_Click(object sender, EventArgs e)
        {
           
            Random random = new Random();
            string id = "";

            int colIndex = 0;
            bool bFound = false;
            bool isFound = false;

            while (bFound == false)
            {
                isFound = false;
                id = (random.Next(10000, 99999)).ToString();
                foreach (DataGridViewRow row in Assetdb.Rows)
                {
                    if (row.Cells[colIndex].Value != null && getIntID(row.Cells[colIndex].Value.ToString()) == "AI" + id)
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    bFound = true;
                }
            }

            TxtAssetID.Text = "AI" + id;

           
        }
        private string getIntID(string id)
        {
            string temp = id.Substring(2);

            return temp;
        }

        private void AddAsset_Click(object sender, EventArgs e)
        {
            string AssetId = TxtAssetID.Text;
            string AssetName = txtAssName.Text;
            string Condition = TxtCondition.Text;
            int Quantity = Convert.ToInt32(this.TxtQuantity.Text);
            string Type = TxtType.Text;
            int CostPrice = Convert.ToInt32(this.TxtCostPrice.Text);

            assetTableAdapter.Insert(AssetId, AssetName, Condition, CostPrice, Type, Quantity);
            this.assetTableAdapter.Fill(this.dsBox360.Asset);


        }

        private void AddAssetgb_Enter(object sender, EventArgs e)
        {

        }

        private void TxtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAsset_Click(object sender, EventArgs e)
        {
            assetTableAdapter.UpdateConditionMethod(updateconditioncb.Text, Assetdb.CurrentRow.Cells[0].Value.ToString(), Assetdb.CurrentRow.Cells[0].Value.ToString());
            assetTableAdapter.UpdateQuantityMethod(int.Parse(TxtUpdateQuantity.Text), Assetdb.CurrentRow.Cells[0].Value.ToString(), Assetdb.CurrentRow.Cells[0].Value.ToString());
            this.assetTableAdapter.Fill(this.dsBox360.Asset);

        }

        private void DeleteAsset_Click(object sender, EventArgs e)
        {
            dsBox360.Asset.Rows[Assetdb.CurrentRow.Index].Delete();
        }
    }
}
