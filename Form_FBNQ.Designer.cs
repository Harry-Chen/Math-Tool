namespace 数学算法
{
    partial class Form_FBNQ
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
            this.Label_FBNQ_Notice = new System.Windows.Forms.Label();
            this.TextBox_FBNQ = new System.Windows.Forms.TextBox();
            this.ErrorProvider_FBNQ = new System.Windows.Forms.ErrorProvider(this.components);
            this.Button_FBNQ_Act = new System.Windows.Forms.Button();
            this.Button_FBNQ_Return = new System.Windows.Forms.Button();
            this.Label_FBNQ_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_FBNQ)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FBNQ_Notice
            // 
            this.Label_FBNQ_Notice.AutoSize = true;
            this.Label_FBNQ_Notice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Label_FBNQ_Notice.Location = new System.Drawing.Point(12, 61);
            this.Label_FBNQ_Notice.Name = "Label_FBNQ_Notice";
            this.Label_FBNQ_Notice.Size = new System.Drawing.Size(140, 21);
            this.Label_FBNQ_Notice.TabIndex = 0;
            this.Label_FBNQ_Notice.Text = "输入40以内的项数";
            // 
            // TextBox_FBNQ
            // 
            this.TextBox_FBNQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TextBox_FBNQ.Location = new System.Drawing.Point(149, 58);
            this.TextBox_FBNQ.MaxLength = 2;
            this.TextBox_FBNQ.Name = "TextBox_FBNQ";
            this.TextBox_FBNQ.Size = new System.Drawing.Size(84, 29);
            this.TextBox_FBNQ.TabIndex = 1;
            // 
            // ErrorProvider_FBNQ
            // 
            this.ErrorProvider_FBNQ.ContainerControl = this;
            // 
            // Button_FBNQ_Act
            // 
            this.Button_FBNQ_Act.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_FBNQ_Act.Location = new System.Drawing.Point(90, 110);
            this.Button_FBNQ_Act.Name = "Button_FBNQ_Act";
            this.Button_FBNQ_Act.Size = new System.Drawing.Size(100, 35);
            this.Button_FBNQ_Act.TabIndex = 2;
            this.Button_FBNQ_Act.Text = "计算数列";
            this.Button_FBNQ_Act.UseVisualStyleBackColor = true;
            this.Button_FBNQ_Act.Click += new System.EventHandler(this.Button_FBNQ_Act_Click);
            // 
            // Button_FBNQ_Return
            // 
            this.Button_FBNQ_Return.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_FBNQ_Return.Location = new System.Drawing.Point(90, 204);
            this.Button_FBNQ_Return.Name = "Button_FBNQ_Return";
            this.Button_FBNQ_Return.Size = new System.Drawing.Size(100, 35);
            this.Button_FBNQ_Return.TabIndex = 3;
            this.Button_FBNQ_Return.Text = "返回";
            this.Button_FBNQ_Return.UseVisualStyleBackColor = true;
            this.Button_FBNQ_Return.Click += new System.EventHandler(this.Button_FBNQ_Return_Click);
            // 
            // Label_FBNQ_Result
            // 
            this.Label_FBNQ_Result.AutoSize = true;
            this.Label_FBNQ_Result.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label_FBNQ_Result.Location = new System.Drawing.Point(50, 170);
            this.Label_FBNQ_Result.Name = "Label_FBNQ_Result";
            this.Label_FBNQ_Result.Size = new System.Drawing.Size(0, 20);
            this.Label_FBNQ_Result.TabIndex = 4;
            // 
            // Form_FBNQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.Label_FBNQ_Result);
            this.Controls.Add(this.Button_FBNQ_Return);
            this.Controls.Add(this.Button_FBNQ_Act);
            this.Controls.Add(this.TextBox_FBNQ);
            this.Controls.Add(this.Label_FBNQ_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_FBNQ";
            this.Text = "斐波那契数列";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FBNQ_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_FBNQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_FBNQ_Notice;
        private System.Windows.Forms.TextBox TextBox_FBNQ;
        private System.Windows.Forms.ErrorProvider ErrorProvider_FBNQ;
        private System.Windows.Forms.Button Button_FBNQ_Act;
        private System.Windows.Forms.Button Button_FBNQ_Return;
        private System.Windows.Forms.Label Label_FBNQ_Result;
    }
}