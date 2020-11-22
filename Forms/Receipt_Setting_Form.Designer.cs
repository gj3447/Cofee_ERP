namespace Coffee
{
    partial class Receipt_Setting_Form
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
            this.textBox_Before_Hour = new System.Windows.Forms.TextBox();
            this.textBox_Before_Minite = new System.Windows.Forms.TextBox();
            this.textBox_After_Hour = new System.Windows.Forms.TextBox();
            this.textBox_After_Minite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Receipt = new System.Windows.Forms.ListBox();
            this.listBox_Order = new System.Windows.Forms.ListBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Before_Hour
            // 
            this.textBox_Before_Hour.Location = new System.Drawing.Point(6, 63);
            this.textBox_Before_Hour.Name = "textBox_Before_Hour";
            this.textBox_Before_Hour.Size = new System.Drawing.Size(100, 25);
            this.textBox_Before_Hour.TabIndex = 2;
            // 
            // textBox_Before_Minite
            // 
            this.textBox_Before_Minite.Location = new System.Drawing.Point(136, 63);
            this.textBox_Before_Minite.Name = "textBox_Before_Minite";
            this.textBox_Before_Minite.Size = new System.Drawing.Size(100, 25);
            this.textBox_Before_Minite.TabIndex = 3;
            // 
            // textBox_After_Hour
            // 
            this.textBox_After_Hour.Location = new System.Drawing.Point(22, 60);
            this.textBox_After_Hour.Name = "textBox_After_Hour";
            this.textBox_After_Hour.Size = new System.Drawing.Size(100, 25);
            this.textBox_After_Hour.TabIndex = 4;
            // 
            // textBox_After_Minite
            // 
            this.textBox_After_Minite.Location = new System.Drawing.Point(138, 60);
            this.textBox_After_Minite.Name = "textBox_After_Minite";
            this.textBox_After_Minite.Size = new System.Drawing.Size(100, 25);
            this.textBox_After_Minite.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "분";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Before_Hour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Before_Minite);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "before";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_After_Hour);
            this.groupBox2.Controls.Add(this.textBox_After_Minite);
            this.groupBox2.Location = new System.Drawing.Point(516, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "after";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "시간";
            // 
            // listBox_Receipt
            // 
            this.listBox_Receipt.FormattingEnabled = true;
            this.listBox_Receipt.ItemHeight = 15;
            this.listBox_Receipt.Location = new System.Drawing.Point(31, 165);
            this.listBox_Receipt.Name = "listBox_Receipt";
            this.listBox_Receipt.Size = new System.Drawing.Size(214, 274);
            this.listBox_Receipt.TabIndex = 10;
            this.listBox_Receipt.SelectedIndexChanged += new System.EventHandler(this.listBox_Receipt_SelectedIndexChanged);
            // 
            // listBox_Order
            // 
            this.listBox_Order.FormattingEnabled = true;
            this.listBox_Order.ItemHeight = 15;
            this.listBox_Order.Location = new System.Drawing.Point(305, 164);
            this.listBox_Order.Name = "listBox_Order";
            this.listBox_Order.Size = new System.Drawing.Size(217, 274);
            this.listBox_Order.TabIndex = 11;
            this.listBox_Order.SelectedIndexChanged += new System.EventHandler(this.listBox_Order_SelectedIndexChanged);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(327, 85);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(123, 43);
            this.button_Search.TabIndex = 12;
            this.button_Search.Text = "탐색";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(570, 234);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(143, 41);
            this.button_Return.TabIndex = 13;
            this.button_Return.Text = "반품";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(570, 174);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(143, 25);
            this.textBox_Status.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "판매";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Receipt_Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.listBox_Order);
            this.Controls.Add(this.listBox_Receipt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Receipt_Setting_Form";
            this.Text = "Receipt_Setting_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Before_Hour;
        private System.Windows.Forms.TextBox textBox_Before_Minite;
        private System.Windows.Forms.TextBox textBox_After_Hour;
        private System.Windows.Forms.TextBox textBox_After_Minite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Receipt;
        private System.Windows.Forms.ListBox listBox_Order;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Button button1;
    }
}