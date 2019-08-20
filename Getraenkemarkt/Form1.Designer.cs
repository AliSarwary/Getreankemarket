namespace Getraenkemarkt
{
    partial class Form1
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
            this.Titelpanel = new System.Windows.Forms.Panel();
            this.List1panel = new System.Windows.Forms.Panel();
            this.BierTBox = new System.Windows.Forms.TextBox();
            this.ColaTBox = new System.Windows.Forms.TextBox();
            this.FantaTBox = new System.Windows.Forms.TextBox();
            this.BierCHBox = new System.Windows.Forms.CheckBox();
            this.ColaCHBox = new System.Windows.Forms.CheckBox();
            this.FantaCHBox = new System.Windows.Forms.CheckBox();
            this.QuittungRichBox = new System.Windows.Forms.RichTextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.QuittungBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.KostPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MSteuerTxT = new System.Windows.Forms.TextBox();
            this.NettoSummeTxT = new System.Windows.Forms.TextBox();
            this.List2panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testText = new System.Windows.Forms.TextBox();
            this.beverageShopDataSet1 = new Getraenkemarkt.BeverageShopDataSet1();
            this.beverageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beverageTableAdapter = new Getraenkemarkt.BeverageShopDataSet1TableAdapters.beverageTableAdapter();
            this.beverageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beverageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beverageQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List1panel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.KostPanel.SuspendLayout();
            this.List2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Titelpanel
            // 
            this.Titelpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Titelpanel.Location = new System.Drawing.Point(124, 58);
            this.Titelpanel.Name = "Titelpanel";
            this.Titelpanel.Size = new System.Drawing.Size(1161, 169);
            this.Titelpanel.TabIndex = 0;
            // 
            // List1panel
            // 
            this.List1panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.List1panel.Controls.Add(this.testText);
            this.List1panel.Controls.Add(this.BierTBox);
            this.List1panel.Controls.Add(this.ColaTBox);
            this.List1panel.Controls.Add(this.FantaTBox);
            this.List1panel.Controls.Add(this.BierCHBox);
            this.List1panel.Controls.Add(this.ColaCHBox);
            this.List1panel.Controls.Add(this.FantaCHBox);
            this.List1panel.Location = new System.Drawing.Point(124, 233);
            this.List1panel.Name = "List1panel";
            this.List1panel.Size = new System.Drawing.Size(607, 400);
            this.List1panel.TabIndex = 1;
            // 
            // BierTBox
            // 
            this.BierTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BierTBox.Location = new System.Drawing.Point(282, 143);
            this.BierTBox.Name = "BierTBox";
            this.BierTBox.Size = new System.Drawing.Size(100, 23);
            this.BierTBox.TabIndex = 5;
            this.BierTBox.Text = "0";
            this.BierTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BierTBox.Click += new System.EventHandler(this.BierTBox_Click);
            // 
            // ColaTBox
            // 
            this.ColaTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColaTBox.Location = new System.Drawing.Point(282, 89);
            this.ColaTBox.Name = "ColaTBox";
            this.ColaTBox.Size = new System.Drawing.Size(100, 23);
            this.ColaTBox.TabIndex = 4;
            this.ColaTBox.Text = "0";
            this.ColaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColaTBox.Click += new System.EventHandler(this.ColaTBox_Click);
            // 
            // FantaTBox
            // 
            this.FantaTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FantaTBox.ForeColor = System.Drawing.Color.DarkGray;
            this.FantaTBox.Location = new System.Drawing.Point(282, 43);
            this.FantaTBox.Name = "FantaTBox";
            this.FantaTBox.Size = new System.Drawing.Size(100, 23);
            this.FantaTBox.TabIndex = 3;
            this.FantaTBox.Text = "0";
            this.FantaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FantaTBox.Click += new System.EventHandler(this.FantaTBox_Click);
            this.FantaTBox.TextChanged += new System.EventHandler(this.FantaTBox_TextChanged);
            // 
            // BierCHBox
            // 
            this.BierCHBox.AutoSize = true;
            this.BierCHBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BierCHBox.Location = new System.Drawing.Point(38, 152);
            this.BierCHBox.Name = "BierCHBox";
            this.BierCHBox.Size = new System.Drawing.Size(60, 24);
            this.BierCHBox.TabIndex = 2;
            this.BierCHBox.Text = "Bier";
            this.BierCHBox.UseVisualStyleBackColor = true;
            // 
            // ColaCHBox
            // 
            this.ColaCHBox.AutoSize = true;
            this.ColaCHBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColaCHBox.Location = new System.Drawing.Point(38, 89);
            this.ColaCHBox.Name = "ColaCHBox";
            this.ColaCHBox.Size = new System.Drawing.Size(64, 24);
            this.ColaCHBox.TabIndex = 1;
            this.ColaCHBox.Text = "Cola";
            this.ColaCHBox.UseVisualStyleBackColor = true;
            // 
            // FantaCHBox
            // 
            this.FantaCHBox.AutoSize = true;
            this.FantaCHBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FantaCHBox.Location = new System.Drawing.Point(38, 39);
            this.FantaCHBox.Name = "FantaCHBox";
            this.FantaCHBox.Size = new System.Drawing.Size(75, 24);
            this.FantaCHBox.TabIndex = 0;
            this.FantaCHBox.Text = "Fanta";
            this.FantaCHBox.UseVisualStyleBackColor = true;
            // 
            // QuittungRichBox
            // 
            this.QuittungRichBox.Location = new System.Drawing.Point(407, 0);
            this.QuittungRichBox.Name = "QuittungRichBox";
            this.QuittungRichBox.Size = new System.Drawing.Size(270, 394);
            this.QuittungRichBox.TabIndex = 0;
            this.QuittungRichBox.Text = "";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonPanel.Controls.Add(this.ResetBTN);
            this.ButtonPanel.Controls.Add(this.ExitBTN);
            this.ButtonPanel.Controls.Add(this.QuittungBTN);
            this.ButtonPanel.Controls.Add(this.UpdateBTN);
            this.ButtonPanel.Location = new System.Drawing.Point(740, 639);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(545, 110);
            this.ButtonPanel.TabIndex = 1;
            // 
            // ResetBTN
            // 
            this.ResetBTN.BackColor = System.Drawing.Color.Orange;
            this.ResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBTN.Location = new System.Drawing.Point(308, 50);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(75, 30);
            this.ResetBTN.TabIndex = 3;
            this.ResetBTN.Text = "Zurück";
            this.ResetBTN.UseVisualStyleBackColor = false;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.Orange;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(419, 50);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 30);
            this.ExitBTN.TabIndex = 2;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // QuittungBTN
            // 
            this.QuittungBTN.BackColor = System.Drawing.Color.Orange;
            this.QuittungBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuittungBTN.Location = new System.Drawing.Point(190, 50);
            this.QuittungBTN.Name = "QuittungBTN";
            this.QuittungBTN.Size = new System.Drawing.Size(75, 30);
            this.QuittungBTN.TabIndex = 1;
            this.QuittungBTN.Text = "Quittung";
            this.QuittungBTN.UseVisualStyleBackColor = false;
            this.QuittungBTN.Click += new System.EventHandler(this.QuittungBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.Orange;
            this.UpdateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.Location = new System.Drawing.Point(76, 50);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 30);
            this.UpdateBTN.TabIndex = 0;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            // 
            // KostPanel
            // 
            this.KostPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.KostPanel.Controls.Add(this.label2);
            this.KostPanel.Controls.Add(this.label1);
            this.KostPanel.Controls.Add(this.MSteuerTxT);
            this.KostPanel.Controls.Add(this.NettoSummeTxT);
            this.KostPanel.Location = new System.Drawing.Point(124, 639);
            this.KostPanel.Name = "KostPanel";
            this.KostPanel.Size = new System.Drawing.Size(607, 110);
            this.KostPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mehrwertsteuer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Netto Summe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MSteuerTxT
            // 
            this.MSteuerTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSteuerTxT.Location = new System.Drawing.Point(475, 60);
            this.MSteuerTxT.Name = "MSteuerTxT";
            this.MSteuerTxT.Size = new System.Drawing.Size(100, 23);
            this.MSteuerTxT.TabIndex = 2;
            this.MSteuerTxT.Text = "0";
            this.MSteuerTxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NettoSummeTxT
            // 
            this.NettoSummeTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NettoSummeTxT.Location = new System.Drawing.Point(475, 17);
            this.NettoSummeTxT.Name = "NettoSummeTxT";
            this.NettoSummeTxT.Size = new System.Drawing.Size(100, 23);
            this.NettoSummeTxT.TabIndex = 1;
            this.NettoSummeTxT.Text = "0";
            this.NettoSummeTxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List2panel
            // 
            this.List2panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.List2panel.Controls.Add(this.QuittungRichBox);
            this.List2panel.Controls.Add(this.dataGridView1);
            this.List2panel.Location = new System.Drawing.Point(737, 233);
            this.List2panel.Name = "List2panel";
            this.List2panel.Size = new System.Drawing.Size(700, 400);
            this.List2panel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beverageIDDataGridViewTextBoxColumn,
            this.beverageNameDataGridViewTextBoxColumn,
            this.beverageQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beverageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // testText
            // 
            this.testText.Location = new System.Drawing.Point(383, 238);
            this.testText.Name = "testText";
            this.testText.Size = new System.Drawing.Size(100, 20);
            this.testText.TabIndex = 6;
            // 
            // beverageShopDataSet1
            // 
            this.beverageShopDataSet1.DataSetName = "BeverageShopDataSet1";
            this.beverageShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beverageBindingSource
            // 
            this.beverageBindingSource.DataMember = "beverage";
            this.beverageBindingSource.DataSource = this.beverageShopDataSet1;
            // 
            // beverageTableAdapter
            // 
            this.beverageTableAdapter.ClearBeforeFill = true;
            // 
            // beverageIDDataGridViewTextBoxColumn
            // 
            this.beverageIDDataGridViewTextBoxColumn.DataPropertyName = "beverage_ID";
            this.beverageIDDataGridViewTextBoxColumn.HeaderText = "beverage_ID";
            this.beverageIDDataGridViewTextBoxColumn.Name = "beverageIDDataGridViewTextBoxColumn";
            // 
            // beverageNameDataGridViewTextBoxColumn
            // 
            this.beverageNameDataGridViewTextBoxColumn.DataPropertyName = "beverageName";
            this.beverageNameDataGridViewTextBoxColumn.HeaderText = "beverageName";
            this.beverageNameDataGridViewTextBoxColumn.Name = "beverageNameDataGridViewTextBoxColumn";
            // 
            // beverageQuantityDataGridViewTextBoxColumn
            // 
            this.beverageQuantityDataGridViewTextBoxColumn.DataPropertyName = "beverageQuantity";
            this.beverageQuantityDataGridViewTextBoxColumn.HeaderText = "beverageQuantity";
            this.beverageQuantityDataGridViewTextBoxColumn.Name = "beverageQuantityDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 995);
            this.Controls.Add(this.KostPanel);
            this.Controls.Add(this.List2panel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.List1panel);
            this.Controls.Add(this.Titelpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.List1panel.ResumeLayout(false);
            this.List1panel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.KostPanel.ResumeLayout(false);
            this.KostPanel.PerformLayout();
            this.List2panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titelpanel;
        private System.Windows.Forms.Panel List1panel;
        private System.Windows.Forms.CheckBox BierCHBox;
        private System.Windows.Forms.CheckBox ColaCHBox;
        private System.Windows.Forms.CheckBox FantaCHBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel KostPanel;
        private System.Windows.Forms.Panel List2panel;
        private System.Windows.Forms.TextBox BierTBox;
        private System.Windows.Forms.TextBox ColaTBox;
        private System.Windows.Forms.TextBox FantaTBox;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button QuittungBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MSteuerTxT;
        private System.Windows.Forms.TextBox NettoSummeTxT;
        private System.Windows.Forms.RichTextBox QuittungRichBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox testText;
        private BeverageShopDataSet1 beverageShopDataSet1;
        private System.Windows.Forms.BindingSource beverageBindingSource;
        private BeverageShopDataSet1TableAdapters.beverageTableAdapter beverageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn beverageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beverageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beverageQuantityDataGridViewTextBoxColumn;
    }
}

