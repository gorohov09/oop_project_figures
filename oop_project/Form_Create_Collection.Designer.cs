﻿
namespace oop_project
{
    partial class Form_Create_Collection
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
            this.textBoxCountEl = new System.Windows.Forms.TextBox();
            this.buttonCreateColl = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите кол-во элементов";
            // 
            // textBoxCountEl
            // 
            this.textBoxCountEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountEl.Location = new System.Drawing.Point(267, 58);
            this.textBoxCountEl.Name = "textBoxCountEl";
            this.textBoxCountEl.Size = new System.Drawing.Size(133, 28);
            this.textBoxCountEl.TabIndex = 2;
            // 
            // buttonCreateColl
            // 
            this.buttonCreateColl.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCreateColl.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreateColl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateColl.Location = new System.Drawing.Point(243, 154);
            this.buttonCreateColl.Name = "buttonCreateColl";
            this.buttonCreateColl.Size = new System.Drawing.Size(144, 43);
            this.buttonCreateColl.TabIndex = 3;
            this.buttonCreateColl.Text = "Создать";
            this.buttonCreateColl.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Info;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(55, 154);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 43);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // Form_Create_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 282);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCreateColl);
            this.Controls.Add(this.textBoxCountEl);
            this.Controls.Add(this.label1);
            this.Name = "Form_Create_Collection";
            this.Text = "Form_Create_Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxCountEl;
        private System.Windows.Forms.Button buttonCreateColl;
        private System.Windows.Forms.Button buttonClose;
    }
}