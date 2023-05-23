
namespace Prac_16_2
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
            this.CapitalizedWords = new System.Windows.Forms.ListBox();
            this.LowerCaseWords = new System.Windows.Forms.ListBox();
            this.OutputBut = new System.Windows.Forms.Button();
            this.TextList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CapitalizedWords
            // 
            this.CapitalizedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapitalizedWords.FormattingEnabled = true;
            this.CapitalizedWords.ItemHeight = 16;
            this.CapitalizedWords.Location = new System.Drawing.Point(21, 213);
            this.CapitalizedWords.Name = "CapitalizedWords";
            this.CapitalizedWords.Size = new System.Drawing.Size(327, 228);
            this.CapitalizedWords.TabIndex = 0;
            // 
            // LowerCaseWords
            // 
            this.LowerCaseWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowerCaseWords.FormattingEnabled = true;
            this.LowerCaseWords.ItemHeight = 16;
            this.LowerCaseWords.Location = new System.Drawing.Point(461, 213);
            this.LowerCaseWords.Name = "LowerCaseWords";
            this.LowerCaseWords.Size = new System.Drawing.Size(327, 228);
            this.LowerCaseWords.TabIndex = 1;
            // 
            // OutputBut
            // 
            this.OutputBut.BackColor = System.Drawing.Color.Silver;
            this.OutputBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBut.Location = new System.Drawing.Point(354, 332);
            this.OutputBut.Name = "OutputBut";
            this.OutputBut.Size = new System.Drawing.Size(101, 66);
            this.OutputBut.TabIndex = 2;
            this.OutputBut.Text = "Вывести слова из файла";
            this.OutputBut.UseVisualStyleBackColor = false;
            this.OutputBut.Click += new System.EventHandler(this.OutputBut_Click);
            // 
            // TextList
            // 
            this.TextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextList.FormattingEnabled = true;
            this.TextList.ItemHeight = 16;
            this.TextList.Location = new System.Drawing.Point(21, 12);
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(767, 148);
            this.TextList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.OutputBut);
            this.Controls.Add(this.LowerCaseWords);
            this.Controls.Add(this.CapitalizedWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CapitalizedWords;
        private System.Windows.Forms.ListBox LowerCaseWords;
        private System.Windows.Forms.Button OutputBut;
        private System.Windows.Forms.ListBox TextList;
    }
}

