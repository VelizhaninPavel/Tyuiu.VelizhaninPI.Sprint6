
namespace Tyuiu.VelizhaninPI.Sprint6.Task0.V3
{
    partial class MainForm_VPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_VPI));
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.labelVarX = new System.Windows.Forms.Label();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutput = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxTaskInfo = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.buttonGetDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxDataInput.SuspendLayout();
            this.groupBoxDataOutput.SuspendLayout();
            this.groupBoxTaskInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.Controls.Add(this.labelVarX);
            this.groupBoxDataInput.Controls.Add(this.textBoxVarX);
            this.groupBoxDataInput.Location = new System.Drawing.Point(12, 278);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(570, 106);
            this.groupBoxDataInput.TabIndex = 0;
            this.groupBoxDataInput.TabStop = false;
            this.groupBoxDataInput.Text = "Ввод данных:";
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.Location = new System.Drawing.Point(7, 29);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(108, 17);
            this.labelVarX.TabIndex = 1;
            this.labelVarX.Text = "Переменная X:";
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(6, 52);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(109, 22);
            this.textBoxVarX.TabIndex = 0;
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxDataOutput
            // 
            this.groupBoxDataOutput.Controls.Add(this.labelResult);
            this.groupBoxDataOutput.Controls.Add(this.textBoxResult);
            this.groupBoxDataOutput.Location = new System.Drawing.Point(588, 278);
            this.groupBoxDataOutput.Name = "groupBoxDataOutput";
            this.groupBoxDataOutput.Size = new System.Drawing.Size(200, 106);
            this.groupBoxDataOutput.TabIndex = 1;
            this.groupBoxDataOutput.TabStop = false;
            this.groupBoxDataOutput.Text = "Вывод данных:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 29);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 17);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 52);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(186, 22);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxTaskInfo
            // 
            this.groupBoxTaskInfo.Controls.Add(this.textBoxTask);
            this.groupBoxTaskInfo.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTaskInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTaskInfo.Name = "groupBoxTaskInfo";
            this.groupBoxTaskInfo.Size = new System.Drawing.Size(776, 266);
            this.groupBoxTaskInfo.TabIndex = 2;
            this.groupBoxTaskInfo.TabStop = false;
            this.groupBoxTaskInfo.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(564, 76);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой.";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(633, 21);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(135, 76);
            this.pictureBoxFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula.TabIndex = 0;
            this.pictureBoxFormula.TabStop = false;
            // 
            // buttonGetDone
            // 
            this.buttonGetDone.Location = new System.Drawing.Point(645, 390);
            this.buttonGetDone.Name = "buttonGetDone";
            this.buttonGetDone.Size = new System.Drawing.Size(143, 48);
            this.buttonGetDone.TabIndex = 3;
            this.buttonGetDone.Text = "Выполнить";
            this.buttonGetDone.UseVisualStyleBackColor = true;
            this.buttonGetDone.Click += new System.EventHandler(this.buttonGetDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(588, 390);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(51, 48);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // MainForm_VPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonGetDone);
            this.Controls.Add(this.groupBoxTaskInfo);
            this.Controls.Add(this.groupBoxDataOutput);
            this.Controls.Add(this.groupBoxDataInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm_VPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Велижанин П.И";
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            this.groupBoxDataOutput.ResumeLayout(false);
            this.groupBoxDataOutput.PerformLayout();
            this.groupBoxTaskInfo.ResumeLayout(false);
            this.groupBoxTaskInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.GroupBox groupBoxDataOutput;
        private System.Windows.Forms.GroupBox groupBoxTaskInfo;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonGetDone;
        private System.Windows.Forms.Button buttonHelp;
    }
}

