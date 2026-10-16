namespace laba3asd
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtQueueInput = new System.Windows.Forms.TextBox();
            this.btnProcessQueue = new System.Windows.Forms.Button();
            this.txtQueueLog = new System.Windows.Forms.TextBox();
            this.btnProcessStack = new System.Windows.Forms.Button();
            this.txtStackLog = new System.Windows.Forms.TextBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblStack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQueueInput
            // 
            this.txtQueueInput.Location = new System.Drawing.Point(20, 40);
            this.txtQueueInput.Name = "txtQueueInput";
            this.txtQueueInput.Size = new System.Drawing.Size(320, 20);
            this.txtQueueInput.TabIndex = 0;
            this.txtQueueInput.Text = "10, 15, 22, 33, 40, 55, 60";
            // 
            // btnProcessQueue
            // 
            this.btnProcessQueue.Location = new System.Drawing.Point(350, 38);
            this.btnProcessQueue.Name = "btnProcessQueue";
            this.btnProcessQueue.Size = new System.Drawing.Size(180, 23);
            this.btnProcessQueue.TabIndex = 1;
            this.btnProcessQueue.Text = "Обробити чергу (Завдання 1)";
            this.btnProcessQueue.UseVisualStyleBackColor = true;
            this.btnProcessQueue.Click += new System.EventHandler(this.btnProcessQueue_Click);
            // 
            // txtQueueLog
            // 
            this.txtQueueLog.Location = new System.Drawing.Point(20, 70);
            this.txtQueueLog.Multiline = true;
            this.txtQueueLog.Name = "txtQueueLog";
            this.txtQueueLog.ReadOnly = true;
            this.txtQueueLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueueLog.Size = new System.Drawing.Size(510, 110);
            this.txtQueueLog.TabIndex = 2;
            // 
            // btnProcessStack
            // 
            this.btnProcessStack.Location = new System.Drawing.Point(20, 220);
            this.btnProcessStack.Name = "btnProcessStack";
            this.btnProcessStack.Size = new System.Drawing.Size(510, 25);
            this.btnProcessStack.TabIndex = 3;
            this.btnProcessStack.Text = "Обробити стек із файла (Завдання 2)";
            this.btnProcessStack.UseVisualStyleBackColor = true;
            this.btnProcessStack.Click += new System.EventHandler(this.btnProcessStack_Click);
            // 
            // txtStackLog
            // 
            this.txtStackLog.Location = new System.Drawing.Point(20, 255);
            this.txtStackLog.Multiline = true;
            this.txtStackLog.Name = "txtStackLog";
            this.txtStackLog.ReadOnly = true;
            this.txtStackLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStackLog.Size = new System.Drawing.Size(510, 150);
            this.txtStackLog.TabIndex = 4;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(20, 20);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(161, 13);
            this.lblQueue.Text = "Вхідні числа (Завдання 1 - Черга):";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(20, 200);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(211, 13);
            this.lblStack.Text = "Аналіз файлу через стек (Завдання 2):";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.txtStackLog);
            this.Controls.Add(this.btnProcessStack);
            this.Controls.Add(this.txtQueueLog);
            this.Controls.Add(this.btnProcessQueue);
            this.Controls.Add(this.txtQueueInput);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3 — Динамічні структури даних";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtQueueInput;
        private System.Windows.Forms.Button btnProcessQueue;
        private System.Windows.Forms.TextBox txtQueueLog;
        private System.Windows.Forms.Button btnProcessStack;
        private System.Windows.Forms.TextBox txtStackLog;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblStack;
    }
}