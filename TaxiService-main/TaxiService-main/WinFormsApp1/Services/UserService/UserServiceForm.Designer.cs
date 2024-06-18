namespace TaxiClient
{
    partial class UserServiceForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            AddUserBtn = new Button();
            UserListView = new ListView();
            ID = new ColumnHeader();
            Login = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AddUserBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(UserListView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.88889F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Anchor = AnchorStyles.None;
            AddUserBtn.Location = new Point(341, 385);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(117, 36);
            AddUserBtn.TabIndex = 0;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // UserListView
            // 
            UserListView.Columns.AddRange(new ColumnHeader[] { ID, Login });
            UserListView.Dock = DockStyle.Fill;
            UserListView.Location = new Point(3, 3);
            UserListView.Name = "UserListView";
            UserListView.Size = new Size(794, 350);
            UserListView.TabIndex = 1;
            UserListView.UseCompatibleStateImageBehavior = false;
            UserListView.View = View.Details;
            UserListView.SelectedIndexChanged += UserListView_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Login
            // 
            Login.Text = "Login";
            // 
            // UserServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "UserServiceForm";
            Text = "UserServiceForm";
            Activated += UserServiceForm_Activated;
            FormClosing += UserServiceForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button AddUserBtn;
        private ListView UserListView;
        private ColumnHeader ID;
        private ColumnHeader Login;
    }
}