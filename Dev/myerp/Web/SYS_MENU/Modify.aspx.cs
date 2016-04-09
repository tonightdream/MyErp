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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace MyERP.Web.SYS_MENU
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string MENU_CODE= Request.Params["id"];
					ShowInfo(MENU_CODE);
				}
			}
		}
			
	private void ShowInfo(string MENU_CODE)
	{
		MyERP.BLL.SYS_MENU bll=new MyERP.BLL.SYS_MENU();
		MyERP.Model.SYS_MENU model=bll.GetModel(MENU_CODE);
		this.lblMENU_CODE.Text=model.MENU_CODE;
		this.txtMENU_NAME.Text=model.MENU_NAME;
		this.lblMenuID.Text=model.MenuID.ToString();
		this.txtIMAGE_INDEX.Text=model.IMAGE_INDEX.ToString();
		this.txtMENU_UNIT.Text=model.MENU_UNIT;
		this.txtPARENT_MENU_CODE.Text=model.PARENT_MENU_CODE;
		this.chkSysSelect.Checked=model.SysSelect;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMENU_NAME.Text.Trim().Length==0)
			{
				strErr+="MENU_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIMAGE_INDEX.Text))
			{
				strErr+="IMAGE_INDEX格式错误！\\n";	
			}
			if(this.txtMENU_UNIT.Text.Trim().Length==0)
			{
				strErr+="MENU_UNIT不能为空！\\n";	
			}
			if(this.txtPARENT_MENU_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_MENU_CODE不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string MENU_CODE=this.lblMENU_CODE.Text;
			string MENU_NAME=this.txtMENU_NAME.Text;
			Guid MenuID= new Guid(this.lblMenuID.Text);
			int IMAGE_INDEX=int.Parse(this.txtIMAGE_INDEX.Text);
			string MENU_UNIT=this.txtMENU_UNIT.Text;
			string PARENT_MENU_CODE=this.txtPARENT_MENU_CODE.Text;
			bool SysSelect=this.chkSysSelect.Checked;


			MyERP.Model.SYS_MENU model=new MyERP.Model.SYS_MENU();
			model.MENU_CODE=MENU_CODE;
			model.MENU_NAME=MENU_NAME;
			model.MenuID=MenuID;
			model.IMAGE_INDEX=IMAGE_INDEX;
			model.MENU_UNIT=MENU_UNIT;
			model.PARENT_MENU_CODE=PARENT_MENU_CODE;
			model.SysSelect=SysSelect;

			MyERP.BLL.SYS_MENU bll=new MyERP.BLL.SYS_MENU();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
