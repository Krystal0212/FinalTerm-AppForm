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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
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
            this.bClear = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grd3 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.grd4 = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.Label();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).BeginInit();
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
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.cb2.Location = new System.Drawing.Point(73, 95);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(158, 23);
            this.cb2.TabIndex = 11;
            this.cb2.TextChanged += new System.EventHandler(this.cb2_TextChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(350, 94);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(91, 23);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
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
            this.label3.Location = new System.Drawing.Point(6, 137);
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
            this.cb1.Location = new System.Drawing.Point(73, 57);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(158, 23);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
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
            this.groupBox2.Size = new System.Drawing.Size(489, 339);
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
            this.grd1.Size = new System.Drawing.Size(477, 311);
            this.grd1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bClear);
            this.groupBox3.Controls.Add(this.bExport);
            this.groupBox3.Controls.Add(this.grd2);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recent added items";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(240, 167);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(123, 23);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear all stuffs";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(93, 167);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(123, 23);
            this.bExport.TabIndex = 8;
            this.bExport.Text = "Export your ticket";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(6, 22);
            this.grd2.Name = "grd2";
            this.grd2.RowTemplate.Height = 25;
            this.grd2.Size = new System.Drawing.Size(461, 139);
            this.grd2.TabIndex = 0;
            this.grd2.Click += new System.EventHandler(this.grd2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grd3);
            this.groupBox4.Location = new System.Drawing.Point(12, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 262);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your ticket";
            // 
            // grd3
            // 
            this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd3.Location = new System.Drawing.Point(6, 22);
            this.grd3.Name = "grd3";
            this.grd3.RowTemplate.Height = 25;
            this.grd3.Size = new System.Drawing.Size(461, 231);
            this.grd3.TabIndex = 0;
            this.grd3.Click += new System.EventHandler(this.grd3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(986, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 140);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delivery bill";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(986, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 155);
            this.button4.TabIndex = 10;
            this.button4.Text = "View reports";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketLabel);
            this.groupBox1.Controls.Add(this.grd4);
            this.groupBox1.Location = new System.Drawing.Point(491, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 303);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail ticket items";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ticketLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketLabel.Location = new System.Drawing.Point(264, 17);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(69, 21);
            this.ticketLabel.TabIndex = 1;
            this.ticketLabel.Text = "Ticket ID";
            // 
            // grd4
            // 
            this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd4.Location = new System.Drawing.Point(6, 41);
            this.grd4.Name = "grd4";
            this.grd4.RowTemplate.Height = 25;
            this.grd4.Size = new System.Drawing.Size(606, 253);
            this.grd4.TabIndex = 0;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(986, 12);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(81, 21);
            this.user.TabIndex = 12;
            this.user.Text = "Username";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1123, 663);
            this.Controls.Add(this.user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.button5);
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
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button bClear;
        private Button bExport;
        private DataGridView grd2;
        private GroupBox groupBox4;
        private DataGridView grd3;
        private Button button5;
        private Button button4;
        private Button bSave;
        private Button bEdit;
        private Button bDelete;
        private ComboBox cb2;
        private TextBox txtGoodID;
        private Label label4;
        private Button bCancel;
        private GroupBox groupBox1;
        private DataGridView grd4;
        private Label user;
        private Label ticketLabel;
    }
}