namespace ResumeFilterGUI
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
            this.reqKeywordHolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reqKeywordAdd = new System.Windows.Forms.Button();
            this.reqKeywordInput = new System.Windows.Forms.TextBox();
            this.optKeywordInput = new System.Windows.Forms.TextBox();
            this.optKeywordAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.optKeywordHolder = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.reqKeywordUndo = new System.Windows.Forms.Button();
            this.optKeywordClear = new System.Windows.Forms.Button();
            this.reqKeywordClear = new System.Windows.Forms.Button();
            this.optKeywordUndo = new System.Windows.Forms.Button();
            this.resumeHolder = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keywordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resumeInspect = new System.Windows.Forms.RichTextBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reqKeywordHolder
            // 
            this.reqKeywordHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reqKeywordHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqKeywordHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqKeywordHolder.Location = new System.Drawing.Point(12, 37);
            this.reqKeywordHolder.Name = "reqKeywordHolder";
            this.reqKeywordHolder.Size = new System.Drawing.Size(682, 65);
            this.reqKeywordHolder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Required Keywords";
            // 
            // reqKeywordAdd
            // 
            this.reqKeywordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqKeywordAdd.Location = new System.Drawing.Point(343, 114);
            this.reqKeywordAdd.Name = "reqKeywordAdd";
            this.reqKeywordAdd.Size = new System.Drawing.Size(75, 29);
            this.reqKeywordAdd.TabIndex = 3;
            this.reqKeywordAdd.Text = "Add";
            this.reqKeywordAdd.UseVisualStyleBackColor = true;
            this.reqKeywordAdd.Click += new System.EventHandler(this.reqKeywordAdd_Click);
            // 
            // reqKeywordInput
            // 
            this.reqKeywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqKeywordInput.Location = new System.Drawing.Point(12, 117);
            this.reqKeywordInput.Name = "reqKeywordInput";
            this.reqKeywordInput.Size = new System.Drawing.Size(315, 26);
            this.reqKeywordInput.TabIndex = 4;
            this.reqKeywordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reqKeywordInput_KeyDown);
            // 
            // optKeywordInput
            // 
            this.optKeywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optKeywordInput.Location = new System.Drawing.Point(12, 251);
            this.optKeywordInput.Name = "optKeywordInput";
            this.optKeywordInput.Size = new System.Drawing.Size(315, 26);
            this.optKeywordInput.TabIndex = 8;
            this.optKeywordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.optKeywordInput_KeyDown);
            // 
            // optKeywordAdd
            // 
            this.optKeywordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optKeywordAdd.Location = new System.Drawing.Point(343, 248);
            this.optKeywordAdd.Name = "optKeywordAdd";
            this.optKeywordAdd.Size = new System.Drawing.Size(75, 29);
            this.optKeywordAdd.TabIndex = 7;
            this.optKeywordAdd.Text = "Add";
            this.optKeywordAdd.UseVisualStyleBackColor = true;
            this.optKeywordAdd.Click += new System.EventHandler(this.optKeywordAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Optional Keywords";
            // 
            // optKeywordHolder
            // 
            this.optKeywordHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.optKeywordHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optKeywordHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optKeywordHolder.Location = new System.Drawing.Point(12, 171);
            this.optKeywordHolder.Name = "optKeywordHolder";
            this.optKeywordHolder.Size = new System.Drawing.Size(682, 65);
            this.optKeywordHolder.TabIndex = 5;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(729, 37);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(146, 29);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter Resumes";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // reqKeywordUndo
            // 
            this.reqKeywordUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqKeywordUndo.Location = new System.Drawing.Point(434, 114);
            this.reqKeywordUndo.Name = "reqKeywordUndo";
            this.reqKeywordUndo.Size = new System.Drawing.Size(75, 29);
            this.reqKeywordUndo.TabIndex = 10;
            this.reqKeywordUndo.Text = "Undo";
            this.reqKeywordUndo.UseVisualStyleBackColor = true;
            this.reqKeywordUndo.Click += new System.EventHandler(this.reqKeywordUndo_Click);
            // 
            // optKeywordClear
            // 
            this.optKeywordClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optKeywordClear.Location = new System.Drawing.Point(527, 248);
            this.optKeywordClear.Name = "optKeywordClear";
            this.optKeywordClear.Size = new System.Drawing.Size(75, 29);
            this.optKeywordClear.TabIndex = 11;
            this.optKeywordClear.Text = "Clear";
            this.optKeywordClear.UseVisualStyleBackColor = true;
            this.optKeywordClear.Click += new System.EventHandler(this.optKeywordClear_Click);
            // 
            // reqKeywordClear
            // 
            this.reqKeywordClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqKeywordClear.Location = new System.Drawing.Point(527, 114);
            this.reqKeywordClear.Name = "reqKeywordClear";
            this.reqKeywordClear.Size = new System.Drawing.Size(75, 29);
            this.reqKeywordClear.TabIndex = 13;
            this.reqKeywordClear.Text = "Clear";
            this.reqKeywordClear.UseVisualStyleBackColor = true;
            this.reqKeywordClear.Click += new System.EventHandler(this.reqKeywordClear_Click);
            // 
            // optKeywordUndo
            // 
            this.optKeywordUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optKeywordUndo.Location = new System.Drawing.Point(434, 248);
            this.optKeywordUndo.Name = "optKeywordUndo";
            this.optKeywordUndo.Size = new System.Drawing.Size(75, 29);
            this.optKeywordUndo.TabIndex = 14;
            this.optKeywordUndo.Text = "Undo";
            this.optKeywordUndo.UseVisualStyleBackColor = true;
            this.optKeywordUndo.Click += new System.EventHandler(this.optKeywordUndo_Click);
            // 
            // resumeHolder
            // 
            this.resumeHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.resumeHolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.keywordColumn,
            this.statusColumn,
            this.typeColumn});
            this.resumeHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeHolder.FullRowSelect = true;
            this.resumeHolder.Location = new System.Drawing.Point(12, 295);
            this.resumeHolder.Name = "resumeHolder";
            this.resumeHolder.Size = new System.Drawing.Size(682, 435);
            this.resumeHolder.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.resumeHolder.TabIndex = 15;
            this.resumeHolder.UseCompatibleStateImageBehavior = false;
            this.resumeHolder.View = System.Windows.Forms.View.Details;
            this.resumeHolder.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.resumeHolder_ColumnWidthChanging);
            this.resumeHolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resumeHolder_MouseClick);
            this.resumeHolder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resumeHolder_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 350;
            // 
            // keywordColumn
            // 
            this.keywordColumn.Text = "Keywords";
            this.keywordColumn.Width = 100;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 150;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 75;
            // 
            // resumeInspect
            // 
            this.resumeInspect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resumeInspect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resumeInspect.Cursor = System.Windows.Forms.Cursors.Default;
            this.resumeInspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeInspect.Location = new System.Drawing.Point(717, 295);
            this.resumeInspect.Name = "resumeInspect";
            this.resumeInspect.ReadOnly = true;
            this.resumeInspect.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resumeInspect.Size = new System.Drawing.Size(261, 400);
            this.resumeInspect.TabIndex = 18;
            this.resumeInspect.Text = "";
            // 
            // approveButton
            // 
            this.approveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.Location = new System.Drawing.Point(809, 701);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(76, 29);
            this.approveButton.TabIndex = 21;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectButton.Location = new System.Drawing.Point(902, 701);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(76, 29);
            this.rejectButton.TabIndex = 20;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(717, 701);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(76, 29);
            this.openButton.TabIndex = 19;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 742);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.resumeInspect);
            this.Controls.Add(this.resumeHolder);
            this.Controls.Add(this.optKeywordUndo);
            this.Controls.Add(this.reqKeywordClear);
            this.Controls.Add(this.optKeywordClear);
            this.Controls.Add(this.reqKeywordUndo);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.optKeywordInput);
            this.Controls.Add(this.optKeywordAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optKeywordHolder);
            this.Controls.Add(this.reqKeywordInput);
            this.Controls.Add(this.reqKeywordAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reqKeywordHolder);
            this.Name = "Form1";
            this.Text = "ResumeFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqKeywordHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reqKeywordAdd;
        private System.Windows.Forms.TextBox reqKeywordInput;
        private System.Windows.Forms.TextBox optKeywordInput;
        private System.Windows.Forms.Button optKeywordAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label optKeywordHolder;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button reqKeywordUndo;
        private System.Windows.Forms.Button optKeywordClear;
        private System.Windows.Forms.Button reqKeywordClear;
        private System.Windows.Forms.Button optKeywordUndo;
        private System.Windows.Forms.ListView resumeHolder;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader keywordColumn;
        private System.Windows.Forms.RichTextBox resumeInspect;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
    }
}

