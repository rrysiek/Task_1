
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
            this.SelecHardLevel = new System.Windows.Forms.RadioButton();
            this.SelectEasyLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelecHardLevel
            // 
            this.SelecHardLevel.AutoSize = true;
            this.SelecHardLevel.Location = new System.Drawing.Point(598, 168);
            this.SelecHardLevel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.SelecHardLevel.Name = "SelecHardLevel";
            this.SelecHardLevel.Size = new System.Drawing.Size(129, 24);
            this.SelecHardLevel.TabIndex = 12;
            this.SelecHardLevel.TabStop = true;
            this.SelecHardLevel.Text = "HARD LEVEL";
            this.SelecHardLevel.UseVisualStyleBackColor = true;
            // 
            // SelectEasyLevel
            // 
            this.SelectEasyLevel.AutoSize = true;
            this.SelectEasyLevel.Location = new System.Drawing.Point(148, 168);
            this.SelectEasyLevel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.SelectEasyLevel.Name = "SelectEasyLevel";
            this.SelectEasyLevel.Size = new System.Drawing.Size(126, 24);
            this.SelectEasyLevel.TabIndex = 11;
            this.SelectEasyLevel.TabStop = true;
            this.SelectEasyLevel.Text = "EASY LEVEL";
            this.SelectEasyLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Before starting, please choose the difficulty level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "you have to guess 4 word pairs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "you have 10 chances to reveall all memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "you have 15 chances to reveall all memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "you have to guess 4 word pairs";
            // 
            // DifficultyLevelSelecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelecHardLevel);
            this.Controls.Add(this.SelectEasyLevel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DifficultyLevelSelecting";
            this.Text = "choosing difficulty level";
            this.Load += new System.EventHandler(this.DifficultyLevelSelecting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SelecHardLevel;
        private System.Windows.Forms.RadioButton SelectEasyLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}