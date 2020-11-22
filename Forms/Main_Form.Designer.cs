namespace Coffee
{
    partial class Main_Form
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
            this.comboBox_Kind = new System.Windows.Forms.ComboBox();
            this.listBox_Menu = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변경ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.종류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인기록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.월별사용자별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일일메뉴별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.월별메뉴별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Menu_Add = new System.Windows.Forms.Button();
            this.button_Menu_Sale = new System.Windows.Forms.Button();
            this.listView_Sale_Menu = new System.Windows.Forms.ListView();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.변경ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Kind
            // 
            this.comboBox_Kind.FormattingEnabled = true;
            this.comboBox_Kind.Location = new System.Drawing.Point(34, 56);
            this.comboBox_Kind.Name = "comboBox_Kind";
            this.comboBox_Kind.Size = new System.Drawing.Size(250, 23);
            this.comboBox_Kind.TabIndex = 0;
            this.comboBox_Kind.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kind_SelectedIndexChanged);
            // 
            // listBox_Menu
            // 
            this.listBox_Menu.FormattingEnabled = true;
            this.listBox_Menu.ItemHeight = 15;
            this.listBox_Menu.Location = new System.Drawing.Point(34, 98);
            this.listBox_Menu.Name = "listBox_Menu";
            this.listBox_Menu.Size = new System.Drawing.Size(250, 319);
            this.listBox_Menu.TabIndex = 1;
            this.listBox_Menu.SelectedIndexChanged += new System.EventHandler(this.listBox_Menu_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.종류ToolStripMenuItem,
            this.관리자ToolStripMenuItem,
            this.통계ToolStripMenuItem,
            this.주문변경ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴추가ToolStripMenuItem,
            this.변경ToolStripMenuItem1,
            this.삭제ToolStripMenuItem1});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 메뉴추가ToolStripMenuItem
            // 
            this.메뉴추가ToolStripMenuItem.Name = "메뉴추가ToolStripMenuItem";
            this.메뉴추가ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.메뉴추가ToolStripMenuItem.Text = "추가";
            this.메뉴추가ToolStripMenuItem.Click += new System.EventHandler(this.메뉴추가ToolStripMenuItem_Click);
            // 
            // 변경ToolStripMenuItem1
            // 
            this.변경ToolStripMenuItem1.Name = "변경ToolStripMenuItem1";
            this.변경ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.변경ToolStripMenuItem1.Text = "변경";
            this.변경ToolStripMenuItem1.Click += new System.EventHandler(this.변경ToolStripMenuItem1_Click);
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.삭제ToolStripMenuItem1.Text = "삭제";
            this.삭제ToolStripMenuItem1.Click += new System.EventHandler(this.삭제ToolStripMenuItem1_Click);
            // 
            // 종류ToolStripMenuItem
            // 
            this.종류ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.변경ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.종류ToolStripMenuItem.Name = "종류ToolStripMenuItem";
            this.종류ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.종류ToolStripMenuItem.Text = "종류";
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
            // 
            // 변경ToolStripMenuItem
            // 
            this.변경ToolStripMenuItem.Name = "변경ToolStripMenuItem";
            this.변경ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.변경ToolStripMenuItem.Text = "변경";
            this.변경ToolStripMenuItem.Click += new System.EventHandler(this.변경ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // 관리자ToolStripMenuItem
            // 
            this.관리자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인기록ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
            this.관리자ToolStripMenuItem.Name = "관리자ToolStripMenuItem";
            this.관리자ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.관리자ToolStripMenuItem.Text = "로그인";
            // 
            // 로그인기록ToolStripMenuItem
            // 
            this.로그인기록ToolStripMenuItem.Name = "로그인기록ToolStripMenuItem";
            this.로그인기록ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.로그인기록ToolStripMenuItem.Text = "로그인 기록";
            this.로그인기록ToolStripMenuItem.Click += new System.EventHandler(this.로그인기록ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.월별사용자별ToolStripMenuItem,
            this.일일메뉴별ToolStripMenuItem,
            this.월별메뉴별ToolStripMenuItem});
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.통계ToolStripMenuItem.Text = "통계";
            // 
            // 월별사용자별ToolStripMenuItem
            // 
            this.월별사용자별ToolStripMenuItem.Name = "월별사용자별ToolStripMenuItem";
            this.월별사용자별ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.월별사용자별ToolStripMenuItem.Text = "일일 사용자별";
            this.월별사용자별ToolStripMenuItem.Click += new System.EventHandler(this.월별사용자별ToolStripMenuItem_Click);
            // 
            // 일일메뉴별ToolStripMenuItem
            // 
            this.일일메뉴별ToolStripMenuItem.Name = "일일메뉴별ToolStripMenuItem";
            this.일일메뉴별ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.일일메뉴별ToolStripMenuItem.Text = "일일 메뉴별";
            this.일일메뉴별ToolStripMenuItem.Click += new System.EventHandler(this.일일메뉴별ToolStripMenuItem_Click);
            // 
            // 월별메뉴별ToolStripMenuItem
            // 
            this.월별메뉴별ToolStripMenuItem.Name = "월별메뉴별ToolStripMenuItem";
            this.월별메뉴별ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.월별메뉴별ToolStripMenuItem.Text = "월별 메뉴별";
            this.월별메뉴별ToolStripMenuItem.Click += new System.EventHandler(this.월별메뉴별ToolStripMenuItem_Click);
            // 
            // 주문변경ToolStripMenuItem
            // 
            this.주문변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.변경ToolStripMenuItem2});
            this.주문변경ToolStripMenuItem.Name = "주문변경ToolStripMenuItem";
            this.주문변경ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.주문변경ToolStripMenuItem.Text = "주문";
            // 
            // button_Menu_Add
            // 
            this.button_Menu_Add.Location = new System.Drawing.Point(312, 374);
            this.button_Menu_Add.Name = "button_Menu_Add";
            this.button_Menu_Add.Size = new System.Drawing.Size(105, 34);
            this.button_Menu_Add.TabIndex = 3;
            this.button_Menu_Add.Text = "추가";
            this.button_Menu_Add.UseVisualStyleBackColor = true;
            this.button_Menu_Add.Click += new System.EventHandler(this.button_Menu_Add_Click);
            // 
            // button_Menu_Sale
            // 
            this.button_Menu_Sale.Location = new System.Drawing.Point(552, 374);
            this.button_Menu_Sale.Name = "button_Menu_Sale";
            this.button_Menu_Sale.Size = new System.Drawing.Size(119, 34);
            this.button_Menu_Sale.TabIndex = 10;
            this.button_Menu_Sale.Text = "판매";
            this.button_Menu_Sale.UseVisualStyleBackColor = true;
            this.button_Menu_Sale.Click += new System.EventHandler(this.button_Menu_Sale_Click);
            // 
            // listView_Sale_Menu
            // 
            this.listView_Sale_Menu.HideSelection = false;
            this.listView_Sale_Menu.Location = new System.Drawing.Point(312, 56);
            this.listView_Sale_Menu.Name = "listView_Sale_Menu";
            this.listView_Sale_Menu.Size = new System.Drawing.Size(359, 259);
            this.listView_Sale_Menu.TabIndex = 11;
            this.listView_Sale_Menu.UseCompatibleStateImageBehavior = false;
            // 
            // button_Cancle
            // 
            this.button_Cancle.Location = new System.Drawing.Point(423, 374);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(115, 34);
            this.button_Cancle.TabIndex = 12;
            this.button_Cancle.Text = "취소";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 25);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "총가격";
            // 
            // 변경ToolStripMenuItem2
            // 
            this.변경ToolStripMenuItem2.Name = "변경ToolStripMenuItem2";
            this.변경ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.변경ToolStripMenuItem2.Text = "변경";
            this.변경ToolStripMenuItem2.Click += new System.EventHandler(this.변경ToolStripMenuItem2_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.listView_Sale_Menu);
            this.Controls.Add(this.button_Menu_Sale);
            this.Controls.Add(this.button_Menu_Add);
            this.Controls.Add(this.listBox_Menu);
            this.Controls.Add(this.comboBox_Kind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "커피샾";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Kind;
        private System.Windows.Forms.ListBox listBox_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종류ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인기록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 월별사용자별ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일일메뉴별ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 월별메뉴별ToolStripMenuItem;
        private System.Windows.Forms.Button button_Menu_Add;
        private System.Windows.Forms.Button button_Menu_Sale;
        private System.Windows.Forms.ListView listView_Sale_Menu;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경ToolStripMenuItem2;
    }
}