namespace BitFlash
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
            this.cmbdrives = new System.Windows.Forms.ComboBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.tstISOPath = new System.Windows.Forms.TextBox();
            this.btnSelectISO = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkForceMBR = new System.Windows.Forms.CheckBox();
            this.chkFAT32 = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmbdrives
            // 
            this.cmbdrives.FormattingEnabled = true;
            this.cmbdrives.Location = new System.Drawing.Point(46, 54);
            this.cmbdrives.Name = "cmbdrives";
            this.cmbdrives.Size = new System.Drawing.Size(253, 21);
            this.cmbdrives.TabIndex = 0;
            this.cmbdrives.SelectedIndexChanged += new System.EventHandler(this.cmbdrives_SelectedIndexChanged);
            this.cmbdrives.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(48, 234);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(100, 43);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Форматировать";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.button1_Click);
            // 
            // tstISOPath
            // 
            this.tstISOPath.Location = new System.Drawing.Point(194, 95);
            this.tstISOPath.Name = "tstISOPath";
            this.tstISOPath.Size = new System.Drawing.Size(105, 20);
            this.tstISOPath.TabIndex = 2;
            // 
            // btnSelectISO
            // 
            this.btnSelectISO.Location = new System.Drawing.Point(46, 95);
            this.btnSelectISO.Name = "btnSelectISO";
            this.btnSelectISO.Size = new System.Drawing.Size(102, 23);
            this.btnSelectISO.TabIndex = 3;
            this.btnSelectISO.Text = "Выбрать ISO";
            this.btnSelectISO.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(194, 234);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(121, 43);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Записать на флешку";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BitFlash";
            // 
            // chkForceMBR
            // 
            this.chkForceMBR.AutoSize = true;
            this.chkForceMBR.Location = new System.Drawing.Point(48, 187);
            this.chkForceMBR.Name = "chkForceMBR";
            this.chkForceMBR.Size = new System.Drawing.Size(197, 17);
            this.chkForceMBR.TabIndex = 6;
            this.chkForceMBR.Text = "Принудительно записывать в mbr";
            this.chkForceMBR.UseVisualStyleBackColor = true;
            // 
            // chkFAT32
            // 
            this.chkFAT32.AutoSize = true;
            this.chkFAT32.Location = new System.Drawing.Point(48, 164);
            this.chkFAT32.Name = "chkFAT32";
            this.chkFAT32.Size = new System.Drawing.Size(153, 17);
            this.chkFAT32.TabIndex = 7;
            this.chkFAT32.Text = "Форматировать в FAT32";
            this.chkFAT32.UseVisualStyleBackColor = true;
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Location = new System.Drawing.Point(48, 141);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(173, 17);
            this.chkShutdown.TabIndex = 8;
            this.chkShutdown.Text = "Выключить ПК после записи";
            this.chkShutdown.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 21);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 330);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkShutdown);
            this.Controls.Add(this.chkFAT32);
            this.Controls.Add(this.chkForceMBR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnSelectISO);
            this.Controls.Add(this.tstISOPath);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.cmbdrives);
            this.Name = "Form1";
            this.Text = "BitFlash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdrives;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox tstISOPath;
        private System.Windows.Forms.Button btnSelectISO;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkForceMBR;
        private System.Windows.Forms.CheckBox chkFAT32;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

