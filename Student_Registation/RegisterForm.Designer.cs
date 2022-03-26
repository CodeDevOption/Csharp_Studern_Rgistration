
namespace Student_Registation
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextBoxCourse = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TextBoxFee = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.ButtonUpdate = new MaterialSkin.Controls.MaterialButton();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.TextBoxCourse);
            this.panel1.Controls.Add(this.TextBoxFee);
            this.panel1.Location = new System.Drawing.Point(39, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 357);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(92, 241);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Fee :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(68, 152);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Course :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 66);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Student Name :";
            // 
            // TextBoxName
            // 
            this.TextBoxName.AllowPromptAsInput = true;
            this.TextBoxName.AnimateReadOnly = false;
            this.TextBoxName.AsciiOnly = false;
            this.TextBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxName.BeepOnError = false;
            this.TextBoxName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxName.HidePromptOnLeave = false;
            this.TextBoxName.HideSelection = true;
            this.TextBoxName.Hint = "Name";
            this.TextBoxName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBoxName.LeadingIcon = null;
            this.TextBoxName.Location = new System.Drawing.Point(149, 53);
            this.TextBoxName.Mask = "";
            this.TextBoxName.MaxLength = 32767;
            this.TextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PrefixSuffixText = null;
            this.TextBoxName.PromptChar = '_';
            this.TextBoxName.ReadOnly = false;
            this.TextBoxName.RejectInputOnFirstFailure = false;
            this.TextBoxName.ResetOnPrompt = true;
            this.TextBoxName.ResetOnSpace = true;
            this.TextBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.SelectionLength = 0;
            this.TextBoxName.SelectionStart = 0;
            this.TextBoxName.ShortcutsEnabled = true;
            this.TextBoxName.Size = new System.Drawing.Size(250, 48);
            this.TextBoxName.SkipLiterals = true;
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TabStop = false;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxName.TrailingIcon = null;
            this.TextBoxName.UseSystemPasswordChar = false;
            this.TextBoxName.ValidatingType = null;
            // 
            // TextBoxCourse
            // 
            this.TextBoxCourse.AllowPromptAsInput = true;
            this.TextBoxCourse.AnimateReadOnly = false;
            this.TextBoxCourse.AsciiOnly = false;
            this.TextBoxCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxCourse.BeepOnError = false;
            this.TextBoxCourse.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxCourse.Depth = 0;
            this.TextBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxCourse.HidePromptOnLeave = false;
            this.TextBoxCourse.HideSelection = true;
            this.TextBoxCourse.Hint = "Course";
            this.TextBoxCourse.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBoxCourse.LeadingIcon = null;
            this.TextBoxCourse.Location = new System.Drawing.Point(147, 140);
            this.TextBoxCourse.Mask = "";
            this.TextBoxCourse.MaxLength = 32767;
            this.TextBoxCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxCourse.Name = "TextBoxCourse";
            this.TextBoxCourse.PasswordChar = '\0';
            this.TextBoxCourse.PrefixSuffixText = null;
            this.TextBoxCourse.PromptChar = '_';
            this.TextBoxCourse.ReadOnly = false;
            this.TextBoxCourse.RejectInputOnFirstFailure = false;
            this.TextBoxCourse.ResetOnPrompt = true;
            this.TextBoxCourse.ResetOnSpace = true;
            this.TextBoxCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxCourse.SelectedText = "";
            this.TextBoxCourse.SelectionLength = 0;
            this.TextBoxCourse.SelectionStart = 0;
            this.TextBoxCourse.ShortcutsEnabled = true;
            this.TextBoxCourse.Size = new System.Drawing.Size(250, 48);
            this.TextBoxCourse.SkipLiterals = true;
            this.TextBoxCourse.TabIndex = 1;
            this.TextBoxCourse.TabStop = false;
            this.TextBoxCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxCourse.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxCourse.TrailingIcon = null;
            this.TextBoxCourse.UseSystemPasswordChar = false;
            this.TextBoxCourse.ValidatingType = null;
            // 
            // TextBoxFee
            // 
            this.TextBoxFee.AllowPromptAsInput = true;
            this.TextBoxFee.AnimateReadOnly = false;
            this.TextBoxFee.AsciiOnly = false;
            this.TextBoxFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxFee.BeepOnError = false;
            this.TextBoxFee.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxFee.Depth = 0;
            this.TextBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxFee.HidePromptOnLeave = false;
            this.TextBoxFee.HideSelection = true;
            this.TextBoxFee.Hint = "Fee";
            this.TextBoxFee.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBoxFee.LeadingIcon = null;
            this.TextBoxFee.Location = new System.Drawing.Point(147, 224);
            this.TextBoxFee.Mask = "";
            this.TextBoxFee.MaxLength = 32767;
            this.TextBoxFee.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxFee.Name = "TextBoxFee";
            this.TextBoxFee.PasswordChar = '\0';
            this.TextBoxFee.PrefixSuffixText = null;
            this.TextBoxFee.PromptChar = '_';
            this.TextBoxFee.ReadOnly = false;
            this.TextBoxFee.RejectInputOnFirstFailure = false;
            this.TextBoxFee.ResetOnPrompt = true;
            this.TextBoxFee.ResetOnSpace = true;
            this.TextBoxFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxFee.SelectedText = "";
            this.TextBoxFee.SelectionLength = 0;
            this.TextBoxFee.SelectionStart = 0;
            this.TextBoxFee.ShortcutsEnabled = true;
            this.TextBoxFee.Size = new System.Drawing.Size(250, 48);
            this.TextBoxFee.SkipLiterals = true;
            this.TextBoxFee.TabIndex = 1;
            this.TextBoxFee.TabStop = false;
            this.TextBoxFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxFee.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxFee.TrailingIcon = null;
            this.TextBoxFee.UseSystemPasswordChar = false;
            this.TextBoxFee.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(56, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Student Registation";
            // 
            // ButtonClear
            // 
            this.ButtonClear.AutoSize = false;
            this.ButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClear.Depth = 0;
            this.ButtonClear.HighEmphasis = true;
            this.ButtonClear.Icon = null;
            this.ButtonClear.Location = new System.Drawing.Point(386, 513);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClear.Size = new System.Drawing.Size(114, 36);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClear.UseAccentColor = false;
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.AutoSize = false;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonUpdate.Depth = 0;
            this.ButtonUpdate.HighEmphasis = true;
            this.ButtonUpdate.Icon = null;
            this.ButtonUpdate.Location = new System.Drawing.Point(142, 513);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonUpdate.Size = new System.Drawing.Size(114, 36);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonUpdate.UseAccentColor = false;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = null;
            this.ButtonSave.Location = new System.Drawing.Point(20, 513);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(114, 36);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(515, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 437);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = false;
            this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonDelete.Depth = 0;
            this.ButtonDelete.HighEmphasis = true;
            this.ButtonDelete.Icon = null;
            this.ButtonDelete.Location = new System.Drawing.Point(264, 513);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonDelete.Size = new System.Drawing.Size(114, 36);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDelete.UseAccentColor = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Ditails";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1161, 580);
            this.MinimumSize = new System.Drawing.Size(1161, 580);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxName;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxCourse;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ButtonClear;
        private MaterialSkin.Controls.MaterialButton ButtonUpdate;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton ButtonDelete;
        private System.Windows.Forms.Label label1;
    }
}