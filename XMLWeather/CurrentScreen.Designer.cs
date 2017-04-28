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
            this.label5 = new System.Windows.Forms.Label();
            this.todayL = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.wdirLabel = new System.Windows.Forms.Label();
            this.wddabel = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.windBox = new System.Windows.Forms.PictureBox();
            this.humBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.wdOutput = new System.Windows.Forms.Label();
            this.condiOutput = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "______________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // todayL
            // 
            this.todayL.BackColor = System.Drawing.Color.Transparent;
            this.todayL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayL.ForeColor = System.Drawing.Color.DarkViolet;
            this.todayL.Location = new System.Drawing.Point(16, 9);
            this.todayL.Name = "todayL";
            this.todayL.Size = new System.Drawing.Size(102, 28);
            this.todayL.TabIndex = 40;
            this.todayL.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(293, 9);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(113, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Tomorrow";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // wdirLabel
            // 
            this.wdirLabel.BackColor = System.Drawing.Color.Transparent;
            this.wdirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdirLabel.ForeColor = System.Drawing.Color.HotPink;
            this.wdirLabel.Location = new System.Drawing.Point(208, 352);
            this.wdirLabel.Name = "wdirLabel";
            this.wdirLabel.Size = new System.Drawing.Size(132, 32);
            this.wdirLabel.TabIndex = 98;
            this.wdirLabel.Text = "Condition";
            this.wdirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wddabel
            // 
            this.wddabel.AutoSize = true;
            this.wddabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wddabel.ForeColor = System.Drawing.Color.White;
            this.wddabel.Location = new System.Drawing.Point(262, 327);
            this.wddabel.Name = "wddabel";
            this.wddabel.Size = new System.Drawing.Size(50, 25);
            this.wddabel.TabIndex = 97;
            this.wddabel.Text = "13%";
            // 
            // humLabel
            // 
            this.humLabel.AutoSize = true;
            this.humLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humLabel.ForeColor = System.Drawing.Color.White;
            this.humLabel.Location = new System.Drawing.Point(138, 327);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(50, 25);
            this.humLabel.TabIndex = 96;
            this.humLabel.Text = "13%";
            // 
            // windBox
            // 
            this.windBox.BackgroundImage = global::XMLWeather.Properties.Resources.wdd;
            this.windBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windBox.Location = new System.Drawing.Point(219, 319);
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(50, 41);
            this.windBox.TabIndex = 95;
            this.windBox.TabStop = false;
            // 
            // humBox
            // 
            this.humBox.BackgroundImage = global::XMLWeather.Properties.Resources.humidity;
            this.humBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.humBox.Location = new System.Drawing.Point(100, 319);
            this.humBox.Name = "humBox";
            this.humBox.Size = new System.Drawing.Size(50, 41);
            this.humBox.TabIndex = 94;
            this.humBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 65);
            this.label2.TabIndex = 93;
            this.label2.Text = "|";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.ForestGreen;
            this.maxOutput.Location = new System.Drawing.Point(208, 223);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(80, 65);
            this.maxOutput.TabIndex = 92;
            this.maxOutput.Text = "22";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Orange;
            this.minOutput.Location = new System.Drawing.Point(70, 223);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(80, 65);
            this.minOutput.TabIndex = 91;
            this.minOutput.Text = "22";
            // 
            // currentImage
            // 
            this.currentImage.BackgroundImage = global::XMLWeather.Properties.Resources.overcast;
            this.currentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.currentImage.Location = new System.Drawing.Point(61, 89);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(110, 88);
            this.currentImage.TabIndex = 90;
            this.currentImage.TabStop = false;
            // 
            // wdOutput
            // 
            this.wdOutput.AutoSize = true;
            this.wdOutput.Location = new System.Drawing.Point(131, 314);
            this.wdOutput.Name = "wdOutput";
            this.wdOutput.Size = new System.Drawing.Size(35, 13);
            this.wdOutput.TabIndex = 89;
            this.wdOutput.Text = "label1";
            // 
            // condiOutput
            // 
            this.condiOutput.BackColor = System.Drawing.Color.Transparent;
            this.condiOutput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condiOutput.ForeColor = System.Drawing.Color.HotPink;
            this.condiOutput.Location = new System.Drawing.Point(75, 180);
            this.condiOutput.Name = "condiOutput";
            this.condiOutput.Size = new System.Drawing.Size(229, 43);
            this.condiOutput.TabIndex = 88;
            this.condiOutput.Text = "Condition";
            this.condiOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.condiOutput.UseWaitCursor = true;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(125, 35);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(174, 51);
            this.cityOutput.TabIndex = 83;
            this.cityOutput.Text = "Stratford";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(242, 288);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 87;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(102, 288);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 86;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(42, 264);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 85;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Segoe UI", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.tempLabel.Location = new System.Drawing.Point(155, 92);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(101, 82);
            this.tempLabel.TabIndex = 84;
            this.tempLabel.Text = "13";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.wdirLabel);
            this.Controls.Add(this.wddabel);
            this.Controls.Add(this.humLabel);
            this.Controls.Add(this.windBox);
            this.Controls.Add(this.humBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentImage);
            this.Controls.Add(this.wdOutput);
            this.Controls.Add(this.condiOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayL);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(420, 400);
            ((System.ComponentModel.ISupportInitialize)(this.windBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label todayL;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label wdirLabel;
        private System.Windows.Forms.Label wddabel;
        private System.Windows.Forms.Label humLabel;
        private System.Windows.Forms.PictureBox windBox;
        private System.Windows.Forms.PictureBox humBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.PictureBox currentImage;
        private System.Windows.Forms.Label wdOutput;
        private System.Windows.Forms.Label condiOutput;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
    }
}
