namespace LinkedList_MergeSort
{
    partial class Form2
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
            btnReturn = new Button();
            btnSort = new Button();
            lstStory = new ListBox();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(637, 403);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(310, 50);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Back";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(121, 403);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(302, 50);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lstStory
            // 
            lstStory.FormattingEnabled = true;
            lstStory.Location = new Point(12, 29);
            lstStory.Name = "lstStory";
            lstStory.Size = new Size(1149, 344);
            lstStory.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 478);
            Controls.Add(lstStory);
            Controls.Add(btnSort);
            Controls.Add(btnReturn);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Button btnSort;
        private ListBox lstStory;
    }
}