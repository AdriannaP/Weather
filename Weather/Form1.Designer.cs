namespace Weather
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
            this.staticText = new System.Windows.Forms.Label();
            this.textBox_inputCity = new System.Windows.Forms.TextBox();
            this.label_cityName = new System.Windows.Forms.Label();
            this.label_temperature = new System.Windows.Forms.Label();
            this.label_skyCondition = new System.Windows.Forms.Label();
            this.label_pressure = new System.Windows.Forms.Label();
            this.label_pressureValue = new System.Windows.Forms.Label();
            this.label_skyConditionValue = new System.Windows.Forms.Label();
            this.label_temperatureValue = new System.Windows.Forms.Label();
            this.label_cityNameValue = new System.Windows.Forms.Label();
            this.button_checkWeather = new System.Windows.Forms.Button();
            this.button_startSave = new System.Windows.Forms.Button();
            this.button_stopSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // staticText
            // 
            this.staticText.AutoSize = true;
            this.staticText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticText.Location = new System.Drawing.Point(12, 27);
            this.staticText.Name = "staticText";
            this.staticText.Size = new System.Drawing.Size(208, 32);
            this.staticText.TabIndex = 1;
            this.staticText.Text = "Enter your city";
            // 
            // textBox_inputCity
            // 
            this.textBox_inputCity.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputCity.Location = new System.Drawing.Point(12, 73);
            this.textBox_inputCity.Multiline = true;
            this.textBox_inputCity.Name = "textBox_inputCity";
            this.textBox_inputCity.Size = new System.Drawing.Size(336, 45);
            this.textBox_inputCity.TabIndex = 2;
            // 
            // label_cityName
            // 
            this.label_cityName.AutoSize = true;
            this.label_cityName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cityName.Location = new System.Drawing.Point(12, 133);
            this.label_cityName.Name = "label_cityName";
            this.label_cityName.Size = new System.Drawing.Size(67, 32);
            this.label_cityName.TabIndex = 3;
            this.label_cityName.Text = "City";
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature.Location = new System.Drawing.Point(141, 133);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(182, 32);
            this.label_temperature.TabIndex = 4;
            this.label_temperature.Text = "Temperature";
            // 
            // label_skyCondition
            // 
            this.label_skyCondition.AutoSize = true;
            this.label_skyCondition.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_skyCondition.Location = new System.Drawing.Point(383, 133);
            this.label_skyCondition.Name = "label_skyCondition";
            this.label_skyCondition.Size = new System.Drawing.Size(201, 32);
            this.label_skyCondition.TabIndex = 5;
            this.label_skyCondition.Text = "Sky Condition";
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pressure.Location = new System.Drawing.Point(640, 133);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(132, 32);
            this.label_pressure.TabIndex = 6;
            this.label_pressure.Text = "Pressure";
            // 
            // label_pressureValue
            // 
            this.label_pressureValue.AutoSize = true;
            this.label_pressureValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pressureValue.ForeColor = System.Drawing.Color.Maroon;
            this.label_pressureValue.Location = new System.Drawing.Point(662, 202);
            this.label_pressureValue.Name = "label_pressureValue";
            this.label_pressureValue.Size = new System.Drawing.Size(0, 32);
            this.label_pressureValue.TabIndex = 10;
            // 
            // label_skyConditionValue
            // 
            this.label_skyConditionValue.AutoSize = true;
            this.label_skyConditionValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_skyConditionValue.ForeColor = System.Drawing.Color.Maroon;
            this.label_skyConditionValue.Location = new System.Drawing.Point(383, 202);
            this.label_skyConditionValue.Name = "label_skyConditionValue";
            this.label_skyConditionValue.Size = new System.Drawing.Size(0, 32);
            this.label_skyConditionValue.TabIndex = 9;
            // 
            // label_temperatureValue
            // 
            this.label_temperatureValue.AutoSize = true;
            this.label_temperatureValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperatureValue.ForeColor = System.Drawing.Color.Maroon;
            this.label_temperatureValue.Location = new System.Drawing.Point(178, 202);
            this.label_temperatureValue.Name = "label_temperatureValue";
            this.label_temperatureValue.Size = new System.Drawing.Size(0, 32);
            this.label_temperatureValue.TabIndex = 8;
            // 
            // label_cityNameValue
            // 
            this.label_cityNameValue.AutoSize = true;
            this.label_cityNameValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cityNameValue.ForeColor = System.Drawing.Color.Maroon;
            this.label_cityNameValue.Location = new System.Drawing.Point(13, 202);
            this.label_cityNameValue.Name = "label_cityNameValue";
            this.label_cityNameValue.Size = new System.Drawing.Size(0, 32);
            this.label_cityNameValue.TabIndex = 7;
            this.label_cityNameValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_checkWeather
            // 
            this.button_checkWeather.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_checkWeather.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkWeather.Location = new System.Drawing.Point(378, 73);
            this.button_checkWeather.Name = "button_checkWeather";
            this.button_checkWeather.Size = new System.Drawing.Size(133, 45);
            this.button_checkWeather.TabIndex = 11;
            this.button_checkWeather.Text = "Check";
            this.button_checkWeather.UseVisualStyleBackColor = false;
            this.button_checkWeather.Click += new System.EventHandler(this.button_checkWeather_Click);
            // 
            // button_startSave
            // 
            this.button_startSave.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_startSave.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_startSave.Location = new System.Drawing.Point(12, 277);
            this.button_startSave.Name = "button_startSave";
            this.button_startSave.Size = new System.Drawing.Size(311, 44);
            this.button_startSave.TabIndex = 12;
            this.button_startSave.Text = "Start Save";
            this.button_startSave.UseVisualStyleBackColor = false;
            this.button_startSave.Click += new System.EventHandler(this.button_startSave_Click);
            // 
            // button_stopSave
            // 
            this.button_stopSave.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_stopSave.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_stopSave.Location = new System.Drawing.Point(461, 277);
            this.button_stopSave.Name = "button_stopSave";
            this.button_stopSave.Size = new System.Drawing.Size(311, 44);
            this.button_stopSave.TabIndex = 13;
            this.button_stopSave.Text = "Stop Save";
            this.button_stopSave.UseVisualStyleBackColor = false;
            this.button_stopSave.Click += new System.EventHandler(this.button_stopSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(795, 328);
            this.Controls.Add(this.button_stopSave);
            this.Controls.Add(this.button_startSave);
            this.Controls.Add(this.button_checkWeather);
            this.Controls.Add(this.label_pressureValue);
            this.Controls.Add(this.label_skyConditionValue);
            this.Controls.Add(this.label_temperatureValue);
            this.Controls.Add(this.label_cityNameValue);
            this.Controls.Add(this.label_pressure);
            this.Controls.Add(this.label_skyCondition);
            this.Controls.Add(this.label_temperature);
            this.Controls.Add(this.label_cityName);
            this.Controls.Add(this.textBox_inputCity);
            this.Controls.Add(this.staticText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticText;
        private System.Windows.Forms.TextBox textBox_inputCity;
        private System.Windows.Forms.Label label_cityName;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.Label label_skyCondition;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.Label label_pressureValue;
        private System.Windows.Forms.Label label_skyConditionValue;
        private System.Windows.Forms.Label label_temperatureValue;
        private System.Windows.Forms.Label label_cityNameValue;
        private System.Windows.Forms.Button button_checkWeather;
        private System.Windows.Forms.Button button_startSave;
        private System.Windows.Forms.Button button_stopSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

