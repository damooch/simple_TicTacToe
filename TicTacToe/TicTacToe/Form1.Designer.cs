namespace TicTacToe
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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.groupBoxGameStatus = new System.Windows.Forms.GroupBox();
            this.richTextBoxGameStatus = new System.Windows.Forms.RichTextBox();
            this.groupBoxGameStatistics = new System.Windows.Forms.GroupBox();
            this.richTextBoxGameStatistics = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelGame = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBoxGameStatus.SuspendLayout();
            this.groupBoxGameStatistics.SuspendLayout();
            this.tableLayoutPanelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.Blue;
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.ForeColor = System.Drawing.Color.White;
            this.startGameBtn.Location = new System.Drawing.Point(510, 73);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(112, 49);
            this.startGameBtn.TabIndex = 1;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // groupBoxGameStatus
            // 
            this.groupBoxGameStatus.Controls.Add(this.richTextBoxGameStatus);
            this.groupBoxGameStatus.Location = new System.Drawing.Point(28, 438);
            this.groupBoxGameStatus.Name = "groupBoxGameStatus";
            this.groupBoxGameStatus.Size = new System.Drawing.Size(396, 137);
            this.groupBoxGameStatus.TabIndex = 3;
            this.groupBoxGameStatus.TabStop = false;
            this.groupBoxGameStatus.Text = "Game Status";
            // 
            // richTextBoxGameStatus
            // 
            this.richTextBoxGameStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBoxGameStatus.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxGameStatus.Name = "richTextBoxGameStatus";
            this.richTextBoxGameStatus.Size = new System.Drawing.Size(384, 112);
            this.richTextBoxGameStatus.TabIndex = 0;
            this.richTextBoxGameStatus.Text = "";
            // 
            // groupBoxGameStatistics
            // 
            this.groupBoxGameStatistics.Controls.Add(this.richTextBoxGameStatistics);
            this.groupBoxGameStatistics.Location = new System.Drawing.Point(510, 148);
            this.groupBoxGameStatistics.Name = "groupBoxGameStatistics";
            this.groupBoxGameStatistics.Size = new System.Drawing.Size(308, 209);
            this.groupBoxGameStatistics.TabIndex = 4;
            this.groupBoxGameStatistics.TabStop = false;
            this.groupBoxGameStatistics.Text = "Game Statistics";
            // 
            // richTextBoxGameStatistics
            // 
            this.richTextBoxGameStatistics.BackColor = System.Drawing.Color.Lime;
            this.richTextBoxGameStatistics.Location = new System.Drawing.Point(0, 19);
            this.richTextBoxGameStatistics.Name = "richTextBoxGameStatistics";
            this.richTextBoxGameStatistics.Size = new System.Drawing.Size(308, 190);
            this.richTextBoxGameStatistics.TabIndex = 0;
            this.richTextBoxGameStatistics.Text = "";
            // 
            // tableLayoutPanelGame
            // 
            this.tableLayoutPanelGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelGame.ColumnCount = 3;
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelGame.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelGame.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelGame.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanelGame.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanelGame.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanelGame.Location = new System.Drawing.Point(28, 73);
            this.tableLayoutPanelGame.Name = "tableLayoutPanelGame";
            this.tableLayoutPanelGame.RowCount = 3;
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.Size = new System.Drawing.Size(396, 343);
            this.tableLayoutPanelGame.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 108);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(135, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 108);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(267, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 108);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 108);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(135, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 108);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(267, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 108);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 231);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 109);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(135, 231);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 109);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(267, 231);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 109);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetGame.Location = new System.Drawing.Point(606, 481);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(112, 37);
            this.buttonResetGame.TabIndex = 6;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = true;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(706, 73);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 49);
            this.button10.TabIndex = 7;
            this.button10.Text = "Start Game -vs- AI";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(881, 624);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.tableLayoutPanelGame);
            this.Controls.Add(this.groupBoxGameStatistics);
            this.Controls.Add(this.groupBoxGameStatus);
            this.Controls.Add(this.startGameBtn);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.groupBoxGameStatus.ResumeLayout(false);
            this.groupBoxGameStatistics.ResumeLayout(false);
            this.tableLayoutPanelGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.GroupBox groupBoxGameStatus;
        private System.Windows.Forms.RichTextBox richTextBoxGameStatus;
        private System.Windows.Forms.GroupBox groupBoxGameStatistics;
        private System.Windows.Forms.RichTextBox richTextBoxGameStatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.Button button10;
    }
}

