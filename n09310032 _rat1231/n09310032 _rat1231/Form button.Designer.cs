﻿namespace n09310032__rat1231
{
    partial class Form_button
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
            this.BTNCLICK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNCLICK
            // 
            this.BTNCLICK.Location = new System.Drawing.Point(123, 91);
            this.BTNCLICK.Name = "BTNCLICK";
            this.BTNCLICK.Size = new System.Drawing.Size(145, 58);
            this.BTNCLICK.TabIndex = 0;
            this.BTNCLICK.Text = "按我啊幹等啥阿";
            this.BTNCLICK.UseVisualStyleBackColor = true;
            this.BTNCLICK.Click += new System.EventHandler(this.BTNCLICK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "加1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "減1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(482, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // Form_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNCLICK);
            this.Name = "Form_button";
            this.Text = "Form_button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCLICK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}