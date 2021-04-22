
namespace Pokemon_API
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
            this.btn_ID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ID
            // 
            this.btn_ID.Location = new System.Drawing.Point(55, 175);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(100, 32);
            this.btn_ID.TabIndex = 0;
            this.btn_ID.Text = "Submit";
            this.btn_ID.UseVisualStyleBackColor = true;
            this.btn_ID.Click += new System.EventHandler(this.btn_ID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find Species by ID";
            // 
            // txt_IDBox
            // 
            this.txt_IDBox.Location = new System.Drawing.Point(55, 235);
            this.txt_IDBox.Name = "txt_IDBox";
            this.txt_IDBox.Size = new System.Drawing.Size(100, 22);
            this.txt_IDBox.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(325, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 388);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ID);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

