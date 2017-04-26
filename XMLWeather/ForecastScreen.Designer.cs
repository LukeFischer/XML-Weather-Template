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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOutput1 = new System.Windows.Forms.Label();
            this.dateOutput2 = new System.Windows.Forms.Label();
            this.dateOutput3 = new System.Windows.Forms.Label();
            this.dateOutput4 = new System.Windows.Forms.Label();
            this.dateOutput5 = new System.Windows.Forms.Label();
            this.dateOutput6 = new System.Windows.Forms.Label();
            this.maxLabel1 = new System.Windows.Forms.Label();
            this.maxLabel2 = new System.Windows.Forms.Label();
            this.maxLabel3 = new System.Windows.Forms.Label();
            this.maxLabel4 = new System.Windows.Forms.Label();
            this.maxLabel5 = new System.Windows.Forms.Label();
            this.maxLabel6 = new System.Windows.Forms.Label();
            this.minLabel1 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.minLabel4 = new System.Windows.Forms.Label();
            this.minLabel5 = new System.Windows.Forms.Label();
            this.minLabel6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(3, 7);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 24);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cityOutput.Location = new System.Drawing.Point(313, 7);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(0, 33);
            this.cityOutput.TabIndex = 43;
            // 
            // minTemp
            // 
            this.minTemp.AutoSize = true;
            this.minTemp.BackColor = System.Drawing.Color.Transparent;
            this.minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp.ForeColor = System.Drawing.Color.Blue;
            this.minTemp.Location = new System.Drawing.Point(303, 58);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(68, 33);
            this.minTemp.TabIndex = 46;
            this.minTemp.Text = "Low";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Red;
            this.maxLabel.Location = new System.Drawing.Point(161, 58);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(75, 33);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "High";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutput1
            // 
            this.dateOutput1.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput1.Location = new System.Drawing.Point(15, 113);
            this.dateOutput1.Name = "dateOutput1";
            this.dateOutput1.Size = new System.Drawing.Size(90, 24);
            this.dateOutput1.TabIndex = 65;
            // 
            // dateOutput2
            // 
            this.dateOutput2.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput2.Location = new System.Drawing.Point(15, 165);
            this.dateOutput2.Name = "dateOutput2";
            this.dateOutput2.Size = new System.Drawing.Size(90, 21);
            this.dateOutput2.TabIndex = 69;
            // 
            // dateOutput3
            // 
            this.dateOutput3.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput3.Location = new System.Drawing.Point(15, 213);
            this.dateOutput3.Name = "dateOutput3";
            this.dateOutput3.Size = new System.Drawing.Size(100, 23);
            this.dateOutput3.TabIndex = 79;
            // 
            // dateOutput4
            // 
            this.dateOutput4.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput4.Location = new System.Drawing.Point(15, 254);
            this.dateOutput4.Name = "dateOutput4";
            this.dateOutput4.Size = new System.Drawing.Size(103, 26);
            this.dateOutput4.TabIndex = 80;
            // 
            // dateOutput5
            // 
            this.dateOutput5.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput5.Location = new System.Drawing.Point(15, 303);
            this.dateOutput5.Name = "dateOutput5";
            this.dateOutput5.Size = new System.Drawing.Size(100, 23);
            this.dateOutput5.TabIndex = 81;
            // 
            // dateOutput6
            // 
            this.dateOutput6.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOutput6.Location = new System.Drawing.Point(15, 349);
            this.dateOutput6.Name = "dateOutput6";
            this.dateOutput6.Size = new System.Drawing.Size(100, 23);
            this.dateOutput6.TabIndex = 82;
            // 
            // maxLabel1
            // 
            this.maxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel1.ForeColor = System.Drawing.Color.Red;
            this.maxLabel1.Location = new System.Drawing.Point(163, 113);
            this.maxLabel1.Name = "maxLabel1";
            this.maxLabel1.Size = new System.Drawing.Size(100, 23);
            this.maxLabel1.TabIndex = 84;
            // 
            // maxLabel2
            // 
            this.maxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel2.ForeColor = System.Drawing.Color.Red;
            this.maxLabel2.Location = new System.Drawing.Point(163, 165);
            this.maxLabel2.Name = "maxLabel2";
            this.maxLabel2.Size = new System.Drawing.Size(78, 26);
            this.maxLabel2.TabIndex = 85;
            // 
            // maxLabel3
            // 
            this.maxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel3.ForeColor = System.Drawing.Color.Red;
            this.maxLabel3.Location = new System.Drawing.Point(162, 213);
            this.maxLabel3.Name = "maxLabel3";
            this.maxLabel3.Size = new System.Drawing.Size(100, 23);
            this.maxLabel3.TabIndex = 86;
            // 
            // maxLabel4
            // 
            this.maxLabel4.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel4.ForeColor = System.Drawing.Color.Red;
            this.maxLabel4.Location = new System.Drawing.Point(163, 254);
            this.maxLabel4.Name = "maxLabel4";
            this.maxLabel4.Size = new System.Drawing.Size(73, 26);
            this.maxLabel4.TabIndex = 87;
            // 
            // maxLabel5
            // 
            this.maxLabel5.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel5.ForeColor = System.Drawing.Color.Red;
            this.maxLabel5.Location = new System.Drawing.Point(163, 303);
            this.maxLabel5.Name = "maxLabel5";
            this.maxLabel5.Size = new System.Drawing.Size(100, 23);
            this.maxLabel5.TabIndex = 88;
            // 
            // maxLabel6
            // 
            this.maxLabel6.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel6.ForeColor = System.Drawing.Color.Red;
            this.maxLabel6.Location = new System.Drawing.Point(163, 349);
            this.maxLabel6.Name = "maxLabel6";
            this.maxLabel6.Size = new System.Drawing.Size(100, 23);
            this.maxLabel6.TabIndex = 89;
            // 
            // minLabel1
            // 
            this.minLabel1.BackColor = System.Drawing.Color.Transparent;
            this.minLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel1.ForeColor = System.Drawing.Color.Blue;
            this.minLabel1.Location = new System.Drawing.Point(315, 121);
            this.minLabel1.Name = "minLabel1";
            this.minLabel1.Size = new System.Drawing.Size(72, 23);
            this.minLabel1.TabIndex = 91;
            // 
            // minLabel2
            // 
            this.minLabel2.BackColor = System.Drawing.Color.Transparent;
            this.minLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel2.ForeColor = System.Drawing.Color.Blue;
            this.minLabel2.Location = new System.Drawing.Point(314, 165);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(72, 26);
            this.minLabel2.TabIndex = 92;
            // 
            // minLabel3
            // 
            this.minLabel3.BackColor = System.Drawing.Color.Transparent;
            this.minLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel3.ForeColor = System.Drawing.Color.Blue;
            this.minLabel3.Location = new System.Drawing.Point(315, 213);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(57, 20);
            this.minLabel3.TabIndex = 93;
            // 
            // minLabel4
            // 
            this.minLabel4.BackColor = System.Drawing.Color.Transparent;
            this.minLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel4.ForeColor = System.Drawing.Color.Blue;
            this.minLabel4.Location = new System.Drawing.Point(315, 254);
            this.minLabel4.Name = "minLabel4";
            this.minLabel4.Size = new System.Drawing.Size(72, 25);
            this.minLabel4.TabIndex = 94;
            // 
            // minLabel5
            // 
            this.minLabel5.BackColor = System.Drawing.Color.Transparent;
            this.minLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel5.ForeColor = System.Drawing.Color.Blue;
            this.minLabel5.Location = new System.Drawing.Point(314, 303);
            this.minLabel5.Name = "minLabel5";
            this.minLabel5.Size = new System.Drawing.Size(72, 29);
            this.minLabel5.TabIndex = 95;
            // 
            // minLabel6
            // 
            this.minLabel6.BackColor = System.Drawing.Color.Transparent;
            this.minLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel6.ForeColor = System.Drawing.Color.Blue;
            this.minLabel6.Location = new System.Drawing.Point(315, 349);
            this.minLabel6.Name = "minLabel6";
            this.minLabel6.Size = new System.Drawing.Size(71, 23);
            this.minLabel6.TabIndex = 96;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.minLabel6);
            this.Controls.Add(this.minLabel5);
            this.Controls.Add(this.minLabel4);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.minLabel2);
            this.Controls.Add(this.minLabel1);
            this.Controls.Add(this.maxLabel6);
            this.Controls.Add(this.maxLabel5);
            this.Controls.Add(this.maxLabel4);
            this.Controls.Add(this.maxLabel3);
            this.Controls.Add(this.maxLabel2);
            this.Controls.Add(this.maxLabel1);
            this.Controls.Add(this.dateOutput6);
            this.Controls.Add(this.dateOutput5);
            this.Controls.Add(this.dateOutput4);
            this.Controls.Add(this.dateOutput3);
            this.Controls.Add(this.dateOutput2);
            this.Controls.Add(this.dateOutput1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minTemp);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minTemp;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateOutput1;
        private System.Windows.Forms.Label dateOutput2;
        private System.Windows.Forms.Label dateOutput3;
        private System.Windows.Forms.Label dateOutput4;
        private System.Windows.Forms.Label dateOutput5;
        private System.Windows.Forms.Label dateOutput6;
        private System.Windows.Forms.Label maxLabel1;
        private System.Windows.Forms.Label maxLabel2;
        private System.Windows.Forms.Label maxLabel3;
        private System.Windows.Forms.Label maxLabel4;
        private System.Windows.Forms.Label maxLabel5;
        private System.Windows.Forms.Label maxLabel6;
        private System.Windows.Forms.Label minLabel1;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.Label minLabel4;
        private System.Windows.Forms.Label minLabel5;
        private System.Windows.Forms.Label minLabel6;
    }
}
