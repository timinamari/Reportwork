namespace bibliobook
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
            this.grbReader = new System.Windows.Forms.GroupBox();
            this.grbInform = new System.Windows.Forms.GroupBox();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVisibleInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblReader = new System.Windows.Forms.Label();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.lstInform = new System.Windows.Forms.ListBox();
            this.grbReader.SuspendLayout();
            this.grbInform.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReader
            // 
            this.grbReader.Controls.Add(this.lstBooks);
            this.grbReader.Controls.Add(this.txtKol);
            this.grbReader.Controls.Add(this.chkBook);
            this.grbReader.Controls.Add(this.grbStatus);
            this.grbReader.Controls.Add(this.lblKol);
            this.grbReader.Controls.Add(this.lblBooks);
            this.grbReader.Controls.Add(this.cmbReader);
            this.grbReader.Controls.Add(this.lblReader);
            this.grbReader.Location = new System.Drawing.Point(12, 12);
            this.grbReader.Name = "grbReader";
            this.grbReader.Size = new System.Drawing.Size(385, 284);
            this.grbReader.TabIndex = 0;
            this.grbReader.TabStop = false;
            this.grbReader.Text = "Карточка читателя";
            // 
            // grbInform
            // 
            this.grbInform.Controls.Add(this.lstInform);
            this.grbInform.Location = new System.Drawing.Point(12, 355);
            this.grbInform.Name = "grbInform";
            this.grbInform.Size = new System.Drawing.Size(385, 185);
            this.grbInform.TabIndex = 1;
            this.grbInform.TabStop = false;
            this.grbInform.Text = "Информация";
            // 
            // btnInform
            // 
            this.btnInform.Enabled = false;
            this.btnInform.Location = new System.Drawing.Point(438, 29);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(188, 37);
            this.btnInform.TabIndex = 2;
            this.btnInform.Text = "Получить информацию";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(438, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить строку";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(438, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVisibleInfo
            // 
            this.btnVisibleInfo.Enabled = false;
            this.btnVisibleInfo.Location = new System.Drawing.Point(438, 220);
            this.btnVisibleInfo.Name = "btnVisibleInfo";
            this.btnVisibleInfo.Size = new System.Drawing.Size(188, 37);
            this.btnVisibleInfo.TabIndex = 5;
            this.btnVisibleInfo.Text = "Скрыть информацию";
            this.btnVisibleInfo.UseVisualStyleBackColor = true;
            this.btnVisibleInfo.Click += new System.EventHandler(this.btnVisibleInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReader.Location = new System.Drawing.Point(20, 28);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(61, 15);
            this.lblReader.TabIndex = 0;
            this.lblReader.Text = "Читатель";
            // 
            // cmbReader
            // 
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.Items.AddRange(new object[] {
            "Арбузов Н.В.",
            "Вылегжанина О.Ю.",
            "Иванов П.Р.",
            "Петров С.Е.",
            "Сидоров А.И."});
            this.cmbReader.Location = new System.Drawing.Point(99, 25);
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.Size = new System.Drawing.Size(257, 23);
            this.cmbReader.Sorted = true;
            this.cmbReader.TabIndex = 1;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.Location = new System.Drawing.Point(235, 63);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(126, 15);
            this.lblBooks.TabIndex = 2;
            this.lblBooks.Text = "Список книг фондов";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKol.Location = new System.Drawing.Point(20, 250);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(108, 15);
            this.lblKol.TabIndex = 3;
            this.lblKol.Text = "Количество дней";
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbStatus3);
            this.grbStatus.Controls.Add(this.rdbStatus2);
            this.grbStatus.Controls.Add(this.rdbStatus1);
            this.grbStatus.Location = new System.Drawing.Point(27, 68);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(171, 123);
            this.grbStatus.TabIndex = 4;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Статус";
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.Location = new System.Drawing.Point(27, 208);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(109, 19);
            this.chkBook.TabIndex = 5;
            this.chkBook.Text = "Книги на руках";
            this.chkBook.UseVisualStyleBackColor = true;
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(172, 247);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(150, 23);
            this.txtKol.TabIndex = 6;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Items.AddRange(new object[] {
            "Достоевский \"Идиот\"",
            "Куприн \"Сборник рассказов\"",
            "Лермонтов \"Мцыри\"",
            "Толстой \"Война и мир\""});
            this.lstBooks.Location = new System.Drawing.Point(218, 81);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(153, 109);
            this.lstBooks.TabIndex = 7;
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.Location = new System.Drawing.Point(22, 29);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(82, 19);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Школьник";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Location = new System.Drawing.Point(22, 54);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(68, 19);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.TabStop = true;
            this.rdbStatus2.Text = "Студент";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Location = new System.Drawing.Point(22, 79);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(77, 19);
            this.rdbStatus3.TabIndex = 2;
            this.rdbStatus3.TabStop = true;
            this.rdbStatus3.Text = "Работник";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // lstInform
            // 
            this.lstInform.FormattingEnabled = true;
            this.lstInform.ItemHeight = 15;
            this.lstInform.Location = new System.Drawing.Point(16, 22);
            this.lstInform.Name = "lstInform";
            this.lstInform.Size = new System.Drawing.Size(355, 139);
            this.lstInform.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVisibleInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.grbInform);
            this.Controls.Add(this.grbReader);
            this.Name = "Form1";
            this.Text = "Выдача литературы на дом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbReader.ResumeLayout(false);
            this.grbReader.PerformLayout();
            this.grbInform.ResumeLayout(false);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbReader;
        private Label lblReader;
        private GroupBox grbInform;
        private Button btnInform;
        private Button btnRemove;
        private Button btnClear;
        private Button btnVisibleInfo;
        private Button btnExit;
        private ComboBox cmbReader;
        private ListBox lstBooks;
        private TextBox txtKol;
        private CheckBox chkBook;
        private GroupBox grbStatus;
        private Label lblKol;
        private Label lblBooks;
        private RadioButton rdbStatus3;
        private RadioButton rdbStatus2;
        private RadioButton rdbStatus1;
        private ListBox lstInform;
    }
}