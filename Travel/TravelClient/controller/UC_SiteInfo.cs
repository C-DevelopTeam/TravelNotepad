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
using System.Xml;


namespace TravelClient.controller
{
    public delegate void delegate_getTask();
    public partial class UC_SiteInfo : UserControl
    {
        ChangePanel changePanel;
        Route route = new Route();
        string sitename = "";
        string siteId;
        string TravelTitle;
        bool isCreate = false;
        long travelId;
        public delegate_getTask delegate_Get;
        string cmbMarkNumText;
        string keyword;
        string city = "";
        Dictionary<string, Site> sites = new Dictionary<string, Site>();



        public UC_SiteInfo(ChangePanel changePanel,string travelTitle, long travelId, bool isCreate = false, long routeID=-1, string siteId="")
        {
            InitializeComponent();
            //SetFont();
            this.isCreate = isCreate;
            this.changePanel = changePanel;
            this.TravelTitle = travelTitle;
            this.travelId = travelId;

            comboBox_site.TextUpdate += ComboBox_site_TextUpdate;

            this.Lbl_title.Text = travelTitle;
            if (isCreate==false)
            {
                this.route.RouteId = routeID;
                this.siteId = siteId;

                initinfo();
            }
            
            
        }

        private async void GetSiteName()
        {
            string url = "https://localhost:5001/api/site/get?siteId=" + siteId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Site));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    Site site = (Site)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    sitename = site.SiteName;
                    this.comboBox_site.Text = sitename;
                    city = site.City;
                    TxtBox_city.Text = city;
                }
                else
                {
                    using (Form_Tips tip = new Form_Tips("警告", "获取失败"))
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

        private void ComboBox_site_TextUpdate(object sender, EventArgs e)
        {
            city = TxtBox_city.Text;
            keyword = comboBox_site.Text;
            sites.Clear();
            comboBox_site.Items.Clear();
            getSites();
        }

        private void comboBox_site_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void getSites()
        {
            Client client = new Client();
            string url = "https://restapi.amap.com/v3/assistant/inputtips?key=6ed5794f8d092ea145181b36e643ff22&keywords="+keyword+"&city="+city+"&output=XML";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Site>));
            HttpResponseMessage result = await client.Get(url);

            
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(await result.Content.ReadAsStreamAsync());
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//tip");
            foreach (XmlElement element in xmlNodeList)
            {
                Site site = new Site();
                site.SiteId = element.ChildNodes[0].InnerText;
                site.SiteName = element.ChildNodes[1].InnerText;
                site.Distinct = element.ChildNodes[2].InnerText;
                site.Adcode = element.ChildNodes[3].InnerText;
                site.Location = element.ChildNodes[4].InnerText;
                site.Address = element.ChildNodes[5].InnerText;
                site.City = city;
                if(!sites.Keys.Contains(site.SiteName))
                {
                    sites.Add(site.SiteName, site);
                }
                comboBox_site.Items.Add(site.SiteName);
            }
            comboBox_site.DroppedDown = true;

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
                Font titleFont10 = new Font(font.Families[0], 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_site.Font = titleFont12;
                Lbl_timeForArrive.Font = titleFont12;
                Lbl_timeForLeave.Font = titleFont12;
                Lbl_title.Font = titleFont20;
                Lbl_vehicle.Font = titleFont12;
                Lbl_city.Font = titleFont12;
                Btn_delete.Font = titleFont10;
                Btn_Comfirm.Font = titleFont10;

            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private async void initinfo()
        {
            
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
                    GetSiteName();
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
                        if (!result.IsSuccessStatusCode)
                        {
                            using (Form_Tips tip = new Form_Tips("提示", "修改失败"))
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
            else
            {
                string url = "https://localhost:5001/api/route";
                string urlOfSite = "https://localhost:5001/api/Site";
                XmlSerializer xmlSerializerForRoute = new XmlSerializer(typeof(Route));
                XmlSerializer xmlSerializerForSite = new XmlSerializer(typeof(Site));
                Client client = new Client();
                try
                {
                    string data = "";
                    string dataOfSite = "";
                    Route routeToSend = new Route();
                    routeToSend.Method = this.Txtbos_vehicle.Text;
                    routeToSend.StartTime = this.dateTimePicker1.Value;
                    routeToSend.EndTime = this.dateTimePicker2.Value;
                    routeToSend.TravelId = travelId;
                    Site site = new Site();
                    site = sites[comboBox_site.Text];
                    routeToSend.StartSiteId = site.SiteId;
                    //添加site

                    using (StringWriter sw = new StringWriter())
                    {
                        xmlSerializerForRoute.Serialize(sw, routeToSend);
                        data = sw.ToString();
                    }

                    using (StringWriter sw = new StringWriter())
                    {
                        xmlSerializerForSite.Serialize(sw, site);
                        dataOfSite = sw.ToString();
                    }
                    HttpResponseMessage resultOfSite = await client.Post(urlOfSite, dataOfSite);

                    HttpResponseMessage result = new HttpResponseMessage();

                    if (resultOfSite.IsSuccessStatusCode)
                    {
                        result = await client.Post(url, data);
                    }
                    
                    if (result.IsSuccessStatusCode)
                    {
                        Route newRoute = (Route)xmlSerializerForRoute.Deserialize(await result.Content.ReadAsStreamAsync());
                        routeToSend = newRoute;
                        isCreate = false;
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

        private async void Btn_delete_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:5001/api/Route/delete?routeId=" + route.RouteId;
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Delete(url);
                if (result.IsSuccessStatusCode)
                {
                    UC_AllSites uc_as = new UC_AllSites(changePanel, TravelTitle, travelId);
                    changePanel(uc_as);
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
                using (Form_Tips tip = new Form_Tips("警告", ex.Message))
                {
                    tip.ShowDialog();
                }
            }
        }
    }
}
