﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using MyERP.Model;
namespace MyERP.BLL
{
	/// <summary>
	/// SAL_RECEIPT_MASTER
	/// </summary>
	public partial class SAL_RECEIPT_MASTER
	{
		private readonly MyERP.DAL.SAL_RECEIPT_MASTER dal=new MyERP.DAL.SAL_RECEIPT_MASTER();
		public SAL_RECEIPT_MASTER()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BillNO)
		{
			return dal.Exists(BillNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SAL_RECEIPT_MASTER model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyERP.Model.SAL_RECEIPT_MASTER model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string BillNO)
		{
			
			return dal.Delete(BillNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string BillNOlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(BillNOlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyERP.Model.SAL_RECEIPT_MASTER GetModel(string BillNO)
		{
			
			return dal.GetModel(BillNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public MyERP.Model.SAL_RECEIPT_MASTER GetModelByCache(string BillNO)
		{
			
			string CacheKey = "SAL_RECEIPT_MASTERModel-" + BillNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(BillNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (MyERP.Model.SAL_RECEIPT_MASTER)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyERP.Model.SAL_RECEIPT_MASTER> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyERP.Model.SAL_RECEIPT_MASTER> DataTableToList(DataTable dt)
		{
			List<MyERP.Model.SAL_RECEIPT_MASTER> modelList = new List<MyERP.Model.SAL_RECEIPT_MASTER>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MyERP.Model.SAL_RECEIPT_MASTER model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

