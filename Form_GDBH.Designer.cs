namespace 数学算法
{
    partial class Form_GDBH
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
            this.Label_GDBH_Notice = new System.Windows.Forms.Label();
            this.TextBox_GDBH = new System.Windows.Forms.TextBox();
            this.ErrorProvider_GDBH = new System.Windows.Forms.ErrorProvider(this.components);
            this.Button_GDBH_Act = new System.Windows.Forms.Button();
            this.Label_GDBH_Result = new System.Windows.Forms.Label();
            this.Button_GDBH_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_GDBH)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_GDBH_Notice
            // 
            this.Label_GDBH_Notice.AutoSize = true;
            this.Label_GDBH_Notice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Label_GDBH_Notice.Location = new System.Drawing.Point(12, 61);
            this.Label_GDBH_Notice.Name = "Label_GDBH_Notice";
            this.Label_GDBH_Notice.Size = new System.Drawing.Size(131, 21);
            this.Label_GDBH_Notice.TabIndex = 1;
            this.Label_GDBH_Notice.Text = "输入大于6的偶数";
            // 
            // TextBox_GDBH
            // 
            this.TextBox_GDBH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TextBox_GDBH.Location = new System.Drawing.Point(149, 58);
            this.TextBox_GDBH.MaxLength = 6;
            this.TextBox_GDBH.Name = "TextBox_GDBH";
            this.TextBox_GDBH.Size = new System.Drawing.Size(84, 29);
            this.TextBox_GDBH.TabIndex = 2;
            // 
            // ErrorProvider_GDBH
            // 
            this.ErrorProvider_GDBH.ContainerControl = this;
            // 
            // Button_GDBH_Act
            // 
            this.Button_GDBH_Act.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_GDBH_Act.Location = new System.Drawing.Point(90, 110);
            this.Button_GDBH_Act.Name = "Button_GDBH_Act";
            this.Button_GDBH_Act.Size = new System.Drawing.Size(100, 35);
            this.Button_GDBH_Act.TabIndex = 3;
            this.Button_GDBH_Act.Text = "分解该数";
            this.Button_GDBH_Act.UseVisualStyleBackColor = true;
            this.Button_GDBH_Act.Click += new System.EventHandler(this.Button_GDBH_Act_Click);
            // 
            // Label_GDBH_Result
            // 
            this.Label_GDBH_Result.AutoSize = true;
            this.Label_GDBH_Result.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label_GDBH_Result.Location = new System.Drawing.Point(75, 165);
            this.Label_GDBH_Result.Name = "Label_GDBH_Result";
            this.Label_GDBH_Result.Size = new System.Drawing.Size(0, 20);
            this.Label_GDBH_Result.TabIndex = 5;
            // 
            // Button_GDBH_Return
            // 
            this.Button_GDBH_Return.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_GDBH_Return.Location = new System.Drawing.Point(90, 204);
            this.Button_GDBH_Return.Name = "Button_GDBH_Return";
            this.Button_GDBH_Return.Size = new System.Drawing.Size(100, 35);
            this.Button_GDBH_Return.TabIndex = 6;
            this.Button_GDBH_Return.Text = "返回";
            this.Button_GDBH_Return.UseVisualStyleBackColor = true;
            this.Button_GDBH_Return.Click += new System.EventHandler(this.Button_GDBH_Return_Click);
            // 
            // Form_GDBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.Button_GDBH_Return);
            this.Controls.Add(this.Label_GDBH_Result);
            this.Controls.Add(this.Button_GDBH_Act);
            this.Controls.Add(this.TextBox_GDBH);
            this.Controls.Add(this.Label_GDBH_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_GDBH";
            this.Text = "哥德巴赫猜想";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GDBH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_GDBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_GDBH_Notice;
        private System.Windows.Forms.TextBox TextBox_GDBH;
        private System.Windows.Forms.ErrorProvider ErrorProvider_GDBH;
        private System.Windows.Forms.Button Button_GDBH_Act;
        private System.Windows.Forms.Label Label_GDBH_Result;
        private System.Windows.Forms.Button Button_GDBH_Return;
    }
}