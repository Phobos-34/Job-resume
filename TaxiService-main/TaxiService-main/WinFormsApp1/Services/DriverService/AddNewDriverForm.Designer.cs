namespace TaxiClient
{
    partial class AddNewDriverForm
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            AddDriverBtn = new Button();
            label2 = new Label();
            NameTextBox = new TextBox();
            IDTextBox = new TextBox();
            DebugText = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(AddDriverBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(IDTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(DebugText, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tableLayoutPanel1.Size = new Size(214, 210);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // AddDriverBtn
            // 
            AddDriverBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddDriverBtn.Location = new Point(3, 61);
            AddDriverBtn.Name = "AddDriverBtn";
            AddDriverBtn.Size = new Size(101, 28);
            AddDriverBtn.TabIndex = 4;
            AddDriverBtn.Text = "Add Driver";
            AddDriverBtn.UseVisualStyleBackColor = true;
            AddDriverBtn.Click += AddDriverBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(110, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 2;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(110, 32);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 3;
            // 
            // DebugText
            // 
            DebugText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DebugText.AutoSize = true;
            DebugText.Location = new Point(110, 58);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(101, 15);
            DebugText.TabIndex = 5;
            DebugText.Text = "Debug Text";
            // 
            // AddNewDriverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Name = "AddNewDriverForm";
            Text = "AddNewDriverForm";
            FormClosing += AddNewDriverForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox NameTextBox;
        private TextBox IDTextBox;
        private Button AddDriverBtn;
        private Label DebugText;
    }
}