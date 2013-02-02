namespace 数学算法
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button_Factorial = new System.Windows.Forms.Button();
            this.Button_GDBH = new System.Windows.Forms.Button();
            this.Button_FBNQ = new System.Windows.Forms.Button();
            this.ProgressBar_Load = new System.Windows.Forms.ProgressBar();
            this.Button_Load = new System.Windows.Forms.Button();
            this.Label_Copyright = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Button_Factorial
            // 
            this.Button_Factorial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Factorial.Location = new System.Drawing.Point(90, 50);
            this.Button_Factorial.Name = "Button_Factorial";
            this.Button_Factorial.Size = new System.Drawing.Size(120, 36);
            this.Button_Factorial.TabIndex = 0;
            this.Button_Factorial.Text = "阶乘";
            this.Button_Factorial.UseVisualStyleBackColor = true;
            this.Button_Factorial.Visible = false;
            this.Button_Factorial.Click += new System.EventHandler(this.Button_Factorial_Click);
            // 
            // Button_GDBH
            // 
            this.Button_GDBH.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_GDBH.Location = new System.Drawing.Point(90, 115);
            this.Button_GDBH.Name = "Button_GDBH";
            this.Button_GDBH.Size = new System.Drawing.Size(120, 36);
            this.Button_GDBH.TabIndex = 0;
            this.Button_GDBH.Text = "哥德巴赫猜想";
            this.Button_GDBH.UseVisualStyleBackColor = true;
            this.Button_GDBH.Visible = false;
            this.Button_GDBH.Click += new System.EventHandler(this.Button_GDBH_Click);
            // 
            // Button_FBNQ
            // 
            this.Button_FBNQ.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_FBNQ.Location = new System.Drawing.Point(90, 180);
            this.Button_FBNQ.Name = "Button_FBNQ";
            this.Button_FBNQ.Size = new System.Drawing.Size(120, 36);
            this.Button_FBNQ.TabIndex = 0;
            this.Button_FBNQ.Text = "斐波那契数列";
            this.Button_FBNQ.UseVisualStyleBackColor = true;
            this.Button_FBNQ.Visible = false;
            this.Button_FBNQ.Click += new System.EventHandler(this.Button_FBNQ_Click);
            // 
            // ProgressBar_Load
            // 
            this.ProgressBar_Load.Location = new System.Drawing.Point(50, 60);
            this.ProgressBar_Load.Name = "ProgressBar_Load";
            this.ProgressBar_Load.Size = new System.Drawing.Size(200, 30);
            this.ProgressBar_Load.Step = 1;
            this.ProgressBar_Load.TabIndex = 1;
            // 
            // Button_Load
            // 
            this.Button_Load.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Load.Location = new System.Drawing.Point(90, 115);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(120, 36);
            this.Button_Load.TabIndex = 2;
            this.Button_Load.Text = "点击载入程序";
            this.Button_Load.UseVisualStyleBackColor = true;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // Label_Copyright
            // 
            this.Label_Copyright.AutoSize = true;
            this.Label_Copyright.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Copyright.Location = new System.Drawing.Point(105, 168);
            this.Label_Copyright.Name = "Label_Copyright";
            this.Label_Copyright.Size = new System.Drawing.Size(0, 20);
            this.Label_Copyright.TabIndex = 3;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Enabled = true;
            this.Timer_Main.Tick += new System.EventHandler(this.Timer_Main_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.Label_Copyright);
            this.Controls.Add(this.Button_Load);
            this.Controls.Add(this.ProgressBar_Load);
            this.Controls.Add(this.Button_FBNQ);
            this.Controls.Add(this.Button_GDBH);
            this.Controls.Add(this.Button_Factorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "数学算法";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Button_Factorial;
        private System.Windows.Forms.Button Button_GDBH;
        private System.Windows.Forms.Button Button_FBNQ;
        private System.Windows.Forms.ProgressBar ProgressBar_Load;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.Label Label_Copyright;
        private System.Windows.Forms.Timer Timer_Main;
    }
}

