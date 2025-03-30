namespace AuctionTradeKurs
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
            dataGridViewAuction = new DataGridView();
            button_exit = new Button();
            menuStrip1 = new MenuStrip();
            УправлениеАукционамиToolStripMenuItem = new ToolStripMenuItem();
            УправлениеЛотамиToolStripMenuItem = new ToolStripMenuItem();
            формированиеОтчётовToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            dataGridViewLog = new DataGridView();
            dataGridViewLot = new DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            dataGridView4 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuction).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAuction
            // 
            dataGridViewAuction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuction.Location = new Point(12, 195);
            dataGridViewAuction.Name = "dataGridViewAuction";
            dataGridViewAuction.Size = new Size(644, 242);
            dataGridViewAuction.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(662, 385);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(126, 53);
            button_exit.TabIndex = 1;
            button_exit.Text = "Выход";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { УправлениеАукционамиToolStripMenuItem, УправлениеЛотамиToolStripMenuItem, формированиеОтчётовToolStripMenuItem, помощьToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // УправлениеАукционамиToolStripMenuItem
            // 
            УправлениеАукционамиToolStripMenuItem.Name = "УправлениеАукционамиToolStripMenuItem";
            УправлениеАукционамиToolStripMenuItem.Size = new Size(156, 20);
            УправлениеАукционамиToolStripMenuItem.Text = "Управление аукционами";
            УправлениеАукционамиToolStripMenuItem.Click += УправлениеАукционамиToolStripMenuItem_Click;
            // 
            // УправлениеЛотамиToolStripMenuItem
            // 
            УправлениеЛотамиToolStripMenuItem.Name = "УправлениеЛотамиToolStripMenuItem";
            УправлениеЛотамиToolStripMenuItem.Size = new Size(129, 20);
            УправлениеЛотамиToolStripMenuItem.Text = "Управление лотами";
            УправлениеЛотамиToolStripMenuItem.Click += УправлениеЛотамиToolStripMenuItem_Click;
            // 
            // формированиеОтчётовToolStripMenuItem
            // 
            формированиеОтчётовToolStripMenuItem.Name = "формированиеОтчётовToolStripMenuItem";
            формированиеОтчётовToolStripMenuItem.Size = new Size(143, 20);
            формированиеОтчётовToolStripMenuItem.Text = "Формирование отчёта";
            формированиеОтчётовToolStripMenuItem.Click += формированиеОтчётовToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            помощьToolStripMenuItem.Click += помощьToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 3;
            label1.Text = "Дата и время начала аукциона";
            // 
            // button1
            // 
            button1.Location = new Point(662, 195);
            button1.Name = "button1";
            button1.Size = new Size(126, 58);
            button1.TabIndex = 4;
            button1.Text = "Сформировать отчёт";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(548, 23);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(662, 195);
            button2.Name = "button2";
            button2.Size = new Size(126, 58);
            button2.TabIndex = 7;
            button2.Text = "Назначить аукцион";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(662, 195);
            button3.Name = "button3";
            button3.Size = new Size(126, 57);
            button3.TabIndex = 8;
            button3.Text = "Добавить лот";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 9;
            label2.Text = "Дата и время окончания аукциона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 10;
            label3.Text = "Укажите аукционера";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(548, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(548, 23);
            textBox3.TabIndex = 12;
            textBox3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 13;
            label4.Text = "Укажите место проведение";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(548, 23);
            textBox4.TabIndex = 14;
            textBox4.Visible = false;
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Location = new Point(335, 195);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.Size = new Size(321, 242);
            dataGridViewLog.TabIndex = 15;
            dataGridViewLog.Visible = false;
            // 
            // dataGridViewLot
            // 
            dataGridViewLot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLot.Location = new Point(12, 195);
            dataGridViewLot.Name = "dataGridViewLot";
            dataGridViewLot.Size = new Size(644, 243);
            dataGridViewLot.TabIndex = 16;
            dataGridViewLot.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Очно", "Очно-Заочно", "Заочно" });
            comboBox1.Location = new Point(240, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(548, 23);
            comboBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 158);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 18;
            label5.Text = "Укажите форму проведения";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Нефтяников 10", "Энтузиастов 32", "Энергетиков 22", "Ленина 1", "Островского 46" });
            comboBox2.Location = new Point(240, 126);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(548, 23);
            comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Николай", "Иван", "Любовь", "Константин", "Дарья" });
            comboBox3.Location = new Point(240, 97);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(548, 23);
            comboBox3.TabIndex = 20;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(240, 126);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(548, 23);
            comboBox4.TabIndex = 21;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Бытовая техника", "Монеты", "Компьютерная периферия", "Украшение", "Игрушка" });
            comboBox5.Location = new Point(240, 39);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(548, 23);
            comboBox5.TabIndex = 22;
            comboBox5.Visible = false;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(12, 227);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(644, 211);
            dataGridView4.TabIndex = 23;
            dataGridView4.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 209);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 24;
            label6.Text = "Проданные лоты:";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 24);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 25;
            label7.Text = "История ставок:";
            label7.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView4);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewLot);
            Controls.Add(dataGridViewLog);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button_exit);
            Controls.Add(dataGridViewAuction);
            Controls.Add(menuStrip1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "АС \"Аукционная торговля\"";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuction).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLot).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAuction;
        private Button button_exit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem УправлениеАукционамиToolStripMenuItem;
        private ToolStripMenuItem УправлениеЛотамиToolStripMenuItem;
        private ToolStripMenuItem формированиеОтчётовToolStripMenuItem;
        private Label label1;
        private Button button1;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dataGridViewLog;
        private DataGridView dataGridViewLot;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private DataGridView dataGridView4;
        private Label label6;
        private Label label7;
    }
}
