namespace Coffee
{
    partial class Menucreate_Form
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
            this.textBoxMenuName = new System.Windows.Forms.TextBox();
            this.comboBoxKinds = new System.Windows.Forms.ComboBox();
            this.textBoxMenuPrice = new System.Windows.Forms.TextBox();
            this.textBoxKindsAdd = new System.Windows.Forms.TextBox();
            this.buttonKindsAdd = new System.Windows.Forms.Button();
            this.buttonMenuAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMenuName
            // 
            this.textBoxMenuName.Location = new System.Drawing.Point(45, 51);
            this.textBoxMenuName.Name = "textBoxMenuName";
            this.textBoxMenuName.Size = new System.Drawing.Size(100, 25);
            this.textBoxMenuName.TabIndex = 0;
            // 
            // comboBoxKinds
            // 
            this.comboBoxKinds.FormattingEnabled = true;
            this.comboBoxKinds.Location = new System.Drawing.Point(349, 53);
            this.comboBoxKinds.Name = "comboBoxKinds";
            this.comboBoxKinds.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKinds.TabIndex = 1;
            // 
            // textBoxMenuPrice
            // 
            this.textBoxMenuPrice.Location = new System.Drawing.Point(199, 50);
            this.textBoxMenuPrice.Name = "textBoxMenuPrice";
            this.textBoxMenuPrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxMenuPrice.TabIndex = 2;
            // 
            // textBoxKindsAdd
            // 
            this.textBoxKindsAdd.Location = new System.Drawing.Point(349, 123);
            this.textBoxKindsAdd.Name = "textBoxKindsAdd";
            this.textBoxKindsAdd.Size = new System.Drawing.Size(100, 25);
            this.textBoxKindsAdd.TabIndex = 3;
            // 
            // buttonKindsAdd
            // 
            this.buttonKindsAdd.Location = new System.Drawing.Point(349, 154);
            this.buttonKindsAdd.Name = "buttonKindsAdd";
            this.buttonKindsAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonKindsAdd.TabIndex = 4;
            this.buttonKindsAdd.Text = "종류추가";
            this.buttonKindsAdd.UseVisualStyleBackColor = true;
            this.buttonKindsAdd.Click += new System.EventHandler(this.buttonKindsAdd_Click);
            // 
            // buttonMenuAdd
            // 
            this.buttonMenuAdd.Location = new System.Drawing.Point(64, 123);
            this.buttonMenuAdd.Name = "buttonMenuAdd";
            this.buttonMenuAdd.Size = new System.Drawing.Size(196, 63);
            this.buttonMenuAdd.TabIndex = 5;
            this.buttonMenuAdd.Text = "메뉴추가";
            this.buttonMenuAdd.UseVisualStyleBackColor = true;
            this.buttonMenuAdd.Click += new System.EventHandler(this.buttonMenuAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "종류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "종류추가";
            // 
            // Menucreate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenuAdd);
            this.Controls.Add(this.buttonKindsAdd);
            this.Controls.Add(this.textBoxKindsAdd);
            this.Controls.Add(this.textBoxMenuPrice);
            this.Controls.Add(this.comboBoxKinds);
            this.Controls.Add(this.textBoxMenuName);
            this.Name = "Menucreate_Form";
            this.Text = "Menucreate_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMenuName;
        private System.Windows.Forms.ComboBox comboBoxKinds;
        private System.Windows.Forms.TextBox textBoxMenuPrice;
        private System.Windows.Forms.TextBox textBoxKindsAdd;
        private System.Windows.Forms.Button buttonKindsAdd;
        private System.Windows.Forms.Button buttonMenuAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}