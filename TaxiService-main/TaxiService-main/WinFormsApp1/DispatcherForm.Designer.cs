namespace TaxiClient
{
    partial class DispatcherForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            LoginText = new Label();
            RoleText = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            CreateOrderBtn = new Button();
            OrderListView = new ListView();
            Driver = new ColumnHeader();
            Client = new ColumnHeader();
            Satisfaction = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(OrderListView, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(700, 338);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(344, 332);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(LoginText, 1, 0);
            tableLayoutPanel2.Controls.Add(RoleText, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
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
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Роль";
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Location = new Point(103, 0);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(58, 15);
            LoginText.TabIndex = 2;
            LoginText.Text = "LoginText";
            // 
            // RoleText
            // 
            RoleText.AutoSize = true;
            RoleText.Location = new Point(103, 50);
            RoleText.Name = "RoleText";
            RoleText.Size = new Size(51, 15);
            RoleText.TabIndex = 3;
            RoleText.Text = "RoleText";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(CreateOrderBtn);
            flowLayoutPanel2.Location = new Point(3, 109);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 100);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.Location = new Point(3, 3);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Size = new Size(105, 23);
            CreateOrderBtn.TabIndex = 0;
            CreateOrderBtn.Text = "Create order";
            CreateOrderBtn.UseVisualStyleBackColor = true;
            CreateOrderBtn.Click += CreateOrderBtn_Click;
            // 
            // OrderListView
            // 
            OrderListView.Columns.AddRange(new ColumnHeader[] { Driver, Client, Satisfaction });
            OrderListView.Location = new Point(353, 3);
            OrderListView.Name = "OrderListView";
            OrderListView.Size = new Size(344, 192);
            OrderListView.TabIndex = 1;
            OrderListView.UseCompatibleStateImageBehavior = false;
            OrderListView.View = View.Details;
            // 
            // Driver
            // 
            Driver.Text = "Driver";
            // 
            // Client
            // 
            Client.Text = "Client";
            // 
            // Satisfaction
            // 
            Satisfaction.Text = "Satisfaction";
            // 
            // DispatcherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Name = "DispatcherForm";
            Text = "DispatcherForm";
            Activated += DispatcherForm_Activated;
            FormClosing += DispatcherForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label LoginText;
        private Label RoleText;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button CreateOrderBtn;
        private ListView OrderListView;
        private ColumnHeader Driver;
        private ColumnHeader Client;
        private ColumnHeader Satisfaction;
    }
}