namespace NguyenQuocToan_1706020089_OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDuongThang = new System.Windows.Forms.ToolStripButton();
            this.tsbTamGiac = new System.Windows.Forms.ToolStripButton();
            this.tsbHinhThoi = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btLoad = new System.Windows.Forms.ToolStripButton();
            this.paper = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDuongThang,
            this.tsbTamGiac,
            this.tsbHinhThoi,
            this.btSave,
            this.btLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(467, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDuongThang
            // 
            this.tsbDuongThang.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuongThang.Image")));
            this.tsbDuongThang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuongThang.Name = "tsbDuongThang";
            this.tsbDuongThang.Size = new System.Drawing.Size(100, 22);
            this.tsbDuongThang.Text = "Đường Thẳng";
            this.tsbDuongThang.Click += new System.EventHandler(this.tsbDuongThang_Click);
            // 
            // tsbTamGiac
            // 
            this.tsbTamGiac.Image = ((System.Drawing.Image)(resources.GetObject("tsbTamGiac.Image")));
            this.tsbTamGiac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTamGiac.Name = "tsbTamGiac";
            this.tsbTamGiac.Size = new System.Drawing.Size(77, 22);
            this.tsbTamGiac.Text = "Tam Giác";
            this.tsbTamGiac.Click += new System.EventHandler(this.tsbTamGiac_Click);
            // 
            // tsbHinhThoi
            // 
            this.tsbHinhThoi.Image = ((System.Drawing.Image)(resources.GetObject("tsbHinhThoi.Image")));
            this.tsbHinhThoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHinhThoi.Name = "tsbHinhThoi";
            this.tsbHinhThoi.Size = new System.Drawing.Size(80, 22);
            this.tsbHinhThoi.Text = "Hình Thoi";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(35, 22);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoad.Image = ((System.Drawing.Image)(resources.GetObject("btLoad.Image")));
            this.btLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(37, 22);
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paper.Location = new System.Drawing.Point(0, 25);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(467, 352);
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 377);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDuongThang;
        private System.Windows.Forms.ToolStripButton tsbTamGiac;
        private System.Windows.Forms.ToolStripButton tsbHinhThoi;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btLoad;
        private System.Windows.Forms.PictureBox paper;
    }
}

