namespace demoexz2
{
    partial class Partner
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelSkidka = new System.Windows.Forms.Label();
            this.labelRaiting = new System.Windows.Forms.Label();
            this.labelNomer = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelNaimenovanie = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(83, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "|";
            // 
            // labelSkidka
            // 
            this.labelSkidka.AutoSize = true;
            this.labelSkidka.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSkidka.Location = new System.Drawing.Point(328, 10);
            this.labelSkidka.Name = "labelSkidka";
            this.labelSkidka.Size = new System.Drawing.Size(62, 21);
            this.labelSkidka.TabIndex = 13;
            this.labelSkidka.Text = "Скидка";
            this.labelSkidka.Click += new System.EventHandler(this.labelSkidka_Click);
            // 
            // labelRaiting
            // 
            this.labelRaiting.AutoSize = true;
            this.labelRaiting.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelRaiting.Location = new System.Drawing.Point(7, 94);
            this.labelRaiting.Name = "labelRaiting";
            this.labelRaiting.Size = new System.Drawing.Size(59, 19);
            this.labelRaiting.TabIndex = 12;
            this.labelRaiting.Text = "Рейтинг";
            this.labelRaiting.Click += new System.EventHandler(this.labelRaiting_Click);
            // 
            // labelNomer
            // 
            this.labelNomer.AutoSize = true;
            this.labelNomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNomer.Location = new System.Drawing.Point(7, 70);
            this.labelNomer.Name = "labelNomer";
            this.labelNomer.Size = new System.Drawing.Size(52, 19);
            this.labelNomer.TabIndex = 11;
            this.labelNomer.Text = "Номер";
            this.labelNomer.Click += new System.EventHandler(this.labelNomer_Click);
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDirector.Location = new System.Drawing.Point(7, 43);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(71, 19);
            this.labelDirector.TabIndex = 10;
            this.labelDirector.Text = "Директор";
            this.labelDirector.Click += new System.EventHandler(this.labelDirector_Click);
            // 
            // labelNaimenovanie
            // 
            this.labelNaimenovanie.AutoSize = true;
            this.labelNaimenovanie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNaimenovanie.Location = new System.Drawing.Point(103, 10);
            this.labelNaimenovanie.Name = "labelNaimenovanie";
            this.labelNaimenovanie.Size = new System.Drawing.Size(188, 21);
            this.labelNaimenovanie.TabIndex = 9;
            this.labelNaimenovanie.Text = "Наименование партнера";
            this.labelNaimenovanie.Click += new System.EventHandler(this.labelNaimenovanie_Click);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTip.Location = new System.Drawing.Point(3, 10);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(36, 21);
            this.labelTip.TabIndex = 8;
            this.labelTip.Text = "Тип";
            this.labelTip.Click += new System.EventHandler(this.labelTip_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(372, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 18);
            this.panel1.TabIndex = 15;
            // 
            // Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSkidka);
            this.Controls.Add(this.labelRaiting);
            this.Controls.Add(this.labelNomer);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelNaimenovanie);
            this.Controls.Add(this.labelTip);
            this.Name = "Partner";
            this.Size = new System.Drawing.Size(398, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSkidka;
        private System.Windows.Forms.Label labelRaiting;
        private System.Windows.Forms.Label labelNomer;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelNaimenovanie;
        private System.Windows.Forms.Label labelTip;
        
    }
}
