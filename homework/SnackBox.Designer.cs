namespace homework
{
    partial class SnackBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.count = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Yellow;
            this.name.Location = new System.Drawing.Point(30, 14);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 24);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.SnackBox_Click);
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.Yellow;
            this.price.Location = new System.Drawing.Point(30, 115);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(95, 34);
            this.price.TabIndex = 0;
            this.price.Text = "Price";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.price.Click += new System.EventHandler(this.SnackBox_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(30, 42);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(95, 69);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.SnackBox_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Enabled = false;
            this.count.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.count.ForeColor = System.Drawing.Color.Yellow;
            this.count.Location = new System.Drawing.Point(51, 153);
            this.count.Margin = new System.Windows.Forms.Padding(4);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(74, 23);
            this.count.TabIndex = 2;
            this.count.TabStop = true;
            this.count.Text = "Count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.SnackBox_Click);
            // 
            // SnackBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.count);
            this.Controls.Add(this.image);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnackBox";
            this.Size = new System.Drawing.Size(154, 182);
            this.Click += new System.EventHandler(this.SnackBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.PictureBox image;
        public System.Windows.Forms.RadioButton count;
    }
}
