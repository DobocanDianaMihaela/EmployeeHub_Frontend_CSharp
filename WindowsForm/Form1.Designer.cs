namespace WindowsForm
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnUpdate = new Button();
            deleteBtn = new Button();
            textBoxInsDepId = new TextBox();
            textBoxInsEmail = new TextBox();
            textBoxInsName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            textBoxUpdId = new TextBox();
            textBoxupdDepId = new TextBox();
            textBoxUpdEmail = new TextBox();
            textBoxUpdName = new TextBox();
            label12 = new Label();
            textBoxDeleteId = new TextBox();
            btnInsert = new Button();
            checkBoxIsManager = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(11, 26);
            button1.Name = "button1";
            button1.Size = new Size(154, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(342, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(385, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 2;
            label1.Text = "Employees";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(-5, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Employee";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(11, 426);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(155, 34);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete Employee";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // textBoxInsDepId
            // 
            textBoxInsDepId.Location = new Point(303, 189);
            textBoxInsDepId.Name = "textBoxInsDepId";
            textBoxInsDepId.Size = new Size(119, 31);
            textBoxInsDepId.TabIndex = 7;
            // 
            // textBoxInsEmail
            // 
            textBoxInsEmail.Location = new Point(631, 189);
            textBoxInsEmail.Name = "textBoxInsEmail";
            textBoxInsEmail.Size = new Size(126, 31);
            textBoxInsEmail.TabIndex = 8;
            // 
            // textBoxInsName
            // 
            textBoxInsName.Location = new Point(457, 189);
            textBoxInsName.Name = "textBoxInsName";
            textBoxInsName.Size = new Size(113, 31);
            textBoxInsName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 147);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 12;
            label3.Text = "departmentId:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 147);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 13;
            label4.Text = "email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 147);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 15;
            label6.Text = "name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 278);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 16;
            label7.Text = "Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 278);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 17;
            label8.Text = "departmentId:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(664, 278);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 18;
            label9.Text = "email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(487, 278);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 20;
            label11.Text = "name:";
            // 
            // textBoxUpdId
            // 
            textBoxUpdId.Location = new Point(198, 319);
            textBoxUpdId.Name = "textBoxUpdId";
            textBoxUpdId.Size = new Size(53, 31);
            textBoxUpdId.TabIndex = 21;
            // 
            // textBoxupdDepId
            // 
            textBoxupdDepId.Location = new Point(303, 320);
            textBoxupdDepId.Name = "textBoxupdDepId";
            textBoxupdDepId.Size = new Size(119, 31);
            textBoxupdDepId.TabIndex = 22;
            // 
            // textBoxUpdEmail
            // 
            textBoxUpdEmail.Location = new Point(631, 322);
            textBoxUpdEmail.Name = "textBoxUpdEmail";
            textBoxUpdEmail.Size = new Size(126, 31);
            textBoxUpdEmail.TabIndex = 23;
            // 
            // textBoxUpdName
            // 
            textBoxUpdName.Location = new Point(457, 320);
            textBoxUpdName.Name = "textBoxUpdName";
            textBoxUpdName.Size = new Size(113, 31);
            textBoxUpdName.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(198, 406);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 26;
            label12.Text = "Id:";
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(188, 434);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(53, 31);
            textBoxDeleteId.TabIndex = 27;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(11, 186);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(154, 34);
            btnInsert.TabIndex = 28;
            btnInsert.Text = "Insert Employee";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // checkBoxIsManager
            // 
            checkBoxIsManager.AutoSize = true;
            checkBoxIsManager.Location = new Point(171, 188);
            checkBoxIsManager.Name = "checkBoxIsManager";
            checkBoxIsManager.Size = new Size(108, 29);
            checkBoxIsManager.TabIndex = 29;
            checkBoxIsManager.Text = "Manager";
            checkBoxIsManager.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(864, 498);
            Controls.Add(checkBoxIsManager);
            Controls.Add(btnInsert);
            Controls.Add(textBoxDeleteId);
            Controls.Add(label12);
            Controls.Add(textBoxUpdName);
            Controls.Add(textBoxUpdEmail);
            Controls.Add(textBoxupdDepId);
            Controls.Add(textBoxUpdId);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxInsName);
            Controls.Add(textBoxInsEmail);
            Controls.Add(textBoxInsDepId);
            Controls.Add(deleteBtn);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnUpdate;
        private Button deleteBtn;
        private TextBox textBoxInsDepId;
        private TextBox textBoxInsEmail;
        private TextBox textBoxInsName;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox textBoxUpdId;
        private TextBox textBoxupdDepId;
        private TextBox textBoxUpdEmail;
        private TextBox textBoxUpdName;
        private Label label12;
        private TextBox textBoxDeleteId;
        private Button btnInsert;
        private CheckBox checkBoxIsManager;
    }
}