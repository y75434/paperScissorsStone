
namespace WindowsFormsApp1
{
    partial class b
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.電腦 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.Label();
            this.computerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "剪刀";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "石頭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "布";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // 電腦
            // 
            this.電腦.AutoSize = true;
            this.電腦.Location = new System.Drawing.Point(105, 121);
            this.電腦.Name = "電腦";
            this.電腦.Size = new System.Drawing.Size(44, 18);
            this.電腦.TabIndex = 3;
            this.電腦.Text = "電腦";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "玩家";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(355, 13);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 18);
            this.player.TabIndex = 7;
            this.player.Text = "玩家";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(425, 13);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(16, 18);
            this.playerScore.TabIndex = 8;
            this.playerScore.Text = "0";
            // 
            // computer
            // 
            this.computer.AutoSize = true;
            this.computer.Location = new System.Drawing.Point(504, 12);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(44, 18);
            this.computer.TabIndex = 9;
            this.computer.Text = "電腦";
            // 
            // computerScore
            // 
            this.computerScore.AutoSize = true;
            this.computerScore.Location = new System.Drawing.Point(579, 12);
            this.computerScore.Name = "computerScore";
            this.computerScore.Size = new System.Drawing.Size(16, 18);
            this.computerScore.TabIndex = 10;
            this.computerScore.Text = "0";
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 375);
            this.Controls.Add(this.computerScore);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.電腦);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "b";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label 電腦;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label computer;
        private System.Windows.Forms.Label computerScore;
    }
}

