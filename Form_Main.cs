using System;
using System.Windows.Forms;

namespace 数学算法
{
    public partial class Form_Main : Form
    {
        string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day+"\n", copyright = "Harry Chen\n", time;
        public Form_Main()
        {
            InitializeComponent();
        }
        #region 加载按钮单击事件
        private void Button_Load_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                ProgressBar_Load.PerformStep();
            }
            MessageBox.Show("欢迎使用!", "Harry Chen");
            ProgressBar_Load.Visible = false;
            Button_Load.Visible = false;
            Label_Copyright.Visible = false;
            Button_Factorial.Visible = true;
            Button_FBNQ.Visible = true;
            Button_GDBH.Visible = true;
            Timer_Main.Enabled = false;
        }
        #endregion

        #region 三个打开窗体的按钮单击事件
        private void Button_Factorial_Click(object sender, EventArgs e)
        {
            Form frm_Factorial = new Form_Factorial();
            frm_Factorial.Show();
        }

        private void Button_GDBH_Click(object sender, EventArgs e)
        {
            Form frm_GDBH = new Form_GDBH();
            frm_GDBH.Show();
        }

        private void Button_FBNQ_Click(object sender, System.EventArgs e)
        {
            Form frm_FBHQ = new Form_FBNQ();
            frm_FBHQ.Show();
        }
        #endregion

        #region 回车和Esc键按下的处理
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
        #endregion

        #region 动态时钟的更新
        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            Label_Copyright.Text = copyright + date + time;

        }
        #endregion
    }
}
