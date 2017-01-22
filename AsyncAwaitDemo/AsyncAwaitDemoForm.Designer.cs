namespace AsyncAwaitDemo
{
    partial class AsyncAwaitDemoForm
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
            this.Synchronous = new System.Windows.Forms.Button();
            this.Async = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Synchronous
            // 
            this.Synchronous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Synchronous.Location = new System.Drawing.Point(1, 65);
            this.Synchronous.Name = "Synchronous";
            this.Synchronous.Size = new System.Drawing.Size(152, 70);
            this.Synchronous.TabIndex = 0;
            this.Synchronous.Text = "Synchronous";
            this.Synchronous.UseVisualStyleBackColor = true;
            this.Synchronous.Click += new System.EventHandler(this.Sync_Click);
            // 
            // Async
            // 
            this.Async.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Async.Location = new System.Drawing.Point(1, 169);
            this.Async.Name = "Async";
            this.Async.Size = new System.Drawing.Size(152, 70);
            this.Async.TabIndex = 1;
            this.Async.Text = "Async";
            this.Async.UseVisualStyleBackColor = true;
            this.Async.Click += new System.EventHandler(this.Async_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(152, 142);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(25, 22);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "   ";
            // 
            // AsyncAwaitDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 318);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Async);
            this.Controls.Add(this.Synchronous);
            this.Name = "AsyncAwaitDemoForm";
            this.Text = "AsyncAwaitDemoForm";
            this.Load += new System.EventHandler(this.AsyncAwaitDemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Synchronous;
        private System.Windows.Forms.Button Async;
        private System.Windows.Forms.Label StatusLabel;
    }
}

