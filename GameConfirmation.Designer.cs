
namespace Task_1
{
    partial class GameConfirmation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeSolving = new System.Windows.Forms.Label();
            this.GuessedChances = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.SuccesRemember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(286, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guessing time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guessed chances used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "You have been solved level";
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(505, 468);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(80, 35);
            this.yes.TabIndex = 4;
            this.yes.Text = "YES";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(610, 468);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(80, 35);
            this.no.TabIndex = 5;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "ready for next play?";
            // 
            // TimeSolving
            // 
            this.TimeSolving.AutoSize = true;
            this.TimeSolving.Location = new System.Drawing.Point(470, 218);
            this.TimeSolving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeSolving.Name = "TimeSolving";
            this.TimeSolving.Size = new System.Drawing.Size(24, 20);
            this.TimeSolving.TabIndex = 7;
            this.TimeSolving.Text = "---";
            // 
            // GuessedChances
            // 
            this.GuessedChances.AutoSize = true;
            this.GuessedChances.Location = new System.Drawing.Point(470, 166);
            this.GuessedChances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuessedChances.Name = "GuessedChances";
            this.GuessedChances.Size = new System.Drawing.Size(24, 20);
            this.GuessedChances.TabIndex = 8;
            this.GuessedChances.Text = "---";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(470, 114);
            this.Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(24, 20);
            this.Level.TabIndex = 9;
            this.Level.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "write name for remember this score";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(60, 89);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(264, 26);
            this.PlayerName.TabIndex = 11;
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            // 
            // SuccesRemember
            // 
            this.SuccesRemember.Enabled = false;
            this.SuccesRemember.Location = new System.Drawing.Point(112, 141);
            this.SuccesRemember.Name = "SuccesRemember";
            this.SuccesRemember.Size = new System.Drawing.Size(160, 35);
            this.SuccesRemember.TabIndex = 12;
            this.SuccesRemember.Text = "save score";
            this.SuccesRemember.UseVisualStyleBackColor = true;
            this.SuccesRemember.Click += new System.EventHandler(this.SuccesRemember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SuccesRemember);
            this.groupBox1.Location = new System.Drawing.Point(61, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "save your score";
            // 
            // GameConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.GuessedChances);
            this.Controls.Add(this.TimeSolving);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameConfirmation";
            this.Text = "Game confirmation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label GuessedChances;
        public System.Windows.Forms.Label Level;
        public System.Windows.Forms.Label TimeSolving;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button SuccesRemember;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}