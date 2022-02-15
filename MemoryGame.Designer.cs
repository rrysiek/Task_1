
namespace Task_1
{
    partial class MemoryGame
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
            this.components = new System.ComponentModel.Container();
            this.lDifficultyLevelInfo = new System.Windows.Forms.Label();
            this.lGC = new System.Windows.Forms.Label();
            this.LeftChanches = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lTimer = new System.Windows.Forms.Label();
            this.Field2 = new System.Windows.Forms.Button();
            this.Field3 = new System.Windows.Forms.Button();
            this.Field4 = new System.Windows.Forms.Button();
            this.Field5 = new System.Windows.Forms.Button();
            this.Field6 = new System.Windows.Forms.Button();
            this.Field7 = new System.Windows.Forms.Button();
            this.Field8 = new System.Windows.Forms.Button();
            this.Field9 = new System.Windows.Forms.Button();
            this.Field10 = new System.Windows.Forms.Button();
            this.Field11 = new System.Windows.Forms.Button();
            this.Field12 = new System.Windows.Forms.Button();
            this.Field13 = new System.Windows.Forms.Button();
            this.Field14 = new System.Windows.Forms.Button();
            this.Field15 = new System.Windows.Forms.Button();
            this.Field16 = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.Button();
            this.NewGameSelection = new System.Windows.Forms.Button();
            this.PlayingTime = new System.Windows.Forms.Timer(this.components);
            this.HallOfFame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDifficultyLevelInfo
            // 
            this.lDifficultyLevelInfo.AutoSize = true;
            this.lDifficultyLevelInfo.Location = new System.Drawing.Point(328, 63);
            this.lDifficultyLevelInfo.Name = "lDifficultyLevelInfo";
            this.lDifficultyLevelInfo.Size = new System.Drawing.Size(58, 20);
            this.lDifficultyLevelInfo.TabIndex = 3;
            this.lDifficultyLevelInfo.Text = "Level:  ";
            // 
            // lGC
            // 
            this.lGC.AutoSize = true;
            this.lGC.Location = new System.Drawing.Point(328, 122);
            this.lGC.Name = "lGC";
            this.lGC.Size = new System.Drawing.Size(124, 20);
            this.lGC.TabIndex = 4;
            this.lGC.Text = "Guess chances:";
            // 
            // LeftChanches
            // 
            this.LeftChanches.AutoSize = true;
            this.LeftChanches.Location = new System.Drawing.Point(456, 122);
            this.LeftChanches.Name = "LeftChanches";
            this.LeftChanches.Size = new System.Drawing.Size(19, 20);
            this.LeftChanches.TabIndex = 5;
            this.LeftChanches.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "tic, tac, ...";
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Location = new System.Drawing.Point(694, 42);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(31, 20);
            this.lTimer.TabIndex = 1;
            this.lTimer.Text = "-- s";
            // 
            // Field2
            // 
            this.Field2.BackColor = System.Drawing.Color.LightGray;
            this.Field2.Location = new System.Drawing.Point(238, 235);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(155, 92);
            this.Field2.TabIndex = 7;
            this.Field2.TabStop = false;
            this.Field2.UseVisualStyleBackColor = false;
            this.Field2.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field2.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field3
            // 
            this.Field3.BackColor = System.Drawing.Color.LightGray;
            this.Field3.Location = new System.Drawing.Point(404, 235);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(155, 92);
            this.Field3.TabIndex = 8;
            this.Field3.TabStop = false;
            this.Field3.UseVisualStyleBackColor = false;
            this.Field3.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field3.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field4
            // 
            this.Field4.BackColor = System.Drawing.Color.LightGray;
            this.Field4.Location = new System.Drawing.Point(570, 235);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(155, 92);
            this.Field4.TabIndex = 9;
            this.Field4.TabStop = false;
            this.Field4.UseVisualStyleBackColor = false;
            this.Field4.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field4.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field5
            // 
            this.Field5.BackColor = System.Drawing.Color.LightGray;
            this.Field5.Location = new System.Drawing.Point(72, 336);
            this.Field5.Name = "Field5";
            this.Field5.Size = new System.Drawing.Size(155, 92);
            this.Field5.TabIndex = 10;
            this.Field5.TabStop = false;
            this.Field5.UseVisualStyleBackColor = false;
            this.Field5.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field5.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field6
            // 
            this.Field6.BackColor = System.Drawing.Color.LightGray;
            this.Field6.Location = new System.Drawing.Point(238, 336);
            this.Field6.Name = "Field6";
            this.Field6.Size = new System.Drawing.Size(155, 92);
            this.Field6.TabIndex = 11;
            this.Field6.TabStop = false;
            this.Field6.UseVisualStyleBackColor = false;
            this.Field6.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field6.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field7
            // 
            this.Field7.BackColor = System.Drawing.Color.LightGray;
            this.Field7.Location = new System.Drawing.Point(404, 336);
            this.Field7.Name = "Field7";
            this.Field7.Size = new System.Drawing.Size(155, 92);
            this.Field7.TabIndex = 12;
            this.Field7.TabStop = false;
            this.Field7.UseVisualStyleBackColor = false;
            this.Field7.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field7.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field8
            // 
            this.Field8.BackColor = System.Drawing.Color.LightGray;
            this.Field8.Location = new System.Drawing.Point(570, 336);
            this.Field8.Name = "Field8";
            this.Field8.Size = new System.Drawing.Size(155, 92);
            this.Field8.TabIndex = 13;
            this.Field8.TabStop = false;
            this.Field8.UseVisualStyleBackColor = false;
            this.Field8.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field8.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field9
            // 
            this.Field9.BackColor = System.Drawing.Color.LightGray;
            this.Field9.Location = new System.Drawing.Point(72, 437);
            this.Field9.Name = "Field9";
            this.Field9.Size = new System.Drawing.Size(155, 92);
            this.Field9.TabIndex = 14;
            this.Field9.TabStop = false;
            this.Field9.UseVisualStyleBackColor = false;
            this.Field9.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field9.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field10
            // 
            this.Field10.BackColor = System.Drawing.Color.LightGray;
            this.Field10.Location = new System.Drawing.Point(238, 437);
            this.Field10.Name = "Field10";
            this.Field10.Size = new System.Drawing.Size(155, 92);
            this.Field10.TabIndex = 15;
            this.Field10.TabStop = false;
            this.Field10.UseVisualStyleBackColor = false;
            this.Field10.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field10.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field11
            // 
            this.Field11.BackColor = System.Drawing.Color.LightGray;
            this.Field11.Location = new System.Drawing.Point(404, 437);
            this.Field11.Name = "Field11";
            this.Field11.Size = new System.Drawing.Size(155, 92);
            this.Field11.TabIndex = 16;
            this.Field11.TabStop = false;
            this.Field11.UseVisualStyleBackColor = false;
            this.Field11.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field11.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field12
            // 
            this.Field12.BackColor = System.Drawing.Color.LightGray;
            this.Field12.Location = new System.Drawing.Point(570, 437);
            this.Field12.Name = "Field12";
            this.Field12.Size = new System.Drawing.Size(155, 92);
            this.Field12.TabIndex = 17;
            this.Field12.TabStop = false;
            this.Field12.UseVisualStyleBackColor = false;
            this.Field12.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field12.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field13
            // 
            this.Field13.BackColor = System.Drawing.Color.LightGray;
            this.Field13.Location = new System.Drawing.Point(72, 538);
            this.Field13.Name = "Field13";
            this.Field13.Size = new System.Drawing.Size(155, 92);
            this.Field13.TabIndex = 18;
            this.Field13.TabStop = false;
            this.Field13.UseVisualStyleBackColor = false;
            this.Field13.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field13.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field14
            // 
            this.Field14.BackColor = System.Drawing.Color.LightGray;
            this.Field14.Location = new System.Drawing.Point(238, 538);
            this.Field14.Name = "Field14";
            this.Field14.Size = new System.Drawing.Size(155, 92);
            this.Field14.TabIndex = 19;
            this.Field14.TabStop = false;
            this.Field14.UseVisualStyleBackColor = false;
            this.Field14.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field14.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field15
            // 
            this.Field15.BackColor = System.Drawing.Color.LightGray;
            this.Field15.Location = new System.Drawing.Point(404, 538);
            this.Field15.Name = "Field15";
            this.Field15.Size = new System.Drawing.Size(155, 92);
            this.Field15.TabIndex = 20;
            this.Field15.TabStop = false;
            this.Field15.UseVisualStyleBackColor = false;
            this.Field15.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field15.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field16
            // 
            this.Field16.BackColor = System.Drawing.Color.LightGray;
            this.Field16.Location = new System.Drawing.Point(570, 538);
            this.Field16.Name = "Field16";
            this.Field16.Size = new System.Drawing.Size(155, 92);
            this.Field16.TabIndex = 21;
            this.Field16.TabStop = false;
            this.Field16.UseVisualStyleBackColor = false;
            this.Field16.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field16.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // Field1
            // 
            this.Field1.BackColor = System.Drawing.Color.LightGray;
            this.Field1.Location = new System.Drawing.Point(72, 235);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(155, 92);
            this.Field1.TabIndex = 6;
            this.Field1.TabStop = false;
            this.Field1.UseVisualStyleBackColor = false;
            this.Field1.Click += new System.EventHandler(this.FieldChooseClick);
            this.Field1.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            // 
            // NewGameSelection
            // 
            this.NewGameSelection.Location = new System.Drawing.Point(72, 42);
            this.NewGameSelection.Name = "NewGameSelection";
            this.NewGameSelection.Size = new System.Drawing.Size(109, 41);
            this.NewGameSelection.TabIndex = 0;
            this.NewGameSelection.TabStop = false;
            this.NewGameSelection.Text = "New game";
            this.NewGameSelection.UseVisualStyleBackColor = true;
            this.NewGameSelection.Click += new System.EventHandler(this.NewGameSelection_Click);
            // 
            // PlayingTime
            // 
            this.PlayingTime.Interval = 1000;
            this.PlayingTime.Tick += new System.EventHandler(this.PlayingTime_Tick);
            // 
            // HallOfFame
            // 
            this.HallOfFame.Location = new System.Drawing.Point(72, 101);
            this.HallOfFame.Name = "HallOfFame";
            this.HallOfFame.Size = new System.Drawing.Size(109, 41);
            this.HallOfFame.TabIndex = 22;
            this.HallOfFame.TabStop = false;
            this.HallOfFame.Text = "Hall of fame";
            this.HallOfFame.UseVisualStyleBackColor = true;
            this.HallOfFame.Click += new System.EventHandler(this.HallOfFame_Click);
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 714);
            this.Controls.Add(this.HallOfFame);
            this.Controls.Add(this.NewGameSelection);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.Field16);
            this.Controls.Add(this.Field15);
            this.Controls.Add(this.Field14);
            this.Controls.Add(this.Field13);
            this.Controls.Add(this.Field12);
            this.Controls.Add(this.Field11);
            this.Controls.Add(this.Field10);
            this.Controls.Add(this.Field9);
            this.Controls.Add(this.Field8);
            this.Controls.Add(this.Field7);
            this.Controls.Add(this.Field6);
            this.Controls.Add(this.Field5);
            this.Controls.Add(this.Field4);
            this.Controls.Add(this.Field3);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.lTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftChanches);
            this.Controls.Add(this.lGC);
            this.Controls.Add(this.lDifficultyLevelInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MemoryGame";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDifficultyLevelInfo;
        private System.Windows.Forms.Label lGC;
        private System.Windows.Forms.Label LeftChanches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.Button Field2;
        private System.Windows.Forms.Button Field3;
        private System.Windows.Forms.Button Field4;
        private System.Windows.Forms.Button Field5;
        private System.Windows.Forms.Button Field6;
        private System.Windows.Forms.Button Field7;
        private System.Windows.Forms.Button Field8;
        private System.Windows.Forms.Button Field9;
        private System.Windows.Forms.Button Field10;
        private System.Windows.Forms.Button Field11;
        private System.Windows.Forms.Button Field12;
        private System.Windows.Forms.Button Field13;
        private System.Windows.Forms.Button Field14;
        private System.Windows.Forms.Button Field15;
        private System.Windows.Forms.Button Field16;
        private System.Windows.Forms.Button Field1;
        private System.Windows.Forms.Button NewGameSelection;
        private System.Windows.Forms.Timer PlayingTime;
        private System.Windows.Forms.Button HallOfFame;
    }
}

