namespace ClockApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.ClassicHand = new System.Windows.Forms.RadioButton();
            this.StandartHand = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTick = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.Standart = new System.Windows.Forms.RadioButton();
            this.Caption = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassicHand
            // 
            this.ClassicHand.AutoSize = true;
            this.ClassicHand.Location = new System.Drawing.Point(95, 20);
            this.ClassicHand.Name = "ClassicHand";
            this.ClassicHand.Size = new System.Drawing.Size(58, 17);
            this.ClassicHand.TabIndex = 1;
            this.ClassicHand.TabStop = true;
            this.ClassicHand.Text = "Classic";
            this.ClassicHand.UseVisualStyleBackColor = true;
            this.ClassicHand.CheckedChanged += new System.EventHandler(this.DoStyle);
            // 
            // StandartHand
            // 
            this.StandartHand.AutoSize = true;
            this.StandartHand.Checked = true;
            this.StandartHand.Location = new System.Drawing.Point(7, 20);
            this.StandartHand.Name = "StandartHand";
            this.StandartHand.Size = new System.Drawing.Size(65, 17);
            this.StandartHand.TabIndex = 0;
            this.StandartHand.TabStop = true;
            this.StandartHand.Text = "Standart";
            this.StandartHand.UseVisualStyleBackColor = true;
            this.StandartHand.CheckedChanged += new System.EventHandler(this.DoStyle);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassicHand);
            this.groupBox2.Controls.Add(this.StandartHand);
            this.groupBox2.Location = new System.Drawing.Point(13, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hand Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ticks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numbers:";
            // 
            // comboBoxTick
            // 
            this.comboBoxTick.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBoxTick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTick.FormattingEnabled = true;
            this.comboBoxTick.Items.AddRange(new object[] {
            "All",
            "Main",
            "Big",
            "None"});
            this.comboBoxTick.Location = new System.Drawing.Point(67, 167);
            this.comboBoxTick.Name = "comboBoxTick";
            this.comboBoxTick.Size = new System.Drawing.Size(105, 21);
            this.comboBoxTick.TabIndex = 6;
            this.comboBoxTick.SelectedValueChanged += new System.EventHandler(this.DoClockRefresh);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(67, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.DoClockRefresh);
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Items.AddRange(new object[] {
            "All ",
            "Main",
            "None"});
            this.comboBoxNumber.Location = new System.Drawing.Point(67, 221);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(105, 21);
            this.comboBoxNumber.TabIndex = 8;
            this.comboBoxNumber.SelectedValueChanged += new System.EventHandler(this.DoClockRefresh);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "InnerColor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "OuterColor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "SecHandColor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "HandColor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(97, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "TextColor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "TickColor";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Caption:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Orion";
            // 
            // Clock
            // 
            this.Clock.Location = new System.Drawing.Point(178, 12);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(401, 370);
            this.Clock.TabIndex = 17;
            this.Clock.TabStop = false;
            this.Clock.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.DoClockRefresh);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Classic);
            this.groupBox1.Controls.Add(this.Standart);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Style";
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.Location = new System.Drawing.Point(95, 20);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(58, 17);
            this.Classic.TabIndex = 1;
            this.Classic.TabStop = true;
            this.Classic.Text = "Classic";
            this.Classic.UseVisualStyleBackColor = true;
            this.Classic.CheckedChanged += new System.EventHandler(this.DoStandart);
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.Checked = true;
            this.Standart.Location = new System.Drawing.Point(7, 20);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(65, 17);
            this.Standart.TabIndex = 0;
            this.Standart.TabStop = true;
            this.Standart.Text = "Standart";
            this.Standart.UseVisualStyleBackColor = true;
            this.Standart.CheckedChanged += new System.EventHandler(this.DoStandart);
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Location = new System.Drawing.Point(345, 90);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(0, 13);
            this.Caption.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 394);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxTick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Clock";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ClassicHand;
        private System.Windows.Forms.RadioButton StandartHand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTick;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Clock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.RadioButton Standart;
        private System.Windows.Forms.Label Caption;
    }
}

