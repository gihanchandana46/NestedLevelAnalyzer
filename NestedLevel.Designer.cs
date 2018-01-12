namespace NestedLevelAnalyzer
{
    partial class NestedLevel
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NestedArrayTestbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourcetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LineContentTextbox = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(219, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Nested Level";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(798, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 26);
            this.textBox1.TabIndex = 1;
            // 
            // NestedArrayTestbox
            // 
            this.NestedArrayTestbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NestedArrayTestbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NestedArrayTestbox.Location = new System.Drawing.Point(511, 71);
            this.NestedArrayTestbox.Multiline = true;
            this.NestedArrayTestbox.Name = "NestedArrayTestbox";
            this.NestedArrayTestbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NestedArrayTestbox.Size = new System.Drawing.Size(194, 273);
            this.NestedArrayTestbox.TabIndex = 2;
            this.NestedArrayTestbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NestedArrayTestbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(430, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "NESTED LEVEL ANALYSER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sourcetextbox
            // 
            this.sourcetextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sourcetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcetextbox.Location = new System.Drawing.Point(12, 71);
            this.sourcetextbox.Multiline = true;
            this.sourcetextbox.Name = "sourcetextbox";
            this.sourcetextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourcetextbox.Size = new System.Drawing.Size(476, 273);
            this.sourcetextbox.TabIndex = 4;
            this.sourcetextbox.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(153, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(903, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Line Content";
            // 
            // LineContentTextbox
            // 
            this.LineContentTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LineContentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineContentTextbox.Location = new System.Drawing.Point(732, 71);
            this.LineContentTextbox.Name = "LineContentTextbox";
            this.LineContentTextbox.Size = new System.Drawing.Size(446, 273);
            this.LineContentTextbox.TabIndex = 9;
            this.LineContentTextbox.Text = "";
            this.LineContentTextbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(453, 419);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 26);
            this.textBox4.TabIndex = 10;
            // 
            // NestedLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 466);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LineContentTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourcetextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NestedArrayTestbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "NestedLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NestedArrayTestbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourcetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox LineContentTextbox;
        private System.Windows.Forms.TextBox textBox4;
    }
}

