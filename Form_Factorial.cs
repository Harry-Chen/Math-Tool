using System;
using System.Windows.Forms;

namespace 数学算法
{
    public partial class Form_Factorial : Form
    {
        public Form_Factorial()
        {
            InitializeComponent(); 
        }

        #region 返回按钮单击事件
        private void Button_Factorial_Return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region 计算按钮单击事件
        private void Button_Factorial_Act_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Factorial.Text.Equals(""))
                {
                    throw new FormatException("没有输入!");
                }
                else
                {
                    ErrorProvider_Factorial.Clear();
                    string source = TextBox_Factorial.Text;
                    ulong number = (ulong)Convert.ToInt64(source);
                    if (number < 0) throw new FormatException("数字太小!");
                    if (number > 65) throw new FormatException(" 数字太大!");
                    ulong result = factorial(number);
                    string label;
                    switch (number)
                    {
                        case 0:
                        case 1:
                            label = number + "!=" + 1;
                            break;
                        case 2:
                            label = "2!=1X2=2";
                            break;
                        case 3:
                            label = "3!=1X2X3=6";
                            break;
                        default:
                            label = number + "!=" + "1X2X……X" + number + "=" + result.ToString();
                            break;
                    }
                    Label_Factotial_Result.Text = label;
                    
                }
            }
            catch (Exception ee)
            {
                Label_Factotial_Result.Text = "";
                ErrorProvider_Factorial.SetError(TextBox_Factorial, ee.Message);
                DialogResult dr = MessageBox.Show("是否要显示详细调试信息?", "发生错误!", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (dr == DialogResult.Yes) MessageBox.Show(ee.ToString(), "错误!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            TextBox_Factorial.SelectAll();
        }
        #endregion

        #region 计算阶乘的方法
        private ulong factorial(ulong number)
        {

            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }

        }
        #endregion

        #region 回车和Esc键按下的处理
        private void Factorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_Factorial_Act_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Button_Factorial_Return_Click(sender, e);
            }
        }
        #endregion
    }
}
