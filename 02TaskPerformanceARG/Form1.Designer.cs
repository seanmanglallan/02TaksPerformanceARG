﻿namespace _02TaskPerformanceARG
{
    partial class QueuingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(12, 39);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(75, 59);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(123, 67);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(139, 31);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "P - 10000";
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(148, 106);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(75, 24);
            this.btnNextForm.TabIndex = 3;
            this.btnNextForm.Text = "Next";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(321, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCashier);
            this.Name = "QueuingForm";
            this.Text = "Queuing Form";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.Label label2;
    }
}

