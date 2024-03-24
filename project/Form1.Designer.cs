namespace project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbxName = new TextBox();
            tbxCategory = new TextBox();
            label3 = new Label();
            tbxAmount = new TextBox();
            label4 = new Label();
            btnTest = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnTotal = new Button();
            btnDelete = new Button();
            dgvStudentInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 24);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 0;
            label1.Text = "Personal Expense Tracker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 114);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 1;
            label2.Text = "Income Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(188, 109);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(136, 23);
            tbxName.TabIndex = 2;
            // 
            // tbxCategory
            // 
            tbxCategory.Location = new Point(188, 150);
            tbxCategory.Name = "tbxCategory";
            tbxCategory.Size = new Size(136, 23);
            tbxCategory.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(188, 190);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(136, 23);
            tbxAmount.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 195);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 5;
            label4.Text = "Amount:";
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.DarkSeaGreen;
            btnTest.Location = new Point(137, 420);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(86, 36);
            btnTest.TabIndex = 7;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkSeaGreen;
            btnLoad.Location = new Point(27, 420);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(85, 36);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(27, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 33);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSeaGreen;
            btnUpdate.Location = new Point(137, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.DarkSeaGreen;
            btnTotal.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotal.Location = new Point(83, 230);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(175, 39);
            btnTotal.TabIndex = 11;
            btnTotal.Text = "Total Amount";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSeaGreen;
            btnDelete.Location = new Point(249, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(408, 109);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvStudentInfo.RowTemplate.Height = 25;
            dgvStudentInfo.Size = new Size(395, 347);
            dgvStudentInfo.TabIndex = 13;
            dgvStudentInfo.CellContentClick += dgvStudentInfo_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(929, 622);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnDelete);
            Controls.Add(btnTotal);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(btnTest);
            Controls.Add(tbxAmount);
            Controls.Add(label4);
            Controls.Add(tbxCategory);
            Controls.Add(label3);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxName;
        private TextBox tbxCategory;
        private Label label3;
        private TextBox tbxAmount;
        private Label label4;
        private Button btnTest;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnTotal;
        private Button btnDelete;
        private DataGridView dgvStudentInfo;
        private DataGridViewCellEventHandler dgvStudentInfo_CellContentClick;
    }
}