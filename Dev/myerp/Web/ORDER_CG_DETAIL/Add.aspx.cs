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
namespace MyERP.Web.ORDER_CG_DETAIL
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
			if(this.txtMASTERID.Text.Trim().Length==0)
			{
				strErr+="MASTERID不能为空！\\n";	
			}
			if(this.txtDETAILID.Text.Trim().Length==0)
			{
				strErr+="DETAILID不能为空！\\n";	
			}
			if(this.txtBILLNO.Text.Trim().Length==0)
			{
				strErr+="BILLNO不能为空！\\n";	
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
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtITEM_CZ.Text.Trim().Length==0)
			{
				strErr+="ITEM_CZ不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_LH.Text))
			{
				strErr+="ITEM_LH格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_LK.Text))
			{
				strErr+="ITEM_LK格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_BJ.Text))
			{
				strErr+="ITEM_BJ格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_JZ.Text))
			{
				strErr+="ITEM_JZ格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_HZ.Text))
			{
				strErr+="ITEM_HZ格式错误！\\n";	
			}
			if(this.txtITEM_rate.Text.Trim().Length==0)
			{
				strErr+="ITEM_rate不能为空！\\n";	
			}
			if(this.txtITEM_GYLC.Text.Trim().Length==0)
			{
				strErr+="ITEM_GYLC不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNET_PRICE.Text))
			{
				strErr+="NET_PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttotal_quantity.Text))
			{
				strErr+="total_quantity格式错误！\\n";	
			}
			if(this.txtORD_TL.Text.Trim().Length==0)
			{
				strErr+="ORD_TL不能为空！\\n";	
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
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string MASTERID=this.txtMASTERID.Text;
			string DETAILID=this.txtDETAILID.Text;
			string BILLNO=this.txtBILLNO.Text;
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string ITEM_CZ=this.txtITEM_CZ.Text;
			decimal ITEM_LH=decimal.Parse(this.txtITEM_LH.Text);
			decimal ITEM_LK=decimal.Parse(this.txtITEM_LK.Text);
			decimal ITEM_BJ=decimal.Parse(this.txtITEM_BJ.Text);
			decimal ITEM_JZ=decimal.Parse(this.txtITEM_JZ.Text);
			decimal ITEM_HZ=decimal.Parse(this.txtITEM_HZ.Text);
			string ITEM_rate=this.txtITEM_rate.Text;
			string ITEM_GYLC=this.txtITEM_GYLC.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal Quantity=decimal.Parse(this.txtQuantity.Text);
			decimal total_quantity=decimal.Parse(this.txttotal_quantity.Text);
			string ORD_TL=this.txtORD_TL.Text;
			string BARCODE=this.txtBARCODE.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_CG_DETAIL model=new MyERP.Model.ORDER_CG_DETAIL();
			model.SEQUENCE=SEQUENCE;
			model.MASTERID=MASTERID;
			model.DETAILID=DETAILID;
			model.BILLNO=BILLNO;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_COLOR=ITEM_COLOR;
			model.ITEM_TYPE=ITEM_TYPE;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.ITEM_CZ=ITEM_CZ;
			model.ITEM_LH=ITEM_LH;
			model.ITEM_LK=ITEM_LK;
			model.ITEM_BJ=ITEM_BJ;
			model.ITEM_JZ=ITEM_JZ;
			model.ITEM_HZ=ITEM_HZ;
			model.ITEM_rate=ITEM_rate;
			model.ITEM_GYLC=ITEM_GYLC;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.Quantity=Quantity;
			model.total_quantity=total_quantity;
			model.ORD_TL=ORD_TL;
			model.BARCODE=BARCODE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_CG_DETAIL bll=new MyERP.BLL.ORDER_CG_DETAIL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
