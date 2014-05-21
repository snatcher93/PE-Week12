namespace Painter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RectangleTool = new System.Windows.Forms.ToolStripButton();
            this.TriangleTool = new System.Windows.Forms.ToolStripButton();
            this.CircleTool = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RectangleTool,
            this.TriangleTool,
            this.CircleTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RectangleTool
            // 
            this.RectangleTool.Checked = true;
            this.RectangleTool.CheckOnClick = true;
            this.RectangleTool.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.RectangleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleTool.Image = ((System.Drawing.Image)(resources.GetObject("RectangleTool.Image")));
            this.RectangleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleTool.Name = "RectangleTool";
            this.RectangleTool.Size = new System.Drawing.Size(23, 22);
            this.RectangleTool.Text = "toolStripButton1";
            this.RectangleTool.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TriangleTool
            // 
            this.TriangleTool.CheckOnClick = true;
            this.TriangleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TriangleTool.Image = ((System.Drawing.Image)(resources.GetObject("TriangleTool.Image")));
            this.TriangleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TriangleTool.Name = "TriangleTool";
            this.TriangleTool.Size = new System.Drawing.Size(23, 22);
            this.TriangleTool.Text = "toolStripButton2";
            this.TriangleTool.Click += new System.EventHandler(this.TriangleTool_Click);
            // 
            // CircleTool
            // 
            this.CircleTool.CheckOnClick = true;
            this.CircleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleTool.Image = ((System.Drawing.Image)(resources.GetObject("CircleTool.Image")));
            this.CircleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleTool.Name = "CircleTool";
            this.CircleTool.Size = new System.Drawing.Size(23, 22);
            this.CircleTool.Text = "toolStripButton3";
            this.CircleTool.Click += new System.EventHandler(this.CircleTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 525);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RectangleTool;
        private System.Windows.Forms.ToolStripButton TriangleTool;
        private System.Windows.Forms.ToolStripButton CircleTool;

    }
}

