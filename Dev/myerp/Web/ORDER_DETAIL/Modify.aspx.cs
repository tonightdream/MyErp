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
namespace MyERP.Web.ORDER_DETAIL
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string DETAILID= Request.Params["id"];
					ShowInfo(DETAILID);
				}
			}
		}
			
	private void ShowInfo(string DETAILID)
	{
		MyERP.BLL.ORDER_DETAIL bll=new MyERP.BLL.ORDER_DETAIL();
		MyERP.Model.ORDER_DETAIL model=bll.GetModel(DETAILID);
		this.txtMASTERID.Text=model.MASTERID;
		this.lblDETAILID.Text=model.DETAILID;
		this.txtBILLNO.Text=model.BILLNO;
		this.txtSequence.Text=model.Sequence.ToString();
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtITEM_COLOR.Text=model.ITEM_COLOR;
		this.txtPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE.ToString();
		this.txtITEM_TYPE.Text=model.ITEM_TYPE;
		this.txtITEM_LOGO.Text=model.ITEM_LOGO;
		this.txtITEM_CD.Text=model.ITEM_CD.ToString();
		this.txtITEM_KD.Text=model.ITEM_KD.ToString();
		this.txtITEM_GD.Text=model.ITEM_GD.ToString();
		this.txtITEM_GYLC.Text=model.ITEM_GYLC;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtDWMJ.Text=model.DWMJ.ToString();
		this.txtBZFS.Text=model.BZFS;
		this.txtGRAPHICNO.Text=model.GRAPHICNO;
		this.txtDESCRIPTION.Text=model.DESCRIPTION;
		this.txtNET_PRICE.Text=model.NET_PRICE.ToString();
		this.txtPRICE.Text=model.PRICE.ToString();
		this.txtQuantity.Text=model.Quantity.ToString();
		this.txtORD_CGqty.Text=model.ORD_CGqty.ToString();
		this.txtORD_CLqty.Text=model.ORD_CLqty.ToString();
		this.txtORD_PCqty.Text=model.ORD_PCqty.ToString();
		this.txtORD_WGqty.Text=model.ORD_WGqty.ToString();
		this.txtORD_TCqty.Text=model.ORD_TCqty.ToString();
		this.txtORD_WGZL.Text=model.ORD_WGZL.ToString();
		this.txtORD_FPqty.Text=model.ORD_FPqty.ToString();
		this.txtORD_LHqty.Text=model.ORD_LHqty.ToString();
		this.txtORD_Sendqty.Text=model.ORD_Sendqty.ToString();
		this.txtORD_SHqty.Text=model.ORD_SHqty.ToString();
		this.txtORD_HZqty.Text=model.ORD_HZqty.ToString();
		this.txtORD_THqty.Text=model.ORD_THqty.ToString();
		this.txtORD_Acceptqty.Text=model.ORD_Acceptqty.ToString();
		this.txtORD_SHDH.Text=model.ORD_SHDH;
		this.txtORD_TL.Text=model.ORD_TL;
		this.txtPOSITION.Text=model.POSITION.ToString();
		this.txtBARCODE.Text=model.BARCODE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			if(this.txtITEM_GYLC.Text.Trim().Length==0)
			{
				strErr+="ITEM_GYLC不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDWMJ.Text))
			{
				strErr+="DWMJ格式错误！\\n";	
			}
			if(this.txtBZFS.Text.Trim().Length==0)
			{
				strErr+="BZFS不能为空！\\n";	
			}
			if(this.txtGRAPHICNO.Text.Trim().Length==0)
			{
				strErr+="GRAPHICNO不能为空！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtORD_CGqty.Text))
			{
				strErr+="ORD_CGqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_CLqty.Text))
			{
				strErr+="ORD_CLqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_PCqty.Text))
			{
				strErr+="ORD_PCqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_WGqty.Text))
			{
				strErr+="ORD_WGqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_TCqty.Text))
			{
				strErr+="ORD_TCqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_WGZL.Text))
			{
				strErr+="ORD_WGZL格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_FPqty.Text))
			{
				strErr+="ORD_FPqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_LHqty.Text))
			{
				strErr+="ORD_LHqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_Sendqty.Text))
			{
				strErr+="ORD_Sendqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_SHqty.Text))
			{
				strErr+="ORD_SHqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_HZqty.Text))
			{
				strErr+="ORD_HZqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_THqty.Text))
			{
				strErr+="ORD_THqty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtORD_Acceptqty.Text))
			{
				strErr+="ORD_Acceptqty格式错误！\\n";	
			}
			if(this.txtORD_SHDH.Text.Trim().Length==0)
			{
				strErr+="ORD_SHDH不能为空！\\n";	
			}
			if(this.txtORD_TL.Text.Trim().Length==0)
			{
				strErr+="ORD_TL不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPOSITION.Text))
			{
				strErr+="POSITION格式错误！\\n";	
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
			string MASTERID=this.txtMASTERID.Text;
			string DETAILID=this.lblDETAILID.Text;
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
			decimal ITEM_CD=decimal.Parse(this.txtITEM_CD.Text);
			decimal ITEM_KD=decimal.Parse(this.txtITEM_KD.Text);
			decimal ITEM_GD=decimal.Parse(this.txtITEM_GD.Text);
			string ITEM_GYLC=this.txtITEM_GYLC.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			decimal DWMJ=decimal.Parse(this.txtDWMJ.Text);
			string BZFS=this.txtBZFS.Text;
			string GRAPHICNO=this.txtGRAPHICNO.Text;
			string DESCRIPTION=this.txtDESCRIPTION.Text;
			decimal NET_PRICE=decimal.Parse(this.txtNET_PRICE.Text);
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			decimal Quantity=decimal.Parse(this.txtQuantity.Text);
			decimal ORD_CGqty=decimal.Parse(this.txtORD_CGqty.Text);
			decimal ORD_CLqty=decimal.Parse(this.txtORD_CLqty.Text);
			decimal ORD_PCqty=decimal.Parse(this.txtORD_PCqty.Text);
			decimal ORD_WGqty=decimal.Parse(this.txtORD_WGqty.Text);
			decimal ORD_TCqty=decimal.Parse(this.txtORD_TCqty.Text);
			decimal ORD_WGZL=decimal.Parse(this.txtORD_WGZL.Text);
			decimal ORD_FPqty=decimal.Parse(this.txtORD_FPqty.Text);
			decimal ORD_LHqty=decimal.Parse(this.txtORD_LHqty.Text);
			decimal ORD_Sendqty=decimal.Parse(this.txtORD_Sendqty.Text);
			decimal ORD_SHqty=decimal.Parse(this.txtORD_SHqty.Text);
			decimal ORD_HZqty=decimal.Parse(this.txtORD_HZqty.Text);
			decimal ORD_THqty=decimal.Parse(this.txtORD_THqty.Text);
			decimal ORD_Acceptqty=decimal.Parse(this.txtORD_Acceptqty.Text);
			string ORD_SHDH=this.txtORD_SHDH.Text;
			string ORD_TL=this.txtORD_TL.Text;
			decimal POSITION=decimal.Parse(this.txtPOSITION.Text);
			string BARCODE=this.txtBARCODE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_DETAIL model=new MyERP.Model.ORDER_DETAIL();
			model.MASTERID=MASTERID;
			model.DETAILID=DETAILID;
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
			model.ITEM_CD=ITEM_CD;
			model.ITEM_KD=ITEM_KD;
			model.ITEM_GD=ITEM_GD;
			model.ITEM_GYLC=ITEM_GYLC;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.DWMJ=DWMJ;
			model.BZFS=BZFS;
			model.GRAPHICNO=GRAPHICNO;
			model.DESCRIPTION=DESCRIPTION;
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
			model.ORD_LHqty=ORD_LHqty;
			model.ORD_Sendqty=ORD_Sendqty;
			model.ORD_SHqty=ORD_SHqty;
			model.ORD_HZqty=ORD_HZqty;
			model.ORD_THqty=ORD_THqty;
			model.ORD_Acceptqty=ORD_Acceptqty;
			model.ORD_SHDH=ORD_SHDH;
			model.ORD_TL=ORD_TL;
			model.POSITION=POSITION;
			model.BARCODE=BARCODE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_DETAIL bll=new MyERP.BLL.ORDER_DETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
