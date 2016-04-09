using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace MyERP.Web.ORDER_YSJZ
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		MyERP.BLL.ORDER_YSJZ bll=new MyERP.BLL.ORDER_YSJZ();
		MyERP.Model.ORDER_YSJZ model=bll.GetModel();
		this.lblFDID.Text=model.FDID;
		this.lblcustomcode.Text=model.customcode;
		this.lblcustomname.Text=model.customname;
		this.lblSJJZ.Text=model.SJJZ.ToString();
		this.lblQZZK.Text=model.QZZK.ToString();
		this.lblQZYS.Text=model.QZYS.ToString();
		this.lblYSJE.Text=model.YSJE.ToString();
		this.lblYSWS.Text=model.YSWS.ToString();
		this.lblbegindate.Text=model.begindate;
		this.lblenddate.Text=model.enddate;
		this.lblcreatename.Text=model.createname;
		this.lblcreatedate.Text=model.createdate;
		this.lblremark.Text=model.remark;

	}


    }
}
