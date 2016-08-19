namespace book_compiler
{
    partial class BookCLexicalAnalyzer
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
            this.btnread = new System.Windows.Forms.Button();
            this.rtbxleximcheck = new System.Windows.Forms.RichTextBox();
            this.rtbxNotepad = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvLexeme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxLineNum = new System.Windows.Forms.TextBox();
            this.rtbxerrorlist = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(464, 564);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "READ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // rtbxleximcheck
            // 
            this.rtbxleximcheck.BackColor = System.Drawing.Color.Tan;
            this.rtbxleximcheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxleximcheck.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxleximcheck.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbxleximcheck.Location = new System.Drawing.Point(529, 163);
            this.rtbxleximcheck.Name = "rtbxleximcheck";
            this.rtbxleximcheck.ReadOnly = true;
            this.rtbxleximcheck.Size = new System.Drawing.Size(361, 395);
            this.rtbxleximcheck.TabIndex = 7;
            this.rtbxleximcheck.Text = "";
            this.rtbxleximcheck.VScroll += new System.EventHandler(this.rtbxleximcheck_VScroll);
            // 
            // rtbxNotepad
            // 
            this.rtbxNotepad.BackColor = System.Drawing.Color.Tan;
            this.rtbxNotepad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxNotepad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxNotepad.Location = new System.Drawing.Point(123, 163);
            this.rtbxNotepad.Name = "rtbxNotepad";
            this.rtbxNotepad.Size = new System.Drawing.Size(347, 395);
            this.rtbxNotepad.TabIndex = 6;
            this.rtbxNotepad.Text = "";
            this.rtbxNotepad.VScroll += new System.EventHandler(this.rtbxNotepad_VScroll);
            this.rtbxNotepad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbxNotepad_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::book_compiler.Properties.Resources.openbook3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(938, 619);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lvLexeme
            // 
            this.lvLexeme.BackColor = System.Drawing.Color.Tan;
            this.lvLexeme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLexeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvLexeme.Font = new System.Drawing.Font("Cambria", 12F);
            this.lvLexeme.Location = new System.Drawing.Point(529, 163);
            this.lvLexeme.Name = "lvLexeme";
            this.lvLexeme.Size = new System.Drawing.Size(361, 395);
            this.lvLexeme.TabIndex = 11;
            this.lvLexeme.UseCompatibleStateImageBehavior = false;
            this.lvLexeme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lexeme";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Token";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Validity";
            this.columnHeader3.Width = 120;
            // 
            // tbxLineNum
            // 
            this.tbxLineNum.BackColor = System.Drawing.Color.Tan;
            this.tbxLineNum.Enabled = false;
            this.tbxLineNum.Font = new System.Drawing.Font("Cambria", 12F);
            this.tbxLineNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxLineNum.Location = new System.Drawing.Point(98, 163);
            this.tbxLineNum.Multiline = true;
            this.tbxLineNum.Name = "tbxLineNum";
            this.tbxLineNum.Size = new System.Drawing.Size(25, 395);
            this.tbxLineNum.TabIndex = 12;
            // 
            // rtbxerrorlist
            // 
            this.rtbxerrorlist.BackColor = System.Drawing.Color.BurlyWood;
            this.rtbxerrorlist.Font = new System.Drawing.Font("Cambria", 12F);
            this.rtbxerrorlist.Location = new System.Drawing.Point(98, 595);
            this.rtbxerrorlist.Name = "rtbxerrorlist";
            this.rtbxerrorlist.Size = new System.Drawing.Size(792, 110);
            this.rtbxerrorlist.TabIndex = 13;
            this.rtbxerrorlist.Text = "";
            // 
            // BookCLexicalAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::book_compiler.Properties.Resources.Brown_Wallpaper_Free_Download;
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.rtbxerrorlist);
            this.Controls.Add(this.tbxLineNum);
            this.Controls.Add(this.lvLexeme);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.rtbxleximcheck);
            this.Controls.Add(this.rtbxNotepad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookCLexicalAnalyzer";
            this.Text = "BookCLexicalAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.RichTextBox rtbxleximcheck;
        private System.Windows.Forms.RichTextBox rtbxNotepad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvLexeme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbxLineNum;
        private System.Windows.Forms.RichTextBox rtbxerrorlist;
    }
}