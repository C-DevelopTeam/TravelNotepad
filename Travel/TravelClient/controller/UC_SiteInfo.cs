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
using TravelClient.form;
using TravelClient.Models;
using System.Xml.Serialization;
using TravelClient.utils;
using System.Net.Http;
using System.IO;

namespace TravelClient.controller
{
    public delegate void delegate_getTask();
    public partial class UC_SiteInfo : UserControl
    {
        ChangePanel changePanel;
        Route route = new Route();
        string sitename = "";
        string TravelTitle;
        bool isCreate = false;
        long travelId;
        public delegate_getTask delegate_Get;

        public UC_SiteInfo(ChangePanel changePanel,string travelTitle, long travelId, long routeID=-1,string siteName="",bool isCreate = false)
        {
            InitializeComponent();
            SetFont();
            this.isCreate = isCreate;
            this.changePanel = changePanel;
            this.TravelTitle = travelTitle;

            this.Lbl_title.Text = travelTitle;
            if (isCreate==false)
            {
                this.route.RouteId = routeID;
                this.sitename = siteName;
                this.travelId = travelId;

                initinfo();
            }
            
            
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");
                Font titleFont20 = new Font(font.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont12 = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_site.Font = titleFont12;
                Lbl_timeForArrive.Font = titleFont12;
                Lbl_timeForLeave.Font = titleFont12;
                Lbl_title.Font = titleFont20;
                Lbl_vehicle.Font = titleFont12;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private async void initinfo()
        {
            this.Txtbox_site.Text = sitename;
            string url = "https://localhost:5001/api/route?routeId=" + route.RouteId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Route));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    Route route = (Route)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    this.Txtbos_vehicle.Text = route.Method;
                    this.dateTimePicker1.Value = route.StartTime;
                    this.dateTimePicker2.Value = route.EndTime;
                    getTask();
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

        public async void getTask()
        {
            string url = "https://localhost:5001/api/Task/get?routeId=" + route.RouteId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Models.Task>));
            Client client = new Client();
            flowLayoutPanel_todo.Controls.Clear();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    List<Models.Task> tasks = (List<Models.Task>)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    foreach (Models.Task task in tasks)
                    {
                        UC_Todo cell = new UC_Todo(task,delegate_Get);
                        //添加到panel中
                        flowLayoutPanel_todo.Controls.Add(cell);
                    }
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


        private void Btn_backToRoute_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_as = new UC_AllSites(changePanel,TravelTitle,travelId);
            changePanel(uc_as);
        }

        private void AddControlsToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }


        private void Btn_addSite_Click(object sender, EventArgs e)
        {
            
        }

        private async void Btn_addtodo_Click(object sender, EventArgs e)
        {
            if(TxtBox_todo.Text.Length==0)
            {
                using (Form_Tips tip = new Form_Tips("警告", "待办事项为空"))
                {
                    tip.ShowDialog();
                }
            }
            else
            {
                Models.Task task = new Models.Task();
                task.State = 0;
                task.RouteId = route.RouteId;
                task.Description = TxtBox_todo.Text;

                string url = "https://localhost:5001/api/Task";
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
                    HttpResponseMessage result = await client.Post(url, data);
                    if (result.IsSuccessStatusCode)
                    {

                        using (Form_Tips tip = new Form_Tips("提示", "成功创建"))
                        {
                            tip.ShowDialog();
                        }
                        TxtBox_todo.Text = "";
                        flowLayoutPanel_todo.Controls.Clear();
                        getTask();
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

        private async void Btn_Comfirm_Click(object sender, EventArgs e)
        {
            if (isCreate == false)
            {
                string url = "https://localhost:5001/api/route?routeId=" + route.RouteId;
                string url2 = "https://localhost:5001/api/route/update?routeId=" + route.RouteId;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Route));
                Client client = new Client();
                try
                {
                    string data = "";
                    HttpResponseMessage result = await client.Get(url);
                    if (result.IsSuccessStatusCode)
                    {
                        Route route = (Route)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                        route.Method = this.Txtbos_vehicle.Text;
                        route.StartTime = this.dateTimePicker1.Value;
                        route.EndTime = this.dateTimePicker2.Value;
                        using (StringWriter sw = new StringWriter())
                        {
                            xmlSerializer.Serialize(sw, route);
                            data = sw.ToString();
                        }

                        result = await client.Put(url2, data);
                        if (result.IsSuccessStatusCode)
                        {
                            using (Form_Tips tip = new Form_Tips("提示", "修改成功"))
                            {
                                tip.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        using (Form_Tips tip = new Form_Tips("警告", "信息有误"))
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
}
