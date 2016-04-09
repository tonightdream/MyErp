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
namespace MyERP.Web.ORDER_PCDETAIL
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
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtITEM_COLOR.Text.Trim().Length==0)
			{
				strErr+="ITEM_COLOR不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPARENT_ITEM_CODE.Text))
			{
				strErr+="PARENT_ITEM_CODE格式错误！\\n";	
			}
			if(this.txtITEM_TYPE.Text.Trim().Length==0)
			{
				strErr+="ITEM_TYPE不能为空！\\n";	
			}
			if(this.txtITEM_LOGO.Text.Trim().Length==0)
			{
				strErr+="ITEM_LOGO不能为空！\\n";	
			}
			if(this.txtITEM_DESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="ITEM_DESCRIPTION不能为空！\\n";	
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
			if(this.txtITEM_SPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="ITEM_SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtITEM_MEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="ITEM_MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtITEM_GYLC.Text.Trim().Length==0)
			{
				strErr+="ITEM_GYLC不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_POSITION.Text))
			{
				strErr+="ITEM_POSITION格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_MIN_QTY.Text))
			{
				strErr+="ITEM_MIN_QTY格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_MAX_QTY.Text))
			{
				strErr+="ITEM_MAX_QTY格式错误！\\n";	
			}
			if(this.txtITEM_IMAGE.Text.Trim().Length==0)
			{
				strErr+="ITEM_IMAGE不能为空！\\n";	
			}
			if(this.txtITEM_IMAGE_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_IMAGE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtITEM_DWMJ.Text))
			{
				strErr+="ITEM_DWMJ格式错误！\\n";	
			}
			if(this.txtITEM_BARCODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_BARCODE不能为空！\\n";	
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
			if(this.txtORD_TL.Text.Trim().Length==0)
			{
				strErr+="ORD_TL不能为空！\\n";	
			}
			if(this.txtORD_GRAPHICNO.Text.Trim().Length==0)
			{
				strErr+="ORD_GRAPHICNO不能为空！\\n";	
			}
			if(this.txtORD_SHDH.Text.Trim().Length==0)
			{
				strErr+="ORD_SHDH不能为空！\\n";	
			}
			if(this.txtORD_BZFS.Text.Trim().Length==0)
			{
				strErr+="ORD_BZFS不能为空！\\n";	
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
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_CODE_old=this.txtITEM_CODE_old.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			decimal PARENT_ITEM_CODE=decimal.Parse(this.txtPARENT_ITEM_CODE.Text);
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string ITEM_LOGO=this.txtITEM_LOGO.Text;
			string ITEM_DESCRIPTION=this.txtITEM_DESCRIPTION.Text;
			decimal ITEM_CD=decimal.Parse(this.txtITEM_CD.Text);
			decimal ITEM_KD=decimal.Parse(this.txtITEM_KD.Text);
			decimal ITEM_GD=decimal.Parse(this.txtITEM_GD.Text);
			string ITEM_SPECIFICATIONS=this.txtITEM_SPECIFICATIONS.Text;
			string ITEM_MEASURE_UNIT=this.txtITEM_MEASURE_UNIT.Text;
			string ITEM_GYLC=this.txtITEM_GYLC.Text;
			decimal ITEM_POSITION=decimal.Parse(this.txtITEM_POSITION.Text);
			decimal ITEM_MIN_QTY=decimal.Parse(this.txtITEM_MIN_QTY.Text);
			decimal ITEM_MAX_QTY=decimal.Parse(this.txtITEM_MAX_QTY.Text);
			string ITEM_IMAGE=this.txtITEM_IMAGE.Text;
			string ITEM_IMAGE_NAME=this.txtITEM_IMAGE_NAME.Text;
			decimal ITEM_DWMJ=decimal.Parse(this.txtITEM_DWMJ.Text);
			string ITEM_BARCODE=this.txtITEM_BARCODE.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			int Quantity=int.Parse(this.txtQuantity.Text);
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
			string ORD_TL=this.txtORD_TL.Text;
			string ORD_GRAPHICNO=this.txtORD_GRAPHICNO.Text;
			string ORD_SHDH=this.txtORD_SHDH.Text;
			string ORD_BZFS=this.txtORD_BZFS.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_PCDETAIL model=new MyERP.Model.ORDER_PCDETAIL();
			model.DETAILID=DETAILID;
			model.MASTERID=MASTERID;
			model.BILLNO=BILLNO;
			model.Sequence=Sequence;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_CODE_old=ITEM_CODE_old;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_COLOR=ITEM_COLOR;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.ITEM_TYPE=ITEM_TYPE;
			model.ITEM_LOGO=ITEM_LOGO;
			model.ITEM_DESCRIPTION=ITEM_DESCRIPTION;
			model.ITEM_CD=ITEM_CD;
			model.ITEM_KD=ITEM_KD;
			model.ITEM_GD=ITEM_GD;
			model.ITEM_SPECIFICATIONS=ITEM_SPECIFICATIONS;
			model.ITEM_MEASURE_UNIT=ITEM_MEASURE_UNIT;
			model.ITEM_GYLC=ITEM_GYLC;
			model.ITEM_POSITION=ITEM_POSITION;
			model.ITEM_MIN_QTY=ITEM_MIN_QTY;
			model.ITEM_MAX_QTY=ITEM_MAX_QTY;
			model.ITEM_IMAGE=ITEM_IMAGE;
			model.ITEM_IMAGE_NAME=ITEM_IMAGE_NAME;
			model.ITEM_DWMJ=ITEM_DWMJ;
			model.ITEM_BARCODE=ITEM_BARCODE;
			model.NET_PRICE=NET_PRICE;
			model.PRICE=PRICE;
			model.Quantity=Quantity;
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
			model.ORD_TL=ORD_TL;
			model.ORD_GRAPHICNO=ORD_GRAPHICNO;
			model.ORD_SHDH=ORD_SHDH;
			model.ORD_BZFS=ORD_BZFS;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_PCDETAIL bll=new MyERP.BLL.ORDER_PCDETAIL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
