namespace demoexz2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRaiting = new System.Windows.Forms.TextBox();
            this.labelNomer = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.TextBox();
            this.labelNaimenovanie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(143, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "|";
            // 
            // labelRaiting
            // 
            this.labelRaiting.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelRaiting.Location = new System.Drawing.Point(12, 126);
            this.labelRaiting.Name = "labelRaiting";
            this.labelRaiting.Size = new System.Drawing.Size(125, 25);
            this.labelRaiting.TabIndex = 20;
            this.labelRaiting.Text = "Рейтинг";
            // 
            // labelNomer
            // 
            this.labelNomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNomer.Location = new System.Drawing.Point(12, 102);
            this.labelNomer.Name = "labelNomer";
            this.labelNomer.Size = new System.Drawing.Size(125, 25);
            this.labelNomer.TabIndex = 19;
            this.labelNomer.Text = "Номер";
            // 
            // labelDirector
            // 
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDirector.Location = new System.Drawing.Point(12, 75);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(125, 25);
            this.labelDirector.TabIndex = 18;
            this.labelDirector.Text = "Директор";
            // 
            // labelNaimenovanie
            // 
            this.labelNaimenovanie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNaimenovanie.Location = new System.Drawing.Point(163, 43);
            this.labelNaimenovanie.Name = "labelNaimenovanie";
            this.labelNaimenovanie.Size = new System.Drawing.Size(216, 29);
            this.labelNaimenovanie.TabIndex = 17;
            this.labelNaimenovanie.Text = "Наименование партнера";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 25);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Почта";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 29);
            this.comboBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(12, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 25);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "Юридический адрес";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(394, 210);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRaiting);
            this.Controls.Add(this.labelNomer);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelNaimenovanie);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelRaiting;
        private System.Windows.Forms.TextBox labelNomer;
        private System.Windows.Forms.TextBox labelDirector;
        private System.Windows.Forms.TextBox labelNaimenovanie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}