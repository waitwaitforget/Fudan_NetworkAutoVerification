namespace 网络自动认证工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_autover = new System.Windows.Forms.Timer(this.components);
            this.lb_tips = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_passwd = new System.Windows.Forms.TextBox();
            this.网络自动认证工具 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_autover
            // 
            this.timer_autover.Interval = 7200000;
            this.timer_autover.Tick += new System.EventHandler(this.timer_autover_Tick);
            // 
            // lb_tips
            // 
            this.lb_tips.AutoSize = true;
            this.lb_tips.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_tips.Location = new System.Drawing.Point(402, 9);
            this.lb_tips.Name = "lb_tips";
            this.lb_tips.Size = new System.Drawing.Size(85, 24);
            this.lb_tips.TabIndex = 1;
            this.lb_tips.Text = "提示：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始认证";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(86, 54);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(120, 25);
            this.txb_username.TabIndex = 5;
            // 
            // txb_passwd
            // 
            this.txb_passwd.Location = new System.Drawing.Point(288, 54);
            this.txb_passwd.Name = "txb_passwd";
            this.txb_passwd.PasswordChar = '*';
            this.txb_passwd.Size = new System.Drawing.Size(120, 25);
            this.txb_passwd.TabIndex = 6;
            // 
            // 网络自动认证工具
            // 
            this.网络自动认证工具.Icon = ((System.Drawing.Icon)(resources.GetObject("网络自动认证工具.Icon")));
            this.网络自动认证工具.Text = "网络自动认证工具";
            this.网络自动认证工具.Visible = true;
            this.网络自动认证工具.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.网络自动认证工具.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(48, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "点击最小化后台挂起";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 110);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_passwd);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_tips);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "复旦大学网络自动认证工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_autover;
        private System.Windows.Forms.Label lb_tips;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_passwd;
        private System.Windows.Forms.NotifyIcon 网络自动认证工具;
        private System.Windows.Forms.Label label3;
    }
}

