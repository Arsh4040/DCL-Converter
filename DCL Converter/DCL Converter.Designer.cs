namespace DCL_Converter
{
    partial class DCL_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCL_Converter));
            textBoxFilePath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            btnExport = new Button();
            SuspendLayout();
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.BackColor = SystemColors.ControlLight;
            textBoxFilePath.Location = new Point(25, 162);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(719, 43);
            textBoxFilePath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(135, 101);
            label1.Name = "label1";
            label1.Size = new Size(496, 30);
            label1.TabIndex = 1;
            label1.Text = "Convert DCL files into DCL Embedded AutoLISP files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(156, 30);
            label2.Name = "label2";
            label2.Size = new Size(462, 57);
            label2.TabIndex = 2;
            label2.Text = "DCL to LISP Converter";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 8F);
            btnBrowse.ForeColor = SystemColors.ActiveCaptionText;
            btnBrowse.Location = new Point(174, 258);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(155, 57);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExport
            // 
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft Sans Serif", 8F);
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Location = new Point(416, 258);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(155, 57);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // DCL_Converter
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(774, 360);
            Controls.Add(btnExport);
            Controls.Add(btnBrowse);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFilePath);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DCL_Converter";
            Text = "  DCL Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilePath;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private Button btnExport;
    }
}
