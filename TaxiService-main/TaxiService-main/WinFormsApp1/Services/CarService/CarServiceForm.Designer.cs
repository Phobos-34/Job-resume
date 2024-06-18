namespace TaxiClient.Services.CarService
{
    partial class CarServiceForm
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
            AddCarBtn = new Button();
            CarListView = new ListView();
            ID = new ColumnHeader();
            Color = new ColumnHeader();
            Model = new ColumnHeader();
            Vin = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AddCarBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(CarListView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.88889F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddCarBtn
            // 
            AddCarBtn.Anchor = AnchorStyles.None;
            AddCarBtn.Location = new Point(341, 385);
            AddCarBtn.Name = "AddCarBtn";
            AddCarBtn.Size = new Size(117, 36);
            AddCarBtn.TabIndex = 0;
            AddCarBtn.Text = "Add Car";
            AddCarBtn.UseVisualStyleBackColor = true;
            AddCarBtn.Click += AddCarBtn_Click;
            // 
            // CarListView
            // 
            CarListView.Columns.AddRange(new ColumnHeader[] { ID, Color, Model, Vin });
            CarListView.Dock = DockStyle.Fill;
            CarListView.Location = new Point(3, 3);
            CarListView.Name = "CarListView";
            CarListView.Size = new Size(794, 350);
            CarListView.TabIndex = 1;
            CarListView.UseCompatibleStateImageBehavior = false;
            CarListView.View = View.Details;
            CarListView.SelectedIndexChanged += CarListView_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Color
            // 
            Color.Text = "Color";
            // 
            // Model
            // 
            Model.Text = "Model";
            // 
            // Vin
            // 
            Vin.Text = "VIN";
            // 
            // CarServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CarServiceForm";
            Text = "CarServiceForm";
            Activated += CarServiceForm_Activated;
            FormClosing += CarServiceForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button AddCarBtn;
        private ListView CarListView;
        private ColumnHeader ID;
        private ColumnHeader Color;
        private ColumnHeader Model;
        private ColumnHeader Vin;
    }
}