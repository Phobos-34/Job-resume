namespace TaxiClient
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            LoginText = new Label();
            UserTypeText = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            UserServiceBtn = new Button();
            DriverServiceBtn = new Button();
            CarServiceBtn = new Button();
            ShiftBtn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            DispatcherLabel = new Label();
            DriverListView = new ListView();
            ID = new ColumnHeader();
            DriverName = new ColumnHeader();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 2);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(344, 334);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginText, 1, 0);
            tableLayoutPanel1.Controls.Add(UserTypeText, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(219, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Роль";
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Location = new Point(112, 0);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(58, 15);
            LoginText.TabIndex = 2;
            LoginText.Text = "LoginText";
            // 
            // UserTypeText
            // 
            UserTypeText.AutoSize = true;
            UserTypeText.Location = new Point(112, 15);
            UserTypeText.Name = "UserTypeText";
            UserTypeText.Size = new Size(75, 15);
            UserTypeText.TabIndex = 3;
            UserTypeText.Text = "UserTypeText";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(UserServiceBtn);
            flowLayoutPanel2.Controls.Add(DriverServiceBtn);
            flowLayoutPanel2.Controls.Add(CarServiceBtn);
            flowLayoutPanel2.Controls.Add(ShiftBtn);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 101);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(219, 116);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // UserServiceBtn
            // 
            UserServiceBtn.Location = new Point(3, 3);
            UserServiceBtn.Name = "UserServiceBtn";
            UserServiceBtn.Size = new Size(105, 23);
            UserServiceBtn.TabIndex = 0;
            UserServiceBtn.Text = "User Service";
            UserServiceBtn.UseVisualStyleBackColor = true;
            UserServiceBtn.Click += UserServiceBtn_Click;
            // 
            // DriverServiceBtn
            // 
            DriverServiceBtn.Location = new Point(3, 32);
            DriverServiceBtn.Name = "DriverServiceBtn";
            DriverServiceBtn.Size = new Size(105, 23);
            DriverServiceBtn.TabIndex = 1;
            DriverServiceBtn.Text = "Driver Service";
            DriverServiceBtn.UseVisualStyleBackColor = true;
            DriverServiceBtn.Click += DriverServiceBtn_Click;
            // 
            // CarServiceBtn
            // 
            CarServiceBtn.Location = new Point(3, 61);
            CarServiceBtn.Name = "CarServiceBtn";
            CarServiceBtn.Size = new Size(105, 23);
            CarServiceBtn.TabIndex = 2;
            CarServiceBtn.Text = "Car Service";
            CarServiceBtn.UseVisualStyleBackColor = true;
            CarServiceBtn.Click += CarServiceBtn_Click;
            // 
            // ShiftBtn
            // 
            ShiftBtn.Location = new Point(3, 90);
            ShiftBtn.Name = "ShiftBtn";
            ShiftBtn.Size = new Size(105, 23);
            ShiftBtn.TabIndex = 3;
            ShiftBtn.Text = "Shift";
            ShiftBtn.UseVisualStyleBackColor = true;
            ShiftBtn.Click += ShiftBtn_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(700, 338);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.24756F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.75244F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(DispatcherLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(DriverListView, 1, 1);
            tableLayoutPanel3.Location = new Point(390, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(307, 216);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Диспетчер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 1;
            label4.Text = "Водители";
            // 
            // DispatcherLabel
            // 
            DispatcherLabel.AutoSize = true;
            DispatcherLabel.Location = new Point(102, 0);
            DispatcherLabel.Name = "DispatcherLabel";
            DispatcherLabel.Size = new Size(29, 15);
            DispatcherLabel.TabIndex = 2;
            DispatcherLabel.Text = "Null";
            // 
            // DriverListView
            // 
            DriverListView.Columns.AddRange(new ColumnHeader[] { ID, DriverName });
            DriverListView.Location = new Point(102, 111);
            DriverListView.Name = "DriverListView";
            DriverListView.Size = new Size(196, 102);
            DriverListView.TabIndex = 3;
            DriverListView.UseCompatibleStateImageBehavior = false;
            DriverListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // DriverName
            // 
            DriverName.Text = "Driver Name";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "AdminForm";
            Activated += AdminForm_Activated;
            FormClosing += AdminForm_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label LoginText;
        private Label UserTypeText;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button UserServiceBtn;
        private Button DriverServiceBtn;
        private Button CarServiceBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label DispatcherLabel;
        private Button ShiftBtn;
        private ListView DriverListView;
        private ColumnHeader ID;
        private ColumnHeader DriverName;
    }
}