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
namespace MyERP.Web.PUR_PURCHASE_DETAIL
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDETAILID.Text.Trim().Length==0)
			{
				strErr+="DETAILID不能为空！\\n";	
			}
			if(this.txtMASTERID.Text.Trim().Length==0)
			{
				strErr+="MASTERID不能为空！\\n";	
			}
			if(this.txtBILLNO.Text.Trim().Length==0)
			{
				strErr+="BILLNO不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSequence.Text))
			{
				strErr+="Sequence格式错误！\\n";	
			}
			if(this.txtSUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_NAME.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_NAME不能为空！\\n";	
			}
			if(this.txtITEM_INTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE_old.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE_old不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPARENT_ITEM_CODE.Text))
			{
				strErr+="PARENT_ITEM_CODE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_CD.Text))
			{
				strErr+="ITEM_CD格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_KD.Text))
			{
				strErr+="ITEM_KD格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_GD.Text))
			{
				strErr+="ITEM_GD格式错误！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtCOLOR.Text.Trim().Length==0)
			{
				strErr+="COLOR不能为空！\\n";	
			}
			if(this.txtIMAGE.Text.Trim().Length==0)
			{
				strErr+="IMAGE不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDWMJ.Text))
			{
				strErr+="DWMJ格式错误！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
			}
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNET_PRICE.Text))
			{
				strErr+="NET_PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPAYAMOUNT.Text))
			{
				strErr+="PAYAMOUNT格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTAX_RATE.Text))
			{
				strErr+="TAX_RATE格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_CGqty.Text))
			{
				strErr+="ORD_CGqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_CLqty.Text))
			{
				strErr+="ORD_CLqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_PCqty.Text))
			{
				strErr+="ORD_PCqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_WGqty.Text))
			{
				strErr+="ORD_WGqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_TCqty.Text))
			{
				strErr+="ORD_TCqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_WGZL.Text))
			{
				strErr+="ORD_WGZL格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_FPqty.Text))
			{
				strErr+="ORD_FPqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_Sendqty.Text))
			{
				strErr+="ORD_Sendqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_SHqty.Text))
			{
				strErr+="ORD_SHqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_LHqty.Text))
			{
				strErr+="ORD_LHqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_HZqty.Text))
			{
				strErr+="ORD_HZqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_THqty.Text))
			{
				strErr+="ORD_THqty格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtORD_Acceptqty.Text))
			{
				strErr+="ORD_Acceptqty格式错误！\\n";	
			}
			if(this.txtORD_SHDH.Text.Trim().Length==0)
			{
				strErr+="ORD_SHDH不能为空！\\n";	
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
			string DETAILID=this.txtDETAILID.Text;
			string MASTERID=this.txtMASTERID.Text;
			string BILLNO=this.txtBILLNO.Text;
			int Sequence=int.Parse(this.txtSequence.Text);
			string SUPPLY_CODE=this.txtSUPPLY_CODE.Text;
			string SUPPLY_NAME=this.txtSUPPLY_NAME.Text;
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_CODE_old=this.txtITEM_CODE_old.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			decimal PARENT_ITEM_CODE=decimal.Parse(this.txtPARENT_ITEM_CODE.Text);
			decimal ITEM_CD=decimal.Parse(this.txtITEM_CD.Text);
			decimal ITEM_KD=decimal.Parse(this.txtITEM_KD.Text);
			decimal ITEM_GD=decimal.Parse(this.txtITEM_GD.Text);
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string COLOR=this.txtCOLOR.Text;
			string IMAGE=this.txtIMAGE.Text;
			decimal DWMJ=decimal.Parse(this.txtDWMJ.Text);
			string DESCRIPTION=this.txtDESCRIPTION.Text;
			string BARCODE=this.txtBARCODE.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			int Quantity=int.Parse(this.txtQuantity.Text);
			decimal PAYAMOUNT=decimal.Parse(this.txtPAYAMOUNT.Text);
			decimal TAX_RATE=decimal.Parse(this.txtTAX_RATE.Text);
			int ORD_CGqty=int.Parse(this.txtORD_CGqty.Text);
			int ORD_CLqty=int.Parse(this.txtORD_CLqty.Text);
			int ORD_PCqty=int.Parse(this.txtORD_PCqty.Text);
			int ORD_WGqty=int.Parse(this.txtORD_WGqty.Text);
			int ORD_TCqty=int.Parse(this.txtORD_TCqty.Text);
			int ORD_WGZL=int.Parse(this.txtORD_WGZL.Text);
			int ORD_FPqty=int.Parse(this.txtORD_FPqty.Text);
			int ORD_Sendqty=int.Parse(this.txtORD_Sendqty.Text);
			int ORD_SHqty=int.Parse(this.txtORD_SHqty.Text);
			int ORD_LHqty=int.Parse(this.txtORD_LHqty.Text);
			int ORD_HZqty=int.Parse(this.txtORD_HZqty.Text);
			int ORD_THqty=int.Parse(this.txtORD_THqty.Text);
			int ORD_Acceptqty=int.Parse(this.txtORD_Acceptqty.Text);
			string ORD_SHDH=this.txtORD_SHDH.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUR_PURCHASE_DETAIL model=new MyERP.Model.PUR_PURCHASE_DETAIL();
			model.DETAILID=DETAILID;
			model.MASTERID=MASTERID;
			model.BILLNO=BILLNO;
			model.Sequence=Sequence;
			model.SUPPLY_CODE=SUPPLY_CODE;
			model.SUPPLY_NAME=SUPPLY_NAME;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_CODE_old=ITEM_CODE_old;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.ITEM_CD=ITEM_CD;
			model.ITEM_KD=ITEM_KD;
			model.ITEM_GD=ITEM_GD;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_TYPE=ITEM_TYPE;
			model.COLOR=COLOR;
			model.IMAGE=IMAGE;
			model.DWMJ=DWMJ;
			model.DESCRIPTION=DESCRIPTION;
			model.BARCODE=BARCODE;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.Quantity=Quantity;
			model.PAYAMOUNT=PAYAMOUNT;
			model.TAX_RATE=TAX_RATE;
			model.ORD_CGqty=ORD_CGqty;
			model.ORD_CLqty=ORD_CLqty;
			model.ORD_PCqty=ORD_PCqty;
			model.ORD_WGqty=ORD_WGqty;
			model.ORD_TCqty=ORD_TCqty;
			model.ORD_WGZL=ORD_WGZL;
			model.ORD_FPqty=ORD_FPqty;
			model.ORD_Sendqty=ORD_Sendqty;
			model.ORD_SHqty=ORD_SHqty;
			model.ORD_LHqty=ORD_LHqty;
			model.ORD_HZqty=ORD_HZqty;
			model.ORD_THqty=ORD_THqty;
			model.ORD_Acceptqty=ORD_Acceptqty;
			model.ORD_SHDH=ORD_SHDH;
			model.REMARK=REMARK;

			MyERP.BLL.PUR_PURCHASE_DETAIL bll=new MyERP.BLL.PUR_PURCHASE_DETAIL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
