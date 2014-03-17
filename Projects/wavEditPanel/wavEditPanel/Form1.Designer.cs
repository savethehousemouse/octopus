namespace wavEditPanel
{
    partial class Form1
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
            this.getFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ProgramLocationBtn = new System.Windows.Forms.Button();
            this.ProgramLocationField = new System.Windows.Forms.TextBox();
            this.cmdLineField = new System.Windows.Forms.TextBox();
            this.DisplacementField = new System.Windows.Forms.TextBox();
            this.BlocklengthField = new System.Windows.Forms.TextBox();
            this.residualField = new System.Windows.Forms.TextBox();
            this.autoSetSeed = new System.Windows.Forms.Button();
            this.seedField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FileOutSelect = new System.Windows.Forms.Button();
            this.fileInSelect = new System.Windows.Forms.Button();
            this.codeInSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileOutField = new System.Windows.Forms.TextBox();
            this.fileInField = new System.Windows.Forms.TextBox();
            this.codeFileField = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.automaticBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.encodeBtn = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getFile
            // 
            this.getFile.DefaultExt = "wav";
            this.getFile.Filter = "Sound Files|*.wav|All Files|*.*";
            this.getFile.RestoreDirectory = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProgramLocationBtn);
            this.tabPage1.Controls.Add(this.ProgramLocationField);
            this.tabPage1.Controls.Add(this.cmdLineField);
            this.tabPage1.Controls.Add(this.DisplacementField);
            this.tabPage1.Controls.Add(this.BlocklengthField);
            this.tabPage1.Controls.Add(this.residualField);
            this.tabPage1.Controls.Add(this.autoSetSeed);
            this.tabPage1.Controls.Add(this.seedField);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.FileOutSelect);
            this.tabPage1.Controls.Add(this.fileInSelect);
            this.tabPage1.Controls.Add(this.codeInSelect);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.fileOutField);
            this.tabPage1.Controls.Add(this.fileInField);
            this.tabPage1.Controls.Add(this.codeFileField);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Program Location:";
            // 
            // ProgramLocationBtn
            // 
            this.ProgramLocationBtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLocationBtn.Location = new System.Drawing.Point(797, 486);
            this.ProgramLocationBtn.Name = "ProgramLocationBtn";
            this.ProgramLocationBtn.Size = new System.Drawing.Size(75, 24);
            this.ProgramLocationBtn.TabIndex = 25;
            this.ProgramLocationBtn.Text = ". . .";
            this.ProgramLocationBtn.UseVisualStyleBackColor = true;
            this.ProgramLocationBtn.Click += new System.EventHandler(this.ProgramLocationBtn_Click);
            // 
            // ProgramLocationField
            // 
            this.ProgramLocationField.Enabled = false;
            this.ProgramLocationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLocationField.Location = new System.Drawing.Point(7, 486);
            this.ProgramLocationField.Name = "ProgramLocationField";
            this.ProgramLocationField.Size = new System.Drawing.Size(753, 22);
            this.ProgramLocationField.TabIndex = 24;
            // 
            // cmdLineField
            // 
            this.cmdLineField.Location = new System.Drawing.Point(7, 520);
            this.cmdLineField.Multiline = true;
            this.cmdLineField.Name = "cmdLineField";
            this.cmdLineField.Size = new System.Drawing.Size(913, 83);
            this.cmdLineField.TabIndex = 23;
            // 
            // DisplacementField
            // 
            this.DisplacementField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplacementField.Location = new System.Drawing.Point(165, 290);
            this.DisplacementField.MaxLength = 20;
            this.DisplacementField.Name = "DisplacementField";
            this.DisplacementField.Size = new System.Drawing.Size(181, 22);
            this.DisplacementField.TabIndex = 22;
            this.DisplacementField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // BlocklengthField
            // 
            this.BlocklengthField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlocklengthField.Location = new System.Drawing.Point(165, 252);
            this.BlocklengthField.Name = "BlocklengthField";
            this.BlocklengthField.Size = new System.Drawing.Size(181, 22);
            this.BlocklengthField.TabIndex = 21;
            this.BlocklengthField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // residualField
            // 
            this.residualField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residualField.Location = new System.Drawing.Point(165, 208);
            this.residualField.Name = "residualField";
            this.residualField.Size = new System.Drawing.Size(67, 22);
            this.residualField.TabIndex = 20;
            this.residualField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // autoSetSeed
            // 
            this.autoSetSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoSetSeed.Location = new System.Drawing.Point(387, 170);
            this.autoSetSeed.Name = "autoSetSeed";
            this.autoSetSeed.Size = new System.Drawing.Size(75, 23);
            this.autoSetSeed.TabIndex = 19;
            this.autoSetSeed.Text = "Auto Set";
            this.autoSetSeed.UseVisualStyleBackColor = true;
            this.autoSetSeed.Click += new System.EventHandler(this.button6_Click);
            // 
            // seedField
            // 
            this.seedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedField.Location = new System.Drawing.Point(165, 171);
            this.seedField.MaxLength = 20;
            this.seedField.Name = "seedField";
            this.seedField.Size = new System.Drawing.Size(181, 22);
            this.seedField.TabIndex = 18;
            this.seedField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Block Length :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Residual / Saltiness :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Displacement :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seed :";
            // 
            // FileOutSelect
            // 
            this.FileOutSelect.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileOutSelect.Location = new System.Drawing.Point(797, 124);
            this.FileOutSelect.Name = "FileOutSelect";
            this.FileOutSelect.Size = new System.Drawing.Size(75, 24);
            this.FileOutSelect.TabIndex = 8;
            this.FileOutSelect.Text = ". . .";
            this.FileOutSelect.UseVisualStyleBackColor = true;
            this.FileOutSelect.Click += new System.EventHandler(this.FileOutSelect_Click);
            // 
            // fileInSelect
            // 
            this.fileInSelect.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInSelect.Location = new System.Drawing.Point(797, 76);
            this.fileInSelect.Name = "fileInSelect";
            this.fileInSelect.Size = new System.Drawing.Size(75, 24);
            this.fileInSelect.TabIndex = 7;
            this.fileInSelect.Text = ". . .";
            this.fileInSelect.UseVisualStyleBackColor = true;
            this.fileInSelect.Click += new System.EventHandler(this.fileInSelect_Click);
            // 
            // codeInSelect
            // 
            this.codeInSelect.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeInSelect.Location = new System.Drawing.Point(797, 32);
            this.codeInSelect.Name = "codeInSelect";
            this.codeInSelect.Size = new System.Drawing.Size(75, 24);
            this.codeInSelect.TabIndex = 6;
            this.codeInSelect.Text = ". . .";
            this.codeInSelect.UseVisualStyleBackColor = true;
            this.codeInSelect.Click += new System.EventHandler(this.codeFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sound File OUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sound File IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Code File";
            // 
            // fileOutField
            // 
            this.fileOutField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOutField.Location = new System.Drawing.Point(7, 124);
            this.fileOutField.Name = "fileOutField";
            this.fileOutField.Size = new System.Drawing.Size(783, 22);
            this.fileOutField.TabIndex = 2;
            this.fileOutField.DoubleClick += new System.EventHandler(this.fileOutField_DoubleClick);
            this.fileOutField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // fileInField
            // 
            this.fileInField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInField.Location = new System.Drawing.Point(7, 76);
            this.fileInField.Name = "fileInField";
            this.fileInField.Size = new System.Drawing.Size(783, 22);
            this.fileInField.TabIndex = 1;
            this.fileInField.DoubleClick += new System.EventHandler(this.fileInField_DoubleClick);
            this.fileInField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // codeFileField
            // 
            this.codeFileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFileField.Location = new System.Drawing.Point(7, 32);
            this.codeFileField.Name = "codeFileField";
            this.codeFileField.Size = new System.Drawing.Size(783, 22);
            this.codeFileField.TabIndex = 0;
            this.codeFileField.DoubleClick += new System.EventHandler(this.codeFileField_DoubleClick);
            this.codeFileField.Leave += new System.EventHandler(this.codeFileField_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // automaticBtn
            // 
            this.automaticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automaticBtn.Location = new System.Drawing.Point(2, 649);
            this.automaticBtn.Name = "automaticBtn";
            this.automaticBtn.Size = new System.Drawing.Size(217, 41);
            this.automaticBtn.TabIndex = 1;
            this.automaticBtn.Text = "Automatic";
            this.automaticBtn.UseVisualStyleBackColor = true;
            this.automaticBtn.Click += new System.EventHandler(this.automaticBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Enabled = false;
            this.ProcessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessBtn.Location = new System.Drawing.Point(610, 649);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(326, 41);
            this.ProcessBtn.TabIndex = 2;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // encodeBtn
            // 
            this.encodeBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.encodeBtn.AutoSize = true;
            this.encodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeBtn.Location = new System.Drawing.Point(357, 656);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(71, 26);
            this.encodeBtn.TabIndex = 3;
            this.encodeBtn.Text = "Encode";
            this.encodeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.CheckedChanged += new System.EventHandler(this.encodeBtn_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "wav";
            this.saveFileDialog1.Filter = "Sound Files|*.wav|All Files|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 691);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.automaticBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog getFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button FileOutSelect;
        private System.Windows.Forms.Button fileInSelect;
        private System.Windows.Forms.Button codeInSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileOutField;
        private System.Windows.Forms.TextBox fileInField;
        private System.Windows.Forms.TextBox codeFileField;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button automaticBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.CheckBox encodeBtn;
        private System.Windows.Forms.TextBox DisplacementField;
        private System.Windows.Forms.TextBox BlocklengthField;
        private System.Windows.Forms.TextBox residualField;
        private System.Windows.Forms.Button autoSetSeed;
        private System.Windows.Forms.TextBox seedField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmdLineField;
        private System.Windows.Forms.Button ProgramLocationBtn;
        private System.Windows.Forms.TextBox ProgramLocationField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

