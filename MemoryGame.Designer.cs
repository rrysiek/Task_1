
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
            this.lConfirmation = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBFileData = new System.Windows.Forms.TextBox();
            this.lRecordsQuantity = new System.Windows.Forms.Label();
            this.lConf_OK = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectEasyLevel = new System.Windows.Forms.RadioButton();
            this.SelecHardLevel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Before starting, please choose the difficulty level:";
            // 
            // SelectEasyLevel
            // 
            this.SelectEasyLevel.AutoSize = true;
            this.SelectEasyLevel.Location = new System.Drawing.Point(402, 70);
            this.SelectEasyLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectEasyLevel.Name = "SelectEasyLevel";
            this.SelectEasyLevel.Size = new System.Drawing.Size(322, 24);
            this.SelectEasyLevel.TabIndex = 8;
            this.SelectEasyLevel.TabStop = true;
            this.SelectEasyLevel.Text = "Easy level, you have to guess 4 word pairs";
            this.SelectEasyLevel.UseVisualStyleBackColor = true;
            this.SelectEasyLevel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SelecHardLevel
            // 
            this.SelecHardLevel.AutoSize = true;
            this.SelecHardLevel.Location = new System.Drawing.Point(402, 129);
            this.SelecHardLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelecHardLevel.Name = "SelecHardLevel";
            this.SelecHardLevel.Size = new System.Drawing.Size(326, 24);
            this.SelecHardLevel.TabIndex = 9;
            this.SelecHardLevel.TabStop = true;
            this.SelecHardLevel.Text = "Hard level , you have to guess 8 word pairs";
            this.SelecHardLevel.UseVisualStyleBackColor = true;
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2175, 1075);
            this.Controls.Add(this.SelecHardLevel);
            this.Controls.Add(this.SelectEasyLevel);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label lConfirmation;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBFileData;
        private System.Windows.Forms.Label lRecordsQuantity;
        private System.Windows.Forms.Label lConf_OK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SelectEasyLevel;
        private System.Windows.Forms.RadioButton SelecHardLevel;
    }
}

