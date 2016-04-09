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
namespace MyERP.Web.STEEL_RECEIPT_DETAIL
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int TempID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(TempID);
				}
			}
		}
			
	private void ShowInfo(int TempID)
	{
		MyERP.BLL.STEEL_RECEIPT_DETAIL bll=new MyERP.BLL.STEEL_RECEIPT_DETAIL();
		MyERP.Model.STEEL_RECEIPT_DETAIL model=bll.GetModel(TempID);
		this.lblTempID.Text=model.TempID.ToString();
		this.txtBillNo.Text=model.BillNo;
		this.txtSEQUENCE.Text=model.SEQUENCE.ToString();
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtITEM_TYPE.Text=model.ITEM_TYPE;
		this.txtITEM_COLOR.Text=model.ITEM_COLOR;
		this.txtNET_PRICE.Text=model.NET_PRICE.ToString();
		this.txtPRICE.Text=model.PRICE.ToString();
		this.txtQTY.Text=model.QTY.ToString();
		this.txtQUANTITY.Text=model.QUANTITY.ToString();
		this.txtACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.txtYKQUANTITY.Text=model.YKQUANTITY.ToString();
		this.txtPAYAMOUNT.Text=model.PAYAMOUNT.ToString();
		this.txtSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.txtSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.txtPOSITION.Text=model.POSITION;
		this.txtBARCODE.Text=model.BARCODE;
		this.txtREMARK.Text=model.REMARK;
		this.txtDESCRIPTION.Text=model.DESCRIPTION;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNo.Text.Trim().Length==0)
			{
				strErr+="BillNo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSEQUENCE.Text))
			{
				strErr+="SEQUENCE格式错误！\\n";	
			}
			if(this.txtITEM_INTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_ITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_ITEM_CODE不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtACTUAL_QTY.Text))
			{
				strErr+="ACTUAL_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtYKQUANTITY.Text))
			{
				strErr+="YKQUANTITY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPAYAMOUNT.Text))
			{
				strErr+="PAYAMOUNT格式错误！\\n";	
			}
			if(this.txtSUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_NAME.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_NAME不能为空！\\n";	
			}
			if(this.txtPOSITION.Text.Trim().Length==0)
			{
				strErr+="POSITION不能为空！\\n";	
			}
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
			}
			if(this.txtREMARK.Text.Trim().Length==0)
			{
				strErr+="REMARK不能为空！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TempID=int.Parse(this.lblTempID.Text);
			string BillNo=this.txtBillNo.Text;
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string PARENT_ITEM_CODE=this.txtPARENT_ITEM_CODE.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal QTY=decimal.Parse(this.txtQTY.Text);
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			decimal ACTUAL_QTY=decimal.Parse(this.txtACTUAL_QTY.Text);
			decimal YKQUANTITY=decimal.Parse(this.txtYKQUANTITY.Text);
			decimal PAYAMOUNT=decimal.Parse(this.txtPAYAMOUNT.Text);
			string SUPPLY_CODE=this.txtSUPPLY_CODE.Text;
			string SUPPLY_NAME=this.txtSUPPLY_NAME.Text;
			string POSITION=this.txtPOSITION.Text;
			string BARCODE=this.txtBARCODE.Text;
			string REMARK=this.txtREMARK.Text;
			string DESCRIPTION=this.txtDESCRIPTION.Text;


			MyERP.Model.STEEL_RECEIPT_DETAIL model=new MyERP.Model.STEEL_RECEIPT_DETAIL();
			model.TempID=TempID;
			model.BillNo=BillNo;
			model.SEQUENCE=SEQUENCE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.ITEM_TYPE=ITEM_TYPE;
			model.ITEM_COLOR=ITEM_COLOR;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.QTY=QTY;
			model.QUANTITY=QUANTITY;
			model.ACTUAL_QTY=ACTUAL_QTY;
			model.YKQUANTITY=YKQUANTITY;
			model.PAYAMOUNT=PAYAMOUNT;
			model.SUPPLY_CODE=SUPPLY_CODE;
			model.SUPPLY_NAME=SUPPLY_NAME;
			model.POSITION=POSITION;
			model.BARCODE=BARCODE;
			model.REMARK=REMARK;
			model.DESCRIPTION=DESCRIPTION;

			MyERP.BLL.STEEL_RECEIPT_DETAIL bll=new MyERP.BLL.STEEL_RECEIPT_DETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
