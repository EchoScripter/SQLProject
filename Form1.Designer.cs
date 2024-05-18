namespace DatabaseSQLMusicAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_Description = new TextBox();
            txt_imageURL = new TextBox();
            txt_year = new TextBox();
            txt_artistName = new TextBox();
            txt_albumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(331, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(709, 233);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(765, 12);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(467, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1080, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_Description);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artistName);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button3
            // 
            button3.Location = new Point(77, 159);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(110, 130);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(161, 23);
            txt_Description.TabIndex = 9;
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(110, 103);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(161, 23);
            txt_imageURL.TabIndex = 8;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(110, 76);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(161, 23);
            txt_year.TabIndex = 7;
            // 
            // txt_artistName
            // 
            txt_artistName.Location = new Point(110, 49);
            txt_artistName.Name = "txt_artistName";
            txt_artistName.Size = new Size(161, 23);
            txt_artistName.TabIndex = 6;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(110, 22);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(161, 23);
            txt_albumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 130);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 57);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 289);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            label6.Click += label6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(334, 309);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(706, 150);
            dataGridView2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(334, 465);
            button4.Name = "button4";
            button4.Size = new Size(127, 30);
            button4.TabIndex = 8;
            button4.Text = "Delete Selected Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 572);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Description;
        private TextBox txt_imageURL;
        private TextBox txt_year;
        private TextBox txt_artistName;
        private TextBox txt_albumName;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
    }
}
