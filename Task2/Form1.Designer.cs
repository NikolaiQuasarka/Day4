namespace Task2
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
            button2 = new Button();
            textBox_name = new TextBox();
            textBox_price = new TextBox();
            textBox_nameStore = new TextBox();
            textBox_search = new TextBox();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            storeName = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            radioButton_name = new RadioButton();
            radioButton_nameStore = new RadioButton();
            radioButton_price = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(110, 228);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 178);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Искать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(171, 50);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(164, 27);
            textBox_name.TabIndex = 3;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(171, 107);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(164, 27);
            textBox_price.TabIndex = 4;
            // 
            // textBox_nameStore
            // 
            textBox_nameStore.Location = new Point(171, 164);
            textBox_nameStore.Name = "textBox_nameStore";
            textBox_nameStore.Size = new Size(164, 27);
            textBox_nameStore.TabIndex = 5;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(76, 129);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(195, 27);
            textBox_search.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, price, storeName });
            dataGridView1.Location = new Point(33, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 537);
            dataGridView1.TabIndex = 7;
            // 
            // name
            // 
            name.HeaderText = "Название товара";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 145;
            // 
            // price
            // 
            price.HeaderText = "Цена товара";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 116;
            // 
            // storeName
            // 
            storeName.HeaderText = "Название магазина";
            storeName.MinimumWidth = 6;
            storeName.Name = "storeName";
            storeName.ReadOnly = true;
            storeName.Width = 161;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_price);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(textBox_nameStore);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(476, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 289);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 167);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 8;
            label3.Text = "Название магазина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Цена товара";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 6;
            label1.Text = "Название товара";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox_search);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(476, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 242);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск";
            // 
            // button3
            // 
            button3.Location = new Point(193, 178);
            button3.Name = "button3";
            button3.Size = new Size(142, 29);
            button3.TabIndex = 14;
            button3.Text = "Отменить поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton_name);
            groupBox3.Controls.Add(radioButton_nameStore);
            groupBox3.Controls.Add(radioButton_price);
            groupBox3.Location = new Point(62, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 106);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // radioButton_name
            // 
            radioButton_name.AutoSize = true;
            radioButton_name.Location = new Point(9, 19);
            radioButton_name.Name = "radioButton_name";
            radioButton_name.Size = new Size(176, 24);
            radioButton_name.TabIndex = 10;
            radioButton_name.TabStop = true;
            radioButton_name.Text = "По названию товара";
            radioButton_name.UseVisualStyleBackColor = true;
            // 
            // radioButton_nameStore
            // 
            radioButton_nameStore.AutoSize = true;
            radioButton_nameStore.Location = new Point(9, 79);
            radioButton_nameStore.Name = "radioButton_nameStore";
            radioButton_nameStore.Size = new Size(194, 24);
            radioButton_nameStore.TabIndex = 12;
            radioButton_nameStore.TabStop = true;
            radioButton_nameStore.Text = "По названию магазина";
            radioButton_nameStore.UseVisualStyleBackColor = true;
            // 
            // radioButton_price
            // 
            radioButton_price.AutoSize = true;
            radioButton_price.Location = new Point(9, 49);
            radioButton_price.Name = "radioButton_price";
            radioButton_price.Size = new Size(88, 24);
            radioButton_price.TabIndex = 11;
            radioButton_price.TabStop = true;
            radioButton_price.Text = "По цене";
            radioButton_price.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 578);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox_name;
        private TextBox textBox_price;
        private TextBox textBox_nameStore;
        private TextBox textBox_search;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn storeName;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButton_name;
        private RadioButton radioButton_price;
        private RadioButton radioButton_nameStore;
        private GroupBox groupBox3;
        private Button button3;
    }
}
