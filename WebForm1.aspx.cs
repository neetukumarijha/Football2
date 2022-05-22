using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Football
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.tblFootBallLeagues;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            GridView1.DataSource = from football in data.tblFootBallLeagues
                                   where football.TeamName1 == "Japan" || football.TeamName2 == "Japan"
                                   select football;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            NewMethod3();
        }
        private void NewMethod3()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            GridView1.DataSource = from football in data.tblFootBallLeagues
                                   where football.MatchStatus == "Draw"
                                   select football;
            GridView1.DataBind();
        }
        private void Getdata()
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            GridView1.DataSource = dataClasses1DataContext.tblFootBallLeagues;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            GridView1.DataSource = from football in data.tblFootBallLeagues
                                   where football.MatchStatus=="Win"
                                   select football;
            GridView1.DataBind();

        }
    }
}