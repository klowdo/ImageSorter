namespace ImageSorter
{
    partial class Form1
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
            this.FromPath = new System.Windows.Forms.Button();
            this.ToPath = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.Recursive_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FromPath
            // 
            this.FromPath.Location = new System.Drawing.Point(70, 12);
            this.FromPath.Name = "FromPath";
            this.FromPath.Size = new System.Drawing.Size(75, 23);
            this.FromPath.TabIndex = 0;
            this.FromPath.Text = "From";
            this.FromPath.UseVisualStyleBackColor = true;
            this.FromPath.Click += new System.EventHandler(this.FromPath_Click);
            // 
            // ToPath
            // 
            this.ToPath.Location = new System.Drawing.Point(70, 59);
            this.ToPath.Name = "ToPath";
            this.ToPath.Size = new System.Drawing.Size(75, 23);
            this.ToPath.TabIndex = 1;
            this.ToPath.Text = "To";
            this.ToPath.UseVisualStyleBackColor = true;
            this.ToPath.Click += new System.EventHandler(this.ToPath_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(70, 126);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // Recursive_Check
            // 
            this.Recursive_Check.AutoSize = true;
            this.Recursive_Check.Location = new System.Drawing.Point(65, 103);
            this.Recursive_Check.Name = "Recursive_Check";
            this.Recursive_Check.Size = new System.Drawing.Size(80, 17);
            this.Recursive_Check.TabIndex = 3;
            this.Recursive_Check.Text = "Recursive?";
            this.Recursive_Check.UseVisualStyleBackColor = true;
            this.Recursive_Check.CheckedChanged += new System.EventHandler(this.Recursive_Check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 212);
            this.Controls.Add(this.Recursive_Check);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.ToPath);
            this.Controls.Add(this.FromPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FromPath;
        private System.Windows.Forms.Button ToPath;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.CheckBox Recursive_Check;
    }
}

