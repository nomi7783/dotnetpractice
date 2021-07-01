using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetPractice
{
    public partial class ApiHitPractice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string str = webClient.DownloadString("https://jsonplaceholder.typicode.com/users");


            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<users> lstUsers = javaScriptSerializer.Deserialize<List<users>>(str);


            GridView1.DataSource = lstUsers;
            GridView1.DataBind();


        }
    }

    public class users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public company company { get; set; }
    }

    public class address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }

        public geo geo { get; set; }

    }

    public class geo
    {
        public string lat { get; set; }

        public string lng { get; set; }
    }

    public class company
    {
        public string name { get; set; }

        public string catchPhrase { get; set; }

        public string bs { get; set; }

    }
}