using System;
using System.Windows.Forms;

namespace 数学算法
{
    public partial class Form_GDBH : Form
    {
        String result;
        ulong total;
        public Form_GDBH()
        {
            InitializeComponent();
        }


        #region 返回按钮单击事件

        private void Button_GDBH_Return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region 计算按钮单击事件

        private void Button_GDBH_Act_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_GDBH.Text.Equals(""))
                {
                    throw new FormatException("没有输入!");
                }
                else
                {
                    ErrorProvider_GDBH.Clear();
                    string source = TextBox_GDBH.Text;
                    ulong number = (ulong)Convert.ToInt64(source);
                    bool LastResult = isGDBH(number);
                    if (LastResult)
                    {
                        result = "共有" + total + "种分解法:\n" + result;
                        Label_GDBH_Result.Text = number + "可以被分解\n";
                    }
                    else
                    {
                        Label_GDBH_Result.Text = number + "不能被分解\n";
                    }
                    if (total>35)
                    {
                        DialogResult dr = MessageBox.Show("项目太多,是否要完整显示?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            MessageBox.Show(result, "分解结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("共有" + total + "种分解法\n", "分解结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(result, "分解结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ee)
            {
                Label_GDBH_Result.Text = "";
                ErrorProvider_GDBH.SetError(TextBox_GDBH, ee.Message);
                DialogResult dr = MessageBox.Show("是否要显示详细调试信息?", "发生错误!", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (dr == DialogResult.Yes) MessageBox.Show(ee.ToString(), "错误!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            TextBox_GDBH.SelectAll();
        }
        #endregion

        #region 判断是否为素数的方法

        private bool isPrimeNumber(ulong Num)
        {
            bool isPrimeNumber = true;
            if (Num == 1)
            {
                isPrimeNumber = false;
            }
            else if (Num == 2)
            {
                isPrimeNumber = true;
            }
            else
            {
                ulong sqrt = Convert.ToUInt64(Math.Sqrt(Num));
                for (ulong i = sqrt; i >= 2; i--)
                {
                    if (Num % i == 0)
                    {
                        isPrimeNumber = false;
                    }
                }
            }
            return isPrimeNumber;
        }

        #endregion

        #region 判断是否符合哥德巴赫猜想的方法

        private bool isGDBH(ulong Num)
        {
            total = 0;
            result = "";
            bool isGDBH = false;
            if (Num % 2 == 0 && Num > 6)
            {
                for (ulong i = 1; i <= Num / 2; i++)
                {
                    bool bl1 = isPrimeNumber(i);
                    bool bl2 = isPrimeNumber(Num - i);
                    if (bl1 && bl2)
                    {
                        total++;
                        result += (Num + "=" + i + "+" + (Num - i)+"\n");
                        isGDBH = true;
                    }
                }
            }
            else
            {
                throw new FormatException("请输入符合要求的数字!");
            }
            return isGDBH;
        }

        #endregion

        #region 回车和Esc键按下的处理
        private void GDBH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_GDBH_Act_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Button_GDBH_Return_Click(sender, e);
            }
        }
        #endregion






    }
}
