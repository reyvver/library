namespace BookManager
{
    partial class FormAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddition));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPublishing = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.checkBoxBook = new System.Windows.Forms.CheckBox();
            this.checkBoxStudybook = new System.Windows.Forms.CheckBox();
            this.textBoxCoAuthor = new System.Windows.Forms.TextBox();
            this.textBoxSphere = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPublish = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCoAuthor = new System.Windows.Forms.Label();
            this.labelSphere = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCancel.Location = new System.Drawing.Point(293, 465);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(231, 58);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Закрыть";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.button_CloseAdditionForm);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Linen;
            this.buttonConfirm.Location = new System.Drawing.Point(16, 465);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(231, 58);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Добавить";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(197, 122);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(277, 22);
            this.textboxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(197, 159);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(277, 22);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxPublishing
            // 
            this.textBoxPublishing.Location = new System.Drawing.Point(197, 198);
            this.textBoxPublishing.Name = "textBoxPublishing";
            this.textBoxPublishing.Size = new System.Drawing.Size(277, 22);
            this.textBoxPublishing.TabIndex = 7;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(197, 239);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(277, 22);
            this.textBoxCount.TabIndex = 8;
            // 
            // checkBoxBook
            // 
            this.checkBoxBook.AutoSize = true;
            this.checkBoxBook.Checked = true;
            this.checkBoxBook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBook.Location = new System.Drawing.Point(98, 75);
            this.checkBoxBook.Name = "checkBoxBook";
            this.checkBoxBook.Size = new System.Drawing.Size(68, 21);
            this.checkBoxBook.TabIndex = 9;
            this.checkBoxBook.Text = "Книга";
            this.checkBoxBook.UseVisualStyleBackColor = true;
            this.checkBoxBook.Click += new System.EventHandler(this.checkBoxBook_Click);
            // 
            // checkBoxStudybook
            // 
            this.checkBoxStudybook.AutoSize = true;
            this.checkBoxStudybook.Location = new System.Drawing.Point(219, 76);
            this.checkBoxStudybook.Name = "checkBoxStudybook";
            this.checkBoxStudybook.Size = new System.Drawing.Size(86, 21);
            this.checkBoxStudybook.TabIndex = 10;
            this.checkBoxStudybook.Text = "Учебник";
            this.checkBoxStudybook.UseVisualStyleBackColor = true;
            this.checkBoxStudybook.Click += new System.EventHandler(this.checkBoxStudybook_Click);
            // 
            // textBoxCoAuthor
            // 
            this.textBoxCoAuthor.Location = new System.Drawing.Point(197, 279);
            this.textBoxCoAuthor.Name = "textBoxCoAuthor";
            this.textBoxCoAuthor.Size = new System.Drawing.Size(277, 22);
            this.textBoxCoAuthor.TabIndex = 11;
            // 
            // textBoxSphere
            // 
            this.textBoxSphere.Location = new System.Drawing.Point(197, 325);
            this.textBoxSphere.Name = "textBoxSphere";
            this.textBoxSphere.Size = new System.Drawing.Size(277, 22);
            this.textBoxSphere.TabIndex = 12;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(33, 76);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(37, 17);
            this.labeltype.TabIndex = 13;
            this.labeltype.Text = "Тип:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(32, 122);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 17);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Название";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(34, 162);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 15;
            this.labelAuthor.Text = "Автор";
            // 
            // labelPublish
            // 
            this.labelPublish.AutoSize = true;
            this.labelPublish.Location = new System.Drawing.Point(34, 201);
            this.labelPublish.Name = "labelPublish";
            this.labelPublish.Size = new System.Drawing.Size(100, 17);
            this.labelPublish.TabIndex = 16;
            this.labelPublish.Text = "Издательство";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(32, 239);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(144, 17);
            this.labelCount.TabIndex = 17;
            this.labelCount.Text = "Количество страниц";
            // 
            // labelCoAuthor
            // 
            this.labelCoAuthor.AutoSize = true;
            this.labelCoAuthor.Location = new System.Drawing.Point(32, 284);
            this.labelCoAuthor.Name = "labelCoAuthor";
            this.labelCoAuthor.Size = new System.Drawing.Size(73, 17);
            this.labelCoAuthor.TabIndex = 18;
            this.labelCoAuthor.Text = "Соавторы";
            // 
            // labelSphere
            // 
            this.labelSphere.AutoSize = true;
            this.labelSphere.Location = new System.Drawing.Point(32, 330);
            this.labelSphere.Name = "labelSphere";
            this.labelSphere.Size = new System.Drawing.Size(97, 17);
            this.labelSphere.TabIndex = 19;
            this.labelSphere.Text = "Направление";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHeader.Location = new System.Drawing.Point(153, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(256, 25);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "Добавление в библиотеку";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.labelSphere);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.labelCoAuthor);
            this.panel1.Controls.Add(this.textboxTitle);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.textBoxAuthor);
            this.panel1.Controls.Add(this.labelPublish);
            this.panel1.Controls.Add(this.textBoxPublishing);
            this.panel1.Controls.Add(this.labelAuthor);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.checkBoxBook);
            this.panel1.Controls.Add(this.labeltype);
            this.panel1.Controls.Add(this.checkBoxStudybook);
            this.panel1.Controls.Add(this.textBoxSphere);
            this.panel1.Controls.Add(this.textBoxCoAuthor);
            this.panel1.Location = new System.Drawing.Point(116, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 540);
            this.panel1.TabIndex = 21;
            // 
            // FormAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 621);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddition";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPublishing;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.CheckBox checkBoxBook;
        private System.Windows.Forms.CheckBox checkBoxStudybook;
        private System.Windows.Forms.TextBox textBoxCoAuthor;
        private System.Windows.Forms.TextBox textBoxSphere;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPublish;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCoAuthor;
        private System.Windows.Forms.Label labelSphere;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
    }
}