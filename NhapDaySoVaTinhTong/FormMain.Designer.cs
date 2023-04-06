namespace NhapDaySoVaTinhTong
{
    partial class FormMain
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
            this.label5 = new System.Windows.Forms.Label();
            this.textArray = new System.Windows.Forms.TextBox();
            this.textSum = new System.Windows.Forms.TextBox();
            this.textSumChan = new System.Windows.Forms.TextBox();
            this.textSumLe = new System.Windows.Forms.TextBox();
            this.BTNRun = new System.Windows.Forms.Button();
            this.BTNReset = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhấp Dãy Số và Tính Tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy số bạn vừa nhập là:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Chẵn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Lẻ:";
            // 
            // textArray
            // 
            this.textArray.Location = new System.Drawing.Point(40, 137);
            this.textArray.Name = "textArray";
            this.textArray.ReadOnly = true;
            this.textArray.Size = new System.Drawing.Size(177, 20);
            this.textArray.TabIndex = 5;
            this.textArray.TextChanged += new System.EventHandler(this.textArray_TextChanged);
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(236, 137);
            this.textSum.Name = "textSum";
            this.textSum.ReadOnly = true;
            this.textSum.Size = new System.Drawing.Size(39, 20);
            this.textSum.TabIndex = 6;
            // 
            // textSumChan
            // 
            this.textSumChan.Location = new System.Drawing.Point(106, 198);
            this.textSumChan.Name = "textSumChan";
            this.textSumChan.ReadOnly = true;
            this.textSumChan.Size = new System.Drawing.Size(54, 20);
            this.textSumChan.TabIndex = 7;
            // 
            // textSumLe
            // 
            this.textSumLe.Location = new System.Drawing.Point(239, 198);
            this.textSumLe.Name = "textSumLe";
            this.textSumLe.ReadOnly = true;
            this.textSumLe.Size = new System.Drawing.Size(39, 20);
            this.textSumLe.TabIndex = 8;
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(17, 251);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(143, 23);
            this.BTNRun.TabIndex = 9;
            this.BTNRun.Text = "Nhập Số và Tính Tổng";
            this.BTNRun.UseVisualStyleBackColor = true;
            this.BTNRun.Click += new System.EventHandler(this.BTNRun_Click);
            // 
            // BTNReset
            // 
            this.BTNReset.Location = new System.Drawing.Point(163, 251);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(75, 23);
            this.BTNReset.TabIndex = 10;
            this.BTNReset.Text = "Reset";
            this.BTNReset.UseVisualStyleBackColor = true;
            this.BTNReset.Click += new System.EventHandler(this.BTNReset_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(241, 251);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 11;
            this.BTNExit.Text = "Thoát";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 312);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.BTNRun);
            this.Controls.Add(this.textSumLe);
            this.Controls.Add(this.textSumChan);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.textArray);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textArray;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.TextBox textSumChan;
        private System.Windows.Forms.TextBox textSumLe;
        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Button BTNReset;
        private System.Windows.Forms.Button BTNExit;
    }
}

