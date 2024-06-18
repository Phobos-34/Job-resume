namespace TaxiClient
{
    partial class AddNewUserForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            UserTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            AddUserBtn = new Button();
            DebugText = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 451);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(UserTypeComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(LoginTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(AddUserBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(DebugText, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(250, 191);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 33);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // UserTypeComboBox
            // 
            UserTypeComboBox.FormattingEnabled = true;
            UserTypeComboBox.Location = new Point(128, 69);
            UserTypeComboBox.Name = "UserTypeComboBox";
            UserTypeComboBox.Size = new Size(118, 28);
            UserTypeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(119, 33);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(119, 34);
            label3.TabIndex = 2;
            label3.Text = "UserType";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(128, 3);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(118, 27);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(128, 36);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(118, 27);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(3, 103);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(94, 29);
            AddUserBtn.TabIndex = 5;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // DebugText
            // 
            DebugText.AutoSize = true;
            DebugText.Location = new Point(128, 100);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(81, 20);
            DebugText.TabIndex = 6;
            DebugText.Text = "DebugText";
            // 
            // AddNewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(flowLayoutPanel1);
            Name = "AddNewUserForm";
            Text = "AddNewUserForm";
            FormClosing += AddNewUserForm_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox UserTypeComboBox;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button AddUserBtn;
        private Label DebugText;
    }
}