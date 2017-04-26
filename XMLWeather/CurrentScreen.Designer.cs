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
            this.todayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.weatherOuput = new System.Windows.Forms.Label();
            this.updateOutput = new System.Windows.Forms.Label();
            this.highOutput = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(23, 90);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(0, 33);
            this.cityOutput.TabIndex = 22;
            // 
            // lowOutput
            // 
            this.lowOutput.BackColor = System.Drawing.Color.Transparent;
            this.lowOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowOutput.ForeColor = System.Drawing.Color.Blue;
            this.lowOutput.Location = new System.Drawing.Point(370, 341);
            this.lowOutput.Name = "lowOutput";
            this.lowOutput.Size = new System.Drawing.Size(113, 33);
            this.lowOutput.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(278, 341);
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
            this.maxLabel.Location = new System.Drawing.Point(18, 341);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(79, 33);
            this.maxLabel.TabIndex = 29;
            this.maxLabel.Text = "High";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.Black;
            this.currentOutput.Location = new System.Drawing.Point(251, 42);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(246, 169);
            this.currentOutput.TabIndex = 28;
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
            // weatherOuput
            // 
            this.weatherOuput.BackColor = System.Drawing.Color.Transparent;
            this.weatherOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherOuput.Location = new System.Drawing.Point(21, 172);
            this.weatherOuput.Name = "weatherOuput";
            this.weatherOuput.Size = new System.Drawing.Size(215, 36);
            this.weatherOuput.TabIndex = 44;
            // 
            // updateOutput
            // 
            this.updateOutput.BackColor = System.Drawing.Color.Transparent;
            this.updateOutput.Location = new System.Drawing.Point(264, 10);
            this.updateOutput.Name = "updateOutput";
            this.updateOutput.Size = new System.Drawing.Size(233, 32);
            this.updateOutput.TabIndex = 45;
            // 
            // highOutput
            // 
            this.highOutput.BackColor = System.Drawing.Color.Transparent;
            this.highOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highOutput.ForeColor = System.Drawing.Color.Red;
            this.highOutput.Location = new System.Drawing.Point(109, 341);
            this.highOutput.Name = "highOutput";
            this.highOutput.Size = new System.Drawing.Size(147, 45);
            this.highOutput.TabIndex = 30;
            // 
            // humidityOutput
            // 
            this.humidityOutput.AutoSize = true;
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.Location = new System.Drawing.Point(24, 263);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(0, 25);
            this.humidityOutput.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "label1";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::XMLWeather.Properties.Resources._1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.updateOutput);
            this.Controls.Add(this.weatherOuput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.lowOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.currentOutput);
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
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label weatherOuput;
        private System.Windows.Forms.Label updateOutput;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label label1;
    }
}
