namespace QueueingForm
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            listCashierQueue = new ListView();
            columnHeader1 = new ColumnHeader();
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(12, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(83, 34);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.AllowDrop = true;
            listCashierQueue.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listCashierQueue.Location = new Point(113, 29);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(178, 223);
            listCashierQueue.TabIndex = 1;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(12, 61);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(83, 34);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 281);
            Controls.Add(btnNext);
            Controls.Add(listCashierQueue);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private ListView listCashierQueue;
        private Button btnNext;
        private ColumnHeader columnHeader1;
    }
}