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
namespace MyERP.Web.WL_RECEIPT_DETAIL
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
		MyERP.BLL.WL_RECEIPT_DETAIL bll=new MyERP.BLL.WL_RECEIPT_DETAIL();
		MyERP.Model.WL_RECEIPT_DETAIL model=bll.GetModel(TempID);
		this.lblTempID.Text=model.TempID.ToString();
		this.txtBillNO.Text=model.BillNO;
		this.txtSEQUENCE.Text=model.SEQUENCE.ToString();
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.txtITEM_TYPE.Text=model.ITEM_TYPE;
		this.txtITEM_COLOR.Text=model.ITEM_COLOR;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtNET_PRICE.Text=model.NET_PRICE.ToString();
		this.txtPRICE.Text=model.PRICE.ToString();
		this.txtACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.txtQUANTITY.Text=model.QUANTITY.ToString();
		this.txtYKQUANTITY.Text=model.YKQUANTITY.ToString();
		this.txtPAYAMOUNT.Text=model.PAYAMOUNT.ToString();
		this.txtNET_PAYAMOUNT.Text=model.NET_PAYAMOUNT.ToString();
		this.txtBARCODE.Text=model.BARCODE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNO.Text.Trim().Length==0)
			{
				strErr+="BillNO不能为空！\\n";	
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
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtACTUAL_QTY.Text))
			{
				strErr+="ACTUAL_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtYKQUANTITY.Text))
			{
				strErr+="YKQUANTITY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPAYAMOUNT.Text))
			{
				strErr+="PAYAMOUNT格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNET_PAYAMOUNT.Text))
			{
				strErr+="NET_PAYAMOUNT格式错误！\\n";	
			}
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
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
			int TempID=int.Parse(this.lblTempID.Text);
			string BillNO=this.txtBillNO.Text;
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string PARENT_ITEM_CODE=this.txtPARENT_ITEM_CODE.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal ACTUAL_QTY=decimal.Parse(this.txtACTUAL_QTY.Text);
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			decimal YKQUANTITY=decimal.Parse(this.txtYKQUANTITY.Text);
			decimal PAYAMOUNT=decimal.Parse(this.txtPAYAMOUNT.Text);
			decimal NET_PAYAMOUNT=decimal.Parse(this.txtNET_PAYAMOUNT.Text);
			string BARCODE=this.txtBARCODE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.WL_RECEIPT_DETAIL model=new MyERP.Model.WL_RECEIPT_DETAIL();
			model.TempID=TempID;
			model.BillNO=BillNO;
			model.SEQUENCE=SEQUENCE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.ITEM_TYPE=ITEM_TYPE;
			model.ITEM_COLOR=ITEM_COLOR;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.ACTUAL_QTY=ACTUAL_QTY;
			model.QUANTITY=QUANTITY;
			model.YKQUANTITY=YKQUANTITY;
			model.PAYAMOUNT=PAYAMOUNT;
			model.NET_PAYAMOUNT=NET_PAYAMOUNT;
			model.BARCODE=BARCODE;
			model.REMARK=REMARK;

			MyERP.BLL.WL_RECEIPT_DETAIL bll=new MyERP.BLL.WL_RECEIPT_DETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
