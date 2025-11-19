using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得國家按鈕的事件處理方法。
        /// 詳細說明：
        /// - 此處應放置讀取或產生南美洲國家清單的邏輯，將結果加入 countriesListBox 控制項中。
        /// - 例如：從檔案讀取或從內部陣列填入 items。
        /// - 為避免阻塞 UI，若為長時間作業應考慮使用非同步模式或背景執行緒。
        /// 目前僅保留事件方法框架，實際實作請依需求新增。
        /// </summary>
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // TODO: 在此加入讀取/填充 countriesListBox 的實作
            StreamReader inputFile;
            try 
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\Countries.txt"); //"C:\Users\m303\Desktop\Countries.txt"
                countriesListBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    string country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        /// <summary>
        /// 離開按鈕事件處理方法（關閉表單）。
        /// 詳細說明：
        /// - 呼叫 this.Close() 將觸發表單關閉流程，若有需要可在 FormClosing 事件中處理保存或取消邏輯。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並結束應用程式視窗（若為主要表單）。
            this.Close();
        }
    }
}
