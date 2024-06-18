namespace TaxiClient.Services.CarService
{
    partial class EditCarForm
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
            label3 = new Label();
            SaveBtn = new Button();
            ColorComboBox = new ComboBox();
            ModelTextBox = new TextBox();
            VINTextBox = new TextBox();
            DebugText = new Label();
            RemoveBtn = new Button();
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
            flowLayoutPanel1.Size = new Size(800, 450);
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
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(SaveBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(ColorComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(ModelTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(VINTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(DebugText, 1, 3);
            tableLayoutPanel1.Controls.Add(RemoveBtn, 0, 4);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Size = new Size(254, 217);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "VIN";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(3, 98);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(130, 3);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(121, 23);
            ColorComboBox.TabIndex = 4;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(130, 32);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(121, 23);
            ModelTextBox.TabIndex = 5;
            // 
            // VINTextBox
            // 
            VINTextBox.Location = new Point(130, 61);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.Size = new Size(121, 23);
            VINTextBox.TabIndex = 6;
            VINTextBox.TextChanged += VINTextBox_TextChanged;
            // 
            // DebugText
            // 
            DebugText.AutoSize = true;
            DebugText.Location = new Point(130, 95);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(10, 15);
            DebugText.TabIndex = 7;
            DebugText.Text = " ";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(3, 130);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 8;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // EditCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "EditCarForm";
            Text = "EditCarForm";
            FormClosing += EditCarForm_FormClosing;
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
        private Label label3;
        private Button SaveBtn;
        private ComboBox ColorComboBox;
        private TextBox ModelTextBox;
        private TextBox VINTextBox;
        private Label DebugText;
        private Button RemoveBtn;
    }
}