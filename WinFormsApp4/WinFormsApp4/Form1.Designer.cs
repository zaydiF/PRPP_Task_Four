namespace BookVisitorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefaultBook = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.groupBoxVisitor = new System.Windows.Forms.GroupBox();
            this.lblTotalVisitors = new System.Windows.Forms.Label();
            this.btnAddVisitor = new System.Windows.Forms.Button();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxVisitors = new System.Windows.Forms.ListBox();
            this.groupBoxBook.SuspendLayout();
            this.groupBoxVisitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.txtYear);
            this.groupBoxBook.Controls.Add(this.txtAuthor);
            this.groupBoxBook.Controls.Add(this.txtTitle);
            this.groupBoxBook.Controls.Add(this.label3);
            this.groupBoxBook.Controls.Add(this.label2);
            this.groupBoxBook.Controls.Add(this.label1);
            this.groupBoxBook.Controls.Add(this.btnDefaultBook);
            this.groupBoxBook.Controls.Add(this.btnCreateBook);
            this.groupBoxBook.Controls.Add(this.listBoxBooks);
            this.groupBoxBook.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(360, 260);
            this.groupBoxBook.TabIndex = 0;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Книжная полка";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(78, 74);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(78, 48);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(78, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // btnDefaultBook
            // 
            this.btnDefaultBook.Location = new System.Drawing.Point(195, 48);
            this.btnDefaultBook.Name = "btnDefaultBook";
            this.btnDefaultBook.Size = new System.Drawing.Size(150, 23);
            this.btnDefaultBook.TabIndex = 2;
            this.btnDefaultBook.Text = "Книга по умолчанию";
            this.btnDefaultBook.UseVisualStyleBackColor = true;
            this.btnDefaultBook.Click += new System.EventHandler(this.btnDefaultBook_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(195, 19);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(150, 23);
            this.btnCreateBook.TabIndex = 1;
            this.btnCreateBook.Text = "Создать книгу и показать";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(20, 112);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(325, 95);
            this.listBoxBooks.TabIndex = 0;
            // 
            // groupBoxVisitor
            // 
            this.groupBoxVisitor.Controls.Add(this.lblTotalVisitors);
            this.groupBoxVisitor.Controls.Add(this.btnAddVisitor);
            this.groupBoxVisitor.Controls.Add(this.txtVisitorName);
            this.groupBoxVisitor.Controls.Add(this.label4);
            this.groupBoxVisitor.Controls.Add(this.listBoxVisitors);
            this.groupBoxVisitor.Location = new System.Drawing.Point(12, 278);
            this.groupBoxVisitor.Name = "groupBoxVisitor";
            this.groupBoxVisitor.Size = new System.Drawing.Size(360, 217);
            this.groupBoxVisitor.TabIndex = 1;
            this.groupBoxVisitor.TabStop = false;
            this.groupBoxVisitor.Text = "Умный счетчик";
            // 
            // lblTotalVisitors
            // 
            this.lblTotalVisitors.AutoSize = true;
            this.lblTotalVisitors.Location = new System.Drawing.Point(20, 188);
            this.lblTotalVisitors.Name = "lblTotalVisitors";
            this.lblTotalVisitors.Size = new System.Drawing.Size(104, 13);
            this.lblTotalVisitors.TabIndex = 4;
            this.lblTotalVisitors.Text = "Всего посетителей:";
            // 
            // btnAddVisitor
            // 
            this.btnAddVisitor.Location = new System.Drawing.Point(195, 19);
            this.btnAddVisitor.Name = "btnAddVisitor";
            this.btnAddVisitor.Size = new System.Drawing.Size(150, 23);
            this.btnAddVisitor.TabIndex = 3;
            this.btnAddVisitor.Text = "Добавить посетителя";
            this.btnAddVisitor.UseVisualStyleBackColor = true;
            this.btnAddVisitor.Click += new System.EventHandler(this.btnAddVisitor_Click);
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.Location = new System.Drawing.Point(78, 21);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.Size = new System.Drawing.Size(100, 20);
            this.txtVisitorName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Имя:";
            // 
            // listBoxVisitors
            // 
            this.listBoxVisitors.FormattingEnabled = true;
            this.listBoxVisitors.Location = new System.Drawing.Point(20, 55);
            this.listBoxVisitors.Name = "listBoxVisitors";
            this.listBoxVisitors.Size = new System.Drawing.Size(325, 121);
            this.listBoxVisitors.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.groupBoxVisitor);
            this.Controls.Add(this.groupBoxBook);
            this.Name = "Form1";
            this.Text = "Библиотека и посетители";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.groupBoxVisitor.ResumeLayout(false);
            this.groupBoxVisitor.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDefaultBook;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.GroupBox groupBoxVisitor;
        private System.Windows.Forms.Label lblTotalVisitors;
        private System.Windows.Forms.Button btnAddVisitor;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxVisitors;
    }
}