namespace n09310032__rat1231
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
            // Form_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCLICK);
            this.Name = "Form_button";
            this.Text = "Form_button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCLICK;
    }
}