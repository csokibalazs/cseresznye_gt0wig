namespace MarvelFilmek
{
    partial class GridView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            heroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalRevenueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heroRevenueBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heroRevenueBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { heroDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, totalRevenueDataGridViewTextBoxColumn });
            dataGridView1.DataSource = heroRevenueBindingSource;
            dataGridView1.Location = new Point(1, -1);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(462, 432);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // heroDataGridViewTextBoxColumn
            // 
            heroDataGridViewTextBoxColumn.DataPropertyName = "Hero";
            heroDataGridViewTextBoxColumn.HeaderText = "Hero";
            heroDataGridViewTextBoxColumn.MinimumWidth = 10;
            heroDataGridViewTextBoxColumn.Name = "heroDataGridViewTextBoxColumn";
            heroDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Visible = false;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalRevenueDataGridViewTextBoxColumn
            // 
            totalRevenueDataGridViewTextBoxColumn.DataPropertyName = "TotalRevenue";
            totalRevenueDataGridViewTextBoxColumn.HeaderText = "TotalRevenue";
            totalRevenueDataGridViewTextBoxColumn.MinimumWidth = 10;
            totalRevenueDataGridViewTextBoxColumn.Name = "totalRevenueDataGridViewTextBoxColumn";
            totalRevenueDataGridViewTextBoxColumn.Width = 200;
            // 
            // heroRevenueBindingSource
            // 
            heroRevenueBindingSource.DataSource = typeof(heroRevenue);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("DataContext", heroRevenueBindingSource, "Name", true));
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(544, 218);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 29);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(544, 177);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Ismertebb nevén:";
            // 
            // GridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GridView";
            Size = new Size(834, 433);
            Load += GridView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heroRevenueBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource heroRevenueBindingSource;
        private DataGridViewTextBoxColumn heroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalRevenueDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Label label1;
    }
}