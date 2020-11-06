namespace Coffee
{
    partial class Casher_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.buttonMenuAdd = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.labelClock = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.buttonStatiStics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴";
            // 
            // listViewMenu
            // 
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(36, 56);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(347, 331);
            this.listViewMenu.TabIndex = 2;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            // 
            // buttonMenuAdd
            // 
            this.buttonMenuAdd.Location = new System.Drawing.Point(36, 409);
            this.buttonMenuAdd.Name = "buttonMenuAdd";
            this.buttonMenuAdd.Size = new System.Drawing.Size(129, 23);
            this.buttonMenuAdd.TabIndex = 3;
            this.buttonMenuAdd.Text = "메뉴 추가";
            this.buttonMenuAdd.UseVisualStyleBackColor = true;
            this.buttonMenuAdd.Click += new System.EventHandler(this.buttonMenuAdd_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(538, 137);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(151, 120);
            this.buttonSale.TabIndex = 4;
            this.buttonSale.Text = "판매";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // labelClock
            // 
            this.labelClock.Location = new System.Drawing.Point(620, 413);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(168, 34);
            this.labelClock.TabIndex = 5;
            this.labelClock.Text = "label2";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(680, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(45, 15);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "label2";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(680, 28);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(42, 15);
            this.labelSales.TabIndex = 7;
            this.labelSales.Text = "sales";
            // 
            // buttonStatiStics
            // 
            this.buttonStatiStics.Location = new System.Drawing.Point(662, 56);
            this.buttonStatiStics.Name = "buttonStatiStics";
            this.buttonStatiStics.Size = new System.Drawing.Size(75, 23);
            this.buttonStatiStics.TabIndex = 8;
            this.buttonStatiStics.Text = "통계";
            this.buttonStatiStics.UseVisualStyleBackColor = true;
            this.buttonStatiStics.Click += new System.EventHandler(this.buttonStatiStics_Click);
            // 
            // Casher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStatiStics);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.buttonMenuAdd);
            this.Controls.Add(this.listViewMenu);
            this.Controls.Add(this.label1);
            this.Name = "Casher_Form";
            this.Text = "Casher_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Casher_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.Button buttonMenuAdd;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Button buttonStatiStics;
    }
}