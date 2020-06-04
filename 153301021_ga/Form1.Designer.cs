namespace _GA_rosenbrock
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_pen = new System.Windows.Forms.NumericUpDown();
            this.num_sec = new System.Windows.Forms.NumericUpDown();
            this.num_mut = new System.Windows.Forms.NumericUpDown();
            this.num_cap = new System.Windows.Forms.NumericUpDown();
            this.num_pop = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_jen = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chart_ga = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_basla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_pen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_pen);
            this.groupBox1.Controls.Add(this.num_sec);
            this.groupBox1.Controls.Add(this.num_mut);
            this.groupBox1.Controls.Add(this.num_cap);
            this.groupBox1.Controls.Add(this.num_pop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // num_pen
            // 
            this.num_pen.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_pen.Location = new System.Drawing.Point(155, 111);
            this.num_pen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_pen.Name = "num_pen";
            this.num_pen.Size = new System.Drawing.Size(98, 20);
            this.num_pen.TabIndex = 1;
            this.num_pen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_pen.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // num_sec
            // 
            this.num_sec.Location = new System.Drawing.Point(155, 90);
            this.num_sec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_sec.Name = "num_sec";
            this.num_sec.Size = new System.Drawing.Size(98, 20);
            this.num_sec.TabIndex = 1;
            this.num_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_sec.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num_mut
            // 
            this.num_mut.DecimalPlaces = 4;
            this.num_mut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.num_mut.Location = new System.Drawing.Point(155, 64);
            this.num_mut.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_mut.Name = "num_mut";
            this.num_mut.Size = new System.Drawing.Size(98, 20);
            this.num_mut.TabIndex = 1;
            this.num_mut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_mut.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // num_cap
            // 
            this.num_cap.DecimalPlaces = 2;
            this.num_cap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_cap.Location = new System.Drawing.Point(155, 41);
            this.num_cap.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_cap.Name = "num_cap";
            this.num_cap.Size = new System.Drawing.Size(98, 20);
            this.num_cap.TabIndex = 1;
            this.num_cap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_cap.Value = new decimal(new int[] {
            70,
            0,
            0,
            131072});
            // 
            // num_pop
            // 
            this.num_pop.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_pop.Location = new System.Drawing.Point(155, 18);
            this.num_pop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_pop.Name = "num_pop";
            this.num_pop.Size = new System.Drawing.Size(98, 20);
            this.num_pop.TabIndex = 1;
            this.num_pop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_pop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Penalty Parametresi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seçkinlik:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mutasyon Oranı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çaprazlama Oranı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Populasyon Boyutu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_jen);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(31, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 89);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonlanma Ölçütü";
            // 
            // num_jen
            // 
            this.num_jen.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_jen.Location = new System.Drawing.Point(155, 59);
            this.num_jen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_jen.Name = "num_jen";
            this.num_jen.Size = new System.Drawing.Size(98, 20);
            this.num_jen.TabIndex = 1;
            this.num_jen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_jen.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(131, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "uygunluk değeri";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(10, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "iterasyon sayısı";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jenerasyon Sayısı:";
            // 
            // chart_ga
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ga.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ga.Legends.Add(legend1);
            this.chart_ga.Location = new System.Drawing.Point(307, 12);
            this.chart_ga.Name = "chart_ga";
            this.chart_ga.Size = new System.Drawing.Size(411, 298);
            this.chart_ga.TabIndex = 1;
            this.chart_ga.Text = "chart1";
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(307, 316);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(411, 37);
            this.btn_basla.TabIndex = 2;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_GA_rosenbrock.Properties.Resources.rosenbrock;
            this.pictureBox1.Location = new System.Drawing.Point(26, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(724, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 342);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 365);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.chart_ga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_pen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ga;
        private System.Windows.Forms.NumericUpDown num_pop;
        private System.Windows.Forms.NumericUpDown num_pen;
        private System.Windows.Forms.NumericUpDown num_sec;
        private System.Windows.Forms.NumericUpDown num_mut;
        private System.Windows.Forms.NumericUpDown num_cap;
        private System.Windows.Forms.NumericUpDown num_jen;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

