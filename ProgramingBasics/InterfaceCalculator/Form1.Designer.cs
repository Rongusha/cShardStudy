﻿namespace InterfaceCalculator
{
    partial class Form1
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
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.AccessibleName = "Box1";
            this.Box1.Location = new System.Drawing.Point(30, 48);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 0;
            // 
            // Box2
            // 
            this.Box2.AccessibleName = "Box2";
            this.Box2.Location = new System.Drawing.Point(183, 48);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 20);
            this.Box2.TabIndex = 1;
            // 
            // Suma
            // 
            this.Suma.AccessibleDescription = "Suma";
            this.Suma.AccessibleName = "Suma";
            this.Suma.Location = new System.Drawing.Point(415, 48);
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Size = new System.Drawing.Size(100, 20);
            this.Suma.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Смятай Мършо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(299, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 167);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Суматор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Suma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

