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
namespace MyERP.Web.VEHICLE_ORD_DETAIL
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNo.Text.Trim().Length==0)
			{
				strErr+="BillNo不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtSALES_CONTRACTNO.Text.Trim().Length==0)
			{
				strErr+="SALES_CONTRACTNO不能为空！\\n";	
			}
			if(this.txtTRUCKER.Text.Trim().Length==0)
			{
				strErr+="TRUCKER不能为空！\\n";	
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
			string BillNo=this.txtBillNo.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string SALES_CONTRACTNO=this.txtSALES_CONTRACTNO.Text;
			string TRUCKER=this.txtTRUCKER.Text;
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

			MyERP.Model.VEHICLE_ORD_DETAIL model=new MyERP.Model.VEHICLE_ORD_DETAIL();
			model.BillNo=BillNo;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.SALES_CONTRACTNO=SALES_CONTRACTNO;
			model.TRUCKER=TRUCKER;
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

			MyERP.BLL.VEHICLE_ORD_DETAIL bll=new MyERP.BLL.VEHICLE_ORD_DETAIL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
