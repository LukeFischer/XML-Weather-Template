namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.maxTemp1 = new System.Windows.Forms.Label();
            this.minTemp1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.maximum2 = new System.Windows.Forms.Label();
            this.minimum2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.maximum1 = new System.Windows.Forms.Label();
            this.minimum1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(142, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(16, 90);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(71, 23);
            this.cityOutput.TabIndex = 43;
            this.cityOutput.Text = "City";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(15, 197);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(90, 13);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = " Min Temperature";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(16, 167);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(90, 13);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(16, 130);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 65;
            this.dateLabel.Text = "Date";
            // 
            // dateLabel2
            // 
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel2.Location = new System.Drawing.Point(16, 233);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(30, 13);
            this.dateLabel2.TabIndex = 69;
            this.dateLabel2.Text = "Date";
            // 
            // maxTemp1
            // 
            this.maxTemp1.AutoSize = true;
            this.maxTemp1.ForeColor = System.Drawing.SystemColors.Control;
            this.maxTemp1.Location = new System.Drawing.Point(16, 268);
            this.maxTemp1.Name = "maxTemp1";
            this.maxTemp1.Size = new System.Drawing.Size(90, 13);
            this.maxTemp1.TabIndex = 70;
            this.maxTemp1.Text = "Max Temperature";
            // 
            // minTemp1
            // 
            this.minTemp1.AutoSize = true;
            this.minTemp1.ForeColor = System.Drawing.SystemColors.Control;
            this.minTemp1.Location = new System.Drawing.Point(15, 302);
            this.minTemp1.Name = "minTemp1";
            this.minTemp1.Size = new System.Drawing.Size(86, 13);
            this.minTemp1.TabIndex = 71;
            this.minTemp1.Text = "min Temperature";
            // 
            // date2
            // 
            this.date2.ForeColor = System.Drawing.SystemColors.Control;
            this.date2.Location = new System.Drawing.Point(134, 223);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(91, 23);
            this.date2.TabIndex = 72;
            // 
            // maximum2
            // 
            this.maximum2.ForeColor = System.Drawing.SystemColors.Control;
            this.maximum2.Location = new System.Drawing.Point(144, 268);
            this.maximum2.Name = "maximum2";
            this.maximum2.Size = new System.Drawing.Size(72, 25);
            this.maximum2.TabIndex = 73;
            // 
            // minimum2
            // 
            this.minimum2.ForeColor = System.Drawing.SystemColors.Control;
            this.minimum2.Location = new System.Drawing.Point(144, 302);
            this.minimum2.Name = "minimum2";
            this.minimum2.Size = new System.Drawing.Size(78, 25);
            this.minimum2.TabIndex = 74;
            // 
            // date1
            // 
            this.date1.ForeColor = System.Drawing.SystemColors.Control;
            this.date1.Location = new System.Drawing.Point(131, 120);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(100, 23);
            this.date1.TabIndex = 75;
            // 
            // maximum1
            // 
            this.maximum1.ForeColor = System.Drawing.SystemColors.Control;
            this.maximum1.Location = new System.Drawing.Point(134, 157);
            this.maximum1.Name = "maximum1";
            this.maximum1.Size = new System.Drawing.Size(100, 23);
            this.maximum1.TabIndex = 76;
            // 
            // minimum1
            // 
            this.minimum1.ForeColor = System.Drawing.SystemColors.Control;
            this.minimum1.Location = new System.Drawing.Point(134, 197);
            this.minimum1.Name = "minimum1";
            this.minimum1.Size = new System.Drawing.Size(100, 23);
            this.minimum1.TabIndex = 77;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.minimum1);
            this.Controls.Add(this.maximum1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.minimum2);
            this.Controls.Add(this.maximum2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.minTemp1);
            this.Controls.Add(this.maxTemp1);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(298, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Label maxTemp1;
        private System.Windows.Forms.Label minTemp1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label maximum2;
        private System.Windows.Forms.Label minimum2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label maximum1;
        private System.Windows.Forms.Label minimum1;
    }
}
