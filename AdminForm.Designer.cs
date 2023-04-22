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
            grp1 = new GroupBox();
            bCancel = new Button();
            txtGoodID = new TextBox();
            label4 = new Label();
            cb2 = new ComboBox();
            bSave = new Button();
            bEdit = new Button();
            bDelete = new Button();
            bAdd = new Button();
            dtp = new DateTimePicker();
            txtTotalprice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cb1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            grd1 = new DataGridView();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            grd2 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            grp1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(bCancel);
            grp1.Controls.Add(txtGoodID);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(cb2);
            grp1.Controls.Add(bSave);
            grp1.Controls.Add(bEdit);
            grp1.Controls.Add(bDelete);
            grp1.Controls.Add(bAdd);
            grp1.Controls.Add(dtp);
            grp1.Controls.Add(txtTotalprice);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(cb1);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(12, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(473, 178);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Import goods";
            // 
            // bCancel
            // 
            bCancel.Location = new Point(298, 133);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(91, 23);
            bCancel.TabIndex = 14;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // txtGoodID
            // 
            txtGoodID.Location = new Point(73, 22);
            txtGoodID.Name = "txtGoodID";
            txtGoodID.Size = new Size(158, 23);
            txtGoodID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "Good ID";
            // 
            // cb2
            // 
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30" });
            cb2.Location = new Point(73, 95);
            cb2.Name = "cb2";
            cb2.Size = new Size(158, 23);
            cb2.TabIndex = 11;
            cb2.TextChanged += cb2_TextChanged;
            // 
            // bSave
            // 
            bSave.Location = new Point(350, 94);
            bSave.Name = "bSave";
            bSave.Size = new Size(91, 23);
            bSave.TabIndex = 10;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(253, 94);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(81, 23);
            bEdit.TabIndex = 9;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(350, 56);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(91, 23);
            bDelete.TabIndex = 8;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(253, 56);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(81, 23);
            bAdd.TabIndex = 7;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // dtp
            // 
            dtp.Location = new Point(253, 22);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 6;
            // 
            // txtTotalprice
            // 
            txtTotalprice.Location = new Point(73, 134);
            txtTotalprice.Name = "txtTotalprice";
            txtTotalprice.Size = new Size(158, 23);
            txtTotalprice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 137);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Total Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(73, 57);
            cb1.Name = "cb1";
            cb1.Size = new Size(158, 23);
            cb1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Goods";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd1);
            groupBox2.Location = new Point(491, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 459);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current goods in stock";
            // 
            // grd1
            // 
            grd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd1.Location = new Point(6, 22);
            grd1.Name = "grd1";
            grd1.RowTemplate.Height = 25;
            grd1.Size = new Size(477, 431);
            grd1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(grd2);
            groupBox3.Location = new Point(12, 196);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 196);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Recent added items";
            // 
            // button3
            // 
            button3.Location = new Point(240, 167);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 9;
            button3.Text = "Clear all stuffs";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 167);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 8;
            button2.Text = "Export your ticket";
            button2.UseVisualStyleBackColor = true;
            // 
            // grd2
            // 
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(6, 22);
            grd2.Name = "grd2";
            grd2.RowTemplate.Height = 25;
            grd2.Size = new Size(461, 139);
            grd2.TabIndex = 0;
            grd2.Click += grd2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(12, 398);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(473, 262);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Your ticket";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(461, 231);
            dataGridView2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(577, 506);
            button5.Name = "button5";
            button5.Size = new Size(123, 23);
            button5.TabIndex = 9;
            button5.Text = "Delivery bill";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(748, 506);
            button4.Name = "button4";
            button4.Size = new Size(123, 23);
            button4.TabIndex = 10;
            button4.Text = "View reports";
            button4.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(992, 655);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "AdminForm";
            Text = "Staff Use";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
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