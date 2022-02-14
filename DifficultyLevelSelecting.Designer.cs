
namespace Task_1
{
    partial class DifficultyLevelSelecting
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirmation_Button = new System.Windows.Forms.Button();
            this.SelectEasyLevel = new System.Windows.Forms.CheckBox();
            this.SelectHardLevel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Before starting, please choose the difficulty level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "you have to guess 4 word pairs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "you have 10 chances to reveall all memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "you have 15 chances to reveall all memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "you have to guess 4 word pairs";
            // 
            // Confirmation_Button
            // 
            this.Confirmation_Button.Enabled = false;
            this.Confirmation_Button.Location = new System.Drawing.Point(331, 346);
            this.Confirmation_Button.Name = "Confirmation_Button";
            this.Confirmation_Button.Size = new System.Drawing.Size(230, 90);
            this.Confirmation_Button.TabIndex = 19;
            this.Confirmation_Button.Text = "Confirm";
            this.Confirmation_Button.UseVisualStyleBackColor = true;
            this.Confirmation_Button.Click += new System.EventHandler(this.Confirmation_Button_Click);
            // 
            // SelectEasyLevel
            // 
            this.SelectEasyLevel.AccessibleDescription = "";
            this.SelectEasyLevel.AutoSize = true;
            this.SelectEasyLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectEasyLevel.Location = new System.Drawing.Point(152, 152);
            this.SelectEasyLevel.Name = "SelectEasyLevel";
            this.SelectEasyLevel.Size = new System.Drawing.Size(133, 25);
            this.SelectEasyLevel.TabIndex = 20;
            this.SelectEasyLevel.Text = "EASY LEVEL";
            this.SelectEasyLevel.UseVisualStyleBackColor = true;
            this.SelectEasyLevel.CheckedChanged += new System.EventHandler(this.SelectEasyLevel_CheckedChanged_1);
            // 
            // SelectHardLevel
            // 
            this.SelectHardLevel.AccessibleDescription = "";
            this.SelectHardLevel.AutoSize = true;
            this.SelectHardLevel.Location = new System.Drawing.Point(588, 152);
            this.SelectHardLevel.Name = "SelectHardLevel";
            this.SelectHardLevel.Size = new System.Drawing.Size(130, 24);
            this.SelectHardLevel.TabIndex = 21;
            this.SelectHardLevel.Text = "HARD LEVEL";
            this.SelectHardLevel.UseVisualStyleBackColor = true;
            this.SelectHardLevel.CheckedChanged += new System.EventHandler(this.SelectHardLevel_CheckedChanged_1);
            // 
            // DifficultyLevelSelecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.SelectHardLevel);
            this.Controls.Add(this.SelectEasyLevel);
            this.Controls.Add(this.Confirmation_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DifficultyLevelSelecting";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "choosing difficulty level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Confirmation_Button;
        private System.Windows.Forms.CheckBox SelectEasyLevel;
        private System.Windows.Forms.CheckBox SelectHardLevel;
    }
}