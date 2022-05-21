namespace Billinggroup3
{
    partial class formRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRestaurant));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.restPanel = new System.Windows.Forms.Panel();
            this.itemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtTotNum = new System.Windows.Forms.TextBox();
            this.picExit2 = new System.Windows.Forms.PictureBox();
            this.dvgRestaurant = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBttn = new System.Windows.Forms.Button();
            this.maxBttn = new System.Windows.Forms.Button();
            this.minBttn = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.rtReceipt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scsuRest = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.bttnTotal = new System.Windows.Forms.Button();
            this.dgvClearBttn = new System.Windows.Forms.Button();
            this.bttnLaod = new System.Windows.Forms.Button();
            this.abbBtn = new System.Windows.Forms.Button();
            this.priceCombo = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printBttn = new System.Windows.Forms.Button();
            this.resetBttn = new System.Windows.Forms.Button();
            this.costItem = new System.Windows.Forms.TextBox();
            this.receiptBttn = new System.Windows.Forms.Button();
            this.numLbl = new System.Windows.Forms.Label();
            this.itemComboText = new System.Windows.Forms.ComboBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.costLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.restPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restPanel
            // 
            this.restPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restPanel.BackgroundImage")));
            this.restPanel.Controls.Add(this.itemChart);
            this.restPanel.Controls.Add(this.txtTotNum);
            this.restPanel.Controls.Add(this.picExit2);
            this.restPanel.Controls.Add(this.dvgRestaurant);
            this.restPanel.Controls.Add(this.exitBttn);
            this.restPanel.Controls.Add(this.maxBttn);
            this.restPanel.Controls.Add(this.minBttn);
            this.restPanel.Controls.Add(this.receiptLabel);
            this.restPanel.Controls.Add(this.rtReceipt);
            this.restPanel.Controls.Add(this.label3);
            this.restPanel.Controls.Add(this.picExit);
            this.restPanel.Controls.Add(this.label1);
            this.restPanel.Controls.Add(this.scsuRest);
            this.restPanel.Controls.Add(this.inputPanel);
            this.restPanel.Controls.Add(this.menuStrip1);
            this.restPanel.Location = new System.Drawing.Point(12, 12);
            this.restPanel.Name = "restPanel";
            this.restPanel.Size = new System.Drawing.Size(1346, 725);
            this.restPanel.TabIndex = 0;
            this.restPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // itemChart
            // 
            chartArea1.Name = "ChartArea1";
            this.itemChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.itemChart.Legends.Add(legend1);
            this.itemChart.Location = new System.Drawing.Point(387, 397);
            this.itemChart.Name = "itemChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Item";
            this.itemChart.Series.Add(series1);
            this.itemChart.Size = new System.Drawing.Size(512, 264);
            this.itemChart.TabIndex = 45;
            this.itemChart.Text = "chart1";
            // 
            // txtTotNum
            // 
            this.txtTotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotNum.Location = new System.Drawing.Point(707, 371);
            this.txtTotNum.Name = "txtTotNum";
            this.txtTotNum.Size = new System.Drawing.Size(148, 21);
            this.txtTotNum.TabIndex = 43;
            this.txtTotNum.Text = "Total number of items";
            // 
            // picExit2
            // 
            this.picExit2.Image = ((System.Drawing.Image)(resources.GetObject("picExit2.Image")));
            this.picExit2.Location = new System.Drawing.Point(1262, 667);
            this.picExit2.Name = "picExit2";
            this.picExit2.Size = new System.Drawing.Size(65, 50);
            this.picExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit2.TabIndex = 13;
            this.picExit2.TabStop = false;
            this.picExit2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dvgRestaurant
            // 
            this.dvgRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgRestaurant.Location = new System.Drawing.Point(387, 109);
            this.dvgRestaurant.Name = "dvgRestaurant";
            this.dvgRestaurant.Size = new System.Drawing.Size(512, 256);
            this.dvgRestaurant.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Food Item";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Number of Item";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Cost of Item";
            this.Column4.Name = "Column4";
            // 
            // exitBttn
            // 
            this.exitBttn.BackColor = System.Drawing.Color.Orange;
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(1200, 667);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(78, 50);
            this.exitBttn.TabIndex = 4;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.button5_Click);
            // 
            // maxBttn
            // 
            this.maxBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBttn.Location = new System.Drawing.Point(1237, 42);
            this.maxBttn.Name = "maxBttn";
            this.maxBttn.Size = new System.Drawing.Size(43, 36);
            this.maxBttn.TabIndex = 39;
            this.maxBttn.Text = "Max";
            this.maxBttn.UseVisualStyleBackColor = true;
            this.maxBttn.Click += new System.EventHandler(this.maxBttn_Click);
            // 
            // minBttn
            // 
            this.minBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBttn.Location = new System.Drawing.Point(1198, 55);
            this.minBttn.Name = "minBttn";
            this.minBttn.Size = new System.Drawing.Size(37, 23);
            this.minBttn.TabIndex = 38;
            this.minBttn.Text = "Min";
            this.minBttn.UseVisualStyleBackColor = true;
            this.minBttn.Click += new System.EventHandler(this.minBttn_Click_1);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(969, 121);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(54, 16);
            this.receiptLabel.TabIndex = 36;
            this.receiptLabel.Text = "Receipt";
            // 
            // rtReceipt
            // 
            this.rtReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtReceipt.Location = new System.Drawing.Point(952, 109);
            this.rtReceipt.Name = "rtReceipt";
            this.rtReceipt.Size = new System.Drawing.Size(375, 552);
            this.rtReceipt.TabIndex = 35;
            this.rtReceipt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "How hungry are you?";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1284, 38);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(43, 40);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 14;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1054, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Get the best out of our tasty meals";
            // 
            // scsuRest
            // 
            this.scsuRest.AutoSize = true;
            this.scsuRest.BackColor = System.Drawing.Color.Transparent;
            this.scsuRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scsuRest.Location = new System.Drawing.Point(234, 36);
            this.scsuRest.Name = "scsuRest";
            this.scsuRest.Size = new System.Drawing.Size(841, 55);
            this.scsuRest.TabIndex = 7;
            this.scsuRest.Text = "St Cloud State University Restaurant";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.inputPanel.Controls.Add(this.bttnTotal);
            this.inputPanel.Controls.Add(this.dgvClearBttn);
            this.inputPanel.Controls.Add(this.bttnLaod);
            this.inputPanel.Controls.Add(this.abbBtn);
            this.inputPanel.Controls.Add(this.priceCombo);
            this.inputPanel.Controls.Add(this.priceLbl);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.printBttn);
            this.inputPanel.Controls.Add(this.resetBttn);
            this.inputPanel.Controls.Add(this.costItem);
            this.inputPanel.Controls.Add(this.receiptBttn);
            this.inputPanel.Controls.Add(this.numLbl);
            this.inputPanel.Controls.Add(this.itemComboText);
            this.inputPanel.Controls.Add(this.numUpDown);
            this.inputPanel.Controls.Add(this.costLbl);
            this.inputPanel.Controls.Add(this.itemLbl);
            this.inputPanel.Location = new System.Drawing.Point(13, 109);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(329, 552);
            this.inputPanel.TabIndex = 1;
            // 
            // bttnTotal
            // 
            this.bttnTotal.AutoSize = true;
            this.bttnTotal.BackColor = System.Drawing.SystemColors.Info;
            this.bttnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTotal.Location = new System.Drawing.Point(15, 451);
            this.bttnTotal.Name = "bttnTotal";
            this.bttnTotal.Size = new System.Drawing.Size(75, 37);
            this.bttnTotal.TabIndex = 39;
            this.bttnTotal.Text = "Total";
            this.bttnTotal.UseVisualStyleBackColor = false;
            this.bttnTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvClearBttn
            // 
            this.dgvClearBttn.AutoSize = true;
            this.dgvClearBttn.BackColor = System.Drawing.SystemColors.Info;
            this.dgvClearBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvClearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClearBttn.Location = new System.Drawing.Point(248, 451);
            this.dgvClearBttn.Name = "dgvClearBttn";
            this.dgvClearBttn.Size = new System.Drawing.Size(71, 37);
            this.dgvClearBttn.TabIndex = 38;
            this.dgvClearBttn.Text = "Clear ";
            this.dgvClearBttn.UseVisualStyleBackColor = false;
            this.dgvClearBttn.Click += new System.EventHandler(this.dgvClear_Click);
            // 
            // bttnLaod
            // 
            this.bttnLaod.AutoSize = true;
            this.bttnLaod.BackColor = System.Drawing.SystemColors.Info;
            this.bttnLaod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnLaod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLaod.Location = new System.Drawing.Point(98, 451);
            this.bttnLaod.Name = "bttnLaod";
            this.bttnLaod.Size = new System.Drawing.Size(143, 37);
            this.bttnLaod.TabIndex = 37;
            this.bttnLaod.Text = "Load Chart";
            this.bttnLaod.UseVisualStyleBackColor = false;
            this.bttnLaod.Click += new System.EventHandler(this.bttnLaod_Click);
            // 
            // abbBtn
            // 
            this.abbBtn.AutoSize = true;
            this.abbBtn.BackColor = System.Drawing.SystemColors.Info;
            this.abbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.abbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abbBtn.Location = new System.Drawing.Point(173, 385);
            this.abbBtn.Name = "abbBtn";
            this.abbBtn.Size = new System.Drawing.Size(69, 32);
            this.abbBtn.TabIndex = 36;
            this.abbBtn.Text = "Add";
            this.abbBtn.UseVisualStyleBackColor = false;
            this.abbBtn.Click += new System.EventHandler(this.abbBtn_Click);
            // 
            // priceCombo
            // 
            this.priceCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCombo.FormattingEnabled = true;
            this.priceCombo.Location = new System.Drawing.Point(173, 179);
            this.priceCombo.Name = "priceCombo";
            this.priceCombo.Size = new System.Drawing.Size(120, 24);
            this.priceCombo.TabIndex = 35;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(34, 181);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(54, 20);
            this.priceLbl.TabIndex = 35;
            this.priceLbl.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tell us what you want";
            // 
            // printBttn
            // 
            this.printBttn.AutoSize = true;
            this.printBttn.BackColor = System.Drawing.SystemColors.Info;
            this.printBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBttn.Location = new System.Drawing.Point(15, 385);
            this.printBttn.Name = "printBttn";
            this.printBttn.Size = new System.Drawing.Size(75, 32);
            this.printBttn.TabIndex = 2;
            this.printBttn.Text = "Print";
            this.printBttn.UseVisualStyleBackColor = false;
            this.printBttn.Click += new System.EventHandler(this.printBttn_Click);
            // 
            // resetBttn
            // 
            this.resetBttn.AutoSize = true;
            this.resetBttn.BackColor = System.Drawing.SystemColors.Info;
            this.resetBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBttn.Location = new System.Drawing.Point(98, 385);
            this.resetBttn.Name = "resetBttn";
            this.resetBttn.Size = new System.Drawing.Size(62, 32);
            this.resetBttn.TabIndex = 3;
            this.resetBttn.Text = "Reset";
            this.resetBttn.UseVisualStyleBackColor = false;
            this.resetBttn.Click += new System.EventHandler(this.resetBttn_Click);
            // 
            // costItem
            // 
            this.costItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costItem.Location = new System.Drawing.Point(173, 287);
            this.costItem.Name = "costItem";
            this.costItem.Size = new System.Drawing.Size(120, 24);
            this.costItem.TabIndex = 31;
            // 
            // receiptBttn
            // 
            this.receiptBttn.AutoSize = true;
            this.receiptBttn.BackColor = System.Drawing.SystemColors.Info;
            this.receiptBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.receiptBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBttn.Location = new System.Drawing.Point(248, 385);
            this.receiptBttn.Name = "receiptBttn";
            this.receiptBttn.Size = new System.Drawing.Size(71, 32);
            this.receiptBttn.TabIndex = 1;
            this.receiptBttn.Text = "Receipt";
            this.receiptBttn.UseVisualStyleBackColor = false;
            this.receiptBttn.Click += new System.EventHandler(this.receiptBttn_Click);
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLbl.Location = new System.Drawing.Point(34, 232);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(138, 20);
            this.numLbl.TabIndex = 26;
            this.numLbl.Text = "Number of Item:";
            // 
            // itemComboText
            // 
            this.itemComboText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboText.FormattingEnabled = true;
            this.itemComboText.Location = new System.Drawing.Point(173, 122);
            this.itemComboText.Name = "itemComboText";
            this.itemComboText.Size = new System.Drawing.Size(120, 24);
            this.itemComboText.TabIndex = 8;
            this.itemComboText.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numUpDown
            // 
            this.numUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown.Location = new System.Drawing.Point(173, 230);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 24);
            this.numUpDown.TabIndex = 24;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown.UseWaitCursor = true;
            this.numUpDown.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.Location = new System.Drawing.Point(34, 292);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(113, 20);
            this.costLbl.TabIndex = 23;
            this.costLbl.Text = "Cost of Item:";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.Location = new System.Drawing.Point(34, 125);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(96, 20);
            this.itemLbl.TabIndex = 5;
            this.itemLbl.Text = "Food Item:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.receiptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.restPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formRestaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.restPanel.ResumeLayout(false);
            this.restPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel restPanel;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Button resetBttn;
        private System.Windows.Forms.Button printBttn;
        private System.Windows.Forms.Button receiptBttn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label scsuRest;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemComboText;
        private System.Windows.Forms.TextBox costItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picExit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.ComboBox priceCombo;
        private System.Windows.Forms.RichTextBox rtReceipt;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button maxBttn;
        private System.Windows.Forms.Button minBttn;
        private System.Windows.Forms.DataGridView dvgRestaurant;
        private System.Windows.Forms.Button bttnLaod;
        private System.Windows.Forms.Button abbBtn;
        private System.Windows.Forms.Button dgvClearBttn;
        private System.Windows.Forms.Button bttnTotal;
        private System.Windows.Forms.TextBox txtTotNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataVisualization.Charting.Chart itemChart;
        private System.Windows.Forms.ImageList imageList1;
    }
}

