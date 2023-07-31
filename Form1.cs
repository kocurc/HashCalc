namespace HashCalc
{
    public partial class HashCalcForm : Form
    {
        public HashCalcForm()
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCalcForm));
            DataFormatLabel = new Label();
            DataFormatComboBox = new ComboBox();
            DataValueLabel = new Label();
            DataValueTextBox = new TextBox();
            EllipsisFileButton = new Button();
            DataSourcePanel = new Panel();
            HashesPanel = new Panel();
            EDonkeyHashTextBox = new TextBox();
            CRC32HashTextBox = new TextBox();
            Adler32HashTextBox = new TextBox();
            MD2HashTextBox = new TextBox();
            TigerHashTextBox = new TextBox();
            PanamaHashTextBox = new TextBox();
            RIPEMD160HashTextBox = new TextBox();
            SHA512HashTextBox = new TextBox();
            SHA384HashTextBox = new TextBox();
            SHA256HashTextBox = new TextBox();
            SHA1HashTextBox = new TextBox();
            MD4HashTextBox = new TextBox();
            MD5HashTextBox = new TextBox();
            EDonkeyCheckBox = new CheckBox();
            CRC32CheckBox = new CheckBox();
            Adler32CheckBox = new CheckBox();
            MD2CheckBox = new CheckBox();
            TigerCheckBox = new CheckBox();
            PanamaCheckBox = new CheckBox();
            RIPEMD160CheckBox = new CheckBox();
            SHA512CheckBox = new CheckBox();
            SHA384CheckBox = new CheckBox();
            SHA256CheckBox = new CheckBox();
            SHA1CheckBox = new CheckBox();
            MD4CheckBox = new CheckBox();
            MD5CheckBox = new CheckBox();
            FooterPanel = new Panel();
            HelpButton = new Button();
            CloseButton = new Button();
            LogoPictureBox = new PictureBox();
            DataSourcePanel.SuspendLayout();
            HashesPanel.SuspendLayout();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DataFormatLabel
            // 
            DataFormatLabel.AutoSize = true;
            DataFormatLabel.Location = new Point(3, 12);
            DataFormatLabel.Name = "DataFormatLabel";
            DataFormatLabel.Size = new Size(75, 15);
            DataFormatLabel.TabIndex = 0;
            DataFormatLabel.Text = "Data Format:";
            // 
            // DataFormatComboBox
            // 
            DataFormatComboBox.FormattingEnabled = true;
            DataFormatComboBox.Location = new Point(3, 30);
            DataFormatComboBox.Name = "DataFormatComboBox";
            DataFormatComboBox.Size = new Size(75, 23);
            DataFormatComboBox.TabIndex = 1;
            // 
            // DataValueLabel
            // 
            DataValueLabel.AutoSize = true;
            DataValueLabel.Location = new Point(92, 12);
            DataValueLabel.Name = "DataValueLabel";
            DataValueLabel.Size = new Size(34, 15);
            DataValueLabel.TabIndex = 2;
            DataValueLabel.Text = "Data:";
            // 
            // DataValueTextBox
            // 
            DataValueTextBox.Location = new Point(84, 31);
            DataValueTextBox.Name = "DataValueTextBox";
            DataValueTextBox.Size = new Size(100, 23);
            DataValueTextBox.TabIndex = 3;
            // 
            // EllipsisFileButton
            // 
            EllipsisFileButton.BackColor = SystemColors.ScrollBar;
            EllipsisFileButton.Location = new Point(190, 30);
            EllipsisFileButton.Name = "EllipsisFileButton";
            EllipsisFileButton.Size = new Size(38, 23);
            EllipsisFileButton.TabIndex = 4;
            EllipsisFileButton.Text = "...";
            EllipsisFileButton.UseVisualStyleBackColor = false;
            // 
            // DataSourcePanel
            // 
            DataSourcePanel.Controls.Add(DataFormatLabel);
            DataSourcePanel.Controls.Add(DataFormatComboBox);
            DataSourcePanel.Controls.Add(DataValueLabel);
            DataSourcePanel.Controls.Add(DataValueTextBox);
            DataSourcePanel.Controls.Add(EllipsisFileButton);
            DataSourcePanel.Location = new Point(12, 9);
            DataSourcePanel.Name = "DataSourcePanel";
            DataSourcePanel.Size = new Size(290, 70);
            DataSourcePanel.TabIndex = 5;
            // 
            // HashesPanel
            // 
            HashesPanel.Controls.Add(EDonkeyHashTextBox);
            HashesPanel.Controls.Add(CRC32HashTextBox);
            HashesPanel.Controls.Add(Adler32HashTextBox);
            HashesPanel.Controls.Add(MD2HashTextBox);
            HashesPanel.Controls.Add(TigerHashTextBox);
            HashesPanel.Controls.Add(PanamaHashTextBox);
            HashesPanel.Controls.Add(RIPEMD160HashTextBox);
            HashesPanel.Controls.Add(SHA512HashTextBox);
            HashesPanel.Controls.Add(SHA384HashTextBox);
            HashesPanel.Controls.Add(SHA256HashTextBox);
            HashesPanel.Controls.Add(SHA1HashTextBox);
            HashesPanel.Controls.Add(MD4HashTextBox);
            HashesPanel.Controls.Add(MD5HashTextBox);
            HashesPanel.Controls.Add(EDonkeyCheckBox);
            HashesPanel.Controls.Add(CRC32CheckBox);
            HashesPanel.Controls.Add(Adler32CheckBox);
            HashesPanel.Controls.Add(MD2CheckBox);
            HashesPanel.Controls.Add(TigerCheckBox);
            HashesPanel.Controls.Add(PanamaCheckBox);
            HashesPanel.Controls.Add(RIPEMD160CheckBox);
            HashesPanel.Controls.Add(SHA512CheckBox);
            HashesPanel.Controls.Add(SHA384CheckBox);
            HashesPanel.Controls.Add(SHA256CheckBox);
            HashesPanel.Controls.Add(SHA1CheckBox);
            HashesPanel.Controls.Add(MD4CheckBox);
            HashesPanel.Controls.Add(MD5CheckBox);
            HashesPanel.Location = new Point(12, 85);
            HashesPanel.Name = "HashesPanel";
            HashesPanel.Size = new Size(290, 326);
            HashesPanel.TabIndex = 6;
            // 
            // EDonkeyHashTextBox
            // 
            EDonkeyHashTextBox.Location = new Point(92, 303);
            EDonkeyHashTextBox.Name = "EDonkeyHashTextBox";
            EDonkeyHashTextBox.ReadOnly = true;
            EDonkeyHashTextBox.Size = new Size(194, 23);
            EDonkeyHashTextBox.TabIndex = 13;
            // 
            // CRC32HashTextBox
            // 
            CRC32HashTextBox.Location = new Point(92, 278);
            CRC32HashTextBox.Name = "CRC32HashTextBox";
            CRC32HashTextBox.ReadOnly = true;
            CRC32HashTextBox.Size = new Size(194, 23);
            CRC32HashTextBox.TabIndex = 13;
            // 
            // Adler32HashTextBox
            // 
            Adler32HashTextBox.Location = new Point(92, 253);
            Adler32HashTextBox.Name = "Adler32HashTextBox";
            Adler32HashTextBox.ReadOnly = true;
            Adler32HashTextBox.Size = new Size(195, 23);
            Adler32HashTextBox.TabIndex = 13;
            // 
            // MD2HashTextBox
            // 
            MD2HashTextBox.Location = new Point(92, 228);
            MD2HashTextBox.Name = "MD2HashTextBox";
            MD2HashTextBox.ReadOnly = true;
            MD2HashTextBox.Size = new Size(194, 23);
            MD2HashTextBox.TabIndex = 13;
            // 
            // TigerHashTextBox
            // 
            TigerHashTextBox.Location = new Point(92, 203);
            TigerHashTextBox.Name = "TigerHashTextBox";
            TigerHashTextBox.ReadOnly = true;
            TigerHashTextBox.Size = new Size(194, 23);
            TigerHashTextBox.TabIndex = 13;
            // 
            // PanamaHashTextBox
            // 
            PanamaHashTextBox.Location = new Point(92, 178);
            PanamaHashTextBox.Name = "PanamaHashTextBox";
            PanamaHashTextBox.ReadOnly = true;
            PanamaHashTextBox.Size = new Size(194, 23);
            PanamaHashTextBox.TabIndex = 13;
            // 
            // RIPEMD160HashTextBox
            // 
            RIPEMD160HashTextBox.Location = new Point(92, 153);
            RIPEMD160HashTextBox.Name = "RIPEMD160HashTextBox";
            RIPEMD160HashTextBox.ReadOnly = true;
            RIPEMD160HashTextBox.Size = new Size(194, 23);
            RIPEMD160HashTextBox.TabIndex = 13;
            // 
            // SHA512HashTextBox
            // 
            SHA512HashTextBox.Location = new Point(92, 128);
            SHA512HashTextBox.Name = "SHA512HashTextBox";
            SHA512HashTextBox.ReadOnly = true;
            SHA512HashTextBox.Size = new Size(194, 23);
            SHA512HashTextBox.TabIndex = 13;
            // 
            // SHA384HashTextBox
            // 
            SHA384HashTextBox.Location = new Point(92, 103);
            SHA384HashTextBox.Name = "SHA384HashTextBox";
            SHA384HashTextBox.ReadOnly = true;
            SHA384HashTextBox.Size = new Size(194, 23);
            SHA384HashTextBox.TabIndex = 13;
            // 
            // SHA256HashTextBox
            // 
            SHA256HashTextBox.Location = new Point(92, 78);
            SHA256HashTextBox.Name = "SHA256HashTextBox";
            SHA256HashTextBox.ReadOnly = true;
            SHA256HashTextBox.Size = new Size(194, 23);
            SHA256HashTextBox.TabIndex = 13;
            // 
            // SHA1HashTextBox
            // 
            SHA1HashTextBox.Location = new Point(92, 53);
            SHA1HashTextBox.Name = "SHA1HashTextBox";
            SHA1HashTextBox.ReadOnly = true;
            SHA1HashTextBox.Size = new Size(194, 23);
            SHA1HashTextBox.TabIndex = 13;
            // 
            // MD4HashTextBox
            // 
            MD4HashTextBox.Location = new Point(92, 28);
            MD4HashTextBox.Name = "MD4HashTextBox";
            MD4HashTextBox.ReadOnly = true;
            MD4HashTextBox.Size = new Size(194, 23);
            MD4HashTextBox.TabIndex = 13;
            // 
            // MD5HashTextBox
            // 
            MD5HashTextBox.Location = new Point(92, 3);
            MD5HashTextBox.Name = "MD5HashTextBox";
            MD5HashTextBox.ReadOnly = true;
            MD5HashTextBox.Size = new Size(194, 23);
            MD5HashTextBox.TabIndex = 13;
            // 
            // EDonkeyCheckBox
            // 
            EDonkeyCheckBox.AutoSize = true;
            EDonkeyCheckBox.Location = new Point(3, 303);
            EDonkeyCheckBox.Name = "EDonkeyCheckBox";
            EDonkeyCheckBox.Size = new Size(72, 19);
            EDonkeyCheckBox.TabIndex = 12;
            EDonkeyCheckBox.Text = "eDonkey";
            EDonkeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CRC32CheckBox
            // 
            CRC32CheckBox.AutoSize = true;
            CRC32CheckBox.Location = new Point(3, 278);
            CRC32CheckBox.Name = "CRC32CheckBox";
            CRC32CheckBox.Size = new Size(61, 19);
            CRC32CheckBox.TabIndex = 11;
            CRC32CheckBox.Text = "CRC32";
            CRC32CheckBox.UseVisualStyleBackColor = true;
            // 
            // Adler32CheckBox
            // 
            Adler32CheckBox.AutoSize = true;
            Adler32CheckBox.Location = new Point(3, 253);
            Adler32CheckBox.Name = "Adler32CheckBox";
            Adler32CheckBox.Size = new Size(73, 19);
            Adler32CheckBox.TabIndex = 10;
            Adler32CheckBox.Text = "ADLER32";
            Adler32CheckBox.UseVisualStyleBackColor = true;
            // 
            // MD2CheckBox
            // 
            MD2CheckBox.AutoSize = true;
            MD2CheckBox.Location = new Point(3, 228);
            MD2CheckBox.Name = "MD2CheckBox";
            MD2CheckBox.Size = new Size(51, 19);
            MD2CheckBox.TabIndex = 9;
            MD2CheckBox.Text = "MD2";
            MD2CheckBox.UseVisualStyleBackColor = true;
            // 
            // TigerCheckBox
            // 
            TigerCheckBox.AutoSize = true;
            TigerCheckBox.Location = new Point(3, 203);
            TigerCheckBox.Name = "TigerCheckBox";
            TigerCheckBox.Size = new Size(56, 19);
            TigerCheckBox.TabIndex = 8;
            TigerCheckBox.Text = "TIGER";
            TigerCheckBox.UseVisualStyleBackColor = true;
            // 
            // PanamaCheckBox
            // 
            PanamaCheckBox.AutoSize = true;
            PanamaCheckBox.Location = new Point(3, 178);
            PanamaCheckBox.Name = "PanamaCheckBox";
            PanamaCheckBox.Size = new Size(76, 19);
            PanamaCheckBox.TabIndex = 7;
            PanamaCheckBox.Text = "PANAMA";
            PanamaCheckBox.UseVisualStyleBackColor = true;
            // 
            // RIPEMD160CheckBox
            // 
            RIPEMD160CheckBox.AutoSize = true;
            RIPEMD160CheckBox.Location = new Point(3, 153);
            RIPEMD160CheckBox.Name = "RIPEMD160CheckBox";
            RIPEMD160CheckBox.Size = new Size(86, 19);
            RIPEMD160CheckBox.TabIndex = 6;
            RIPEMD160CheckBox.Text = "RIPEMD160";
            RIPEMD160CheckBox.UseVisualStyleBackColor = true;
            // 
            // SHA512CheckBox
            // 
            SHA512CheckBox.AutoSize = true;
            SHA512CheckBox.Location = new Point(3, 128);
            SHA512CheckBox.Name = "SHA512CheckBox";
            SHA512CheckBox.Size = new Size(67, 19);
            SHA512CheckBox.TabIndex = 5;
            SHA512CheckBox.Text = "SHA512";
            SHA512CheckBox.UseVisualStyleBackColor = true;
            // 
            // SHA384CheckBox
            // 
            SHA384CheckBox.AutoSize = true;
            SHA384CheckBox.Location = new Point(3, 103);
            SHA384CheckBox.Name = "SHA384CheckBox";
            SHA384CheckBox.Size = new Size(67, 19);
            SHA384CheckBox.TabIndex = 4;
            SHA384CheckBox.Text = "SHA384";
            SHA384CheckBox.UseVisualStyleBackColor = true;
            // 
            // SHA256CheckBox
            // 
            SHA256CheckBox.AutoSize = true;
            SHA256CheckBox.Location = new Point(3, 78);
            SHA256CheckBox.Name = "SHA256CheckBox";
            SHA256CheckBox.Size = new Size(67, 19);
            SHA256CheckBox.TabIndex = 3;
            SHA256CheckBox.Text = "SHA256";
            SHA256CheckBox.UseVisualStyleBackColor = true;
            // 
            // SHA1CheckBox
            // 
            SHA1CheckBox.AutoSize = true;
            SHA1CheckBox.Location = new Point(3, 53);
            SHA1CheckBox.Name = "SHA1CheckBox";
            SHA1CheckBox.Size = new Size(55, 19);
            SHA1CheckBox.TabIndex = 2;
            SHA1CheckBox.Text = "SHA1";
            SHA1CheckBox.UseVisualStyleBackColor = true;
            // 
            // MD4CheckBox
            // 
            MD4CheckBox.AutoSize = true;
            MD4CheckBox.Location = new Point(3, 28);
            MD4CheckBox.Name = "MD4CheckBox";
            MD4CheckBox.Size = new Size(51, 19);
            MD4CheckBox.TabIndex = 1;
            MD4CheckBox.Text = "MD4";
            MD4CheckBox.UseVisualStyleBackColor = true;
            // 
            // MD5CheckBox
            // 
            MD5CheckBox.AutoSize = true;
            MD5CheckBox.Location = new Point(3, 3);
            MD5CheckBox.Name = "MD5CheckBox";
            MD5CheckBox.Size = new Size(51, 19);
            MD5CheckBox.TabIndex = 0;
            MD5CheckBox.Text = "MD5";
            MD5CheckBox.UseVisualStyleBackColor = true;
            // 
            // FooterPanel
            // 
            FooterPanel.Controls.Add(HelpButton);
            FooterPanel.Controls.Add(CloseButton);
            FooterPanel.Controls.Add(LogoPictureBox);
            FooterPanel.Location = new Point(12, 417);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(290, 61);
            FooterPanel.TabIndex = 7;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(190, 20);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(75, 23);
            HelpButton.TabIndex = 2;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(109, 20);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.InitialImage = null;
            LogoPictureBox.Location = new Point(3, 3);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(100, 50);
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // HashCalcForm
            // 
            ClientSize = new Size(310, 488);
            Controls.Add(FooterPanel);
            Controls.Add(HashesPanel);
            Controls.Add(DataSourcePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HashCalcForm";
            Text = "HashCalc";
            DataSourcePanel.ResumeLayout(false);
            DataSourcePanel.PerformLayout();
            HashesPanel.ResumeLayout(false);
            HashesPanel.PerformLayout();
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label DataFormatLabel;
        private ComboBox DataFormatComboBox;
        private Label DataValueLabel;
        private TextBox DataValueTextBox;
        private Button EllipsisFileButton;
        private Panel DataSourcePanel;
        private Panel HashesPanel;
        private CheckBox SHA384CheckBox;
        private CheckBox SHA256CheckBox;
        private CheckBox SHA1CheckBox;
        private CheckBox MD4CheckBox;
        private CheckBox MD5CheckBox;
        private CheckBox EDonkeyCheckBox;
        private CheckBox CRC32CheckBox;
        private CheckBox Adler32CheckBox;
        private CheckBox MD2CheckBox;
        private CheckBox TigerCheckBox;
        private CheckBox PanamaCheckBox;
        private CheckBox RIPEMD160CheckBox;
        private CheckBox SHA512CheckBox;
        private Panel FooterPanel;
        private Button HelpButton;
        private Button CloseButton;
        private PictureBox LogoPictureBox;
        private TextBox EDonkeyHashTextBox;
        private TextBox CRC32HashTextBox;
        private TextBox Adler32HashTextBox;
        private TextBox MD2HashTextBox;
        private TextBox TigerHashTextBox;
        private TextBox PanamaHashTextBox;
        private TextBox RIPEMD160HashTextBox;
        private TextBox SHA512HashTextBox;
        private TextBox SHA384HashTextBox;
        private TextBox SHA256HashTextBox;
        private TextBox SHA1HashTextBox;
        private TextBox MD4HashTextBox;
        private TextBox MD5HashTextBox;
    }
}
