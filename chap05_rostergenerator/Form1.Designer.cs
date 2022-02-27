namespace chap05_rostergenerator
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete1Avail = new System.Windows.Forms.Button();
            this.DeleteAllAvail = new System.Windows.Forms.Button();
            this.AddWriteInPlayerButton = new System.Windows.Forms.Button();
            this.EditAvail = new System.Windows.Forms.Button();
            this.ImportRosterButton = new System.Windows.Forms.Button();
            this.PrintRosterButton = new System.Windows.Forms.Button();
            this.ExportRosterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Move1AvailButton = new System.Windows.Forms.Button();
            this.MoveAllAvailButton = new System.Windows.Forms.Button();
            this.Move1SelButton = new System.Windows.Forms.Button();
            this.MoveAllSelButton = new System.Windows.Forms.Button();
            this.AvailPlayersListBox = new System.Windows.Forms.ListBox();
            this.SelPlayersListBox = new System.Windows.Forms.ListBox();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.ExportRosterFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.WriteInPlayerTextBox = new System.Windows.Forms.TextBox();
            this.MoveSelUpButton = new System.Windows.Forms.Button();
            this.MoveSelDownButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playerMoveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerMoveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roster Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Write-in Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tea&m";
            // 
            // Delete1Avail
            // 
            this.Delete1Avail.Location = new System.Drawing.Point(70, 508);
            this.Delete1Avail.Name = "Delete1Avail";
            this.Delete1Avail.Size = new System.Drawing.Size(108, 23);
            this.Delete1Avail.TabIndex = 6;
            this.Delete1Avail.Text = "&Delete";
            this.Delete1Avail.UseVisualStyleBackColor = true;
            this.Delete1Avail.Click += new System.EventHandler(this.Delete1Avail_Click);
            // 
            // DeleteAllAvail
            // 
            this.DeleteAllAvail.Location = new System.Drawing.Point(70, 554);
            this.DeleteAllAvail.Name = "DeleteAllAvail";
            this.DeleteAllAvail.Size = new System.Drawing.Size(108, 23);
            this.DeleteAllAvail.TabIndex = 7;
            this.DeleteAllAvail.Text = " De&lete All";
            this.DeleteAllAvail.UseVisualStyleBackColor = true;
            this.DeleteAllAvail.Click += new System.EventHandler(this.DeleteAllAvail_Click);
            // 
            // AddWriteInPlayerButton
            // 
            this.AddWriteInPlayerButton.Location = new System.Drawing.Point(201, 461);
            this.AddWriteInPlayerButton.Name = "AddWriteInPlayerButton";
            this.AddWriteInPlayerButton.Size = new System.Drawing.Size(108, 23);
            this.AddWriteInPlayerButton.TabIndex = 8;
            this.AddWriteInPlayerButton.Text = "&Add";
            this.AddWriteInPlayerButton.UseVisualStyleBackColor = true;
            this.AddWriteInPlayerButton.Click += new System.EventHandler(this.AddWriteInPlayerButton_Click);
            // 
            // EditAvail
            // 
            this.EditAvail.Location = new System.Drawing.Point(201, 508);
            this.EditAvail.Name = "EditAvail";
            this.EditAvail.Size = new System.Drawing.Size(108, 23);
            this.EditAvail.TabIndex = 9;
            this.EditAvail.Text = "&Edit";
            this.EditAvail.UseVisualStyleBackColor = true;
            this.EditAvail.Click += new System.EventHandler(this.EditAvail_Click);
            // 
            // ImportRosterButton
            // 
            this.ImportRosterButton.Location = new System.Drawing.Point(201, 554);
            this.ImportRosterButton.Name = "ImportRosterButton";
            this.ImportRosterButton.Size = new System.Drawing.Size(108, 23);
            this.ImportRosterButton.TabIndex = 10;
            this.ImportRosterButton.Text = "&Import Roster";
            this.ImportRosterButton.UseVisualStyleBackColor = true;
            this.ImportRosterButton.Click += new System.EventHandler(this.ImportRosterButton_Click);
            // 
            // PrintRosterButton
            // 
            this.PrintRosterButton.Location = new System.Drawing.Point(383, 508);
            this.PrintRosterButton.Name = "PrintRosterButton";
            this.PrintRosterButton.Size = new System.Drawing.Size(108, 23);
            this.PrintRosterButton.TabIndex = 11;
            this.PrintRosterButton.Text = "&Print Roster";
            this.PrintRosterButton.UseVisualStyleBackColor = true;
            this.PrintRosterButton.Click += new System.EventHandler(this.PrintRosterButton_Click);
            // 
            // ExportRosterButton
            // 
            this.ExportRosterButton.Location = new System.Drawing.Point(383, 554);
            this.ExportRosterButton.Name = "ExportRosterButton";
            this.ExportRosterButton.Size = new System.Drawing.Size(108, 23);
            this.ExportRosterButton.TabIndex = 12;
            this.ExportRosterButton.Text = "Expor&t Roster";
            this.ExportRosterButton.UseVisualStyleBackColor = true;
            this.ExportRosterButton.Click += new System.EventHandler(this.ExportRosterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(383, 592);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Move1AvailButton
            // 
            this.Move1AvailButton.Location = new System.Drawing.Point(268, 171);
            this.Move1AvailButton.Name = "Move1AvailButton";
            this.Move1AvailButton.Size = new System.Drawing.Size(75, 23);
            this.Move1AvailButton.TabIndex = 14;
            this.Move1AvailButton.Text = ">";
            this.Move1AvailButton.UseVisualStyleBackColor = true;
            this.Move1AvailButton.Click += new System.EventHandler(this.Move1AvailButton_Click);
            // 
            // MoveAllAvailButton
            // 
            this.MoveAllAvailButton.Location = new System.Drawing.Point(268, 200);
            this.MoveAllAvailButton.Name = "MoveAllAvailButton";
            this.MoveAllAvailButton.Size = new System.Drawing.Size(75, 23);
            this.MoveAllAvailButton.TabIndex = 15;
            this.MoveAllAvailButton.Text = ">>";
            this.MoveAllAvailButton.UseVisualStyleBackColor = true;
            this.MoveAllAvailButton.Click += new System.EventHandler(this.MoveAllAvailButton_Click);
            // 
            // Move1SelButton
            // 
            this.Move1SelButton.Location = new System.Drawing.Point(268, 229);
            this.Move1SelButton.Name = "Move1SelButton";
            this.Move1SelButton.Size = new System.Drawing.Size(75, 23);
            this.Move1SelButton.TabIndex = 16;
            this.Move1SelButton.Text = "<";
            this.Move1SelButton.UseVisualStyleBackColor = true;
            this.Move1SelButton.Click += new System.EventHandler(this.Move1SelButton_Click);
            // 
            // MoveAllSelButton
            // 
            this.MoveAllSelButton.Location = new System.Drawing.Point(268, 258);
            this.MoveAllSelButton.Name = "MoveAllSelButton";
            this.MoveAllSelButton.Size = new System.Drawing.Size(75, 23);
            this.MoveAllSelButton.TabIndex = 17;
            this.MoveAllSelButton.Text = "<<";
            this.MoveAllSelButton.UseVisualStyleBackColor = true;
            this.MoveAllSelButton.Click += new System.EventHandler(this.MoveAllSelButton_Click);
            // 
            // AvailPlayersListBox
            // 
            this.AvailPlayersListBox.FormattingEnabled = true;
            this.AvailPlayersListBox.Items.AddRange(new object[] {
            "Boswell, Susan",
            "Claus, Santa",
            "Conwell, Adam",
            "Dietz, Carl",
            "Higgs, Rodney",
            "Jennings, Barry",
            "Mendeleson, Cathy",
            "Niker, Gary",
            "Oslund, Matthew",
            "Powell, Joe",
            "Rodriguez, Alex",
            "Ruth, Babe",
            "Smith, Freddie",
            "Stacey, Jack",
            "Trevetone, Donna",
            "Veniere, Henry"});
            this.AvailPlayersListBox.Location = new System.Drawing.Point(70, 171);
            this.AvailPlayersListBox.Name = "AvailPlayersListBox";
            this.AvailPlayersListBox.Size = new System.Drawing.Size(165, 212);
            this.AvailPlayersListBox.Sorted = true;
            this.AvailPlayersListBox.TabIndex = 18;
            // 
            // SelPlayersListBox
            // 
            this.SelPlayersListBox.FormattingEnabled = true;
            this.SelPlayersListBox.Location = new System.Drawing.Point(383, 171);
            this.SelPlayersListBox.Name = "SelPlayersListBox";
            this.SelPlayersListBox.Size = new System.Drawing.Size(165, 212);
            this.SelPlayersListBox.TabIndex = 19;
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Items.AddRange(new object[] {
            "Blue Jays",
            "Orioles",
            "Rays",
            "Red Sox",
            "Yankees"});
            this.TeamComboBox.Location = new System.Drawing.Point(383, 472);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeamComboBox.Sorted = true;
            this.TeamComboBox.TabIndex = 20;
            // 
            // WriteInPlayerTextBox
            // 
            this.WriteInPlayerTextBox.Location = new System.Drawing.Point(70, 464);
            this.WriteInPlayerTextBox.Name = "WriteInPlayerTextBox";
            this.WriteInPlayerTextBox.Size = new System.Drawing.Size(108, 20);
            this.WriteInPlayerTextBox.TabIndex = 21;
            // 
            // MoveSelUpButton
            // 
            this.MoveSelUpButton.Location = new System.Drawing.Point(270, 327);
            this.MoveSelUpButton.Name = "MoveSelUpButton";
            this.MoveSelUpButton.Size = new System.Drawing.Size(75, 23);
            this.MoveSelUpButton.TabIndex = 22;
            this.MoveSelUpButton.Text = "Move &Up";
            this.MoveSelUpButton.UseVisualStyleBackColor = true;
            this.MoveSelUpButton.Click += new System.EventHandler(this.MoveSelUpButton_Click);
            // 
            // MoveSelDownButton
            // 
            this.MoveSelDownButton.Location = new System.Drawing.Point(270, 360);
            this.MoveSelDownButton.Name = "MoveSelDownButton";
            this.MoveSelDownButton.Size = new System.Drawing.Size(75, 23);
            this.MoveSelDownButton.TabIndex = 23;
            this.MoveSelDownButton.Text = "&Move Down";
            this.MoveSelDownButton.UseVisualStyleBackColor = true;
            this.MoveSelDownButton.Click += new System.EventHandler(this.MoveSelDownButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerMoveUpToolStripMenuItem,
            this.playerMoveDownToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // playerMoveUpToolStripMenuItem
            // 
            this.playerMoveUpToolStripMenuItem.Name = "playerMoveUpToolStripMenuItem";
            this.playerMoveUpToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playerMoveUpToolStripMenuItem.Text = "Player Move Up";
            // 
            // playerMoveDownToolStripMenuItem
            // 
            this.playerMoveDownToolStripMenuItem.Name = "playerMoveDownToolStripMenuItem";
            this.playerMoveDownToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playerMoveDownToolStripMenuItem.Text = "Player Move Down";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 676);
            this.Controls.Add(this.MoveSelDownButton);
            this.Controls.Add(this.MoveSelUpButton);
            this.Controls.Add(this.WriteInPlayerTextBox);
            this.Controls.Add(this.TeamComboBox);
            this.Controls.Add(this.SelPlayersListBox);
            this.Controls.Add(this.AvailPlayersListBox);
            this.Controls.Add(this.MoveAllSelButton);
            this.Controls.Add(this.Move1SelButton);
            this.Controls.Add(this.MoveAllAvailButton);
            this.Controls.Add(this.Move1AvailButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportRosterButton);
            this.Controls.Add(this.PrintRosterButton);
            this.Controls.Add(this.ImportRosterButton);
            this.Controls.Add(this.EditAvail);
            this.Controls.Add(this.AddWriteInPlayerButton);
            this.Controls.Add(this.DeleteAllAvail);
            this.Controls.Add(this.Delete1Avail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.Text = "Chapter 5 - Roster Generator";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete1Avail;
        private System.Windows.Forms.Button DeleteAllAvail;
        private System.Windows.Forms.Button AddWriteInPlayerButton;
        private System.Windows.Forms.Button EditAvail;
        private System.Windows.Forms.Button ImportRosterButton;
        private System.Windows.Forms.Button PrintRosterButton;
        private System.Windows.Forms.Button ExportRosterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Move1AvailButton;
        private System.Windows.Forms.Button MoveAllAvailButton;
        private System.Windows.Forms.Button Move1SelButton;
        private System.Windows.Forms.Button MoveAllSelButton;
        private System.Windows.Forms.ListBox AvailPlayersListBox;
        private System.Windows.Forms.ListBox SelPlayersListBox;
        private System.Windows.Forms.ComboBox TeamComboBox;
        private System.Windows.Forms.FolderBrowserDialog ExportRosterFolderBrowserDialog;
        private System.Windows.Forms.TextBox WriteInPlayerTextBox;
        private System.Windows.Forms.Button MoveSelUpButton;
        private System.Windows.Forms.Button MoveSelDownButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerMoveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerMoveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

