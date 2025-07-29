namespace LinkedList_MergeSort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblOut = new Label();
            lblOutput = new Label();
            label2 = new Label();
            btnNextForm = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(526, 303);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(149, 303);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblOut);
            panel1.Location = new Point(35, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 207);
            panel1.TabIndex = 0;
            // 
            // lblOut
            // 
            lblOut.Location = new Point(42, 82);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(654, 41);
            lblOut.TabIndex = 0;
            lblOut.Text = "label3";
            lblOut.Click += lblOut_Click;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(0, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(100, 23);
            lblOutput.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // btnNextForm
            // 
            btnNextForm.Location = new Point(343, 380);
            btnNextForm.Name = "btnNextForm";
            btnNextForm.Size = new Size(94, 29);
            btnNextForm.TabIndex = 2;
            btnNextForm.Text = "Page 2";
            btnNextForm.UseVisualStyleBackColor = true;
            btnNextForm.Click += btnNextForm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(286, 21);
            label4.Name = "label4";
            label4.Size = new Size(224, 38);
            label4.TabIndex = 3;
            label4.Text = "Story Script Sort!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnNextForm);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Button btnPrev;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblOutput;
        private Button btnNextForm;
        private Label lblOut;
        private Label label4;
    }
}
