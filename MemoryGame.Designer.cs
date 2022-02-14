
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
            this.l1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBFileData = new System.Windows.Forms.TextBox();
            this.lRecordsQuantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lConfirmation = new System.Windows.Forms.Label();
            this.lConf_OK = new System.Windows.Forms.Label();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(33, 222);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(122, 20);
            this.l1.TabIndex = 1;
            this.l1.Text = "records quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "file data";
            // 
            // tBFileData
            // 
            this.tBFileData.Location = new System.Drawing.Point(16, 555);
            this.tBFileData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBFileData.Multiline = true;
            this.tBFileData.Name = "tBFileData";
            this.tBFileData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBFileData.Size = new System.Drawing.Size(409, 370);
            this.tBFileData.TabIndex = 3;
            // 
            // lRecordsQuantity
            // 
            this.lRecordsQuantity.AutoSize = true;
            this.lRecordsQuantity.Location = new System.Drawing.Point(170, 220);
            this.lRecordsQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRecordsQuantity.Name = "lRecordsQuantity";
            this.lRecordsQuantity.Size = new System.Drawing.Size(66, 20);
            this.lRecordsQuantity.TabIndex = 4;
            this.lRecordsQuantity.Text = "records ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lConfirmation
            // 
            this.lConfirmation.AutoSize = true;
            this.lConfirmation.Location = new System.Drawing.Point(28, 180);
            this.lConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConfirmation.Name = "lConfirmation";
            this.lConfirmation.Size = new System.Drawing.Size(94, 20);
            this.lConfirmation.TabIndex = 0;
            this.lConfirmation.Text = "file readings";
            // 
            // lConf_OK
            // 
            this.lConf_OK.AutoSize = true;
            this.lConf_OK.Location = new System.Drawing.Point(170, 180);
            this.lConf_OK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConf_OK.Name = "lConf_OK";
            this.lConf_OK.Size = new System.Drawing.Size(91, 20);
            this.lConf_OK.TabIndex = 5;
            this.lConf_OK.Text = "odczyt pliku";
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(490, 555);
            this.tB2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB2.Multiline = true;
            this.tB2.Name = "tB2";
            this.tB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB2.Size = new System.Drawing.Size(409, 370);
            this.tB2.TabIndex = 7;
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 958);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lConf_OK);
            this.Controls.Add(this.lRecordsQuantity);
            this.Controls.Add(this.tBFileData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.lConfirmation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemoryGame";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBFileData;
        private System.Windows.Forms.Label lRecordsQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lConfirmation;
        private System.Windows.Forms.Label lConf_OK;
        private System.Windows.Forms.TextBox tB2;
    }
}

