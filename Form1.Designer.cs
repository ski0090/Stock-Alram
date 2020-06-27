namespace Stock_Alram
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mAddSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mListSubject = new System.Windows.Forms.ListBox();
            this.mHightCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mLowCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mCurrentCost = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.m_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mAddSubject
            // 
            this.mAddSubject.Location = new System.Drawing.Point(75, 12);
            this.mAddSubject.Name = "mAddSubject";
            this.mAddSubject.Size = new System.Drawing.Size(100, 21);
            this.mAddSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "추가 종목";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // mListSubject
            // 
            this.mListSubject.FormattingEnabled = true;
            this.mListSubject.ItemHeight = 12;
            this.mListSubject.Location = new System.Drawing.Point(14, 39);
            this.mListSubject.Name = "mListSubject";
            this.mListSubject.Size = new System.Drawing.Size(242, 364);
            this.mListSubject.TabIndex = 3;
            // 
            // mHightCost
            // 
            this.mHightCost.Location = new System.Drawing.Point(337, 39);
            this.mHightCost.Name = "mHightCost";
            this.mHightCost.Size = new System.Drawing.Size(123, 21);
            this.mHightCost.TabIndex = 4;
            this.mHightCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "알람가(상)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "알람가(하)";
            // 
            // mLowCost
            // 
            this.mLowCost.Location = new System.Drawing.Point(337, 66);
            this.mLowCost.Name = "mLowCost";
            this.mLowCost.Size = new System.Drawing.Size(123, 21);
            this.mLowCost.TabIndex = 6;
            this.mLowCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "현재가";
            // 
            // mCurrentCost
            // 
            this.mCurrentCost.AutoSize = true;
            this.mCurrentCost.Location = new System.Drawing.Point(422, 129);
            this.mCurrentCost.Name = "mCurrentCost";
            this.mCurrentCost.Size = new System.Drawing.Size(38, 12);
            this.mCurrentCost.TabIndex = 9;
            this.mCurrentCost.Text = "label5";
            this.mCurrentCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.CrawllingStock);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // m_notify
            // 
            this.m_notify.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notify.Icon")));
            this.m_notify.Text = "notifyIcon1";
            this.m_notify.Visible = true;
            this.m_notify.DoubleClick += new System.EventHandler(this.AgainShowForm);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "적용";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mCurrentCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mLowCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mHightCost);
            this.Controls.Add(this.mListSubject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mAddSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "주식 알람";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Release);
            this.Load += new System.EventHandler(this.Initialize);
            this.Resize += new System.EventHandler(this.ResizeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox mListSubject;
        private System.Windows.Forms.TextBox mHightCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mLowCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mCurrentCost;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon m_notify;
        private System.Windows.Forms.Button button3;
    }
}

