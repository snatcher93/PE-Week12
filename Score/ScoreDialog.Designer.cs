namespace StudentScore
{
    partial class ScoreDialog
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScoreInputCtrl = new System.Windows.Forms.NumericUpDown();
            this.SubjectInputCtrl = new System.Windows.Forms.TextBox();
            this.SubjectLabelCtrl = new System.Windows.Forms.Label();
            this.NameInputCtrl = new System.Windows.Forms.TextBox();
            this.NameLabelCtrl = new System.Windows.Forms.Label();
            this.ScoreLabelCtrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreInputCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(157, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreInputCtrl
            // 
            this.ScoreInputCtrl.Location = new System.Drawing.Point(80, 109);
            this.ScoreInputCtrl.Name = "ScoreInputCtrl";
            this.ScoreInputCtrl.Size = new System.Drawing.Size(185, 21);
            this.ScoreInputCtrl.TabIndex = 13;
            // 
            // SubjectInputCtrl
            // 
            this.SubjectInputCtrl.Location = new System.Drawing.Point(80, 63);
            this.SubjectInputCtrl.Name = "SubjectInputCtrl";
            this.SubjectInputCtrl.Size = new System.Drawing.Size(185, 21);
            this.SubjectInputCtrl.TabIndex = 11;
            // 
            // SubjectLabelCtrl
            // 
            this.SubjectLabelCtrl.AutoSize = true;
            this.SubjectLabelCtrl.Location = new System.Drawing.Point(22, 66);
            this.SubjectLabelCtrl.Name = "SubjectLabelCtrl";
            this.SubjectLabelCtrl.Size = new System.Drawing.Size(29, 12);
            this.SubjectLabelCtrl.TabIndex = 10;
            this.SubjectLabelCtrl.Text = "과목";
            // 
            // NameInputCtrl
            // 
            this.NameInputCtrl.Location = new System.Drawing.Point(80, 21);
            this.NameInputCtrl.Name = "NameInputCtrl";
            this.NameInputCtrl.Size = new System.Drawing.Size(185, 21);
            this.NameInputCtrl.TabIndex = 9;
            // 
            // NameLabelCtrl
            // 
            this.NameLabelCtrl.AutoSize = true;
            this.NameLabelCtrl.Location = new System.Drawing.Point(22, 24);
            this.NameLabelCtrl.Name = "NameLabelCtrl";
            this.NameLabelCtrl.Size = new System.Drawing.Size(29, 12);
            this.NameLabelCtrl.TabIndex = 8;
            this.NameLabelCtrl.Text = "이름";
            // 
            // ScoreLabelCtrl
            // 
            this.ScoreLabelCtrl.AutoSize = true;
            this.ScoreLabelCtrl.Location = new System.Drawing.Point(24, 114);
            this.ScoreLabelCtrl.Name = "ScoreLabelCtrl";
            this.ScoreLabelCtrl.Size = new System.Drawing.Size(29, 12);
            this.ScoreLabelCtrl.TabIndex = 16;
            this.ScoreLabelCtrl.Text = "성적";
            // 
            // ScoreDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.ScoreLabelCtrl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScoreInputCtrl);
            this.Controls.Add(this.SubjectInputCtrl);
            this.Controls.Add(this.SubjectLabelCtrl);
            this.Controls.Add(this.NameInputCtrl);
            this.Controls.Add(this.NameLabelCtrl);
            this.Name = "ScoreDialog";
            this.Text = "ScoreDialog";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreInputCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ScoreInputCtrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectInputCtrl;
        private System.Windows.Forms.Label SubjectLabelCtrl;
        private System.Windows.Forms.TextBox NameInputCtrl;
        private System.Windows.Forms.Label NameLabelCtrl;
        private System.Windows.Forms.Label ScoreLabelCtrl;
    }
}