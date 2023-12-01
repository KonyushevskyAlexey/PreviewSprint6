
namespace WindowsFormsMyAppFirst
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonPushMe = new System.Windows.Forms.Button();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.labelVarB = new System.Windows.Forms.Label();
            this.labelVarA = new System.Windows.Forms.Label();
            this.textBoxVarB = new System.Windows.Forms.TextBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Button();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPushMe
            // 
            this.buttonPushMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPushMe.Location = new System.Drawing.Point(623, 34);
            this.buttonPushMe.Name = "buttonPushMe";
            this.buttonPushMe.Size = new System.Drawing.Size(160, 30);
            this.buttonPushMe.TabIndex = 0;
            this.buttonPushMe.Text = "Нажми меня";
            this.buttonPushMe.UseVisualStyleBackColor = true;
            this.buttonPushMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.radioButtonDiv);
            this.groupBoxInputData.Controls.Add(this.radioButtonMinus);
            this.groupBoxInputData.Controls.Add(this.radioButtonMult);
            this.groupBoxInputData.Controls.Add(this.radioButtonPlus);
            this.groupBoxInputData.Controls.Add(this.labelVarB);
            this.groupBoxInputData.Controls.Add(this.labelVarA);
            this.groupBoxInputData.Controls.Add(this.textBoxVarB);
            this.groupBoxInputData.Controls.Add(this.textBoxVarA);
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(275, 172);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных ";
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(217, 104);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(38, 24);
            this.radioButtonDiv.TabIndex = 2;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "/";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(216, 46);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(39, 24);
            this.radioButtonMinus.TabIndex = 2;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(148, 104);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(40, 24);
            this.radioButtonMult.TabIndex = 2;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "*";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(148, 45);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(43, 24);
            this.radioButtonPlus.TabIndex = 2;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // labelVarB
            // 
            this.labelVarB.AutoSize = true;
            this.labelVarB.Location = new System.Drawing.Point(11, 74);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(24, 20);
            this.labelVarB.TabIndex = 1;
            this.labelVarB.Text = "B:";
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(11, 22);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(24, 20);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "A:";
            // 
            // textBoxVarB
            // 
            this.textBoxVarB.Location = new System.Drawing.Point(15, 102);
            this.textBoxVarB.Name = "textBoxVarB";
            this.textBoxVarB.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarB.TabIndex = 0;
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(15, 45);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarA.TabIndex = 0;
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.labelResult);
            this.groupBoxOutPutData.Controls.Add(this.textBoxResult);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(12, 211);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(133, 93);
            this.groupBoxOutPutData.TabIndex = 2;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(89, 20);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 45);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(151, 246);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(136, 36);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 326);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 121);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1\r\n2\r\n3\r\n5\r\n6\r\n7\r\n8";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(283, 147);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Aqua;
            this.panelRight.Controls.Add(this.buttonPanel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(853, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(125, 576);
            this.panelRight.TabIndex = 6;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(20, 13);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(84, 41);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Text = "Кнопка";
            this.buttonPanel.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 576);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.buttonPushMe);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моё первое приложение под Windows";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPushMe;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.TextBox textBoxVarB;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonPanel;
    }
}

