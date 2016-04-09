﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using MyERP.Model;
namespace MyERP.BLL
{
	/// <summary>
	/// PUB_PAYMENT_TYPE
	/// </summary>
	public partial class PUB_PAYMENT_TYPE
	{
		private readonly MyERP.DAL.PUB_PAYMENT_TYPE dal=new MyERP.DAL.PUB_PAYMENT_TYPE();
		public PUB_PAYMENT_TYPE()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PAYMENT_CODE)
		{
			return dal.Exists(PAYMENT_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_PAYMENT_TYPE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyERP.Model.PUB_PAYMENT_TYPE model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string PAYMENT_CODE)
		{
			
			return dal.Delete(PAYMENT_CODE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PAYMENT_CODElist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(PAYMENT_CODElist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyERP.Model.PUB_PAYMENT_TYPE GetModel(string PAYMENT_CODE)
		{
			
			return dal.GetModel(PAYMENT_CODE);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public MyERP.Model.PUB_PAYMENT_TYPE GetModelByCache(string PAYMENT_CODE)
		{
			
			string CacheKey = "PUB_PAYMENT_TYPEModel-" + PAYMENT_CODE;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PAYMENT_CODE);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (MyERP.Model.PUB_PAYMENT_TYPE)objModel;
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
		public List<MyERP.Model.PUB_PAYMENT_TYPE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyERP.Model.PUB_PAYMENT_TYPE> DataTableToList(DataTable dt)
		{
			List<MyERP.Model.PUB_PAYMENT_TYPE> modelList = new List<MyERP.Model.PUB_PAYMENT_TYPE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MyERP.Model.PUB_PAYMENT_TYPE model;
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

