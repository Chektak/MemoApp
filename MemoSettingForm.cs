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
    public partial class MemoSettingForm : Form
    {
        public MemoSettingForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1.memoSettingForm.Visible = false;
        }

        private void BasicForm_Click(object sender, EventArgs e)
        {
            Form1.memoFormSettingState = Form1.MemoFormSettingState.BASIC;
        }

        private void DetailForm_Click(object sender, EventArgs e)
        {
            Form1.memoFormSettingState = Form1.MemoFormSettingState.DETAIL;
        }

        private void Basic_PlanForm_Click(object sender, EventArgs e)
        {
            Form1.memoFormSettingState = Form1.MemoFormSettingState.BASIC_PLAN;
        }

        private void Detail_PlanForm_Click(object sender, EventArgs e)
        {
            Form1.memoFormSettingState = Form1.MemoFormSettingState.DETAILS_PLAN;
        }
    }
}
