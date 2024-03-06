namespace EnglishTest_Gavrilova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.btn2Klass = new System.Windows.Forms.Button();
            this.btn3Klass = new System.Windows.Forms.Button();
            this.btn4Klass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тест по английскому языку для 2-4 классов";
            // 
            // btn2Klass
            // 
            this.btn2Klass.BackColor = System.Drawing.Color.Maroon;
            this.btn2Klass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2Klass.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Klass.ForeColor = System.Drawing.Color.White;
            this.btn2Klass.Location = new System.Drawing.Point(40, 384);
            this.btn2Klass.Name = "btn2Klass";
            this.btn2Klass.Size = new System.Drawing.Size(148, 54);
            this.btn2Klass.TabIndex = 9;
            this.btn2Klass.Text = "2 класс";
            this.btn2Klass.UseVisualStyleBackColor = false;
            this.btn2Klass.Click += new System.EventHandler(this.btn2Klass_Click);
            // 
            // btn3Klass
            // 
            this.btn3Klass.BackColor = System.Drawing.Color.Maroon;
            this.btn3Klass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3Klass.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn3Klass.ForeColor = System.Drawing.Color.White;
            this.btn3Klass.Location = new System.Drawing.Point(244, 384);
            this.btn3Klass.Name = "btn3Klass";
            this.btn3Klass.Size = new System.Drawing.Size(148, 54);
            this.btn3Klass.TabIndex = 10;
            this.btn3Klass.Text = "3 класс";
            this.btn3Klass.UseVisualStyleBackColor = false;
            this.btn3Klass.Click += new System.EventHandler(this.btn3Klass_Click);
            // 
            // btn4Klass
            // 
            this.btn4Klass.BackColor = System.Drawing.Color.Maroon;
            this.btn4Klass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4Klass.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn4Klass.ForeColor = System.Drawing.Color.White;
            this.btn4Klass.Location = new System.Drawing.Point(447, 384);
            this.btn4Klass.Name = "btn4Klass";
            this.btn4Klass.Size = new System.Drawing.Size(148, 54);
            this.btn4Klass.TabIndex = 11;
            this.btn4Klass.Text = "4 класс";
            this.btn4Klass.UseVisualStyleBackColor = false;
            this.btn4Klass.Click += new System.EventHandler(this.btn4Klass_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(640, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 54);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn4Klass);
            this.Controls.Add(this.btn3Klass);
            this.Controls.Add(this.btn2Klass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2Klass;
        private System.Windows.Forms.Button btn3Klass;
        private System.Windows.Forms.Button btn4Klass;
        private System.Windows.Forms.Button btnExit;
    }
}

