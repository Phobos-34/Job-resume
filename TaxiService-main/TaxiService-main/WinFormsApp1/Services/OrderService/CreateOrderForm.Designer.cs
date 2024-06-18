namespace TaxiClient.Services.OrderService
{
    partial class CreateOrderForm
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
            ClientTextBox = new TextBox();
            CreateOrderBtn = new Button();
            DriverComboBox = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(700, 338);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(ClientTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(CreateOrderBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(DriverComboBox, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(254, 133);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Driver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Client";
            // 
            // ClientTextBox
            // 
            ClientTextBox.Location = new Point(130, 32);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.Size = new Size(121, 23);
            ClientTextBox.TabIndex = 3;
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.Location = new Point(3, 61);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Size = new Size(105, 23);
            CreateOrderBtn.TabIndex = 4;
            CreateOrderBtn.Text = "Create order";
            CreateOrderBtn.UseVisualStyleBackColor = true;
            CreateOrderBtn.Click += CreateOrderBtn_Click;
            // 
            // DriverComboBox
            // 
            DriverComboBox.FormattingEnabled = true;
            DriverComboBox.Location = new Point(130, 3);
            DriverComboBox.Name = "DriverComboBox";
            DriverComboBox.Size = new Size(121, 23);
            DriverComboBox.TabIndex = 5;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateOrderForm";
            Text = "CreateOrderForm";
            FormClosed += CreateOrderForm_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox ClientTextBox;
        private Button CreateOrderBtn;
        private ComboBox DriverComboBox;
    }
}