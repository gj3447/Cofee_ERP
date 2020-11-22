namespace Coffee
{
    partial class Menu_Create_Form
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Kind = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(31, 39);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(149, 25);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(31, 108);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(149, 25);
            this.textBox_Price.TabIndex = 1;
            // 
            // comboBox_Kind
            // 
            this.comboBox_Kind.FormattingEnabled = true;
            this.comboBox_Kind.Location = new System.Drawing.Point(213, 39);
            this.comboBox_Kind.Name = "comboBox_Kind";
            this.comboBox_Kind.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Kind.TabIndex = 2;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(213, 107);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(121, 23);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "추가";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "price";
            // 
            // Menu_Create_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.comboBox_Kind);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Menu_Create_Form";
            this.Text = "메뉴설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ComboBox comboBox_Kind;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}