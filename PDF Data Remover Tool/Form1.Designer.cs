namespace Sample_UI_Application
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.tbSearchExpression = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaskRemovedText = new System.Windows.Forms.CheckBox();
            this.cbMakeUnsearchable = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pdfViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfViewerControl1.CacheVisitedPages = true;
            this.pdfViewerControl1.Location = new System.Drawing.Point(275, 28);
            this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.RegistrationKey = null;
            this.pdfViewerControl1.RegistrationName = null;
            this.pdfViewerControl1.ShowToolbarFind = false;
            this.pdfViewerControl1.Size = new System.Drawing.Size(866, 662);
            this.pdfViewerControl1.TabIndex = 0;
            this.pdfViewerControl1.PreProcessKey += new Bytescout.PDFViewer.PreProcessKeyEventHandler(this.PdfViewerControl1_PreProcessKey);
            this.pdfViewerControl1.CurrentPageIndexChanged += new System.EventHandler(this.PdfViewerControl1_CurrentPageIndexChanged);
            this.pdfViewerControl1.SelectionChanged += new Bytescout.PDFViewer.SelectionChangedEventHandler(this.PdfViewerControl1_SelectionChanged);
            this.pdfViewerControl1.ValidateContextMenu += new Bytescout.PDFViewer.ValidateContextMenuEventHandler(this.PdfViewerControl1_ValidateContextMenu);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1153, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(64, 22);
            this.tsbOpen.Text = "&Open PDF";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(140, 207);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(129, 23);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Perform Removal";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // tbSearchExpression
            // 
            this.tbSearchExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchExpression.Location = new System.Drawing.Point(68, 19);
            this.tbSearchExpression.Name = "tbSearchExpression";
            this.tbSearchExpression.Size = new System.Drawing.Size(183, 20);
            this.tbSearchExpression.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(176, 69);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find All";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRegex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSearchExpression);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Location = new System.Drawing.Point(9, 45);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(144, 17);
            this.cbRegex.TabIndex = 1;
            this.cbRegex.Text = "Use Regular Expressions";
            this.cbRegex.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find what:";
            // 
            // cbMaskRemovedText
            // 
            this.cbMaskRemovedText.AutoSize = true;
            this.cbMaskRemovedText.Location = new System.Drawing.Point(12, 151);
            this.cbMaskRemovedText.Name = "cbMaskRemovedText";
            this.cbMaskRemovedText.Size = new System.Drawing.Size(238, 17);
            this.cbMaskRemovedText.TabIndex = 2;
            this.cbMaskRemovedText.Text = "Draw black rectangles over the removed text";
            this.toolTip1.SetToolTip(this.cbMaskRemovedText, "Mask removed text fragments with black rectangles to make the output document loo" +
        "k like \"censored\".");
            this.cbMaskRemovedText.UseVisualStyleBackColor = true;
            // 
            // cbMakeUnsearchable
            // 
            this.cbMakeUnsearchable.AutoSize = true;
            this.cbMakeUnsearchable.Location = new System.Drawing.Point(12, 174);
            this.cbMakeUnsearchable.Name = "cbMakeUnsearchable";
            this.cbMakeUnsearchable.Size = new System.Drawing.Size(221, 17);
            this.cbMakeUnsearchable.TabIndex = 3;
            this.cbMakeUnsearchable.Text = "Make the output document unsearchable";
            this.toolTip1.SetToolTip(this.cbMakeUnsearchable, "Make the output document unsearchable. If checked, all PDF pages will be replaced" +
        " with rendered images.");
            this.cbMakeUnsearchable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 702);
            this.Controls.Add(this.cbMakeUnsearchable);
            this.Controls.Add(this.cbMaskRemovedText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDF Data Remover Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox tbSearchExpression;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMaskRemovedText;
        private System.Windows.Forms.CheckBox cbMakeUnsearchable;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

