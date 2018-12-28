using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoApp
{
    public partial class InputBoxOuterMonthDate : Form
    {
        public InputBoxOuterMonthDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.InputOuterMonth = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                if (MessageBox.Show("제대로 숫자를 입력해 주세요. \r\n 다시 시도하시겠습니까?",
                    "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    return;
            }

            Close();
        }
    }
}
