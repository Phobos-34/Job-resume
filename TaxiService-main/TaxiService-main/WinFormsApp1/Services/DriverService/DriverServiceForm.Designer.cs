namespace TaxiClient
{
    partial class DriverServiceForm
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
            DriverListView = new ListView();
            ID = new ColumnHeader();
            DriverName = new ColumnHeader();
            AddDriverBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DriverListView, 0, 0);
            tableLayoutPanel1.Controls.Add(AddDriverBtn, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DriverListView
            // 
            DriverListView.Columns.AddRange(new ColumnHeader[] { ID, DriverName });
            DriverListView.Dock = DockStyle.Fill;
            DriverListView.Location = new Point(3, 3);
            DriverListView.Name = "DriverListView";
            DriverListView.Size = new Size(794, 350);
            DriverListView.TabIndex = 0;
            DriverListView.UseCompatibleStateImageBehavior = false;
            DriverListView.View = View.Details;
            DriverListView.SelectedIndexChanged += DriverListView_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // DriverName
            // 
            DriverName.Text = "Driver Name";
            // 
            // AddDriverBtn
            // 
            AddDriverBtn.Anchor = AnchorStyles.None;
            AddDriverBtn.Location = new Point(341, 385);
            AddDriverBtn.Name = "AddDriverBtn";
            AddDriverBtn.Size = new Size(117, 36);
            AddDriverBtn.TabIndex = 1;
            AddDriverBtn.Text = "Add Driver";
            AddDriverBtn.UseVisualStyleBackColor = true;
            AddDriverBtn.Click += AddDriverBtn_Click;
            // 
            // DriverServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "DriverServiceForm";
            Text = "DriverServiceForm";
            Activated += DriverServiceForm_Activated;
            FormClosing += DriverServiceForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView DriverListView;
        private Button AddDriverBtn;
        private ColumnHeader ID;
        private ColumnHeader DriverName;
    }
}