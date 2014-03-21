namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addition = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.inputNomberTwo = new System.Windows.Forms.TextBox();
            this.inputNomberOne = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(12, 126);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 0;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(163, 155);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 1;
            this.divide.Text = "Деление";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(12, 155);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(75, 23);
            this.subtraction.TabIndex = 2;
            this.subtraction.Text = "Вычитание";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(163, 126);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 3;
            this.multiplication.Text = "Умножение";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // inputNomberTwo
            // 
            this.inputNomberTwo.Location = new System.Drawing.Point(12, 38);
            this.inputNomberTwo.Name = "inputNomberTwo";
            this.inputNomberTwo.Size = new System.Drawing.Size(260, 20);
            this.inputNomberTwo.TabIndex = 4;
            // 
            // inputNomberOne
            // 
            this.inputNomberOne.Location = new System.Drawing.Point(12, 12);
            this.inputNomberOne.Name = "inputNomberOne";
            this.inputNomberOne.Size = new System.Drawing.Size(260, 20);
            this.inputNomberOne.TabIndex = 5;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(12, 64);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(260, 20);
            this.res.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.res);
            this.Controls.Add(this.inputNomberOne);
            this.Controls.Add(this.inputNomberTwo);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.TextBox inputNomberTwo;
        private System.Windows.Forms.TextBox inputNomberOne;
        private System.Windows.Forms.TextBox res;
    }
}

