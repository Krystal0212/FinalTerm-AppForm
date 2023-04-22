namespace FormApp
{
    partial class AdminForm
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.txtGoodID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.bCancel);
            this.grp1.Controls.Add(this.txtGoodID);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.cb2);
            this.grp1.Controls.Add(this.bSave);
            this.grp1.Controls.Add(this.bEdit);
            this.grp1.Controls.Add(this.bDelete);
            this.grp1.Controls.Add(this.bAdd);
            this.grp1.Controls.Add(this.dtp);
            this.grp1.Controls.Add(this.txtTotalprice);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.cb1);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Location = new System.Drawing.Point(12, 12);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(473, 178);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "Import goods";
            // 
            // txtGoodID
            // 
            this.txtGoodID.Location = new System.Drawing.Point(73, 22);
            this.txtGoodID.Name = "txtGoodID";
            this.txtGoodID.Size = new System.Drawing.Size(158, 23);
            this.txtGoodID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Good ID";
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cb2.Location = new System.Drawing.Point(73, 95);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(158, 23);
            this.cb2.TabIndex = 11;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(350, 94);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(91, 23);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(253, 94);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(81, 23);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(350, 56);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(91, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(253, 56);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(81, 23);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(253, 22);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 23);
            this.dtp.TabIndex = 6;
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Location = new System.Drawing.Point(73, 134);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(158, 23);
            this.txtTotalprice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Samsung Galaxy s23",
            "Ipad Pro 2018"});
            this.cb1.Location = new System.Drawing.Point(73, 57);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(158, 23);
            this.cb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd1);
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current goods in stock";
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(6, 22);
            this.grd1.Name = "grd1";
            this.grd1.RowTemplate.Height = 25;
            this.grd1.Size = new System.Drawing.Size(477, 431);
            this.grd1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.grd2);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recent added items";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear all stuffs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Export your ticket";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(6, 22);
            this.grd2.Name = "grd2";
            this.grd2.RowTemplate.Height = 25;
            this.grd2.Size = new System.Drawing.Size(461, 90);
            this.grd2.TabIndex = 0;
            this.grd2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd2_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 262);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your ticket";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(461, 231);
            this.dataGridView2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(577, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delivery bill";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(748, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "View reports";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(298, 133);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(91, 23);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp1);
            this.Name = "AdminForm";
            this.Text = "Staff Use";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp1;
        private Label label1;
        private DateTimePicker dtp;
        private TextBox txtTotalprice;
        private Label label3;
        private Label label2;
        private ComboBox cb1;
        private GroupBox groupBox2;
        private DataGridView grd1;
        private Button bAdd;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private DataGridView grd2;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private Button button5;
        private Button button4;
        private Button bSave;
        private Button bEdit;
        private Button bDelete;
        private ComboBox cb2;
        private TextBox txtGoodID;
        private Label label4;
        private Button bCancel;
    }
}