﻿using System;
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
namespace MyERP.Web.WL_DA
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
		MyERP.BLL.WL_DA bll=new MyERP.BLL.WL_DA();
		MyERP.Model.WL_DA model=bll.GetModel(ITEM_INTERNAL_CODE);
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtITEM_COLOR.Text=model.ITEM_COLOR;
		this.txtPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.txtITEM_TYPE.Text=model.ITEM_TYPE;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtITEM_CZ.Text=model.ITEM_CZ;
		this.txtITEM_JZ.Text=model.ITEM_JZ.ToString();
		this.txtITEM_HZ.Text=model.ITEM_HZ.ToString();
		this.txtITEM_GYLC.Text=model.ITEM_GYLC;
		this.txtDICT_CODE.Text=model.DICT_CODE;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtTYPE_NAME.Text=model.TYPE_NAME;
		this.txtNET_PRICE.Text=model.NET_PRICE.ToString();
		this.txtPRICE.Text=model.PRICE.ToString();
		this.txtMIN_QTY.Text=model.MIN_QTY.ToString();
		this.txtMAX_QTY.Text=model.MAX_QTY.ToString();
		this.txtPOSITION.Text=model.POSITION;
		this.txtIMAGE.Text=model.IMAGE.ToString();
		this.txtIMAGE_NAME.Text=model.IMAGE_NAME;
		this.txtActual_Qty.Text=model.Actual_Qty.ToString();
		this.txtBARCODE.Text=model.BARCODE;
		this.txtDESCRIPTION.Text=model.DESCRIPTION;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE_old.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE_old不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
			}
			if(this.txtPARENT_ITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtITEM_CZ.Text.Trim().Length==0)
			{
				strErr+="ITEM_CZ不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_JZ.Text))
			{
				strErr+="ITEM_JZ格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_HZ.Text))
			{
				strErr+="ITEM_HZ格式错误！\\n";	
			}
			if(this.txtITEM_GYLC.Text.Trim().Length==0)
			{
				strErr+="ITEM_GYLC不能为空！\\n";	
			}
			if(this.txtDICT_CODE.Text.Trim().Length==0)
			{
				strErr+="DICT_CODE不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtTYPE_NAME.Text.Trim().Length==0)
			{
				strErr+="TYPE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNET_PRICE.Text))
			{
				strErr+="NET_PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMIN_QTY.Text))
			{
				strErr+="MIN_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMAX_QTY.Text))
			{
				strErr+="MAX_QTY格式错误！\\n";	
			}
			if(this.txtPOSITION.Text.Trim().Length==0)
			{
				strErr+="POSITION不能为空！\\n";	
			}
			if(this.txtIMAGE_NAME.Text.Trim().Length==0)
			{
				strErr+="IMAGE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActual_Qty.Text))
			{
				strErr+="Actual_Qty格式错误！\\n";	
			}
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
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
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_CODE_old=this.txtITEM_CODE_old.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			string PARENT_ITEM_CODE=this.txtPARENT_ITEM_CODE.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string ITEM_CZ=this.txtITEM_CZ.Text;
			decimal ITEM_JZ=decimal.Parse(this.txtITEM_JZ.Text);
			decimal ITEM_HZ=decimal.Parse(this.txtITEM_HZ.Text);
			string ITEM_GYLC=this.txtITEM_GYLC.Text;
			string DICT_CODE=this.txtDICT_CODE.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string TYPE_NAME=this.txtTYPE_NAME.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal MIN_QTY=decimal.Parse(this.txtMIN_QTY.Text);
			decimal MAX_QTY=decimal.Parse(this.txtMAX_QTY.Text);
			string POSITION=this.txtPOSITION.Text;
			byte[] IMAGE= new UnicodeEncoding().GetBytes(this.txtIMAGE.Text);
			string IMAGE_NAME=this.txtIMAGE_NAME.Text;
			decimal Actual_Qty=decimal.Parse(this.txtActual_Qty.Text);
			string BARCODE=this.txtBARCODE.Text;
			string DESCRIPTION=this.txtDESCRIPTION.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.WL_DA model=new MyERP.Model.WL_DA();
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_CODE_old=ITEM_CODE_old;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_COLOR=ITEM_COLOR;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.ITEM_TYPE=ITEM_TYPE;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.ITEM_CZ=ITEM_CZ;
			model.ITEM_JZ=ITEM_JZ;
			model.ITEM_HZ=ITEM_HZ;
			model.ITEM_GYLC=ITEM_GYLC;
			model.DICT_CODE=DICT_CODE;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.TYPE_NAME=TYPE_NAME;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.MIN_QTY=MIN_QTY;
			model.MAX_QTY=MAX_QTY;
			model.POSITION=POSITION;
			model.IMAGE=IMAGE;
			model.IMAGE_NAME=IMAGE_NAME;
			model.Actual_Qty=Actual_Qty;
			model.BARCODE=BARCODE;
			model.DESCRIPTION=DESCRIPTION;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.WL_DA bll=new MyERP.BLL.WL_DA();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
