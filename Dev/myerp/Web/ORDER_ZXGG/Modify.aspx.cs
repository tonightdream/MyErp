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
namespace MyERP.Web.ORDER_ZXGG
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
		MyERP.BLL.ORDER_ZXGG bll=new MyERP.BLL.ORDER_ZXGG();
		MyERP.Model.ORDER_ZXGG model=bll.GetModel();
		this.txtINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.txtCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.txtZXXXCode.Text=model.ZXXXCode;
		this.txtZXXXName.Text=model.ZXXXName;
		this.txtZXKDGS.Text=model.ZXKDGS;
		this.txtZXLENGS.Text=model.ZXLENGS;
		this.txtZXZK.Text=model.ZXZK.ToString();
		this.txtZXDT.Text=model.ZXDT.ToString();
		this.txtZXZBSL.Text=model.ZXZBSL.ToString();
		this.txtZXYZBJ.Text=model.ZXYZBJ;
		this.txtZXGZBJ.Text=model.ZXGZBJ;
		this.txtZXIMAGE.Text=model.ZXIMAGE.ToString();
		this.txtZXZK_cm.Text=model.ZXZK_cm.ToString();
		this.txtZXDT_cm.Text=model.ZXDT_cm.ToString();
		this.txtZXYxgs.Text=model.ZXYxgs;
		this.txtZXYXGD.Text=model.ZXYXGD;
		this.txtIMAGE_NAME.Text=model.IMAGE_NAME;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtINTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtZXXXCode.Text.Trim().Length==0)
			{
				strErr+="ZXXXCode不能为空！\\n";	
			}
			if(this.txtZXXXName.Text.Trim().Length==0)
			{
				strErr+="ZXXXName不能为空！\\n";	
			}
			if(this.txtZXKDGS.Text.Trim().Length==0)
			{
				strErr+="ZXKDGS不能为空！\\n";	
			}
			if(this.txtZXLENGS.Text.Trim().Length==0)
			{
				strErr+="ZXLENGS不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtZXZK.Text))
			{
				strErr+="ZXZK格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtZXDT.Text))
			{
				strErr+="ZXDT格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtZXZBSL.Text))
			{
				strErr+="ZXZBSL格式错误！\\n";	
			}
			if(this.txtZXYZBJ.Text.Trim().Length==0)
			{
				strErr+="ZXYZBJ不能为空！\\n";	
			}
			if(this.txtZXGZBJ.Text.Trim().Length==0)
			{
				strErr+="ZXGZBJ不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtZXZK_cm.Text))
			{
				strErr+="ZXZK_cm格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtZXDT_cm.Text))
			{
				strErr+="ZXDT_cm格式错误！\\n";	
			}
			if(this.txtZXYxgs.Text.Trim().Length==0)
			{
				strErr+="ZXYxgs不能为空！\\n";	
			}
			if(this.txtZXYXGD.Text.Trim().Length==0)
			{
				strErr+="ZXYXGD不能为空！\\n";	
			}
			if(this.txtIMAGE_NAME.Text.Trim().Length==0)
			{
				strErr+="IMAGE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
			}
			if(this.txtUPDATE_DATE.Text.Trim().Length==0)
			{
				strErr+="UPDATE_DATE不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string ZXXXCode=this.txtZXXXCode.Text;
			string ZXXXName=this.txtZXXXName.Text;
			string ZXKDGS=this.txtZXKDGS.Text;
			string ZXLENGS=this.txtZXLENGS.Text;
			decimal ZXZK=decimal.Parse(this.txtZXZK.Text);
			decimal ZXDT=decimal.Parse(this.txtZXDT.Text);
			int ZXZBSL=int.Parse(this.txtZXZBSL.Text);
			string ZXYZBJ=this.txtZXYZBJ.Text;
			string ZXGZBJ=this.txtZXGZBJ.Text;
			byte[] ZXIMAGE= new UnicodeEncoding().GetBytes(this.txtZXIMAGE.Text);
			decimal ZXZK_cm=decimal.Parse(this.txtZXZK_cm.Text);
			decimal ZXDT_cm=decimal.Parse(this.txtZXDT_cm.Text);
			string ZXYxgs=this.txtZXYxgs.Text;
			string ZXYXGD=this.txtZXYXGD.Text;
			string IMAGE_NAME=this.txtIMAGE_NAME.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string UPDATE_DATE=this.txtUPDATE_DATE.Text;


			MyERP.Model.ORDER_ZXGG model=new MyERP.Model.ORDER_ZXGG();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.ZXXXCode=ZXXXCode;
			model.ZXXXName=ZXXXName;
			model.ZXKDGS=ZXKDGS;
			model.ZXLENGS=ZXLENGS;
			model.ZXZK=ZXZK;
			model.ZXDT=ZXDT;
			model.ZXZBSL=ZXZBSL;
			model.ZXYZBJ=ZXYZBJ;
			model.ZXGZBJ=ZXGZBJ;
			model.ZXIMAGE=ZXIMAGE;
			model.ZXZK_cm=ZXZK_cm;
			model.ZXDT_cm=ZXDT_cm;
			model.ZXYxgs=ZXYxgs;
			model.ZXYXGD=ZXYXGD;
			model.IMAGE_NAME=IMAGE_NAME;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;

			MyERP.BLL.ORDER_ZXGG bll=new MyERP.BLL.ORDER_ZXGG();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
