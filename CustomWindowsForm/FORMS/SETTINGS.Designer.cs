﻿namespace CustomWindowsForm.FORMS
{
    partial class SETTINGS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._MinButton = new CustomWindowsForm.ButtonZ();
            this._MaxButton = new CustomWindowsForm.MinMaxButton();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.lbl_heder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStripZ1 = new CustomWindowsForm.MenuStripZ();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.unduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_NEW = new CustomWindowsForm.ShapedButton();
            this.DGV_TAV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXT_TOTAL_TAX = new CustomWindowsForm.hyflexTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapedButton1 = new CustomWindowsForm.ShapedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_EXCHANGE_RATE = new CustomWindowsForm.hyflexTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStripZ1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TAV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this._MinButton);
            this.TopPanel.Controls.Add(this._MaxButton);
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Controls.Add(this.lbl_heder);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(691, 30);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _MinButton
            // 
            this._MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.Enabled = false;
            this._MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.Location = new System.Drawing.Point(607, 6);
            this._MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MinButton.Name = "_MinButton";
            this._MinButton.Size = new System.Drawing.Size(31, 24);
            this._MinButton.TabIndex = 6;
            this._MinButton.Text = "_";
            this._MinButton.TextLocation_X = 6;
            this._MinButton.TextLocation_Y = -20;
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Visible = false;
            // 
            // _MaxButton
            // 
            this._MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MaxButton.CFormState = CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
            this._MaxButton.DisplayText = "_";
            this._MaxButton.Enabled = false;
            this._MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MaxButton.ForeColor = System.Drawing.Color.White;
            this._MaxButton.Location = new System.Drawing.Point(638, 6);
            this._MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MaxButton.Name = "_MaxButton";
            this._MaxButton.Size = new System.Drawing.Size(31, 24);
            this._MaxButton.TabIndex = 5;
            this._MaxButton.Text = "minMaxButton1";
            this._MaxButton.TextLocation_X = 8;
            this._MaxButton.TextLocation_Y = 6;
            this._MaxButton.UseVisualStyleBackColor = true;
            this._MaxButton.Visible = false;
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(661, 3);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.Red;
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(27, 29);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // lbl_heder
            // 
            this.lbl_heder.AutoSize = true;
            this.lbl_heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_heder.ForeColor = System.Drawing.Color.White;
            this.lbl_heder.Location = new System.Drawing.Point(3, 8);
            this.lbl_heder.Name = "lbl_heder";
            this.lbl_heder.Size = new System.Drawing.Size(89, 20);
            this.lbl_heder.TabIndex = 1;
            this.lbl_heder.Text = "SETTINGS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(689, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 259);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 259);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(2, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 2);
            this.label3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.menuStripZ1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 15);
            this.panel2.TabIndex = 13;
            // 
            // menuStripZ1
            // 
            this.menuStripZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripZ1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripZ1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripZ1.Location = new System.Drawing.Point(295, -7);
            this.menuStripZ1.Name = "menuStripZ1";
            this.menuStripZ1.Size = new System.Drawing.Size(200, 28);
            this.menuStripZ1.TabIndex = 20;
            this.menuStripZ1.Text = "menuStripZ1";
            this.menuStripZ1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.fileToolStripMenuItem.Text = "  File  ";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.newToolStripMenuItem.Text = "New                                 ";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.closeAllToolStripMenuItem.Text = "Close All";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(237, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(237, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(240, 24);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator5,
            this.unduToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.editToolStripMenuItem.Text = "  Edit  ";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.cutToolStripMenuItem.Text = "Cut                             ";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // unduToolStripMenuItem
            // 
            this.unduToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unduToolStripMenuItem.Name = "unduToolStripMenuItem";
            this.unduToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.unduToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(213, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.helpToolStripMenuItem.Text = "  Help  ";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.BTN_NEW);
            this.groupBox1.Controls.Add(this.DGV_TAV);
            this.groupBox1.Controls.Add(this.TXT_TOTAL_TAX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE TAX";
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.BorderColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.BorderWidth = 1;
            this.BTN_NEW.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.BTN_NEW.ButtonText = "";
            this.BTN_NEW.EndColor = System.Drawing.Color.Navy;
            this.BTN_NEW.FlatAppearance.BorderSize = 0;
            this.BTN_NEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BTN_NEW.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW.GradientAngle = 90;
            this.BTN_NEW.Location = new System.Drawing.Point(236, 180);
            this.BTN_NEW.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.BTN_NEW.MouseClickColor2 = System.Drawing.Color.Red;
            this.BTN_NEW.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.BTN_NEW.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.ShowButtontext = true;
            this.BTN_NEW.Size = new System.Drawing.Size(92, 39);
            this.BTN_NEW.StartColor = System.Drawing.Color.Fuchsia;
            this.BTN_NEW.TabIndex = 14;
            this.BTN_NEW.Text = "SAVE";
            this.BTN_NEW.TextLocation_X = 29;
            this.BTN_NEW.TextLocation_Y = 18;
            this.BTN_NEW.Transparent1 = 25;
            this.BTN_NEW.Transparent2 = 250;
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // DGV_TAV
            // 
            this.DGV_TAV.AllowUserToAddRows = false;
            this.DGV_TAV.AllowUserToDeleteRows = false;
            this.DGV_TAV.AllowUserToResizeColumns = false;
            this.DGV_TAV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TAV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_TAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TAV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TAV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_TAV.Location = new System.Drawing.Point(9, 55);
            this.DGV_TAV.MultiSelect = false;
            this.DGV_TAV.Name = "DGV_TAV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TAV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TAV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TAV.Size = new System.Drawing.Size(319, 121);
            this.DGV_TAV.TabIndex = 9;
            this.DGV_TAV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TAV_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tax_type_id";
            this.Column1.HeaderText = "TAX_ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tax_type";
            this.Column2.HeaderText = "TAX TYPE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "precentage";
            this.Column3.HeaderText = "TAX";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // TXT_TOTAL_TAX
            // 
            this.TXT_TOTAL_TAX.Enabled = false;
            this.TXT_TOTAL_TAX.F_color = System.Drawing.Color.LightGreen;
            this.TXT_TOTAL_TAX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_TOTAL_TAX.Location = new System.Drawing.Point(252, 24);
            this.TXT_TOTAL_TAX.Name = "TXT_TOTAL_TAX";
            this.TXT_TOTAL_TAX.Size = new System.Drawing.Size(76, 25);
            this.TXT_TOTAL_TAX.TabIndex = 8;
            this.TXT_TOTAL_TAX.Text = "0";
            this.TXT_TOTAL_TAX.User_null_check = CustomWindowsForm.hyflexTextbox.Resust.False;
            this.TXT_TOTAL_TAX.User_selection = CustomWindowsForm.hyflexTextbox.String_Type.Numeric;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOTAL :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "LIST OF TAX";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox2.Controls.Add(this.shapedButton1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXT_EXCHANGE_RATE);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(347, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 112);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE EXCHANGE RATE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // shapedButton1
            // 
            this.shapedButton1.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderWidth = 1;
            this.shapedButton1.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton1.ButtonText = "";
            this.shapedButton1.EndColor = System.Drawing.Color.Navy;
            this.shapedButton1.FlatAppearance.BorderSize = 0;
            this.shapedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.shapedButton1.ForeColor = System.Drawing.Color.White;
            this.shapedButton1.GradientAngle = 90;
            this.shapedButton1.Location = new System.Drawing.Point(236, 48);
            this.shapedButton1.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.shapedButton1.MouseClickColor2 = System.Drawing.Color.Red;
            this.shapedButton1.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.shapedButton1.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.shapedButton1.Name = "shapedButton1";
            this.shapedButton1.ShowButtontext = true;
            this.shapedButton1.Size = new System.Drawing.Size(92, 39);
            this.shapedButton1.StartColor = System.Drawing.Color.Fuchsia;
            this.shapedButton1.TabIndex = 14;
            this.shapedButton1.Text = "SAVE";
            this.shapedButton1.TextLocation_X = 29;
            this.shapedButton1.TextLocation_Y = 18;
            this.shapedButton1.Transparent1 = 25;
            this.shapedButton1.Transparent2 = 250;
            this.shapedButton1.UseVisualStyleBackColor = false;
            this.shapedButton1.Click += new System.EventHandler(this.shapedButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "NEW EXCHAGE RATE ( 1USD =LKR ? )";
            // 
            // TXT_EXCHANGE_RATE
            // 
            this.TXT_EXCHANGE_RATE.F_color = System.Drawing.Color.LightGreen;
            this.TXT_EXCHANGE_RATE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_EXCHANGE_RATE.Location = new System.Drawing.Point(19, 55);
            this.TXT_EXCHANGE_RATE.Name = "TXT_EXCHANGE_RATE";
            this.TXT_EXCHANGE_RATE.Size = new System.Drawing.Size(190, 25);
            this.TXT_EXCHANGE_RATE.TabIndex = 8;
            this.TXT_EXCHANGE_RATE.Text = "0";
            this.TXT_EXCHANGE_RATE.User_null_check = CustomWindowsForm.hyflexTextbox.Resust.False;
            this.TXT_EXCHANGE_RATE.User_selection = CustomWindowsForm.hyflexTextbox.String_Type.Numeric;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(347, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 105);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EXTRA SETTINGS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(691, 289);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.SETTINGS_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripZ1.ResumeLayout(false);
            this.menuStripZ1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TAV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lbl_heder;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private ButtonZ _MinButton;
        private MinMaxButton _MaxButton;
        private MenuStripZ menuStripZ1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem unduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_TAV;
        private hyflexTextbox TXT_TOTAL_TAX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private ShapedButton BTN_NEW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private ShapedButton shapedButton1;
        private System.Windows.Forms.Label label5;
        private hyflexTextbox TXT_EXCHANGE_RATE;
    }
}