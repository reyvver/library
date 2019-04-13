namespace BookManager
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonEXit = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.panelwithButtons = new System.Windows.Forms.Panel();
            this.buttonFilePathSbooks = new System.Windows.Forms.Button();
            this.buttonFilePathBooks = new System.Windows.Forms.Button();
            this.panelwithButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEXit
            // 
            this.buttonEXit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonEXit.Location = new System.Drawing.Point(23, 528);
            this.buttonEXit.Name = "buttonEXit";
            this.buttonEXit.Size = new System.Drawing.Size(231, 56);
            this.buttonEXit.TabIndex = 0;
            this.buttonEXit.Text = "[ Выход ]";
            this.buttonEXit.UseVisualStyleBackColor = false;
            this.buttonEXit.Click += new System.EventHandler(this.button_ExitApplication);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.BackColor = System.Drawing.Color.Linen;
            this.buttonLibrary.Enabled = false;
            this.buttonLibrary.Location = new System.Drawing.Point(23, 419);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(231, 58);
            this.buttonLibrary.TabIndex = 1;
            this.buttonLibrary.Text = "[ Открыть библиотеку ]";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.button_OpenLibrary);
            // 
            // button_AddBook
            // 
            this.button_AddBook.BackColor = System.Drawing.Color.Linen;
            this.button_AddBook.Enabled = false;
            this.button_AddBook.Location = new System.Drawing.Point(23, 319);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(231, 58);
            this.button_AddBook.TabIndex = 2;
            this.button_AddBook.Text = "[ Добавить книгу ]";
            this.button_AddBook.UseVisualStyleBackColor = false;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddNewBook);
            // 
            // panelwithButtons
            // 
            this.panelwithButtons.BackColor = System.Drawing.Color.Linen;
            this.panelwithButtons.Controls.Add(this.buttonFilePathSbooks);
            this.panelwithButtons.Controls.Add(this.buttonFilePathBooks);
            this.panelwithButtons.Controls.Add(this.button_AddBook);
            this.panelwithButtons.Controls.Add(this.buttonEXit);
            this.panelwithButtons.Controls.Add(this.buttonLibrary);
            this.panelwithButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelwithButtons.Location = new System.Drawing.Point(735, 0);
            this.panelwithButtons.MinimumSize = new System.Drawing.Size(230, 0);
            this.panelwithButtons.Name = "panelwithButtons";
            this.panelwithButtons.Size = new System.Drawing.Size(266, 645);
            this.panelwithButtons.TabIndex = 3;
            // 
            // buttonFilePathSbooks
            // 
            this.buttonFilePathSbooks.BackColor = System.Drawing.Color.Linen;
            this.buttonFilePathSbooks.Location = new System.Drawing.Point(23, 160);
            this.buttonFilePathSbooks.Name = "buttonFilePathSbooks";
            this.buttonFilePathSbooks.Size = new System.Drawing.Size(231, 58);
            this.buttonFilePathSbooks.TabIndex = 4;
            this.buttonFilePathSbooks.Text = "[ Файл - учебники ]";
            this.buttonFilePathSbooks.UseVisualStyleBackColor = false;
            this.buttonFilePathSbooks.Click += new System.EventHandler(this.buttonFilePathSbooks_Click);
            // 
            // buttonFilePathBooks
            // 
            this.buttonFilePathBooks.BackColor = System.Drawing.Color.Linen;
            this.buttonFilePathBooks.Location = new System.Drawing.Point(23, 96);
            this.buttonFilePathBooks.Name = "buttonFilePathBooks";
            this.buttonFilePathBooks.Size = new System.Drawing.Size(231, 58);
            this.buttonFilePathBooks.TabIndex = 3;
            this.buttonFilePathBooks.Text = "[ Файл - книги ]";
            this.buttonFilePathBooks.UseVisualStyleBackColor = false;
            this.buttonFilePathBooks.Click += new System.EventHandler(this.buttonFilePathBooks_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 645);
            this.Controls.Add(this.panelwithButtons);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мини-библиотека";
            this.panelwithButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEXit;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.Panel panelwithButtons;
        private System.Windows.Forms.Button buttonFilePathBooks;
        private System.Windows.Forms.Button buttonFilePathSbooks;
    }
}

