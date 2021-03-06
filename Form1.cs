﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace MemoApp
{
    public partial class Form1 : Form
    {
        string stryear = DateTime.Now.Year.ToString();
        string filePath = null;
        string fileName;
        bool txtNoteChange = false;
        Dictionary<int, int[]> baseValueDate = new Dictionary<int, int[]>();
        int[] inMonthDate = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int[] outerMonthDate = new int[12];
        public static int InputOuterMonth;
        //key : Year, Value : 7*n-Month.Day

        enum FileNameSettingState
        {
            BASIC, DETAIL, BASIC_PLAN, DETAILS_PLAN
        }
        public enum MemoFormSettingState
        {
            BASIC, DETAIL, BASIC_PLAN, DETAILS_PLAN
        }
        FileNameSettingState fileNameSettingState = FileNameSettingState.BASIC;
        public static MemoFormSettingState memoFormSettingState = MemoFormSettingState.BASIC;

        public static MemoSettingForm memoSettingForm = new MemoSettingForm();
        public static UseAppTipForm useAppTipForm = new UseAppTipForm();
        public static InputBoxOuterMonthDate inputBoxForm = new InputBoxOuterMonthDate();
 //--------------------------------------------------------------------------------------------------------------
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GetFileName();
                FileSave();
            }
            catch
            {
                MessageBox.Show("저장에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("저장에 성공하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {//날짜가 변경되면 일어나는 함수
            txtMemo.Clear();
            GetFileName();
            SystemLabel.Text = "파일 이름 : "+fileName;
            FileRead();
            txtNoteChange = false;
        }
        private void DateTimePicker_DropDown(object sender, EventArgs e)
        {
            if (txtNoteChange==true&&
                MessageBox.Show("파일에 변경내용이 있습니다. \r\n정말 저장하지 않고 다른파일을 여시겠습니까?",
                    "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                return;
        }

        private void TxtMemo_KeyDown(object sender, KeyEventArgs e)
        {
            txtNoteChange = true;
        }

        private void TxtMemo_MouseClick(object sender, MouseEventArgs e)
        {//폴더에 해당 txt파일이 없다면 새로만들고 밑의 문자를 입력
            if (txtMemo.TextLength==0) { 
                for (int i = 0; i < DayOfWeekToInt(); i++)
                {
                    string Date = DateTimePicker.Value.Month.ToString() + "." + (DateTimePicker.Value.Day
                        - DayOfWeekToInt()+i) + " ";
                    if ((DateTimePicker.Value.Day - DayOfWeekToInt() + i) <= 0)//12월1일 등이어서 -가 되는 특수한 경우
                    {
                        int formerMonthDays;
                        if (DateTimePicker.Value.Month - 2 <= 0)
                            formerMonthDays = 31;
                        else
                            formerMonthDays = inMonthDate[DateTimePicker.Value.AddMonths(-2).Month];
                        Date = DateTimePicker.Value.AddDays(-DayOfWeekToInt() + i).Month + "."
                        +DateTimePicker.Value.AddDays(-DayOfWeekToInt() + i ).Day + " ";
                    }
                    Date += IntToDayOfWeek(i);//월화수목금토일같은 문자로 변환한다.
                    Date += "\r\n\r\n";//줄바꿈 두개
                    txtMemo.Text += Date;

                }
                for (int i = 0; i < 7 - (DayOfWeekToInt()); i++)
                {
                    string Date = DateTimePicker.Value.Month.ToString() + "." + (DateTimePicker.Value.Day
                        + i) + " ";
                    if ((DateTimePicker.Value.Day + i) > inMonthDate[DateTimePicker.Value.Month-1])//11월30일 등이어서 해당달의 총일을 넘는 특수한 경우
                    {
                        Date = DateTimePicker.Value.AddMonths(1).Month.ToString() + "." +
                        (DateTimePicker.Value.Day + i - inMonthDate[(DateTimePicker.Value.AddMonths(-1).Month==12)? 0 : DateTimePicker.Value.AddMonths(-1).Month]) + " ";
                    }
                    Date += IntToDayOfWeek(i + (DayOfWeekToInt()));
                    Date += "\r\n\r\n";//줄바꿈 두개
                    txtMemo.Text += Date;
                }
            }
            
        }

        /// <summary>
        /// Day를 넣으면 0~6숫자로 변환한다.
        /// </summary>
        /// <returns></returns>
        private int DayOfWeekToInt()
        {
            int a=0;
            if (DateTimePicker.Value.DayOfWeek.ToString() == "Monday")
                a = 0;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Tuesday")
                a = 1;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Wednesday")
                a = 2;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Thursday")
                a = 3;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Friday")
                a = 4;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Saturday")
                a = 5;
            else if (DateTimePicker.Value.DayOfWeek.ToString() == "Sunday")
                a = 6;
            return a;
        }

        /// <summary>
        /// 0~6 숫자를 넣으면 Week로 변환한다.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private string IntToDayOfWeek(int a)
        {
            string DayName="";
            if (a == 0)
                DayName = "월";
            else if (a == 1)
                DayName = "화";
            else if (a == 2)
                DayName = "수";
            else if (a == 3)
                DayName = "목";
            else if (a == 4)
                DayName = "금";
            else if (a == 5)
                DayName = "토";
            else if (a == 6)
                DayName = "일";
            return DayName;
        }

        /// <summary>
        /// 짝수홀수달의 일수와, 윤년까지 계산해 변환한다.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int MonthTheAllDayCount(int a)
        {
            int va = 30;
            if (a % 2 == 0)//짝수 홀수 달을 계산
                va = 31;
            if (a == 2)
                va = 28;
            if (a == 2 && DateTimePicker.Value.Year % 4 == 0)//1일을 추가하는 윤년을 계산
                va = 29;
            return va;
        }

        private void FileRead()
        {
            try
            {
                string[] textValue = System.IO.File.ReadAllLines(filePath + @"\" + fileName + ".txt", Encoding.Default);
                foreach (string str in textValue)
                {
                    txtMemo.Text += str+"\r\n";
                }
            }
            catch
            {
                return;
            }
        }

        private void SaveFolderPath_MouseClick(object sender, MouseEventArgs e)
        {//경로 설정
            if (Fddfile.ShowDialog() == DialogResult.OK)
            {
                filePath = Fddfile.SelectedPath;
                SaveFolderPath.Text = filePath;
                BtnSave.Enabled = true;
                if (baseValueDate.ContainsKey(DateTimePicker.Value.Year) == true) {
                    GetFileName();
                    FileRead();
                }

            }
        }

        private void FileSave()
        {
            StreamWriter sw = new StreamWriter(filePath + @"\" + fileName+".txt", false, System.Text.Encoding.Default);
            sw.Write(txtMemo.Text);
            sw.Flush();
            sw.Close();
            FileInfo f = new FileInfo(fileName);
            this.Text = f.Name;
            txtNoteChange = false;
            SystemLabel.Text = filePath + @"\" + fileName+".txt" + "으로 저장되었습니다.";
        }

        private void MemoSettingFormBtn_Click(object sender, EventArgs e)
        {
            memoSettingForm.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            useAppTipForm.Visible = true;
        }

        private void RadioButtons_Changed(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
                fileNameSettingState = FileNameSettingState.BASIC;
            else if (RadioButton2.Checked == true)
                fileNameSettingState = FileNameSettingState.DETAIL;
        }

        public void GetFileName()
        {
            fileName = DateTimePicker.Value.Year + "년 " + DateTimePicker.Value.Month + "월 ";
            switch (fileNameSettingState)
            {
                case FileNameSettingState.BASIC:
                    try
                    {
                        outerMonthDate = baseValueDate[DateTimePicker.Value.Year];
                        string nextvaluestr;
                        int value;
                        for (value = 0; value * 7 + 1 < 7 - ((DateTimePicker.Value.Month == 1) ? InputOuterMonth : outerMonthDate[DateTimePicker.Value.Month - 2])
                            + DateTimePicker.Value.Day; value++) { }
                        int nextvalueint = value + 1;
                        int month = DateTimePicker.Value.Month;

                        if (nextvalueint * 7 > 7 - outerMonthDate[DateTimePicker.Value.Month - 1] +
                            inMonthDate[DateTimePicker.Value.Month - 1] || nextvalueint >= 7)
                        {
                            nextvalueint = 1;
                            month += 1;
                            if (month > 12)
                                month = 1;
                        }
                        nextvaluestr = month + "월 " + nextvalueint + "째주";

                        fileName += value + "째주~ " + nextvaluestr;
                    }
                    catch
                    {
                        if (MessageBox.Show("InputOuterMonth에 대한 값을\r\n찾을 수 없습니다. 다시 시도합니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                            == DialogResult.No)
                            return;
                        UpdateDictionary();
                        GetFileName();
                    }
                    break;
                case FileNameSettingState.DETAIL:
                    fileName = "DETAIL";
                    break;
                    
                default:
                    break;
            }
        }

        void UpdateDictionary()
        {
            inputBoxForm.ShowDialog();//이전년도의 outerMonth를 InputOuterMonth 변수로 받는다.
            try
            {

                int value;
                int[] outerMonthBox = new int[12];
                for (int i = 0; i < 12; i++)
                {
                    if (i == 0)
                    {
                        for (value = 7; 7 - InputOuterMonth + inMonthDate[i] > value; value += 7)//이전년도의 outerMonthDate[12]
                        { }
                        outerMonthBox[i] = value - (7 - InputOuterMonth + inMonthDate[i]);
                        continue;
                    }
                    for (value = 7; 7 - outerMonthBox[i - 1] + inMonthDate[i] > value; value += 7)//이전년도의 outerMonthDate[12]
                    { }
                    outerMonthBox[i] = value - (7 - outerMonthBox[i - 1] + inMonthDate[i]);
                }
                baseValueDate[DateTimePicker.Value.Year] = outerMonthBox;
            }
            catch
            {
                MessageBox.Show("Dictionary업데이트에 실패하였습니다.", "알림", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            InputTextBox.Text = "InputOuterMonth : " + InputOuterMonth;
        }
        void UpdateinMonthDate()
        {
            if (DateTimePicker.Value.Year % 4 == 0)
                inMonthDate[2] = 29;
            else
                inMonthDate[2] = 28;
        }

        private void InputTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateDictionary();
        }
    }
}
