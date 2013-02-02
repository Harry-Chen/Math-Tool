using System;
using System.Windows.Forms;

namespace 数学算法
{
    public partial class Form_FBNQ : Form
    {
        public Form_FBNQ()
        {
            InitializeComponent();
        }

        #region 返回按钮单击事件
        private void Button_FBNQ_Return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region 计算按钮单击事件
        private void Button_FBNQ_Act_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_FBNQ.Text.Equals(""))
                {
                    throw new FormatException("没有输入!");
                }
                else
                {
                    ErrorProvider_FBNQ.Clear();
                    string source = TextBox_FBNQ.Text;
                    int number = Convert.ToInt16(source);
                    ulong result = FBNQ(number);
                    string label = "斐波那契数列的第" + number + "项是" + result;
                    Label_FBNQ_Result.Text = label;
                }
            }
            catch (Exception ee)
            {
                Label_FBNQ_Result.Text = "";
                ErrorProvider_FBNQ.SetError(TextBox_FBNQ, ee.Message);
                DialogResult dr = MessageBox.Show("是否要显示详细调试信息?", "发生错误!", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (dr==DialogResult.Yes) MessageBox.Show(ee.ToString(), "错误!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            TextBox_FBNQ.SelectAll();
        }
        #endregion

        #region 计算斐波那契数列的方法
        private ulong FBNQ(int number)
        {
            {
                if (number > 40) throw new FormatException("数字太大!");
                if (number <= 0) throw new FormatException("数字太小!");
                if (number == 1 || number == 2)
                {
                    return 1;
                }
                else
                {
                    return FBNQ(number - 1) + FBNQ(number - 2);
                }

            }

        }
        #endregion

        #region 回车和Esc键按下的处理
        private void FBNQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_FBNQ_Act_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Button_FBNQ_Return_Click(sender, e);
            }
        }
        #endregion
    }
}

