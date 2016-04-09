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
namespace MyERP.Web.PUB_FIXEDASSET
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ITEM_INTERNAL_CODE= Request.Params["id"];
					ShowInfo(ITEM_INTERNAL_CODE);
				}
			}
		}
			
	private void ShowInfo(string ITEM_INTERNAL_CODE)
	{
		MyERP.BLL.PUB_FIXEDASSET bll=new MyERP.BLL.PUB_FIXEDASSET();
		MyERP.Model.PUB_FIXEDASSET model=bll.GetModel(ITEM_INTERNAL_CODE);
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtFIXEDASSET_CODE.Text=model.FIXEDASSET_CODE;
		this.txtFIXEDASSET_NAME.Text=model.FIXEDASSET_NAME;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.txtSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.txtOUT_DATE.Text=model.OUT_DATE.ToString();
		this.txtPOWER_RATE.Text=model.POWER_RATE;
		this.txtBEGIN_DATE.Text=model.BEGIN_DATE;
		this.txtEND_DATE.Text=model.END_DATE;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtQUANTITY.Text=model.QUANTITY.ToString();
		this.txtFIXEDASSET_STATUS.Text=model.FIXEDASSET_STATUS;
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtPOSITION.Text=model.POSITION;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFIXEDASSET_CODE.Text.Trim().Length==0)
			{
				strErr+="FIXEDASSET_CODE不能为空！\\n";	
			}
			if(this.txtFIXEDASSET_NAME.Text.Trim().Length==0)
			{
				strErr+="FIXEDASSET_NAME不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtSUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_NAME.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOUT_DATE.Text))
			{
				strErr+="OUT_DATE格式错误！\\n";	
			}
			if(this.txtPOWER_RATE.Text.Trim().Length==0)
			{
				strErr+="POWER_RATE不能为空！\\n";	
			}
			if(this.txtBEGIN_DATE.Text.Trim().Length==0)
			{
				strErr+="BEGIN_DATE不能为空！\\n";	
			}
			if(this.txtEND_DATE.Text.Trim().Length==0)
			{
				strErr+="END_DATE不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
			}
			if(this.txtFIXEDASSET_STATUS.Text.Trim().Length==0)
			{
				strErr+="FIXEDASSET_STATUS不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtPOSITION.Text.Trim().Length==0)
			{
				strErr+="POSITION不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUPDATE_DATE.Text))
			{
				strErr+="UPDATE_DATE格式错误！\\n";	
			}
			if(this.txtREMARK.Text.Trim().Length==0)
			{
				strErr+="REMARK不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ITEM_INTERNAL_CODE=this.lblITEM_INTERNAL_CODE.Text;
			string FIXEDASSET_CODE=this.txtFIXEDASSET_CODE.Text;
			string FIXEDASSET_NAME=this.txtFIXEDASSET_NAME.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string SUPPLY_CODE=this.txtSUPPLY_CODE.Text;
			string SUPPLY_NAME=this.txtSUPPLY_NAME.Text;
			DateTime OUT_DATE=DateTime.Parse(this.txtOUT_DATE.Text);
			string POWER_RATE=this.txtPOWER_RATE.Text;
			string BEGIN_DATE=this.txtBEGIN_DATE.Text;
			string END_DATE=this.txtEND_DATE.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			string FIXEDASSET_STATUS=this.txtFIXEDASSET_STATUS.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string POSITION=this.txtPOSITION.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_FIXEDASSET model=new MyERP.Model.PUB_FIXEDASSET();
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.FIXEDASSET_CODE=FIXEDASSET_CODE;
			model.FIXEDASSET_NAME=FIXEDASSET_NAME;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.SUPPLY_CODE=SUPPLY_CODE;
			model.SUPPLY_NAME=SUPPLY_NAME;
			model.OUT_DATE=OUT_DATE;
			model.POWER_RATE=POWER_RATE;
			model.BEGIN_DATE=BEGIN_DATE;
			model.END_DATE=END_DATE;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.QUANTITY=QUANTITY;
			model.FIXEDASSET_STATUS=FIXEDASSET_STATUS;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.POSITION=POSITION;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_FIXEDASSET bll=new MyERP.BLL.PUB_FIXEDASSET();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
