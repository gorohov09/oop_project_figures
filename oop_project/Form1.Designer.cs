﻿
namespace oop_project
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
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.Create_Collection = new System.Windows.Forms.Button();
            this.Show_Collection = new System.Windows.Forms.Button();
            this.listBoxFigures = new System.Windows.Forms.ListBox();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureArea
            // 
            this.PictureArea.BackColor = System.Drawing.SystemColors.Window;
            this.PictureArea.Location = new System.Drawing.Point(454, 2);
            this.PictureArea.Margin = new System.Windows.Forms.Padding(4);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(710, 632);
            this.PictureArea.TabIndex = 0;
            this.PictureArea.TabStop = false;
            // 
            // Create_Collection
            // 
            this.Create_Collection.BackColor = System.Drawing.SystemColors.Info;
            this.Create_Collection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_Collection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Create_Collection.Location = new System.Drawing.Point(28, 49);
            this.Create_Collection.Name = "Create_Collection";
            this.Create_Collection.Size = new System.Drawing.Size(160, 45);
            this.Create_Collection.TabIndex = 1;
            this.Create_Collection.Text = "Создать массив";
            this.Create_Collection.UseVisualStyleBackColor = false;
            this.Create_Collection.Click += new System.EventHandler(this.Create_Collection_Click);
            // 
            // Show_Collection
            // 
            this.Show_Collection.BackColor = System.Drawing.SystemColors.Info;
            this.Show_Collection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_Collection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Show_Collection.Location = new System.Drawing.Point(28, 115);
            this.Show_Collection.Name = "Show_Collection";
            this.Show_Collection.Size = new System.Drawing.Size(160, 45);
            this.Show_Collection.TabIndex = 2;
            this.Show_Collection.Text = "Показать массив";
            this.Show_Collection.UseVisualStyleBackColor = false;
            this.Show_Collection.Click += new System.EventHandler(this.Show_Collection_Click);
            // 
            // listBoxFigures
            // 
            this.listBoxFigures.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxFigures.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFigures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxFigures.FormattingEnabled = true;
            this.listBoxFigures.ItemHeight = 23;
            this.listBoxFigures.Location = new System.Drawing.Point(212, 35);
            this.listBoxFigures.Name = "listBoxFigures";
            this.listBoxFigures.Size = new System.Drawing.Size(227, 349);
            this.listBoxFigures.TabIndex = 3;
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMove.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMove.Location = new System.Drawing.Point(28, 186);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(160, 45);
            this.buttonMove.TabIndex = 4;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 635);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.listBoxFigures);
            this.Controls.Add(this.Show_Collection);
            this.Controls.Add(this.Create_Collection);
            this.Controls.Add(this.PictureArea);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureArea;
        private System.Windows.Forms.Button Create_Collection;
        private System.Windows.Forms.Button Show_Collection;
        private System.Windows.Forms.ListBox listBoxFigures;
        private System.Windows.Forms.Button buttonMove;
    }
}

