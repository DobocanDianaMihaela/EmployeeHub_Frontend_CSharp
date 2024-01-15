namespace WindowsForm
{
    partial class Form2
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
            btnInsert = new Button();
            textBoxDeleteId = new TextBox();
            label12 = new Label();
            textBoxUpdDesc = new TextBox();
            textBoxUpdManagId = new TextBox();
            textBoxupdParentId = new TextBox();
            textBoxUpdId = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxInsDescript = new TextBox();
            textBoxInsManagerId = new TextBox();
            textBoxInsParentId = new TextBox();
            deleteBtn = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(80, 209);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(164, 34);
            btnInsert.TabIndex = 50;
            btnInsert.Text = "Insert Department";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(257, 457);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(53, 31);
            textBoxDeleteId.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(267, 429);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 48;
            label12.Text = "Id:";
            // 
            // textBoxUpdDesc
            // 
            textBoxUpdDesc.Location = new Point(349, 343);
            textBoxUpdDesc.Name = "textBoxUpdDesc";
            textBoxUpdDesc.Size = new Size(113, 31);
            textBoxUpdDesc.TabIndex = 47;
            // 
            // textBoxUpdManagId
            // 
            textBoxUpdManagId.Location = new Point(513, 343);
            textBoxUpdManagId.Name = "textBoxUpdManagId";
            textBoxUpdManagId.Size = new Size(126, 31);
            textBoxUpdManagId.TabIndex = 46;
            // 
            // textBoxupdParentId
            // 
            textBoxupdParentId.Location = new Point(706, 343);
            textBoxupdParentId.Name = "textBoxupdParentId";
            textBoxupdParentId.Size = new Size(119, 31);
            textBoxupdParentId.TabIndex = 45;
            // 
            // textBoxUpdId
            // 
            textBoxUpdId.Location = new Point(257, 343);
            textBoxUpdId.Name = "textBoxUpdId";
            textBoxUpdId.Size = new Size(53, 31);
            textBoxUpdId.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(358, 301);
            label11.Name = "label11";
            label11.Size = new Size(104, 25);
            label11.TabIndex = 43;
            label11.Text = "description:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 301);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 42;
            label9.Text = "managerId:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(729, 301);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 41;
            label8.Text = "parentId:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 301);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 40;
            label7.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 170);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 39;
            label6.Text = "description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 170);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 38;
            label4.Text = "managerId:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(729, 170);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 37;
            label3.Text = "parentId:";
            // 
            // textBoxInsDescript
            // 
            textBoxInsDescript.Location = new Point(349, 209);
            textBoxInsDescript.Name = "textBoxInsDescript";
            textBoxInsDescript.Size = new Size(113, 31);
            textBoxInsDescript.TabIndex = 36;
            // 
            // textBoxInsManagerId
            // 
            textBoxInsManagerId.Location = new Point(513, 209);
            textBoxInsManagerId.Name = "textBoxInsManagerId";
            textBoxInsManagerId.Size = new Size(126, 31);
            textBoxInsManagerId.TabIndex = 35;
            // 
            // textBoxInsParentId
            // 
            textBoxInsParentId.Location = new Point(706, 212);
            textBoxInsParentId.Name = "textBoxInsParentId";
            textBoxInsParentId.Size = new Size(119, 31);
            textBoxInsParentId.TabIndex = 34;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(52, 449);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(183, 34);
            deleteBtn.TabIndex = 33;
            deleteBtn.Text = "Delete Department";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(52, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 34);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update Department";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(454, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 31;
            label1.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(411, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(89, 51);
            button1.Name = "button1";
            button1.Size = new Size(155, 34);
            button1.TabIndex = 29;
            button1.Text = "Load Department";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(895, 511);
            Controls.Add(btnInsert);
            Controls.Add(textBoxDeleteId);
            Controls.Add(label12);
            Controls.Add(textBoxUpdDesc);
            Controls.Add(textBoxUpdManagId);
            Controls.Add(textBoxupdParentId);
            Controls.Add(textBoxUpdId);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxInsDescript);
            Controls.Add(textBoxInsManagerId);
            Controls.Add(textBoxInsParentId);
            Controls.Add(deleteBtn);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private TextBox textBoxDeleteId;
        private Label label12;
        private TextBox textBoxUpdDesc;
        private TextBox textBoxUpdManagId;
        private TextBox textBoxupdParentId;
        private TextBox textBoxUpdId;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBoxInsDescript;
        private TextBox textBoxInsManagerId;
        private TextBox textBoxInsParentId;
        private Button deleteBtn;
        private Button btnUpdate;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}