namespace TestRostelecom.Filter
{
    partial class FilterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "С:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По:";
            // 
            // firstDateTimePicker
            // 
            this.firstDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstDateTimePicker.Location = new System.Drawing.Point(13, 23);
            this.firstDateTimePicker.Name = "firstDateTimePicker";
            this.firstDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.firstDateTimePicker.TabIndex = 2;
            // 
            // secondDateTimePicker
            // 
            this.secondDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.secondDateTimePicker.Location = new System.Drawing.Point(128, 23);
            this.secondDateTimePicker.Name = "secondDateTimePicker";
            this.secondDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.secondDateTimePicker.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Применить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondDateTimePicker);
            this.Controls.Add(this.firstDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите даты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.DateTimePicker secondDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}