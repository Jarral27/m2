
namespace Box360_M2
{
    partial class AssetInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetInventory));
            this.assetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.assetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Assetdb = new System.Windows.Forms.DataGridView();
            this.TxtAssetID = new System.Windows.Forms.TextBox();
            this.AssetIdBtn = new System.Windows.Forms.Button();
            this.txtAssName = new System.Windows.Forms.TextBox();
            this.AssNameLabel = new System.Windows.Forms.Label();
            this.TxtCondition = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.CostPrice = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.TxtCostPrice = new System.Windows.Forms.TextBox();
            this.AddAsset = new System.Windows.Forms.Button();
            this.AddAssetgb = new System.Windows.Forms.GroupBox();
            this.UpdateAssetgb = new System.Windows.Forms.GroupBox();
            this.TxtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.UpdateQuantity = new System.Windows.Forms.Label();
            this.UpdateCondition = new System.Windows.Forms.Label();
            this.updateconditioncb = new System.Windows.Forms.ComboBox();
            this.UpdateAsset = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBox360 = new Box360_M2.dsBox360();
            this.assetTableAdapter = new Box360_M2.dsBox360TableAdapters.AssetTableAdapter();
            this.tableAdapterManager = new Box360_M2.dsBox360TableAdapters.TableAdapterManager();
            this.DeleteAsset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingNavigator)).BeginInit();
            this.assetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Assetdb)).BeginInit();
            this.AddAssetgb.SuspendLayout();
            this.UpdateAssetgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).BeginInit();
            this.SuspendLayout();
            // 
            // assetBindingNavigator
            // 
            this.assetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetBindingNavigator.BindingSource = this.assetBindingSource;
            this.assetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.assetBindingNavigatorSaveItem});
            this.assetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetBindingNavigator.Name = "assetBindingNavigator";
            this.assetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetBindingNavigator.Size = new System.Drawing.Size(1332, 27);
            this.assetBindingNavigator.TabIndex = 0;
            this.assetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // assetBindingNavigatorSaveItem
            // 
            this.assetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetBindingNavigatorSaveItem.Image")));
            this.assetBindingNavigatorSaveItem.Name = "assetBindingNavigatorSaveItem";
            this.assetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.assetBindingNavigatorSaveItem.Text = "Save Data";
            this.assetBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetBindingNavigatorSaveItem_Click);
            // 
            // Assetdb
            // 
            this.Assetdb.AutoGenerateColumns = false;
            this.Assetdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Assetdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.Assetdb.DataSource = this.assetBindingSource;
            this.Assetdb.Location = new System.Drawing.Point(18, 52);
            this.Assetdb.Name = "Assetdb";
            this.Assetdb.RowHeadersWidth = 51;
            this.Assetdb.RowTemplate.Height = 24;
            this.Assetdb.Size = new System.Drawing.Size(802, 220);
            this.Assetdb.TabIndex = 1;
            this.Assetdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetDataGridView_CellContentClick);
            // 
            // TxtAssetID
            // 
            this.TxtAssetID.Location = new System.Drawing.Point(149, 46);
            this.TxtAssetID.Name = "TxtAssetID";
            this.TxtAssetID.ReadOnly = true;
            this.TxtAssetID.Size = new System.Drawing.Size(111, 22);
            this.TxtAssetID.TabIndex = 2;
            this.TxtAssetID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AssetIdBtn
            // 
            this.AssetIdBtn.Location = new System.Drawing.Point(6, 30);
            this.AssetIdBtn.Name = "AssetIdBtn";
            this.AssetIdBtn.Size = new System.Drawing.Size(137, 38);
            this.AssetIdBtn.TabIndex = 3;
            this.AssetIdBtn.Text = "Generate Asset ID";
            this.AssetIdBtn.UseVisualStyleBackColor = true;
            this.AssetIdBtn.Click += new System.EventHandler(this.AssetIdBtn_Click);
            // 
            // txtAssName
            // 
            this.txtAssName.Location = new System.Drawing.Point(149, 93);
            this.txtAssName.Name = "txtAssName";
            this.txtAssName.Size = new System.Drawing.Size(111, 22);
            this.txtAssName.TabIndex = 4;
            // 
            // AssNameLabel
            // 
            this.AssNameLabel.AutoSize = true;
            this.AssNameLabel.Location = new System.Drawing.Point(59, 96);
            this.AssNameLabel.Name = "AssNameLabel";
            this.AssNameLabel.Size = new System.Drawing.Size(84, 17);
            this.AssNameLabel.TabIndex = 5;
            this.AssNameLabel.Text = "Asset Name";
            // 
            // TxtCondition
            // 
            this.TxtCondition.Location = new System.Drawing.Point(149, 136);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.Size = new System.Drawing.Size(111, 22);
            this.TxtCondition.TabIndex = 6;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(76, 141);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(67, 17);
            this.ConditionLabel.TabIndex = 7;
            this.ConditionLabel.Text = "Condition";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(344, 51);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.label1_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(365, 96);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type";
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSize = true;
            this.CostPrice.Location = new System.Drawing.Point(333, 141);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(72, 17);
            this.CostPrice.TabIndex = 10;
            this.CostPrice.Text = "Cost Price";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(411, 51);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(111, 22);
            this.TxtQuantity.TabIndex = 11;
            // 
            // TxtType
            // 
            this.TxtType.Location = new System.Drawing.Point(411, 93);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(111, 22);
            this.TxtType.TabIndex = 12;
            this.TxtType.TextChanged += new System.EventHandler(this.TxtType_TextChanged);
            // 
            // TxtCostPrice
            // 
            this.TxtCostPrice.Location = new System.Drawing.Point(411, 136);
            this.TxtCostPrice.Name = "TxtCostPrice";
            this.TxtCostPrice.Size = new System.Drawing.Size(111, 22);
            this.TxtCostPrice.TabIndex = 13;
            // 
            // AddAsset
            // 
            this.AddAsset.Location = new System.Drawing.Point(571, 91);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Size = new System.Drawing.Size(120, 67);
            this.AddAsset.TabIndex = 14;
            this.AddAsset.Text = "Add Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            this.AddAsset.Click += new System.EventHandler(this.AddAsset_Click);
            // 
            // AddAssetgb
            // 
            this.AddAssetgb.Controls.Add(this.TxtCostPrice);
            this.AddAssetgb.Controls.Add(this.AddAsset);
            this.AddAssetgb.Controls.Add(this.TxtType);
            this.AddAssetgb.Controls.Add(this.TxtAssetID);
            this.AddAssetgb.Controls.Add(this.TxtQuantity);
            this.AddAssetgb.Controls.Add(this.Quantity);
            this.AddAssetgb.Controls.Add(this.Type);
            this.AddAssetgb.Controls.Add(this.CostPrice);
            this.AddAssetgb.Controls.Add(this.ConditionLabel);
            this.AddAssetgb.Controls.Add(this.AssetIdBtn);
            this.AddAssetgb.Controls.Add(this.TxtCondition);
            this.AddAssetgb.Controls.Add(this.txtAssName);
            this.AddAssetgb.Controls.Add(this.AssNameLabel);
            this.AddAssetgb.Location = new System.Drawing.Point(12, 332);
            this.AddAssetgb.Name = "AddAssetgb";
            this.AddAssetgb.Size = new System.Drawing.Size(723, 193);
            this.AddAssetgb.TabIndex = 15;
            this.AddAssetgb.TabStop = false;
            this.AddAssetgb.Text = "Add an Asset";
            this.AddAssetgb.Enter += new System.EventHandler(this.AddAssetgb_Enter);
            // 
            // UpdateAssetgb
            // 
            this.UpdateAssetgb.Controls.Add(this.UpdateAsset);
            this.UpdateAssetgb.Controls.Add(this.updateconditioncb);
            this.UpdateAssetgb.Controls.Add(this.UpdateCondition);
            this.UpdateAssetgb.Controls.Add(this.UpdateQuantity);
            this.UpdateAssetgb.Controls.Add(this.TxtUpdateQuantity);
            this.UpdateAssetgb.Location = new System.Drawing.Point(783, 332);
            this.UpdateAssetgb.Name = "UpdateAssetgb";
            this.UpdateAssetgb.Size = new System.Drawing.Size(449, 193);
            this.UpdateAssetgb.TabIndex = 16;
            this.UpdateAssetgb.TabStop = false;
            this.UpdateAssetgb.Text = "Update Asset";
            // 
            // TxtUpdateQuantity
            // 
            this.TxtUpdateQuantity.Location = new System.Drawing.Point(148, 51);
            this.TxtUpdateQuantity.Name = "TxtUpdateQuantity";
            this.TxtUpdateQuantity.Size = new System.Drawing.Size(121, 22);
            this.TxtUpdateQuantity.TabIndex = 0;
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.AutoSize = true;
            this.UpdateQuantity.Location = new System.Drawing.Point(31, 54);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(111, 17);
            this.UpdateQuantity.TabIndex = 1;
            this.UpdateQuantity.Text = "Update Quantity";
            // 
            // UpdateCondition
            // 
            this.UpdateCondition.AutoSize = true;
            this.UpdateCondition.Location = new System.Drawing.Point(25, 98);
            this.UpdateCondition.Name = "UpdateCondition";
            this.UpdateCondition.Size = new System.Drawing.Size(117, 17);
            this.UpdateCondition.TabIndex = 2;
            this.UpdateCondition.Text = "Update Condition";
            // 
            // updateconditioncb
            // 
            this.updateconditioncb.AutoCompleteCustomSource.AddRange(new string[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.updateconditioncb.FormattingEnabled = true;
            this.updateconditioncb.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.updateconditioncb.Location = new System.Drawing.Point(148, 93);
            this.updateconditioncb.Name = "updateconditioncb";
            this.updateconditioncb.Size = new System.Drawing.Size(121, 24);
            this.updateconditioncb.TabIndex = 3;
            // 
            // UpdateAsset
            // 
            this.UpdateAsset.Location = new System.Drawing.Point(297, 91);
            this.UpdateAsset.Name = "UpdateAsset";
            this.UpdateAsset.Size = new System.Drawing.Size(120, 67);
            this.UpdateAsset.TabIndex = 15;
            this.UpdateAsset.Text = "Update Asset";
            this.UpdateAsset.UseVisualStyleBackColor = true;
            this.UpdateAsset.Click += new System.EventHandler(this.UpdateAsset_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AssetID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AssetName";
            this.dataGridViewTextBoxColumn2.HeaderText = "AssetName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn3.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CostPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "CostPrice";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataMember = "Asset";
            this.assetBindingSource.DataSource = this.dsBox360;
            // 
            // dsBox360
            // 
            this.dsBox360.DataSetName = "dsBox360";
            this.dsBox360.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetTableAdapter
            // 
            this.assetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetTableAdapter = this.assetTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.SaleItemTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.SupplierOrderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Box360_M2.dsBox360TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DeleteAsset
            // 
            this.DeleteAsset.Location = new System.Drawing.Point(1001, 149);
            this.DeleteAsset.Name = "DeleteAsset";
            this.DeleteAsset.Size = new System.Drawing.Size(144, 51);
            this.DeleteAsset.TabIndex = 17;
            this.DeleteAsset.Text = "Delete Asset";
            this.DeleteAsset.UseVisualStyleBackColor = true;
            this.DeleteAsset.Click += new System.EventHandler(this.DeleteAsset_Click);
            // 
            // AssetInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 590);
            this.Controls.Add(this.DeleteAsset);
            this.Controls.Add(this.UpdateAssetgb);
            this.Controls.Add(this.Assetdb);
            this.Controls.Add(this.assetBindingNavigator);
            this.Controls.Add(this.AddAssetgb);
            this.Name = "AssetInventory";
            this.Load += new System.EventHandler(this.AssetInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingNavigator)).EndInit();
            this.assetBindingNavigator.ResumeLayout(false);
            this.assetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Assetdb)).EndInit();
            this.AddAssetgb.ResumeLayout(false);
            this.AddAssetgb.PerformLayout();
            this.UpdateAssetgb.ResumeLayout(false);
            this.UpdateAssetgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBox360 dsBox360;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private dsBox360TableAdapters.AssetTableAdapter assetTableAdapter;
        private dsBox360TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton assetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView Assetdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox TxtAssetID;
        private System.Windows.Forms.Button AssetIdBtn;
        private System.Windows.Forms.TextBox txtAssName;
        private System.Windows.Forms.Label AssNameLabel;
        private System.Windows.Forms.TextBox TxtCondition;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label CostPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.TextBox TxtCostPrice;
        private System.Windows.Forms.Button AddAsset;
        private System.Windows.Forms.GroupBox AddAssetgb;
        private System.Windows.Forms.GroupBox UpdateAssetgb;
        private System.Windows.Forms.ComboBox updateconditioncb;
        private System.Windows.Forms.Label UpdateCondition;
        private System.Windows.Forms.Label UpdateQuantity;
        private System.Windows.Forms.TextBox TxtUpdateQuantity;
        private System.Windows.Forms.Button UpdateAsset;
        private System.Windows.Forms.Button DeleteAsset;
    }
}