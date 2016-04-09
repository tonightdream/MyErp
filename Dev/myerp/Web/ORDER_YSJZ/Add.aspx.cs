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
namespace MyERP.Web.ORDER_YSJZ
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFDID.Text.Trim().Length==0)
			{
				strErr+="FDID不能为空！\\n";	
			}
			if(this.txtcustomcode.Text.Trim().Length==0)
			{
				strErr+="customcode不能为空！\\n";	
			}
			if(this.txtcustomname.Text.Trim().Length==0)
			{
				strErr+="customname不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSJJZ.Text))
			{
				strErr+="SJJZ格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQZZK.Text))
			{
				strErr+="QZZK格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQZYS.Text))
			{
				strErr+="QZYS格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtYSJE.Text))
			{
				strErr+="YSJE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtYSWS.Text))
			{
				strErr+="YSWS格式错误！\\n";	
			}
			if(this.txtbegindate.Text.Trim().Length==0)
			{
				strErr+="begindate不能为空！\\n";	
			}
			if(this.txtenddate.Text.Trim().Length==0)
			{
				strErr+="enddate不能为空！\\n";	
			}
			if(this.txtcreatename.Text.Trim().Length==0)
			{
				strErr+="createname不能为空！\\n";	
			}
			if(this.txtcreatedate.Text.Trim().Length==0)
			{
				strErr+="createdate不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string FDID=this.txtFDID.Text;
			string customcode=this.txtcustomcode.Text;
			string customname=this.txtcustomname.Text;
			decimal SJJZ=decimal.Parse(this.txtSJJZ.Text);
			decimal QZZK=decimal.Parse(this.txtQZZK.Text);
			decimal QZYS=decimal.Parse(this.txtQZYS.Text);
			decimal YSJE=decimal.Parse(this.txtYSJE.Text);
			decimal YSWS=decimal.Parse(this.txtYSWS.Text);
			string begindate=this.txtbegindate.Text;
			string enddate=this.txtenddate.Text;
			string createname=this.txtcreatename.Text;
			string createdate=this.txtcreatedate.Text;
			string remark=this.txtremark.Text;

			MyERP.Model.ORDER_YSJZ model=new MyERP.Model.ORDER_YSJZ();
			model.FDID=FDID;
			model.customcode=customcode;
			model.customname=customname;
			model.SJJZ=SJJZ;
			model.QZZK=QZZK;
			model.QZYS=QZYS;
			model.YSJE=YSJE;
			model.YSWS=YSWS;
			model.begindate=begindate;
			model.enddate=enddate;
			model.createname=createname;
			model.createdate=createdate;
			model.remark=remark;

			MyERP.BLL.ORDER_YSJZ bll=new MyERP.BLL.ORDER_YSJZ();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
