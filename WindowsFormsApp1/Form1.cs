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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;
namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        public const int WM_DEVICECHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;
        public const int DBT_CONFIGCHANGED = 0x0018;
        public const int DBT_CUSTOMEVENT = 0x8006;
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;
        public const int DBT_DEVNODES_CHANGED = 0x0007;
        public const int DBT_QUERYCHANGECONFIG = 0x0017;
        public const int DBT_USERDEFINED = 0xFFFF;
        public JObject wifi;
        public JObject rp;
        public string path;
        public int tag = 1;

        public SynchronizationContext _syncContext = null;
        public Form1()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
            this.Load += new EventHandler(Form1_Load);
        }
   

      

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("111111111111");
            DriveInfo[] s = DriveInfo.GetDrives();
            ;
            foreach (DriveInfo drive in s)
            {
                ;//Gamepad cfg
                if (drive.VolumeLabel == "P5gamepad")
                {
                    path = drive.Name;
                    Console.WriteLine(path);
                 
                    tag = 0;
                    device.Text = "Drive:" + drive.VolumeLabel;
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                   
                    return;
                } else if (drive.VolumeLabel == "mscboot") {
                    path = drive.Name;
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    return;
                }
            }

        }

        public string Readjson(string jsonfile, string wifinamestr,string wifipwdstr)
        {
            // string jsonfile = "h://wifi.json";//JSON文件路径

            string txt = "";
            StreamReader sr = new StreamReader(@jsonfile);

            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                txt += str + "\n";
            }

            sr.Close();
            string[] strArray = txt.Split('\n');
            string str1 = strArray[0];
            string str2 = strArray[1];

            string[] ud =  str1.Split(':');
            string[] ud1 = str2.Split(':');
            if (wifinamestr.Length!=0) {
                ud[1] = " " + wifinamestr;
            }
            if (wifipwdstr.Length != 0)
            {
                ud1[1] = " " + wifipwdstr;
            }

           

            strArray[0] = string.Join(":", ud);
            strArray[1] = string.Join(":", ud1);

            string newtext = string.Join("\n", strArray);

            Console.WriteLine(newtext);
            return newtext;
            //using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))

            //{
            //Console.WriteLine(file);
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            // JObject o = (JObject)JToken.ReadFrom(reader);

            //   Console.WriteLine(o);
            //     return o;
            //   }
            // }
        }

      


    protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        case DBT_DEVICEARRIVAL://U盘插入
                            DriveInfo[] s = DriveInfo.GetDrives();
                           ;
                            foreach (DriveInfo drive in s)
                            {
                                ;
                                if (drive.VolumeLabel == "P5gamepad")
                                {
                                    path = drive.Name;
                                   
                                    tag = 0;
                                    device.Text = "设备:" + drive.VolumeLabel;
                                    groupBox1.Visible = true;
                                    groupBox2.Visible = false;
                                    break;
                                }
                                else if (drive.VolumeLabel == "mscboot")
                                {
                                    path = drive.Name;
                                    groupBox1.Visible = false;
                                    groupBox2.Visible = true;
                                    break;
                                }
                            }
                            break;
                        case DBT_CONFIGCHANGECANCELED:
                            break;
                        case DBT_CONFIGCHANGED:
                            break;
                        case DBT_CUSTOMEVENT:
                            break;
                        case DBT_DEVICEQUERYREMOVE:
                            break;
                        case DBT_DEVICEQUERYREMOVEFAILED:
                            break;
                        case DBT_DEVICEREMOVECOMPLETE: //U盘卸载
                            device.Text = "没有连接设备";
                            tag = 1;
                            break;
                        case DBT_DEVICEREMOVEPENDING:
                            break;
                        case DBT_DEVICETYPESPECIFIC:
                            break;
                        case DBT_DEVNODES_CHANGED:
                            break;
                        case DBT_QUERYCHANGECONFIG:
                            break;
                        case DBT_USERDEFINED:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //调用系统默认的浏览器
            System.Diagnostics.Process.Start("https://id.sonyentertainmentnetwork.com/signin/?service_entity=urn:service-entity:psn&response_type=code&client_id=ba495a24-818c-472b-b12d-ff231c1b5745&redirect_uri=https://remoteplay.dl.playstation.net/remoteplay/redirect&scope=psn:clientapp&request_locale=en_US&ui=pr&service_logo=ps&layout_type=popup&smcid=remoteplay&PlatformPrivacyWs1=minimal&error=login_required&error_code=4165&error_description=User+is+not+authenticated&no_captcha=false#/signin?entry=%2Fsignin");


        }

        private  void  button2_Click(object sender, EventArgs e)
        {
            if (tag == 1)
            {
                MessageBox.Show("设备还没有连接");
            }
            else {
               



                string wifinamestr = wifiname.Text;
                string wifipwdstr = wifipwd.Text;
                string pinstr = pinid.Text;
                string pinidnamestr = psnidname.Text;


                string wifioutput = Readjson(path + "Wifi Config.txt", wifinamestr, wifipwdstr);
                string rpoutput = Readjson(path + "PSN Config.txt", pinidnamestr, pinstr);

                File.WriteAllText(path + "PSN Config.txt", rpoutput); 
                File.WriteAllText(path + "Wifi Config.txt", wifioutput);
                 

                // rp["psn_id"] = pinidnamestr;
                // rp["pin"] = pinstr;
                // wifi["ssid"] = wifinamestr;
                // wifi["pass"] = wifipwdstr;
                //Console.WriteLine(rp);
                //Console.WriteLine(wifi);
                //string wifioutput = Newtonsoft.Json.JsonConvert.SerializeObject(wifi, Newtonsoft.Json.Formatting.Indented);
                // string rpoutput = Newtonsoft.Json.JsonConvert.SerializeObject(rp, Newtonsoft.Json.Formatting.Indented);
                // File.WriteAllText(path + "wifi.json", wifioutput);
                // File.WriteAllText(path + "rp.json", rpoutput);

                 MessageBox.Show("保存成功，请手柄按HOME键连接PS4/5主机");
            }





        }

        


        private static byte[] strSToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++) {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                Console.WriteLine(returnBytes[i]);
            }
            Array.Reverse(returnBytes);
          

            return returnBytes;
        } 


        private void getID_Click(object sender, EventArgs e)
        {

            



            String url =  maskedTextBox2.Text;
            if (url.Length > 5)
            {
                var obj = ParseUrl(url, out url);
                string code = obj["code"];
                String address = "https://auth.api.sonyentertainmentnetwork.com/2.0/oauth/token";
                Dictionary<string, string> openWith = new Dictionary<string, string>();
                openWith.Add("grant_type", "authorization_code");
                openWith.Add("code", code);
                openWith.Add("redirect_uri", "https://remoteplay.dl.playstation.net/remoteplay/redirect");

               
                try
                {
                    Post(address, openWith);
                }
                catch
                {
                    MessageBox.Show("网络错误,或者PSN服务器无法连接,或者url有误");
                }

            }
            else {
                MessageBox.Show("没有正确的url");
            }
            



        }

        public  string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Authorization", "Basic YmE0OTVhMjQtODE4Yy00NzJiLWIxMmQtZmYyMzFjMWI1NzQ1Om12YWlaa1JzQXNJMUlCa1k=");
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            string access_token = jo["access_token"].ToString();
            GetID("https://auth.api.sonyentertainmentnetwork.com/2.0/oauth/token/" + access_token);
            return result;
        }

        public  void GetID(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Headers.Add("Authorization", "Basic YmE0OTVhMjQtODE4Yy00NzJiLWIxMmQtZmYyMzFjMWI1NzQ1Om12YWlaa1JzQXNJMUlCa1k=");
            req.Method = "GET";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            string id = jo["user_id"].ToString();
            string str = Convert.ToString(long.Parse(id), 16);
            string strd = Convert.ToBase64String(strSToToHexByte(str));
            psnidname.Text = strd;
            MessageBox.Show("成功获取");

        }
        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        public string GetSimplePath(string path)
        {
            //E:\Upload\cms\day_150813\1.jpg
            path = path.Replace(@"\", "/");
            int pos = path.IndexOf("Upload");
            if (pos != -1)
            {
                pos = pos - 1;//拿到前面那个/,这样为绝对路径，直接保存在整个项目下的upload文件夹下
                return path.Substring(pos, path.Length - pos);
            }
            return "";
        }

        public void method() {
            CopyFileByUrl("http://www.xjycs.top/frm/frmdown?tag=1");

        }

        private void SetLabelText(object text)
        {
            progressBar1.Value = int.Parse(text.ToString());
        }



        public void CopyFileByUrl(string url)
          {

                                                                   //启动线程
            
          
            //string name = url.Substring(url.LastIndexOf('/') + 1);//获取名字
            string fileFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
              string filePath = Path.Combine(fileFolder, "firmware.bin");//存放地址就是本地的upload下的同名的文件
             
             HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
             request.Method = "GET";
             request.ProtocolVersion = new Version(1, 1);
             HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            
             // 转换为byte类型
             System.IO.Stream stream = response.GetResponseStream();
    
 
             //创建本地文件写入流
             Stream fs = new FileStream(fileFolder+ "/firmware.bin", FileMode.Create);
             byte[] bArr = new byte[1024];
             int size = stream.Read(bArr, 0, (int)bArr.Length);
             while (size > 0)
             {
                 fs.Write(bArr, 0, size);
                 size = stream.Read(bArr, 0, (int) bArr.Length);
             }
             fs.Close();
             stream.Close();
            
            File.Copy(fileFolder + "/firmware.bin", path + "/firmware.bin", true);
            _syncContext.Post(SetLabelText, "100");
            MessageBox.Show("更新完毕");
            
           
        }











        public static System.Collections.Specialized.NameValueCollection ParseUrl(string url, out string baseUrl)
        {
            baseUrl = "";
            if (string.IsNullOrEmpty(url))
                return null;
            System.Collections.Specialized.NameValueCollection nvc = new System.Collections.Specialized.NameValueCollection();

            try
            {
                int questionMarkIndex = url.IndexOf('?');

                if (questionMarkIndex == -1)
                    baseUrl = url;
                else
                    baseUrl = url.Substring(0, questionMarkIndex);
                if (questionMarkIndex == url.Length - 1)
                    return null;
                string ps = url.Substring(questionMarkIndex + 1);

                // 开始分析参数对   
                System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(@"(^|&)?(\w+)=([^&]+)(&|$)?", System.Text.RegularExpressions.RegexOptions.Compiled);
                System.Text.RegularExpressions.MatchCollection mc = re.Matches(ps);

                foreach (System.Text.RegularExpressions.Match m in mc)
                {
                    nvc.Add(m.Result("$2").ToLower(), m.Result("$3"));
                }

            }
            catch { }
            return nvc;
        }

        private void psnidname_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void device_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            Thread thread = new Thread(new ThreadStart(method));//创建线程
            thread.IsBackground = true;
             thread.Start();  
         


        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            Thread thread = new Thread(new ThreadStart(method));//创建线程
            thread.IsBackground = true;
            thread.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
