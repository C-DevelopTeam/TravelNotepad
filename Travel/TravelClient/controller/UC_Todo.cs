using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelClient.utils;
using System.Net.Http;
using TravelClient.form;
using System.IO;

namespace TravelClient.controller
{
    public partial class UC_Todo : UserControl
    {
        Models.Task task = new Models.Task();
        public delegate_getTask delegate_Get;

        public UC_Todo(Models.Task task,delegate_getTask getTask)
        {
            InitializeComponent();
            this.task = task;
            Cbx_todo.Text = task.Description;
            this.delegate_Get = getTask;
            if(task.State == 1)
            {
                Cbx_todo.Checked = true;
            }
            else
            {
                Cbx_todo.Checked = false;
            }
            SetFont();
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font titleFont12 = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Cbx_todo.Font = titleFont12;

            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void Btn_deleteTodo_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:5001/api/Task/delete?taskId=" + task.TaskId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Models.Task>));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Delete(url);
                if (result.IsSuccessStatusCode)
                {
                    delegate_Get();
                }
                else
                {
                    using (Form_Tips tip = new Form_Tips("警告", "初始化信息失败"))
                    {
                        tip.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void Cbx_todo_CheckedChanged(object sender, EventArgs e)
        {
            if(Cbx_todo.Checked==true)
            {
                task.State = 1;
            }
            else
            {
                task.State = 0;
            }

            string url = "https://localhost:5001/api/Task/update?taskId="+task.TaskId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Models.Task));
            Client client = new Client();

            try
            {
                string data = "";
                using (StringWriter sw = new StringWriter())
                {
                    xmlSerializer.Serialize(sw, task);
                    data = sw.ToString();
                }
                HttpResponseMessage result = await client.Put(url, data);
                if (result.IsSuccessStatusCode)
                {

                }
                else
                {
                    using (Form_Tips tip = new Form_Tips("警告", result.StatusCode.ToString()))
                    {
                        tip.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

