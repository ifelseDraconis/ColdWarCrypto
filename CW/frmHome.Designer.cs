namespace ColdWarCrypto
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblPrompt = new Label();
            btnGoCommand = new Button();
            txtCommandBox = new TextBox();
            picGiff = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGiff).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShortcutKeys = Keys.F1;
            helpToolStripMenuItem.Size = new Size(129, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(129, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(256, 212);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(124, 15);
            lblPrompt.TabIndex = 1;
            lblPrompt.Text = "What is the password?";
            lblPrompt.Click += lblPrompt_Click;
            // 
            // btnGoCommand
            // 
            btnGoCommand.Location = new Point(428, 259);
            btnGoCommand.Name = "btnGoCommand";
            btnGoCommand.Size = new Size(75, 23);
            btnGoCommand.TabIndex = 2;
            btnGoCommand.Text = "Proceed";
            btnGoCommand.UseVisualStyleBackColor = true;
            btnGoCommand.Click += btnGoCommand_ClickAsync;
            // 
            // txtCommandBox
            // 
            txtCommandBox.Location = new Point(256, 230);
            txtCommandBox.Name = "txtCommandBox";
            txtCommandBox.Size = new Size(247, 23);
            txtCommandBox.TabIndex = 3;
            // 
            // picGiff
            // 
            picGiff.Image = (Image)resources.GetObject("picGiff.Image");
            picGiff.Location = new Point(531, 52);
            picGiff.Name = "picGiff";
            picGiff.Size = new Size(190, 175);
            picGiff.TabIndex = 4;
            picGiff.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picGiff);
            Controls.Add(txtCommandBox);
            Controls.Add(btnGoCommand);
            Controls.Add(lblPrompt);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHome";
            Text = "Welcome Agent";
            Load += frmHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGiff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblPrompt;
        private Button btnGoCommand;
        private TextBox txtCommandBox;
        private PictureBox picGiff;
    }
}
