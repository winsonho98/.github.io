using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBotFaceRecognition
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "FYc+kenfRVcGiib82+/dJTprR5/kQ3J/0tIzwIdqNjqXncny4m4WGo5ux7LsJ5zk/s/BOEmVICQ6Acgr+cUAox/6ADG9Dt7JCzjSoYffgcT9KXD65gLpPqZCsguraQA6HGn69myslaXcUA5f3/5h91GUYhWQfeY8sLGRXgo3xvw=";
        const string AdminUserId= "U31d140b4970d5fea454be423ebf3ce97";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}