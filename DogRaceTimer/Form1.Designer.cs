namespace DogRaceTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackCtrl = new System.Windows.Forms.PictureBox();
            this.dog1Ctrl = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dog2Ctrl = new System.Windows.Forms.PictureBox();
            this.dog3Ctrl = new System.Windows.Forms.PictureBox();
            this.dog4Ctrl = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Ctrl)).BeginInit();
            this.SuspendLayout();
            // 
            // trackCtrl
            // 
            this.trackCtrl.Image = ((System.Drawing.Image)(resources.GetObject("trackCtrl.Image")));
            this.trackCtrl.Location = new System.Drawing.Point(1, 1);
            this.trackCtrl.Name = "trackCtrl";
            this.trackCtrl.Size = new System.Drawing.Size(603, 200);
            this.trackCtrl.TabIndex = 0;
            this.trackCtrl.TabStop = false;
            // 
            // dog1Ctrl
            // 
            this.dog1Ctrl.Image = ((System.Drawing.Image)(resources.GetObject("dog1Ctrl.Image")));
            this.dog1Ctrl.Location = new System.Drawing.Point(12, 12);
            this.dog1Ctrl.Name = "dog1Ctrl";
            this.dog1Ctrl.Size = new System.Drawing.Size(75, 20);
            this.dog1Ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1Ctrl.TabIndex = 1;
            this.dog1Ctrl.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "경주시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dog2Ctrl
            // 
            this.dog2Ctrl.Image = ((System.Drawing.Image)(resources.GetObject("dog2Ctrl.Image")));
            this.dog2Ctrl.Location = new System.Drawing.Point(12, 56);
            this.dog2Ctrl.Name = "dog2Ctrl";
            this.dog2Ctrl.Size = new System.Drawing.Size(75, 20);
            this.dog2Ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2Ctrl.TabIndex = 3;
            this.dog2Ctrl.TabStop = false;
            // 
            // dog3Ctrl
            // 
            this.dog3Ctrl.Image = ((System.Drawing.Image)(resources.GetObject("dog3Ctrl.Image")));
            this.dog3Ctrl.Location = new System.Drawing.Point(13, 111);
            this.dog3Ctrl.Name = "dog3Ctrl";
            this.dog3Ctrl.Size = new System.Drawing.Size(75, 20);
            this.dog3Ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3Ctrl.TabIndex = 4;
            this.dog3Ctrl.TabStop = false;
            // 
            // dog4Ctrl
            // 
            this.dog4Ctrl.Image = ((System.Drawing.Image)(resources.GetObject("dog4Ctrl.Image")));
            this.dog4Ctrl.Location = new System.Drawing.Point(13, 167);
            this.dog4Ctrl.Name = "dog4Ctrl";
            this.dog4Ctrl.Size = new System.Drawing.Size(75, 20);
            this.dog4Ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4Ctrl.TabIndex = 5;
            this.dog4Ctrl.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 247);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dog4Ctrl);
            this.Controls.Add(this.dog3Ctrl);
            this.Controls.Add(this.dog2Ctrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dog1Ctrl);
            this.Controls.Add(this.trackCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4Ctrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trackCtrl;
        private System.Windows.Forms.PictureBox dog1Ctrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox dog2Ctrl;
        private System.Windows.Forms.PictureBox dog3Ctrl;
        private System.Windows.Forms.PictureBox dog4Ctrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

