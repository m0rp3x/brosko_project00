using System.Windows.Forms;

namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Абоба = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.БАЗА = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.Абоба.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.БАЗА.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Абоба
            // 
            this.Абоба.Controls.Add(this.button10);
            this.Абоба.Controls.Add(this.button9);
            this.Абоба.Controls.Add(this.dataGridView4);
            this.Абоба.Controls.Add(this.button8);
            this.Абоба.Controls.Add(this.textBox10);
            this.Абоба.Controls.Add(this.textBox9);
            this.Абоба.Controls.Add(this.textBox8);
            this.Абоба.Controls.Add(this.dataGridView3);
            this.Абоба.Controls.Add(this.button5);
            this.Абоба.Controls.Add(this.button3);
            this.Абоба.Controls.Add(this.textBox3);
            this.Абоба.Controls.Add(this.textBox1);
            this.Абоба.Controls.Add(this.button2);
            this.Абоба.Controls.Add(this.dataGridView1);
            this.Абоба.Controls.Add(this.button1);
            this.Абоба.Location = new System.Drawing.Point(4, 24);
            this.Абоба.Name = "Абоба";
            this.Абоба.Padding = new System.Windows.Forms.Padding(3);
            this.Абоба.Size = new System.Drawing.Size(1060, 551);
            this.Абоба.TabIndex = 0;
            this.Абоба.Text = "Патреон";
            this.Абоба.UseVisualStyleBackColor = true;
            this.Абоба.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(356, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Удалить ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(870, 376);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Показать дауна";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(719, 247);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(335, 94);
            this.dataGridView4.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(719, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Добавить долбаеба";
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.Location = new System.Drawing.Point(954, 347);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9.Location = new System.Drawing.Point(719, 347);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 23);
            this.textBox9.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(832, 347);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(856, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(198, 118);
            this.dataGridView3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(856, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Онлайн";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 23);
            this.textBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1048, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ваша прихоть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(475, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вывод всего";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // БАЗА
            // 
            this.БАЗА.Controls.Add(this.Абоба);
            this.БАЗА.Controls.Add(this.tabPage2);
            this.БАЗА.Location = new System.Drawing.Point(12, 12);
            this.БАЗА.Name = "БАЗА";
            this.БАЗА.SelectedIndex = 0;
            this.БАЗА.Size = new System.Drawing.Size(1068, 579);
            this.БАЗА.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дискорд";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(373, 460);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Что угодно";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(242, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(2, 431);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(475, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(475, 389);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(2, 460);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(365, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Вывод всего";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1097, 605);
            this.Controls.Add(this.БАЗА);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Абоба.ResumeLayout(false);
            this.Абоба.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.БАЗА.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl БАЗА;
        private TabPage Абоба;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private DataGridView dataGridView3;
        private Button button5;
        private TabPage tabPage2;
        private TextBox textBox4;
        private DataGridView dataGridView2;
        private Button button6;
        private Button button4;
        private TextBox textBox2;
        private Button button7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Button button8;
        private DataGridView dataGridView4;
        private Button button9;
        private Button button10;
    }
}