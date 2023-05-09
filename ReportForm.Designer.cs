namespace FormApp
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOut = new System.Windows.Forms.ComboBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderIDlabel = new System.Windows.Forms.Label();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIn = new System.Windows.Forms.ComboBox();
            this.grd3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRevenue = new System.Windows.Forms.ComboBox();
            this.grd4 = new System.Windows.Forms.DataGridView();
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
            this.grp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbOut);
            this.groupBox1.Controls.Add(this.grd1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outgoing stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month";
            // 
            // cbOut
            // 
            this.cbOut.FormattingEnabled = true;
            this.cbOut.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbOut.Location = new System.Drawing.Point(329, 20);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(121, 23);
            this.cbOut.TabIndex = 1;
            this.cbOut.TextChanged += new System.EventHandler(this.cbOut_TextChanged);
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(6, 49);
            this.grd1.Name = "grd1";
            this.grd1.RowTemplate.Height = 25;
            this.grd1.Size = new System.Drawing.Size(511, 180);
            this.grd1.TabIndex = 0;
            this.grd1.Click += new System.EventHandler(this.grd1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderIDlabel);
            this.groupBox2.Controls.Add(this.grd2);
            this.groupBox2.Location = new System.Drawing.Point(541, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 235);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail outgoing stock";
            // 
            // OrderIDlabel
            // 
            this.OrderIDlabel.AutoSize = true;
            this.OrderIDlabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderIDlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderIDlabel.Location = new System.Drawing.Point(174, 25);
            this.OrderIDlabel.Name = "OrderIDlabel";
            this.OrderIDlabel.Size = new System.Drawing.Size(52, 21);
            this.OrderIDlabel.TabIndex = 4;
            this.OrderIDlabel.Text = "label3";
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(6, 49);
            this.grd2.Name = "grd2";
            this.grd2.RowTemplate.Height = 25;
            this.grd2.Size = new System.Drawing.Size(409, 180);
            this.grd2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbIn);
            this.groupBox3.Controls.Add(this.grd3);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 235);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Incoming stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month";
            // 
            // cbIn
            // 
            this.cbIn.FormattingEnabled = true;
            this.cbIn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbIn.Location = new System.Drawing.Point(329, 20);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(121, 23);
            this.cbIn.TabIndex = 1;
            this.cbIn.TextChanged += new System.EventHandler(this.cbIn_TextChanged);
            // 
            // grd3
            // 
            this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd3.Location = new System.Drawing.Point(6, 49);
            this.grd3.Name = "grd3";
            this.grd3.RowTemplate.Height = 25;
            this.grd3.Size = new System.Drawing.Size(511, 180);
            this.grd3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 143);
            this.button1.TabIndex = 3;
            this.button1.Text = "Best-selling products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp4
            // 
            this.grp4.Controls.Add(this.label3);
            this.grp4.Controls.Add(this.cbRevenue);
            this.grp4.Controls.Add(this.grd4);
            this.grp4.Location = new System.Drawing.Point(541, 253);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(523, 235);
            this.grp4.TabIndex = 5;
            this.grp4.TabStop = false;
            this.grp4.Text = "Revenue monthly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Month";
            // 
            // cbRevenue
            // 
            this.cbRevenue.FormattingEnabled = true;
            this.cbRevenue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbRevenue.Location = new System.Drawing.Point(329, 20);
            this.cbRevenue.Name = "cbRevenue";
            this.cbRevenue.Size = new System.Drawing.Size(121, 23);
            this.cbRevenue.TabIndex = 1;
            this.cbRevenue.TextChanged += new System.EventHandler(this.cbRevenue_TextChanged);
            // 
            // grd4
            // 
            this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd4.Location = new System.Drawing.Point(6, 49);
            this.grd4.Name = "grd4";
            this.grd4.RowTemplate.Height = 25;
            this.grd4.Size = new System.Drawing.Size(511, 180);
            this.grd4.TabIndex = 0;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(968, 161);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(133, 80);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "Back to main";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 492);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.grp4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
            this.grp4.ResumeLayout(false);
            this.grp4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grd1;
        private Label label1;
        private ComboBox cbOut;
        private GroupBox groupBox2;
        private DataGridView grd2;
        private GroupBox groupBox3;
        private Label label2;
        private ComboBox cbIn;
        private DataGridView grd3;
        private Label OrderIDlabel;
        private Button button1;
        private GroupBox grp4;
        private Label label3;
        private ComboBox cbRevenue;
        private DataGridView grd4;
        private Button bBack;
    }
}