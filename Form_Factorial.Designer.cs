namespace 数学算法
{
    partial class Form_Factorial
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
            this.Label_Factorial_Notice = new System.Windows.Forms.Label();
            this.TextBox_Factorial = new System.Windows.Forms.TextBox();
            this.Button_Factorial_Act = new System.Windows.Forms.Button();
            this.Label_Factotial_Result = new System.Windows.Forms.Label();
            this.Button_Factorial_Return = new System.Windows.Forms.Button();
            this.ErrorProvider_Factorial = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Factorial)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Factorial_Notice
            // 
            this.Label_Factorial_Notice.AutoSize = true;
            this.Label_Factorial_Notice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Factorial_Notice.Location = new System.Drawing.Point(12, 61);
            this.Label_Factorial_Notice.Name = "Label_Factorial_Notice";
            this.Label_Factorial_Notice.Size = new System.Drawing.Size(124, 21);
            this.Label_Factorial_Notice.TabIndex = 0;
            this.Label_Factorial_Notice.Text = "输入0-65的整数";
            // 
            // TextBox_Factorial
            // 
            this.TextBox_Factorial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Factorial.Location = new System.Drawing.Point(149, 58);
            this.TextBox_Factorial.MaxLength = 8;
            this.TextBox_Factorial.Name = "TextBox_Factorial";
            this.TextBox_Factorial.Size = new System.Drawing.Size(84, 29);
            this.TextBox_Factorial.TabIndex = 1;
            // 
            // Button_Factorial_Act
            // 
            this.Button_Factorial_Act.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_Factorial_Act.Location = new System.Drawing.Point(90, 110);
            this.Button_Factorial_Act.Name = "Button_Factorial_Act";
            this.Button_Factorial_Act.Size = new System.Drawing.Size(100, 35);
            this.Button_Factorial_Act.TabIndex = 2;
            this.Button_Factorial_Act.Text = "进行阶乘";
            this.Button_Factorial_Act.UseVisualStyleBackColor = true;
            this.Button_Factorial_Act.Click += new System.EventHandler(this.Button_Factorial_Act_Click);
            // 
            // Label_Factotial_Result
            // 
            this.Label_Factotial_Result.AutoSize = true;
            this.Label_Factotial_Result.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label_Factotial_Result.Location = new System.Drawing.Point(1, 170);
            this.Label_Factotial_Result.Name = "Label_Factotial_Result";
            this.Label_Factotial_Result.Size = new System.Drawing.Size(0, 20);
            this.Label_Factotial_Result.TabIndex = 3;
            // 
            // Button_Factorial_Return
            // 
            this.Button_Factorial_Return.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Button_Factorial_Return.Location = new System.Drawing.Point(90, 204);
            this.Button_Factorial_Return.Name = "Button_Factorial_Return";
            this.Button_Factorial_Return.Size = new System.Drawing.Size(100, 35);
            this.Button_Factorial_Return.TabIndex = 2;
            this.Button_Factorial_Return.Text = "返回";
            this.Button_Factorial_Return.UseVisualStyleBackColor = true;
            this.Button_Factorial_Return.Click += new System.EventHandler(this.Button_Factorial_Return_Click);
            // 
            // ErrorProvider_Factorial
            // 
            this.ErrorProvider_Factorial.ContainerControl = this;
            // 
            // Form_Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.Label_Factotial_Result);
            this.Controls.Add(this.Button_Factorial_Return);
            this.Controls.Add(this.Button_Factorial_Act);
            this.Controls.Add(this.TextBox_Factorial);
            this.Controls.Add(this.Label_Factorial_Notice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Factorial";
            this.Text = "阶乘";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Factorial_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Factorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Factorial_Notice;
        private System.Windows.Forms.TextBox TextBox_Factorial;
        private System.Windows.Forms.Button Button_Factorial_Act;
        private System.Windows.Forms.Label Label_Factotial_Result;
        private System.Windows.Forms.Button Button_Factorial_Return;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Factorial;
    }
}