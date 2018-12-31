namespace WindowsFormsApp1
{
    partial class specialAbility
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
            this.btnAdvance = new System.Windows.Forms.Button();
            this.chose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(333, 267);
            this.btnAdvance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(112, 35);
            this.btnAdvance.TabIndex = 10;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // chose
            // 
            this.chose.AutoSize = true;
            this.chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chose.Location = new System.Drawing.Point(218, 95);
            this.chose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chose.Name = "chose";
            this.chose.Size = new System.Drawing.Size(26, 29);
            this.chose.TabIndex = 9;
            this.chose.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "How many squares do \r\nyou wish to advance?";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(176, 142);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 69);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // specialAbility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 422);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.chose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "specialAbility";
            this.Text = "specialAbility";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdvance;
        public System.Windows.Forms.Label chose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}