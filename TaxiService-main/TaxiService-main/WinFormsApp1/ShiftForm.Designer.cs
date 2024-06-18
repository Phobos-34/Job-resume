namespace TaxiClient
{
    partial class ShiftForm
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
            DispatcherComboBox = new ComboBox();
            DriversListView = new ListView();
            ID = new ColumnHeader();
            DriverName = new ColumnHeader();
            SaveBtn = new Button();
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
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(DispatcherComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(DriversListView, 1, 1);
            tableLayoutPanel1.Controls.Add(SaveBtn, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.587677F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.41232F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(345, 264);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Диспетчер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Водители";
            // 
            // DispatcherComboBox
            // 
            DispatcherComboBox.FormattingEnabled = true;
            DispatcherComboBox.Location = new Point(175, 3);
            DispatcherComboBox.Name = "DispatcherComboBox";
            DispatcherComboBox.Size = new Size(121, 23);
            DispatcherComboBox.TabIndex = 2;
            // 
            // DriversListView
            // 
            DriversListView.Columns.AddRange(new ColumnHeader[] { ID, DriverName });
            DriversListView.Location = new Point(175, 40);
            DriversListView.Name = "DriversListView";
            DriversListView.Size = new Size(167, 184);
            DriversListView.TabIndex = 3;
            DriversListView.UseCompatibleStateImageBehavior = false;
            DriversListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // DriverName
            // 
            DriverName.Text = "Driver Name";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(3, 231);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(105, 23);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ShiftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flowLayoutPanel1);
            Name = "ShiftForm";
            Text = "ShiftForm";
            FormClosing += ShiftForm_FormClosing;
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
        private ComboBox DispatcherComboBox;
        private ListView DriversListView;
        private Button SaveBtn;
        private ColumnHeader ID;
        private ColumnHeader DriverName;
    }
}