﻿using System;
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
namespace MyERP.Web.WL_STOCK_DETAIL
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		MyERP.BLL.WL_STOCK_DETAIL bll=new MyERP.BLL.WL_STOCK_DETAIL();
		MyERP.Model.WL_STOCK_DETAIL model=bll.GetModel();
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();

	}


    }
}
