
namespace Star_Wars_API
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
            this.btn_Character = new System.Windows.Forms.Button();
            this.btn_Species = new System.Windows.Forms.Button();
            this.btn_Planet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Character
            // 
            this.btn_Character.Location = new System.Drawing.Point(19, 231);
            this.btn_Character.Name = "btn_Character";
            this.btn_Character.Size = new System.Drawing.Size(103, 53);
            this.btn_Character.TabIndex = 1;
            this.btn_Character.Text = "Character";
            this.btn_Character.UseVisualStyleBackColor = true;
            this.btn_Character.Click += new System.EventHandler(this.btn_Character_Click);
            // 
            // btn_Species
            // 
            this.btn_Species.Location = new System.Drawing.Point(19, 321);
            this.btn_Species.Name = "btn_Species";
            this.btn_Species.Size = new System.Drawing.Size(103, 53);
            this.btn_Species.TabIndex = 2;
            this.btn_Species.Text = "Species";
            this.btn_Species.UseVisualStyleBackColor = true;
            this.btn_Species.Click += new System.EventHandler(this.btn_Species_Click);
            // 
            // btn_Planet
            // 
            this.btn_Planet.Location = new System.Drawing.Point(19, 142);
            this.btn_Planet.Name = "btn_Planet";
            this.btn_Planet.Size = new System.Drawing.Size(103, 53);
            this.btn_Planet.TabIndex = 3;
            this.btn_Planet.Text = "Planet";
            this.btn_Planet.UseVisualStyleBackColor = true;
            this.btn_Planet.Click += new System.EventHandler(this.btn_Planet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(297, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(493, 420);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // txt_IDBox
            // 
            this.txt_IDBox.Location = new System.Drawing.Point(174, 173);
            this.txt_IDBox.Name = "txt_IDBox";
            this.txt_IDBox.Size = new System.Drawing.Size(100, 22);
            this.txt_IDBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 119);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter the id of the planet or character \r\nyou would like to retrieve.\r\n\r\nThen hit" +
    " the corresponding \r\nbutton to view the planet or id.\r\n\r\nThere are 60 planets an" +
    "d 83 characters.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Planet);
            this.Controls.Add(this.btn_Species);
            this.Controls.Add(this.btn_Character);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Character;
        private System.Windows.Forms.Button btn_Species;
        private System.Windows.Forms.Button btn_Planet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDBox;
        private System.Windows.Forms.Label label4;
    }
}

