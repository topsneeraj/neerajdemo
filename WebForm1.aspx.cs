using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection cn;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=c7b3df84-c1c0-483b-81ee-a42900abb864.sqlserver.sequelizer.com;Database=dbc7b3df84c1c0483b81eea42900abb864;User ID=wiyqiurndtqtnqzc;Password=GgiXFixcKYErQyV5nXBNFt2uecpChr3iJrdxoxuS55dDrzYQ7SGQkpGonWSC243t;");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into userinfo values(@a,@b)", cn);
            cmd.Parameters.AddWithValue("@a", TextBox1.Text);
            cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        
            cn.Open();
          int i=  cmd.ExecuteNonQuery();
          if (i > 0)
          {
              Label1.Text = "record inserted succfully";
          }
          else
          {
              Label1.Text = "sorry shktiman..!!!";
          }
            cn.Close();
            Label1.Text = "record inserted succfully";
        }
    }
}
