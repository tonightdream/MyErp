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
namespace MyERP.Web.PUB_ITEM_DETAIL
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		MyERP.BLL.PUB_ITEM_DETAIL bll=new MyERP.BLL.PUB_ITEM_DETAIL();
		MyERP.Model.PUB_ITEM_DETAIL model=bll.GetModel();
		this.txtSEQUENCE.Text=model.SEQUENCE.ToString();
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtITEM_COLOR.Text=model.ITEM_COLOR;
		this.txtPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.txtITEM_TYPE.Text=model.ITEM_TYPE;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.txtDESCRIPTION.Text=model.DESCRIPTION;
		this.txtITEM_LH.Text=model.ITEM_LH.ToString();
		this.txtITEM_LK.Text=model.ITEM_LK.ToString();
		this.txtITEM_BJ.Text=model.ITEM_BJ.ToString();
		this.txtITEM_JZ.Text=model.ITEM_JZ.ToString();
		this.txtITEM_HZ.Text=model.ITEM_HZ.ToString();
		this.txtITEM_rate.Text=model.ITEM_rate;
		this.txtITEM_GYLC.Text=model.ITEM_GYLC;
		this.txtNET_PRICE.Text=model.NET_PRICE.ToString();
		this.txtPRICE.Text=model.PRICE.ToString();
		this.txtQuantity.Text=model.Quantity.ToString();
		this.txtBARCODE.Text=model.BARCODE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtDESCRIPTION.Text.Trim().Length==0)
			{
				strErr+="DESCRIPTION不能为空！\\n";	
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
			if(this.txtBARCODE.Text.Trim().Length==0)
			{
				strErr+="BARCODE不能为空！\\n";	
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
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_CODE_old=this.txtITEM_CODE_old.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string ITEM_COLOR=this.txtITEM_COLOR.Text;
			string PARENT_ITEM_CODE=this.txtPARENT_ITEM_CODE.Text;
			string ITEM_TYPE=this.txtITEM_TYPE.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string DESCRIPTION=this.txtDESCRIPTION.Text;
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
			string BARCODE=this.txtBARCODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_ITEM_DETAIL model=new MyERP.Model.PUB_ITEM_DETAIL();
			model.SEQUENCE=SEQUENCE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_CODE_old=ITEM_CODE_old;
			model.ITEM_NAME=ITEM_NAME;
			model.ITEM_COLOR=ITEM_COLOR;
			model.PARENT_ITEM_CODE=PARENT_ITEM_CODE;
			model.ITEM_TYPE=ITEM_TYPE;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.DESCRIPTION=DESCRIPTION;
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
			model.BARCODE=BARCODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_ITEM_DETAIL bll=new MyERP.BLL.PUB_ITEM_DETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
