namespace Lab3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rect_create = new System.Windows.Forms.Button();
            this.Sq_create = new System.Windows.Forms.Button();
            this.El_create = new System.Windows.Forms.Button();
            this.Circle_create = new System.Windows.Forms.Button();
            this.rect_x = new System.Windows.Forms.TextBox();
            this.rect_y = new System.Windows.Forms.TextBox();
            this.rect_w = new System.Windows.Forms.TextBox();
            this.rect_h = new System.Windows.Forms.TextBox();
            this.sq_x = new System.Windows.Forms.TextBox();
            this.sq_y = new System.Windows.Forms.TextBox();
            this.sq_w = new System.Windows.Forms.TextBox();
            this.el_x = new System.Windows.Forms.TextBox();
            this.el_y = new System.Windows.Forms.TextBox();
            this.el_r1 = new System.Windows.Forms.TextBox();
            this.el_r2 = new System.Windows.Forms.TextBox();
            this.circ_x = new System.Windows.Forms.TextBox();
            this.circ_y = new System.Windows.Forms.TextBox();
            this.circ_r = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.figuresListBox = new System.Windows.Forms.ListBox();
            this.move_button = new System.Windows.Forms.Button();
            this.move_to_x = new System.Windows.Forms.TextBox();
            this.move_to_y = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rect_create
            // 
            this.Rect_create.Location = new System.Drawing.Point(13, 481);
            this.Rect_create.Name = "Rect_create";
            this.Rect_create.Size = new System.Drawing.Size(88, 42);
            this.Rect_create.TabIndex = 1;
            this.Rect_create.Text = "Прямоугольник";
            this.Rect_create.UseVisualStyleBackColor = true;
            this.Rect_create.Click += new System.EventHandler(this.Rect_create_Click);
            // 
            // Sq_create
            // 
            this.Sq_create.Location = new System.Drawing.Point(117, 481);
            this.Sq_create.Name = "Sq_create";
            this.Sq_create.Size = new System.Drawing.Size(85, 42);
            this.Sq_create.TabIndex = 2;
            this.Sq_create.Text = "Квадрат";
            this.Sq_create.UseVisualStyleBackColor = true;
            this.Sq_create.Click += new System.EventHandler(this.Sq_create_Click);
            // 
            // El_create
            // 
            this.El_create.Location = new System.Drawing.Point(223, 481);
            this.El_create.Name = "El_create";
            this.El_create.Size = new System.Drawing.Size(87, 42);
            this.El_create.TabIndex = 3;
            this.El_create.Text = "Эллипс";
            this.El_create.UseVisualStyleBackColor = true;
            this.El_create.Click += new System.EventHandler(this.El_create_Click);
            // 
            // Circle_create
            // 
            this.Circle_create.Location = new System.Drawing.Point(333, 481);
            this.Circle_create.Name = "Circle_create";
            this.Circle_create.Size = new System.Drawing.Size(82, 42);
            this.Circle_create.TabIndex = 4;
            this.Circle_create.Text = "Окружность";
            this.Circle_create.UseVisualStyleBackColor = true;
            this.Circle_create.Click += new System.EventHandler(this.Circle_create_Click);
            // 
            // rect_x
            // 
            this.rect_x.Location = new System.Drawing.Point(51, 529);
            this.rect_x.Name = "rect_x";
            this.rect_x.Size = new System.Drawing.Size(50, 22);
            this.rect_x.TabIndex = 5;
            // 
            // rect_y
            // 
            this.rect_y.Location = new System.Drawing.Point(51, 557);
            this.rect_y.Name = "rect_y";
            this.rect_y.Size = new System.Drawing.Size(50, 22);
            this.rect_y.TabIndex = 6;
            // 
            // rect_w
            // 
            this.rect_w.Location = new System.Drawing.Point(51, 585);
            this.rect_w.Name = "rect_w";
            this.rect_w.Size = new System.Drawing.Size(50, 22);
            this.rect_w.TabIndex = 7;
            // 
            // rect_h
            // 
            this.rect_h.Location = new System.Drawing.Point(51, 613);
            this.rect_h.Name = "rect_h";
            this.rect_h.Size = new System.Drawing.Size(50, 22);
            this.rect_h.TabIndex = 8;
            // 
            // sq_x
            // 
            this.sq_x.Location = new System.Drawing.Point(154, 529);
            this.sq_x.Name = "sq_x";
            this.sq_x.Size = new System.Drawing.Size(48, 22);
            this.sq_x.TabIndex = 9;
            // 
            // sq_y
            // 
            this.sq_y.Location = new System.Drawing.Point(154, 557);
            this.sq_y.Name = "sq_y";
            this.sq_y.Size = new System.Drawing.Size(48, 22);
            this.sq_y.TabIndex = 10;
            // 
            // sq_w
            // 
            this.sq_w.Location = new System.Drawing.Point(154, 589);
            this.sq_w.Name = "sq_w";
            this.sq_w.Size = new System.Drawing.Size(48, 22);
            this.sq_w.TabIndex = 11;
            // 
            // el_x
            // 
            this.el_x.Location = new System.Drawing.Point(266, 529);
            this.el_x.Name = "el_x";
            this.el_x.Size = new System.Drawing.Size(44, 22);
            this.el_x.TabIndex = 12;
            // 
            // el_y
            // 
            this.el_y.Location = new System.Drawing.Point(266, 557);
            this.el_y.Name = "el_y";
            this.el_y.Size = new System.Drawing.Size(44, 22);
            this.el_y.TabIndex = 13;
            // 
            // el_r1
            // 
            this.el_r1.Location = new System.Drawing.Point(266, 585);
            this.el_r1.Name = "el_r1";
            this.el_r1.Size = new System.Drawing.Size(44, 22);
            this.el_r1.TabIndex = 14;
            // 
            // el_r2
            // 
            this.el_r2.Location = new System.Drawing.Point(266, 613);
            this.el_r2.Name = "el_r2";
            this.el_r2.Size = new System.Drawing.Size(44, 22);
            this.el_r2.TabIndex = 15;
            // 
            // circ_x
            // 
            this.circ_x.Location = new System.Drawing.Point(366, 529);
            this.circ_x.Name = "circ_x";
            this.circ_x.Size = new System.Drawing.Size(49, 22);
            this.circ_x.TabIndex = 16;
            // 
            // circ_y
            // 
            this.circ_y.Location = new System.Drawing.Point(366, 557);
            this.circ_y.Name = "circ_y";
            this.circ_y.Size = new System.Drawing.Size(49, 22);
            this.circ_y.TabIndex = 17;
            // 
            // circ_r
            // 
            this.circ_r.Location = new System.Drawing.Point(366, 585);
            this.circ_r.Name = "circ_r";
            this.circ_r.Size = new System.Drawing.Size(49, 22);
            this.circ_r.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(328, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(110, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(218, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(328, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "W:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(110, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "W:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "H:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(218, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "R1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(218, 609);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "R2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(329, 581);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "R:";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(433, 651);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(222, 42);
            this.delete_button.TabIndex = 33;
            this.delete_button.Text = "удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // figuresListBox
            // 
            this.figuresListBox.FormattingEnabled = true;
            this.figuresListBox.ItemHeight = 16;
            this.figuresListBox.Location = new System.Drawing.Point(433, 481);
            this.figuresListBox.Name = "figuresListBox";
            this.figuresListBox.Size = new System.Drawing.Size(222, 164);
            this.figuresListBox.TabIndex = 34;
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(663, 537);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(100, 45);
            this.move_button.TabIndex = 35;
            this.move_button.Text = "переместить";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // move_to_x
            // 
            this.move_to_x.Location = new System.Drawing.Point(699, 481);
            this.move_to_x.Name = "move_to_x";
            this.move_to_x.Size = new System.Drawing.Size(64, 22);
            this.move_to_x.TabIndex = 36;
            // 
            // move_to_y
            // 
            this.move_to_y.Location = new System.Drawing.Point(699, 509);
            this.move_to_y.Name = "move_to_y";
            this.move_to_y.Size = new System.Drawing.Size(64, 22);
            this.move_to_y.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(661, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "X:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(663, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 25);
            this.label16.TabIndex = 39;
            this.label16.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 40;
            this.button1.Text = "изменить прямоугольник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "изменить квадрат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 42;
            this.button3.Text = "изменить эллипс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(769, 649);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 43;
            this.button4.Text = "изменить окружность";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 705);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.move_to_y);
            this.Controls.Add(this.move_to_x);
            this.Controls.Add(this.move_button);
            this.Controls.Add(this.figuresListBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circ_r);
            this.Controls.Add(this.circ_y);
            this.Controls.Add(this.circ_x);
            this.Controls.Add(this.el_r2);
            this.Controls.Add(this.el_r1);
            this.Controls.Add(this.el_y);
            this.Controls.Add(this.el_x);
            this.Controls.Add(this.sq_w);
            this.Controls.Add(this.sq_y);
            this.Controls.Add(this.sq_x);
            this.Controls.Add(this.rect_h);
            this.Controls.Add(this.rect_w);
            this.Controls.Add(this.rect_y);
            this.Controls.Add(this.rect_x);
            this.Controls.Add(this.Circle_create);
            this.Controls.Add(this.El_create);
            this.Controls.Add(this.Sq_create);
            this.Controls.Add(this.Rect_create);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Rect_create;
        private System.Windows.Forms.Button Sq_create;
        private System.Windows.Forms.Button El_create;
        private System.Windows.Forms.Button Circle_create;
        private System.Windows.Forms.TextBox rect_x;
        private System.Windows.Forms.TextBox rect_y;
        private System.Windows.Forms.TextBox rect_w;
        private System.Windows.Forms.TextBox rect_h;
        private System.Windows.Forms.TextBox sq_x;
        private System.Windows.Forms.TextBox sq_y;
        private System.Windows.Forms.TextBox sq_w;
        private System.Windows.Forms.TextBox el_x;
        private System.Windows.Forms.TextBox el_y;
        private System.Windows.Forms.TextBox el_r1;
        private System.Windows.Forms.TextBox el_r2;
        private System.Windows.Forms.TextBox circ_x;
        private System.Windows.Forms.TextBox circ_y;
        private System.Windows.Forms.TextBox circ_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListBox figuresListBox;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.TextBox move_to_x;
        private System.Windows.Forms.TextBox move_to_y;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

