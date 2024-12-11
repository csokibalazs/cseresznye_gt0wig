namespace MarvelFilmek
{
    partial class ListBox
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
            listBox1 = new System.Windows.Forms.ListBox();
            movieBindingSource = new BindingSource(components);
            textBoxDir = new TextBox();
            textBoxRat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.DataSource = movieBindingSource;
            listBox1.DisplayMember = "Title";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 23);
            listBox1.Margin = new Padding(2, 1, 2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 349);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "Id";
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(MovieModels.Movie);
            // 
            // textBoxDir
            // 
            textBoxDir.DataBindings.Add(new Binding("DataContext", movieBindingSource, "Director", true));
            textBoxDir.Location = new Point(272, 82);
            textBoxDir.Margin = new Padding(2, 1, 2, 1);
            textBoxDir.Name = "textBoxDir";
            textBoxDir.Size = new Size(159, 23);
            textBoxDir.TabIndex = 1;
            textBoxDir.TextChanged += textBoxDir_TextChanged;
            // 
            // textBoxRat
            // 
            textBoxRat.DataBindings.Add(new Binding("DataContext", movieBindingSource, "Rating", true));
            textBoxRat.Location = new Point(272, 141);
            textBoxRat.Margin = new Padding(2, 1, 2, 1);
            textBoxRat.Name = "textBoxRat";
            textBoxRat.Size = new Size(159, 23);
            textBoxRat.TabIndex = 2;
            textBoxRat.TextChanged += textBoxRat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Rendező";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 4;
            label2.Text = "Minimum értékelés";
            // 
            // ListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRat);
            Controls.Add(textBoxDir);
            Controls.Add(listBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ListBox";
            Size = new Size(460, 404);
            Load += ListBox_Load;
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private BindingSource movieBindingSource;
        private TextBox textBoxDir;
        private TextBox textBoxRat;
        private Label label1;
        private Label label2;
    }
}