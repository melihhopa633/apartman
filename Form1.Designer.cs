namespace eberduman
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
            this.gelirler = new System.Windows.Forms.Button();
            this.giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gelirler
            // 
            this.gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirler.Location = new System.Drawing.Point(75, 78);
            this.gelirler.Name = "gelirler";
            this.gelirler.Size = new System.Drawing.Size(160, 267);
            this.gelirler.TabIndex = 0;
            this.gelirler.Text = "Gelirler";
            this.gelirler.UseVisualStyleBackColor = true;
            this.gelirler.Click += new System.EventHandler(this.button1_Click);
            // 
            // giderler
            // 
            this.giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderler.Location = new System.Drawing.Point(451, 78);
            this.giderler.Name = "giderler";
            this.giderler.Size = new System.Drawing.Size(160, 267);
            this.giderler.TabIndex = 1;
            this.giderler.Text = "Giderler";
            this.giderler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giderler);
            this.Controls.Add(this.gelirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gelirler;
        private System.Windows.Forms.Button giderler;
    }
}

