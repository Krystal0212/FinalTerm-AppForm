namespace FormApp
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.grd3 = new System.Windows.Forms.DataGridView();
            this.bPrint = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.bAccept = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.grd1);
            this.grp1.Location = new System.Drawing.Point(7, 12);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(1055, 309);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "Order List";
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(6, 22);
            this.grd1.Name = "grd1";
            this.grd1.RowTemplate.Height = 25;
            this.grd1.Size = new System.Drawing.Size(1045, 281);
            this.grd1.TabIndex = 1;
            this.grd1.Click += new System.EventHandler(this.grd1_Click);
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.grd3);
            this.grp3.Location = new System.Drawing.Point(473, 327);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(589, 238);
            this.grp3.TabIndex = 2;
            this.grp3.TabStop = false;
            this.grp3.Text = "Succesful Order";
            // 
            // grd3
            // 
            this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd3.Location = new System.Drawing.Point(6, 22);
            this.grd3.Name = "grd3";
            this.grd3.RowTemplate.Height = 25;
            this.grd3.Size = new System.Drawing.Size(577, 210);
            this.grd3.TabIndex = 0;
            this.grd3.Click += new System.EventHandler(this.grd3_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(1063, 377);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(115, 34);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(1064, 68);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(114, 34);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd2);
            this.groupBox1.Location = new System.Drawing.Point(7, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(6, 22);
            this.grd2.Name = "grd2";
            this.grd2.RowTemplate.Height = 25;
            this.grd2.Size = new System.Drawing.Size(448, 210);
            this.grd2.TabIndex = 0;
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(1065, 108);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(114, 34);
            this.bAccept.TabIndex = 6;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(1064, 39);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(114, 23);
            this.txtOrderID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Order ID";
            // 
            // cbOrderID
            // 
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(1065, 349);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(112, 23);
            this.cbOrderID.TabIndex = 9;
            this.cbOrderID.TextChanged += new System.EventHandler(this.cbOrderID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Order ID";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(1065, 148);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(114, 34);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(1065, 188);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(114, 34);
            this.bRefresh.TabIndex = 12;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(1065, 461);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(114, 70);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "Back to main";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 568);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.grp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grp1;
        private DataGridView grd1;
        private GroupBox grp3;
        private DataGridView grd3;
        private Button bPrint;
        private Button bDelete;
        private GroupBox groupBox1;
        private DataGridView grd2;
        private Button bAccept;
        private TextBox txtOrderID;
        private Label label1;
        private ComboBox cbOrderID;
        private Label label2;
        private Button bCancel;
        private Button bRefresh;
        private Button bBack;
    }
}