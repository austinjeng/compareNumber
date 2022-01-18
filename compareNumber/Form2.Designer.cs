
namespace compareNumber
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bigButton = new System.Windows.Forms.Button();
            this.smallButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.equalButton = new System.Windows.Forms.Button();
            this.replayButton = new System.Windows.Forms.Button();
            this.backToForm1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "你的數字是:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerNumberTextBox
            // 
            this.playerNumberTextBox.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerNumberTextBox.Location = new System.Drawing.Point(180, 44);
            this.playerNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerNumberTextBox.Multiline = true;
            this.playerNumberTextBox.Name = "playerNumberTextBox";
            this.playerNumberTextBox.Size = new System.Drawing.Size(61, 49);
            this.playerNumberTextBox.TabIndex = 2;
            this.playerNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(251, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "，你想猜大,小還是相等";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bigButton
            // 
            this.bigButton.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bigButton.Location = new System.Drawing.Point(16, 160);
            this.bigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(160, 150);
            this.bigButton.TabIndex = 4;
            this.bigButton.Text = "大";
            this.bigButton.UseVisualStyleBackColor = true;
            this.bigButton.Click += new System.EventHandler(this.bigButton_Click);
            // 
            // smallButton
            // 
            this.smallButton.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.smallButton.Location = new System.Drawing.Point(196, 160);
            this.smallButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(160, 150);
            this.smallButton.TabIndex = 5;
            this.smallButton.Text = "小";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.Click += new System.EventHandler(this.smallButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(104, 328);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(353, 64);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalButton.Location = new System.Drawing.Point(371, 160);
            this.equalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(168, 150);
            this.equalButton.TabIndex = 7;
            this.equalButton.Text = "相等";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(21, 454);
            this.replayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(135, 50);
            this.replayButton.TabIndex = 8;
            this.replayButton.Text = "再來一局";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // backToForm1Button
            // 
            this.backToForm1Button.Location = new System.Drawing.Point(21, 524);
            this.backToForm1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backToForm1Button.Name = "backToForm1Button";
            this.backToForm1Button.Size = new System.Drawing.Size(135, 50);
            this.backToForm1Button.TabIndex = 9;
            this.backToForm1Button.Text = "回主畫面";
            this.backToForm1Button.UseVisualStyleBackColor = true;
            this.backToForm1Button.Click += new System.EventHandler(this.backToForm1Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 589);
            this.Controls.Add(this.backToForm1Button);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.smallButton);
            this.Controls.Add(this.bigButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerNumberTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "比大小";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bigButton;
        private System.Windows.Forms.Button smallButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button backToForm1Button;
    }
}