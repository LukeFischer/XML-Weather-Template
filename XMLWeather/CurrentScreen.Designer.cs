namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.lowOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.weatherOuput = new System.Windows.Forms.Label();
            this.updateOutput = new System.Windows.Forms.Label();
            this.highOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(23, 66);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(212, 36);
            this.cityOutput.TabIndex = 22;
            // 
            // lowOutput
            // 
            this.lowOutput.BackColor = System.Drawing.Color.Transparent;
            this.lowOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowOutput.ForeColor = System.Drawing.Color.Cyan;
            this.lowOutput.Location = new System.Drawing.Point(140, 330);
            this.lowOutput.Name = "lowOutput";
            this.lowOutput.Size = new System.Drawing.Size(113, 33);
            this.lowOutput.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(18, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "Low";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Red;
            this.maxLabel.Location = new System.Drawing.Point(18, 265);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(79, 33);
            this.maxLabel.TabIndex = 29;
            this.maxLabel.Text = "High";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.Black;
            this.currentOutput.Location = new System.Drawing.Point(343, 186);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(99, 33);
            this.currentOutput.TabIndex = 28;
            // 
            // currentTemp
            // 
            this.currentTemp.AutoSize = true;
            this.currentTemp.BackColor = System.Drawing.Color.Transparent;
            this.currentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.ForeColor = System.Drawing.Color.Black;
            this.currentTemp.Location = new System.Drawing.Point(20, 186);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(306, 33);
            this.currentTemp.TabIndex = 26;
            this.currentTemp.Text = "Current Temperature";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.Black;
            this.todayLabel.Location = new System.Drawing.Point(21, 14);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(83, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(141, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(156, 66);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(100, 36);
            this.countryLabel.TabIndex = 43;
            // 
            // weatherOuput
            // 
            this.weatherOuput.BackColor = System.Drawing.Color.Transparent;
            this.weatherOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherOuput.Location = new System.Drawing.Point(20, 125);
            this.weatherOuput.Name = "weatherOuput";
            this.weatherOuput.Size = new System.Drawing.Size(403, 36);
            this.weatherOuput.TabIndex = 44;
            // 
            // updateOutput
            // 
            this.updateOutput.BackColor = System.Drawing.Color.Transparent;
            this.updateOutput.Location = new System.Drawing.Point(287, 368);
            this.updateOutput.Name = "updateOutput";
            this.updateOutput.Size = new System.Drawing.Size(233, 32);
            this.updateOutput.TabIndex = 45;
            // 
            // highOutput
            // 
            this.highOutput.BackColor = System.Drawing.Color.Transparent;
            this.highOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highOutput.ForeColor = System.Drawing.Color.Red;
            this.highOutput.Location = new System.Drawing.Point(140, 253);
            this.highOutput.Name = "highOutput";
            this.highOutput.Size = new System.Drawing.Size(147, 45);
            this.highOutput.TabIndex = 30;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::XMLWeather.Properties.Resources._1;
            this.Controls.Add(this.updateOutput);
            this.Controls.Add(this.weatherOuput);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.lowOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.currentTemp);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label lowOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label weatherOuput;
        private System.Windows.Forms.Label updateOutput;
    }
}
