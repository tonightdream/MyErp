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
namespace MyERP.Web.STEEL_DA
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSEQUENCE.Text))
			{
				strErr+="SEQUENCE格式错误！\\n";	
			}
			if(this.txtITEM_INTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_NAME.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_NAME不能为空！\\n";	
			}
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtITEM_HD.Text.Trim().Length==0)
			{
				strErr+="ITEM_HD不能为空！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
			}
			if(this.txtPARENT_ITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_ITEM_CODE不能为空！\\n";	
			}
			if(this.txtTYPE_NAME.Text.Trim().Length==0)
			{
				strErr+="TYPE_NAME不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtITEM_rate.Text.Trim().Length==0)
			{
				strErr+="ITEM_rate不能为空！\\n";	
			}
			if(this.txtMEASURE_CODE.Text.Trim().Length==0)
			{
				strErr+="MEASURE_CODE不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNET_PRICE.Text))
			{
				strErr+="NET_PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQTY.Text))
			{
				strErr+="QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtACTUAL_QTY.Text))
			{
				strErr+="ACTUAL_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMIN_QTY.Text))
			{
				strErr+="MIN_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMAX_QTY.Text))
			{
				strErr+="MAX_QTY格式错误！\\n";	
			}
			if(this.txtPOSITION_CODE.Text.Trim().Length==0)
			{
				strErr+="POSITION_CODE不能为空！\\n";	
			}
			if(this.txtPOSITION.Text.Trim().Length==0)
			{
				strErr+="POSITION不能为空！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
			}
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUPDATE_DATE.Text))
			{
				strErr+="UPDATE_DATE格式错误！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
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
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string SUPPLY_CODE=this.txtSUPPLY_CODE.Text;
			string SUPPLY_NAME=this.txtSUPPLY_NAME.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_HD=this.txtITEM_HD.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			byte[] IMAGE= new UnicodeEncoding().GetBytes(this.txtIMAGE.Text);
			string PARENT_ITEM_CODE=this.txtPARENT_ITEM_CODE.Text;
			string TYPE_NAME=this.txtTYPE_NAME.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string ITEM_rate=this.txtITEM_rate.Text;
			string MEASURE_CODE=this.txtMEASURE_CODE.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal QTY=decimal.Parse(this.txtQTY.Text);
			decimal ACTUAL_QTY=decimal.Parse(this.txtACTUAL_QTY.Text);
			decimal MIN_QTY=decimal.Parse(this.txtMIN_QTY.Text);
			decimal MAX_QTY=decimal.Parse(this.txtMAX_QTY.Text);
			string POSITION_CODE=this.txtPOSITION_CODE.Text;
			string POSITION=this.txtPOSITION.Text;
			string DESCRIPTION=this.txtDESCRIPTION.Text;
			string BARCODE=this.txtBARCODE.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.STEEL_DA model=new MyERP.Model.STEEL_DA();
			model.SEQUENCE=SEQUENCE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.SUPPLY_CODE=SUPPLY_CODE;
			model.SUPPLY_NAME=SUPPLY_NAME;
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_HD=ITEM_HD;
			model.ITEM_TYPE=ITEM_TYPE;
			model.ITEM_COLOR=ITEM_COLOR;
			model.IMAGE=IMAGE;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.TYPE_NAME=TYPE_NAME;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.ITEM_rate=ITEM_rate;
			model.MEASURE_CODE=MEASURE_CODE;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.QTY=QTY;
			model.ACTUAL_QTY=ACTUAL_QTY;
			model.MIN_QTY=MIN_QTY;
			model.MAX_QTY=MAX_QTY;
			model.POSITION_CODE=POSITION_CODE;
			model.POSITION=POSITION;
			model.DESCRIPTION=DESCRIPTION;
			model.BARCODE=BARCODE;
			model.CREATE_DATE=CREATE_DATE;
			model.CREATE_NAME=CREATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.REMARK=REMARK;

			MyERP.BLL.STEEL_DA bll=new MyERP.BLL.STEEL_DA();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
