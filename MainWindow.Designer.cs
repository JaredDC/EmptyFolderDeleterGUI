namespace ao_id_extractor
{
    partial class MainWindow
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
            this.tbAOFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectOutFolder = new System.Windows.Forms.Button();
            this.btnPrintOutFolder = new System.Windows.Forms.Button();
            this.tbOutFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFromRegistry = new System.Windows.Forms.Button();
            this.btnSelectAOFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbExportType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExtractionMode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAOFolder
            // 
            this.tbAOFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAOFolder.Location = new System.Drawing.Point(142, 64);
            this.tbAOFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbAOFolder.Name = "tbAOFolder";
            this.tbAOFolder.Size = new System.Drawing.Size(592, 28);
            this.tbAOFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelectOutFolder);
            this.groupBox1.Controls.Add(this.btnPrintOutFolder);
            this.groupBox1.Controls.Add(this.tbOutFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1010, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // btnSelectOutFolder
            // 
            this.btnSelectOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOutFolder.Location = new System.Drawing.Point(830, 24);
            this.btnSelectOutFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOutFolder.Name = "btnSelectOutFolder";
            this.btnSelectOutFolder.Size = new System.Drawing.Size(80, 32);
            this.btnSelectOutFolder.TabIndex = 5;
            this.btnSelectOutFolder.Text = "Select";
            this.btnSelectOutFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutFolder.Click += new System.EventHandler(this.btnSelectOutFolder_Click);
            // 
            // btnPrintOutFolder
            // 
            this.btnPrintOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintOutFolder.Location = new System.Drawing.Point(920, 24);
            this.btnPrintOutFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintOutFolder.Name = "btnPrintOutFolder";
            this.btnPrintOutFolder.Size = new System.Drawing.Size(80, 32);
            this.btnPrintOutFolder.TabIndex = 5;
            this.btnPrintOutFolder.Text = "Print";
            this.btnPrintOutFolder.UseVisualStyleBackColor = true;
            this.btnPrintOutFolder.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbOutFolder
            // 
            this.tbOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutFolder.Location = new System.Drawing.Point(142, 26);
            this.tbOutFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutFolder.Name = "tbOutFolder";
            this.tbOutFolder.Size = new System.Drawing.Size(680, 28);
            this.tbOutFolder.TabIndex = 3;
            this.tbOutFolder.TextChanged += new System.EventHandler(this.tbOutFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Folder:";
            // 
            // btnSelectFromRegistry
            // 
            this.btnSelectFromRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFromRegistry.Location = new System.Drawing.Point(746, 61);
            this.btnSelectFromRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFromRegistry.Name = "btnSelectFromRegistry";
            this.btnSelectFromRegistry.Size = new System.Drawing.Size(134, 32);
            this.btnSelectFromRegistry.TabIndex = 7;
            this.btnSelectFromRegistry.Text = "From Registry";
            this.btnSelectFromRegistry.UseVisualStyleBackColor = true;
            this.btnSelectFromRegistry.Click += new System.EventHandler(this.btnSelectFromRegistry_Click);
            // 
            // btnSelectAOFolder
            // 
            this.btnSelectAOFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAOFolder.Location = new System.Drawing.Point(888, 61);
            this.btnSelectAOFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAOFolder.Name = "btnSelectAOFolder";
            this.btnSelectAOFolder.Size = new System.Drawing.Size(112, 32);
            this.btnSelectAOFolder.TabIndex = 6;
            this.btnSelectAOFolder.Text = "Select";
            this.btnSelectAOFolder.UseVisualStyleBackColor = true;
            this.btnSelectAOFolder.Click += new System.EventHandler(this.btnSelectAOFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "AO Main Folder:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbExportType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbExtractionMode);
            this.groupBox2.Location = new System.Drawing.Point(9, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1010, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Export Type:";
            // 
            // cbExportType
            // 
            this.cbExportType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportType.FormattingEnabled = true;
            this.cbExportType.Items.AddRange(new object[] {
            "Text List",
            "JSON",
            "Both"});
            this.cbExportType.Location = new System.Drawing.Point(819, 26);
            this.cbExportType.Margin = new System.Windows.Forms.Padding(4);
            this.cbExportType.Name = "cbExportType";
            this.cbExportType.Size = new System.Drawing.Size(180, 26);
            this.cbExportType.TabIndex = 4;
            this.cbExportType.SelectedIndexChanged += new System.EventHandler(this.cbExportType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Extraction Mode:";
            // 
            // cbExtractionMode
            // 
            this.cbExtractionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtractionMode.FormattingEnabled = true;
            this.cbExtractionMode.Items.AddRange(new object[] {
            "Item Extraction",
            "Location Extraction",
            "Resource Extraction",
            "Dump All XML",
            "Extract Items & Locations & Resource"});
            this.cbExtractionMode.Location = new System.Drawing.Point(148, 26);
            this.cbExtractionMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbExtractionMode.Name = "cbExtractionMode";
            this.cbExtractionMode.Size = new System.Drawing.Size(180, 26);
            this.cbExtractionMode.TabIndex = 0;
            this.cbExtractionMode.SelectedIndexChanged += new System.EventHandler(this.cbExtractionMode_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbConsole);
            this.groupBox3.Location = new System.Drawing.Point(9, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1010, 530);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console";
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.Location = new System.Drawing.Point(9, 28);
            this.tbConsole.Margin = new System.Windows.Forms.Padding(4);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(990, 485);
            this.tbConsole.TabIndex = 0;
            this.tbConsole.WordWrap = false;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Location = new System.Drawing.Point(897, 652);
            this.btnExtract.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(112, 32);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "Clean";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(20, 652);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(460, 652);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(754, 536);
            this.Name = "MainWindow";
            this.Text = "Empty Folder Deleter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbAOFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOutFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAOFolder;
        private System.Windows.Forms.Button btnSelectOutFolder;
        private System.Windows.Forms.Button btnPrintOutFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbExtractionMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbExportType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSelectFromRegistry;
        public System.Windows.Forms.TextBox tbConsole;
    }
}