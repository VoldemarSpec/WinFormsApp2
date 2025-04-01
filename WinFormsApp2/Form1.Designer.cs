namespace WinFormsApp2
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            groupBoxSingleChoice = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBoxMultipleChoice = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            groupBoxSingleChoice.SuspendLayout();
            groupBoxMultipleChoice.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Circular Spotify Text Bold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 102);
            label1.TabIndex = 3;
            label1.Text = "Questionaire";
            // 
            // button1
            // 
            button1.Font = new Font("Circular Spotify Text Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(199, 575);
            button1.Name = "button1";
            button1.Size = new Size(301, 90);
            button1.TabIndex = 4;
            button1.Text = "Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Circular Spotify Text Bold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 167);
            label2.MaximumSize = new Size(400, 45);
            label2.MinimumSize = new Size(600, 45);
            label2.Name = "label2";
            label2.Size = new Size(600, 45);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // groupBoxSingleChoice
            // 
            groupBoxSingleChoice.Controls.Add(radioButton3);
            groupBoxSingleChoice.Controls.Add(radioButton2);
            groupBoxSingleChoice.Controls.Add(radioButton1);
            groupBoxSingleChoice.Location = new Point(12, 225);
            groupBoxSingleChoice.Name = "groupBoxSingleChoice";
            groupBoxSingleChoice.Size = new Size(300, 307);
            groupBoxSingleChoice.TabIndex = 6;
            groupBoxSingleChoice.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 251);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 169);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 83);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMultipleChoice
            // 
            groupBoxMultipleChoice.Controls.Add(checkBox3);
            groupBoxMultipleChoice.Controls.Add(checkBox2);
            groupBoxMultipleChoice.Controls.Add(checkBox1);
            groupBoxMultipleChoice.Location = new Point(12, 225);
            groupBoxMultipleChoice.Name = "groupBoxMultipleChoice";
            groupBoxMultipleChoice.Size = new Size(300, 315);
            groupBoxMultipleChoice.TabIndex = 7;
            groupBoxMultipleChoice.TabStop = false;
            groupBoxMultipleChoice.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(26, 216);
            checkBox3.MinimumSize = new Size(150, 29);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(150, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(26, 144);
            checkBox2.MinimumSize = new Size(150, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(150, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 72);
            checkBox1.MinimumSize = new Size(150, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Circular Spotify Text Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 122);
            label3.MinimumSize = new Size(600, 100);
            label3.Name = "label3";
            label3.Size = new Size(600, 100);
            label3.TabIndex = 8;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 730);
            Controls.Add(label3);
            Controls.Add(groupBoxMultipleChoice);
            Controls.Add(groupBoxSingleChoice);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBoxSingleChoice.ResumeLayout(false);
            groupBoxSingleChoice.PerformLayout();
            groupBoxMultipleChoice.ResumeLayout(false);
            groupBoxMultipleChoice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Label label2;
        private GroupBox groupBoxSingleChoice;
        private GroupBox groupBoxMultipleChoice;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
    }
}
