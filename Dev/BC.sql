/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2015-07-08 17:46:46                          */
/*==============================================================*/


if exists (select 1
          from sysobjects
          where  id = object_id('dbo.PUB_ITEM_LIST_SYNCHRONOUS_SAL_ITEM_STOCK_DETAIL')
          and type in ('P','PC'))
   drop procedure dbo.PUB_ITEM_LIST_SYNCHRONOUS_SAL_ITEM_STOCK_DETAIL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_BILL_INSERT_RECORD')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_BILL_INSERT_RECORD
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_COPY_RECEIPT')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_COPY_RECEIPT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_ITEM_TONGBU')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_ITEM_TONGBU
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_JXC')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_JXC
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_JXC_BEGIN')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_JXC_BEGIN
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_JXC_STOCK_DETAIL_BEGIN888')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_JXC_STOCK_DETAIL_BEGIN888
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_PD_IMPORT')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_PD_IMPORT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_RECEIPT_REPORT')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_RECEIPT_REPORT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_CL_SCAN_BARCODE')
          and type in ('P','PC'))
   drop procedure dbo.SP_CL_SCAN_BARCODE
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_LAST_DATE')
          and type in ('P','PC'))
   drop procedure dbo.SP_LAST_DATE
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_ORDER_CG_DETAIL')
          and type in ('P','PC'))
   drop procedure dbo.SP_ORDER_CG_DETAIL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_ORD_BOM')
          and type in ('P','PC'))
   drop procedure dbo.SP_ORD_BOM
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_ORD_BOM_TOTAL')
          and type in ('P','PC'))
   drop procedure dbo.SP_ORD_BOM_TOTAL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_ORD_CLEAR')
          and type in ('P','PC'))
   drop procedure dbo.SP_ORD_CLEAR
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_ORD_TONGBU')
          and type in ('P','PC'))
   drop procedure dbo.SP_ORD_TONGBU
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_RECEIPT_DELETE')
          and type in ('P','PC'))
   drop procedure dbo.SP_RECEIPT_DELETE
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_RECEIPT_INSERT')
          and type in ('P','PC'))
   drop procedure dbo.SP_RECEIPT_INSERT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_RECEIPT_SELECT')
          and type in ('P','PC'))
   drop procedure dbo.SP_RECEIPT_SELECT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_RECEIPT_UPDATE')
          and type in ('P','PC'))
   drop procedure dbo.SP_RECEIPT_UPDATE
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_CHART')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_CHART
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_DAY_TOTAL')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_DAY_TOTAL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_DB_DETAIL')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_DB_DETAIL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_IMPORT_PD')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_IMPORT_PD
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_IMPORT_PD_bak')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_IMPORT_PD_bak
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_ITEM_TONGBU')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_ITEM_TONGBU
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_JXC')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_JXC
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_JXC_STOCK_DETAIL_BEGIN')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_JXC_STOCK_DETAIL_BEGIN
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_RECEIPT_REPORT')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_RECEIPT_REPORT
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_ROW')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_ROW
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SAL_SCAN_BARCODE')
          and type in ('P','PC'))
   drop procedure dbo.SP_SAL_SCAN_BARCODE
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_STEEL_DA_BEGIN')
          and type in ('P','PC'))
   drop procedure dbo.SP_STEEL_DA_BEGIN
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_STEEL_JXC')
          and type in ('P','PC'))
   drop procedure dbo.SP_STEEL_JXC
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_STEEL_TONGBU')
          and type in ('P','PC'))
   drop procedure dbo.SP_STEEL_TONGBU
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_SYS_DATA_CLEAR')
          and type in ('P','PC'))
   drop procedure dbo.SP_SYS_DATA_CLEAR
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_WL_DA_SYNCHRONOUS')
          and type in ('P','PC'))
   drop procedure dbo.SP_WL_DA_SYNCHRONOUS
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_WL_DA_SYNCHRONOUS_WL_STOCK_DETAIL')
          and type in ('P','PC'))
   drop procedure dbo.SP_WL_DA_SYNCHRONOUS_WL_STOCK_DETAIL
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_WL_DA_TONGBU')
          and type in ('P','PC'))
   drop procedure dbo.SP_WL_DA_TONGBU
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_WL_JXC')
          and type in ('P','PC'))
   drop procedure dbo.SP_WL_JXC
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.SP_WL_JXC_BEGIN')
          and type in ('P','PC'))
   drop procedure dbo.SP_WL_JXC_BEGIN
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_addtosourcecontrol')
          and type in ('P','PC'))
   drop procedure dbo.dt_addtosourcecontrol
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_addtosourcecontrol_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_addtosourcecontrol_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_adduserobject')
          and type in ('P','PC'))
   drop procedure dbo.dt_adduserobject
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_adduserobject_vcs')
          and type in ('P','PC'))
   drop procedure dbo.dt_adduserobject_vcs
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_checkinobject')
          and type in ('P','PC'))
   drop procedure dbo.dt_checkinobject
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_checkinobject_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_checkinobject_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_checkoutobject')
          and type in ('P','PC'))
   drop procedure dbo.dt_checkoutobject
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_checkoutobject_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_checkoutobject_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_isundersourcecontrol')
          and type in ('P','PC'))
   drop procedure dbo.dt_isundersourcecontrol
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_validateloginparams')
          and type in ('P','PC'))
   drop procedure dbo.dt_validateloginparams
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_whocheckedout')
          and type in ('P','PC'))
   drop procedure dbo.dt_whocheckedout
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_displayoaerror')
          and type in ('P','PC'))
   drop procedure dbo.dt_displayoaerror
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_isundersourcecontrol_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_isundersourcecontrol_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_validateloginparams_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_validateloginparams_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_whocheckedout_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_whocheckedout_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_displayoaerror_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_displayoaerror_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_removefromsourcecontrol')
          and type in ('P','PC'))
   drop procedure dbo.dt_removefromsourcecontrol
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_droppropertiesbyid')
          and type in ('P','PC'))
   drop procedure dbo.dt_droppropertiesbyid
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_dropuserobjectbyid')
          and type in ('P','PC'))
   drop procedure dbo.dt_dropuserobjectbyid
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_setpropertybyid_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_setpropertybyid_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_generateansiname')
          and type in ('P','PC'))
   drop procedure dbo.dt_generateansiname
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getobjwithprop')
          and type in ('P','PC'))
   drop procedure dbo.dt_getobjwithprop
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getobjwithprop_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_getobjwithprop_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getpropertiesbyid')
          and type in ('P','PC'))
   drop procedure dbo.dt_getpropertiesbyid
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getpropertiesbyid_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_getpropertiesbyid_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getpropertiesbyid_vcs')
          and type in ('P','PC'))
   drop procedure dbo.dt_getpropertiesbyid_vcs
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_getpropertiesbyid_vcs_u')
          and type in ('P','PC'))
   drop procedure dbo.dt_getpropertiesbyid_vcs_u
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_setpropertybyid')
          and type in ('P','PC'))
   drop procedure dbo.dt_setpropertybyid
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_vcsenabled')
          and type in ('P','PC'))
   drop procedure dbo.dt_vcsenabled
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.dt_verstamp006')
          and type in ('P','PC'))
   drop procedure dbo.dt_verstamp006
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.lwj')
          and type in ('P','PC'))
   drop procedure dbo.lwj
go

if exists (select 1
          from sysobjects
          where  id = object_id('dbo.p_createjob')
          and type in ('P','PC'))
   drop procedure dbo.p_createjob
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.CL_RECEIPT_DETAIL') and o.name = 'FK_BILLNO')
alter table dbo.CL_RECEIPT_DETAIL
   drop constraint FK_BILLNO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_BOM') and o.name = 'FK_ORDER_BOM_ORDER_DETAIL')
alter table dbo.ORD_BOM
   drop constraint FK_ORDER_BOM_ORDER_DETAIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_CG_DETAIL') and o.name = 'FK_ORDER_CG_DETAIL_ORDER_CG_MASTER1')
alter table dbo.ORD_CG_DETAIL
   drop constraint FK_ORDER_CG_DETAIL_ORDER_CG_MASTER1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_DETAIL') and o.name = 'FK_ORDER_DETAIL_ORDER_MASTER')
alter table dbo.ORD_DETAIL
   drop constraint FK_ORDER_DETAIL_ORDER_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_ITEM_DA_BOM') and o.name = 'FK_PUB_ITEM_DA_BOM_PUB_ITEM_DA')
alter table dbo.ORD_ITEM_DA_BOM
   drop constraint FK_PUB_ITEM_DA_BOM_PUB_ITEM_DA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_PCDETAIL') and o.name = 'FK_ORDER_PCDETAIL_ORDER_PCMASTER')
alter table dbo.ORD_PCDETAIL
   drop constraint FK_ORDER_PCDETAIL_ORDER_PCMASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_PURCHASE_DETAIL') and o.name = 'FK_PUR_PURCHASE_DETAIL_PUR_PURCHASE_MASTER1')
alter table dbo.ORD_PURCHASE_DETAIL
   drop constraint FK_PUR_PURCHASE_DETAIL_PUR_PURCHASE_MASTER1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_SEND_DETAIL') and o.name = 'FK_ORDER_SEND_DETAIL_ORDER_SEND_MASTER')
alter table dbo.ORD_SEND_DETAIL
   drop constraint FK_ORDER_SEND_DETAIL_ORDER_SEND_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_SEND_REMARK') and o.name = 'FK_ORDER_SEND_REMARK_ORDER_SEND_MASTER')
alter table dbo.ORD_SEND_REMARK
   drop constraint FK_ORDER_SEND_REMARK_ORDER_SEND_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.ORD_VEHICLE_DETAIL') and o.name = 'FK_VEHICLE_ORD_DETAIL_VEHICLE_ORD_MASTER')
alter table dbo.ORD_VEHICLE_DETAIL
   drop constraint FK_VEHICLE_ORD_DETAIL_VEHICLE_ORD_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.PUB_ITEM_DETAIL') and o.name = 'FK_PUB_ITEM_DETAIL_INTERNAL_CODE')
alter table dbo.PUB_ITEM_DETAIL
   drop constraint FK_PUB_ITEM_DETAIL_INTERNAL_CODE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.PUB_ITEM_LIST') and o.name = 'FK_INTERNAL_CODE')
alter table dbo.PUB_ITEM_LIST
   drop constraint FK_INTERNAL_CODE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.SAL_RECEIPT_DETAIL') and o.name = 'FK_SAL_BILLNO')
alter table dbo.SAL_RECEIPT_DETAIL
   drop constraint FK_SAL_BILLNO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.STEEL_GG_BOM') and o.name = 'FK_STEEL_GG_BOM_STEEL_GG')
alter table dbo.STEEL_GG_BOM
   drop constraint FK_STEEL_GG_BOM_STEEL_GG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.STEEL_RECEIPT_DETAIL') and o.name = 'FK_STEEL_RECEIPT_DETAIL_STEEL_RECEIPT_MASTER')
alter table dbo.STEEL_RECEIPT_DETAIL
   drop constraint FK_STEEL_RECEIPT_DETAIL_STEEL_RECEIPT_MASTER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('dbo.WL_RECEIPT_DETAIL') and o.name = 'FK_WL_RECEIPT_DETAIL_WL_RECEIPT_MASTER')
alter table dbo.WL_RECEIPT_DETAIL
   drop constraint FK_WL_RECEIPT_DETAIL_WL_RECEIPT_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.CHECK_CONSTRAINTS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.CHECK_CONSTRAINTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.CL_ITEM_STOCK_DETAIL')
            and   type = 'U')
   drop table dbo.CL_ITEM_STOCK_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.CL_ITEM_STOCK_DETAIL_BEGIN')
            and   type = 'U')
   drop table dbo.CL_ITEM_STOCK_DETAIL_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD')
            and   type = 'U')
   drop table dbo.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.CL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.CL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.CL_RECEIPT_MASTER')
            and   type = 'U')
   drop table dbo.CL_RECEIPT_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.COLUMNS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.COLUMNS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.COLUMN_DOMAIN_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.COLUMN_DOMAIN_USAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.COLUMN_PRIVILEGES')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.COLUMN_PRIVILEGES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.DOMAINS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.DOMAINS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.DOMAIN_CONSTRAINTS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.DOMAIN_CONSTRAINTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.KEY_COLUMN_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.KEY_COLUMN_USAGE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('dbo.ORD_BOM')
            and   name  = 'IX_ORDER_BOM'
            and   indid > 0
            and   indid < 255)
   drop index dbo.ORD_BOM.IX_ORDER_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_BOM')
            and   type = 'U')
   drop table dbo.ORD_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_CGDETAIL')
            and   type = 'U')
   drop table dbo.ORD_CGDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_CG_DETAIL')
            and   type = 'U')
   drop table dbo.ORD_CG_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_CG_MASTER')
            and   type = 'U')
   drop table dbo.ORD_CG_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_COMPLAIN')
            and   type = 'U')
   drop table dbo.ORD_COMPLAIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_Capacity_chart')
            and   type = 'U')
   drop table dbo.ORD_Capacity_chart
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_DETAIL')
            and   type = 'U')
   drop table dbo.ORD_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_ITEM_DA')
            and   type = 'U')
   drop table dbo.ORD_ITEM_DA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_ITEM_DA_BOM')
            and   type = 'U')
   drop table dbo.ORD_ITEM_DA_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_MASTER')
            and   type = 'U')
   drop table dbo.ORD_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_PCDETAIL')
            and   type = 'U')
   drop table dbo.ORD_PCDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_PCMASTER')
            and   type = 'U')
   drop table dbo.ORD_PCMASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_PURCHASE_DETAIL')
            and   type = 'U')
   drop table dbo.ORD_PURCHASE_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_PURCHASE_MASTER')
            and   type = 'U')
   drop table dbo.ORD_PURCHASE_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SEND_DETAIL')
            and   type = 'U')
   drop table dbo.ORD_SEND_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SEND_MASTER')
            and   type = 'U')
   drop table dbo.ORD_SEND_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SEND_REMARK')
            and   type = 'U')
   drop table dbo.ORD_SEND_REMARK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SEND_SHD')
            and   type = 'U')
   drop table dbo.ORD_SEND_SHD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SEND_THJL')
            and   type = 'U')
   drop table dbo.ORD_SEND_THJL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_SKJL')
            and   type = 'U')
   drop table dbo.ORD_SKJL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_TCDETAIL')
            and   type = 'U')
   drop table dbo.ORD_TCDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_THDETAIL')
            and   type = 'U')
   drop table dbo.ORD_THDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_VEHICLE_DETAIL')
            and   type = 'U')
   drop table dbo.ORD_VEHICLE_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_VEHICLE_MASTER')
            and   type = 'U')
   drop table dbo.ORD_VEHICLE_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_WGDETAIL')
            and   type = 'U')
   drop table dbo.ORD_WGDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.ORD_YSJZ')
            and   type = 'U')
   drop table dbo.ORD_YSJZ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.PARAMETERS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.PARAMETERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_AREA')
            and   type = 'U')
   drop table dbo.PUB_AREA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_BANK')
            and   type = 'U')
   drop table dbo.PUB_BANK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_BAR_CODE')
            and   type = 'U')
   drop table dbo.PUB_BAR_CODE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_BMTMP')
            and   type = 'U')
   drop table dbo.PUB_BMTMP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_COMPANY')
            and   type = 'U')
   drop table dbo.PUB_COMPANY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_COMPANY_TYPE')
            and   type = 'U')
   drop table dbo.PUB_COMPANY_TYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_CONSTANT')
            and   type = 'U')
   drop table dbo.PUB_CONSTANT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_CURRENCY')
            and   type = 'U')
   drop table dbo.PUB_CURRENCY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_CUSTOM')
            and   type = 'U')
   drop table dbo.PUB_CUSTOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_CUSTOM_TYPE')
            and   type = 'U')
   drop table dbo.PUB_CUSTOM_TYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_CustomsFees')
            and   type = 'U')
   drop table dbo.PUB_CustomsFees
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_DEPARTMENT')
            and   type = 'U')
   drop table dbo.PUB_DEPARTMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_DICT')
            and   type = 'U')
   drop table dbo.PUB_DICT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_FIXEDASSET')
            and   type = 'U')
   drop table dbo.PUB_FIXEDASSET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_ITEM_DETAIL')
            and   type = 'U')
   drop table dbo.PUB_ITEM_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_ITEM_LIST')
            and   type = 'U')
   drop table dbo.PUB_ITEM_LIST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_ITEM_PRICE')
            and   type = 'U')
   drop table dbo.PUB_ITEM_PRICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_ITEM_TYPE')
            and   type = 'U')
   drop table dbo.PUB_ITEM_TYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_PAYMENT_TYPE')
            and   type = 'U')
   drop table dbo.PUB_PAYMENT_TYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_PRICE')
            and   type = 'U')
   drop table dbo.PUB_PRICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_SALE')
            and   type = 'U')
   drop table dbo.PUB_SALE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_STOCK_MASTER')
            and   type = 'U')
   drop table dbo.PUB_STOCK_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_SUPPLY')
            and   type = 'U')
   drop table dbo.PUB_SUPPLY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.PUB_VEHICLE')
            and   type = 'U')
   drop table dbo.PUB_VEHICLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.ROUTINES')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.ROUTINES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.ROUTINE_COLUMNS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.ROUTINE_COLUMNS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_CUSTOM')
            and   type = 'U')
   drop table dbo.SAL_CUSTOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_ITEM_NOW_PRICE')
            and   type = 'U')
   drop table dbo.SAL_ITEM_NOW_PRICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_ITEM_STOCK_DETAIL')
            and   type = 'U')
   drop table dbo.SAL_ITEM_STOCK_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_ITEM_STOCK_DETAIL_BEGIN')
            and   type = 'U')
   drop table dbo.SAL_ITEM_STOCK_DETAIL_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD')
            and   type = 'U')
   drop table dbo.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.SAL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SAL_RECEIPT_MASTER')
            and   type = 'U')
   drop table dbo.SAL_RECEIPT_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.SCHEMATA')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.SCHEMATA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_DA')
            and   type = 'U')
   drop table dbo.STEEL_DA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_DA_BEGIN')
            and   type = 'U')
   drop table dbo.STEEL_DA_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_DA_BEGIN_RECORD')
            and   type = 'U')
   drop table dbo.STEEL_DA_BEGIN_RECORD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_GG')
            and   type = 'U')
   drop table dbo.STEEL_GG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_GG_BOM')
            and   type = 'U')
   drop table dbo.STEEL_GG_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.STEEL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.STEEL_RECEIPT_MASTER')
            and   type = 'U')
   drop table dbo.STEEL_RECEIPT_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_MENU')
            and   type = 'U')
   drop table dbo.SYS_MENU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_REGISTER')
            and   type = 'U')
   drop table dbo.SYS_REGISTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_SYSCS')
            and   type = 'U')
   drop table dbo.SYS_SYSCS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_USER')
            and   type = 'U')
   drop table dbo.SYS_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_USER_DATARIGHT')
            and   type = 'U')
   drop table dbo.SYS_USER_DATARIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_USER_GROUP')
            and   type = 'U')
   drop table dbo.SYS_USER_GROUP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.SYS_VERSION')
            and   type = 'U')
   drop table dbo.SYS_VERSION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.TABLES')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.TABLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.TABLE_CONSTRAINTS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.TABLE_CONSTRAINTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.TABLE_PRIVILEGES')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.TABLE_PRIVILEGES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.VIEWS')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.VIEWS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.VIEW_COLUMN_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.VIEW_COLUMN_USAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INFORMATION_SCHEMA.VIEW_TABLE_USAGE')
            and   type = 'U')
   drop table INFORMATION_SCHEMA.VIEW_TABLE_USAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VIP_GRADE')
            and   type = 'U')
   drop table dbo.VIP_GRADE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VIP_INFO')
            and   type = 'U')
   drop table dbo.VIP_INFO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_CL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.VI_CL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_ORD_DETAIL')
            and   type = 'U')
   drop table dbo.VI_ORD_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_ORD_SEND_DETAIL')
            and   type = 'U')
   drop table dbo.VI_ORD_SEND_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_SAL_ITEM_STOCK_DETAIL')
            and   type = 'U')
   drop table dbo.VI_SAL_ITEM_STOCK_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_SAL_ITEM_STOCK_DETAIL_BEGIN')
            and   type = 'U')
   drop table dbo.VI_SAL_ITEM_STOCK_DETAIL_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.VI_SAL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.VI_SAL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_ORD_BOM')
            and   type = 'U')
   drop table dbo.Vi_ORD_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_ORD_PCDETAIL')
            and   type = 'U')
   drop table dbo.Vi_ORD_PCDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_SAL_TOTAL')
            and   type = 'U')
   drop table dbo.Vi_SAL_TOTAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_STEEL_Chart')
            and   type = 'U')
   drop table dbo.Vi_STEEL_Chart
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_STEEL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.Vi_STEEL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_WL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.Vi_WL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_WL_STOCK_DETAIL')
            and   type = 'U')
   drop table dbo.Vi_WL_STOCK_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.Vi_WL_STOCK_DETAIL_BEGIN')
            and   type = 'U')
   drop table dbo.Vi_WL_STOCK_DETAIL_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_DA')
            and   type = 'U')
   drop table dbo.WL_DA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_DA_BOM')
            and   type = 'U')
   drop table dbo.WL_DA_BOM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_RECEIPT_DETAIL')
            and   type = 'U')
   drop table dbo.WL_RECEIPT_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_RECEIPT_MASTER')
            and   type = 'U')
   drop table dbo.WL_RECEIPT_MASTER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_STOCK_BEGIN')
            and   type = 'U')
   drop table dbo.WL_STOCK_BEGIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_STOCK_BEGIN_RECORD')
            and   type = 'U')
   drop table dbo.WL_STOCK_BEGIN_RECORD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.WL_STOCK_DETAIL')
            and   type = 'U')
   drop table dbo.WL_STOCK_DETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.all_columns')
            and   type = 'U')
   drop table sys.all_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.all_objects')
            and   type = 'U')
   drop table sys.all_objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.all_parameters')
            and   type = 'U')
   drop table sys.all_parameters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.all_sql_modules')
            and   type = 'U')
   drop table sys.all_sql_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.all_views')
            and   type = 'U')
   drop table sys.all_views
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.allocation_units')
            and   type = 'U')
   drop table sys.allocation_units
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.assemblies')
            and   type = 'U')
   drop table sys.assemblies
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.assembly_files')
            and   type = 'U')
   drop table sys.assembly_files
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.assembly_modules')
            and   type = 'U')
   drop table sys.assembly_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.assembly_references')
            and   type = 'U')
   drop table sys.assembly_references
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.assembly_types')
            and   type = 'U')
   drop table sys.assembly_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.asymmetric_keys')
            and   type = 'U')
   drop table sys.asymmetric_keys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.backup_devices')
            and   type = 'U')
   drop table sys.backup_devices
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.certificates')
            and   type = 'U')
   drop table sys.certificates
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.change_tracking_databases')
            and   type = 'U')
   drop table sys.change_tracking_databases
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.change_tracking_tables')
            and   type = 'U')
   drop table sys.change_tracking_tables
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.check_constraints')
            and   type = 'U')
   drop table sys.check_constraints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.column_type_usages')
            and   type = 'U')
   drop table sys.column_type_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.column_xml_schema_collection_usages')
            and   type = 'U')
   drop table sys.column_xml_schema_collection_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.columns')
            and   type = 'U')
   drop table sys.columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.computed_columns')
            and   type = 'U')
   drop table sys.computed_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.configurations')
            and   type = 'U')
   drop table sys.configurations
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.conversation_endpoints')
            and   type = 'U')
   drop table sys.conversation_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.conversation_groups')
            and   type = 'U')
   drop table sys.conversation_groups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.conversation_priorities')
            and   type = 'U')
   drop table sys.conversation_priorities
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.credentials')
            and   type = 'U')
   drop table sys.credentials
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.crypt_properties')
            and   type = 'U')
   drop table sys.crypt_properties
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.cryptographic_providers')
            and   type = 'U')
   drop table sys.cryptographic_providers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.data_spaces')
            and   type = 'U')
   drop table sys.data_spaces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_audit_specification_details')
            and   type = 'U')
   drop table sys.database_audit_specification_details
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_audit_specifications')
            and   type = 'U')
   drop table sys.database_audit_specifications
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_files')
            and   type = 'U')
   drop table sys.database_files
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_mirroring')
            and   type = 'U')
   drop table sys.database_mirroring
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_mirroring_endpoints')
            and   type = 'U')
   drop table sys.database_mirroring_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_mirroring_witnesses')
            and   type = 'U')
   drop table sys.database_mirroring_witnesses
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_permissions')
            and   type = 'U')
   drop table sys.database_permissions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_principal_aliases')
            and   type = 'U')
   drop table sys.database_principal_aliases
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_principals')
            and   type = 'U')
   drop table sys.database_principals
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_recovery_status')
            and   type = 'U')
   drop table sys.database_recovery_status
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.database_role_members')
            and   type = 'U')
   drop table sys.database_role_members
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.databases')
            and   type = 'U')
   drop table sys.databases
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.default_constraints')
            and   type = 'U')
   drop table sys.default_constraints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.destination_data_spaces')
            and   type = 'U')
   drop table sys.destination_data_spaces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_audit_actions')
            and   type = 'U')
   drop table sys.dm_audit_actions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_audit_class_type_map')
            and   type = 'U')
   drop table sys.dm_audit_class_type_map
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_broker_activated_tasks')
            and   type = 'U')
   drop table sys.dm_broker_activated_tasks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_broker_connections')
            and   type = 'U')
   drop table sys.dm_broker_connections
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_broker_forwarded_messages')
            and   type = 'U')
   drop table sys.dm_broker_forwarded_messages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_broker_queue_monitors')
            and   type = 'U')
   drop table sys.dm_broker_queue_monitors
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_cdc_errors')
            and   type = 'U')
   drop table sys.dm_cdc_errors
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_cdc_log_scan_sessions')
            and   type = 'U')
   drop table sys.dm_cdc_log_scan_sessions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_clr_appdomains')
            and   type = 'U')
   drop table sys.dm_clr_appdomains
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_clr_loaded_assemblies')
            and   type = 'U')
   drop table sys.dm_clr_loaded_assemblies
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_clr_properties')
            and   type = 'U')
   drop table sys.dm_clr_properties
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_clr_tasks')
            and   type = 'U')
   drop table sys.dm_clr_tasks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_cryptographic_provider_properties')
            and   type = 'U')
   drop table sys.dm_cryptographic_provider_properties
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_database_encryption_keys')
            and   type = 'U')
   drop table sys.dm_database_encryption_keys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_file_space_usage')
            and   type = 'U')
   drop table sys.dm_db_file_space_usage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_index_usage_stats')
            and   type = 'U')
   drop table sys.dm_db_index_usage_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_mirroring_auto_page_repair')
            and   type = 'U')
   drop table sys.dm_db_mirroring_auto_page_repair
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_mirroring_connections')
            and   type = 'U')
   drop table sys.dm_db_mirroring_connections
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_mirroring_past_actions')
            and   type = 'U')
   drop table sys.dm_db_mirroring_past_actions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_missing_index_details')
            and   type = 'U')
   drop table sys.dm_db_missing_index_details
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_missing_index_group_stats')
            and   type = 'U')
   drop table sys.dm_db_missing_index_group_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_missing_index_groups')
            and   type = 'U')
   drop table sys.dm_db_missing_index_groups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_partition_stats')
            and   type = 'U')
   drop table sys.dm_db_partition_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_persisted_sku_features')
            and   type = 'U')
   drop table sys.dm_db_persisted_sku_features
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_script_level')
            and   type = 'U')
   drop table sys.dm_db_script_level
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_session_space_usage')
            and   type = 'U')
   drop table sys.dm_db_session_space_usage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_db_task_space_usage')
            and   type = 'U')
   drop table sys.dm_db_task_space_usage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_background_job_queue')
            and   type = 'U')
   drop table sys.dm_exec_background_job_queue
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_background_job_queue_stats')
            and   type = 'U')
   drop table sys.dm_exec_background_job_queue_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_cached_plans')
            and   type = 'U')
   drop table sys.dm_exec_cached_plans
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_connections')
            and   type = 'U')
   drop table sys.dm_exec_connections
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_procedure_stats')
            and   type = 'U')
   drop table sys.dm_exec_procedure_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_query_memory_grants')
            and   type = 'U')
   drop table sys.dm_exec_query_memory_grants
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_query_optimizer_info')
            and   type = 'U')
   drop table sys.dm_exec_query_optimizer_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_query_resource_semaphores')
            and   type = 'U')
   drop table sys.dm_exec_query_resource_semaphores
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_query_stats')
            and   type = 'U')
   drop table sys.dm_exec_query_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_query_transformation_stats')
            and   type = 'U')
   drop table sys.dm_exec_query_transformation_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_requests')
            and   type = 'U')
   drop table sys.dm_exec_requests
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_sessions')
            and   type = 'U')
   drop table sys.dm_exec_sessions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_exec_trigger_stats')
            and   type = 'U')
   drop table sys.dm_exec_trigger_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_filestream_file_io_handles')
            and   type = 'U')
   drop table sys.dm_filestream_file_io_handles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_filestream_file_io_requests')
            and   type = 'U')
   drop table sys.dm_filestream_file_io_requests
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_active_catalogs')
            and   type = 'U')
   drop table sys.dm_fts_active_catalogs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_fdhosts')
            and   type = 'U')
   drop table sys.dm_fts_fdhosts
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_index_population')
            and   type = 'U')
   drop table sys.dm_fts_index_population
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_memory_buffers')
            and   type = 'U')
   drop table sys.dm_fts_memory_buffers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_memory_pools')
            and   type = 'U')
   drop table sys.dm_fts_memory_pools
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_outstanding_batches')
            and   type = 'U')
   drop table sys.dm_fts_outstanding_batches
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_fts_population_ranges')
            and   type = 'U')
   drop table sys.dm_fts_population_ranges
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_io_backup_tapes')
            and   type = 'U')
   drop table sys.dm_io_backup_tapes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_io_cluster_shared_drives')
            and   type = 'U')
   drop table sys.dm_io_cluster_shared_drives
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_io_pending_io_requests')
            and   type = 'U')
   drop table sys.dm_io_pending_io_requests
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_buffer_descriptors')
            and   type = 'U')
   drop table sys.dm_os_buffer_descriptors
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_child_instances')
            and   type = 'U')
   drop table sys.dm_os_child_instances
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_cluster_nodes')
            and   type = 'U')
   drop table sys.dm_os_cluster_nodes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_dispatcher_pools')
            and   type = 'U')
   drop table sys.dm_os_dispatcher_pools
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_dispatchers')
            and   type = 'U')
   drop table sys.dm_os_dispatchers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_hosts')
            and   type = 'U')
   drop table sys.dm_os_hosts
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_latch_stats')
            and   type = 'U')
   drop table sys.dm_os_latch_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_loaded_modules')
            and   type = 'U')
   drop table sys.dm_os_loaded_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_allocations')
            and   type = 'U')
   drop table sys.dm_os_memory_allocations
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_brokers')
            and   type = 'U')
   drop table sys.dm_os_memory_brokers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_cache_clock_hands')
            and   type = 'U')
   drop table sys.dm_os_memory_cache_clock_hands
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_cache_counters')
            and   type = 'U')
   drop table sys.dm_os_memory_cache_counters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_cache_entries')
            and   type = 'U')
   drop table sys.dm_os_memory_cache_entries
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_cache_hash_tables')
            and   type = 'U')
   drop table sys.dm_os_memory_cache_hash_tables
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_clerks')
            and   type = 'U')
   drop table sys.dm_os_memory_clerks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_node_access_stats')
            and   type = 'U')
   drop table sys.dm_os_memory_node_access_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_nodes')
            and   type = 'U')
   drop table sys.dm_os_memory_nodes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_objects')
            and   type = 'U')
   drop table sys.dm_os_memory_objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_memory_pools')
            and   type = 'U')
   drop table sys.dm_os_memory_pools
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_nodes')
            and   type = 'U')
   drop table sys.dm_os_nodes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_performance_counters')
            and   type = 'U')
   drop table sys.dm_os_performance_counters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_process_memory')
            and   type = 'U')
   drop table sys.dm_os_process_memory
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_ring_buffers')
            and   type = 'U')
   drop table sys.dm_os_ring_buffers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_schedulers')
            and   type = 'U')
   drop table sys.dm_os_schedulers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_spinlock_stats')
            and   type = 'U')
   drop table sys.dm_os_spinlock_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_stacks')
            and   type = 'U')
   drop table sys.dm_os_stacks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_sublatches')
            and   type = 'U')
   drop table sys.dm_os_sublatches
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_sys_info')
            and   type = 'U')
   drop table sys.dm_os_sys_info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_sys_memory')
            and   type = 'U')
   drop table sys.dm_os_sys_memory
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_tasks')
            and   type = 'U')
   drop table sys.dm_os_tasks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_threads')
            and   type = 'U')
   drop table sys.dm_os_threads
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_virtual_address_dump')
            and   type = 'U')
   drop table sys.dm_os_virtual_address_dump
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_wait_stats')
            and   type = 'U')
   drop table sys.dm_os_wait_stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_waiting_tasks')
            and   type = 'U')
   drop table sys.dm_os_waiting_tasks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_worker_local_storage')
            and   type = 'U')
   drop table sys.dm_os_worker_local_storage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_os_workers')
            and   type = 'U')
   drop table sys.dm_os_workers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_qn_subscriptions')
            and   type = 'U')
   drop table sys.dm_qn_subscriptions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_repl_articles')
            and   type = 'U')
   drop table sys.dm_repl_articles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_repl_schemas')
            and   type = 'U')
   drop table sys.dm_repl_schemas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_repl_tranhash')
            and   type = 'U')
   drop table sys.dm_repl_tranhash
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_repl_traninfo')
            and   type = 'U')
   drop table sys.dm_repl_traninfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_resource_governor_configuration')
            and   type = 'U')
   drop table sys.dm_resource_governor_configuration
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_resource_governor_resource_pools')
            and   type = 'U')
   drop table sys.dm_resource_governor_resource_pools
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_resource_governor_workload_groups')
            and   type = 'U')
   drop table sys.dm_resource_governor_workload_groups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_server_audit_status')
            and   type = 'U')
   drop table sys.dm_server_audit_status
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_active_snapshot_database_transactions')
            and   type = 'U')
   drop table sys.dm_tran_active_snapshot_database_transactions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_active_transactions')
            and   type = 'U')
   drop table sys.dm_tran_active_transactions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_commit_table')
            and   type = 'U')
   drop table sys.dm_tran_commit_table
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_current_snapshot')
            and   type = 'U')
   drop table sys.dm_tran_current_snapshot
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_current_transaction')
            and   type = 'U')
   drop table sys.dm_tran_current_transaction
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_database_transactions')
            and   type = 'U')
   drop table sys.dm_tran_database_transactions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_locks')
            and   type = 'U')
   drop table sys.dm_tran_locks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_session_transactions')
            and   type = 'U')
   drop table sys.dm_tran_session_transactions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_top_version_generators')
            and   type = 'U')
   drop table sys.dm_tran_top_version_generators
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_transactions_snapshot')
            and   type = 'U')
   drop table sys.dm_tran_transactions_snapshot
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_tran_version_store')
            and   type = 'U')
   drop table sys.dm_tran_version_store
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_map_values')
            and   type = 'U')
   drop table sys.dm_xe_map_values
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_object_columns')
            and   type = 'U')
   drop table sys.dm_xe_object_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_objects')
            and   type = 'U')
   drop table sys.dm_xe_objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_packages')
            and   type = 'U')
   drop table sys.dm_xe_packages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_session_event_actions')
            and   type = 'U')
   drop table sys.dm_xe_session_event_actions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_session_events')
            and   type = 'U')
   drop table sys.dm_xe_session_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_session_object_columns')
            and   type = 'U')
   drop table sys.dm_xe_session_object_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_session_targets')
            and   type = 'U')
   drop table sys.dm_xe_session_targets
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.dm_xe_sessions')
            and   type = 'U')
   drop table sys.dm_xe_sessions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.dtproperties')
            and   type = 'U')
   drop table dbo.dtproperties
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.endpoint_webmethods')
            and   type = 'U')
   drop table sys.endpoint_webmethods
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.endpoints')
            and   type = 'U')
   drop table sys.endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.event_notification_event_types')
            and   type = 'U')
   drop table sys.event_notification_event_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.event_notifications')
            and   type = 'U')
   drop table sys.event_notifications
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.events')
            and   type = 'U')
   drop table sys.events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.extended_procedures')
            and   type = 'U')
   drop table sys.extended_procedures
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.extended_properties')
            and   type = 'U')
   drop table sys.extended_properties
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.filegroups')
            and   type = 'U')
   drop table sys.filegroups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.foreign_key_columns')
            and   type = 'U')
   drop table sys.foreign_key_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.foreign_keys')
            and   type = 'U')
   drop table sys.foreign_keys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_catalogs')
            and   type = 'U')
   drop table sys.fulltext_catalogs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_document_types')
            and   type = 'U')
   drop table sys.fulltext_document_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_index_catalog_usages')
            and   type = 'U')
   drop table sys.fulltext_index_catalog_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_index_columns')
            and   type = 'U')
   drop table sys.fulltext_index_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_index_fragments')
            and   type = 'U')
   drop table sys.fulltext_index_fragments
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_indexes')
            and   type = 'U')
   drop table sys.fulltext_indexes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_languages')
            and   type = 'U')
   drop table sys.fulltext_languages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_stoplists')
            and   type = 'U')
   drop table sys.fulltext_stoplists
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_stopwords')
            and   type = 'U')
   drop table sys.fulltext_stopwords
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.fulltext_system_stopwords')
            and   type = 'U')
   drop table sys.fulltext_system_stopwords
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.function_order_columns')
            and   type = 'U')
   drop table sys.function_order_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.http_endpoints')
            and   type = 'U')
   drop table sys.http_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.identity_columns')
            and   type = 'U')
   drop table sys.identity_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.index_columns')
            and   type = 'U')
   drop table sys.index_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.indexes')
            and   type = 'U')
   drop table sys.indexes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.internal_tables')
            and   type = 'U')
   drop table sys.internal_tables
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.key_constraints')
            and   type = 'U')
   drop table sys.key_constraints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.key_encryptions')
            and   type = 'U')
   drop table sys.key_encryptions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.linked_logins')
            and   type = 'U')
   drop table sys.linked_logins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.login_token')
            and   type = 'U')
   drop table sys.login_token
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.master_files')
            and   type = 'U')
   drop table sys.master_files
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.master_key_passwords')
            and   type = 'U')
   drop table sys.master_key_passwords
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.message_type_xml_schema_collection_usages')
            and   type = 'U')
   drop table sys.message_type_xml_schema_collection_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.messages')
            and   type = 'U')
   drop table sys.messages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.module_assembly_usages')
            and   type = 'U')
   drop table sys.module_assembly_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.numbered_procedure_parameters')
            and   type = 'U')
   drop table sys.numbered_procedure_parameters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.numbered_procedures')
            and   type = 'U')
   drop table sys.numbered_procedures
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.objects')
            and   type = 'U')
   drop table sys.objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.openkeys')
            and   type = 'U')
   drop table sys.openkeys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.parameter_type_usages')
            and   type = 'U')
   drop table sys.parameter_type_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.parameter_xml_schema_collection_usages')
            and   type = 'U')
   drop table sys.parameter_xml_schema_collection_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.parameters')
            and   type = 'U')
   drop table sys.parameters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.partition_functions')
            and   type = 'U')
   drop table sys.partition_functions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.partition_parameters')
            and   type = 'U')
   drop table sys.partition_parameters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.partition_range_values')
            and   type = 'U')
   drop table sys.partition_range_values
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.partition_schemes')
            and   type = 'U')
   drop table sys.partition_schemes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.partitions')
            and   type = 'U')
   drop table sys.partitions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.plan_guides')
            and   type = 'U')
   drop table sys.plan_guides
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.procedures')
            and   type = 'U')
   drop table sys.procedures
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.remote_logins')
            and   type = 'U')
   drop table sys.remote_logins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.remote_service_bindings')
            and   type = 'U')
   drop table sys.remote_service_bindings
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.resource_governor_configuration')
            and   type = 'U')
   drop table sys.resource_governor_configuration
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.resource_governor_resource_pools')
            and   type = 'U')
   drop table sys.resource_governor_resource_pools
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.resource_governor_workload_groups')
            and   type = 'U')
   drop table sys.resource_governor_workload_groups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.routes')
            and   type = 'U')
   drop table sys.routes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.schemas')
            and   type = 'U')
   drop table sys.schemas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.securable_classes')
            and   type = 'U')
   drop table sys.securable_classes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_assembly_modules')
            and   type = 'U')
   drop table sys.server_assembly_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_audit_specification_details')
            and   type = 'U')
   drop table sys.server_audit_specification_details
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_audit_specifications')
            and   type = 'U')
   drop table sys.server_audit_specifications
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_audits')
            and   type = 'U')
   drop table sys.server_audits
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_notifications')
            and   type = 'U')
   drop table sys.server_event_notifications
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_session_actions')
            and   type = 'U')
   drop table sys.server_event_session_actions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_session_events')
            and   type = 'U')
   drop table sys.server_event_session_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_session_fields')
            and   type = 'U')
   drop table sys.server_event_session_fields
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_session_targets')
            and   type = 'U')
   drop table sys.server_event_session_targets
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_event_sessions')
            and   type = 'U')
   drop table sys.server_event_sessions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_events')
            and   type = 'U')
   drop table sys.server_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_file_audits')
            and   type = 'U')
   drop table sys.server_file_audits
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_permissions')
            and   type = 'U')
   drop table sys.server_permissions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_principal_credentials')
            and   type = 'U')
   drop table sys.server_principal_credentials
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_principals')
            and   type = 'U')
   drop table sys.server_principals
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_role_members')
            and   type = 'U')
   drop table sys.server_role_members
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_sql_modules')
            and   type = 'U')
   drop table sys.server_sql_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_trigger_events')
            and   type = 'U')
   drop table sys.server_trigger_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.server_triggers')
            and   type = 'U')
   drop table sys.server_triggers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.servers')
            and   type = 'U')
   drop table sys.servers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_broker_endpoints')
            and   type = 'U')
   drop table sys.service_broker_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_contract_message_usages')
            and   type = 'U')
   drop table sys.service_contract_message_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_contract_usages')
            and   type = 'U')
   drop table sys.service_contract_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_contracts')
            and   type = 'U')
   drop table sys.service_contracts
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_message_types')
            and   type = 'U')
   drop table sys.service_message_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_queue_usages')
            and   type = 'U')
   drop table sys.service_queue_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.service_queues')
            and   type = 'U')
   drop table sys.service_queues
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.services')
            and   type = 'U')
   drop table sys.services
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.soap_endpoints')
            and   type = 'U')
   drop table sys.soap_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.spatial_index_tessellations')
            and   type = 'U')
   drop table sys.spatial_index_tessellations
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.spatial_indexes')
            and   type = 'U')
   drop table sys.spatial_indexes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.spatial_reference_systems')
            and   type = 'U')
   drop table sys.spatial_reference_systems
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sql_dependencies')
            and   type = 'U')
   drop table sys.sql_dependencies
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sql_expression_dependencies')
            and   type = 'U')
   drop table sys.sql_expression_dependencies
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sql_logins')
            and   type = 'U')
   drop table sys.sql_logins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sql_modules')
            and   type = 'U')
   drop table sys.sql_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.stats')
            and   type = 'U')
   drop table sys.stats
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.stats_columns')
            and   type = 'U')
   drop table sys.stats_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.symmetric_keys')
            and   type = 'U')
   drop table sys.symmetric_keys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.synonyms')
            and   type = 'U')
   drop table sys.synonyms
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysaltfiles')
            and   type = 'U')
   drop table sys.sysaltfiles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscacheobjects')
            and   type = 'U')
   drop table sys.syscacheobjects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscharsets')
            and   type = 'U')
   drop table sys.syscharsets
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscolumns')
            and   type = 'U')
   drop table sys.syscolumns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscomments')
            and   type = 'U')
   drop table sys.syscomments
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysconfigures')
            and   type = 'U')
   drop table sys.sysconfigures
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysconstraints')
            and   type = 'U')
   drop table sys.sysconstraints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscurconfigs')
            and   type = 'U')
   drop table sys.syscurconfigs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscursorcolumns')
            and   type = 'U')
   drop table sys.syscursorcolumns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscursorrefs')
            and   type = 'U')
   drop table sys.syscursorrefs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscursors')
            and   type = 'U')
   drop table sys.syscursors
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syscursortables')
            and   type = 'U')
   drop table sys.syscursortables
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysdatabases')
            and   type = 'U')
   drop table sys.sysdatabases
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysdepends')
            and   type = 'U')
   drop table sys.sysdepends
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysdevices')
            and   type = 'U')
   drop table sys.sysdevices
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysfilegroups')
            and   type = 'U')
   drop table sys.sysfilegroups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysfiles')
            and   type = 'U')
   drop table sys.sysfiles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysforeignkeys')
            and   type = 'U')
   drop table sys.sysforeignkeys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysfulltextcatalogs')
            and   type = 'U')
   drop table sys.sysfulltextcatalogs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysindexes')
            and   type = 'U')
   drop table sys.sysindexes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysindexkeys')
            and   type = 'U')
   drop table sys.sysindexkeys
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syslanguages')
            and   type = 'U')
   drop table sys.syslanguages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syslockinfo')
            and   type = 'U')
   drop table sys.syslockinfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syslogins')
            and   type = 'U')
   drop table sys.syslogins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysmembers')
            and   type = 'U')
   drop table sys.sysmembers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysmessages')
            and   type = 'U')
   drop table sys.sysmessages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysobjects')
            and   type = 'U')
   drop table sys.sysobjects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysoledbusers')
            and   type = 'U')
   drop table sys.sysoledbusers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysopentapes')
            and   type = 'U')
   drop table sys.sysopentapes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysperfinfo')
            and   type = 'U')
   drop table sys.sysperfinfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.syspermissions')
            and   type = 'U')
   drop table sys.syspermissions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysprocesses')
            and   type = 'U')
   drop table sys.sysprocesses
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysprotects')
            and   type = 'U')
   drop table sys.sysprotects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysreferences')
            and   type = 'U')
   drop table sys.sysreferences
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysremotelogins')
            and   type = 'U')
   drop table sys.sysremotelogins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysservers')
            and   type = 'U')
   drop table sys.sysservers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_columns')
            and   type = 'U')
   drop table sys.system_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_components_surface_area_configuration')
            and   type = 'U')
   drop table sys.system_components_surface_area_configuration
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_internals_allocation_units')
            and   type = 'U')
   drop table sys.system_internals_allocation_units
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_internals_partition_columns')
            and   type = 'U')
   drop table sys.system_internals_partition_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_internals_partitions')
            and   type = 'U')
   drop table sys.system_internals_partitions
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_objects')
            and   type = 'U')
   drop table sys.system_objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_parameters')
            and   type = 'U')
   drop table sys.system_parameters
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_sql_modules')
            and   type = 'U')
   drop table sys.system_sql_modules
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.system_views')
            and   type = 'U')
   drop table sys.system_views
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.systypes')
            and   type = 'U')
   drop table sys.systypes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.sysusers')
            and   type = 'U')
   drop table sys.sysusers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.table_types')
            and   type = 'U')
   drop table sys.table_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.tables')
            and   type = 'U')
   drop table sys.tables
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.tcp_endpoints')
            and   type = 'U')
   drop table sys.tcp_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trace_categories')
            and   type = 'U')
   drop table sys.trace_categories
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trace_columns')
            and   type = 'U')
   drop table sys.trace_columns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trace_event_bindings')
            and   type = 'U')
   drop table sys.trace_event_bindings
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trace_events')
            and   type = 'U')
   drop table sys.trace_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trace_subclass_values')
            and   type = 'U')
   drop table sys.trace_subclass_values
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.traces')
            and   type = 'U')
   drop table sys.traces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.transmission_queue')
            and   type = 'U')
   drop table sys.transmission_queue
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trigger_event_types')
            and   type = 'U')
   drop table sys.trigger_event_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.trigger_events')
            and   type = 'U')
   drop table sys.trigger_events
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.triggers')
            and   type = 'U')
   drop table sys.triggers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.type_assembly_usages')
            and   type = 'U')
   drop table sys.type_assembly_usages
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.types')
            and   type = 'U')
   drop table sys.types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.user_token')
            and   type = 'U')
   drop table sys.user_token
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.via_endpoints')
            and   type = 'U')
   drop table sys.via_endpoints
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.views')
            and   type = 'U')
   drop table sys.views
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_indexes')
            and   type = 'U')
   drop table sys.xml_indexes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_attributes')
            and   type = 'U')
   drop table sys.xml_schema_attributes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_collections')
            and   type = 'U')
   drop table sys.xml_schema_collections
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_component_placements')
            and   type = 'U')
   drop table sys.xml_schema_component_placements
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_components')
            and   type = 'U')
   drop table sys.xml_schema_components
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_elements')
            and   type = 'U')
   drop table sys.xml_schema_elements
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_facets')
            and   type = 'U')
   drop table sys.xml_schema_facets
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_model_groups')
            and   type = 'U')
   drop table sys.xml_schema_model_groups
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_namespaces')
            and   type = 'U')
   drop table sys.xml_schema_namespaces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_types')
            and   type = 'U')
   drop table sys.xml_schema_types
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_wildcard_namespaces')
            and   type = 'U')
   drop table sys.xml_schema_wildcard_namespaces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sys.xml_schema_wildcards')
            and   type = 'U')
   drop table sys.xml_schema_wildcards
go

execute sp_revokedbaccess INFORMATION_SCHEMA
go

execute sp_revokedbaccess dbo
go

execute sp_revokedbaccess sys
go

/*==============================================================*/
/* User: INFORMATION_SCHEMA                                     */
/*==============================================================*/
execute sp_grantdbaccess INFORMATION_SCHEMA
go

/*==============================================================*/
/* User: dbo                                                    */
/*==============================================================*/
execute sp_grantdbaccess dbo
go

/*==============================================================*/
/* User: sys                                                    */
/*==============================================================*/
execute sp_grantdbaccess sys
go

/*==============================================================*/
/* Table: CHECK_CONSTRAINTS                                     */
/*==============================================================*/
create table INFORMATION_SCHEMA.CHECK_CONSTRAINTS (
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null,
   CHECK_CLAUSE         nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'CHECK_CONSTRAINTS'
go

/*==============================================================*/
/* Table: CL_ITEM_STOCK_DETAIL                                  */
/*==============================================================*/
create table dbo.CL_ITEM_STOCK_DETAIL (
   TEMPID               int                  identity,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(200)        null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(200)        null,
   IMAGE                image(2147483647)    null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   TYPE_NAME            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_LK              float                null,
   ITEM_LH              float                null,
   ITEM_BJ              float                null,
   ITEM_rate            float                null,
   ITEM_GYLC            nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(6)          null,
   NET_PRICE            float                null default (0),
   PRICE                float                null default (0),
   QTY                  float                null,
   ACTUAL_QTY           float                null default (0),
   MIN_QTY              numeric(12,2)        null default (0),
   MAX_QTY              numeric(12,2)        null default (0),
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   POSITION_CODE        nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   DESCRIPTION          varchar(200)         null,
   BARCODE              varchar(50)          null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(50)         null,
   REMARK               nvarchar(200)        null,
   constraint PK_CL_ITEM_STOCK_DETAIL primary key nonclustered (ITEM_CODE)
)
go

/*==============================================================*/
/* Table: CL_ITEM_STOCK_DETAIL_BEGIN                            */
/*==============================================================*/
create table dbo.CL_ITEM_STOCK_DETAIL_BEGIN (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   CREATE_DATE          datetime             null
)
go

/*==============================================================*/
/* Table: CL_ITEM_STOCK_DETAIL_BEGIN_RECORD                     */
/*==============================================================*/
create table dbo.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          varchar(50)          null
)
go

/*==============================================================*/
/* Table: CL_RECEIPT_DETAIL                                     */
/*==============================================================*/
create table dbo.CL_RECEIPT_DETAIL (
   TempID               int                  identity,
   BillNo               nvarchar(50)         null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   NET_PRICE            decimal(18,3)        null,
   PRICE                decimal(18,3)        null,
   ITEM_JZ              float                null,
   QTY                  float                null,
   QUANTITY             float                null,
   ACTUAL_QTY           float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   BARCODE              nvarchar(50)         null,
   REMARK               nvarchar(50)         null,
   DESCRIPTION          varchar(200)         null
)
go

/*==============================================================*/
/* Table: CL_RECEIPT_MASTER                                     */
/*==============================================================*/
create table dbo.CL_RECEIPT_MASTER (
   BillNo               nvarchar(50)         not null,
   MANUAL_BILLNO        nvarchar(50)         null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nvarchar(50)         null,
   BILLTYPE             nvarchar(50)         null,
   BILL_STATUS          nvarchar(10)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BILLDATE             datetime             null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(50)         null,
   constraint PK_CL_RECEIPT_MASTER primary key nonclustered (BillNo)
)
go

/*==============================================================*/
/* Table: COLUMNS                                               */
/*==============================================================*/
create table INFORMATION_SCHEMA.COLUMNS (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          sysname(128)         null,
   ORDINAL_POSITION     int                  null,
   COLUMN_DEFAULT       nvarchar(4000)       null,
   IS_NULLABLE          varchar(3)           null,
   DATA_TYPE            nvarchar(128)        null,
   CHARACTER_MAXIMUM_LENGTH int                  null,
   CHARACTER_OCTET_LENGTH int                  null,
   NUMERIC_PRECISION    tinyint              null,
   NUMERIC_PRECISION_RADIX smallint             null,
   NUMERIC_SCALE        int                  null,
   DATETIME_PRECISION   smallint             null,
   CHARACTER_SET_CATALOG sysname(128)         null,
   CHARACTER_SET_SCHEMA sysname(128)         null,
   CHARACTER_SET_NAME   sysname(128)         null,
   COLLATION_CATALOG    sysname(128)         null,
   COLLATION_SCHEMA     sysname(128)         null,
   COLLATION_NAME       sysname(128)         null,
   DOMAIN_CATALOG       sysname(128)         null,
   DOMAIN_SCHEMA        sysname(128)         null,
   DOMAIN_NAME          sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'COLUMNS'
go

/*==============================================================*/
/* Table: COLUMN_DOMAIN_USAGE                                   */
/*==============================================================*/
create table INFORMATION_SCHEMA.COLUMN_DOMAIN_USAGE (
   DOMAIN_CATALOG       nvarchar(128)        null,
   DOMAIN_SCHEMA        nvarchar(128)        null,
   DOMAIN_NAME          sysname(128)         not null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'COLUMN_DOMAIN_USAGE'
go

/*==============================================================*/
/* Table: COLUMN_PRIVILEGES                                     */
/*==============================================================*/
create table INFORMATION_SCHEMA.COLUMN_PRIVILEGES (
   GRANTOR              nvarchar(128)        null,
   GRANTEE              nvarchar(128)        null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          sysname(128)         null,
   PRIVILEGE_TYPE       varchar(10)          null,
   IS_GRANTABLE         varchar(3)           null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'COLUMN_PRIVILEGES'
go

/*==============================================================*/
/* Table: CONSTRAINT_COLUMN_USAGE                               */
/*==============================================================*/
create table INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          nvarchar(128)        null,
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'CONSTRAINT_COLUMN_USAGE'
go

/*==============================================================*/
/* Table: CONSTRAINT_TABLE_USAGE                                */
/*==============================================================*/
create table INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'CONSTRAINT_TABLE_USAGE'
go

/*==============================================================*/
/* Table: DOMAINS                                               */
/*==============================================================*/
create table INFORMATION_SCHEMA.DOMAINS (
   DOMAIN_CATALOG       nvarchar(128)        null,
   DOMAIN_SCHEMA        nvarchar(128)        null,
   DOMAIN_NAME          sysname(128)         not null,
   DATA_TYPE            nvarchar(128)        null,
   CHARACTER_MAXIMUM_LENGTH int                  null,
   CHARACTER_OCTET_LENGTH int                  null,
   COLLATION_CATALOG    sysname(128)         null,
   COLLATION_SCHEMA     sysname(128)         null,
   COLLATION_NAME       sysname(128)         null,
   CHARACTER_SET_CATALOG sysname(128)         null,
   CHARACTER_SET_SCHEMA sysname(128)         null,
   CHARACTER_SET_NAME   sysname(128)         null,
   NUMERIC_PRECISION    tinyint              null,
   NUMERIC_PRECISION_RADIX smallint             null,
   NUMERIC_SCALE        int                  null,
   DATETIME_PRECISION   smallint             null,
   DOMAIN_DEFAULT       nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'DOMAINS'
go

/*==============================================================*/
/* Table: DOMAIN_CONSTRAINTS                                    */
/*==============================================================*/
create table INFORMATION_SCHEMA.DOMAIN_CONSTRAINTS (
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null,
   DOMAIN_CATALOG       nvarchar(128)        null,
   DOMAIN_SCHEMA        nvarchar(128)        null,
   DOMAIN_NAME          sysname(128)         not null,
   IS_DEFERRABLE        varchar(2)           not null,
   INITIALLY_DEFERRED   varchar(2)           not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'DOMAIN_CONSTRAINTS'
go

/*==============================================================*/
/* Table: KEY_COLUMN_USAGE                                      */
/*==============================================================*/
create table INFORMATION_SCHEMA.KEY_COLUMN_USAGE (
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          nvarchar(128)        null,
   ORDINAL_POSITION     int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'KEY_COLUMN_USAGE'
go

/*==============================================================*/
/* Table: ORD_BOM                                               */
/*==============================================================*/
create table dbo.ORD_BOM (
   SEQUENCE             int                  null,
   MASTERID             varchar(50)          null,
   DETAILID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_INTERNAL_CODE_CL nvarchar(100)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_CZ              nchar(10)            null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   total_quantity       float                null default (0),
   ACTUAL_QTY           float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Index: IX_ORDER_BOM                                          */
/*==============================================================*/
create index IX_ORDER_BOM on dbo.ORD_BOM (
SEQUENCE ASC
)
go

/*==============================================================*/
/* Table: ORD_CGDETAIL                                          */
/*==============================================================*/
create table dbo.ORD_CGDETAIL (
   BillNO               varchar(50)          not null,
   MASTERID             varchar(200)         null,
   DetailID             varchar(200)         null,
   Sequence             varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   Quantity             float                null,
   ORD_TL               nvarchar(10)         null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          nvarchar(10)         null,
   REMARK               nvarchar(50)         null,
   constraint PK_ORDER_CGDETAIL primary key nonclustered (BillNO)
)
go

/*==============================================================*/
/* Table: ORD_CG_DETAIL                                         */
/*==============================================================*/
create table dbo.ORD_CG_DETAIL (
   SEQUENCE             int                  null,
   BILLNO               varchar(50)          not null,
   MASTERID             varchar(50)          not null,
   DETAILID             varchar(50)          not null,
   SUPPLY_CODE          varchar(50)          null,
   SUPPLY_NAME          varchar(50)          null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nchar(10)            null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_CZ              nchar(10)            null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   total_quantity       float                null,
   CG_TL                nchar(10)            null,
   BILL_DATE            datetime             null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: ORD_CG_MASTER                                         */
/*==============================================================*/
create table dbo.ORD_CG_MASTER (
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   MANUAL_BILLNO        varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   FACTORY              varchar(50)          null,
   BILL_TYPE            varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   SCYQ                 varchar(100)         null,
   BZTYPE               varchar(100)         null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null,
   REMARK1              varchar(50)          null,
   REMARK2              varchar(50)          null,
   constraint PK_ORDER_CG_MASTER primary key nonclustered (BILLNO)
)
go

/*==============================================================*/
/* Table: ORD_COMPLAIN                                          */
/*==============================================================*/
create table dbo.ORD_COMPLAIN (
   INTERNAL_CODE        varchar(50)          not null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   billtype             varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   BILLNO               varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   IMAGE_NAME           varchar(50)          null,
   IMAGE                image(2147483647)    null,
   QUANTITY             float                null,
   COMPLAIN_question    ntext(1073741823)    null,
   UPDATE_question      ntext(1073741823)    null,
   Tracking_question    ntext(1073741823)    null,
   BEGIN_DATE           varchar(50)          null,
   END_DATE             varchar(50)          null,
   BILL_STATUS          nchar(10)            null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               varchar(50)          null,
   id                   int                  null,
   photo                image(2147483647)    null
)
go

/*==============================================================*/
/* Table: ORD_Capacity_chart                                    */
/*==============================================================*/
create table dbo.ORD_Capacity_chart (
   INTERNAL_CODE        nvarchar(50)         null,
   BILLDATE             datetime             null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   QUANTITY             float                null
)
go

/*==============================================================*/
/* Table: ORD_DETAIL                                            */
/*==============================================================*/
create table dbo.ORD_DETAIL (
   MASTERID             varchar(50)          null,
   DETAILID             varchar(50)          not null,
   BILLNO               varchar(50)          not null,
   Sequence             int                  not null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_CODE_old        varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_NO              varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   PARENT_ITEM_CODE     varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_LOGO            varchar(50)          null,
   ITEM_CD              float                null,
   ITEM_KD              float                null,
   ITEM_GD              float                null,
   ITEM_GYLC            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   DWMJ                 float                null,
   BZFS                 nvarchar(50)         null,
   GRAPHICNO            varchar(50)          null,
   DESCRIPTION          varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   ORD_CGqty            float                null,
   ORD_CLqty            float                null,
   ORD_PCqty            float                null,
   ORD_WGqty            float                null,
   ORD_TCqty            float                null,
   ORD_WGZL             float                null,
   ORD_FPqty            float                null,
   ORD_LHqty            float                null,
   ORD_Sendqty          float                null,
   ORD_SHqty            float                null,
   ORD_HZqty            float                null,
   ORD_THqty            float                null,
   ORD_Acceptqty        float                null,
   ORD_SHDH             varchar(50)          null,
   ORD_TL               varchar(50)          null,
   POSITION             float                null,
   BARCODE              varchar(50)          null,
   REMARK               varchar(50)          null,
   constraint PK_ORDER_DETAIL primary key nonclustered (DETAILID)
)
go

/*==============================================================*/
/* Table: ORD_ITEM_DA                                           */
/*==============================================================*/
create table dbo.ORD_ITEM_DA (
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   ITEM_NO              nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   TYPE_NAME            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   POSITION             nvarchar(50)         null,
   IMAGE                image(2147483647)    null,
   IMAGE_NAME           nvarchar(50)         null,
   Actual_Qty           float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_PUB_ITEM_DA primary key nonclustered (ITEM_INTERNAL_CODE)
)
go

/*==============================================================*/
/* Table: ORD_ITEM_DA_BOM                                       */
/*==============================================================*/
create table dbo.ORD_ITEM_DA_BOM (
   SEQUENCE             int                  not null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_INTERNAL_CODE_CL nvarchar(100)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_CZ              nchar(10)            null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: ORD_MASTER                                            */
/*==============================================================*/
create table dbo.ORD_MASTER (
   MASTERID             varchar(50)          not null,
   BILLNO               varchar(50)          not null,
   MANUAL_BILLNO        varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   FACTORY              varchar(50)          null,
   BILL_TYPE            varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   SCYQ                 text(2147483647)     null,
   BZTYPE               text(2147483647)     null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null,
   REMARK1              varchar(50)          null,
   REMARK2              varchar(50)          null,
   constraint PK_ORDER_MASTER primary key nonclustered (BILLNO)
)
go

/*==============================================================*/
/* Table: ORD_PCDETAIL                                          */
/*==============================================================*/
create table dbo.ORD_PCDETAIL (
   MASTERID             varchar(50)          null,
   DETAILID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   MANUAL_BILLNO        varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   Sequence             int                  null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_CODE_old        varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   PARENT_ITEM_CODE     varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_LOGO            varchar(50)          null,
   ITEM_CD              float                null,
   ITEM_KD              float                null,
   ITEM_GD              float                null,
   ITEM_GYLC            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   DWMJ                 float                null,
   BZFS                 nvarchar(50)         null,
   GRAPHICNO            varchar(50)          null,
   DESCRIPTION          varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   BARCODE              varchar(50)          null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_PCMASTER                                          */
/*==============================================================*/
create table dbo.ORD_PCMASTER (
   BillNo               varchar(50)          not null,
   BILL_DATE            varchar(50)          null,
   "GROUP"              varchar(50)          null,
   MACHINE              varchar(50)          null,
   FACTORY              varchar(50)          null,
   BILL_STATUS          int                  null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null,
   constraint PK_ORDER_PCMASTER primary key nonclustered (BillNo)
)
go

/*==============================================================*/
/* Table: ORD_PURCHASE_DETAIL                                   */
/*==============================================================*/
create table dbo.ORD_PURCHASE_DETAIL (
   DETAILID             varchar(50)          null,
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   Sequence             int                  null,
   SUPPLY_CODE          varchar(50)          null,
   SUPPLY_NAME          varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_CODE_old        varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   PARENT_ITEM_CODE     float                null,
   ITEM_CD              float                null,
   ITEM_KD              float                null,
   ITEM_GD              float                null,
   MEASURE_UNIT         varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   COLOR                varchar(50)          null,
   IMAGE                varchar(50)          null,
   DWMJ                 float                null,
   DESCRIPTION          varchar(50)          null,
   BARCODE              varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             int                  null,
   PAYAMOUNT            float                null,
   TAX_RATE             float                null,
   ORD_CGqty            int                  null,
   ORD_CLqty            int                  null,
   ORD_PCqty            int                  null,
   ORD_WGqty            int                  null,
   ORD_TCqty            int                  null,
   ORD_WGZL             int                  null,
   ORD_FPqty            int                  null,
   ORD_Sendqty          int                  null,
   ORD_SHqty            int                  null,
   ORD_LHqty            int                  null,
   ORD_HZqty            int                  null,
   ORD_THqty            int                  null,
   ORD_Acceptqty        int                  null,
   ORD_SHDH             varchar(50)          null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_PURCHASE_MASTER                                   */
/*==============================================================*/
create table dbo.ORD_PURCHASE_MASTER (
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   FACTORY              varchar(50)          null,
   MANUAL_BILLNO        varchar(50)          null,
   SUPPLY_CODE          varchar(50)          null,
   SUPPLY_NAME          varchar(50)          null,
   BILL_TYPE            varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   SCYQ                 varchar(100)         null,
   BZTYPE               varchar(100)         null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   PROPOSER             varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          varchar(50)          null,
   REMARK               varchar(50)          null,
   REMARK1              varchar(50)          null,
   REMARK2              varchar(50)          null,
   constraint PK_PUR_PURCHASE_MASTER primary key nonclustered (BILLNO)
)
go

/*==============================================================*/
/* Table: ORD_SEND_DETAIL                                       */
/*==============================================================*/
create table dbo.ORD_SEND_DETAIL (
   DETAILID             varchar(50)          null,
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   Sequence             int                  not null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   PARENT_ITEM_CODE     float                null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_CD              float                null,
   ITEM_KD              float                null,
   ITEM_GD              float                null,
   ITEM_SPECIFICATIONS  varchar(50)          null,
   ITEM_MEASURE_UNIT    varchar(50)          null,
   ITEM_GYLC            varchar(50)          null,
   ITEM_POSITION        float                null,
   ITEM_MIN_QTY         float                null,
   ITEM_MAX_QTY         float                null,
   ITEM_IMAGE           varchar(50)          null,
   ITEM_IMAGE_NAME      varchar(50)          null,
   ITEM_DWMJ            float                null,
   ITEM_BARCODE         varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             int                  null,
   ORD_CGqty            int                  null,
   ORD_CLqty            int                  null,
   ORD_PCqty            int                  null,
   ORD_WGqty            int                  null,
   ORD_TCqty            int                  null,
   ORD_WGZL             int                  null,
   ORD_FPqty            int                  null,
   ORD_Sendqty          int                  null,
   ORD_SHqty            int                  null,
   ORD_LHqty            int                  null,
   ORD_HZqty            int                  null,
   ORD_THqty            int                  null,
   ORD_Acceptqty        int                  null,
   ORD_TL               varchar(50)          null,
   ORD_GRAPHICNO        varchar(50)          null,
   ORD_SHDH             varchar(50)          null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_SEND_MASTER                                       */
/*==============================================================*/
create table dbo.ORD_SEND_MASTER (
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   MANUAL_BILLNO        varchar(100)         null,
   Vehicle_CODE         varchar(50)          null,
   Vehicle_NAME         varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   NOW_STATUS           nvarchar(10)         null,
   NOW_DATE             nvarchar(10)         null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   FACTORY              nvarchar(50)         null,
   SALE_NAME            varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               varchar(200)         null,
   constraint PK_ORDER_SEND_MASTER primary key nonclustered (BILLNO)
)
go

/*==============================================================*/
/* Table: ORD_SEND_REMARK                                       */
/*==============================================================*/
create table dbo.ORD_SEND_REMARK (
   MASTERID             varchar(50)          null,
   BILLNO               varchar(50)          not null,
   Sequence             int                  not null,
   MANUAL_BILLNO        varchar(50)          null,
   Vehicle_CODE         varchar(50)          null,
   Vehicle_NAME         varchar(50)          null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(200)         null
)
go

/*==============================================================*/
/* Table: ORD_SEND_SHD                                          */
/*==============================================================*/
create table dbo.ORD_SEND_SHD (
   BillNo               varchar(50)          null,
   BILL_DATE            datetime             null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   PCBH                 varchar(50)          null,
   CLBH                 varchar(50)          null,
   SHJE                 float                null,
   THJE                 float                null,
   HZJE                 float                null,
   LWKKJE               float                null,
   YSJE                 float                null,
   Accepter             varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_SEND_THJL                                         */
/*==============================================================*/
create table dbo.ORD_SEND_THJL (
   DetailID             uniqueidentifier(36) null,
   BillNo               varchar(50)          not null,
   Sequence             varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ZXBJNO               varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   SPECIFICATIONS       nchar(10)            null,
   Quantity             int                  null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_SKJL                                              */
/*==============================================================*/
create table dbo.ORD_SKJL (
   BillNO               nvarchar(10)         null,
   JZBH                 nvarchar(10)         null,
   SKJE                 float                null,
   CREATE_NAME          nvarchar(10)         null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(30)         null
)
go

/*==============================================================*/
/* Table: ORD_TCDETAIL                                          */
/*==============================================================*/
create table dbo.ORD_TCDETAIL (
   DetailID             varchar(50)          null,
   BillNO               varchar(50)          not null,
   Sequence             varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   Quantity             float                null,
   CREATE_DATE          nvarchar(10)         null,
   CREATE_NAME          nvarchar(10)         null,
   REMARK               nvarchar(50)         null,
   constraint PK_ORDER_TCDETAIL primary key nonclustered (BillNO)
)
go

/*==============================================================*/
/* Table: ORD_THDETAIL                                          */
/*==============================================================*/
create table dbo.ORD_THDETAIL (
   DetailID             uniqueidentifier(36) null,
   BillNo               varchar(50)          not null,
   Sequence             varchar(50)          null,
   ItemInternalCode     varchar(50)          null,
   ZXBJNO               varchar(50)          null,
   SHDH                 varchar(50)          null,
   Quantity             int                  null,
   THRQ                 varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: ORD_VEHICLE_DETAIL                                    */
/*==============================================================*/
create table dbo.ORD_VEHICLE_DETAIL (
   TempID               int                  identity,
   BillNo               nvarchar(50)         null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   SALES_CONTRACTNO     nvarchar(50)         null,
   TRUCKER              nvarchar(50)         null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   NET_PRICE            decimal(18,3)        null,
   PRICE                decimal(18,3)        null,
   QTY                  float                null,
   QUANTITY             float                null,
   ACTUAL_QTY           float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   BARCODE              nvarchar(50)         null,
   REMARK               nvarchar(50)         null,
   DESCRIPTION          varchar(200)         null
)
go

/*==============================================================*/
/* Table: ORD_VEHICLE_MASTER                                    */
/*==============================================================*/
create table dbo.ORD_VEHICLE_MASTER (
   BillNo               nvarchar(50)         not null,
   MANUAL_BILLNO        nvarchar(50)         null,
   TRUCKERNO            nvarchar(50)         null,
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nvarchar(50)         null,
   Vehicle_CODE         nvarchar(50)         null,
   Vehicle_NAME         nvarchar(50)         null,
   BILLTYPE             nvarchar(50)         null,
   BILL_STATUS          nvarchar(10)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BILLDATE             datetime             null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(50)         null,
   constraint PK_VEHICLE_ORD_MASTER primary key nonclustered (BillNo)
)
go

/*==============================================================*/
/* Table: ORD_WGDETAIL                                          */
/*==============================================================*/
create table dbo.ORD_WGDETAIL (
   DetailID             varchar(50)          null,
   BillNO               varchar(50)          null,
   Sequence             varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   Quantity             float                null,
   ORD_FPqty            float                null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          nvarchar(10)         null,
   REMARK               nvarchar(50)         null
)
go

/*==============================================================*/
/* Table: ORD_YSJZ                                              */
/*==============================================================*/
create table dbo.ORD_YSJZ (
   DETAILID             varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   SJJZ                 float                null,
   QZZK                 float                null,
   QZYS                 float                null,
   YSJE                 float                null,
   YSWS                 float                null,
   BEGIN_DATE           varchar(50)          null,
   END_DATE             varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          varchar(50)          null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: PARAMETERS                                            */
/*==============================================================*/
create table INFORMATION_SCHEMA.PARAMETERS (
   SPECIFIC_CATALOG     nvarchar(128)        null,
   SPECIFIC_SCHEMA      nvarchar(128)        null,
   SPECIFIC_NAME        sysname(128)         not null,
   ORDINAL_POSITION     int                  not null,
   PARAMETER_MODE       nvarchar(10)         null,
   IS_RESULT            nvarchar(10)         null,
   AS_LOCATOR           nvarchar(10)         null,
   PARAMETER_NAME       sysname(128)         null,
   DATA_TYPE            nvarchar(128)        not null,
   CHARACTER_MAXIMUM_LENGTH int                  null,
   CHARACTER_OCTET_LENGTH int                  null,
   COLLATION_CATALOG    sysname(128)         null,
   COLLATION_SCHEMA     sysname(128)         null,
   COLLATION_NAME       sysname(128)         null,
   CHARACTER_SET_CATALOG sysname(128)         null,
   CHARACTER_SET_SCHEMA sysname(128)         null,
   CHARACTER_SET_NAME   sysname(128)         null,
   NUMERIC_PRECISION    tinyint              null,
   NUMERIC_PRECISION_RADIX smallint             null,
   NUMERIC_SCALE        int                  null,
   DATETIME_PRECISION   smallint             null,
   INTERVAL_TYPE        nvarchar(30)         null,
   INTERVAL_PRECISION   smallint             null,
   USER_DEFINED_TYPE_CATALOG sysname(128)         null,
   USER_DEFINED_TYPE_SCHEMA sysname(128)         null,
   USER_DEFINED_TYPE_NAME sysname(128)         null,
   SCOPE_CATALOG        sysname(128)         null,
   SCOPE_SCHEMA         sysname(128)         null,
   SCOPE_NAME           sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'PARAMETERS'
go

/*==============================================================*/
/* Table: PUB_AREA                                              */
/*==============================================================*/
create table dbo.PUB_AREA (
   COMPANY_CODE         varchar(10)          not null,
   AREA_CODE            varchar(12)          not null,
   AREA_NAME            varchar(20)          null,
   PARENT_AREA_CODE     varchar(12)          null,
   MANAGER              varchar(12)          null,
   ALLOW_USERED         varchar(1)           null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nchar(10)            null,
   UPDATE_DATE          datetime             null,
   constraint PK_PUB_AREA_CODE primary key nonclustered (AREA_CODE)
)
go

/*==============================================================*/
/* Table: PUB_BANK                                              */
/*==============================================================*/
create table dbo.PUB_BANK (
   INTERNAL_CODE        nchar(10)            null,
   BANK_CODE            nvarchar(30)         not null,
   BANK_NAME            nvarchar(40)         null,
   CREATE_NAME          nvarchar(20)         null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(20)         null,
   UPDATE_DATE          nvarchar(20)         null,
   constraint PK_PUB_BANK primary key nonclustered (BANK_CODE)
)
go

/*==============================================================*/
/* Table: PUB_BAR_CODE                                          */
/*==============================================================*/
create table dbo.PUB_BAR_CODE (
   COMPANY_CODE         nvarchar(20)         null,
   ITEM_CODE            nvarchar(20)         null,
   BAR_CODE             nvarchar(30)         null,
   COLOR_CODE           nvarchar(20)         null,
   RULER_CODE           nvarchar(20)         null,
   LENGTH_CODE          nvarchar(20)         null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          nvarchar(50)         null,
   REMARK               nvarchar(100)        null
)
go

/*==============================================================*/
/* Table: PUB_BMTMP                                             */
/*==============================================================*/
create table dbo.PUB_BMTMP (
   BMCODE               nchar(10)            null,
   BMNAME               nchar(10)            null
)
go

/*==============================================================*/
/* Table: PUB_COMPANY                                           */
/*==============================================================*/
create table dbo.PUB_COMPANY (
   COMPANY_CODE         nvarchar(10)         null,
   COMPANY_NAME         nvarchar(60)         null,
   COMPANY_FULLNAME     nchar(200)           null,
   PARENT_COMPANY_CODE  nvarchar(10)         null,
   MANAGER              nvarchar(20)         null,
   ADDRESS              nvarchar(200)        null,
   TELPHONE             nvarchar(20)         null,
   ZIP                  nvarchar(6)          null,
   EMAIL                nvarchar(20)         null,
   HTTP                 nvarchar(20)         null,
   LICENSE              nvarchar(50)         null,
   REGISTER_BANK        nvarchar(60)         null,
   BANK_ACCOUNT         nvarchar(30)         null,
   ALLOW_USED           nvarchar(1)          null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: PUB_COMPANY_TYPE                                      */
/*==============================================================*/
create table dbo.PUB_COMPANY_TYPE (
   INTERNAL_CODE        nvarchar(30)         null,
   COMPANY_CODE         nvarchar(40)         null,
   COMPANY_TYPE         nvarchar(30)         null,
   SN                   numeric(18,1)        null,
   "DESC"               ntext(1073741823)    null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nchar(10)            null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(50)         null
)
go

/*==============================================================*/
/* Table: PUB_CONSTANT                                          */
/*==============================================================*/
create table dbo.PUB_CONSTANT (
   COMPANY_CODE         nvarchar(10)         not null,
   CONST_TYPE           nvarchar(10)         null,
   CONST_CODE           nvarchar(3)          null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          nchar(10)            null,
   UPDATE_NAME          nchar(10)            null,
   UPDATE_DATE          nchar(10)            null,
   REMARK               nchar(100)           null
)
go

/*==============================================================*/
/* Table: PUB_CURRENCY                                          */
/*==============================================================*/
create table dbo.PUB_CURRENCY (
   COMPANY_CODE         nvarchar(10)         null,
   CURRENCY_CODE        nvarchar(4)          null,
   CURRENCY_NAME        nvarchar(20)         null,
   EXCHANGE_RATE        numeric(12,2)        null,
   ALLOW_USERED         nvarchar(1)          null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: PUB_CUSTOM                                            */
/*==============================================================*/
create table dbo.PUB_CUSTOM (
   CUSTOM_CODE          nvarchar(50)         not null,
   CUSTOM_NAME          nvarchar(50)         null,
   CUSTOM_TYPE          nvarchar(50)         null,
   CREDIT_LIMIT         nchar(10)            null,
   ORG_CODE             nvarchar(50)         null,
   PARENT_CUSTOM_CODE   nvarchar(50)         null,
   CREDIT_AMOUNT        float                null,
   CUSTOM_TYPE_CODE     nvarchar(50)         null,
   FULL_NAME            nvarchar(80)         null,
   SALE_MAN             nvarchar(20)         null,
   FAX                  nvarchar(30)         null,
   MANAGER              nvarchar(50)         null,
   ADDRESS              nvarchar(50)         null,
   TELPHIONE            nvarchar(50)         null,
   ZIP                  nvarchar(50)         null,
   EMAIL                nvarchar(50)         null,
   HTTP                 nvarchar(50)         null,
   VIPCARD_CODE         nvarchar(50)         null,
   VIPCARD_NAME         nvarchar(50)         null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          nvarchar(50)         null,
   UPDATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          nvarchar(50)         null,
   REMARK               nvarchar(50)         null,
   constraint PK_PUB_CUSTOM primary key nonclustered (CUSTOM_CODE)
)
go

/*==============================================================*/
/* Table: PUB_CUSTOM_TYPE                                       */
/*==============================================================*/
create table dbo.PUB_CUSTOM_TYPE (
   INTERNAL_CODE        varchar(50)          null,
   TYPE_CODE            varchar(50)          null,
   TYPE_NAME            varchar(50)          null,
   CRDATE_NAME          varchar(50)          null,
   CREATE_DATE          varchar(50)          null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          varchar(50)          null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: PUB_CustomsFees                                       */
/*==============================================================*/
create table dbo.PUB_CustomsFees (
   CustomsfeesID        uniqueidentifier(36) null,
   Customsfees_CODE     nvarchar(50)         not null,
   Customsfees_NAME     nvarchar(50)         null,
   PRICE                float                null,
   CREATE_DATE          varchar(50)          null,
   CREATE_NAME          nvarchar(10)         null,
   UPDATE_DATE          datetime             null,
   UPDATE_NAME          nchar(10)            null,
   REMARK               varchar(50)          null
)
go

/*==============================================================*/
/* Table: PUB_DEPARTMENT                                        */
/*==============================================================*/
create table dbo.PUB_DEPARTMENT (
   INTERNAL_CODE        varchar(50)          null,
   COMPANY_CODE         nvarchar(10)         null,
   DEPARTMENT_CODE      nvarchar(12)         not null,
   DEPARTMENT_NAME      nvarchar(80)         null,
   PARENT_DEPARTMENT_CODE nvarchar(12)         null,
   MANAGER              nvarchar(12)         null,
   TELEPHONE            nvarchar(100)        null,
   ADDRESS              nvarchar(100)        null,
   SHOP_NAME            nvarchar(30)         null,
   SETTLE_DATE          numeric(12,2)        null,
   SIZE                 numeric(12,2)        null,
   EMAIL                nvarchar(50)         null,
   FAX                  nvarchar(50)         null,
   DISCOUNT             numeric(12,2)        null,
   SHIP                 numeric(12,2)        null,
   PPRICE_SHOW          int                  null,
   SALE_METHOD          nvarchar(10)         null,
   ALLOW_USED           nvarchar(1)          null,
   START_DATE           smalldatetime(16)    null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_PUB_DEPARTMENT primary key nonclustered (DEPARTMENT_CODE)
)
go

/*==============================================================*/
/* Table: PUB_DICT                                              */
/*==============================================================*/
create table dbo.PUB_DICT (
   DICT_CODE            nvarchar(50)         not null,
   DICT_NAME            nvarchar(50)         null,
   PARENT_DICT_CODE     nvarchar(50)         null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          datetime             null,
   REMARK               nchar(10)            null,
   constraint PK_PUB_DICT primary key nonclustered (DICT_CODE)
)
go

/*==============================================================*/
/* Table: PUB_FIXEDASSET                                        */
/*==============================================================*/
create table dbo.PUB_FIXEDASSET (
   ITEM_INTERNAL_CODE   varchar(50)          not null,
   FIXEDASSET_CODE      varchar(50)          not null,
   FIXEDASSET_NAME      varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   SUPPLY_CODE          varchar(50)          null,
   SUPPLY_NAME          nchar(10)            null,
   OUT_DATE             datetime             null,
   POWER_RATE           varchar(50)          null,
   BEGIN_DATE           varchar(50)          null,
   END_DATE             varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   QUANTITY             float                null,
   FIXEDASSET_STATUS    nchar(10)            null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   POSITION             varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               varchar(50)          null,
   constraint PK_PUB_FIXEDASSET_1 primary key nonclustered (ITEM_INTERNAL_CODE)
)
go

/*==============================================================*/
/* Table: PUB_ITEM_DETAIL                                       */
/*==============================================================*/
create table dbo.PUB_ITEM_DETAIL (
   SEQUENCE             int                  not null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_INTERNAL_CODE_CL nchar(10)            null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   DESCRIPTION          nvarchar(200)        null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: PUB_ITEM_LIST                                         */
/*==============================================================*/
create table dbo.PUB_ITEM_LIST (
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   TYPE_NAME            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   MIN_QTY              numeric(12,2)        null,
   MAX_QTY              numeric(12,2)        null,
   POSITION             nvarchar(50)         null,
   IMAGE                image(2147483647)    null,
   IMAGE_NAME           nvarchar(50)         null,
   Actual_Qty           float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_PUB_ITEM_LIST primary key nonclustered (ITEM_INTERNAL_CODE)
)
go

/*==============================================================*/
/* Table: PUB_ITEM_PRICE                                        */
/*==============================================================*/
create table dbo.PUB_ITEM_PRICE (
   COMPANY_CODE         nvarchar(10)         null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(30)         not null,
   ITEM_NAME            nvarchar(20)         null,
   COLOR                nvarchar(10)         null,
   MeasureUnit          nvarchar(6)          null,
   PRICE                numeric(12,2)        null,
   START_DATE           smalldatetime(16)    null,
   STOP_DATE            smalldatetime(16)    null,
   CREATE_NAME          nchar(10)            null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_PUB_ITEM_PRICE primary key nonclustered (ITEM_CODE)
)
go

/*==============================================================*/
/* Table: PUB_ITEM_TYPE                                         */
/*==============================================================*/
create table dbo.PUB_ITEM_TYPE (
   INTERNAL_CODE        varchar(50)          null,
   COMPANY_CODE         varchar(50)          null,
   COMPANY_NAME         varchar(50)          null,
   TYPE_CODE            varchar(50)          not null,
   TYPE_NAME            varchar(50)          null,
   PARENT_TYPE_CODE     varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   ALLOW_used           bit                  null,
   constraint PK_PUB_ITEMTYPE primary key nonclustered (TYPE_CODE)
)
go

/*==============================================================*/
/* Table: PUB_PAYMENT_TYPE                                      */
/*==============================================================*/
create table dbo.PUB_PAYMENT_TYPE (
   COMPANY_CODE         nvarchar(30)         null,
   PAYMENT_CODE         nvarchar(30)         not null,
   PAYMENT_NAME         nvarchar(30)         null,
   "DESC"               nvarchar(40)         null,
   CREATE_NAME          nvarchar(20)         null,
   CREATE_DATE          smalldatetime(16)    null,
   UPDATE_NAME          nvarchar(20)         null,
   UPDATE_DATE          smalldatetime(16)    null,
   REMARK               nvarchar(50)         null,
   constraint PK_PUB_PAYMENT_TYPE primary key nonclustered (PAYMENT_CODE)
)
go

/*==============================================================*/
/* Table: PUB_PRICE                                             */
/*==============================================================*/
create table dbo.PUB_PRICE (
   INTERNAL_CODE        nchar(10)            null,
   COMPANY_CODE         nvarchar(10)         null,
   ITEM_CODE            nvarchar(20)         null,
   ITEM_NAME            nchar(10)            null,
   COLOR                nvarchar(10)         null,
   ALL_PRICE            numeric(12,2)        null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          nvarchar(50)         null,
   UPDATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          nvarchar(50)         null
)
go

/*==============================================================*/
/* Table: PUB_SALE                                              */
/*==============================================================*/
create table dbo.PUB_SALE (
   CompanyCode          nvarchar(10)         null,
   EmployeCode          nvarchar(12)         null,
   EmployeeName         nvarchar(20)         null,
   DepartmentCode       nvarchar(12)         null,
   EmployeeType         nvarchar(6)          null,
   IDCardNo             nvarchar(20)         null,
   SociatyNo            nvarchar(20)         null,
   SensusData           nvarchar(1)          null,
   Sex                  nvarchar(6)          null,
   BirthDay             smalldatetime(16)    null,
   Degree               nvarchar(6)          null,
   DegreeCard           nvarchar(1)          null,
   Health               nvarchar(1)          null,
   HealthDate           smalldatetime(16)    null,
   Spinsterhood         nvarchar(1)          null,
   SpinsterhoodDate     smalldatetime(16)    null,
   Idleness             nvarchar(1)          null,
   IdlenessDate         smalldatetime(16)    null,
   Title                nvarchar(20)         null,
   ArrialDay            smalldatetime(16)    null,
   LeaveDay             smalldatetime(16)    null,
   Phone                nvarchar(100)        null,
   Address              nvarchar(60)         null,
   Zip                  nvarchar(6)          null,
   Email                nvarchar(40)         null,
   AllowUsed            nvarchar(1)          null,
   SociatyCode          nvarchar(50)         null,
   SociatyDate          smalldatetime(16)    null,
   SociatyPay           numeric(12,2)        null,
   IndiSWBX             numeric(12,2)        null,
   IndiSYBX             numeric(12,2)        null,
   SociatyComp          nvarchar(50)         null,
   Remark               nvarchar(200)        null,
   EmployeNo            nvarchar(30)         null,
   WorkID               nvarchar(30)         null,
   Situations           nvarchar(20)         null,
   HospitalPay          ntext(1073741823)    null,
   HospitalDate         smalldatetime(16)    null,
   Contract             ntext(1073741823)    null,
   ContractDate         smalldatetime(16)    null,
   PayMounth            nvarchar(20)         null,
   IsZB                 nvarchar(1)          null,
   IsBD                 nvarchar(1)          null,
   LastEdit             varbinary(8)         null
)
go

/*==============================================================*/
/* Table: PUB_STOCK_MASTER                                      */
/*==============================================================*/
create table dbo.PUB_STOCK_MASTER (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nchar(10)            null,
   STOCK_CODE           nvarchar(50)         not null,
   STOCK_NAME           nvarchar(50)         null,
   PARENT_STOCK_CODE    nvarchar(50)         null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(50)         null,
   constraint PK_PUB_StockMaster primary key nonclustered (STOCK_CODE)
)
go

/*==============================================================*/
/* Table: PUB_SUPPLY                                            */
/*==============================================================*/
create table dbo.PUB_SUPPLY (
   INTERNAL_CODE        nvarchar(50)         null,
   SUPPLY_CODE          nvarchar(50)         not null,
   SUPPLY_NAME          nvarchar(50)         null,
   PARENT_SUPPLY_CODE   nvarchar(50)         null,
   TypeCode             nvarchar(50)         null,
   TypeName             nvarchar(50)         null,
   TELPHONE             nvarchar(50)         null,
   TELPHONE1            nvarchar(50)         null,
   FAX                  nvarchar(50)         null,
   EMAIL                nvarchar(50)         null,
   FULLNAME             nvarchar(50)         null,
   ADDRESS              nvarchar(50)         null,
   EASYCODE             nvarchar(50)         null,
   Contact_MAN          nvarchar(50)         null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          datetime             null,
   ALLOW_used           bit                  null,
   REMARK               nvarchar(50)         null
)
go

/*==============================================================*/
/* Table: PUB_VEHICLE                                           */
/*==============================================================*/
create table dbo.PUB_VEHICLE (
   VehicleID            uniqueidentifier(36) null,
   Vehicle_CODE         nvarchar(50)         not null,
   Vehicle_NAME         nvarchar(50)         null,
   MobilePhone          nvarchar(50)         null,
   standard_area        float                null,
   Real_area            float                null,
   weigth               float                null,
   Withcar              nvarchar(30)         null,
   CREATE_DATE          varchar(50)          null,
   CREATE_NAME          nvarchar(10)         null,
   UPDATE_DATE          datetime             null,
   UPDATE_NAME          nchar(10)            null,
   REMARK               varchar(50)          null,
   constraint PK_PUB_VEHICLE primary key nonclustered (Vehicle_CODE)
)
go

/*==============================================================*/
/* Table: REFERENTIAL_CONSTRAINTS                               */
/*==============================================================*/
create table INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS (
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null,
   UNIQUE_CONSTRAINT_CATALOG nvarchar(128)        null,
   UNIQUE_CONSTRAINT_SCHEMA nvarchar(128)        null,
   UNIQUE_CONSTRAINT_NAME sysname(128)         null,
   MATCH_OPTION         varchar(7)           null,
   UPDATE_RULE          varchar(11)          null,
   DELETE_RULE          varchar(11)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'REFERENTIAL_CONSTRAINTS'
go

/*==============================================================*/
/* Table: ROUTINES                                              */
/*==============================================================*/
create table INFORMATION_SCHEMA.ROUTINES (
   SPECIFIC_CATALOG     nvarchar(128)        null,
   SPECIFIC_SCHEMA      nvarchar(128)        null,
   SPECIFIC_NAME        sysname(128)         not null,
   ROUTINE_CATALOG      nvarchar(128)        null,
   ROUTINE_SCHEMA       nvarchar(128)        null,
   ROUTINE_NAME         sysname(128)         not null,
   ROUTINE_TYPE         nvarchar(20)         null,
   MODULE_CATALOG       sysname(128)         null,
   MODULE_SCHEMA        sysname(128)         null,
   MODULE_NAME          sysname(128)         null,
   UDT_CATALOG          sysname(128)         null,
   UDT_SCHEMA           sysname(128)         null,
   UDT_NAME             sysname(128)         null,
   DATA_TYPE            sysname(128)         null,
   CHARACTER_MAXIMUM_LENGTH int                  null,
   CHARACTER_OCTET_LENGTH int                  null,
   COLLATION_CATALOG    sysname(128)         null,
   COLLATION_SCHEMA     sysname(128)         null,
   COLLATION_NAME       sysname(128)         null,
   CHARACTER_SET_CATALOG sysname(128)         null,
   CHARACTER_SET_SCHEMA sysname(128)         null,
   CHARACTER_SET_NAME   sysname(128)         null,
   NUMERIC_PRECISION    tinyint              null,
   NUMERIC_PRECISION_RADIX smallint             null,
   NUMERIC_SCALE        int                  null,
   DATETIME_PRECISION   smallint             null,
   INTERVAL_TYPE        nvarchar(30)         null,
   INTERVAL_PRECISION   smallint             null,
   TYPE_UDT_CATALOG     sysname(128)         null,
   TYPE_UDT_SCHEMA      sysname(128)         null,
   TYPE_UDT_NAME        sysname(128)         null,
   SCOPE_CATALOG        sysname(128)         null,
   SCOPE_SCHEMA         sysname(128)         null,
   SCOPE_NAME           sysname(128)         null,
   MAXIMUM_CARDINALITY  bigint               null,
   DTD_IDENTIFIER       sysname(128)         null,
   ROUTINE_BODY         nvarchar(30)         null,
   ROUTINE_DEFINITION   nvarchar(4000)       null,
   EXTERNAL_NAME        sysname(128)         null,
   EXTERNAL_LANGUAGE    nvarchar(30)         null,
   PARAMETER_STYLE      nvarchar(30)         null,
   IS_DETERMINISTIC     nvarchar(10)         null,
   SQL_DATA_ACCESS      nvarchar(30)         null,
   IS_NULL_CALL         nvarchar(10)         null,
   SQL_PATH             sysname(128)         null,
   SCHEMA_LEVEL_ROUTINE nvarchar(10)         null,
   MAX_DYNAMIC_RESULT_SETS smallint             null,
   IS_USER_DEFINED_CAST nvarchar(10)         null,
   IS_IMPLICITLY_INVOCABLE nvarchar(10)         null,
   CREATED              datetime             not null,
   LAST_ALTERED         datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'ROUTINES'
go

/*==============================================================*/
/* Table: ROUTINE_COLUMNS                                       */
/*==============================================================*/
create table INFORMATION_SCHEMA.ROUTINE_COLUMNS (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          sysname(128)         null,
   ORDINAL_POSITION     int                  not null,
   COLUMN_DEFAULT       nvarchar(4000)       null,
   IS_NULLABLE          varchar(3)           null,
   DATA_TYPE            nvarchar(128)        null,
   CHARACTER_MAXIMUM_LENGTH int                  null,
   CHARACTER_OCTET_LENGTH int                  null,
   NUMERIC_PRECISION    tinyint              null,
   NUMERIC_PRECISION_RADIX smallint             null,
   NUMERIC_SCALE        int                  null,
   DATETIME_PRECISION   smallint             null,
   CHARACTER_SET_CATALOG sysname(128)         null,
   CHARACTER_SET_SCHEMA sysname(128)         null,
   CHARACTER_SET_NAME   sysname(128)         null,
   COLLATION_CATALOG    sysname(128)         null,
   COLLATION_SCHEMA     sysname(128)         null,
   COLLATION_NAME       sysname(128)         null,
   DOMAIN_CATALOG       sysname(128)         null,
   DOMAIN_SCHEMA        sysname(128)         null,
   DOMAIN_NAME          sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'ROUTINE_COLUMNS'
go

/*==============================================================*/
/* Table: SAL_CUSTOM                                            */
/*==============================================================*/
create table dbo.SAL_CUSTOM (
   CompanyCode          nvarchar(10)         null,
   CustomerCode         nvarchar(20)         null,
   CustomerLevel        nvarchar(20)         null,
   Discount             numeric(12,2)        null,
   DiscountGrade        int                  null,
   TradeAmount          numeric(12,2)        null,
   TradeAmountDate      smalldatetime(16)    null,
   TradeGrade           int                  null,
   DueAmount            numeric(12,2)        null,
   DueAmountDate        smalldatetime(16)    null,
   DueGrade             int                  null,
   DueTime              int                  null,
   DueTimeGrade         int                  null,
   DueTimeDate          smalldatetime(16)    null,
   Remark               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: SAL_ITEM_NOW_PRICE                                    */
/*==============================================================*/
create table dbo.SAL_ITEM_NOW_PRICE (
   CompanyCode          nvarchar(10)         not null,
   ItemNo               nvarchar(20)         not null,
   Color                nvarchar(10)         null,
   ItemInternalCode     nvarchar(200)        not null,
   InternalCodeMean     nvarchar(200)        null,
   AllPrice             numeric(12,2)        null,
   WholeSalePrice       numeric(12,2)        null,
   OncePrice            numeric(12,2)        null,
   MeasureUnit          nvarchar(6)          null,
   LastEdit             varbinary(8)         null
)
go

/*==============================================================*/
/* Table: SAL_ITEM_STOCK_DETAIL                                 */
/*==============================================================*/
create table dbo.SAL_ITEM_STOCK_DETAIL (
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ACTUAL_QTY           float                null
)
go

/*==============================================================*/
/* Table: SAL_ITEM_STOCK_DETAIL_BEGIN                           */
/*==============================================================*/
create table dbo.SAL_ITEM_STOCK_DETAIL_BEGIN (
   STOCK_CODE           nvarchar(20)         null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   CREATE_DATE          datetime             null
)
go

/*==============================================================*/
/* Table: SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD                    */
/*==============================================================*/
create table dbo.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD (
   ID                   int                  identity,
   STOCK_CODE           varchar(50)          null,
   CREATE_DATE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null
)
go

/*==============================================================*/
/* Table: SAL_RECEIPT_DETAIL                                    */
/*==============================================================*/
create table dbo.SAL_RECEIPT_DETAIL (
   TempID               int                  identity,
   BillNo               nvarchar(50)         not null,
   SEQUENCE             int                  not null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   QUANTITY             float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   NET_PAYAMOUNT        float                null,
   BARCODE              nvarchar(50)         null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: SAL_RECEIPT_MASTER                                    */
/*==============================================================*/
create table dbo.SAL_RECEIPT_MASTER (
   BillNO               nvarchar(50)         not null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nvarchar(50)         null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   BillTYPE             nvarchar(50)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   INSTOCK_CODE         nvarchar(50)         null,
   INSTOCK_NAME         nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BillDate             datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   PayAcount            float                null,
   REMARK               nvarchar(50)         null,
   constraint PK_SAL_Receipt_Master primary key nonclustered (BillNO)
)
go

/*==============================================================*/
/* Table: SCHEMATA                                              */
/*==============================================================*/
create table INFORMATION_SCHEMA.SCHEMATA (
   CATALOG_NAME         nvarchar(128)        null,
   SCHEMA_NAME          sysname(128)         not null,
   SCHEMA_OWNER         nvarchar(128)        null,
   DEFAULT_CHARACTER_SET_CATALOG sysname(128)         null,
   DEFAULT_CHARACTER_SET_SCHEMA sysname(128)         null,
   DEFAULT_CHARACTER_SET_NAME sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'SCHEMATA'
go

/*==============================================================*/
/* Table: STEEL_DA                                              */
/*==============================================================*/
create table dbo.STEEL_DA (
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(200)        not null,
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_NAME            nvarchar(200)        null,
   ITEM_HD              nvarchar(10)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(200)        null,
   IMAGE                image(2147483647)    null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   TYPE_NAME            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   ITEM_rate            nvarchar(50)         null,
   MEASURE_CODE         nvarchar(20)         null,
   MEASURE_UNIT         nvarchar(20)         null,
   NET_PRICE            float                null default (0),
   PRICE                float                null default (0),
   QTY                  float                null,
   ACTUAL_QTY           decimal(18,3)        null default (0),
   MIN_QTY              numeric(12,2)        null default (0),
   MAX_QTY              numeric(12,2)        null default (0),
   POSITION_CODE        nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   DESCRIPTION          varchar(200)         null,
   BARCODE              varchar(50)          null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          nvarchar(50)         null,
   UPDATE_DATE          datetime             null,
   UPDATE_NAME          nvarchar(50)         null,
   REMARK               nvarchar(200)        null,
   constraint PK_STEEL_MATERIAL primary key nonclustered (ITEM_CODE)
)
go

/*==============================================================*/
/* Table: STEEL_DA_BEGIN                                        */
/*==============================================================*/
create table dbo.STEEL_DA_BEGIN (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   CREATE_DATE          datetime             null
)
go

/*==============================================================*/
/* Table: STEEL_DA_BEGIN_RECORD                                 */
/*==============================================================*/
create table dbo.STEEL_DA_BEGIN_RECORD (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   CREATE_NAME          varchar(50)          null
)
go

/*==============================================================*/
/* Table: STEEL_GG                                              */
/*==============================================================*/
create table dbo.STEEL_GG (
   INTERNAL_CODE        varchar(50)          not null,
   DEPARTMENT_CODE      nvarchar(12)         not null,
   DEPARTMENT_NAME      nvarchar(80)         null,
   PARENT_DEPARTMENT_CODE nvarchar(12)         null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   HD                   float                null,
   KD                   float                null,
   QUANTITY             float                null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_STEEL_GG primary key nonclustered (INTERNAL_CODE)
)
go

/*==============================================================*/
/* Table: STEEL_GG_BOM                                          */
/*==============================================================*/
create table dbo.STEEL_GG_BOM (
   temID                int                  identity,
   INTERNAL_CODE        varchar(50)          null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   KD                   float                null,
   QUANTITY             float                null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: STEEL_RECEIPT_DETAIL                                  */
/*==============================================================*/
create table dbo.STEEL_RECEIPT_DETAIL (
   TempID               int                  identity,
   BillNo               nvarchar(50)         null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   NET_PRICE            decimal(18,3)        null,
   PRICE                decimal(18,3)        null,
   QTY                  float                null,
   QUANTITY             float                null,
   ACTUAL_QTY           float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            decimal(18,4)        null,
   SUPPLY_CODE          nvarchar(50)         null,
   SUPPLY_NAME          nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   BARCODE              nvarchar(50)         null,
   REMARK               nvarchar(50)         null,
   DESCRIPTION          varchar(200)         null
)
go

/*==============================================================*/
/* Table: STEEL_RECEIPT_MASTER                                  */
/*==============================================================*/
create table dbo.STEEL_RECEIPT_MASTER (
   BillNo               nvarchar(50)         not null,
   MANUAL_BILLNO        nvarchar(50)         null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nvarchar(50)         null,
   BILLTYPE             nvarchar(50)         null,
   BILL_STATUS          nvarchar(10)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BILLDATE             datetime             null,
   CREATE_DATE          datetime             null,
   REMARK               nvarchar(50)         null,
   constraint PK_STEEL_RECEIPT_MASTER primary key nonclustered (BillNo)
)
go

/*==============================================================*/
/* Table: SYS_MENU                                              */
/*==============================================================*/
create table dbo.SYS_MENU (
   MENU_CODE            nvarchar(50)         not null,
   MENU_NAME            nvarchar(50)         null,
   MenuID               uniqueidentifier(36) null,
   IMAGE_INDEX          int                  null,
   MENU_UNIT            nvarchar(50)         null,
   PARENT_MENU_CODE     nvarchar(50)         null,
   SysSelect            bit                  null,
   constraint PK_SYS_MENU primary key nonclustered (MENU_CODE)
)
go

/*==============================================================*/
/* Table: SYS_REGISTER                                          */
/*==============================================================*/
create table dbo.SYS_REGISTER (
   COMPANY_CODE         nvarchar(50)         not null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nvarchar(50)         null,
   FULL_NAME            nvarchar(50)         null,
   ADRESS               nvarchar(50)         null,
   SERVICE_PHONE        nchar(10)            null,
   constraint PK_SYS_REGISTER primary key nonclustered (COMPANY_CODE)
)
go

/*==============================================================*/
/* Table: SYS_SYSCS                                             */
/*==============================================================*/
create table dbo.SYS_SYSCS (
   COMPANY_CODE         varchar(50)          null,
   COMPANY_NAME         varchar(50)          null,
   FullName             nvarchar(80)         null,
   Address              varchar(200)         null,
   Phone                nvarchar(50)         null,
   Email                nvarchar(50)         null,
   Fax                  nvarchar(50)         null,
   SHDCNT               int                  null,
   ITEM_CODE_LENGTH     varchar(50)          null,
   Billasstock          bit                  null,
   MAYLH                nvarchar(1)          null,
   ServiceTelphone      varchar(50)          null,
   CREATE_NAME          nvarchar(50)         null,
   CREATE_DATE          nvarchar(50)         null,
   REMARK               nvarchar(50)         null
)
go

/*==============================================================*/
/* Table: SYS_USER                                              */
/*==============================================================*/
create table dbo.SYS_USER (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   USER_CODE            nvarchar(12)         not null,
   USER_NAME            nvarchar(20)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   department           nvarchar(50)         null,
   PARENT_DEPARTMENT_CODE nvarchar(50)         null,
   PPRICE_SHOW          bit                  null,
   PASSWORD             nvarchar(20)         null,
   Description          nvarchar(50)         null,
   EmployeeCode         nvarchar(12)         null,
   AllowUsed            text(2147483647)     null,
   isLicenceAudit       nvarchar(1)          null,
   UserType             nvarchar(20)         null,
   LastEdit             varbinary(8)         null,
   AuditDate            datetime             null,
   constraint PK_SYS_USER primary key nonclustered (USER_CODE)
)
go

/*==============================================================*/
/* Table: SYS_USER_DATARIGHT                                    */
/*==============================================================*/
create table dbo.SYS_USER_DATARIGHT (
   MENU_CODE            nvarchar(50)         null,
   MENU_NAME            nvarchar(50)         null,
   MENU_UNIT            nvarchar(50)         null,
   PARENT_MENU_CODE     nvarchar(50)         null,
   USER_CODE            nvarchar(50)         not null,
   IMAGE_INDEX          int                  null,
   tempid               int                  identity
)
go

/*==============================================================*/
/* Table: SYS_USER_GROUP                                        */
/*==============================================================*/
create table dbo.SYS_USER_GROUP (
   CompanyCode          nvarchar(10)         null,
   UserGroupNo          nvarchar(12)         null,
   UserGroupName        nvarchar(20)         null,
   Description          nvarchar(50)         null,
   AllowUsed            nvarchar(1)          null
)
go

/*==============================================================*/
/* Table: SYS_VERSION                                           */
/*==============================================================*/
create table dbo.SYS_VERSION (
   VERSION              varchar(50)          null
)
go

/*==============================================================*/
/* Table: TABLES                                                */
/*==============================================================*/
create table INFORMATION_SCHEMA.TABLES (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         sysname(128)         null,
   TABLE_NAME           sysname(128)         not null,
   TABLE_TYPE           varchar(10)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'TABLES'
go

/*==============================================================*/
/* Table: TABLE_CONSTRAINTS                                     */
/*==============================================================*/
create table INFORMATION_SCHEMA.TABLE_CONSTRAINTS (
   CONSTRAINT_CATALOG   nvarchar(128)        null,
   CONSTRAINT_SCHEMA    nvarchar(128)        null,
   CONSTRAINT_NAME      sysname(128)         not null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         null,
   CONSTRAINT_TYPE      varchar(11)          null,
   IS_DEFERRABLE        varchar(2)           not null,
   INITIALLY_DEFERRED   varchar(2)           not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'TABLE_CONSTRAINTS'
go

/*==============================================================*/
/* Table: TABLE_PRIVILEGES                                      */
/*==============================================================*/
create table INFORMATION_SCHEMA.TABLE_PRIVILEGES (
   GRANTOR              nvarchar(128)        null,
   GRANTEE              nvarchar(128)        null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   PRIVILEGE_TYPE       varchar(10)          null,
   IS_GRANTABLE         varchar(3)           null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'TABLE_PRIVILEGES'
go

/*==============================================================*/
/* Table: VIEWS                                                 */
/*==============================================================*/
create table INFORMATION_SCHEMA.VIEWS (
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   VIEW_DEFINITION      nvarchar(4000)       null,
   CHECK_OPTION         varchar(7)           null,
   IS_UPDATABLE         varchar(2)           not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'VIEWS'
go

/*==============================================================*/
/* Table: VIEW_COLUMN_USAGE                                     */
/*==============================================================*/
create table INFORMATION_SCHEMA.VIEW_COLUMN_USAGE (
   VIEW_CATALOG         nvarchar(128)        null,
   VIEW_SCHEMA          nvarchar(128)        null,
   VIEW_NAME            sysname(128)         not null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null,
   COLUMN_NAME          sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'VIEW_COLUMN_USAGE'
go

/*==============================================================*/
/* Table: VIEW_TABLE_USAGE                                      */
/*==============================================================*/
create table INFORMATION_SCHEMA.VIEW_TABLE_USAGE (
   VIEW_CATALOG         nvarchar(128)        null,
   VIEW_SCHEMA          nvarchar(128)        null,
   VIEW_NAME            sysname(128)         not null,
   TABLE_CATALOG        nvarchar(128)        null,
   TABLE_SCHEMA         nvarchar(128)        null,
   TABLE_NAME           sysname(128)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'INFORMATION_SCHEMA', 'table', 'VIEW_TABLE_USAGE'
go

/*==============================================================*/
/* Table: VIP_GRADE                                             */
/*==============================================================*/
create table dbo.VIP_GRADE (
   COMPANY_CODE         varchar(40)          null,
   GRADE_CODE           varchar(40)          null,
   GRADE_NAME           varchar(20)          null,
   GRADE_TYPE           varchar(30)          null,
   indate               datetime             null,
   outdate              datetime             null,
   LOW_SALES            numeric(30,2)        null,
   TOTAL_SALES          numeric(30,2)        null,
   zsrgrade             numeric(10,2)        null,
   standrate            numeric(5,2)         null,
   specialrate          numeric(5,2)         null,
   birthdayrate         numeric(5,2)         null,
   birthdayspsrate      numeric(5,2)         null,
   year_option          numeric(5,2)         null,
   run                  varchar(10)          null,
   CREATE_NAME          varchar(20)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(20)          null,
   UPDATE_DATE          datetime             null,
   REMARK               varchar(100)         null
)
go

/*==============================================================*/
/* Table: VIP_INFO                                              */
/*==============================================================*/
create table dbo.VIP_INFO (
   COMPANY_CODE         varchar(50)          not null,
   USER_CODE            varchar(50)          null,
   USER_NAME            varchar(50)          null,
   VIP_CARD_CODE        varchar(50)          not null,
   VIP_TEMP_CARD_CODE   numeric(18)          identity,
   PASSWORD             varchar(10)          null,
   BEGIN_DATE           datetime             null,
   END_DATE             datetime             null,
   VIP_TYPE             varchar(20)          null default NULL,
   TOTAL_SALES          numeric(30,2)        null,
   salesno              varchar(200)         null,
   CREATE_NAME          varchar(20)          null,
   CREATE_DATE          smalldatetime(16)    null default getdate(),
   UPDATE_NAME          varchar(20)          null,
   UPDATE_DATE          smalldatetime(16)    null,
   REMARK               varchar(100)         null,
   constraint PK_VIP_Info primary key nonclustered (VIP_CARD_CODE)
)
go

/*==============================================================*/
/* Table: VI_CL_RECEIPT_DETAIL                                  */
/*==============================================================*/
create table dbo.VI_CL_RECEIPT_DETAIL (
   BillNo               nvarchar(50)         not null,
   BILLDATE             datetime             null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nvarchar(50)         null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(200)        null,
   ITEM_JZ              float                null,
   ITEM_COLOR           nvarchar(200)        null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_TYPE            nvarchar(50)         null,
   TYPE_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                decimal(18,3)        null,
   QTY                  float                null,
   QUANTITY             float                null,
   ACTUAL_QTY           float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   POSITION             nvarchar(50)         null,
   BARCODE              varchar(50)          null,
   BILLTYPE             nvarchar(50)         null,
   BILLTYPE1            varchar(4)           not null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   BILL_STATUS          nvarchar(10)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   CREATE_DATE          datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_CL_RECEIPT_DETAIL'
go

/*==============================================================*/
/* Table: VI_ORD_DETAIL                                         */
/*==============================================================*/
create table dbo.VI_ORD_DETAIL (
   MASTERID             varchar(50)          not null,
   DETAILID             varchar(50)          not null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   FACTORY              varchar(50)          null,
   BILLNO               varchar(50)          not null,
   Sequence             int                  not null,
   MANUAL_BILLNO        varchar(50)          null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_CODE_old        varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   PARENT_ITEM_CODE     varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_CD              float                null,
   ITEM_KD              float                null,
   ITEM_GD              float                null,
   SPECIFICATIONS       varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   ITEM_GYLC            varchar(50)          null,
   POSITION             float                null,
   DWMJ                 float                null,
   BARCODE              varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   ORD_CGqty            float                null,
   ORD_CLqty            float                null,
   ORD_PCqty            float                null,
   ORD_WGqty            float                null,
   ORD_TCqty            float                null,
   ORD_WGZL             float                null,
   ORD_FPqty            float                null,
   ORD_Sendqty          float                null,
   ORD_SHqty            float                null,
   ORD_LHqty            float                null,
   ORD_HZqty            float                null,
   ORD_THqty            float                null,
   ORD_Acceptqty        float                null,
   ORD_TL               varchar(50)          null,
   ORD_SHDH             varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   SCYQ                 varchar(100)         null,
   BZTYPE               varchar(100)         null,
   BZFS                 nvarchar(50)         null,
   BILL_TYPE            varchar(50)          null,
   REMARK               varchar(50)          null,
   REMARK1              varchar(50)          null,
   REMARK2              varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   ITEM_LOGO            varchar(50)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_ORD_DETAIL'
go

/*==============================================================*/
/* Table: VI_ORD_SEND_DETAIL                                    */
/*==============================================================*/
create table dbo.VI_ORD_SEND_DETAIL (
   BILLNO               varchar(50)          not null,
   MANUAL_BILLNO        varchar(100)         null,
   Vehicle_NAME         varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               varchar(200)         null,
   Vehicle_CODE         varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_SPECIFICATIONS  varchar(50)          null,
   ITEM_MEASURE_UNIT    varchar(50)          null,
   ITEM_GYLC            varchar(50)          null,
   ITEM_POSITION        float                null,
   ITEM_MIN_QTY         float                null,
   SALE_NAME            varchar(50)          null,
   FACTORY              nvarchar(50)         null,
   NOW_STATUS           nvarchar(10)         null,
   NOW_DATE             nvarchar(10)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_ORD_SEND_DETAIL'
go

/*==============================================================*/
/* Table: VI_SAL_ITEM_STOCK_DETAIL                              */
/*==============================================================*/
create table dbo.VI_SAL_ITEM_STOCK_DETAIL (
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   MIN_QTY              numeric(12,2)        null,
   MAX_QTY              numeric(12,2)        null,
   BARCODE              varchar(50)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_SAL_ITEM_STOCK_DETAIL'
go

/*==============================================================*/
/* Table: VI_SAL_ITEM_STOCK_DETAIL_BEGIN                        */
/*==============================================================*/
create table dbo.VI_SAL_ITEM_STOCK_DETAIL_BEGIN (
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   NET_PRICE            float                null,
   STOCK_CODE           nvarchar(20)         null,
   STOCK_NAME           nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   PRICE                float                null,
   ITEM_COLOR           nvarchar(50)         null,
   CREATE_DATE          datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_SAL_ITEM_STOCK_DETAIL_BEGIN'
go

/*==============================================================*/
/* Table: VI_SAL_RECEIPT_DETAIL                                 */
/*==============================================================*/
create table dbo.VI_SAL_RECEIPT_DETAIL (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nvarchar(50)         null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   BillNO               nvarchar(50)         null,
   BillTYPE             nvarchar(50)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   INSTOCK_CODE         nvarchar(50)         null,
   INSTOCK_NAME         nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BillDate             datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   ITEM_INTERNAL_CODE   nvarchar(100)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   QUANTITY             float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   NET_PAYAMOUNT        float                null,
   ITEM_COLOR           nvarchar(50)         null,
   BARCODE              varchar(50)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'VI_SAL_RECEIPT_DETAIL'
go

/*==============================================================*/
/* Table: Vi_ORD_BOM                                            */
/*==============================================================*/
create table dbo.Vi_ORD_BOM (
   MASTERID             varchar(50)          not null,
   DETAILID             varchar(50)          not null,
   BILLNO               varchar(50)          not null,
   FACTORY              varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   MANUAL_BILLNO        varchar(50)          null,
   BILL_TYPE            varchar(50)          null,
   BILL_DATE            datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   SCYQ                 text(2147483647)     null,
   BZTYPE               text(2147483647)     null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   BZFS                 nvarchar(50)         null,
   GRAPHICNO            varchar(50)          null,
   DESCRIPTION          varchar(50)          null,
   PRICE                float                null,
   NET_PRICE            float                null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   SEQUENCE             int                  null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_CZ              nchar(10)            null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   Quantity             float                null,
   total_quantity       float                null,
   REMARK               nvarchar(200)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_ORD_BOM'
go

/*==============================================================*/
/* Table: Vi_ORD_PCDETAIL                                       */
/*==============================================================*/
create table dbo.Vi_ORD_PCDETAIL (
   BillNo               varchar(50)          not null,
   BILL_DATE            varchar(50)          null,
   "GROUP"              varchar(50)          null,
   MACHINE              varchar(50)          null,
   REMARK               varchar(50)          null,
   MASTERID             varchar(50)          null,
   DETAILID             varchar(50)          null,
   MANUAL_BILLNO        varchar(50)          null,
   CUSTOM_CODE          varchar(50)          null,
   CUSTOM_NAME          varchar(50)          null,
   Sequence             int                  null,
   ITEM_INTERNAL_CODE   varchar(50)          null,
   ITEM_CODE            varchar(50)          null,
   ITEM_CODE_old        varchar(50)          null,
   ITEM_NAME            varchar(50)          null,
   ITEM_COLOR           varchar(50)          null,
   PARENT_ITEM_CODE     varchar(50)          null,
   ITEM_TYPE            varchar(50)          null,
   ITEM_LOGO            varchar(50)          null,
   ITEM_GYLC            varchar(50)          null,
   SPECIFICATIONS       varchar(50)          null,
   MEASURE_UNIT         varchar(50)          null,
   DWMJ                 float                null,
   BZFS                 nvarchar(50)         null,
   GRAPHICNO            varchar(50)          null,
   DESCRIPTION          varchar(50)          null,
   NET_PRICE            float                null,
   PRICE                float                null,
   Quantity             float                null,
   BARCODE              varchar(50)          null,
   BILL_STATUS          int                  null,
   STOCK_CODE           varchar(50)          null,
   STOCK_NAME           varchar(50)          null,
   DEPARTMENT_CODE      varchar(50)          null,
   DEPARTMENT_NAME      varchar(50)          null,
   CREATE_CODE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_ORD_PCDETAIL'
go

/*==============================================================*/
/* Table: Vi_SAL_TOTAL                                          */
/*==============================================================*/
create table dbo.Vi_SAL_TOTAL (
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   BillDate             datetime             null,
   PAYAMOUNT            float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_SAL_TOTAL'
go

/*==============================================================*/
/* Table: Vi_STEEL_Chart                                        */
/*==============================================================*/
create table dbo.Vi_STEEL_Chart (
   SUPPLY_NAME          nvarchar(50)         null,
   ACTUAL_QTY           float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_STEEL_Chart'
go

/*==============================================================*/
/* Table: Vi_STEEL_RECEIPT_DETAIL                               */
/*==============================================================*/
create table dbo.Vi_STEEL_RECEIPT_DETAIL (
   BillNo               nvarchar(50)         not null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(200)        not null,
   ITEM_CODE            nvarchar(50)         not null,
   ITEM_NAME            nvarchar(200)        null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   NET_PRICE            float                null,
   PRICE                decimal(18,3)        null,
   QUANTITY             float                null,
   ACTUAL_QTY           float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   CUSTOM_CODE          nchar(10)            null,
   CUSTOM_NAME          nvarchar(50)         null,
   BILLTYPE             nvarchar(50)         null,
   BILLTYPE1            varchar(4)           not null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   BILL_STATUS          nvarchar(10)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BILLDATE             datetime             null,
   CREATE_DATE          datetime             null,
   QTY                  float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_STEEL_RECEIPT_DETAIL'
go

/*==============================================================*/
/* Table: Vi_WL_RECEIPT_DETAIL                                  */
/*==============================================================*/
create table dbo.Vi_WL_RECEIPT_DETAIL (
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nvarchar(50)         null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   BillNO               nvarchar(50)         null,
   BillTYPE             nvarchar(50)         null,
   BILLTYPE1            varchar(4)           not null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   INSTOCK_CODE         nvarchar(50)         null,
   INSTOCK_NAME         nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BillDate             datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   ITEM_INTERNAL_CODE   nvarchar(100)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   QUANTITY             float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   NET_PAYAMOUNT        float                null,
   ITEM_COLOR           nvarchar(50)         null,
   BARCODE              varchar(50)          null,
   POSITION_CODE        nvarchar(50)         null,
   POSITION             nvarchar(50)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_WL_RECEIPT_DETAIL'
go

/*==============================================================*/
/* Table: Vi_WL_STOCK_DETAIL                                    */
/*==============================================================*/
create table dbo.Vi_WL_STOCK_DETAIL (
   STOCK_CODE           nvarchar(50)         not null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   MIN_QTY              numeric(12,2)        null,
   MAX_QTY              numeric(12,2)        null,
   BARCODE              varchar(50)          null,
   TYPE_NAME            nvarchar(50)         null,
   ITEM_CZ              nchar(10)            null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_GYLC            nvarchar(200)        null,
   DICT_CODE            nvarchar(50)         null,
   POSITION_CODE        nvarchar(50)         null,
   POSITION             nvarchar(50)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_WL_STOCK_DETAIL'
go

/*==============================================================*/
/* Table: Vi_WL_STOCK_DETAIL_BEGIN                              */
/*==============================================================*/
create table dbo.Vi_WL_STOCK_DETAIL_BEGIN (
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   NET_PRICE            float                null,
   STOCK_CODE           nvarchar(20)         null,
   STOCK_NAME           nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   PRICE                float                null,
   ITEM_COLOR           nvarchar(50)         null,
   CREATE_DATE          datetime             null,
   BARCODE              varchar(50)          null,
   TYPE_NAME            nvarchar(50)         null,
   ITEM_CZ              nchar(10)            null,
   ITEM_JZ              float                null,
   ITEM_GYLC            nvarchar(200)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'dbo', 'table', 'Vi_WL_STOCK_DETAIL_BEGIN'
go

/*==============================================================*/
/* Table: WL_DA                                                 */
/*==============================================================*/
create table dbo.WL_DA (
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_CODE_old        nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   ITEM_CZ              nchar(10)            null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_GYLC            nvarchar(200)        null,
   DICT_CODE            nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   TYPE_NAME            nvarchar(50)         null,
   NET_PRICE            float                null default (0),
   PRICE                float                null default (0),
   MIN_QTY              numeric(12,2)        null,
   MAX_QTY              numeric(12,2)        null,
   POSITION_CODE        nvarchar(50)         null,
   POSITION             nvarchar(50)         null,
   IMAGE                image(2147483647)    null,
   IMAGE_NAME           nvarchar(50)         null,
   Actual_Qty           float                null,
   BARCODE              varchar(50)          null,
   DESCRIPTION          varchar(200)         null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null,
   constraint PK_WL_DA primary key nonclustered (ITEM_INTERNAL_CODE)
)
go

/*==============================================================*/
/* Table: WL_DA_BOM                                             */
/*==============================================================*/
create table dbo.WL_DA_BOM (
   SEQUENCE             int                  not null,
   ITEM_INTERNAL_CODE   nvarchar(100)        not null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(200)        null,
   MEASURE_UNIT         nvarchar(6)          null,
   ITEM_CZ              nchar(10)            null,
   ITEM_LH              float                null,
   ITEM_LK              float                null,
   ITEM_BJ              float                null,
   ITEM_JZ              float                null,
   ITEM_HZ              float                null,
   ITEM_rate            nvarchar(50)         null,
   ITEM_GYLC            nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   MIN_QTY              numeric(12,2)        null,
   MAX_QTY              numeric(12,2)        null,
   POSITION             nvarchar(50)         null,
   IMAGE                image(2147483647)    null,
   IMAGE_NAME           nvarchar(50)         null,
   Quantity             float                null,
   BARCODE              varchar(50)          null,
   CREATE_NAME          varchar(50)          null,
   CREATE_DATE          datetime             null,
   UPDATE_NAME          varchar(50)          null,
   UPDATE_DATE          datetime             null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: WL_RECEIPT_DETAIL                                     */
/*==============================================================*/
create table dbo.WL_RECEIPT_DETAIL (
   TempID               int                  identity,
   BillNO               nvarchar(50)         not null,
   SEQUENCE             int                  null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   PARENT_ITEM_CODE     nvarchar(50)         null,
   ITEM_TYPE            nvarchar(50)         null,
   ITEM_COLOR           nvarchar(50)         null,
   SPECIFICATIONS       nvarchar(50)         null,
   MEASURE_UNIT         nvarchar(50)         null,
   NET_PRICE            float                null,
   PRICE                float                null,
   ACTUAL_QTY           float                null,
   QUANTITY             float                null,
   YKQUANTITY           float                null,
   PAYAMOUNT            float                null,
   NET_PAYAMOUNT        float                null,
   BARCODE              nvarchar(50)         null,
   REMARK               nvarchar(200)        null
)
go

/*==============================================================*/
/* Table: WL_RECEIPT_MASTER                                     */
/*==============================================================*/
create table dbo.WL_RECEIPT_MASTER (
   BillNO               nvarchar(50)         not null,
   COMPANY_CODE         nvarchar(50)         null,
   COMPANY_NAME         nvarchar(50)         null,
   PARENT_COMPANY_CODE  nvarchar(50)         null,
   CUSTOM_CODE          nvarchar(50)         null,
   CUSTOM_NAME          nvarchar(50)         null,
   MANUAL_BILLNO        nvarchar(50)         null,
   BillTYPE             nvarchar(50)         null,
   STOCK_CODE           nvarchar(50)         null,
   STOCK_NAME           nvarchar(50)         null,
   INSTOCK_CODE         nvarchar(50)         null,
   INSTOCK_NAME         nvarchar(50)         null,
   DEPARTMENT_CODE      nvarchar(50)         null,
   DEPARTMENT_NAME      nvarchar(50)         null,
   EMPLOYEE_CODE        nvarchar(50)         null,
   EMPLOYEE_NAME        nvarchar(50)         null,
   BillDate             datetime             null,
   BILL_STATUS          nvarchar(10)         null,
   PayAcount            float                null,
   REMARK               nvarchar(50)         null,
   constraint PK_STE_RECEIPT_MASTER primary key nonclustered (BillNO)
)
go

/*==============================================================*/
/* Table: WL_STOCK_BEGIN                                        */
/*==============================================================*/
create table dbo.WL_STOCK_BEGIN (
   STOCK_CODE           nvarchar(20)         null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(200)        null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ACTUAL_QTY           float                null,
   CREATE_DATE          datetime             null
)
go

/*==============================================================*/
/* Table: WL_STOCK_BEGIN_RECORD                                 */
/*==============================================================*/
create table dbo.WL_STOCK_BEGIN_RECORD (
   ID                   int                  identity,
   STOCK_CODE           varchar(50)          null,
   CREATE_DATE          varchar(50)          null,
   CREATE_NAME          varchar(50)          null
)
go

/*==============================================================*/
/* Table: WL_STOCK_DETAIL                                       */
/*==============================================================*/
create table dbo.WL_STOCK_DETAIL (
   STOCK_CODE           nvarchar(50)         not null,
   STOCK_NAME           nvarchar(50)         null,
   ITEM_INTERNAL_CODE   nvarchar(50)         null,
   ITEM_CODE            nvarchar(50)         null,
   ITEM_NAME            nvarchar(50)         null,
   ACTUAL_QTY           float                null
)
go

/*==============================================================*/
/* Table: all_columns                                           */
/*==============================================================*/
create table sys.all_columns (
   object_id            int                  not null,
   name                 sysname(128)         null,
   column_id            int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_ansi_padded       bit                  not null,
   is_rowguidcol        bit                  not null,
   is_identity          bit                  not null,
   is_computed          bit                  not null,
   is_filestream        bit                  not null,
   is_replicated        bit                  null,
   is_non_sql_subscribed bit                  null,
   is_merge_published   bit                  null,
   is_dts_replicated    bit                  null,
   is_xml_document      bit                  not null,
   xml_collection_id    int                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   is_sparse            bit                  null,
   is_column_set        bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'all_columns'
go

/*==============================================================*/
/* Table: all_objects                                           */
/*==============================================================*/
create table sys.all_objects (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'all_objects'
go

/*==============================================================*/
/* Table: all_parameters                                        */
/*==============================================================*/
create table sys.all_parameters (
   object_id            int                  not null,
   name                 sysname(128)         null,
   parameter_id         int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   is_output            bit                  not null,
   is_cursor_ref        bit                  not null,
   has_default_value    bit                  not null,
   is_xml_document      bit                  not null,
   default_value        sql_variant          null,
   xml_collection_id    int                  not null,
   is_readonly          bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'all_parameters'
go

/*==============================================================*/
/* Table: all_sql_modules                                       */
/*==============================================================*/
create table sys.all_sql_modules (
   object_id            int                  not null,
   definition           ntext(1073741823)    null,
   uses_ansi_nulls      bit                  null,
   uses_quoted_identifier bit                  null,
   is_schema_bound      bit                  null,
   uses_database_collation bit                  null,
   is_recompiled        bit                  null,
   null_on_null_input   bit                  null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'all_sql_modules'
go

/*==============================================================*/
/* Table: all_views                                             */
/*==============================================================*/
create table sys.all_views (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   is_replicated        bit                  null,
   has_replication_filter bit                  null,
   has_opaque_metadata  bit                  not null,
   has_unchecked_assembly_data bit                  not null,
   with_check_option    bit                  not null,
   is_date_correlation_view bit                  not null,
   is_tracked_by_cdc    bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'all_views'
go

/*==============================================================*/
/* Table: allocation_units                                      */
/*==============================================================*/
create table sys.allocation_units (
   allocation_unit_id   bigint               not null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   container_id         bigint               not null,
   data_space_id        int                  null,
   total_pages          bigint               not null,
   used_pages           bigint               not null,
   data_pages           bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'allocation_units'
go

/*==============================================================*/
/* Table: assemblies                                            */
/*==============================================================*/
create table sys.assemblies (
   name                 sysname(128)         not null,
   principal_id         int                  null,
   assembly_id          int                  not null,
   clr_name             nvarchar(4000)       null,
   permission_set       tinyint              null,
   permission_set_desc  nvarchar(60)         null,
   is_visible           bit                  not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_user_defined      bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'assemblies'
go

/*==============================================================*/
/* Table: assembly_files                                        */
/*==============================================================*/
create table sys.assembly_files (
   assembly_id          int                  not null,
   name                 nvarchar(260)        null,
   file_id              int                  not null,
   content              image(2147483647)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'assembly_files'
go

/*==============================================================*/
/* Table: assembly_modules                                      */
/*==============================================================*/
create table sys.assembly_modules (
   object_id            int                  not null,
   assembly_id          int                  not null,
   assembly_class       nvarchar(128)        null,
   assembly_method      nvarchar(128)        null,
   null_on_null_input   bit                  null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'assembly_modules'
go

/*==============================================================*/
/* Table: assembly_references                                   */
/*==============================================================*/
create table sys.assembly_references (
   assembly_id          int                  not null,
   referenced_assembly_id int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'assembly_references'
go

/*==============================================================*/
/* Table: assembly_types                                        */
/*==============================================================*/
create table sys.assembly_types (
   name                 sysname(128)         not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   schema_id            int                  not null,
   principal_id         int                  null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_user_defined      bit                  not null,
   is_assembly_type     bit                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   assembly_id          int                  not null,
   assembly_class       sysname(128)         null,
   is_binary_ordered    bit                  null,
   is_fixed_length      bit                  null,
   prog_id              nvarchar(40)         null,
   assembly_qualified_name nvarchar(4000)       null,
   is_table_type        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'assembly_types'
go

/*==============================================================*/
/* Table: asymmetric_keys                                       */
/*==============================================================*/
create table sys.asymmetric_keys (
   name                 sysname(128)         not null,
   principal_id         int                  null,
   asymmetric_key_id    int                  not null,
   pvt_key_encryption_type char(2)              not null,
   pvt_key_encryption_type_desc nvarchar(60)         null,
   thumbprint           varbinary(32)        not null,
   algorithm            char(2)              not null,
   algorithm_desc       nvarchar(60)         null,
   key_length           int                  not null,
   sid                  varbinary(85)        null,
   string_sid           nvarchar(128)        null,
   public_key           image(2147483647)    not null,
   attested_by          nvarchar(260)        null,
   provider_type        nvarchar(60)         null,
   cryptographic_provider_guid uniqueidentifier(36) null,
   cryptographic_provider_algid sql_variant          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'asymmetric_keys'
go

/*==============================================================*/
/* Table: backup_devices                                        */
/*==============================================================*/
create table sys.backup_devices (
   name                 sysname(128)         not null,
   type                 tinyint              null,
   type_desc            nvarchar(60)         null,
   physical_name        nvarchar(260)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'backup_devices'
go

/*==============================================================*/
/* Table: certificates                                          */
/*==============================================================*/
create table sys.certificates (
   name                 sysname(128)         not null,
   certificate_id       int                  not null,
   principal_id         int                  null,
   pvt_key_encryption_type char(2)              not null,
   pvt_key_encryption_type_desc nvarchar(60)         null,
   is_active_for_begin_dialog bit                  null,
   issuer_name          nvarchar(442)        null,
   cert_serial_number   nvarchar(64)         null,
   sid                  varbinary(85)        null,
   string_sid           nvarchar(128)        null,
   subject              nvarchar(4000)       null,
   expiry_date          datetime             null,
   start_date           datetime             null,
   thumbprint           varbinary(32)        not null,
   attested_by          nvarchar(260)        null,
   pvt_key_last_backup_date datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'certificates'
go

/*==============================================================*/
/* Table: change_tracking_databases                             */
/*==============================================================*/
create table sys.change_tracking_databases (
   database_id          int                  not null,
   is_auto_cleanup_on   tinyint              null,
   retention_period     int                  null,
   retention_period_units tinyint              null,
   retention_period_units_desc nvarchar(60)         null,
   max_cleanup_version  bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'change_tracking_databases'
go

/*==============================================================*/
/* Table: change_tracking_tables                                */
/*==============================================================*/
create table sys.change_tracking_tables (
   object_id            int                  not null,
   is_track_columns_updated_on bit                  not null,
   min_valid_version    bigint               null,
   begin_version        bigint               null,
   cleanup_version      bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'change_tracking_tables'
go

/*==============================================================*/
/* Table: check_constraints                                     */
/*==============================================================*/
create table sys.check_constraints (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   is_disabled          bit                  not null,
   is_not_for_replication bit                  not null,
   is_not_trusted       bit                  not null,
   parent_column_id     int                  not null,
   definition           ntext(1073741823)    null,
   uses_database_collation bit                  null,
   is_system_named      bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'check_constraints'
go

/*==============================================================*/
/* Table: column_type_usages                                    */
/*==============================================================*/
create table sys.column_type_usages (
   object_id            int                  not null,
   column_id            int                  not null,
   user_type_id         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'column_type_usages'
go

/*==============================================================*/
/* Table: column_xml_schema_collection_usages                   */
/*==============================================================*/
create table sys.column_xml_schema_collection_usages (
   object_id            int                  not null,
   column_id            int                  not null,
   xml_collection_id    int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'column_xml_schema_collection_usages'
go

/*==============================================================*/
/* Table: columns                                               */
/*==============================================================*/
create table sys.columns (
   object_id            int                  not null,
   name                 sysname(128)         null,
   column_id            int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_ansi_padded       bit                  not null,
   is_rowguidcol        bit                  not null,
   is_identity          bit                  not null,
   is_computed          bit                  not null,
   is_filestream        bit                  not null,
   is_replicated        bit                  null,
   is_non_sql_subscribed bit                  null,
   is_merge_published   bit                  null,
   is_dts_replicated    bit                  null,
   is_xml_document      bit                  not null,
   xml_collection_id    int                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   is_sparse            bit                  null,
   is_column_set        bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'columns'
go

/*==============================================================*/
/* Table: computed_columns                                      */
/*==============================================================*/
create table sys.computed_columns (
   object_id            int                  not null,
   name                 sysname(128)         null,
   column_id            int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_ansi_padded       bit                  not null,
   is_rowguidcol        bit                  not null,
   is_identity          bit                  not null,
   is_filestream        bit                  not null,
   is_replicated        bit                  null,
   is_non_sql_subscribed bit                  null,
   is_merge_published   bit                  null,
   is_dts_replicated    bit                  null,
   is_xml_document      bit                  not null,
   xml_collection_id    int                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   definition           ntext(1073741823)    null,
   uses_database_collation bit                  not null,
   is_persisted         bit                  not null,
   is_computed          bit                  not null,
   is_sparse            bit                  not null,
   is_column_set        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'computed_columns'
go

/*==============================================================*/
/* Table: configurations                                        */
/*==============================================================*/
create table sys.configurations (
   configuration_id     int                  not null,
   name                 nvarchar(35)         not null,
   value                sql_variant          null,
   minimum              sql_variant          null,
   maximum              sql_variant          null,
   value_in_use         sql_variant          null,
   description          nvarchar(255)        not null,
   is_dynamic           bit                  not null,
   is_advanced          bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'configurations'
go

/*==============================================================*/
/* Table: conversation_endpoints                                */
/*==============================================================*/
create table sys.conversation_endpoints (
   conversation_handle  uniqueidentifier(36) not null,
   conversation_id      uniqueidentifier(36) not null,
   is_initiator         bit                  not null,
   service_contract_id  int                  not null,
   conversation_group_id uniqueidentifier(36) not null,
   service_id           int                  not null,
   lifetime             datetime             not null,
   state                char(2)              not null,
   state_desc           nvarchar(60)         null,
   far_service          nvarchar(256)        not null,
   far_broker_instance  nvarchar(128)        null,
   principal_id         int                  not null,
   far_principal_id     int                  not null,
   outbound_session_key_identifier uniqueidentifier(36) not null,
   inbound_session_key_identifier uniqueidentifier(36) not null,
   security_timestamp   datetime             not null,
   dialog_timer         datetime             not null,
   send_sequence        bigint               not null,
   last_send_tran_id    binary(6)            not null,
   end_dialog_sequence  bigint               not null,
   receive_sequence     bigint               not null,
   receive_sequence_frag int                  not null,
   system_sequence      bigint               not null,
   first_out_of_order_sequence bigint               not null,
   last_out_of_order_sequence bigint               not null,
   last_out_of_order_frag int                  not null,
   is_system            bit                  not null,
   priority             tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'conversation_endpoints'
go

/*==============================================================*/
/* Table: conversation_groups                                   */
/*==============================================================*/
create table sys.conversation_groups (
   conversation_group_id uniqueidentifier(36) not null,
   service_id           int                  not null,
   is_system            bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'conversation_groups'
go

/*==============================================================*/
/* Table: conversation_priorities                               */
/*==============================================================*/
create table sys.conversation_priorities (
   priority_id          int                  not null,
   name                 sysname(128)         not null,
   service_contract_id  int                  null,
   local_service_id     int                  null,
   remote_service_name  nvarchar(256)        null,
   priority             tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'conversation_priorities'
go

/*==============================================================*/
/* Table: credentials                                           */
/*==============================================================*/
create table sys.credentials (
   credential_id        int                  not null,
   name                 sysname(128)         not null,
   credential_identity  nvarchar(4000)       null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   target_type          nvarchar(60)         null,
   target_id            int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'credentials'
go

/*==============================================================*/
/* Table: crypt_properties                                      */
/*==============================================================*/
create table sys.crypt_properties (
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   thumbprint           varbinary(32)        not null,
   crypt_type           char(4)              not null,
   crypt_type_desc      nvarchar(60)         null,
   crypt_property       image(2147483647)    not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'crypt_properties'
go

/*==============================================================*/
/* Table: cryptographic_providers                               */
/*==============================================================*/
create table sys.cryptographic_providers (
   provider_id          int                  not null,
   name                 sysname(128)         not null,
   guid                 uniqueidentifier(36) null,
   version              nvarchar(24)         null,
   dll_path             nvarchar(520)        null,
   is_enabled           bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'cryptographic_providers'
go

/*==============================================================*/
/* Table: data_spaces                                           */
/*==============================================================*/
create table sys.data_spaces (
   name                 sysname(128)         not null,
   data_space_id        int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   is_default           bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'data_spaces'
go

/*==============================================================*/
/* Table: database_audit_specification_details                  */
/*==============================================================*/
create table sys.database_audit_specification_details (
   database_specification_id int                  not null,
   audit_action_id      char(4)              not null,
   audit_action_name    nvarchar(60)         null,
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   minor_id             int                  not null,
   audited_principal_id int                  not null,
   audited_result       nvarchar(60)         null,
   is_group             bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_audit_specification_details'
go

/*==============================================================*/
/* Table: database_audit_specifications                         */
/*==============================================================*/
create table sys.database_audit_specifications (
   database_specification_id int                  not null,
   name                 sysname(128)         not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   audit_guid           uniqueidentifier(36) null,
   is_state_enabled     bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_audit_specifications'
go

/*==============================================================*/
/* Table: database_files                                        */
/*==============================================================*/
create table sys.database_files (
   file_id              int                  not null,
   file_guid            uniqueidentifier(36) null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   data_space_id        int                  not null,
   name                 sysname(128)         not null,
   physical_name        nvarchar(260)        not null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   size                 int                  not null,
   max_size             int                  not null,
   growth               int                  not null,
   is_media_read_only   bit                  not null,
   is_read_only         bit                  not null,
   is_sparse            bit                  not null,
   is_percent_growth    bit                  not null,
   is_name_reserved     bit                  not null,
   create_lsn           numeric(25)          null,
   drop_lsn             numeric(25)          null,
   read_only_lsn        numeric(25)          null,
   read_write_lsn       numeric(25)          null,
   differential_base_lsn numeric(25)          null,
   differential_base_guid uniqueidentifier(36) null,
   differential_base_time datetime             null,
   redo_start_lsn       numeric(25)          null,
   redo_start_fork_guid uniqueidentifier(36) null,
   redo_target_lsn      numeric(25)          null,
   redo_target_fork_guid uniqueidentifier(36) null,
   backup_lsn           numeric(25)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_files'
go

/*==============================================================*/
/* Table: database_mirroring                                    */
/*==============================================================*/
create table sys.database_mirroring (
   database_id          int                  not null,
   mirroring_guid       uniqueidentifier(36) null,
   mirroring_state      tinyint              null,
   mirroring_state_desc nvarchar(60)         null,
   mirroring_role       tinyint              null,
   mirroring_role_desc  nvarchar(60)         null,
   mirroring_role_sequence int                  null,
   mirroring_safety_level tinyint              null,
   mirroring_safety_level_desc nvarchar(60)         null,
   mirroring_safety_sequence int                  null,
   mirroring_partner_name nvarchar(128)        null,
   mirroring_partner_instance nvarchar(128)        null,
   mirroring_witness_name nvarchar(128)        null,
   mirroring_witness_state tinyint              null,
   mirroring_witness_state_desc nvarchar(60)         null,
   mirroring_failover_lsn numeric(25)          null,
   mirroring_connection_timeout int                  null,
   mirroring_redo_queue int                  null,
   mirroring_redo_queue_type nvarchar(60)         null,
   mirroring_end_of_log_lsn numeric(25)          null,
   mirroring_replication_lsn numeric(25)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_mirroring'
go

/*==============================================================*/
/* Table: database_mirroring_endpoints                          */
/*==============================================================*/
create table sys.database_mirroring_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   role                 tinyint              null,
   role_desc            nvarchar(60)         null,
   is_encryption_enabled bit                  not null,
   connection_auth      tinyint              not null,
   connection_auth_desc nvarchar(60)         null,
   certificate_id       int                  not null,
   encryption_algorithm tinyint              not null,
   encryption_algorithm_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_mirroring_endpoints'
go

/*==============================================================*/
/* Table: database_mirroring_witnesses                          */
/*==============================================================*/
create table sys.database_mirroring_witnesses (
   database_name        sysname(128)         not null,
   principal_server_name sysname(128)         null,
   mirror_server_name   sysname(128)         null,
   safety_level         tinyint              not null,
   safety_level_desc    nvarchar(60)         null,
   safety_sequence_number int                  not null,
   role_sequence_number int                  not null,
   mirroring_guid       uniqueidentifier(36) not null,
   family_guid          uniqueidentifier(36) not null,
   is_suspended         bit                  null,
   is_suspended_sequence_number int                  not null,
   partner_sync_state   tinyint              null,
   partner_sync_state_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_mirroring_witnesses'
go

/*==============================================================*/
/* Table: database_permissions                                  */
/*==============================================================*/
create table sys.database_permissions (
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   minor_id             int                  not null,
   grantee_principal_id int                  not null,
   grantor_principal_id int                  not null,
   type                 char(4)              not null,
   permission_name      nvarchar(128)        null,
   state                char(1)              not null,
   state_desc           nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_permissions'
go

/*==============================================================*/
/* Table: database_principal_aliases                            */
/*==============================================================*/
create table sys.database_principal_aliases (
   name                 sysname(128)         not null,
   sid                  varbinary(85)        null,
   is_windows_sid       bit                  not null,
   alias_principal_id   int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_principal_aliases'
go

/*==============================================================*/
/* Table: database_principals                                   */
/*==============================================================*/
create table sys.database_principals (
   name                 sysname(128)         not null,
   principal_id         int                  not null,
   type                 char(1)              not null,
   type_desc            nvarchar(60)         null,
   default_schema_name  sysname(128)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   owning_principal_id  int                  null,
   sid                  varbinary(85)        null,
   is_fixed_role        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_principals'
go

/*==============================================================*/
/* Table: database_recovery_status                              */
/*==============================================================*/
create table sys.database_recovery_status (
   database_id          int                  not null,
   database_guid        uniqueidentifier(36) null,
   family_guid          uniqueidentifier(36) null,
   last_log_backup_lsn  numeric(25)          null,
   recovery_fork_guid   uniqueidentifier(36) null,
   first_recovery_fork_guid uniqueidentifier(36) null,
   fork_point_lsn       numeric(25)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_recovery_status'
go

/*==============================================================*/
/* Table: database_role_members                                 */
/*==============================================================*/
create table sys.database_role_members (
   role_principal_id    int                  not null,
   member_principal_id  int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'database_role_members'
go

/*==============================================================*/
/* Table: databases                                             */
/*==============================================================*/
create table sys.databases (
   name                 sysname(128)         not null,
   database_id          int                  not null,
   source_database_id   int                  null,
   owner_sid            varbinary(85)        null,
   create_date          datetime             not null,
   compatibility_level  tinyint              not null,
   collation_name       sysname(128)         null,
   user_access          tinyint              null,
   user_access_desc     nvarchar(60)         null,
   is_read_only         bit                  null,
   is_auto_close_on     bit                  not null,
   is_auto_shrink_on    bit                  null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_in_standby        bit                  null,
   is_cleanly_shutdown  bit                  null,
   is_supplemental_logging_enabled bit                  null,
   snapshot_isolation_state tinyint              null,
   snapshot_isolation_state_desc nvarchar(60)         null,
   is_read_committed_snapshot_on bit                  null,
   recovery_model       tinyint              null,
   recovery_model_desc  nvarchar(60)         null,
   page_verify_option   tinyint              null,
   page_verify_option_desc nvarchar(60)         null,
   is_auto_create_stats_on bit                  null,
   is_auto_update_stats_on bit                  null,
   is_auto_update_stats_async_on bit                  null,
   is_ansi_null_default_on bit                  null,
   is_ansi_nulls_on     bit                  null,
   is_ansi_padding_on   bit                  null,
   is_ansi_warnings_on  bit                  null,
   is_arithabort_on     bit                  null,
   is_concat_null_yields_null_on bit                  null,
   is_numeric_roundabort_on bit                  null,
   is_quoted_identifier_on bit                  null,
   is_recursive_triggers_on bit                  null,
   is_cursor_close_on_commit_on bit                  null,
   is_local_cursor_default bit                  null,
   is_fulltext_enabled  bit                  null,
   is_trustworthy_on    bit                  null,
   is_db_chaining_on    bit                  null,
   is_parameterization_forced bit                  null,
   is_master_key_encrypted_by_server bit                  not null,
   is_published         bit                  not null,
   is_subscribed        bit                  not null,
   is_merge_published   bit                  not null,
   is_distributor       bit                  not null,
   is_sync_with_backup  bit                  not null,
   service_broker_guid  uniqueidentifier(36) not null,
   is_broker_enabled    bit                  not null,
   log_reuse_wait       tinyint              null,
   log_reuse_wait_desc  nvarchar(60)         null,
   is_date_correlation_on bit                  not null,
   is_cdc_enabled       bit                  not null,
   is_encrypted         bit                  null,
   is_honor_broker_priority_on bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'databases'
go

/*==============================================================*/
/* Table: default_constraints                                   */
/*==============================================================*/
create table sys.default_constraints (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   parent_column_id     int                  not null,
   definition           ntext(1073741823)    null,
   is_system_named      bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'default_constraints'
go

/*==============================================================*/
/* Table: destination_data_spaces                               */
/*==============================================================*/
create table sys.destination_data_spaces (
   partition_scheme_id  int                  not null,
   destination_id       int                  not null,
   data_space_id        int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'destination_data_spaces'
go

/*==============================================================*/
/* Table: dm_audit_actions                                      */
/*==============================================================*/
create table sys.dm_audit_actions (
   action_id            varchar(4)           null,
   name                 nvarchar(128)        null,
   class_desc           nvarchar(35)         null,
   covering_action_name nvarchar(128)        null,
   parent_class_desc    nvarchar(35)         null,
   covering_parent_action_name nvarchar(128)        null,
   configuration_level  nvarchar(128)        null,
   containing_group_name nvarchar(128)        null,
   action_in_log        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_audit_actions'
go

/*==============================================================*/
/* Table: dm_audit_class_type_map                               */
/*==============================================================*/
create table sys.dm_audit_class_type_map (
   class_type           varchar(2)           null,
   class_type_desc      nvarchar(35)         null,
   securable_class_desc nvarchar(35)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_audit_class_type_map'
go

/*==============================================================*/
/* Table: dm_broker_activated_tasks                             */
/*==============================================================*/
create table sys.dm_broker_activated_tasks (
   spid                 int                  null,
   database_id          smallint             null,
   queue_id             int                  null,
   procedure_name       nvarchar(325)        null,
   execute_as           int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_broker_activated_tasks'
go

/*==============================================================*/
/* Table: dm_broker_connections                                 */
/*==============================================================*/
create table sys.dm_broker_connections (
   connection_id        uniqueidentifier(36) null,
   transport_stream_id  uniqueidentifier(36) null,
   state                smallint             null,
   state_desc           nvarchar(60)         null,
   connect_time         datetime             null,
   login_time           datetime             null,
   authentication_method nvarchar(128)        null,
   principal_name       nvarchar(128)        null,
   remote_user_name     nvarchar(128)        null,
   last_activity_time   datetime             null,
   is_accept            bit                  null,
   login_state          smallint             null,
   login_state_desc     nvarchar(60)         null,
   peer_certificate_id  int                  null,
   encryption_algorithm smallint             null,
   encryption_algorithm_desc nvarchar(60)         null,
   receives_posted      smallint             null,
   is_receive_flow_controlled bit                  null,
   sends_posted         smallint             null,
   is_send_flow_controlled bit                  null,
   total_bytes_sent     bigint               null,
   total_bytes_received bigint               null,
   total_fragments_sent bigint               null,
   total_fragments_received bigint               null,
   total_sends          bigint               null,
   total_receives       bigint               null,
   peer_arbitration_id  uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_broker_connections'
go

/*==============================================================*/
/* Table: dm_broker_forwarded_messages                          */
/*==============================================================*/
create table sys.dm_broker_forwarded_messages (
   conversation_id      uniqueidentifier(36) null,
   is_initiator         bit                  null,
   to_service_name      nvarchar(256)        null,
   to_broker_instance   nvarchar(256)        null,
   from_service_name    nvarchar(256)        null,
   from_broker_instance nvarchar(256)        null,
   adjacent_broker_address nvarchar(256)        null,
   message_sequence_number bigint               null,
   message_fragment_number int                  null,
   hops_remaining       tinyint              null,
   time_to_live         int                  null,
   time_consumed        int                  null,
   message_id           uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_broker_forwarded_messages'
go

/*==============================================================*/
/* Table: dm_broker_queue_monitors                              */
/*==============================================================*/
create table sys.dm_broker_queue_monitors (
   database_id          int                  null,
   queue_id             int                  null,
   state                nvarchar(32)         null,
   last_empty_rowset_time datetime             null,
   last_activated_time  datetime             null,
   tasks_waiting        int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_broker_queue_monitors'
go

/*==============================================================*/
/* Table: dm_cdc_errors                                         */
/*==============================================================*/
create table sys.dm_cdc_errors (
   session_id           int                  null,
   phase_number         int                  null,
   entry_time           datetime             null,
   error_number         int                  null,
   error_severity       int                  null,
   error_state          int                  null,
   error_message        nvarchar(1025)       null,
   start_lsn            nvarchar(24)         null,
   begin_lsn            nvarchar(24)         null,
   sequence_value       nvarchar(24)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_cdc_errors'
go

/*==============================================================*/
/* Table: dm_cdc_log_scan_sessions                              */
/*==============================================================*/
create table sys.dm_cdc_log_scan_sessions (
   session_id           int                  null,
   start_time           datetime             null,
   end_time             datetime             null,
   duration             int                  null,
   scan_phase           nvarchar(200)        null,
   error_count          int                  null,
   start_lsn            nvarchar(24)         null,
   current_lsn          nvarchar(24)         null,
   end_lsn              nvarchar(24)         null,
   tran_count           bigint               null,
   last_commit_lsn      nvarchar(24)         null,
   last_commit_time     datetime             null,
   log_record_count     bigint               null,
   schema_change_count  int                  null,
   command_count        bigint               null,
   first_begin_cdc_lsn  nvarchar(24)         null,
   last_commit_cdc_lsn  nvarchar(24)         null,
   last_commit_cdc_time datetime             null,
   latency              int                  null,
   empty_scan_count     int                  null,
   failed_sessions_count int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_cdc_log_scan_sessions'
go

/*==============================================================*/
/* Table: dm_clr_appdomains                                     */
/*==============================================================*/
create table sys.dm_clr_appdomains (
   appdomain_address    varbinary(8)         null,
   appdomain_id         int                  null,
   appdomain_name       nvarchar(386)        null,
   creation_time        datetime             null,
   db_id                int                  null,
   user_id              int                  null,
   state                nvarchar(128)        null,
   strong_refcount      int                  null,
   weak_refcount        int                  null,
   cost                 int                  null,
   value                int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_clr_appdomains'
go

/*==============================================================*/
/* Table: dm_clr_loaded_assemblies                              */
/*==============================================================*/
create table sys.dm_clr_loaded_assemblies (
   assembly_id          int                  null,
   appdomain_address    varbinary(8)         null,
   load_time            datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_clr_loaded_assemblies'
go

/*==============================================================*/
/* Table: dm_clr_properties                                     */
/*==============================================================*/
create table sys.dm_clr_properties (
   name                 nvarchar(128)        null,
   value                nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_clr_properties'
go

/*==============================================================*/
/* Table: dm_clr_tasks                                          */
/*==============================================================*/
create table sys.dm_clr_tasks (
   task_address         varbinary(8)         null,
   sos_task_address     varbinary(8)         null,
   appdomain_address    varbinary(8)         null,
   state                nvarchar(128)        null,
   abort_state          nvarchar(128)        null,
   type                 nvarchar(128)        null,
   affinity_count       int                  null,
   forced_yield_count   int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_clr_tasks'
go

/*==============================================================*/
/* Table: dm_cryptographic_provider_properties                  */
/*==============================================================*/
create table sys.dm_cryptographic_provider_properties (
   provider_id          int                  null,
   guid                 uniqueidentifier(36) null,
   provider_version     nvarchar(128)        null,
   sqlcrypt_version     nvarchar(128)        null,
   friendly_name        nvarchar(1024)       null,
   authentication_type  nvarchar(128)        null,
   symmetric_key_support tinyint              null,
   symmetric_key_persistance tinyint              null,
   symmetric_key_export tinyint              null,
   symmetric_key_import tinyint              null,
   asymmetric_key_support tinyint              null,
   asymmetric_key_persistance tinyint              null,
   asymmetric_key_export tinyint              null,
   asymmetric_key_import tinyint              null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_cryptographic_provider_properties'
go

/*==============================================================*/
/* Table: dm_database_encryption_keys                           */
/*==============================================================*/
create table sys.dm_database_encryption_keys (
   database_id          int                  null,
   encryption_state     int                  null,
   create_date          datetime             null,
   regenerate_date      datetime             null,
   modify_date          datetime             null,
   set_date             datetime             null,
   opened_date          datetime             null,
   key_algorithm        nvarchar(128)        null,
   key_length           int                  null,
   encryptor_thumbprint varbinary(20)        null,
   percent_complete     real                 null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_database_encryption_keys'
go

/*==============================================================*/
/* Table: dm_db_file_space_usage                                */
/*==============================================================*/
create table sys.dm_db_file_space_usage (
   database_id          smallint             null,
   file_id              smallint             null,
   unallocated_extent_page_count bigint               null,
   version_store_reserved_page_count bigint               null,
   user_object_reserved_page_count bigint               null,
   internal_object_reserved_page_count bigint               null,
   mixed_extent_page_count bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_file_space_usage'
go

/*==============================================================*/
/* Table: dm_db_index_usage_stats                               */
/*==============================================================*/
create table sys.dm_db_index_usage_stats (
   database_id          smallint             not null,
   object_id            int                  not null,
   index_id             int                  not null,
   user_seeks           bigint               not null,
   user_scans           bigint               not null,
   user_lookups         bigint               not null,
   user_updates         bigint               not null,
   last_user_seek       datetime             null,
   last_user_scan       datetime             null,
   last_user_lookup     datetime             null,
   last_user_update     datetime             null,
   system_seeks         bigint               not null,
   system_scans         bigint               not null,
   system_lookups       bigint               not null,
   system_updates       bigint               not null,
   last_system_seek     datetime             null,
   last_system_scan     datetime             null,
   last_system_lookup   datetime             null,
   last_system_update   datetime             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_index_usage_stats'
go

/*==============================================================*/
/* Table: dm_db_mirroring_auto_page_repair                      */
/*==============================================================*/
create table sys.dm_db_mirroring_auto_page_repair (
   database_id          int                  not null,
   file_id              int                  not null,
   page_id              bigint               not null,
   error_type           smallint             not null,
   page_status          tinyint              not null,
   modification_time    datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_mirroring_auto_page_repair'
go

/*==============================================================*/
/* Table: dm_db_mirroring_connections                           */
/*==============================================================*/
create table sys.dm_db_mirroring_connections (
   connection_id        uniqueidentifier(36) null,
   transport_stream_id  uniqueidentifier(36) null,
   state                smallint             null,
   state_desc           nvarchar(60)         null,
   connect_time         datetime             null,
   login_time           datetime             null,
   authentication_method nvarchar(128)        null,
   principal_name       nvarchar(128)        null,
   remote_user_name     nvarchar(128)        null,
   last_activity_time   datetime             null,
   is_accept            bit                  null,
   login_state          smallint             null,
   login_state_desc     nvarchar(60)         null,
   peer_certificate_id  int                  null,
   encryption_algorithm smallint             null,
   encryption_algorithm_desc nvarchar(60)         null,
   receives_posted      smallint             null,
   is_receive_flow_controlled bit                  null,
   sends_posted         smallint             null,
   is_send_flow_controlled bit                  null,
   total_bytes_sent     bigint               null,
   total_bytes_received bigint               null,
   total_fragments_sent bigint               null,
   total_fragments_received bigint               null,
   total_sends          bigint               null,
   total_receives       bigint               null,
   peer_arbitration_id  uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_mirroring_connections'
go

/*==============================================================*/
/* Table: dm_db_mirroring_past_actions                          */
/*==============================================================*/
create table sys.dm_db_mirroring_past_actions (
   mirroring_guid       uniqueidentifier(36) null,
   state_machine_name   nvarchar(60)         null,
   action_type          nvarchar(60)         null,
   name                 nvarchar(60)         null,
   current_state        nvarchar(60)         null,
   action_sequence      int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_mirroring_past_actions'
go

/*==============================================================*/
/* Table: dm_db_missing_index_details                           */
/*==============================================================*/
create table sys.dm_db_missing_index_details (
   index_handle         int                  not null,
   database_id          smallint             not null,
   object_id            int                  not null,
   equality_columns     nvarchar(4000)       null,
   inequality_columns   nvarchar(4000)       null,
   included_columns     nvarchar(4000)       null,
   statement            nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_missing_index_details'
go

/*==============================================================*/
/* Table: dm_db_missing_index_group_stats                       */
/*==============================================================*/
create table sys.dm_db_missing_index_group_stats (
   group_handle         int                  not null,
   unique_compiles      bigint               not null,
   user_seeks           bigint               not null,
   user_scans           bigint               not null,
   last_user_seek       datetime             null,
   last_user_scan       datetime             null,
   avg_total_user_cost  float                null,
   avg_user_impact      float                null,
   system_seeks         bigint               not null,
   system_scans         bigint               not null,
   last_system_seek     datetime             null,
   last_system_scan     datetime             null,
   avg_total_system_cost float                null,
   avg_system_impact    float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_missing_index_group_stats'
go

/*==============================================================*/
/* Table: dm_db_missing_index_groups                            */
/*==============================================================*/
create table sys.dm_db_missing_index_groups (
   index_group_handle   int                  not null,
   index_handle         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_missing_index_groups'
go

/*==============================================================*/
/* Table: dm_db_partition_stats                                 */
/*==============================================================*/
create table sys.dm_db_partition_stats (
   partition_id         bigint               not null,
   object_id            int                  not null,
   index_id             int                  not null,
   partition_number     int                  not null,
   in_row_data_page_count bigint               not null,
   in_row_used_page_count bigint               not null,
   in_row_reserved_page_count bigint               not null,
   lob_used_page_count  bigint               not null,
   lob_reserved_page_count bigint               not null,
   row_overflow_used_page_count bigint               not null,
   row_overflow_reserved_page_count bigint               not null,
   used_page_count      bigint               not null,
   reserved_page_count  bigint               not null,
   row_count            bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_partition_stats'
go

/*==============================================================*/
/* Table: dm_db_persisted_sku_features                          */
/*==============================================================*/
create table sys.dm_db_persisted_sku_features (
   feature_name         nvarchar(4000)       null,
   feature_id           int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_persisted_sku_features'
go

/*==============================================================*/
/* Table: dm_db_script_level                                    */
/*==============================================================*/
create table sys.dm_db_script_level (
   database_id          int                  not null,
   script_id            int                  not null,
   script_name          nvarchar(128)        null,
   version              int                  not null,
   script_level         int                  not null,
   downgrade_start_level int                  not null,
   downgrade_target_level int                  not null,
   upgrade_start_level  int                  null,
   upgrade_target_level int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_script_level'
go

/*==============================================================*/
/* Table: dm_db_session_space_usage                             */
/*==============================================================*/
create table sys.dm_db_session_space_usage (
   session_id           smallint             null,
   database_id          smallint             null,
   user_objects_alloc_page_count bigint               null,
   user_objects_dealloc_page_count bigint               null,
   internal_objects_alloc_page_count bigint               null,
   internal_objects_dealloc_page_count bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_session_space_usage'
go

/*==============================================================*/
/* Table: dm_db_task_space_usage                                */
/*==============================================================*/
create table sys.dm_db_task_space_usage (
   session_id           smallint             null,
   request_id           int                  null,
   exec_context_id      int                  null,
   database_id          smallint             null,
   user_objects_alloc_page_count bigint               null,
   user_objects_dealloc_page_count bigint               null,
   internal_objects_alloc_page_count bigint               null,
   internal_objects_dealloc_page_count bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_db_task_space_usage'
go

/*==============================================================*/
/* Table: dm_exec_background_job_queue                          */
/*==============================================================*/
create table sys.dm_exec_background_job_queue (
   time_queued          datetime             not null,
   job_id               int                  not null,
   database_id          int                  not null,
   object_id1           int                  not null,
   object_id2           int                  not null,
   object_id3           int                  not null,
   object_id4           int                  not null,
   error_code           int                  null,
   request_type         smallint             not null,
   retry_count          smallint             not null,
   in_progress          smallint             not null,
   session_id           smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_background_job_queue'
go

/*==============================================================*/
/* Table: dm_exec_background_job_queue_stats                    */
/*==============================================================*/
create table sys.dm_exec_background_job_queue_stats (
   queue_max_len        int                  not null,
   enqueued_count       int                  not null,
   started_count        int                  not null,
   ended_count          int                  not null,
   failed_lock_count    int                  not null,
   failed_other_count   int                  not null,
   failed_giveup_count  int                  not null,
   enqueue_failed_full_count int                  not null,
   enqueue_failed_duplicate_count int                  not null,
   elapsed_avg_ms       int                  not null,
   elapsed_max_ms       int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_background_job_queue_stats'
go

/*==============================================================*/
/* Table: dm_exec_cached_plans                                  */
/*==============================================================*/
create table sys.dm_exec_cached_plans (
   bucketid             int                  not null,
   refcounts            int                  not null,
   usecounts            int                  not null,
   size_in_bytes        int                  not null,
   memory_object_address varbinary(8)         not null,
   cacheobjtype         nvarchar(50)         not null,
   objtype              nvarchar(20)         not null,
   plan_handle          varbinary(64)        not null,
   pool_id              int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_cached_plans'
go

/*==============================================================*/
/* Table: dm_exec_connections                                   */
/*==============================================================*/
create table sys.dm_exec_connections (
   session_id           int                  null,
   most_recent_session_id int                  null,
   connect_time         datetime             not null,
   net_transport        nvarchar(40)         not null,
   protocol_type        nvarchar(40)         null,
   protocol_version     int                  null,
   endpoint_id          int                  null,
   encrypt_option       nvarchar(40)         not null,
   auth_scheme          nvarchar(40)         not null,
   node_affinity        smallint             not null,
   num_reads            int                  null,
   num_writes           int                  null,
   last_read            datetime             null,
   last_write           datetime             null,
   net_packet_size      int                  null,
   client_net_address   varchar(48)          null,
   client_tcp_port      int                  null,
   local_net_address    varchar(48)          null,
   local_tcp_port       int                  null,
   connection_id        uniqueidentifier(36) not null,
   parent_connection_id uniqueidentifier(36) null,
   most_recent_sql_handle varbinary(64)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_connections'
go

/*==============================================================*/
/* Table: dm_exec_procedure_stats                               */
/*==============================================================*/
create table sys.dm_exec_procedure_stats (
   database_id          int                  not null,
   object_id            int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   sql_handle           varbinary(64)        not null,
   plan_handle          varbinary(64)        not null,
   cached_time          datetime             null,
   last_execution_time  datetime             null,
   execution_count      bigint               not null,
   total_worker_time    bigint               not null,
   last_worker_time     bigint               not null,
   min_worker_time      bigint               not null,
   max_worker_time      bigint               not null,
   total_physical_reads bigint               not null,
   last_physical_reads  bigint               not null,
   min_physical_reads   bigint               not null,
   max_physical_reads   bigint               not null,
   total_logical_writes bigint               not null,
   last_logical_writes  bigint               not null,
   min_logical_writes   bigint               not null,
   max_logical_writes   bigint               not null,
   total_logical_reads  bigint               not null,
   last_logical_reads   bigint               not null,
   min_logical_reads    bigint               not null,
   max_logical_reads    bigint               not null,
   total_elapsed_time   bigint               not null,
   last_elapsed_time    bigint               not null,
   min_elapsed_time     bigint               not null,
   max_elapsed_time     bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_procedure_stats'
go

/*==============================================================*/
/* Table: dm_exec_query_memory_grants                           */
/*==============================================================*/
create table sys.dm_exec_query_memory_grants (
   session_id           smallint             null,
   request_id           int                  null,
   scheduler_id         int                  null,
   dop                  smallint             null,
   request_time         datetime             null,
   grant_time           datetime             null,
   requested_memory_kb  bigint               null,
   granted_memory_kb    bigint               null,
   required_memory_kb   bigint               null,
   used_memory_kb       bigint               null,
   max_used_memory_kb   bigint               null,
   query_cost           float                null,
   timeout_sec          int                  null,
   resource_semaphore_id smallint             null,
   queue_id             smallint             null,
   wait_order           int                  null,
   is_next_candidate    bit                  null,
   wait_time_ms         bigint               null,
   plan_handle          varbinary(64)        null,
   sql_handle           varbinary(64)        null,
   group_id             int                  null,
   pool_id              int                  null,
   is_small             bit                  null,
   ideal_memory_kb      bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_query_memory_grants'
go

/*==============================================================*/
/* Table: dm_exec_query_optimizer_info                          */
/*==============================================================*/
create table sys.dm_exec_query_optimizer_info (
   counter              nvarchar(4000)       not null,
   occurrence           bigint               not null,
   value                float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_query_optimizer_info'
go

/*==============================================================*/
/* Table: dm_exec_query_resource_semaphores                     */
/*==============================================================*/
create table sys.dm_exec_query_resource_semaphores (
   resource_semaphore_id smallint             null,
   target_memory_kb     bigint               null,
   max_target_memory_kb bigint               null,
   total_memory_kb      bigint               null,
   available_memory_kb  bigint               null,
   granted_memory_kb    bigint               null,
   used_memory_kb       bigint               null,
   grantee_count        int                  null,
   waiter_count         int                  null,
   timeout_error_count  bigint               null,
   forced_grant_count   bigint               null,
   pool_id              int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_query_resource_semaphores'
go

/*==============================================================*/
/* Table: dm_exec_query_stats                                   */
/*==============================================================*/
create table sys.dm_exec_query_stats (
   sql_handle           varbinary(64)        not null,
   statement_start_offset int                  not null,
   statement_end_offset int                  not null,
   plan_generation_num  bigint               not null,
   plan_handle          varbinary(64)        not null,
   creation_time        datetime             not null,
   last_execution_time  datetime             not null,
   execution_count      bigint               not null,
   total_worker_time    bigint               not null,
   last_worker_time     bigint               not null,
   min_worker_time      bigint               not null,
   max_worker_time      bigint               not null,
   total_physical_reads bigint               not null,
   last_physical_reads  bigint               not null,
   min_physical_reads   bigint               not null,
   max_physical_reads   bigint               not null,
   total_logical_writes bigint               not null,
   last_logical_writes  bigint               not null,
   min_logical_writes   bigint               not null,
   max_logical_writes   bigint               not null,
   total_logical_reads  bigint               not null,
   last_logical_reads   bigint               not null,
   min_logical_reads    bigint               not null,
   max_logical_reads    bigint               not null,
   total_clr_time       bigint               not null,
   last_clr_time        bigint               not null,
   min_clr_time         bigint               not null,
   max_clr_time         bigint               not null,
   total_elapsed_time   bigint               not null,
   last_elapsed_time    bigint               not null,
   min_elapsed_time     bigint               not null,
   max_elapsed_time     bigint               not null,
   query_hash           binary(8)            not null,
   query_plan_hash      binary(8)            not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_query_stats'
go

/*==============================================================*/
/* Table: dm_exec_query_transformation_stats                    */
/*==============================================================*/
create table sys.dm_exec_query_transformation_stats (
   name                 varchar(8000)        not null,
   promise_total        bigint               not null,
   promise_avg          float                not null,
   promised             bigint               not null,
   built_substitute     bigint               not null,
   succeeded            bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_query_transformation_stats'
go

/*==============================================================*/
/* Table: dm_exec_requests                                      */
/*==============================================================*/
create table sys.dm_exec_requests (
   session_id           smallint             not null,
   request_id           int                  not null,
   start_time           datetime             not null,
   status               nvarchar(30)         not null,
   command              nvarchar(16)         not null,
   sql_handle           varbinary(64)        null,
   statement_start_offset int                  null,
   statement_end_offset int                  null,
   plan_handle          varbinary(64)        null,
   database_id          smallint             not null,
   user_id              int                  not null,
   connection_id        uniqueidentifier(36) null,
   blocking_session_id  smallint             null,
   wait_type            nvarchar(60)         null,
   wait_time            int                  not null,
   last_wait_type       nvarchar(60)         not null,
   wait_resource        nvarchar(256)        not null,
   open_transaction_count int                  not null,
   open_resultset_count int                  not null,
   transaction_id       bigint               not null,
   context_info         varbinary(128)       null,
   percent_complete     real                 not null,
   estimated_completion_time bigint               not null,
   cpu_time             int                  not null,
   total_elapsed_time   int                  not null,
   scheduler_id         int                  null,
   task_address         varbinary(8)         null,
   reads                bigint               not null,
   writes               bigint               not null,
   logical_reads        bigint               not null,
   text_size            int                  not null,
   language             nvarchar(128)        null,
   date_format          nvarchar(3)          null,
   date_first           smallint             not null,
   quoted_identifier    bit                  not null,
   arithabort           bit                  not null,
   ansi_null_dflt_on    bit                  not null,
   ansi_defaults        bit                  not null,
   ansi_warnings        bit                  not null,
   ansi_padding         bit                  not null,
   ansi_nulls           bit                  not null,
   concat_null_yields_null bit                  not null,
   transaction_isolation_level smallint             not null,
   lock_timeout         int                  not null,
   deadlock_priority    int                  not null,
   row_count            bigint               not null,
   prev_error           int                  not null,
   nest_level           int                  not null,
   granted_query_memory int                  not null,
   executing_managed_code bit                  not null,
   group_id             int                  not null,
   query_hash           binary(8)            null,
   query_plan_hash      binary(8)            null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_requests'
go

/*==============================================================*/
/* Table: dm_exec_sessions                                      */
/*==============================================================*/
create table sys.dm_exec_sessions (
   session_id           smallint             not null,
   login_time           datetime             not null,
   host_name            nvarchar(128)        null,
   program_name         nvarchar(128)        null,
   host_process_id      int                  null,
   client_version       int                  null,
   client_interface_name nvarchar(32)         null,
   security_id          varbinary(85)        not null,
   login_name           nvarchar(128)        not null,
   nt_domain            nvarchar(128)        null,
   nt_user_name         nvarchar(128)        null,
   status               nvarchar(30)         not null,
   context_info         varbinary(128)       null,
   cpu_time             int                  not null,
   memory_usage         int                  not null,
   total_scheduled_time int                  not null,
   total_elapsed_time   int                  not null,
   endpoint_id          int                  not null,
   last_request_start_time datetime             not null,
   last_request_end_time datetime             null,
   reads                bigint               not null,
   writes               bigint               not null,
   logical_reads        bigint               not null,
   is_user_process      bit                  not null,
   text_size            int                  not null,
   language             nvarchar(128)        null,
   date_format          nvarchar(3)          null,
   date_first           smallint             not null,
   quoted_identifier    bit                  not null,
   arithabort           bit                  not null,
   ansi_null_dflt_on    bit                  not null,
   ansi_defaults        bit                  not null,
   ansi_warnings        bit                  not null,
   ansi_padding         bit                  not null,
   ansi_nulls           bit                  not null,
   concat_null_yields_null bit                  not null,
   transaction_isolation_level smallint             not null,
   lock_timeout         int                  not null,
   deadlock_priority    int                  not null,
   row_count            bigint               not null,
   prev_error           int                  not null,
   original_security_id varbinary(85)        not null,
   original_login_name  nvarchar(128)        not null,
   last_successful_logon datetime             null,
   last_unsuccessful_logon datetime             null,
   unsuccessful_logons  bigint               null,
   group_id             int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_sessions'
go

/*==============================================================*/
/* Table: dm_exec_trigger_stats                                 */
/*==============================================================*/
create table sys.dm_exec_trigger_stats (
   database_id          int                  not null,
   object_id            int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   sql_handle           varbinary(64)        not null,
   plan_handle          varbinary(64)        not null,
   cached_time          datetime             null,
   last_execution_time  datetime             null,
   execution_count      bigint               not null,
   total_worker_time    bigint               not null,
   last_worker_time     bigint               not null,
   min_worker_time      bigint               not null,
   max_worker_time      bigint               not null,
   total_physical_reads bigint               not null,
   last_physical_reads  bigint               not null,
   min_physical_reads   bigint               not null,
   max_physical_reads   bigint               not null,
   total_logical_writes bigint               not null,
   last_logical_writes  bigint               not null,
   min_logical_writes   bigint               not null,
   max_logical_writes   bigint               not null,
   total_logical_reads  bigint               not null,
   last_logical_reads   bigint               not null,
   min_logical_reads    bigint               not null,
   max_logical_reads    bigint               not null,
   total_elapsed_time   bigint               not null,
   last_elapsed_time    bigint               not null,
   min_elapsed_time     bigint               not null,
   max_elapsed_time     bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_exec_trigger_stats'
go

/*==============================================================*/
/* Table: dm_filestream_file_io_handles                         */
/*==============================================================*/
create table sys.dm_filestream_file_io_handles (
   handle_context_address varbinary(8)         null,
   creation_request_id  int                  not null,
   creation_irp_id      int                  not null,
   handle_id            int                  not null,
   creation_client_thread_id varbinary(8)         null,
   creation_client_process_id varbinary(8)         null,
   filestream_transaction_id varbinary(128)       null,
   access_type          nvarchar(60)         not null,
   logical_path         nvarchar(256)        null,
   physical_path        nvarchar(256)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_filestream_file_io_handles'
go

/*==============================================================*/
/* Table: dm_filestream_file_io_requests                        */
/*==============================================================*/
create table sys.dm_filestream_file_io_requests (
   request_context_address varbinary(8)         not null,
   current_spid         smallint             not null,
   request_type         nvarchar(60)         not null,
   request_state        nvarchar(60)         not null,
   request_id           int                  not null,
   irp_id               int                  not null,
   handle_id            int                  not null,
   client_thread_id     varbinary(8)         null,
   client_process_id    varbinary(8)         null,
   handle_context_address varbinary(8)         null,
   filestream_transaction_id varbinary(128)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_filestream_file_io_requests'
go

/*==============================================================*/
/* Table: dm_fts_active_catalogs                                */
/*==============================================================*/
create table sys.dm_fts_active_catalogs (
   database_id          int                  not null,
   catalog_id           int                  not null,
   memory_address       varbinary(8)         not null,
   name                 nvarchar(4000)       not null,
   is_paused            bit                  not null,
   status               int                  not null,
   status_description   nvarchar(64)         null,
   previous_status      int                  not null,
   previous_status_description nvarchar(64)         null,
   worker_count         int                  not null,
   active_fts_index_count int                  not null,
   auto_population_count int                  not null,
   manual_population_count int                  not null,
   full_incremental_population_count int                  not null,
   row_count_in_thousands int                  not null,
   is_importing         bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_active_catalogs'
go

/*==============================================================*/
/* Table: dm_fts_fdhosts                                        */
/*==============================================================*/
create table sys.dm_fts_fdhosts (
   fdhost_id            int                  not null,
   fdhost_name          nvarchar(128)        null,
   fdhost_process_id    int                  not null,
   fdhost_type          nvarchar(64)         null,
   max_thread           int                  not null,
   batch_count          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_fdhosts'
go

/*==============================================================*/
/* Table: dm_fts_index_population                               */
/*==============================================================*/
create table sys.dm_fts_index_population (
   database_id          int                  not null,
   catalog_id           int                  not null,
   table_id             int                  not null,
   memory_address       varbinary(8)         not null,
   population_type      int                  not null,
   population_type_description nvarchar(64)         null,
   is_clustered_index_scan bit                  not null,
   range_count          int                  not null,
   completed_range_count int                  not null,
   outstanding_batch_count int                  not null,
   status               int                  not null,
   status_description   nvarchar(64)         null,
   completion_type      int                  not null,
   completion_type_description nvarchar(64)         null,
   worker_count         int                  not null,
   queued_population_type int                  not null,
   queued_population_type_description nvarchar(64)         null,
   start_time           datetime             not null,
   incremental_timestamp binary(8)            not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_index_population'
go

/*==============================================================*/
/* Table: dm_fts_memory_buffers                                 */
/*==============================================================*/
create table sys.dm_fts_memory_buffers (
   pool_id              int                  not null,
   memory_address       varbinary(8)         not null,
   name                 nvarchar(4000)       not null,
   is_free              bit                  not null,
   row_count            int                  not null,
   bytes_used           int                  not null,
   percent_used         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_memory_buffers'
go

/*==============================================================*/
/* Table: dm_fts_memory_pools                                   */
/*==============================================================*/
create table sys.dm_fts_memory_pools (
   pool_id              int                  not null,
   buffer_size          int                  not null,
   min_buffer_limit     int                  not null,
   max_buffer_limit     int                  not null,
   buffer_count         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_memory_pools'
go

/*==============================================================*/
/* Table: dm_fts_outstanding_batches                            */
/*==============================================================*/
create table sys.dm_fts_outstanding_batches (
   database_id          int                  not null,
   catalog_id           int                  not null,
   table_id             int                  not null,
   batch_id             int                  not null,
   memory_address       varbinary(8)         not null,
   crawl_memory_address varbinary(8)         not null,
   memregion_memory_address varbinary(8)         not null,
   hr_batch             int                  not null,
   is_retry_batch       bit                  not null,
   retry_hints          int                  not null,
   retry_hints_description nvarchar(64)         null,
   doc_failed           bigint               not null,
   batch_timestamp      binary(8)            not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_outstanding_batches'
go

/*==============================================================*/
/* Table: dm_fts_population_ranges                              */
/*==============================================================*/
create table sys.dm_fts_population_ranges (
   memory_address       varbinary(8)         not null,
   parent_memory_address varbinary(8)         not null,
   is_retry             bit                  not null,
   session_id           smallint             not null,
   processed_row_count  int                  not null,
   error_count          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_fts_population_ranges'
go

/*==============================================================*/
/* Table: dm_io_backup_tapes                                    */
/*==============================================================*/
create table sys.dm_io_backup_tapes (
   physical_device_name nvarchar(260)        not null,
   logical_device_name  nvarchar(128)        null,
   status               int                  not null,
   status_desc          nvarchar(260)        not null,
   mount_request_time   datetime             null,
   mount_expiration_time datetime             null,
   database_name        nvarchar(128)        null,
   spid                 int                  null,
   command              int                  null,
   command_desc         nvarchar(60)         null,
   media_family_id      int                  null,
   media_set_name       nvarchar(128)        null,
   media_set_guid       uniqueidentifier(36) null,
   media_sequence_number int                  null,
   tape_operation       int                  null,
   tape_operation_desc  nvarchar(60)         null,
   mount_request_type   int                  null,
   mount_request_type_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_io_backup_tapes'
go

/*==============================================================*/
/* Table: dm_io_cluster_shared_drives                           */
/*==============================================================*/
create table sys.dm_io_cluster_shared_drives (
   DriveName            nchar(1)             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_io_cluster_shared_drives'
go

/*==============================================================*/
/* Table: dm_io_pending_io_requests                             */
/*==============================================================*/
create table sys.dm_io_pending_io_requests (
   io_completion_request_address varbinary(8)         not null,
   io_type              nvarchar(60)         not null,
   io_pending_ms_ticks  bigint               not null,
   io_pending           int                  not null,
   io_completion_routine_address varbinary(8)         null,
   io_user_data_address varbinary(8)         null,
   scheduler_address    varbinary(8)         not null,
   io_handle            varbinary(8)         null,
   io_offset            bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_io_pending_io_requests'
go

/*==============================================================*/
/* Table: dm_os_buffer_descriptors                              */
/*==============================================================*/
create table sys.dm_os_buffer_descriptors (
   database_id          int                  null,
   file_id              int                  null,
   page_id              int                  null,
   page_level           int                  null,
   allocation_unit_id   bigint               null,
   page_type            nvarchar(60)         null,
   row_count            int                  null,
   free_space_in_bytes  int                  null,
   is_modified          bit                  null,
   numa_node            int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_buffer_descriptors'
go

/*==============================================================*/
/* Table: dm_os_child_instances                                 */
/*==============================================================*/
create table sys.dm_os_child_instances (
   owning_principal_name nvarchar(256)        null,
   owning_principal_sid nvarchar(256)        null,
   owning_principal_sid_binary varbinary(85)        null,
   instance_name        nvarchar(128)        null,
   instance_pipe_name   nvarchar(260)        null,
   OS_process_id        int                  null,
   OS_process_creation_date datetime             null,
   heart_beat           nvarchar(5)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_child_instances'
go

/*==============================================================*/
/* Table: dm_os_cluster_nodes                                   */
/*==============================================================*/
create table sys.dm_os_cluster_nodes (
   NodeName             nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_cluster_nodes'
go

/*==============================================================*/
/* Table: dm_os_dispatcher_pools                                */
/*==============================================================*/
create table sys.dm_os_dispatcher_pools (
   dispatcher_pool_address varbinary(8)         not null,
   type                 nvarchar(256)        not null,
   name                 nvarchar(256)        not null,
   dispatcher_count     int                  not null,
   dispatcher_ideal_count int                  not null,
   dispatcher_timeout_ms int                  not null,
   dispatcher_waiting_count int                  not null,
   queue_length         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_dispatcher_pools'
go

/*==============================================================*/
/* Table: dm_os_dispatchers                                     */
/*==============================================================*/
create table sys.dm_os_dispatchers (
   dispatcher_pool_address varbinary(8)         not null,
   task_address         varbinary(8)         not null,
   state                nvarchar(60)         not null,
   wait_duration        bigint               null,
   current_item_duration bigint               null,
   items_processed      bigint               not null,
   fade_end_time        int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_dispatchers'
go

/*==============================================================*/
/* Table: dm_os_hosts                                           */
/*==============================================================*/
create table sys.dm_os_hosts (
   host_address         varbinary(8)         not null,
   type                 nvarchar(60)         null,
   name                 nvarchar(60)         not null,
   enqueued_tasks_count int                  null,
   active_tasks_count   int                  null,
   completed_ios_count  int                  null,
   completed_ios_in_bytes bigint               null,
   active_ios_count     int                  null,
   default_memory_clerk_address varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_hosts'
go

/*==============================================================*/
/* Table: dm_os_latch_stats                                     */
/*==============================================================*/
create table sys.dm_os_latch_stats (
   latch_class          nvarchar(60)         not null,
   waiting_requests_count bigint               null,
   wait_time_ms         bigint               null,
   max_wait_time_ms     bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_latch_stats'
go

/*==============================================================*/
/* Table: dm_os_loaded_modules                                  */
/*==============================================================*/
create table sys.dm_os_loaded_modules (
   base_address         varbinary(8)         not null,
   file_version         varchar(256)         null,
   product_version      varchar(256)         null,
   debug                bit                  null,
   patched              bit                  null,
   prerelease           bit                  null,
   private_build        bit                  null,
   special_build        bit                  null,
   language             int                  null,
   company              nvarchar(256)        null,
   description          nvarchar(256)        null,
   name                 nvarchar(256)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_loaded_modules'
go

/*==============================================================*/
/* Table: dm_os_memory_allocations                              */
/*==============================================================*/
create table sys.dm_os_memory_allocations (
   memory_allocation_address varbinary(8)         not null,
   size_in_bytes        bigint               not null,
   creation_time        datetime             not null,
   memory_object_address varbinary(8)         not null,
   memory_node_id       smallint             not null,
   allocator_stack_address varbinary(8)         not null,
   source_file          varchar(256)         null,
   line_num             int                  not null,
   sequence_num         int                  not null,
   tag                  int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_allocations'
go

/*==============================================================*/
/* Table: dm_os_memory_brokers                                  */
/*==============================================================*/
create table sys.dm_os_memory_brokers (
   pool_id              int                  not null,
   memory_broker_type   nvarchar(60)         not null,
   allocations_kb       bigint               not null,
   allocations_kb_per_sec bigint               not null,
   predicted_allocations_kb bigint               not null,
   target_allocations_kb bigint               not null,
   future_allocations_kb bigint               not null,
   overall_limit_kb     bigint               not null,
   last_notification    nvarchar(60)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_brokers'
go

/*==============================================================*/
/* Table: dm_os_memory_cache_clock_hands                        */
/*==============================================================*/
create table sys.dm_os_memory_cache_clock_hands (
   cache_address        varbinary(8)         not null,
   name                 nvarchar(256)        not null,
   type                 nvarchar(60)         not null,
   clock_hand           nvarchar(60)         not null,
   clock_status         nvarchar(60)         not null,
   rounds_count         bigint               not null,
   removed_all_rounds_count bigint               not null,
   updated_last_round_count bigint               not null,
   removed_last_round_count bigint               not null,
   last_tick_time       bigint               not null,
   round_start_time     bigint               not null,
   last_round_start_time bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_cache_clock_hands'
go

/*==============================================================*/
/* Table: dm_os_memory_cache_counters                           */
/*==============================================================*/
create table sys.dm_os_memory_cache_counters (
   cache_address        varbinary(8)         not null,
   name                 nvarchar(256)        not null,
   type                 nvarchar(60)         not null,
   single_pages_kb      bigint               not null,
   multi_pages_kb       bigint               not null,
   single_pages_in_use_kb bigint               null,
   multi_pages_in_use_kb bigint               null,
   entries_count        bigint               not null,
   entries_in_use_count bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_cache_counters'
go

/*==============================================================*/
/* Table: dm_os_memory_cache_entries                            */
/*==============================================================*/
create table sys.dm_os_memory_cache_entries (
   cache_address        varbinary(8)         not null,
   name                 nvarchar(256)        not null,
   type                 nvarchar(60)         not null,
   entry_address        varbinary(8)         not null,
   entry_data_address   varbinary(8)         not null,
   in_use_count         int                  not null,
   is_dirty             bit                  not null,
   disk_ios_count       int                  not null,
   context_switches_count int                  not null,
   original_cost        int                  not null,
   current_cost         int                  not null,
   memory_object_address varbinary(8)         null,
   pages_allocated_count bigint               not null,
   entry_data           nvarchar(2048)       null,
   pool_id              int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_cache_entries'
go

/*==============================================================*/
/* Table: dm_os_memory_cache_hash_tables                        */
/*==============================================================*/
create table sys.dm_os_memory_cache_hash_tables (
   cache_address        varbinary(8)         not null,
   name                 nvarchar(256)        not null,
   type                 nvarchar(60)         not null,
   table_level          int                  not null,
   buckets_count        int                  not null,
   buckets_in_use_count int                  not null,
   buckets_min_length   int                  not null,
   buckets_max_length   int                  not null,
   buckets_avg_length   int                  not null,
   buckets_max_length_ever int                  not null,
   hits_count           bigint               not null,
   misses_count         bigint               not null,
   buckets_avg_scan_hit_length int                  not null,
   buckets_avg_scan_miss_length int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_cache_hash_tables'
go

/*==============================================================*/
/* Table: dm_os_memory_clerks                                   */
/*==============================================================*/
create table sys.dm_os_memory_clerks (
   memory_clerk_address varbinary(8)         not null,
   type                 nvarchar(60)         not null,
   name                 nvarchar(256)        not null,
   memory_node_id       smallint             not null,
   single_pages_kb      bigint               not null,
   multi_pages_kb       bigint               not null,
   virtual_memory_reserved_kb bigint               not null,
   virtual_memory_committed_kb bigint               not null,
   awe_allocated_kb     bigint               not null,
   shared_memory_reserved_kb bigint               not null,
   shared_memory_committed_kb bigint               not null,
   page_size_bytes      bigint               not null,
   page_allocator_address varbinary(8)         not null,
   host_address         varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_clerks'
go

/*==============================================================*/
/* Table: dm_os_memory_node_access_stats                        */
/*==============================================================*/
create table sys.dm_os_memory_node_access_stats (
   local_node           int                  null,
   remote_node          int                  null,
   page_class           nvarchar(60)         null,
   read_count           bigint               null,
   write_count          bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_node_access_stats'
go

/*==============================================================*/
/* Table: dm_os_memory_nodes                                    */
/*==============================================================*/
create table sys.dm_os_memory_nodes (
   memory_node_id       smallint             not null,
   virtual_address_space_reserved_kb bigint               not null,
   virtual_address_space_committed_kb bigint               not null,
   locked_page_allocations_kb bigint               not null,
   single_pages_kb      bigint               not null,
   multi_pages_kb       bigint               not null,
   shared_memory_reserved_kb bigint               not null,
   shared_memory_committed_kb bigint               not null,
   cpu_affinity_mask    bigint               not null,
   online_scheduler_mask bigint               not null,
   processor_group      smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_nodes'
go

/*==============================================================*/
/* Table: dm_os_memory_objects                                  */
/*==============================================================*/
create table sys.dm_os_memory_objects (
   memory_object_address varbinary(8)         not null,
   parent_address       varbinary(8)         null,
   pages_allocated_count int                  not null,
   creation_options     int                  null,
   bytes_used           bigint               null,
   type                 nvarchar(60)         not null,
   name                 varchar(256)         null,
   memory_node_id       smallint             not null,
   creation_time        datetime             null,
   page_size_in_bytes   int                  not null,
   max_pages_allocated_count int                  not null,
   page_allocator_address varbinary(8)         not null,
   creation_stack_address varbinary(8)         null,
   sequence_num         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_objects'
go

/*==============================================================*/
/* Table: dm_os_memory_pools                                    */
/*==============================================================*/
create table sys.dm_os_memory_pools (
   memory_pool_address  varbinary(8)         not null,
   pool_id              int                  not null,
   type                 nvarchar(60)         not null,
   name                 nvarchar(256)        not null,
   max_free_entries_count bigint               not null,
   free_entries_count   bigint               not null,
   removed_in_all_rounds_count bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_memory_pools'
go

/*==============================================================*/
/* Table: dm_os_nodes                                           */
/*==============================================================*/
create table sys.dm_os_nodes (
   node_id              smallint             not null,
   node_state_desc      nvarchar(256)        not null,
   memory_object_address varbinary(8)         not null,
   memory_clerk_address varbinary(8)         not null,
   io_completion_worker_address varbinary(8)         null,
   memory_node_id       smallint             not null,
   cpu_affinity_mask    bigint               not null,
   online_scheduler_count smallint             not null,
   idle_scheduler_count smallint             not null,
   active_worker_count  int                  not null,
   avg_load_balance     int                  not null,
   timer_task_affinity_mask bigint               not null,
   permanent_task_affinity_mask bigint               not null,
   resource_monitor_state bit                  not null,
   online_scheduler_mask bigint               not null,
   processor_group      smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_nodes'
go

/*==============================================================*/
/* Table: dm_os_performance_counters                            */
/*==============================================================*/
create table sys.dm_os_performance_counters (
   object_name          nchar(128)           not null,
   counter_name         nchar(128)           not null,
   instance_name        nchar(128)           null,
   cntr_value           bigint               not null,
   cntr_type            int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_performance_counters'
go

/*==============================================================*/
/* Table: dm_os_process_memory                                  */
/*==============================================================*/
create table sys.dm_os_process_memory (
   physical_memory_in_use_kb bigint               not null,
   large_page_allocations_kb bigint               not null,
   locked_page_allocations_kb bigint               not null,
   total_virtual_address_space_kb bigint               not null,
   virtual_address_space_reserved_kb bigint               not null,
   virtual_address_space_committed_kb bigint               not null,
   virtual_address_space_available_kb bigint               not null,
   page_fault_count     bigint               not null,
   memory_utilization_percentage int                  not null,
   available_commit_limit_kb bigint               not null,
   process_physical_memory_low bit                  not null,
   process_virtual_memory_low bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_process_memory'
go

/*==============================================================*/
/* Table: dm_os_ring_buffers                                    */
/*==============================================================*/
create table sys.dm_os_ring_buffers (
   ring_buffer_address  varbinary(8)         not null,
   ring_buffer_type     nvarchar(60)         not null,
   timestamp            bigint               not null,
   record               nvarchar(2048)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_ring_buffers'
go

/*==============================================================*/
/* Table: dm_os_schedulers                                      */
/*==============================================================*/
create table sys.dm_os_schedulers (
   scheduler_address    varbinary(8)         not null,
   parent_node_id       int                  not null,
   scheduler_id         int                  not null,
   cpu_id               int                  not null,
   status               nvarchar(60)         not null,
   is_online            bit                  not null,
   is_idle              bit                  not null,
   preemptive_switches_count int                  not null,
   context_switches_count int                  not null,
   idle_switches_count  int                  not null,
   current_tasks_count  int                  not null,
   runnable_tasks_count int                  not null,
   current_workers_count int                  not null,
   active_workers_count int                  not null,
   work_queue_count     bigint               not null,
   pending_disk_io_count int                  not null,
   load_factor          int                  not null,
   yield_count          int                  not null,
   last_timer_activity  bigint               not null,
   failed_to_create_worker bit                  not null,
   active_worker_address varbinary(8)         null,
   memory_object_address varbinary(8)         not null,
   task_memory_object_address varbinary(8)         not null,
   quantum_length_us    bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_schedulers'
go

/*==============================================================*/
/* Table: dm_os_spinlock_stats                                  */
/*==============================================================*/
create table sys.dm_os_spinlock_stats (
   name                 nvarchar(256)        not null,
   collisions           bigint               null,
   spins                bigint               null,
   spins_per_collision  real                 null,
   sleep_time           bigint               null,
   backoffs             int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_spinlock_stats'
go

/*==============================================================*/
/* Table: dm_os_stacks                                          */
/*==============================================================*/
create table sys.dm_os_stacks (
   stack_address        varbinary(8)         not null,
   frame_index          int                  not null,
   frame_address        varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_stacks'
go

/*==============================================================*/
/* Table: dm_os_sublatches                                      */
/*==============================================================*/
create table sys.dm_os_sublatches (
   superlatch_address   varbinary(8)         null,
   sublatch_address     varbinary(8)         not null,
   partition_id         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_sublatches'
go

/*==============================================================*/
/* Table: dm_os_sys_info                                        */
/*==============================================================*/
create table sys.dm_os_sys_info (
   cpu_ticks            bigint               not null,
   ms_ticks             bigint               not null,
   cpu_count            int                  not null,
   hyperthread_ratio    int                  not null,
   physical_memory_in_bytes bigint               not null,
   virtual_memory_in_bytes bigint               not null,
   bpool_committed      int                  not null,
   bpool_commit_target  int                  not null,
   bpool_visible        int                  not null,
   stack_size_in_bytes  int                  not null,
   os_quantum           bigint               not null,
   os_error_mode        int                  not null,
   os_priority_class    int                  null,
   max_workers_count    int                  not null,
   scheduler_count      int                  not null,
   scheduler_total_count int                  not null,
   deadlock_monitor_serial_number int                  not null,
   sqlserver_start_time_ms_ticks bigint               not null,
   sqlserver_start_time datetime             not null,
   affinity_type        int                  not null,
   affinity_type_desc   nvarchar(60)         not null,
   process_kernel_time_ms bigint               not null,
   process_user_time_ms bigint               not null,
   time_source          int                  not null,
   time_source_desc     nvarchar(60)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_sys_info'
go

/*==============================================================*/
/* Table: dm_os_sys_memory                                      */
/*==============================================================*/
create table sys.dm_os_sys_memory (
   total_physical_memory_kb bigint               not null,
   available_physical_memory_kb bigint               not null,
   total_page_file_kb   bigint               not null,
   available_page_file_kb bigint               not null,
   system_cache_kb      bigint               not null,
   kernel_paged_pool_kb bigint               not null,
   kernel_nonpaged_pool_kb bigint               not null,
   system_high_memory_signal_state bit                  not null,
   system_low_memory_signal_state bit                  not null,
   system_memory_state_desc nvarchar(256)        not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_sys_memory'
go

/*==============================================================*/
/* Table: dm_os_tasks                                           */
/*==============================================================*/
create table sys.dm_os_tasks (
   task_address         varbinary(8)         not null,
   task_state           nvarchar(60)         null,
   context_switches_count int                  null,
   pending_io_count     int                  null,
   pending_io_byte_count bigint               null,
   pending_io_byte_average int                  null,
   scheduler_id         int                  not null,
   session_id           smallint             null,
   exec_context_id      int                  null,
   request_id           int                  null,
   worker_address       varbinary(8)         null,
   host_address         varbinary(8)         not null,
   parent_task_address  varbinary(8)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_tasks'
go

/*==============================================================*/
/* Table: dm_os_threads                                         */
/*==============================================================*/
create table sys.dm_os_threads (
   thread_address       varbinary(8)         not null,
   started_by_sqlservr  bit                  not null,
   os_thread_id         int                  not null,
   status               int                  not null,
   instruction_address  varbinary(8)         null,
   creation_time        datetime             null,
   kernel_time          bigint               null,
   usermode_time        bigint               null,
   stack_base_address   varbinary(8)         not null,
   stack_end_address    varbinary(8)         null,
   stack_bytes_committed int                  not null,
   stack_bytes_used     int                  null,
   affinity             bigint               not null,
   priority             int                  null,
   locale               int                  not null,
   token                varbinary(8)         null,
   is_impersonating     int                  not null,
   is_waiting_on_loader_lock int                  not null,
   fiber_data           varbinary(8)         null,
   thread_handle        varbinary(8)         null,
   event_handle         varbinary(8)         null,
   scheduler_address    varbinary(8)         null,
   worker_address       varbinary(8)         null,
   fiber_context_address varbinary(8)         null,
   self_address         varbinary(8)         null,
   processor_group      smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_threads'
go

/*==============================================================*/
/* Table: dm_os_virtual_address_dump                            */
/*==============================================================*/
create table sys.dm_os_virtual_address_dump (
   region_base_address  varbinary(8)         not null,
   region_allocation_base_address varbinary(8)         not null,
   region_allocation_protection varbinary(8)         not null,
   region_size_in_bytes bigint               not null,
   region_state         varbinary(8)         not null,
   region_current_protection varbinary(8)         not null,
   region_type          varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_virtual_address_dump'
go

/*==============================================================*/
/* Table: dm_os_wait_stats                                      */
/*==============================================================*/
create table sys.dm_os_wait_stats (
   wait_type            nvarchar(60)         not null,
   waiting_tasks_count  bigint               not null,
   wait_time_ms         bigint               not null,
   max_wait_time_ms     bigint               not null,
   signal_wait_time_ms  bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_wait_stats'
go

/*==============================================================*/
/* Table: dm_os_waiting_tasks                                   */
/*==============================================================*/
create table sys.dm_os_waiting_tasks (
   waiting_task_address varbinary(8)         not null,
   session_id           smallint             null,
   exec_context_id      int                  null,
   wait_duration_ms     bigint               null,
   wait_type            nvarchar(60)         null,
   resource_address     varbinary(8)         null,
   blocking_task_address varbinary(8)         null,
   blocking_session_id  smallint             null,
   blocking_exec_context_id int                  null,
   resource_description nvarchar(2048)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_waiting_tasks'
go

/*==============================================================*/
/* Table: dm_os_worker_local_storage                            */
/*==============================================================*/
create table sys.dm_os_worker_local_storage (
   worker_address       varbinary(8)         not null,
   comp_exec_ctxt_address varbinary(8)         not null,
   ec_address           varbinary(8)         not null,
   broker_address       varbinary(8)         not null,
   task_proxy_address   varbinary(8)         not null,
   msqlxact_address     varbinary(8)         not null,
   sql_prof_address     varbinary(8)         not null,
   stack_checker_address varbinary(8)         not null,
   host_task_address    varbinary(8)         not null,
   sni_error_address    varbinary(8)         not null,
   queryscan_address    varbinary(8)         not null,
   diag_address         varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_worker_local_storage'
go

/*==============================================================*/
/* Table: dm_os_workers                                         */
/*==============================================================*/
create table sys.dm_os_workers (
   worker_address       varbinary(8)         not null,
   status               int                  not null,
   is_preemptive        bit                  null,
   is_fiber             bit                  null,
   is_sick              bit                  null,
   is_in_cc_exception   bit                  null,
   is_fatal_exception   bit                  null,
   is_inside_catch      bit                  null,
   is_in_polling_io_completion_routine bit                  null,
   context_switch_count int                  not null,
   pending_io_count     int                  not null,
   pending_io_byte_count bigint               not null,
   pending_io_byte_average int                  not null,
   wait_started_ms_ticks bigint               not null,
   wait_resumed_ms_ticks bigint               not null,
   task_bound_ms_ticks  bigint               not null,
   worker_created_ms_ticks bigint               not null,
   exception_num        int                  not null,
   exception_severity   int                  not null,
   exception_address    varbinary(8)         null,
   locale               int                  not null,
   affinity             bigint               not null,
   state                nvarchar(60)         null,
   start_quantum        bigint               not null,
   end_quantum          bigint               not null,
   last_wait_type       nvarchar(60)         null,
   return_code          int                  not null,
   quantum_used         bigint               not null,
   max_quantum          bigint               not null,
   boost_count          int                  not null,
   tasks_processed_count int                  not null,
   fiber_address        varbinary(8)         null,
   task_address         varbinary(8)         null,
   memory_object_address varbinary(8)         not null,
   thread_address       varbinary(8)         null,
   signal_worker_address varbinary(8)         null,
   scheduler_address    varbinary(8)         null,
   processor_group      smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_os_workers'
go

/*==============================================================*/
/* Table: dm_qn_subscriptions                                   */
/*==============================================================*/
create table sys.dm_qn_subscriptions (
   id                   int                  not null,
   database_id          int                  not null,
   sid                  varbinary(85)        not null,
   object_id            int                  not null,
   created              datetime             not null,
   timeout              int                  not null,
   status               int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_qn_subscriptions'
go

/*==============================================================*/
/* Table: dm_repl_articles                                      */
/*==============================================================*/
create table sys.dm_repl_articles (
   artcache_db_address  varbinary(8)         null,
   artcache_table_address varbinary(8)         null,
   artcache_schema_address varbinary(8)         null,
   artcache_article_address varbinary(8)         null,
   artid                int                  null,
   artfilter            int                  null,
   artobjid             int                  null,
   artpubid             int                  null,
   artstatus            tinyint              null,
   arttype              tinyint              null,
   wszArtdesttable      nvarchar(256)        null,
   wszArtdesttableowner nvarchar(256)        null,
   wszArtinscmd         nvarchar(258)        null,
   cmdTypeIns           int                  null,
   wszArtdelcmd         nvarchar(258)        null,
   cmdTypeDel           int                  null,
   wszArtupdcmd         nvarchar(258)        null,
   cmdTypeUpd           int                  null,
   wszArtpartialupdcmd  nvarchar(258)        null,
   cmdTypePartialUpd    int                  null,
   numcol               int                  null,
   artcmdtype           tinyint              null,
   artgeninscmd         nvarchar(4000)       null,
   artgendelcmd         nvarchar(4000)       null,
   artgenupdcmd         nvarchar(4000)       null,
   artpartialupdcmd     nvarchar(4000)       null,
   artupdtxtcmd         nvarchar(4000)       null,
   artgenins2cmd        nvarchar(4000)       null,
   artgendel2cmd        nvarchar(4000)       null,
   fInReconcile         tinyint              null,
   fPubAllowUpdate      tinyint              null,
   intPublicationOptions int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_repl_articles'
go

/*==============================================================*/
/* Table: dm_repl_schemas                                       */
/*==============================================================*/
create table sys.dm_repl_schemas (
   artcache_schema_address varbinary(8)         null,
   tabid                int                  null,
   indexid              smallint             null,
   idSch                int                  null,
   tabschema            nvarchar(256)        null,
   ccTabschema          smallint             null,
   tabname              nvarchar(256)        null,
   ccTabname            smallint             null,
   rowsetid_delete      bigint               null,
   rowsetid_insert      bigint               null,
   num_pk_cols          int                  null,
   pcitee               varbinary(8)         null,
   re_numtextcols       int                  null,
   re_schema_lsn_begin  nvarchar(24)         null,
   re_schema_lsn_end    nvarchar(24)         null,
   re_numcols           int                  null,
   re_colid             int                  null,
   re_awcName           nvarchar(256)        null,
   re_ccName            smallint             null,
   re_colattr           smallint             null,
   re_maxlen            smallint             null,
   re_prec              tinyint              null,
   re_scale             tinyint              null,
   re_collatid          int                  null,
   re_xvtype            tinyint              null,
   re_offset            int                  null,
   re_bitpos            tinyint              null,
   re_fNullable         tinyint              null,
   re_fAnsiTrim         tinyint              null,
   re_computed          int                  null,
   se_rowsetid          bigint               null,
   se_schema_lsn_begin  nvarchar(24)         null,
   se_schema_lsn_end    nvarchar(24)         null,
   se_numcols           int                  null,
   se_colid             int                  null,
   se_maxlen            smallint             null,
   se_prec              tinyint              null,
   se_scale             tinyint              null,
   se_collatid          int                  null,
   se_xvtype            tinyint              null,
   se_offset            int                  null,
   se_bitpos            tinyint              null,
   se_fNullable         tinyint              null,
   se_fAnsiTrim         tinyint              null,
   se_computed          tinyint              null,
   se_nullBitInLeafRows smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_repl_schemas'
go

/*==============================================================*/
/* Table: dm_repl_tranhash                                      */
/*==============================================================*/
create table sys.dm_repl_tranhash (
   buckets              int                  null,
   hashed_trans         int                  null,
   completed_trans      int                  null,
   compensated_trans    int                  null,
   first_begin_lsn      nvarchar(24)         null,
   last_commit_lsn      nvarchar(24)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_repl_tranhash'
go

/*==============================================================*/
/* Table: dm_repl_traninfo                                      */
/*==============================================================*/
create table sys.dm_repl_traninfo (
   fp2p_pub_exists      tinyint              null,
   db_ver               int                  null,
   comp_range_address   varbinary(8)         null,
   textinfo_address     varbinary(8)         null,
   fsinfo_address       varbinary(8)         null,
   begin_lsn            nvarchar(24)         null,
   commit_lsn           nvarchar(24)         null,
   dbid                 smallint             null,
   rows                 int                  null,
   xdesid               nvarchar(24)         null,
   artcache_table_address varbinary(8)         null,
   server               nvarchar(256)        null,
   server_len_in_bytes  int                  null,
   "database"           nvarchar(256)        null,
   db_len_in_bytes      int                  null,
   originator           nvarchar(256)        null,
   originator_len_in_bytes int                  null,
   orig_db              nvarchar(256)        null,
   orig_db_len_in_bytes int                  null,
   cmds_in_tran         int                  null,
   is_boundedupdate_singleton tinyint              null,
   begin_update_lsn     nvarchar(24)         null,
   delete_lsn           nvarchar(24)         null,
   last_end_lsn         nvarchar(24)         null,
   fcomplete            tinyint              null,
   fcompensated         tinyint              null,
   fprocessingtext      tinyint              null,
   max_cmds_in_tran     int                  null,
   begin_time           datetime             null,
   commit_time          datetime             null,
   session_id           int                  null,
   session_phase        nvarchar(200)        null,
   is_known_cdc_tran    tinyint              null,
   error_count          int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_repl_traninfo'
go

/*==============================================================*/
/* Table: dm_resource_governor_configuration                    */
/*==============================================================*/
create table sys.dm_resource_governor_configuration (
   classifier_function_id int                  not null,
   is_reconfiguration_pending tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_resource_governor_configuration'
go

/*==============================================================*/
/* Table: dm_resource_governor_resource_pools                   */
/*==============================================================*/
create table sys.dm_resource_governor_resource_pools (
   pool_id              int                  not null,
   name                 nvarchar(256)        not null,
   statistics_start_time datetime             not null,
   total_cpu_usage_ms   bigint               not null,
   cache_memory_kb      bigint               not null,
   compile_memory_kb    bigint               not null,
   used_memgrant_kb     bigint               not null,
   total_memgrant_count bigint               not null,
   total_memgrant_timeout_count bigint               not null,
   active_memgrant_count int                  not null,
   active_memgrant_kb   bigint               not null,
   memgrant_waiter_count int                  not null,
   max_memory_kb        bigint               not null,
   used_memory_kb       bigint               not null,
   target_memory_kb     bigint               not null,
   out_of_memory_count  bigint               not null,
   min_cpu_percent      int                  not null,
   max_cpu_percent      int                  not null,
   min_memory_percent   int                  not null,
   max_memory_percent   int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_resource_governor_resource_pools'
go

/*==============================================================*/
/* Table: dm_resource_governor_workload_groups                  */
/*==============================================================*/
create table sys.dm_resource_governor_workload_groups (
   group_id             int                  not null,
   name                 nvarchar(256)        not null,
   pool_id              int                  not null,
   statistics_start_time datetime             not null,
   total_request_count  bigint               not null,
   total_queued_request_count bigint               not null,
   active_request_count int                  not null,
   queued_request_count int                  not null,
   total_cpu_limit_violation_count bigint               not null,
   total_cpu_usage_ms   bigint               not null,
   max_request_cpu_time_ms bigint               not null,
   blocked_task_count   int                  not null,
   total_lock_wait_count bigint               not null,
   total_lock_wait_time_ms bigint               not null,
   total_query_optimization_count bigint               not null,
   total_suboptimal_plan_generation_count bigint               not null,
   total_reduced_memgrant_count bigint               not null,
   max_request_grant_memory_kb bigint               not null,
   active_parallel_thread_count bigint               not null,
   importance           nvarchar(256)        not null,
   request_max_memory_grant_percent int                  not null,
   request_max_cpu_time_sec int                  not null,
   request_memory_grant_timeout_sec int                  not null,
   group_max_requests   int                  not null,
   max_dop              int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_resource_governor_workload_groups'
go

/*==============================================================*/
/* Table: dm_server_audit_status                                */
/*==============================================================*/
create table sys.dm_server_audit_status (
   audit_id             int                  not null,
   name                 nvarchar(256)        not null,
   status               smallint             not null,
   status_desc          nvarchar(256)        not null,
   status_time          datetime2(27)        not null,
   event_session_address varbinary(8)         null,
   audit_file_path      nvarchar(256)        null,
   audit_file_size      bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_server_audit_status'
go

/*==============================================================*/
/* Table: dm_tran_active_snapshot_database_transactions         */
/*==============================================================*/
create table sys.dm_tran_active_snapshot_database_transactions (
   transaction_id       bigint               null,
   transaction_sequence_num bigint               null,
   commit_sequence_num  bigint               null,
   session_id           int                  null,
   is_snapshot          bit                  null,
   first_snapshot_sequence_num bigint               null,
   max_version_chain_traversed int                  null,
   average_version_chain_traversed float                null,
   elapsed_time_seconds bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_active_snapshot_database_transactions'
go

/*==============================================================*/
/* Table: dm_tran_active_transactions                           */
/*==============================================================*/
create table sys.dm_tran_active_transactions (
   transaction_id       bigint               not null,
   name                 nvarchar(32)         not null,
   transaction_begin_time datetime             not null,
   transaction_type     int                  not null,
   transaction_uow      uniqueidentifier(36) null,
   transaction_state    int                  not null,
   transaction_status   int                  not null,
   transaction_status2  int                  not null,
   dtc_state            int                  not null,
   dtc_status           int                  not null,
   dtc_isolation_level  int                  not null,
   filestream_transaction_id varbinary(128)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_active_transactions'
go

/*==============================================================*/
/* Table: dm_tran_commit_table                                  */
/*==============================================================*/
create table sys.dm_tran_commit_table (
   commit_ts            bigint               null,
   xdes_id              bigint               null,
   commit_lbn           bigint               not null,
   commit_csn           bigint               not null,
   commit_time          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_commit_table'
go

/*==============================================================*/
/* Table: dm_tran_current_snapshot                              */
/*==============================================================*/
create table sys.dm_tran_current_snapshot (
   transaction_sequence_num bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_current_snapshot'
go

/*==============================================================*/
/* Table: dm_tran_current_transaction                           */
/*==============================================================*/
create table sys.dm_tran_current_transaction (
   transaction_id       bigint               null,
   transaction_sequence_num bigint               null,
   transaction_is_snapshot bit                  null,
   first_snapshot_sequence_num bigint               null,
   last_transaction_sequence_num bigint               null,
   first_useful_sequence_num bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_current_transaction'
go

/*==============================================================*/
/* Table: dm_tran_database_transactions                         */
/*==============================================================*/
create table sys.dm_tran_database_transactions (
   transaction_id       bigint               not null,
   database_id          int                  not null,
   database_transaction_begin_time datetime             null,
   database_transaction_type int                  not null,
   database_transaction_state int                  not null,
   database_transaction_status int                  not null,
   database_transaction_status2 int                  not null,
   database_transaction_log_record_count bigint               not null,
   database_transaction_replicate_record_count int                  not null,
   database_transaction_log_bytes_used bigint               not null,
   database_transaction_log_bytes_reserved bigint               not null,
   database_transaction_log_bytes_used_system int                  not null,
   database_transaction_log_bytes_reserved_system int                  not null,
   database_transaction_begin_lsn numeric(25)          null,
   database_transaction_last_lsn numeric(25)          null,
   database_transaction_most_recent_savepoint_lsn numeric(25)          null,
   database_transaction_commit_lsn numeric(25)          null,
   database_transaction_last_rollback_lsn numeric(25)          null,
   database_transaction_next_undo_lsn numeric(25)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_database_transactions'
go

/*==============================================================*/
/* Table: dm_tran_locks                                         */
/*==============================================================*/
create table sys.dm_tran_locks (
   resource_type        nvarchar(60)         not null,
   resource_subtype     nvarchar(60)         not null,
   resource_database_id int                  not null,
   resource_description nvarchar(256)        not null,
   resource_associated_entity_id bigint               null,
   resource_lock_partition int                  null,
   request_mode         nvarchar(60)         not null,
   request_type         nvarchar(60)         not null,
   request_status       nvarchar(60)         not null,
   request_reference_count smallint             not null,
   request_lifetime     int                  not null,
   request_session_id   int                  not null,
   request_exec_context_id int                  not null,
   request_request_id   int                  not null,
   request_owner_type   nvarchar(60)         not null,
   request_owner_id     bigint               null,
   request_owner_guid   uniqueidentifier(36) null,
   request_owner_lockspace_id nvarchar(32)         not null,
   lock_owner_address   varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_locks'
go

/*==============================================================*/
/* Table: dm_tran_session_transactions                          */
/*==============================================================*/
create table sys.dm_tran_session_transactions (
   session_id           int                  not null,
   transaction_id       bigint               not null,
   transaction_descriptor binary(8)            not null,
   enlist_count         int                  not null,
   is_user_transaction  bit                  not null,
   is_local             bit                  not null,
   is_enlisted          bit                  not null,
   is_bound             bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_session_transactions'
go

/*==============================================================*/
/* Table: dm_tran_top_version_generators                        */
/*==============================================================*/
create table sys.dm_tran_top_version_generators (
   database_id          smallint             null,
   rowset_id            bigint               null,
   aggregated_record_length_in_bytes int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_top_version_generators'
go

/*==============================================================*/
/* Table: dm_tran_transactions_snapshot                         */
/*==============================================================*/
create table sys.dm_tran_transactions_snapshot (
   transaction_sequence_num bigint               null,
   snapshot_id          int                  null,
   snapshot_sequence_num bigint               null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_transactions_snapshot'
go

/*==============================================================*/
/* Table: dm_tran_version_store                                 */
/*==============================================================*/
create table sys.dm_tran_version_store (
   transaction_sequence_num bigint               null,
   version_sequence_num bigint               null,
   database_id          smallint             null,
   rowset_id            bigint               null,
   status               tinyint              null,
   min_length_in_bytes  smallint             null,
   record_length_first_part_in_bytes smallint             null,
   record_image_first_part varbinary(8000)      null,
   record_length_second_part_in_bytes smallint             null,
   record_image_second_part varbinary(8000)      null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_tran_version_store'
go

/*==============================================================*/
/* Table: dm_xe_map_values                                      */
/*==============================================================*/
create table sys.dm_xe_map_values (
   name                 nvarchar(60)         not null,
   object_package_guid  uniqueidentifier(36) not null,
   map_key              int                  not null,
   map_value            nvarchar(2048)       not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_map_values'
go

/*==============================================================*/
/* Table: dm_xe_object_columns                                  */
/*==============================================================*/
create table sys.dm_xe_object_columns (
   name                 nvarchar(60)         not null,
   column_id            int                  not null,
   object_name          nvarchar(60)         not null,
   object_package_guid  uniqueidentifier(36) not null,
   type_name            nvarchar(60)         not null,
   type_package_guid    uniqueidentifier(36) not null,
   column_type          nvarchar(60)         not null,
   column_value         nvarchar(256)        null,
   capabilities         int                  null,
   capabilities_desc    nvarchar(256)        null,
   description          nvarchar(256)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_object_columns'
go

/*==============================================================*/
/* Table: dm_xe_objects                                         */
/*==============================================================*/
create table sys.dm_xe_objects (
   name                 nvarchar(60)         not null,
   object_type          nvarchar(60)         not null,
   package_guid         uniqueidentifier(36) not null,
   description          nvarchar(256)        not null,
   capabilities         int                  null,
   capabilities_desc    nvarchar(256)        null,
   type_name            nvarchar(60)         null,
   type_package_guid    uniqueidentifier(36) null,
   type_size            int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_objects'
go

/*==============================================================*/
/* Table: dm_xe_packages                                        */
/*==============================================================*/
create table sys.dm_xe_packages (
   name                 nvarchar(60)         not null,
   guid                 uniqueidentifier(36) not null,
   description          nvarchar(256)        not null,
   capabilities         int                  null,
   capabilities_desc    nvarchar(256)        null,
   module_guid          uniqueidentifier(36) not null,
   module_address       varbinary(8)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_packages'
go

/*==============================================================*/
/* Table: dm_xe_session_event_actions                           */
/*==============================================================*/
create table sys.dm_xe_session_event_actions (
   event_session_address varbinary(8)         not null,
   action_name          nvarchar(60)         not null,
   action_package_guid  uniqueidentifier(36) not null,
   event_name           nvarchar(60)         not null,
   event_package_guid   uniqueidentifier(36) not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_session_event_actions'
go

/*==============================================================*/
/* Table: dm_xe_session_events                                  */
/*==============================================================*/
create table sys.dm_xe_session_events (
   event_session_address varbinary(8)         not null,
   event_name           nvarchar(60)         not null,
   event_package_guid   uniqueidentifier(36) not null,
   event_predicate      nvarchar(2048)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_session_events'
go

/*==============================================================*/
/* Table: dm_xe_session_object_columns                          */
/*==============================================================*/
create table sys.dm_xe_session_object_columns (
   event_session_address varbinary(8)         not null,
   column_name          nvarchar(60)         not null,
   column_id            int                  not null,
   column_value         nvarchar(2048)       null,
   object_type          nvarchar(60)         not null,
   object_name          nvarchar(60)         not null,
   object_package_guid  uniqueidentifier(36) not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_session_object_columns'
go

/*==============================================================*/
/* Table: dm_xe_session_targets                                 */
/*==============================================================*/
create table sys.dm_xe_session_targets (
   event_session_address varbinary(8)         not null,
   target_name          nvarchar(60)         not null,
   target_package_guid  uniqueidentifier(36) not null,
   execution_count      bigint               not null,
   execution_duration_ms bigint               not null,
   target_data          ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_session_targets'
go

/*==============================================================*/
/* Table: dm_xe_sessions                                        */
/*==============================================================*/
create table sys.dm_xe_sessions (
   address              varbinary(8)         not null,
   name                 nvarchar(256)        not null,
   pending_buffers      int                  not null,
   total_regular_buffers int                  not null,
   regular_buffer_size  bigint               not null,
   total_large_buffers  int                  not null,
   large_buffer_size    bigint               not null,
   total_buffer_size    bigint               not null,
   buffer_policy_flags  int                  not null,
   buffer_policy_desc   nvarchar(256)        not null,
   flags                int                  not null,
   flag_desc            nvarchar(256)        not null,
   dropped_event_count  int                  not null,
   dropped_buffer_count int                  not null,
   blocked_event_fire_time int                  not null,
   create_time          datetime             not null,
   largest_event_dropped_size int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'dm_xe_sessions'
go

/*==============================================================*/
/* Table: dtproperties                                          */
/*==============================================================*/
create table dbo.dtproperties (
   id                   int                  identity,
   objectid             int                  null,
   property             varchar(64)          not null,
   value                varchar(255)         null,
   uvalue               nvarchar(255)        null,
   lvalue               image(2147483647)    null,
   version              int                  not null default 0,
   constraint pk_dtproperties primary key nonclustered (id, property)
)
go

/*==============================================================*/
/* Table: endpoint_webmethods                                   */
/*==============================================================*/
create table sys.endpoint_webmethods (
   endpoint_id          int                  not null,
   namespace            nvarchar(384)        null,
   method_alias         nvarchar(64)         not null,
   object_name          nvarchar(776)        null,
   result_schema        tinyint              null,
   result_schema_desc   nvarchar(60)         null,
   result_format        tinyint              null,
   result_format_desc   nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'endpoint_webmethods'
go

/*==============================================================*/
/* Table: endpoints                                             */
/*==============================================================*/
create table sys.endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'endpoints'
go

/*==============================================================*/
/* Table: event_notification_event_types                        */
/*==============================================================*/
create table sys.event_notification_event_types (
   type                 int                  not null,
   type_name            nvarchar(64)         null,
   parent_type          int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'event_notification_event_types'
go

/*==============================================================*/
/* Table: event_notifications                                   */
/*==============================================================*/
create table sys.event_notifications (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   parent_class         tinyint              not null,
   parent_class_desc    nvarchar(60)         null,
   parent_id            int                  not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   service_name         nvarchar(256)        null,
   broker_instance      nvarchar(128)        null,
   creator_sid          varbinary(85)        null,
   principal_id         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'event_notifications'
go

/*==============================================================*/
/* Table: events                                                */
/*==============================================================*/
create table sys.events (
   object_id            int                  not null,
   type                 int                  not null,
   type_desc            nvarchar(128)        not null,
   is_trigger_event     bit                  null,
   event_group_type     int                  null,
   event_group_type_desc nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'events'
go

/*==============================================================*/
/* Table: extended_procedures                                   */
/*==============================================================*/
create table sys.extended_procedures (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   dll_name             nvarchar(260)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'extended_procedures'
go

/*==============================================================*/
/* Table: extended_properties                                   */
/*==============================================================*/
create table sys.extended_properties (
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   minor_id             int                  not null,
   name                 sysname(128)         not null,
   value                sql_variant          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'extended_properties'
go

/*==============================================================*/
/* Table: filegroups                                            */
/*==============================================================*/
create table sys.filegroups (
   name                 sysname(128)         not null,
   data_space_id        int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   is_default           bit                  null,
   filegroup_guid       uniqueidentifier(36) null,
   log_filegroup_id     int                  null,
   is_read_only         bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'filegroups'
go

/*==============================================================*/
/* Table: foreign_key_columns                                   */
/*==============================================================*/
create table sys.foreign_key_columns (
   constraint_object_id int                  not null,
   constraint_column_id int                  not null,
   parent_object_id     int                  not null,
   parent_column_id     int                  not null,
   referenced_object_id int                  not null,
   referenced_column_id int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'foreign_key_columns'
go

/*==============================================================*/
/* Table: foreign_keys                                          */
/*==============================================================*/
create table sys.foreign_keys (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   referenced_object_id int                  null,
   key_index_id         int                  null,
   is_disabled          bit                  not null,
   is_not_for_replication bit                  not null,
   is_not_trusted       bit                  not null,
   delete_referential_action tinyint              null,
   delete_referential_action_desc nvarchar(60)         null,
   update_referential_action tinyint              null,
   update_referential_action_desc nvarchar(60)         null,
   is_system_named      bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'foreign_keys'
go

/*==============================================================*/
/* Table: fulltext_catalogs                                     */
/*==============================================================*/
create table sys.fulltext_catalogs (
   fulltext_catalog_id  int                  not null,
   name                 sysname(128)         not null,
   path                 nvarchar(260)        null,
   is_default           bit                  not null,
   is_accent_sensitivity_on bit                  not null,
   data_space_id        int                  null,
   file_id              int                  null,
   principal_id         int                  null,
   is_importing         bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_catalogs'
go

/*==============================================================*/
/* Table: fulltext_document_types                               */
/*==============================================================*/
create table sys.fulltext_document_types (
   document_type        nvarchar(128)        not null,
   class_id             uniqueidentifier(36) not null,
   path                 nvarchar(260)        null,
   version              nvarchar(128)        not null,
   manufacturer         nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_document_types'
go

/*==============================================================*/
/* Table: fulltext_index_catalog_usages                         */
/*==============================================================*/
create table sys.fulltext_index_catalog_usages (
   object_id            int                  not null,
   index_id             int                  null,
   fulltext_catalog_id  int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_index_catalog_usages'
go

/*==============================================================*/
/* Table: fulltext_index_columns                                */
/*==============================================================*/
create table sys.fulltext_index_columns (
   object_id            int                  not null,
   column_id            int                  not null,
   type_column_id       int                  null,
   language_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_index_columns'
go

/*==============================================================*/
/* Table: fulltext_index_fragments                              */
/*==============================================================*/
create table sys.fulltext_index_fragments (
   table_id             int                  not null,
   fragment_id          int                  not null,
   fragment_object_id   int                  not null,
   timestamp            binary(8)            not null,
   status               int                  not null,
   data_size            bigint               not null,
   row_count            bigint               not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_index_fragments'
go

/*==============================================================*/
/* Table: fulltext_indexes                                      */
/*==============================================================*/
create table sys.fulltext_indexes (
   object_id            int                  not null,
   unique_index_id      int                  not null,
   fulltext_catalog_id  int                  null,
   is_enabled           bit                  not null,
   change_tracking_state char(1)              null,
   change_tracking_state_desc nvarchar(60)         null,
   has_crawl_completed  bit                  not null,
   crawl_type           char(1)              not null,
   crawl_type_desc      nvarchar(60)         null,
   crawl_start_date     datetime             null,
   crawl_end_date       datetime             null,
   incremental_timestamp binary(8)            null,
   stoplist_id          int                  null,
   data_space_id        int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_indexes'
go

/*==============================================================*/
/* Table: fulltext_languages                                    */
/*==============================================================*/
create table sys.fulltext_languages (
   lcid                 int                  not null,
   name                 nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_languages'
go

/*==============================================================*/
/* Table: fulltext_stoplists                                    */
/*==============================================================*/
create table sys.fulltext_stoplists (
   stoplist_id          int                  not null,
   name                 sysname(128)         not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   principal_id         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_stoplists'
go

/*==============================================================*/
/* Table: fulltext_stopwords                                    */
/*==============================================================*/
create table sys.fulltext_stopwords (
   stoplist_id          int                  not null,
   stopword             nvarchar(64)         not null,
   language             nvarchar(128)        null,
   language_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_stopwords'
go

/*==============================================================*/
/* Table: fulltext_system_stopwords                             */
/*==============================================================*/
create table sys.fulltext_system_stopwords (
   stopword             nvarchar(64)         null,
   language_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'fulltext_system_stopwords'
go

/*==============================================================*/
/* Table: function_order_columns                                */
/*==============================================================*/
create table sys.function_order_columns (
   object_id            int                  not null,
   order_column_id      int                  not null,
   column_id            int                  not null,
   is_descending        bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'function_order_columns'
go

/*==============================================================*/
/* Table: http_endpoints                                        */
/*==============================================================*/
create table sys.http_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   site                 nvarchar(128)        null,
   url_path             nvarchar(4000)       null,
   is_clear_port_enabled bit                  not null,
   clear_port           int                  not null,
   is_ssl_port_enabled  bit                  not null,
   ssl_port             int                  not null,
   is_anonymous_enabled bit                  not null,
   is_basic_auth_enabled bit                  not null,
   is_digest_auth_enabled bit                  not null,
   is_kerberos_auth_enabled bit                  not null,
   is_ntlm_auth_enabled bit                  not null,
   is_integrated_auth_enabled bit                  not null,
   authorization_realm  nvarchar(128)        null,
   default_logon_domain nvarchar(128)        null,
   is_compression_enabled bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'http_endpoints'
go

/*==============================================================*/
/* Table: identity_columns                                      */
/*==============================================================*/
create table sys.identity_columns (
   object_id            int                  not null,
   name                 sysname(128)         null,
   column_id            int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_ansi_padded       bit                  not null,
   is_rowguidcol        bit                  not null,
   is_identity          bit                  not null,
   is_filestream        bit                  not null,
   is_replicated        bit                  null,
   is_non_sql_subscribed bit                  null,
   is_merge_published   bit                  null,
   is_dts_replicated    bit                  null,
   is_xml_document      bit                  not null,
   xml_collection_id    int                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   seed_value           sql_variant          null,
   increment_value      sql_variant          null,
   last_value           sql_variant          null,
   is_not_for_replication bit                  null,
   is_computed          bit                  not null,
   is_sparse            bit                  not null,
   is_column_set        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'identity_columns'
go

/*==============================================================*/
/* Table: index_columns                                         */
/*==============================================================*/
create table sys.index_columns (
   object_id            int                  not null,
   index_id             int                  not null,
   index_column_id      int                  not null,
   column_id            int                  not null,
   key_ordinal          tinyint              not null,
   partition_ordinal    tinyint              not null,
   is_descending_key    bit                  null,
   is_included_column   bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'index_columns'
go

/*==============================================================*/
/* Table: indexes                                               */
/*==============================================================*/
create table sys.indexes (
   object_id            int                  not null,
   name                 sysname(128)         null,
   index_id             int                  not null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   is_unique            bit                  null,
   data_space_id        int                  not null,
   ignore_dup_key       bit                  null,
   is_primary_key       bit                  null,
   is_unique_constraint bit                  null,
   fill_factor          tinyint              not null,
   is_padded            bit                  null,
   is_disabled          bit                  null,
   is_hypothetical      bit                  null,
   allow_row_locks      bit                  null,
   allow_page_locks     bit                  null,
   has_filter           bit                  null,
   filter_definition    ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'indexes'
go

/*==============================================================*/
/* Table: internal_tables                                       */
/*==============================================================*/
create table sys.internal_tables (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  null,
   is_published         bit                  null,
   is_schema_published  bit                  null,
   internal_type        tinyint              null,
   internal_type_desc   nvarchar(60)         null,
   parent_id            int                  null,
   parent_minor_id      int                  null,
   lob_data_space_id    int                  null,
   filestream_data_space_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'internal_tables'
go

/*==============================================================*/
/* Table: key_constraints                                       */
/*==============================================================*/
create table sys.key_constraints (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   unique_index_id      int                  null,
   is_system_named      bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'key_constraints'
go

/*==============================================================*/
/* Table: key_encryptions                                       */
/*==============================================================*/
create table sys.key_encryptions (
   key_id               int                  not null,
   thumbprint           varbinary(32)        null,
   crypt_type           char(4)              not null,
   crypt_type_desc      nvarchar(60)         null,
   crypt_property       image(2147483647)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'key_encryptions'
go

/*==============================================================*/
/* Table: linked_logins                                         */
/*==============================================================*/
create table sys.linked_logins (
   server_id            int                  not null,
   local_principal_id   int                  null,
   uses_self_credential bit                  not null,
   remote_name          sysname(128)         null,
   modify_date          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'linked_logins'
go

/*==============================================================*/
/* Table: login_token                                           */
/*==============================================================*/
create table sys.login_token (
   principal_id         int                  null,
   sid                  varbinary(85)        null,
   name                 nvarchar(128)        null,
   type                 nvarchar(128)        null,
   usage                nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'login_token'
go

/*==============================================================*/
/* Table: master_files                                          */
/*==============================================================*/
create table sys.master_files (
   database_id          int                  not null,
   file_id              int                  not null,
   file_guid            uniqueidentifier(36) null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   data_space_id        int                  not null,
   name                 sysname(128)         not null,
   physical_name        nvarchar(260)        not null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   size                 int                  not null,
   max_size             int                  not null,
   growth               int                  not null,
   is_media_read_only   bit                  not null,
   is_read_only         bit                  not null,
   is_sparse            bit                  not null,
   is_percent_growth    bit                  not null,
   is_name_reserved     bit                  not null,
   create_lsn           numeric(25)          null,
   drop_lsn             numeric(25)          null,
   read_only_lsn        numeric(25)          null,
   read_write_lsn       numeric(25)          null,
   differential_base_lsn numeric(25)          null,
   differential_base_guid uniqueidentifier(36) null,
   differential_base_time datetime             null,
   redo_start_lsn       numeric(25)          null,
   redo_start_fork_guid uniqueidentifier(36) null,
   redo_target_lsn      numeric(25)          null,
   redo_target_fork_guid uniqueidentifier(36) null,
   backup_lsn           numeric(25)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'master_files'
go

/*==============================================================*/
/* Table: master_key_passwords                                  */
/*==============================================================*/
create table sys.master_key_passwords (
   credential_id        int                  not null,
   family_guid          uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'master_key_passwords'
go

/*==============================================================*/
/* Table: message_type_xml_schema_collection_usages             */
/*==============================================================*/
create table sys.message_type_xml_schema_collection_usages (
   message_type_id      int                  not null,
   xml_collection_id    int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'message_type_xml_schema_collection_usages'
go

/*==============================================================*/
/* Table: messages                                              */
/*==============================================================*/
create table sys.messages (
   message_id           int                  not null,
   language_id          smallint             not null,
   severity             tinyint              null,
   is_event_logged      bit                  not null,
   text                 nvarchar(2048)       not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'messages'
go

/*==============================================================*/
/* Table: module_assembly_usages                                */
/*==============================================================*/
create table sys.module_assembly_usages (
   object_id            int                  not null,
   assembly_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'module_assembly_usages'
go

/*==============================================================*/
/* Table: numbered_procedure_parameters                         */
/*==============================================================*/
create table sys.numbered_procedure_parameters (
   object_id            int                  not null,
   procedure_number     smallint             not null,
   name                 sysname(128)         null,
   parameter_id         int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   is_output            bit                  not null,
   is_cursor_ref        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'numbered_procedure_parameters'
go

/*==============================================================*/
/* Table: numbered_procedures                                   */
/*==============================================================*/
create table sys.numbered_procedures (
   object_id            int                  not null,
   procedure_number     smallint             null,
   definition           ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'numbered_procedures'
go

/*==============================================================*/
/* Table: objects                                               */
/*==============================================================*/
create table sys.objects (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'objects'
go

/*==============================================================*/
/* Table: openkeys                                              */
/*==============================================================*/
create table sys.openkeys (
   database_id          int                  null,
   database_name        nvarchar(128)        null,
   key_id               int                  null,
   key_name             nvarchar(128)        null,
   key_guid             uniqueidentifier(36) null,
   opened_date          datetime             null,
   status               smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'openkeys'
go

/*==============================================================*/
/* Table: parameter_type_usages                                 */
/*==============================================================*/
create table sys.parameter_type_usages (
   object_id            int                  not null,
   parameter_id         int                  not null,
   user_type_id         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'parameter_type_usages'
go

/*==============================================================*/
/* Table: parameter_xml_schema_collection_usages                */
/*==============================================================*/
create table sys.parameter_xml_schema_collection_usages (
   object_id            int                  not null,
   parameter_id         int                  not null,
   xml_collection_id    int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'parameter_xml_schema_collection_usages'
go

/*==============================================================*/
/* Table: parameters                                            */
/*==============================================================*/
create table sys.parameters (
   object_id            int                  not null,
   name                 sysname(128)         null,
   parameter_id         int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   is_output            bit                  not null,
   is_cursor_ref        bit                  not null,
   has_default_value    bit                  not null,
   is_xml_document      bit                  not null,
   default_value        sql_variant          null,
   xml_collection_id    int                  not null,
   is_readonly          bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'parameters'
go

/*==============================================================*/
/* Table: partition_functions                                   */
/*==============================================================*/
create table sys.partition_functions (
   name                 sysname(128)         not null,
   function_id          int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   fanout               int                  not null,
   boundary_value_on_right bit                  not null,
   create_date          datetime             not null,
   modify_date          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'partition_functions'
go

/*==============================================================*/
/* Table: partition_parameters                                  */
/*==============================================================*/
create table sys.partition_parameters (
   function_id          int                  not null,
   parameter_id         int                  not null,
   system_type_id       tinyint              not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   user_type_id         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'partition_parameters'
go

/*==============================================================*/
/* Table: partition_range_values                                */
/*==============================================================*/
create table sys.partition_range_values (
   function_id          int                  not null,
   boundary_id          int                  not null,
   parameter_id         int                  not null,
   value                sql_variant          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'partition_range_values'
go

/*==============================================================*/
/* Table: partition_schemes                                     */
/*==============================================================*/
create table sys.partition_schemes (
   name                 sysname(128)         not null,
   data_space_id        int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   is_default           bit                  null,
   function_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'partition_schemes'
go

/*==============================================================*/
/* Table: partitions                                            */
/*==============================================================*/
create table sys.partitions (
   partition_id         bigint               not null,
   object_id            int                  not null,
   index_id             int                  not null,
   partition_number     int                  not null,
   hobt_id              bigint               not null,
   rows                 bigint               not null,
   filestream_filegroup_id smallint             not null,
   data_compression     tinyint              not null,
   data_compression_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'partitions'
go

/*==============================================================*/
/* Table: plan_guides                                           */
/*==============================================================*/
create table sys.plan_guides (
   plan_guide_id        int                  not null,
   name                 sysname(128)         not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_disabled          bit                  not null,
   query_text           ntext(1073741823)    null,
   scope_type           tinyint              not null,
   scope_type_desc      nvarchar(60)         null,
   scope_object_id      int                  null,
   scope_batch          ntext(1073741823)    null,
   parameters           ntext(1073741823)    null,
   hints                ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'plan_guides'
go

/*==============================================================*/
/* Table: procedures                                            */
/*==============================================================*/
create table sys.procedures (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   is_auto_executed     bit                  not null,
   is_execution_replicated bit                  null,
   is_repl_serializable_only bit                  null,
   skips_repl_constraints bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'procedures'
go

/*==============================================================*/
/* Table: remote_logins                                         */
/*==============================================================*/
create table sys.remote_logins (
   server_id            int                  not null,
   remote_name          sysname(128)         null,
   local_principal_id   int                  null,
   modify_date          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'remote_logins'
go

/*==============================================================*/
/* Table: remote_service_bindings                               */
/*==============================================================*/
create table sys.remote_service_bindings (
   name                 sysname(128)         not null,
   remote_service_binding_id int                  not null,
   principal_id         int                  null,
   remote_service_name  nvarchar(256)        null,
   service_contract_id  int                  not null,
   remote_principal_id  int                  null,
   is_anonymous_on      bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'remote_service_bindings'
go

/*==============================================================*/
/* Table: resource_governor_configuration                       */
/*==============================================================*/
create table sys.resource_governor_configuration (
   classifier_function_id int                  not null,
   is_enabled           bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'resource_governor_configuration'
go

/*==============================================================*/
/* Table: resource_governor_resource_pools                      */
/*==============================================================*/
create table sys.resource_governor_resource_pools (
   pool_id              int                  not null,
   name                 sysname(128)         not null,
   min_cpu_percent      int                  not null,
   max_cpu_percent      int                  not null,
   min_memory_percent   int                  not null,
   max_memory_percent   int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'resource_governor_resource_pools'
go

/*==============================================================*/
/* Table: resource_governor_workload_groups                     */
/*==============================================================*/
create table sys.resource_governor_workload_groups (
   group_id             int                  not null,
   name                 sysname(128)         not null,
   importance           sysname(128)         not null,
   request_max_memory_grant_percent int                  not null,
   request_max_cpu_time_sec int                  not null,
   request_memory_grant_timeout_sec int                  not null,
   max_dop              int                  not null,
   group_max_requests   int                  not null,
   pool_id              int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'resource_governor_workload_groups'
go

/*==============================================================*/
/* Table: routes                                                */
/*==============================================================*/
create table sys.routes (
   name                 sysname(128)         not null,
   route_id             int                  not null,
   principal_id         int                  null,
   remote_service_name  nvarchar(256)        null,
   broker_instance      nvarchar(128)        null,
   lifetime             datetime             null,
   address              nvarchar(256)        null,
   mirror_address       nvarchar(256)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'routes'
go

/*==============================================================*/
/* Table: schemas                                               */
/*==============================================================*/
create table sys.schemas (
   name                 sysname(128)         not null,
   schema_id            int                  not null,
   principal_id         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'schemas'
go

/*==============================================================*/
/* Table: securable_classes                                     */
/*==============================================================*/
create table sys.securable_classes (
   class_desc           nvarchar(60)         null,
   class                int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'securable_classes'
go

/*==============================================================*/
/* Table: server_assembly_modules                               */
/*==============================================================*/
create table sys.server_assembly_modules (
   object_id            int                  not null,
   assembly_id          int                  not null,
   assembly_class       nvarchar(128)        null,
   assembly_method      nvarchar(128)        null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_assembly_modules'
go

/*==============================================================*/
/* Table: server_audit_specification_details                    */
/*==============================================================*/
create table sys.server_audit_specification_details (
   server_specification_id int                  not null,
   audit_action_id      char(4)              not null,
   audit_action_name    nvarchar(60)         null,
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   minor_id             int                  not null,
   audited_principal_id int                  not null,
   audited_result       nvarchar(60)         null,
   is_group             bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_audit_specification_details'
go

/*==============================================================*/
/* Table: server_audit_specifications                           */
/*==============================================================*/
create table sys.server_audit_specifications (
   server_specification_id int                  not null,
   name                 sysname(128)         not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   audit_guid           uniqueidentifier(36) null,
   is_state_enabled     bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_audit_specifications'
go

/*==============================================================*/
/* Table: server_audits                                         */
/*==============================================================*/
create table sys.server_audits (
   audit_id             int                  not null,
   name                 sysname(128)         not null,
   audit_guid           uniqueidentifier(36) null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   principal_id         int                  null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   on_failure           tinyint              null,
   on_failure_desc      nvarchar(60)         null,
   is_state_enabled     bit                  null,
   queue_delay          int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_audits'
go

/*==============================================================*/
/* Table: server_event_notifications                            */
/*==============================================================*/
create table sys.server_event_notifications (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   parent_class         tinyint              not null,
   parent_class_desc    nvarchar(60)         null,
   parent_id            int                  not null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   service_name         nvarchar(256)        null,
   broker_instance      nvarchar(128)        null,
   creator_sid          varbinary(85)        null,
   principal_id         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_notifications'
go

/*==============================================================*/
/* Table: server_event_session_actions                          */
/*==============================================================*/
create table sys.server_event_session_actions (
   event_session_id     int                  not null,
   event_id             int                  not null,
   name                 sysname(128)         null,
   package              nvarchar(128)        null,
   module               nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_session_actions'
go

/*==============================================================*/
/* Table: server_event_session_events                           */
/*==============================================================*/
create table sys.server_event_session_events (
   event_session_id     int                  not null,
   event_id             int                  not null,
   name                 sysname(128)         null,
   package              nvarchar(128)        null,
   module               nvarchar(128)        null,
   predicate            nvarchar(3000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_session_events'
go

/*==============================================================*/
/* Table: server_event_session_fields                           */
/*==============================================================*/
create table sys.server_event_session_fields (
   event_session_id     int                  not null,
   object_id            int                  not null,
   name                 sysname(128)         null,
   value                sql_variant          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_session_fields'
go

/*==============================================================*/
/* Table: server_event_session_targets                          */
/*==============================================================*/
create table sys.server_event_session_targets (
   event_session_id     int                  not null,
   target_id            int                  not null,
   name                 sysname(128)         null,
   package              nvarchar(128)        null,
   module               nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_session_targets'
go

/*==============================================================*/
/* Table: server_event_sessions                                 */
/*==============================================================*/
create table sys.server_event_sessions (
   event_session_id     int                  not null,
   name                 nvarchar(128)        null,
   event_retention_mode char(1)              null,
   event_retention_mode_desc nvarchar(60)         null,
   max_dispatch_latency int                  null,
   max_memory           int                  null,
   max_event_size       int                  null,
   memory_partition_mode char(1)              null,
   memory_partition_mode_desc nvarchar(60)         null,
   track_causality      bit                  null,
   startup_state        bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_event_sessions'
go

/*==============================================================*/
/* Table: server_events                                         */
/*==============================================================*/
create table sys.server_events (
   object_id            int                  not null,
   type                 int                  not null,
   type_desc            nvarchar(128)        not null,
   is_trigger_event     bit                  null,
   event_group_type     int                  null,
   event_group_type_desc nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_events'
go

/*==============================================================*/
/* Table: server_file_audits                                    */
/*==============================================================*/
create table sys.server_file_audits (
   audit_id             int                  not null,
   name                 sysname(128)         not null,
   audit_guid           uniqueidentifier(36) null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   principal_id         int                  null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   on_failure           tinyint              null,
   on_failure_desc      nvarchar(60)         null,
   is_state_enabled     bit                  null,
   queue_delay          int                  null,
   max_file_size        bigint               null,
   max_rollover_files   int                  null,
   reserve_disk_space   bit                  null,
   log_file_path        nvarchar(260)        null,
   log_file_name        nvarchar(260)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_file_audits'
go

/*==============================================================*/
/* Table: server_permissions                                    */
/*==============================================================*/
create table sys.server_permissions (
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   major_id             int                  not null,
   minor_id             int                  not null,
   grantee_principal_id int                  not null,
   grantor_principal_id int                  not null,
   type                 char(4)              not null,
   permission_name      nvarchar(128)        null,
   state                char(1)              not null,
   state_desc           nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_permissions'
go

/*==============================================================*/
/* Table: server_principal_credentials                          */
/*==============================================================*/
create table sys.server_principal_credentials (
   principal_id         int                  not null,
   credential_id        int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_principal_credentials'
go

/*==============================================================*/
/* Table: server_principals                                     */
/*==============================================================*/
create table sys.server_principals (
   name                 sysname(128)         not null,
   principal_id         int                  not null,
   sid                  varbinary(85)        null,
   type                 char(1)              not null,
   type_desc            nvarchar(60)         null,
   is_disabled          bit                  null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   default_database_name sysname(128)         null,
   default_language_name sysname(128)         null,
   credential_id        int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_principals'
go

/*==============================================================*/
/* Table: server_role_members                                   */
/*==============================================================*/
create table sys.server_role_members (
   role_principal_id    int                  not null,
   member_principal_id  int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_role_members'
go

/*==============================================================*/
/* Table: server_sql_modules                                    */
/*==============================================================*/
create table sys.server_sql_modules (
   object_id            int                  not null,
   definition           ntext(1073741823)    null,
   uses_ansi_nulls      bit                  null,
   uses_quoted_identifier bit                  null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_sql_modules'
go

/*==============================================================*/
/* Table: server_trigger_events                                 */
/*==============================================================*/
create table sys.server_trigger_events (
   object_id            int                  not null,
   type                 int                  not null,
   type_desc            nvarchar(128)        not null,
   is_first             bit                  null,
   is_last              bit                  null,
   event_group_type     int                  null,
   event_group_type_desc nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_trigger_events'
go

/*==============================================================*/
/* Table: server_triggers                                       */
/*==============================================================*/
create table sys.server_triggers (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   parent_class         tinyint              not null,
   parent_class_desc    nvarchar(60)         null,
   parent_id            int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_disabled          bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'server_triggers'
go

/*==============================================================*/
/* Table: servers                                               */
/*==============================================================*/
create table sys.servers (
   server_id            int                  not null,
   name                 sysname(128)         not null,
   product              sysname(128)         not null,
   provider             sysname(128)         not null,
   data_source          nvarchar(4000)       null,
   location             nvarchar(4000)       null,
   provider_string      nvarchar(4000)       null,
   catalog              sysname(128)         null,
   connect_timeout      int                  null,
   query_timeout        int                  null,
   is_linked            bit                  not null,
   is_remote_login_enabled bit                  not null,
   is_rpc_out_enabled   bit                  not null,
   is_data_access_enabled bit                  not null,
   is_collation_compatible bit                  not null,
   uses_remote_collation bit                  not null,
   collation_name       sysname(128)         null,
   lazy_schema_validation bit                  not null,
   is_system            bit                  not null,
   is_publisher         bit                  not null,
   is_subscriber        bit                  null,
   is_distributor       bit                  null,
   is_nonsql_subscriber bit                  null,
   is_remote_proc_transaction_promotion_enabled bit                  null,
   modify_date          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'servers'
go

/*==============================================================*/
/* Table: service_broker_endpoints                              */
/*==============================================================*/
create table sys.service_broker_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   is_message_forwarding_enabled bit                  not null,
   message_forwarding_size int                  not null,
   connection_auth      tinyint              not null,
   connection_auth_desc nvarchar(60)         null,
   certificate_id       int                  not null,
   encryption_algorithm tinyint              not null,
   encryption_algorithm_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_broker_endpoints'
go

/*==============================================================*/
/* Table: service_contract_message_usages                       */
/*==============================================================*/
create table sys.service_contract_message_usages (
   service_contract_id  int                  not null,
   message_type_id      int                  not null,
   is_sent_by_initiator bit                  not null,
   is_sent_by_target    bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_contract_message_usages'
go

/*==============================================================*/
/* Table: service_contract_usages                               */
/*==============================================================*/
create table sys.service_contract_usages (
   service_id           int                  not null,
   service_contract_id  int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_contract_usages'
go

/*==============================================================*/
/* Table: service_contracts                                     */
/*==============================================================*/
create table sys.service_contracts (
   name                 sysname(128)         not null,
   service_contract_id  int                  not null,
   principal_id         int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_contracts'
go

/*==============================================================*/
/* Table: service_message_types                                 */
/*==============================================================*/
create table sys.service_message_types (
   name                 sysname(128)         not null,
   message_type_id      int                  not null,
   principal_id         int                  null,
   validation           char(2)              not null,
   validation_desc      nvarchar(60)         null,
   xml_collection_id    int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_message_types'
go

/*==============================================================*/
/* Table: service_queue_usages                                  */
/*==============================================================*/
create table sys.service_queue_usages (
   service_id           int                  not null,
   service_queue_id     int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_queue_usages'
go

/*==============================================================*/
/* Table: service_queues                                        */
/*==============================================================*/
create table sys.service_queues (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   max_readers          smallint             null,
   activation_procedure nvarchar(776)        null,
   execute_as_principal_id int                  null,
   is_activation_enabled bit                  not null,
   is_receive_enabled   bit                  not null,
   is_enqueue_enabled   bit                  not null,
   is_retention_enabled bit                  not null,
   is_poison_message_handling_enabled bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'service_queues'
go

/*==============================================================*/
/* Table: services                                              */
/*==============================================================*/
create table sys.services (
   name                 sysname(128)         not null,
   service_id           int                  not null,
   principal_id         int                  null,
   service_queue_id     int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'services'
go

/*==============================================================*/
/* Table: soap_endpoints                                        */
/*==============================================================*/
create table sys.soap_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   is_sql_language_enabled bit                  not null,
   wsdl_generator_procedure nvarchar(776)        null,
   default_database     sysname(128)         null,
   default_namespace    nvarchar(384)        null,
   default_result_schema tinyint              null,
   default_result_schema_desc nvarchar(60)         null,
   is_xml_charset_enforced bit                  not null,
   is_session_enabled   bit                  not null,
   session_timeout      int                  not null,
   login_type           nvarchar(60)         null,
   header_limit         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'soap_endpoints'
go

/*==============================================================*/
/* Table: spatial_index_tessellations                           */
/*==============================================================*/
create table sys.spatial_index_tessellations (
   object_id            int                  not null,
   index_id             int                  not null,
   tessellation_scheme  nvarchar(60)         null,
   bounding_box_xmin    float                null,
   bounding_box_ymin    float                null,
   bounding_box_xmax    float                null,
   bounding_box_ymax    float                null,
   level_1_grid         smallint             null,
   level_1_grid_desc    nvarchar(60)         null,
   level_2_grid         smallint             null,
   level_2_grid_desc    nvarchar(60)         null,
   level_3_grid         smallint             null,
   level_3_grid_desc    nvarchar(60)         null,
   level_4_grid         smallint             null,
   level_4_grid_desc    nvarchar(60)         null,
   cells_per_object     int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'spatial_index_tessellations'
go

/*==============================================================*/
/* Table: spatial_indexes                                       */
/*==============================================================*/
create table sys.spatial_indexes (
   object_id            int                  not null,
   name                 sysname(128)         null,
   index_id             int                  not null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   is_unique            bit                  null,
   data_space_id        int                  not null,
   ignore_dup_key       bit                  null,
   is_primary_key       bit                  null,
   is_unique_constraint bit                  null,
   fill_factor          tinyint              not null,
   is_padded            bit                  null,
   is_disabled          bit                  null,
   is_hypothetical      bit                  null,
   allow_row_locks      bit                  null,
   allow_page_locks     bit                  null,
   spatial_index_type   int                  not null,
   spatial_index_type_desc nvarchar(60)         null,
   tessellation_scheme  nvarchar(60)         null,
   has_filter           bit                  not null,
   filter_definition    ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'spatial_indexes'
go

/*==============================================================*/
/* Table: spatial_reference_systems                             */
/*==============================================================*/
create table sys.spatial_reference_systems (
   spatial_reference_id int                  null,
   authority_name       nvarchar(128)        null,
   authorized_spatial_reference_id int                  null,
   well_known_text      nvarchar(4000)       null,
   unit_of_measure      nvarchar(128)        null,
   unit_conversion_factor float                null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'spatial_reference_systems'
go

/*==============================================================*/
/* Table: sql_dependencies                                      */
/*==============================================================*/
create table sys.sql_dependencies (
   class                tinyint              not null,
   class_desc           nvarchar(60)         null,
   object_id            int                  not null,
   column_id            int                  not null,
   referenced_major_id  int                  not null,
   referenced_minor_id  int                  not null,
   is_selected          bit                  not null,
   is_updated           bit                  not null,
   is_select_all        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sql_dependencies'
go

/*==============================================================*/
/* Table: sql_expression_dependencies                           */
/*==============================================================*/
create table sys.sql_expression_dependencies (
   referencing_id       int                  not null,
   referencing_minor_id int                  not null,
   referencing_class    tinyint              null,
   referencing_class_desc nvarchar(60)         null,
   is_schema_bound_reference bit                  not null,
   referenced_class     tinyint              null,
   referenced_class_desc nvarchar(60)         null,
   referenced_server_name nvarchar(128)        null,
   referenced_database_name nvarchar(128)        null,
   referenced_schema_name nvarchar(128)        null,
   referenced_entity_name nvarchar(128)        null,
   referenced_id        int                  null,
   referenced_minor_id  int                  not null,
   is_caller_dependent  bit                  not null,
   is_ambiguous         bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sql_expression_dependencies'
go

/*==============================================================*/
/* Table: sql_logins                                            */
/*==============================================================*/
create table sys.sql_logins (
   name                 sysname(128)         not null,
   principal_id         int                  not null,
   sid                  varbinary(85)        null,
   type                 char(1)              not null,
   type_desc            nvarchar(60)         null,
   is_disabled          bit                  null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   default_database_name sysname(128)         null,
   default_language_name sysname(128)         null,
   credential_id        int                  null,
   is_policy_checked    bit                  null,
   is_expiration_checked bit                  null,
   password_hash        varbinary(256)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sql_logins'
go

/*==============================================================*/
/* Table: sql_modules                                           */
/*==============================================================*/
create table sys.sql_modules (
   object_id            int                  not null,
   definition           ntext(1073741823)    null,
   uses_ansi_nulls      bit                  null,
   uses_quoted_identifier bit                  null,
   is_schema_bound      bit                  null,
   uses_database_collation bit                  null,
   is_recompiled        bit                  null,
   null_on_null_input   bit                  null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sql_modules'
go

/*==============================================================*/
/* Table: stats                                                 */
/*==============================================================*/
create table sys.stats (
   object_id            int                  not null,
   name                 sysname(128)         null,
   stats_id             int                  not null,
   auto_created         bit                  null,
   user_created         bit                  not null,
   no_recompute         bit                  null,
   has_filter           bit                  null,
   filter_definition    ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'stats'
go

/*==============================================================*/
/* Table: stats_columns                                         */
/*==============================================================*/
create table sys.stats_columns (
   object_id            int                  not null,
   stats_id             int                  not null,
   stats_column_id      int                  not null,
   column_id            int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'stats_columns'
go

/*==============================================================*/
/* Table: symmetric_keys                                        */
/*==============================================================*/
create table sys.symmetric_keys (
   name                 sysname(128)         not null,
   principal_id         int                  null,
   symmetric_key_id     int                  not null,
   key_length           int                  not null,
   key_algorithm        char(2)              not null,
   algorithm_desc       nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   key_guid             uniqueidentifier(36) null,
   key_thumbprint       sql_variant          null,
   provider_type        nvarchar(60)         null,
   cryptographic_provider_guid uniqueidentifier(36) null,
   cryptographic_provider_algid sql_variant          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'symmetric_keys'
go

/*==============================================================*/
/* Table: synonyms                                              */
/*==============================================================*/
create table sys.synonyms (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   base_object_name     nvarchar(1035)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'synonyms'
go

/*==============================================================*/
/* Table: sysaltfiles                                           */
/*==============================================================*/
create table sys.sysaltfiles (
   fileid               smallint             null,
   groupid              smallint             null,
   size                 int                  not null,
   maxsize              int                  not null,
   growth               int                  not null,
   status               int                  null,
   perf                 int                  null,
   dbid                 smallint             null,
   name                 sysname(128)         not null,
   filename             nvarchar(260)        not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysaltfiles'
go

/*==============================================================*/
/* Table: syscacheobjects                                       */
/*==============================================================*/
create table sys.syscacheobjects (
   bucketid             int                  not null,
   cacheobjtype         nvarchar(17)         null,
   objtype              nvarchar(20)         not null,
   objid                int                  null,
   dbid                 smallint             null,
   dbidexec             smallint             null,
   uid                  smallint             null,
   refcounts            int                  not null,
   usecounts            int                  not null,
   pagesused            int                  null,
   setopts              int                  null,
   langid               smallint             null,
   dateformat           smallint             null,
   status               int                  null,
   lasttime             bigint               null,
   maxexectime          bigint               null,
   avgexectime          bigint               null,
   lastreads            bigint               null,
   lastwrites           bigint               null,
   sqlbytes             int                  null,
   sql                  nvarchar(3900)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscacheobjects'
go

/*==============================================================*/
/* Table: syscharsets                                           */
/*==============================================================*/
create table sys.syscharsets (
   type                 smallint             not null,
   id                   tinyint              not null,
   csid                 tinyint              not null,
   status               smallint             null,
   name                 nvarchar(128)        not null,
   description          nvarchar(255)        not null,
   binarydefinition     varbinary(6000)      null,
   definition           image(2147483647)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscharsets'
go

/*==============================================================*/
/* Table: syscolumns                                            */
/*==============================================================*/
create table sys.syscolumns (
   name                 sysname(128)         null,
   id                   int                  not null,
   xtype                tinyint              not null,
   typestat             tinyint              null,
   xusertype            smallint             null,
   length               smallint             not null,
   xprec                tinyint              not null,
   xscale               tinyint              not null,
   colid                smallint             null,
   xoffset              smallint             null,
   bitpos               tinyint              null,
   reserved             tinyint              null,
   colstat              smallint             null,
   cdefault             int                  not null,
   domain               int                  not null,
   number               smallint             null,
   colorder             smallint             null,
   autoval              varbinary(8000)      null,
   offset               smallint             null,
   collationid          int                  not null,
   language             int                  null,
   status               tinyint              null,
   type                 tinyint              not null,
   usertype             smallint             null,
   printfmt             varchar(255)         null,
   prec                 smallint             null,
   scale                int                  null,
   iscomputed           int                  null,
   isoutparam           int                  null,
   isnullable           int                  null,
   collation            sysname(128)         null,
   tdscollation         binary(5)            null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscolumns'
go

/*==============================================================*/
/* Table: syscomments                                           */
/*==============================================================*/
create table sys.syscomments (
   id                   int                  not null,
   number               smallint             null,
   colid                smallint             not null,
   status               smallint             not null,
   ctext                varbinary(8000)      null,
   texttype             smallint             null,
   language             smallint             null,
   encrypted            bit                  not null,
   compressed           bit                  not null,
   text                 nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscomments'
go

/*==============================================================*/
/* Table: sysconfigures                                         */
/*==============================================================*/
create table sys.sysconfigures (
   value                int                  null,
   config               int                  not null,
   comment              nvarchar(255)        not null,
   status               smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysconfigures'
go

/*==============================================================*/
/* Table: sysconstraints                                        */
/*==============================================================*/
create table sys.sysconstraints (
   constid              int                  not null,
   id                   int                  not null,
   colid                smallint             null,
   spare1               tinyint              null,
   status               int                  null,
   actions              int                  null,
   error                int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysconstraints'
go

/*==============================================================*/
/* Table: syscurconfigs                                         */
/*==============================================================*/
create table sys.syscurconfigs (
   value                int                  not null,
   config               smallint             null,
   comment              nvarchar(255)        not null,
   status               smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscurconfigs'
go

/*==============================================================*/
/* Table: syscursorcolumns                                      */
/*==============================================================*/
create table sys.syscursorcolumns (
   cursor_handle        int                  not null,
   column_name          nvarchar(128)        null,
   ordinal_position     int                  not null,
   column_characteristics_flags int                  not null,
   column_size          int                  not null,
   data_type_sql        int                  not null,
   column_precision     tinyint              not null,
   column_scale         tinyint              not null,
   order_position       int                  not null,
   order_direction      nvarchar(1)          null,
   hidden_column        smallint             not null,
   columnid             int                  not null,
   objectid             int                  not null,
   dbid                 int                  not null,
   dbname               nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscursorcolumns'
go

/*==============================================================*/
/* Table: syscursorrefs                                         */
/*==============================================================*/
create table sys.syscursorrefs (
   reference_name       nvarchar(128)        null,
   cursor_scope         tinyint              not null,
   cursor_handl         int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscursorrefs'
go

/*==============================================================*/
/* Table: syscursors                                            */
/*==============================================================*/
create table sys.syscursors (
   cursor_handle        int                  not null,
   cursor_name          nvarchar(128)        null,
   status               int                  not null,
   model                tinyint              not null,
   concurrency          tinyint              not null,
   scrollable           tinyint              not null,
   open_status          tinyint              not null,
   cursor_rows          numeric(10)          null,
   fetch_status         smallint             not null,
   column_count         smallint             not null,
   row_count            numeric(10)          null,
   last_operation       tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscursors'
go

/*==============================================================*/
/* Table: syscursortables                                       */
/*==============================================================*/
create table sys.syscursortables (
   cursor_handle        int                  not null,
   table_owner          nvarchar(128)        null,
   table_name           nvarchar(128)        null,
   optimizer_hint       smallint             not null,
   lock_type            smallint             not null,
   server_name          nvarchar(128)        null,
   objectid             int                  not null,
   dbid                 int                  not null,
   dbname               nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syscursortables'
go

/*==============================================================*/
/* Table: sysdatabases                                          */
/*==============================================================*/
create table sys.sysdatabases (
   name                 sysname(128)         not null,
   dbid                 smallint             null,
   sid                  varbinary(85)        null,
   mode                 smallint             null,
   status               int                  null,
   status2              int                  null,
   crdate               datetime             not null,
   reserved             datetime             null,
   category             int                  null,
   cmptlevel            tinyint              not null,
   filename             nvarchar(260)        null,
   version              smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysdatabases'
go

/*==============================================================*/
/* Table: sysdepends                                            */
/*==============================================================*/
create table sys.sysdepends (
   id                   int                  not null,
   depid                int                  not null,
   number               smallint             null,
   depnumber            smallint             null,
   status               smallint             null,
   deptype              tinyint              not null,
   depdbid              smallint             null,
   depsiteid            smallint             null,
   selall               bit                  not null,
   resultobj            bit                  not null,
   readobj              bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysdepends'
go

/*==============================================================*/
/* Table: sysdevices                                            */
/*==============================================================*/
create table sys.sysdevices (
   name                 sysname(128)         not null,
   size                 int                  null,
   low                  int                  null,
   high                 int                  null,
   status               smallint             null,
   cntrltype            smallint             null,
   phyname              nvarchar(260)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysdevices'
go

/*==============================================================*/
/* Table: sysfilegroups                                         */
/*==============================================================*/
create table sys.sysfilegroups (
   groupid              smallint             null,
   allocpolicy          smallint             null,
   status               int                  null,
   groupname            sysname(128)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysfilegroups'
go

/*==============================================================*/
/* Table: sysfiles                                              */
/*==============================================================*/
create table sys.sysfiles (
   fileid               smallint             null,
   groupid              smallint             null,
   size                 int                  not null,
   maxsize              int                  not null,
   growth               int                  not null,
   status               int                  null,
   perf                 int                  null,
   name                 sysname(128)         not null,
   filename             nvarchar(260)        not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysfiles'
go

/*==============================================================*/
/* Table: sysforeignkeys                                        */
/*==============================================================*/
create table sys.sysforeignkeys (
   constid              int                  not null,
   fkeyid               int                  not null,
   rkeyid               int                  not null,
   fkey                 smallint             null,
   rkey                 smallint             null,
   keyno                smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysforeignkeys'
go

/*==============================================================*/
/* Table: sysfulltextcatalogs                                   */
/*==============================================================*/
create table sys.sysfulltextcatalogs (
   ftcatid              smallint             null,
   name                 sysname(128)         not null,
   status               smallint             null,
   path                 nvarchar(260)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysfulltextcatalogs'
go

/*==============================================================*/
/* Table: sysindexes                                            */
/*==============================================================*/
create table sys.sysindexes (
   id                   int                  not null,
   status               int                  null,
   first                binary(6)            null,
   indid                smallint             null,
   root                 binary(6)            null,
   minlen               smallint             null,
   keycnt               smallint             null,
   groupid              smallint             null,
   dpages               int                  null,
   reserved             int                  null,
   used                 int                  null,
   rowcnt               bigint               null,
   rowmodctr            int                  null,
   reserved3            tinyint              null,
   reserved4            tinyint              null,
   xmaxlen              smallint             null,
   maxirow              smallint             null,
   OrigFillFactor       tinyint              null,
   StatVersion          tinyint              null,
   reserved2            int                  null,
   FirstIAM             binary(6)            null,
   impid                smallint             null,
   lockflags            smallint             null,
   pgmodctr             int                  null,
   keys                 varbinary(1088)      null,
   name                 sysname(128)         null,
   statblob             image(2147483647)    null,
   maxlen               int                  null,
   rows                 int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysindexes'
go

/*==============================================================*/
/* Table: sysindexkeys                                          */
/*==============================================================*/
create table sys.sysindexkeys (
   id                   int                  not null,
   indid                smallint             null,
   colid                smallint             null,
   keyno                smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysindexkeys'
go

/*==============================================================*/
/* Table: syslanguages                                          */
/*==============================================================*/
create table sys.syslanguages (
   langid               smallint             not null,
   dateformat           nchar(3)             not null,
   datefirst            tinyint              not null,
   upgrade              int                  null,
   name                 nvarchar(128)        not null,
   alias                nvarchar(128)        not null,
   months               nvarchar(372)        null,
   shortmonths          nvarchar(132)        null,
   days                 nvarchar(217)        null,
   lcid                 int                  not null,
   msglangid            smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syslanguages'
go

/*==============================================================*/
/* Table: syslockinfo                                           */
/*==============================================================*/
create table sys.syslockinfo (
   rsc_text             nchar(32)            not null,
   rsc_bin              binary(16)           not null,
   rsc_valblk           binary(16)           not null,
   rsc_dbid             smallint             not null,
   rsc_indid            smallint             not null,
   rsc_objid            int                  not null,
   rsc_type             tinyint              not null,
   rsc_flag             tinyint              not null,
   req_mode             tinyint              not null,
   req_status           tinyint              not null,
   req_refcnt           smallint             not null,
   req_cryrefcnt        smallint             not null,
   req_lifetime         int                  not null,
   req_spid             int                  not null,
   req_ecid             int                  not null,
   req_ownertype        smallint             not null,
   req_transactionID    bigint               null,
   req_transactionUOW   uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syslockinfo'
go

/*==============================================================*/
/* Table: syslogins                                             */
/*==============================================================*/
create table sys.syslogins (
   sid                  varbinary(85)        null,
   status               smallint             null,
   createdate           datetime             not null,
   updatedate           datetime             not null,
   accdate              datetime             not null,
   totcpu               int                  null,
   totio                int                  null,
   spacelimit           int                  null,
   timelimit            int                  null,
   resultlimit          int                  null,
   name                 sysname(128)         not null,
   dbname               sysname(128)         null,
   password             sysname(128)         null,
   language             sysname(128)         null,
   denylogin            int                  null,
   hasaccess            int                  null,
   isntname             int                  null,
   isntgroup            int                  null,
   isntuser             int                  null,
   sysadmin             int                  null,
   securityadmin        int                  null,
   serveradmin          int                  null,
   setupadmin           int                  null,
   processadmin         int                  null,
   diskadmin            int                  null,
   dbcreator            int                  null,
   bulkadmin            int                  null,
   loginname            sysname(128)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syslogins'
go

/*==============================================================*/
/* Table: sysmembers                                            */
/*==============================================================*/
create table sys.sysmembers (
   memberuid            smallint             null,
   groupuid             smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysmembers'
go

/*==============================================================*/
/* Table: sysmessages                                           */
/*==============================================================*/
create table sys.sysmessages (
   error                int                  not null,
   severity             tinyint              null,
   dlevel               smallint             null,
   description          nvarchar(255)        null,
   msglangid            smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysmessages'
go

/*==============================================================*/
/* Table: sysobjects                                            */
/*==============================================================*/
create table sys.sysobjects (
   name                 sysname(128)         not null,
   id                   int                  not null,
   xtype                char(2)              not null,
   uid                  smallint             null,
   info                 smallint             null,
   status               int                  null,
   base_schema_ver      int                  null,
   replinfo             int                  null,
   parent_obj           int                  not null,
   crdate               datetime             not null,
   ftcatid              smallint             null,
   schema_ver           int                  null,
   stats_schema_ver     int                  null,
   type                 char(2)              null,
   userstat             smallint             null,
   sysstat              smallint             null,
   indexdel             smallint             null,
   refdate              datetime             not null,
   version              int                  null,
   deltrig              int                  null,
   instrig              int                  null,
   updtrig              int                  null,
   seltrig              int                  null,
   category             int                  null,
   cache                smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysobjects'
go

/*==============================================================*/
/* Table: sysoledbusers                                         */
/*==============================================================*/
create table sys.sysoledbusers (
   rmtsrvid             smallint             null,
   rmtloginame          sysname(128)         null,
   rmtpassword          sysname(128)         null,
   loginsid             varbinary(85)        null,
   status               smallint             null,
   changedate           datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysoledbusers'
go

/*==============================================================*/
/* Table: sysopentapes                                          */
/*==============================================================*/
create table sys.sysopentapes (
   openTape             nvarchar(64)         not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysopentapes'
go

/*==============================================================*/
/* Table: sysperfinfo                                           */
/*==============================================================*/
create table sys.sysperfinfo (
   object_name          nchar(128)           not null,
   counter_name         nchar(128)           not null,
   instance_name        nchar(128)           null,
   cntr_value           bigint               not null,
   cntr_type            int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysperfinfo'
go

/*==============================================================*/
/* Table: syspermissions                                        */
/*==============================================================*/
create table sys.syspermissions (
   id                   int                  not null,
   grantee              smallint             null,
   grantor              smallint             null,
   actadd               smallint             null,
   actmod               smallint             null,
   seladd               varbinary(4000)      null,
   selmod               varbinary(4000)      null,
   updadd               varbinary(4000)      null,
   updmod               varbinary(4000)      null,
   refadd               varbinary(4000)      null,
   refmod               varbinary(4000)      null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'syspermissions'
go

/*==============================================================*/
/* Table: sysprocesses                                          */
/*==============================================================*/
create table sys.sysprocesses (
   spid                 smallint             not null,
   kpid                 smallint             not null,
   blocked              smallint             not null,
   waittype             binary(2)            not null,
   waittime             bigint               not null,
   lastwaittype         nchar(32)            not null,
   waitresource         nchar(256)           not null,
   dbid                 smallint             not null,
   uid                  smallint             null,
   cpu                  int                  not null,
   physical_io          bigint               not null,
   memusage             int                  not null,
   login_time           datetime             not null,
   last_batch           datetime             not null,
   ecid                 smallint             not null,
   open_tran            smallint             not null,
   status               nchar(30)            not null,
   sid                  binary(86)           not null,
   hostname             nchar(128)           not null,
   program_name         nchar(128)           not null,
   hostprocess          nchar(10)            not null,
   cmd                  nchar(16)            not null,
   nt_domain            nchar(128)           not null,
   nt_username          nchar(128)           not null,
   net_address          nchar(12)            not null,
   net_library          nchar(12)            not null,
   loginame             nchar(128)           not null,
   context_info         binary(128)          not null,
   sql_handle           binary(20)           not null,
   stmt_start           int                  not null,
   stmt_end             int                  not null,
   request_id           int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysprocesses'
go

/*==============================================================*/
/* Table: sysprotects                                           */
/*==============================================================*/
create table sys.sysprotects (
   id                   int                  not null,
   uid                  smallint             null,
   action               tinyint              null,
   protecttype          tinyint              null,
   columns              varbinary(8000)      null,
   grantor              smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysprotects'
go

/*==============================================================*/
/* Table: sysreferences                                         */
/*==============================================================*/
create table sys.sysreferences (
   constid              int                  not null,
   fkeyid               int                  not null,
   rkeyid               int                  null,
   rkeyindid            smallint             null,
   keycnt               smallint             null,
   forkeys              varbinary(32)        null,
   refkeys              varbinary(32)        null,
   fkeydbid             smallint             null,
   rkeydbid             smallint             null,
   fkey1                smallint             null,
   fkey2                smallint             null,
   fkey3                smallint             null,
   fkey4                smallint             null,
   fkey5                smallint             null,
   fkey6                smallint             null,
   fkey7                smallint             null,
   fkey8                smallint             null,
   fkey9                smallint             null,
   fkey10               smallint             null,
   fkey11               smallint             null,
   fkey12               smallint             null,
   fkey13               smallint             null,
   fkey14               smallint             null,
   fkey15               smallint             null,
   fkey16               smallint             null,
   rkey1                smallint             null,
   rkey2                smallint             null,
   rkey3                smallint             null,
   rkey4                smallint             null,
   rkey5                smallint             null,
   rkey6                smallint             null,
   rkey7                smallint             null,
   rkey8                smallint             null,
   rkey9                smallint             null,
   rkey10               smallint             null,
   rkey11               smallint             null,
   rkey12               smallint             null,
   rkey13               smallint             null,
   rkey14               smallint             null,
   rkey15               smallint             null,
   rkey16               smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysreferences'
go

/*==============================================================*/
/* Table: sysremotelogins                                       */
/*==============================================================*/
create table sys.sysremotelogins (
   remoteserverid       smallint             null,
   remoteusername       sysname(128)         null,
   status               smallint             null,
   sid                  varbinary(85)        null,
   changedate           datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysremotelogins'
go

/*==============================================================*/
/* Table: sysservers                                            */
/*==============================================================*/
create table sys.sysservers (
   srvid                smallint             null,
   srvstatus            smallint             null,
   srvname              sysname(128)         not null,
   srvproduct           sysname(128)         not null,
   providername         nvarchar(128)        not null,
   datasource           nvarchar(4000)       null,
   location             nvarchar(4000)       null,
   providerstring       nvarchar(4000)       null,
   schemadate           datetime             not null,
   topologyx            int                  null,
   topologyy            int                  null,
   catalog              sysname(128)         null,
   srvcollation         sysname(128)         null,
   connecttimeout       int                  null,
   querytimeout         int                  null,
   srvnetname           char(30)             null,
   isremote             bit                  null,
   rpc                  bit                  not null,
   pub                  bit                  not null,
   sub                  bit                  null,
   dist                 bit                  null,
   dpub                 bit                  null,
   rpcout               bit                  not null,
   dataaccess           bit                  not null,
   collationcompatible  bit                  not null,
   system               bit                  not null,
   useremotecollation   bit                  not null,
   lazyschemavalidation bit                  not null,
   collation            sysname(128)         null,
   nonsqlsub            bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysservers'
go

/*==============================================================*/
/* Table: system_columns                                        */
/*==============================================================*/
create table sys.system_columns (
   object_id            int                  not null,
   name                 sysname(128)         not null,
   column_id            int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_ansi_padded       bit                  not null,
   is_rowguidcol        bit                  not null,
   is_identity          bit                  not null,
   is_computed          bit                  not null,
   is_filestream        bit                  not null,
   is_replicated        bit                  not null,
   is_non_sql_subscribed bit                  not null,
   is_merge_published   bit                  not null,
   is_dts_replicated    bit                  not null,
   is_xml_document      bit                  not null,
   xml_collection_id    int                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   is_sparse            bit                  not null,
   is_column_set        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_columns'
go

/*==============================================================*/
/* Table: system_components_surface_area_configuration          */
/*==============================================================*/
create table sys.system_components_surface_area_configuration (
   component_name       sysname(128)         null,
   database_name        sysname(128)         null,
   schema_name          nvarchar(128)        null,
   object_name          nvarchar(128)        not null,
   state                tinyint              null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_components_surface_area_configuration'
go

/*==============================================================*/
/* Table: system_internals_allocation_units                     */
/*==============================================================*/
create table sys.system_internals_allocation_units (
   allocation_unit_id   bigint               not null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   container_id         bigint               not null,
   filegroup_id         smallint             not null,
   total_pages          bigint               not null,
   used_pages           bigint               not null,
   data_pages           bigint               not null,
   first_page           binary(6)            not null,
   root_page            binary(6)            not null,
   first_iam_page       binary(6)            not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_internals_allocation_units'
go

/*==============================================================*/
/* Table: system_internals_partition_columns                    */
/*==============================================================*/
create table sys.system_internals_partition_columns (
   partition_id         bigint               not null,
   partition_column_id  int                  not null,
   modified_count       bigint               not null,
   max_inrow_length     smallint             null,
   is_replicated        bit                  null,
   is_logged_for_replication bit                  null,
   is_dropped           bit                  null,
   system_type_id       tinyint              null,
   max_length           smallint             null,
   "precision"          tinyint              null,
   scale                tinyint              null,
   collation_name       sysname(128)         null,
   is_filestream        bit                  null,
   key_ordinal          smallint             not null,
   is_nullable          bit                  null,
   is_descending_key    bit                  null,
   is_uniqueifier       bit                  null,
   leaf_offset          smallint             null,
   internal_offset      smallint             null,
   leaf_bit_position    tinyint              null,
   internal_bit_position tinyint              null,
   leaf_null_bit        smallint             null,
   internal_null_bit    smallint             null,
   is_anti_matter       bit                  null,
   partition_column_guid uniqueidentifier(36) null,
   is_sparse            bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_internals_partition_columns'
go

/*==============================================================*/
/* Table: system_internals_partitions                           */
/*==============================================================*/
create table sys.system_internals_partitions (
   partition_id         bigint               not null,
   object_id            int                  not null,
   index_id             int                  not null,
   partition_number     int                  not null,
   rows                 bigint               not null,
   filestream_filegroup_id smallint             not null,
   is_orphaned          bit                  null,
   dropped_lob_column_state tinyint              null,
   is_unique            bit                  null,
   is_replicated        bit                  null,
   is_logged_for_replication bit                  null,
   max_null_bit_used    smallint             not null,
   max_leaf_length      int                  not null,
   min_leaf_length      smallint             not null,
   max_internal_length  smallint             not null,
   min_internal_length  smallint             not null,
   allows_nullable_keys bit                  null,
   allow_row_locks      bit                  null,
   allow_page_locks     bit                  null,
   is_data_row_format   bit                  null,
   is_not_versioned     bit                  null,
   filestream_guid      uniqueidentifier(36) null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_internals_partitions'
go

/*==============================================================*/
/* Table: system_objects                                        */
/*==============================================================*/
create table sys.system_objects (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_objects'
go

/*==============================================================*/
/* Table: system_parameters                                     */
/*==============================================================*/
create table sys.system_parameters (
   object_id            int                  not null,
   name                 sysname(128)         not null,
   parameter_id         int                  not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   is_output            bit                  not null,
   is_cursor_ref        bit                  not null,
   has_default_value    bit                  not null,
   is_xml_document      bit                  not null,
   default_value        sql_variant          null,
   xml_collection_id    int                  not null,
   is_readonly          bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_parameters'
go

/*==============================================================*/
/* Table: system_sql_modules                                    */
/*==============================================================*/
create table sys.system_sql_modules (
   object_id            int                  not null,
   definition           ntext(1073741823)    null,
   uses_ansi_nulls      bit                  not null,
   uses_quoted_identifier bit                  not null,
   is_schema_bound      bit                  not null,
   uses_database_collation bit                  not null,
   is_recompiled        bit                  not null,
   null_on_null_input   bit                  not null,
   execute_as_principal_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_sql_modules'
go

/*==============================================================*/
/* Table: system_views                                          */
/*==============================================================*/
create table sys.system_views (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   is_replicated        bit                  not null,
   has_replication_filter bit                  not null,
   has_opaque_metadata  bit                  not null,
   has_unchecked_assembly_data bit                  not null,
   with_check_option    bit                  not null,
   is_date_correlation_view bit                  not null,
   is_tracked_by_cdc    bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'system_views'
go

/*==============================================================*/
/* Table: systypes                                              */
/*==============================================================*/
create table sys.systypes (
   name                 sysname(128)         not null,
   xtype                tinyint              not null,
   status               tinyint              null,
   xusertype            smallint             null,
   length               smallint             not null,
   xprec                tinyint              not null,
   xscale               tinyint              not null,
   tdefault             int                  not null,
   domain               int                  not null,
   uid                  smallint             null,
   reserved             smallint             null,
   collationid          int                  null,
   usertype             smallint             null,
   variable             bit                  not null,
   allownulls           bit                  null,
   type                 tinyint              not null,
   printfmt             varchar(255)         null,
   prec                 smallint             null,
   scale                tinyint              null,
   collation            sysname(128)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'systypes'
go

/*==============================================================*/
/* Table: sysusers                                              */
/*==============================================================*/
create table sys.sysusers (
   uid                  smallint             null,
   status               smallint             null,
   name                 sysname(128)         not null,
   sid                  varbinary(85)        null,
   roles                varbinary(2048)      null,
   createdate           datetime             not null,
   updatedate           datetime             not null,
   altuid               smallint             null,
   password             varbinary(256)       null,
   gid                  smallint             null,
   environ              varchar(255)         null,
   hasdbaccess          int                  null,
   islogin              int                  null,
   isntname             int                  null,
   isntgroup            int                  null,
   isntuser             int                  null,
   issqluser            int                  null,
   isaliased            int                  null,
   issqlrole            int                  null,
   isapprole            int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'sysusers'
go

/*==============================================================*/
/* Table: table_types                                           */
/*==============================================================*/
create table sys.table_types (
   name                 sysname(128)         not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   schema_id            int                  not null,
   principal_id         int                  null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_user_defined      bit                  not null,
   is_assembly_type     bit                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   is_table_type        bit                  not null,
   type_table_object_id int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'table_types'
go

/*==============================================================*/
/* Table: tables                                                */
/*==============================================================*/
create table sys.tables (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   lob_data_space_id    int                  null,
   filestream_data_space_id int                  null,
   max_column_id_used   int                  not null,
   lock_on_bulk_load    bit                  not null,
   uses_ansi_nulls      bit                  null,
   is_replicated        bit                  null,
   has_replication_filter bit                  null,
   is_merge_published   bit                  null,
   is_sync_tran_subscribed bit                  null,
   has_unchecked_assembly_data bit                  not null,
   text_in_row_limit    int                  null,
   large_value_types_out_of_row bit                  null,
   is_tracked_by_cdc    bit                  null,
   lock_escalation      tinyint              null,
   lock_escalation_desc nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'tables'
go

/*==============================================================*/
/* Table: tcp_endpoints                                         */
/*==============================================================*/
create table sys.tcp_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   port                 int                  not null,
   is_dynamic_port      bit                  not null,
   ip_address           varchar(45)          null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'tcp_endpoints'
go

/*==============================================================*/
/* Table: trace_categories                                      */
/*==============================================================*/
create table sys.trace_categories (
   category_id          smallint             not null,
   name                 nvarchar(128)        null,
   type                 tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trace_categories'
go

/*==============================================================*/
/* Table: trace_columns                                         */
/*==============================================================*/
create table sys.trace_columns (
   trace_column_id      smallint             not null,
   name                 nvarchar(128)        null,
   type_name            nvarchar(128)        null,
   max_size             int                  null,
   is_filterable        bit                  not null,
   is_repeatable        bit                  not null,
   is_repeated_base     bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trace_columns'
go

/*==============================================================*/
/* Table: trace_event_bindings                                  */
/*==============================================================*/
create table sys.trace_event_bindings (
   trace_event_id       smallint             not null,
   trace_column_id      smallint             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trace_event_bindings'
go

/*==============================================================*/
/* Table: trace_events                                          */
/*==============================================================*/
create table sys.trace_events (
   trace_event_id       smallint             not null,
   category_id          smallint             not null,
   name                 nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trace_events'
go

/*==============================================================*/
/* Table: trace_subclass_values                                 */
/*==============================================================*/
create table sys.trace_subclass_values (
   trace_event_id       smallint             not null,
   trace_column_id      smallint             not null,
   subclass_name        nvarchar(128)        null,
   subclass_value       smallint             null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trace_subclass_values'
go

/*==============================================================*/
/* Table: traces                                                */
/*==============================================================*/
create table sys.traces (
   id                   int                  not null,
   status               int                  not null,
   path                 nvarchar(260)        null,
   max_size             bigint               null,
   stop_time            datetime             null,
   max_files            int                  null,
   is_rowset            bit                  null,
   is_rollover          bit                  null,
   is_shutdown          bit                  null,
   is_default           bit                  null,
   buffer_count         int                  null,
   buffer_size          int                  null,
   file_position        bigint               null,
   reader_spid          int                  null,
   start_time           datetime             null,
   last_event_time      datetime             null,
   event_count          bigint               null,
   dropped_event_count  int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'traces'
go

/*==============================================================*/
/* Table: transmission_queue                                    */
/*==============================================================*/
create table sys.transmission_queue (
   conversation_handle  uniqueidentifier(36) not null,
   to_service_name      nvarchar(256)        null,
   to_broker_instance   nvarchar(128)        null,
   from_service_name    nvarchar(256)        null,
   service_contract_name nvarchar(256)        null,
   enqueue_time         datetime             not null,
   message_sequence_number bigint               not null,
   message_type_name    nvarchar(256)        null,
   is_conversation_error bit                  not null,
   is_end_of_dialog     bit                  not null,
   message_body         image(2147483647)    null,
   transmission_status  nvarchar(4000)       null,
   priority             tinyint              not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'transmission_queue'
go

/*==============================================================*/
/* Table: trigger_event_types                                   */
/*==============================================================*/
create table sys.trigger_event_types (
   type                 int                  not null,
   type_name            nvarchar(64)         null,
   parent_type          int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trigger_event_types'
go

/*==============================================================*/
/* Table: trigger_events                                        */
/*==============================================================*/
create table sys.trigger_events (
   object_id            int                  not null,
   type                 int                  not null,
   type_desc            nvarchar(128)        not null,
   is_first             bit                  null,
   is_last              bit                  null,
   event_group_type     int                  null,
   event_group_type_desc nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'trigger_events'
go

/*==============================================================*/
/* Table: triggers                                              */
/*==============================================================*/
create table sys.triggers (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   parent_class         tinyint              not null,
   parent_class_desc    nvarchar(60)         null,
   parent_id            int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_disabled          bit                  not null,
   is_not_for_replication bit                  not null,
   is_instead_of_trigger bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'triggers'
go

/*==============================================================*/
/* Table: type_assembly_usages                                  */
/*==============================================================*/
create table sys.type_assembly_usages (
   user_type_id         int                  not null,
   assembly_id          int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'type_assembly_usages'
go

/*==============================================================*/
/* Table: types                                                 */
/*==============================================================*/
create table sys.types (
   name                 sysname(128)         not null,
   system_type_id       tinyint              not null,
   user_type_id         int                  not null,
   schema_id            int                  not null,
   principal_id         int                  null,
   max_length           smallint             not null,
   "precision"          tinyint              not null,
   scale                tinyint              not null,
   collation_name       sysname(128)         null,
   is_nullable          bit                  null,
   is_user_defined      bit                  not null,
   is_assembly_type     bit                  not null,
   default_object_id    int                  not null,
   rule_object_id       int                  not null,
   is_table_type        bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'types'
go

/*==============================================================*/
/* Table: user_token                                            */
/*==============================================================*/
create table sys.user_token (
   principal_id         int                  null,
   sid                  varbinary(85)        null,
   name                 nvarchar(128)        null,
   type                 nvarchar(128)        null,
   usage                nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'user_token'
go

/*==============================================================*/
/* Table: via_endpoints                                         */
/*==============================================================*/
create table sys.via_endpoints (
   name                 sysname(128)         not null,
   endpoint_id          int                  not null,
   principal_id         int                  null,
   protocol             tinyint              not null,
   protocol_desc        nvarchar(60)         null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   state                tinyint              null,
   state_desc           nvarchar(60)         null,
   is_admin_endpoint    bit                  not null,
   discriminator        nvarchar(128)        null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'via_endpoints'
go

/*==============================================================*/
/* Table: views                                                 */
/*==============================================================*/
create table sys.views (
   name                 sysname(128)         not null,
   object_id            int                  not null,
   principal_id         int                  null,
   schema_id            int                  not null,
   parent_object_id     int                  not null,
   type                 char(2)              not null,
   type_desc            nvarchar(60)         null,
   create_date          datetime             not null,
   modify_date          datetime             not null,
   is_ms_shipped        bit                  not null,
   is_published         bit                  not null,
   is_schema_published  bit                  not null,
   is_replicated        bit                  null,
   has_replication_filter bit                  null,
   has_opaque_metadata  bit                  not null,
   has_unchecked_assembly_data bit                  not null,
   with_check_option    bit                  not null,
   is_date_correlation_view bit                  not null,
   is_tracked_by_cdc    bit                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'views'
go

/*==============================================================*/
/* Table: xml_indexes                                           */
/*==============================================================*/
create table sys.xml_indexes (
   object_id            int                  not null,
   name                 sysname(128)         null,
   index_id             int                  not null,
   type                 tinyint              not null,
   type_desc            nvarchar(60)         null,
   is_unique            bit                  null,
   data_space_id        int                  not null,
   ignore_dup_key       bit                  null,
   is_primary_key       bit                  null,
   is_unique_constraint bit                  null,
   fill_factor          tinyint              not null,
   is_padded            bit                  null,
   is_disabled          bit                  null,
   is_hypothetical      bit                  null,
   allow_row_locks      bit                  null,
   allow_page_locks     bit                  null,
   using_xml_index_id   int                  null,
   secondary_type       char(1)              null,
   secondary_type_desc  nvarchar(60)         null,
   has_filter           bit                  not null,
   filter_definition    ntext(1073741823)    null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_indexes'
go

/*==============================================================*/
/* Table: xml_schema_attributes                                 */
/*==============================================================*/
create table sys.xml_schema_attributes (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null,
   is_default_fixed     bit                  not null,
   must_be_qualified    bit                  not null,
   default_value        nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_attributes'
go

/*==============================================================*/
/* Table: xml_schema_collections                                */
/*==============================================================*/
create table sys.xml_schema_collections (
   xml_collection_id    int                  not null,
   schema_id            int                  not null,
   principal_id         int                  null,
   name                 sysname(128)         not null,
   create_date          datetime             not null,
   modify_date          datetime             not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_collections'
go

/*==============================================================*/
/* Table: xml_schema_component_placements                       */
/*==============================================================*/
create table sys.xml_schema_component_placements (
   xml_component_id     int                  not null,
   placement_id         int                  not null,
   placed_xml_component_id int                  not null,
   is_default_fixed     bit                  not null,
   min_occurences       int                  not null,
   max_occurences       int                  not null,
   default_value        nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_component_placements'
go

/*==============================================================*/
/* Table: xml_schema_components                                 */
/*==============================================================*/
create table sys.xml_schema_components (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_components'
go

/*==============================================================*/
/* Table: xml_schema_elements                                   */
/*==============================================================*/
create table sys.xml_schema_elements (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null,
   is_default_fixed     bit                  not null,
   is_abstract          bit                  not null,
   is_nillable          bit                  not null,
   must_be_qualified    bit                  not null,
   is_extension_blocked bit                  not null,
   is_restriction_blocked bit                  not null,
   is_substitution_blocked bit                  not null,
   is_final_extension   bit                  not null,
   is_final_restriction bit                  not null,
   default_value        nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_elements'
go

/*==============================================================*/
/* Table: xml_schema_facets                                     */
/*==============================================================*/
create table sys.xml_schema_facets (
   xml_component_id     int                  not null,
   facet_id             int                  not null,
   kind                 char(2)              not null,
   kind_desc            nvarchar(60)         null,
   is_fixed             bit                  not null,
   value                nvarchar(4000)       null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_facets'
go

/*==============================================================*/
/* Table: xml_schema_model_groups                               */
/*==============================================================*/
create table sys.xml_schema_model_groups (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null,
   compositor           char(1)              not null,
   compositor_desc      nvarchar(60)         null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_model_groups'
go

/*==============================================================*/
/* Table: xml_schema_namespaces                                 */
/*==============================================================*/
create table sys.xml_schema_namespaces (
   xml_collection_id    int                  not null,
   name                 nvarchar(4000)       null,
   xml_namespace_id     int                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_namespaces'
go

/*==============================================================*/
/* Table: xml_schema_types                                      */
/*==============================================================*/
create table sys.xml_schema_types (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null,
   is_abstract          bit                  not null,
   allows_mixed_content bit                  not null,
   is_extension_blocked bit                  not null,
   is_restriction_blocked bit                  not null,
   is_final_extension   bit                  not null,
   is_final_restriction bit                  not null,
   is_final_list_member bit                  not null,
   is_final_union_member bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_types'
go

/*==============================================================*/
/* Table: xml_schema_wildcard_namespaces                        */
/*==============================================================*/
create table sys.xml_schema_wildcard_namespaces (
   xml_component_id     int                  not null,
   namespace            nvarchar(4000)       not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_wildcard_namespaces'
go

/*==============================================================*/
/* Table: xml_schema_wildcards                                  */
/*==============================================================*/
create table sys.xml_schema_wildcards (
   xml_component_id     int                  not null,
   xml_collection_id    int                  not null,
   xml_namespace_id     int                  not null,
   is_qualified         bit                  not null,
   name                 nvarchar(4000)       null,
   symbol_space         char(1)              not null,
   symbol_space_desc    nvarchar(60)         null,
   kind                 char(1)              not null,
   kind_desc            nvarchar(60)         null,
   derivation           char(1)              not null,
   derivation_desc      nvarchar(60)         null,
   base_xml_component_id int                  null,
   scoping_xml_component_id int                  null,
   process_content      char(1)              not null,
   process_content_desc nvarchar(60)         null,
   disallow_namespaces  bit                  not null
)
go

execute sp_addextendedproperty 'MS_Description', 
   'VIEW',
   'user', 'sys', 'table', 'xml_schema_wildcards'
go

alter table dbo.CL_RECEIPT_DETAIL
   add constraint FK_BILLNO foreign key (BillNo)
      references dbo.CL_RECEIPT_MASTER (BillNo)
         on delete cascade
go

alter table dbo.ORD_BOM
   add constraint FK_ORDER_BOM_ORDER_DETAIL foreign key (DETAILID)
      references dbo.ORD_DETAIL (DETAILID)
         on delete cascade
go

alter table dbo.ORD_CG_DETAIL
   add constraint FK_ORDER_CG_DETAIL_ORDER_CG_MASTER1 foreign key (BILLNO)
      references dbo.ORD_CG_MASTER (BILLNO)
         on delete cascade
go

alter table dbo.ORD_DETAIL
   add constraint FK_ORDER_DETAIL_ORDER_MASTER foreign key (BILLNO)
      references dbo.ORD_MASTER (BILLNO)
         on delete cascade
go

alter table dbo.ORD_ITEM_DA_BOM
   add constraint FK_PUB_ITEM_DA_BOM_PUB_ITEM_DA foreign key (ITEM_INTERNAL_CODE)
      references dbo.ORD_ITEM_DA (ITEM_INTERNAL_CODE)
         on delete cascade
go

alter table dbo.ORD_PCDETAIL
   add constraint FK_ORDER_PCDETAIL_ORDER_PCMASTER foreign key (BILLNO)
      references dbo.ORD_PCMASTER (BillNo)
         on delete cascade
go

alter table dbo.ORD_PURCHASE_DETAIL
   add constraint FK_PUR_PURCHASE_DETAIL_PUR_PURCHASE_MASTER1 foreign key (BILLNO)
      references dbo.ORD_PURCHASE_MASTER (BILLNO)
         on delete cascade
go

alter table dbo.ORD_SEND_DETAIL
   add constraint FK_ORDER_SEND_DETAIL_ORDER_SEND_MASTER foreign key (BILLNO)
      references dbo.ORD_SEND_MASTER (BILLNO)
         on delete cascade
go

alter table dbo.ORD_SEND_REMARK
   add constraint FK_ORDER_SEND_REMARK_ORDER_SEND_MASTER foreign key (BILLNO)
      references dbo.ORD_SEND_MASTER (BILLNO)
         on delete cascade
go

alter table dbo.ORD_VEHICLE_DETAIL
   add constraint FK_VEHICLE_ORD_DETAIL_VEHICLE_ORD_MASTER foreign key (BillNo)
      references dbo.ORD_VEHICLE_MASTER (BillNo)
         on delete cascade
go

alter table dbo.PUB_ITEM_DETAIL
   add constraint FK_PUB_ITEM_DETAIL_INTERNAL_CODE foreign key (ITEM_INTERNAL_CODE)
      references dbo.PUB_ITEM_LIST (ITEM_INTERNAL_CODE)
         on delete cascade
go

alter table dbo.PUB_ITEM_LIST
   add constraint FK_INTERNAL_CODE foreign key (ITEM_INTERNAL_CODE)
      references dbo.PUB_ITEM_LIST (ITEM_INTERNAL_CODE)
go

alter table dbo.SAL_RECEIPT_DETAIL
   add constraint FK_SAL_BILLNO foreign key (BillNo)
      references dbo.SAL_RECEIPT_MASTER (BillNO)
         on delete cascade
go

alter table dbo.STEEL_GG_BOM
   add constraint FK_STEEL_GG_BOM_STEEL_GG foreign key (INTERNAL_CODE)
      references dbo.STEEL_GG (INTERNAL_CODE)
         on delete cascade
go

alter table dbo.STEEL_RECEIPT_DETAIL
   add constraint FK_STEEL_RECEIPT_DETAIL_STEEL_RECEIPT_MASTER foreign key (BillNo)
      references dbo.STEEL_RECEIPT_MASTER (BillNo)
         on delete cascade
go

alter table dbo.WL_RECEIPT_DETAIL
   add constraint FK_WL_RECEIPT_DETAIL_WL_RECEIPT_MASTER foreign key (BillNO)
      references dbo.WL_RECEIPT_MASTER (BillNO)
         on delete cascade
go


create procedure dbo.PUB_ITEM_LIST_SYNCHRONOUS_SAL_ITEM_STOCK_DETAIL @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME VARCHAR(50)='' as
BEGIN
	DECLARE @SQL_STR VARCHAR(8000)
	
	--===更新库存表2012-11-22 
	 INSERT INTO SAL_ITEM_STOCK_DETAIL(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, Actual_Qty)
	 SELECT ''+@STOCK_CODE+'',''+@STOCK_NAME+'', ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, '0' FROM PUB_ITEM_LIST
	 WHERE ITEM_INTERNAL_CODE NOT IN 
	 (SELECT  ITEM_INTERNAL_CODE from SAL_ITEM_STOCK_DETAIL 
	 WHERE STOCK_CODE=@STOCK_CODE )
	
	
	--=====更新货名===============
	UPDATE T1  set   T1.ITEM_NAME=T2.ITEM_NAME 
    from 
    (SELECT   ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     SAL_ITEM_STOCK_DETAIL) T1,
    (SELECT  ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     PUB_ITEM_LIST) T2
	 WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE   
	 



	  


END
go


create procedure dbo.SP_CL_BILL_INSERT_RECORD @BILLNO VARCHAR(50)='',
 @ITEM_INTERNAL_CODE VARCHAR(50)='' as
BEGIN
	--DECLARE @SEQUENCE INT

   -- SET  @SEQUENCE=(SELECT MAX(SEQUENCE)+1   FROM CL_RECEIPT_DETAIL WHERE  BillNo=@BILLNO) 
  -- select @SEQUENCE = (SELECT MAX(SEQUENCE)+1   FROM CL_RECEIPT_DETAIL WHERE  BillNo=@BILLNO)
   -- PRINT  @SEQUENCE
    
    
    

    
    
INSERT INTO CL_RECEIPT_DETAIL
      (BILLNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,
       SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,QUANTITY,PAYAMOUNT,DESCRIPTION,REMARK)
SELECT @BILLNO,
       ''+(SELECT MAX(SEQUENCE)+1  AS SEQUENCE  FROM CL_RECEIPT_DETAIL WHERE  BillNo=@BILLNO)+'' ,
       ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,
       SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,'1',NET_PRICE,DESCRIPTION,REMARK
FROM  CL_ITEM_STOCK_DETAIL
WHERE ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE 













END
go


create procedure dbo.SP_CL_COPY_RECEIPT @BillNo varchar(50),
 @newBillNo varchar(50) as
BEGIN

INSERT INTO CL_RECEIPT_MASTER(BillNo,CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,STOCK_CODE,STOCK_NAME,BILL_STATUS,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE)
select ''+@newBillNo+'',CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,STOCK_CODE,STOCK_NAME,BILL_STATUS,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE from dbo.CL_RECEIPT_MASTER 
where BillNo=''+@BillNo+'' 



END
go


create procedure dbo.SP_CL_ITEM_TONGBU @ITEM_INTERNAL_CODE VARCHAR(50)='' as
BEGIN  	
 	--dbo.SAL_RECEIPT_DETAIL单据与产品档案同步 
   UPDATE T3 SET T3.ITEM_CODE=T4.ITEM_CODE,
   T3.ITEM_NAME=T4.ITEM_NAME,
   T3.PARENT_ITEM_CODE=T4.PARENT_ITEM_CODE,  
   T3.ITEM_TYPE=T4.ITEM_TYPE,    
   T3.ITEM_COLOR=T4.ITEM_COLOR, 
   T3.SPECIFICATIONS=T4.SPECIFICATIONS, 
   T3.MEASURE_UNIT=T4.MEASURE_UNIT,
   T3.ITEM_JZ=T4.ITEM_JZ    
   FROM 
  (SELECT   ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,ITEM_JZ FROM CL_RECEIPT_DETAIL) T3, 
  (SELECT  ITEM_INTERNAL_CODE,ITEM_CODE,  ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,ITEM_JZ FROM     CL_ITEM_STOCK_DETAIL)  T4 
  WHERE  T3.ITEM_INTERNAL_CODE=T4.ITEM_INTERNAL_CODE 
  
 
 ---物料与产品BOM表同步
   UPDATE T1 SET T1.ITEM_NAME=T2.ITEM_NAME,   
   T1.PARENT_ITEM_CODE=T2.PARENT_ITEM_CODE,  
   T1.ITEM_TYPE=T2.ITEM_TYPE,    
   T1.ITEM_COLOR=T2.ITEM_COLOR, 
   T1.SPECIFICATIONS=T2.SPECIFICATIONS, 
   T1.MEASURE_UNIT=T2.MEASURE_UNIT,
   T1.ITEM_JZ=T2.ITEM_JZ,
   T1.ITEM_HZ=T2.ITEM_HZ,
   T1.ITEM_GYLC=T2.ITEM_GYLC, 
   T1.ITEM_LK=T2.ITEM_LK,
   T1.ITEM_LH=T2.ITEM_LH,
   T1.ITEM_BJ=T2.ITEM_BJ, 
   T1.[DESCRIPTION]=T2.[DESCRIPTION]  
   FROM 
  (SELECT ITEM_INTERNAL_CODE,ITEM_INTERNAL_CODE_CL,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,ITEM_JZ,ITEM_HZ,ITEM_GYLC,ITEM_LK,ITEM_LH,ITEM_BJ,[DESCRIPTION] FROM PUB_ITEM_DETAIL) T1, 
  (SELECT ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,ITEM_JZ,ITEM_HZ,ITEM_GYLC,ITEM_LK,ITEM_LH,ITEM_BJ,[DESCRIPTION] FROM     CL_ITEM_STOCK_DETAIL)  T2 
  WHERE  T1.ITEM_INTERNAL_CODE_CL=T2.ITEM_INTERNAL_CODE 
 ---2015-06-03 一定是T1.ITEM_INTERNAL_CODE_CL=T2.ITEM_INTERNAL_CODE 一定要小心  
 
                   	
               	
END
go


create procedure dbo.SP_CL_JXC @Begindate char(10)='2008-01-01',
 @Enddate   char(10)='2088-01-01',
 @sITEM_CODE   varchar(200)='',			--材料编号                          		
 @sITEM_NAME    varchar(200)='',         --材料名称                                                         
 @sPARENT_ITEM_CODE varchar(200)='',             --类别
 @sType  int=0                                  
                            --1--(到材料编号)                                        
                            --2--到材料名称)                                        
                            --3--(类别) as
BEGIN
declare @sql_str varchar(8000)



CREATE TABLE #TempJXC
    (
    [ITEM_INTERNAL_CODE]  VARCHAR(50),
	[ITEM_CODE] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[ITEM_NAME] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[SPECIFICATIONS] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,		
	[PARENT_ITEM_CODE] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[ITEM_COLOR] [nvarchar](20),
	[MEASURE_UNIT] [nvarchar](6),
    [NET_PRICE] [float] NULL,
    [PRICE] [float] NULL,
	[beginQty] [float] NULL,	
    [InQty] [float] NULL ,
    [InPayAmount] [float] NULL ,
	[OutQty] [float] NULL ,
	[RetQty] [float] NULL ,
	[losQTY] [float] NULL ,
	[OrtherINQty] [float] NULL ,     --盘点时盘盈(其它入库) 
	[OrtherOUTQty] [float] NULL ,	--盘点时盘亏(其它出库)
	[Actual_Qty] [float] NULL
    ) 
    
      
    

---上月期初库存导入#TempJXC  --期初库存表CL_ItemStockDetail_begin
set @sql_str='insert into #TempJXC
             (ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,beginQty,InQty,OutQty,RetQty,LOSQty,Actual_Qty )
             SELECT S.ITEM_INTERNAL_CODE, S.ITEM_CODE, S.ITEM_NAME, S.SPECIFICATIONS,S.PARENT_ITEM_CODE,S.ITEM_COLOR,S.MEASURE_UNIT,S.NET_PRICE,B.Actual_Qty,''0'',''0'',''0'',''0'',''0'' 
             FROM   dbo.CL_ITEM_STOCK_DETAIL AS S 
             INNER JOIN dbo.CL_ITEM_STOCK_DETAIL_BEGIN AS B 
             ON S.ITEM_CODE = B.ITEM_CODE
             WHERE  substring(CONVERT(varchar, B.CREATE_DATE, 23 ),1,7)='''+SUBSTRING(''+@Begindate+'',1,7)+''' '


 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and S.ITEM_CODE='''+@sITEM_CODE+''''      	   	
     END
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and S.ITEM_NAME='''+@sITEM_NAME+''''
    END         
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and S.PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END 
--PRINT @sql_str
exec (@sql_str)











---本月实际库存导入#TempJXC
set @sql_str='insert into #TempJXC
             (ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,beginQty,InQty,OutQty,RetQty,LOSQty,Actual_Qty )
             SELECT ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,''0'',''0'',''0'',''0'',''0'',Actual_Qty 
             FROM  CL_ITEM_STOCK_DETAIL'

 IF @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' where ITEM_CODE='''+@sITEM_CODE+''''      	   	
     END
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' where ITEM_NAME='''+@sITEM_NAME+''''
    END         
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' where PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END 
    PRINT @sql_str
exec (@sql_str)




---插入进仓
set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,InQty,inPayAmount )
              select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,SUM(Quantity) AS Quantity,sum(PayAmount) as JE from   VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''IN'''
 IF  @sITEM_CODE <>'' 
     BEGIN
     	set @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME <>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''''
    END            
             
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'             

exec (@sql_str)




--======插入出仓===========================================================
set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,outQty )
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,SUM(Quantity) AS Quantity from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''OUT'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END               
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'             

--PRINT @sql_str
exec (@sql_str)



--======插入退仓===========================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,outQty )
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,-SUM(Quantity) AS Quantity from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''TC'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END               
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'             

--PRINT @sql_str
exec (@sql_str)






---插入退货()RetQty--InQty================================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,InQty,inPayAmount) 
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,-SUM(Quantity) AS Quantity,-sum(PayAmount) as JE from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''RET'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END            
             
SET  @sql_str=@sql_str+'GROUP BY  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'             
--PRINT @sql_str
exec (@sql_str)




---报损数量==============================================================================================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,LOSQty )
             select ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE, SUM(Quantity) AS Quantity from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''LOS'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END            
             
SET  @sql_str=@sql_str+'GROUP BY  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'             
--PRINT @sql_str
exec (@sql_str)



---盘点会产生(盘盈的就是其它入库)Quantity-Actual_Qty >0
SET @sql_str='INSERT INTO  #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE, OrtherINQty)
  select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE, ABS(SUM(Quantity-Actual_Qty))  AS YKQuantity from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+'''
             and Quantity-Actual_Qty >''0'' 
             and BILL_STATUS=''1''
             and billtype=''PD'' ' 
 IF  @sITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
     END           
 IF @sPARENT_ITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
     END 
                 SET @sql_str=@sql_str+' group by  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'
  
 PRINT @sql_str                            
 EXEC (@sql_str) 


 ----==盘点会产生(盘亏的就是其它出库)Quantity-Actual_Qty <0  
SET @sql_str='INSERT INTO  #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE, OrtherOUTQty)
  select ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE, ABS(SUM(Quantity-Actual_Qty))  AS YKQuantity from VI_CL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+'''
             and Quantity-Actual_Qty <''0'' 
             and BILL_STATUS=''1''
             and billtype=''PD'' ' 
 IF  @sITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
     END           
 IF @sPARENT_ITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
     END 
                 SET @sql_str=@sql_str+'group by  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,ITEM_COLOR,MEASURE_UNIT,NET_PRICE'
 -- PRINT @sql_str                             
 EXEC (@sql_str) 



if @sType =0 
   begin
    select ITEM_CODE AS 材料编号,ITEM_NAME as 材料名称,SPECIFICATIONS as 规格型号,PARENT_ITEM_CODE as 材料类别,ITEM_COLOR AS 颜色 ,MEASURE_UNIT as 单位,NET_PRICE as 单价, 
     sum(isnull(beginQty,0))	          AS  上月数量,
     sum(isnull(beginQty,0))* NET_PRICE	  AS  上月金额,
     sum(ISNULL(InQty,0))                 AS  本月进仓数,
     sum(ISNULL(InPayAmount,0))           AS  本月进仓金额,
     sum(ISNULL(OutQty,0))                AS  本月出仓数,
     sum(ISNULL(OutQty,0))*NET_PRICE      AS  本月出仓金额,
     sum(ISNULL(LOSQty,0))                AS  本月报废数,
     sum(ISNULL(LOSQty,0))*NET_PRICE      AS  本月报废金额,
     sum(isnull(OrtherINQty,0))           AS  本月盘盈数, --盘点时产生盘盈       
     sum(isnull(OrtherOUTQty,0))          AS  本月盘亏数, --盘点时产生盘亏
     sum(ISNULL(Actual_Qty,0))            AS  本月结存数,    
     sum(ISNULL(Actual_Qty,0))*NET_PRICE  AS  本月结存金额
   from  #TempJXC
   group by ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE 
   end

if @sType =1 
   begin
    select ITEM_CODE AS 材料编号,ITEM_NAME as 材料名称,SPECIFICATIONS as 规格型号,PARENT_ITEM_CODE as 材料类别,ITEM_COLOR AS 颜色,MEASURE_UNIT as 单位, 
     sum(isnull(beginQty,0))	          AS  上月数,
     sum(ISNULL(InQty,0))                 AS  本月进仓数, 
     sum(ISNULL(OutQty,0))                AS  本月出仓数,    
     sum(ISNULL(LOSQty,0))                AS  本月报废数,   
     sum(isnull(OrtherINQty,0))           AS  本月盘盈数, --盘点时产生盘盈       
     sum(isnull(OrtherOUTQty,0))          AS  本月盘亏数, --盘点时产生盘亏
     sum(ISNULL(Actual_Qty,0))            AS  本月结存数
   from  #TempJXC
   group by ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_COLOR,MEASURE_UNIT
   end











   


END
go


create procedure dbo.SP_CL_JXC_BEGIN @CREATE_NAME VARCHAR(50)='',
 @BEGIN_DATE  VARCHAR(50)='' as
BEGIN
--=======据导入期初库存===============   
 ---系统每月最后一天自动月结 2014-09-22 李文基
 declare @DTDATE varchar(50), @LAST_DATE varchar(50)
 ----当天日期
 SET  @DTDATE=(SELECT  CONVERT(varchar(10), getdate(), 23)) 
 ----本月最后一天
 SET @LAST_DATE=(SELECT CONVERT(varchar(10), dateadd(month,1,getdate())-day(dateadd(month,1,getdate())), 23))  
 IF @BEGIN_DATE=@LAST_DATE 
  BEGIN   	
    ---期初库存---------------------------
   	 INSERT INTO CL_ITEM_STOCK_DETAIL_BEGIN(
   	 	    ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE, ACTUAL_QTY, CREATE_DATE)
     SELECT ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE, ACTUAL_QTY, CONVERT(CHAR(10),DATEADD(m,1,DATEADD(dd,-DAY(GETDATE())+1,GETDATE())),23)
     FROM CL_ITEM_STOCK_DETAIL   
      
     ---插入操作记录时间------------------
     Insert into CL_ITEM_STOCK_DETAIL_BEGIN_RECORD(CREATE_DATE,CREATE_NAME) 
     values(''+CONVERT(varchar(10), dateadd(month,1,getdate())-day(dateadd(month,1,getdate())), 23)+'',''+@CREATE_NAME+'')
 
 
 
   END
   
   
   
   
   
   
   
END
go


create procedure dbo.SP_CL_JXC_STOCK_DETAIL_BEGIN888 <@arg> <type> as
declare <@var> <type>
begin

end
go


create procedure dbo.SP_CL_PD_IMPORT @billno VARCHAR(50)='',
 @ITEM_TYEP VARCHAR(50)='' as
BEGIN

  if @ITEM_TYEP='' 
    begin
   --物料全部导入库存	(row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE 生成序行号) 
    INSERT INTO CL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,ITEM_TYPE,ITEM_COLOR,NET_PRICE,PRICE,ACTUAL_QTY)
    SELECT ''+@billno+'',row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,ITEM_TYPE,ITEM_COLOR,NET_PRICE,PRICE,ACTUAL_QTY
    FROM CL_ITEM_STOCK_DETAIL
   end 

  if  @ITEM_TYEP!='' 
   begin  
 
  --按类别导入库存	(row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE 生成序行号) 
  INSERT INTO CL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,ITEM_TYPE,ITEM_COLOR,NET_PRICE,PRICE,ACTUAL_QTY)
  SELECT ''+@billno+'',row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,ITEM_TYPE,ITEM_COLOR,NET_PRICE,PRICE,ACTUAL_QTY
  FROM CL_ITEM_STOCK_DETAIL
  WHERE  PARENT_ITEM_CODE=''+@ITEM_TYEP+''
    end



END
go


create procedure dbo.SP_CL_RECEIPT_REPORT @Begindate         char(10)='2008-01-01',
 @Enddate           char(10)='2088-01-01',
 @BILLNO            varchar(50)='',
 @CUSTOM_NAME       varchar(50)='',
 @sITEM_CODE        varchar(50)='',		--货号
 @sITEM_NAME        varchar(50)='',		--货号
 @SPECIFICATIONS    varchar(50)='',
 @sPARENT_ITEM_CODE varchar(50)='',      --类型
 @sPOSITION       varchar(50)='',        --仓位
 @sType             varchar(50)=''         
                        --IN-- 进仓报表                           
                        --RET--退货报表                                        
                        --OUT--出仓报表                                        
                        --DB---调拔报表 
                        --PD---盘点报表
                        --LOS--报废报表 as
BEGIN
	
DECLARE   @SQL_STR VARCHAR(8000)
--创建监时表
CREATE TABLE  #TEMP_REPORT(BILLNO           varchar(50),
                           ITEM_CODE        varchar(50),
                           ITEM_NAME        varchar(50),
                           SPECIFICATIONS   varchar(50),
                           PARENT_ITEM_CODE varchar(30),
                           MEASURE_UNIT     varchar(20),
                           PRICE            float ,
                           QUANTITY         float,
                           PAYAMOUNT        float,
                           CUSTOM_NAME      varchar(50),
                           POSITION         varchar(50)
)



--=================================进仓报表=========================================================
IF @sType='IN'
  BEGIN

  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(BILLNO,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,CUSTOM_NAME,POSITION )
               SELECT BILLNO, ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,Quantity,PayAmount,CUSTOM_NAME,POSITION from  VI_CL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND billtype=''IN'' '
    IF @CUSTOM_NAME <>''
       SET  @sql_str=@sql_str+'  AND  CUSTOM_NAME ='''+@CUSTOM_NAME+''' '
    IF @billno<>'' 
       SET  @sql_str=@sql_str+'  AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE  like '''+'%'+@sITEM_CODE+'%'+''' '
    IF @sITEM_NAME<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_NAME  like  '''+'%'+@sITEM_NAME+'%'+''' ' 
    IF @sPOSITION<>'' 
        SET  @sql_str=@sql_str+' AND POSITION='''+@sPOSITION+''' '  
    IF @SPECIFICATIONS<>'' 
        SET  @sql_str=@sql_str+' AND SPECIFICATIONS like '''+'%'+@SPECIFICATIONS+'%'+''' '                            
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+'     AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
   exec(@sql_str)
  print(@sql_str) 	
  END


--=================================退货报表=========================================================
IF @sType='RET'
  BEGIN

  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(BILLNO,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,CUSTOM_NAME,POSITION )
               SELECT BILLNO, ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,Quantity,PayAmount,CUSTOM_NAME,POSITION from  VI_CL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND billtype=''RET'' '
    IF @CUSTOM_NAME <>''
       SET  @sql_str=@sql_str+'  AND  CUSTOM_NAME ='''+@CUSTOM_NAME+''' '
    IF @billno<>'' 
       SET  @sql_str=@sql_str+'  AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE  like '''+'%'+@sITEM_CODE+'%'+''' '
    IF @sITEM_NAME<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_NAME  like  '''+'%'+@sITEM_NAME+'%'+''' ' 
    IF @sPOSITION<>'' 
        SET  @sql_str=@sql_str+' AND POSITION='''+@sPOSITION+''' '  
    IF @SPECIFICATIONS<>'' 
        SET  @sql_str=@sql_str+' AND SPECIFICATIONS like '''+'%'+@SPECIFICATIONS+'%'+''' '                            
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+'     AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
   exec(@sql_str)
  	
  END





--===================================出仓报表=========================================================
IF @sType='OUT'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(BILLNO,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,CUSTOM_NAME,POSITION )
               SELECT BILLNO, ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,Quantity,PayAmount,CUSTOM_NAME,POSITION from  VI_CL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND billtype=''OUT'' '
    IF @CUSTOM_NAME <>''
       SET  @sql_str=@sql_str+'  AND  CUSTOM_NAME ='''+@CUSTOM_NAME+''' '
    IF @billno<>'' 
       SET  @sql_str=@sql_str+'  AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE  like '''+'%'+@sITEM_CODE+'%'+''' '
    IF @sITEM_NAME<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_NAME  like  '''+'%'+@sITEM_NAME+'%'+''' ' 
    IF @sPOSITION<>'' 
        SET  @sql_str=@sql_str+' AND POSITION='''+@sPOSITION+''' '  
    IF @SPECIFICATIONS<>'' 
        SET  @sql_str=@sql_str+' AND SPECIFICATIONS like '''+'%'+@SPECIFICATIONS+'%'+''' '                            
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+'     AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
   exec(@sql_str)
  	
  END



--===================================盘点报表=========================================================
IF @sType='PD'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(BILLNO,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,CUSTOM_NAME,POSITION )
               SELECT BILLNO, ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,Quantity,PayAmount,CUSTOM_NAME,POSITION from  VI_CL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND billtype=''PD'' '
    IF @CUSTOM_NAME <>''
       SET  @sql_str=@sql_str+'  AND  CUSTOM_NAME ='''+@CUSTOM_NAME+''' '
    IF @billno<>'' 
       SET  @sql_str=@sql_str+'  AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE  like '''+'%'+@sITEM_CODE+'%'+''' '
    IF @sITEM_NAME<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_NAME  like  '''+'%'+@sITEM_NAME+'%'+''' ' 
    IF @sPOSITION<>'' 
        SET  @sql_str=@sql_str+' AND POSITION='''+@sPOSITION+''' '  
    IF @SPECIFICATIONS<>'' 
        SET  @sql_str=@sql_str+' AND SPECIFICATIONS like '''+'%'+@SPECIFICATIONS+'%'+''' '                            
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+'     AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '

    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
   exec(@sql_str)
  	
  END


--===================================盘点报表=========================================================
IF @sType='LOS'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(BILLNO,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,CUSTOM_NAME,POSITION )
               SELECT BILLNO, ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,Quantity,PayAmount,CUSTOM_NAME,POSITION from  VI_CL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND billtype=''LOS'' '
    IF @CUSTOM_NAME <>''
       SET  @sql_str=@sql_str+'  AND  CUSTOM_NAME ='''+@CUSTOM_NAME+''' '
    IF @billno<>'' 
       SET  @sql_str=@sql_str+'  AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE  like '''+'%'+@sITEM_CODE+'%'+''' '
    IF @sITEM_NAME<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_NAME  like  '''+'%'+@sITEM_NAME+'%'+''' ' 
    IF @sPOSITION<>'' 
        SET  @sql_str=@sql_str+' AND POSITION='''+@sPOSITION+''' '  
    IF @SPECIFICATIONS<>'' 
        SET  @sql_str=@sql_str+' AND SPECIFICATIONS like '''+'%'+@SPECIFICATIONS+'%'+''' '                            
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+'     AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TypeName,Unit,Price '
   exec(@sql_str)
  	
  END


IF @sType='IN'
   BEGIN
   SELECT  BILLNO               AS  单号 ,
        ITEM_CODE            AS  材料编号,
        ITEM_NAME            AS  材料名称,
        SPECIFICATIONS       AS  材料规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        CUSTOM_NAME          AS  供应商,
        POSITION             AS  仓位
     FROM    #TEMP_REPORT
   
   END
   
IF @sType='OUT'
   BEGIN
   SELECT  BILLNO               AS  单号 ,
        ITEM_CODE            AS  材料编号,
        ITEM_NAME            AS  材料名称,
        SPECIFICATIONS       AS  材料规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        CUSTOM_NAME          AS  领用部门,
        POSITION             AS  仓位
     FROM    #TEMP_REPORT
   
   END
   
IF @sType='PD'
   BEGIN
   SELECT  BILLNO               AS  单号 ,
        ITEM_CODE            AS  材料编号,
        ITEM_NAME            AS  材料名称,
        SPECIFICATIONS       AS  材料规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        CUSTOM_NAME          AS  仓库,
        POSITION             AS  仓位
     FROM    #TEMP_REPORT
   
   END
   
 --===============  
IF @sType='RET'   
   BEGIN
   SELECT  BILLNO            AS  单号 ,
        ITEM_CODE            AS  材料编号,
        ITEM_NAME            AS  材料名称,
        SPECIFICATIONS       AS  材料规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        CUSTOM_NAME          AS  仓库,
        POSITION             AS  仓位
     FROM    #TEMP_REPORT
   
   END
  
   --=======报废========  
IF @sType='LOS'   
   BEGIN
   SELECT  BILLNO            AS  单号 ,
        ITEM_CODE            AS  材料编号,
        ITEM_NAME            AS  材料名称,
        SPECIFICATIONS       AS  材料规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        CUSTOM_NAME          AS  仓库,
        POSITION             AS  仓位
     FROM    #TEMP_REPORT
   
   END
   













	


	
	

	







END
go


create procedure dbo.SP_CL_SCAN_BARCODE @Billno VARCHAR(50)='',
 @BARCODE VARCHAR(50)='' as
BEGIN
	



  DECLARE @sequence int,@ct int
  DECLARE @SQL_STR VARCHAR(8000)
--序号
  SET @sequence=(SELECT  COUNT(sequence)+1 AS ct   FROM  CL_RECEIPT_DETAIL WHERE BillNo=''+@Billno+'') 

--首先相判断单据中是否有相同产品，同记录累加，否则增加记录
 -- SET @ct=(SELECT BillNo,BARCODE,count(*) AS ct FROM  SAL_Receipt_Detail   where BillNo=''+@Billno+'' and BARCODE=''+@BARCODE+'' GROUP BY BillNo,BARCODE)
--
--扫条码
   
--@SQL_STR=' INSERT INTO CL_RECEIPT_DETAIL(billno,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,Quantity,PAYAMOUNT,BARCODE)
--      SELECT ''+@Billno+'',''+@sequence+'',ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,'1',Price,''+@BARCODE+'' FROM CL_ITEM_STOCK_DETAIL
--      WHERE BARCODE=''+@BARCODE+'' '
--    EXEC(@SQL_STR)
--    PRINT @SQL_STR


     SET   @SQL_STR=' INSERT INTO CL_RECEIPT_DETAIL(billno,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,Quantity,PAYAMOUNT,BARCODE)
      SELECT '''+@Billno+''','+@sequence+',ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,''1'',Price,''+@BARCODE+'' FROM CL_ITEM_STOCK_DETAIL
      WHERE BARCODE='''+@BARCODE+''' '
      PRINT @SQL_STR
      EXEC(@SQL_STR)
     
     	


 END
go


create procedure dbo.SP_LAST_DATE as
BEGIN


DECLARE @number int
SET     @number=3

--每月最后一天
SELECT DATEADD(Day,-1,CONVERT(char(8),DATEADD(Month,1,GETDATE()),120)+'1')

SELECT GETDATE() AS NOW_DATE 
---http://www.cnblogs.com/lanmiao/articles/2216563.html  全部都有日期 

---当月每一天
  -- select   dateadd(dd,-day(getdate())+1,getdate())  

----当月最后一天：
 --select   dateadd(dd,-day(getdate()),dateadd(m,1,getdate())) 


  Select CONVERT(varchar(10), getdate(), 23)
   
   Select CONVERT(varchar(10), dateadd(month,1,getdate())-day(dateadd(month,1,getdate())), 23)      
--下月的第一天
  SELECT CONVERT(CHAR(10),DATEADD(m,1,DATEADD(dd,-DAY(GETDATE())+1,GETDATE())),23)



END
go


create procedure dbo.SP_ORDER_CG_DETAIL as
BEGIN

 SELECT  *  FROM   dbo.ORDER_BOM

END
go


create procedure dbo.SP_ORD_BOM @BILLNO VARCHAR(50)='',
 @ITEM_INTERNAL_CODE VARCHAR(50)='',
 @MASTERID  VARCHAR(100)='',
 @DETAILID  VARCHAR(100)='' as
BEGIN
 INSERT INTO ORD_BOM(MASTERID,DETAILID,BILLNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_INTERNAL_CODE_CL,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,Quantity,ACTUAL_QTY)
 SELECT ''+@MASTERID+'', ''+@DETAILID+'', ''+@BILLNO+'',SEQUENCE,ITEM_INTERNAL_CODE,ITEM_INTERNAL_CODE_CL,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,Quantity,'0' FROM ORD_ITEM_DA_BOM
 WHERE ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE
 --下订单同时显示库存----- 

 
END
go


create procedure dbo.SP_ORD_BOM_TOTAL @BILLNO VARCHAR(50)='',
 @ITEM_INTERNAL_CODE VARCHAR(50)='',
 @quantity float as
BEGIN

 UPDATE ORD_BOM SET total_quantity=quantity*@quantity  WHERE BILLNO=''+@BILLNO+'' AND ITEM_INTERNAL_CODE=''+@ITEM_INTERNAL_CODE+''

END
go


create procedure dbo.SP_ORD_CLEAR as
BEGIN
   DELETE FROM dbo.ORD_MASTER  
   DELETE FROM  dbo.ORD_PCMASTER
   DELETE FROM  dbo.ORD_TCDETAIL
   DELETE FROM  dbo.ORD_WGDETAIL   
 
END
go


create procedure dbo.SP_ORD_TONGBU @ITEM_INTERNAL_CODE VARCHAR(50)='',
 @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME  VARCHAR(50)='' as
BEGIN
	--1、2015-06-15修改客户档案时单据记录同步 

  UPDATE  T1  SET 
  T1.ITEM_CODE=T2.ITEM_CODE, 
  T1.ITEM_NAME=T2.ITEM_NAME,
  T1.ITEM_CODE_old=T2.ITEM_CODE_old,
  T1.ITEM_NO=T2.ITEM_NO,
  T1.SPECIFICATIONS=T2.SPECIFICATIONS,
  T1.MEASURE_UNIT=T2.MEASURE_UNIT,
  T1.NET_PRICE=T2.NET_PRICE,
  T1.PRICE=T2.PRICE
   FROM 
  (SELECT  ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_NO,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE FROM ORD_DETAIL) T1, 
  (SELECT  ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_NO,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE     FROM     ORD_ITEM_DA) T2 
  WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE  
   
                  	
  -- 	--2、BOM记录同步(未改好)
  -- UPDATE T3    SET T3.ITEM_CODE=T4.ITEM_CODE,
  -- T3.ITEM_NAME=T4.ITEM_NAME,
  -- T3.PARENT_ITEM_CODE=T4.PARENT_ITEM_CODE,  
  -- T3.ITEM_TYPE=T4.ITEM_TYPE,    
  -- T3.ITEM_COLOR=T4.ITEM_COLOR, 
  -- T3.SPECIFICATIONS=T4.SPECIFICATIONS, 
  -- T3.MEASURE_UNIT=T4.MEASURE_UNIT,
  -- T3.NET_PRICE=T4.NET_PRICE     
  -- FROM 
  --(SELECT   ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE FROM ORDER_BOM) T3, 
  --(SELECT  ITEM_INTERNAL_CODE,ITEM_CODE,  ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE    FROM     PUB_ITEM_DA_BOM) T4 
  --WHERE  T3.ITEM_INTERNAL_CODE=T4.ITEM_INTERNAL_CODE             	
               	
END
go


create procedure dbo.SP_RECEIPT_DELETE @TEMP_TABLE VARCHAR(50)='',
 @TEMP_WHERE VARCHAR(50)=''
 --@ID int as
BEGIN
  DECLARE @SQL_STR VARCHAR
  
  SET @SQL_STR='DELETE FROM '''+@TEMP_TABLE+'''  WHERE BILLNO='''+@TEMP_WHERE+''''
  PRINT @SQL_STR
  EXEC (@SQL_STR)
  



END
go


create procedure dbo.SP_RECEIPT_INSERT as
BEGIN
	SELECT * FROM dbo.VI_CL_RECEIPT_DETAIL

END
go


create procedure dbo.SP_RECEIPT_SELECT as
BEGIN

SELECT * FROM  dbo.VI_CL_RECEIPT_DETAIL

END
go


create procedure dbo.SP_RECEIPT_UPDATE @TABLE  VARCHAR(50),
 @BILLNO VARCHAR(50) as
BEGIN	
--=====主表标记BILL_STATUS===
	
	
	
--=====明细表=====	
  DECLARE @ITEM_INTERNAL_CODE VARCHAR(200),
          @QUANTITY INT,
          @PayAmount FLOAT
 /*         
 --===定义游标        
  DECLARE CURSOR_MY   CURSOR   FOR    
         select  *  FROM #TEMPTABLE  WHERE BILLNO=@BILLNO      
         OPEN   CURSOR_MY
  FETCH NEXT FROM CURSOR_MY INTO  @ITEM_INTERNAL_CODE,@QUANTITY
   
 --===循环 
  WHILE   @@FETCH_STATUS = 0   
  BEGIN    	
    UPDATE  #TEMPTABLE set InQty=@Quantity where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE
    FETCH NEXT FROM cursor_IN INTO  @ITEM_INTERNAL_CODE,@Quantity       
  END   
  CLOSE        CURSOR_MY   
  DEALLOCATE   CURSOR_MY 
  
*/

   
   
   
END
go


create procedure dbo.SP_SAL_CHART as
BEGIN
	
   SELECT * FROM dbo.VI_SAL_RECEIPT_DETAIL


END
go


create procedure dbo.SP_SAL_DAY_TOTAL @STOCK_CODE VARCHAR(50)='',
 @begindate CHAR(10)='1990-01-01',
 @enddate CHAR(10)='1990-01-01' as
CREATE TABLE #tempsale(STOCK_CODE VARCHAR(50),STOCK_NAME varchar(50),cday VARCHAR(20),payamount FLOAT	)
declare @sqlstr VARCHAR(8000)
BEGIN

  SET @sqlstr='insert into #tempsale(STOCK_CODE ,STOCK_NAME,cday ,payamount)
      SELECT STOCK_CODE,STOCK_NAME,  RIGHT(''00''+ltrim(rtrim(day(BillDate))),2)  as cday,
      SUM((CASE WHEN BillType=''OUT'' THEN PayAmount ELSE - PayAmount END))
 AS PayAmount
      FROM dbo.VI_SAL_RECEIPT_DETAIL

      where 1=1 AND  BillType=''OUT'' AND  billdate>='''+@begindate+''' and billdate<='''+@enddate+''''
      IF @STOCK_CODE<>'' 
         BEGIN
         	SET @sqlstr=@sqlstr+' and STOCK_CODE='''+@STOCK_CODE+''''
         END
 	SET @sqlstr=@sqlstr+' GROUP BY  STOCK_CODE,STOCK_NAME,BillDate'

PRINT @sqlstr	
EXEC (@sqlstr)
	
	
	--SELECT  STOCK_NAME ,cday , payamount  FROM  #tempsale
	
/*==========各店铺销金额统计Departmentname(部门)，cday(日期),payamount(金额), */
declare @sql varchar(8000) 
IF @STOCK_CODE<>''
   BEGIN
   	set @sql= 'select STOCK_NAME as 门店' --列名 
    select @sql = @sql+ ',sum(case cday when '''+cday+'''  then  payamount else 0 end)  as  '''+cday+'''' --行转为列
   from (select distinct cday from  #tempsale ) AS  sub --日期
   set @sql=@sql + ' from #tempsale where STOCK_CODE = '''+@STOCK_CODE+''' group by STOCK_NAME'  --分组
   exec (@sql)   	
   END
ELSE 
	 BEGIN
   	set @sql= 'select STOCK_NAME as 门店' --列名 
    select @sql = @sql+ ',sum(case cday when '''+cday+'''  then  payamount else 0 end)  as  '''+cday+'''' --行转为列
   from (select distinct cday from  #tempsale ) AS  sub --日期
   set @sql=@sql + ' from #tempsale  group by STOCK_NAME'  --分组
   exec (@sql) 	 	
	 END


   

 
 
 
END
go


create procedure dbo.SP_SAL_DB_DETAIL @billno VARCHAR(50)='',
 @newbillno  VARCHAR(50)='' as
BEGIN

	
--增加入库单(主表及明细表)
INSERT INTO SAL_RECEIPT_MASTER( Company_Code , BillNo, Custom, BillType, PayAcount,
        StockCode, StockName, EmployeeCode, EmployeeName, BillDate, BillStatus, Remark)
SELECT Company_Code , ''+@newbillno+'', Custom, 'IN', PayAcount,
       Instockcode, Instockname, EmployeeCode, EmployeeName, BillDate, '0', '来源于调拔单:'+''+@billno+'' 
FROM SAL_RECEIPT_MASTER
WHERE billno=''+@billno+''
INSERT INTO SAL_RECEIPT_DETAIL( BillNo, Sequence, ItemInternalCode, ItemNo,
       ItemName, Specifications, typecode, TypeName, Unit, NetPrice, Price,
       Quantity, PayAmount, BarCode, Remark)
SELECT  ''+@newbillno+'', Sequence, ItemInternalCode, ItemNo,
       ItemName, Specifications, typecode, TypeName, Unit, NetPrice, NetPrice,
       Quantity, (NetPrice*Quantity) AS PayAmount, BarCode, Remark
 FROM SAL_RECEIPT_DETAIL 
WHERE billno=''+@billno+''



 
END
go


create procedure dbo.SP_SAL_IMPORT_PD @STOCK_CODE VARCHAR(50)='',
 @BILLNO  VARCHAR(50)='',
 @ITEM_TYEP VARCHAR(50)='' as
BEGIN
	IF (@ITEM_TYEP='')
	  BEGIN
	   --导入库存进行盘点 row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE生成行号	
       INSERT INTO dbo.SAL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,
          ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR, SPECIFICATIONS,
          MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,ITEM_TYPE)
       SELECT ''+@BILLNO+'',row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR,
          SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,'0','0',ITEM_TYPE
       -- FROM PUB_ITEM_LIST
       FROM dbo.VI_SAL_ITEM_STOCK_DETAIL
       WHERE STOCK_CODE=@STOCK_CODE
       PRINT '全部导入'	  	
	  END
    ELSE 
      BEGIN
      --导入库存按类别进行盘点	
       INSERT INTO dbo.SAL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,
                                   ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR, SPECIFICATIONS,
                                   MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,ITEM_TYPE)
       SELECT ''+@BILLNO+'',row_number() over (order by ITEM_INTERNAL_CODE) AS SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR,
          SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,'0','0',ITEM_TYPE
      -- FROM PUB_ITEM_LIST
      
       FROM dbo.VI_SAL_ITEM_STOCK_DETAIL
       WHERE STOCK_CODE=@STOCK_CODE AND PARENT_ITEM_CODE=@ITEM_TYEP
        PRINT '类别导入'
      END


      

      
      





END
go


create procedure dbo.SP_SAL_IMPORT_PD_bak @STOCK_CODE VARCHAR(50)='',
 @BILLNO  VARCHAR(50)='',
 @ITEM_TYEP VARCHAR(50)='' as
BEGIN
	IF (@ITEM_TYEP='')
	  BEGIN
	  	--导入库存进行盘点	
       INSERT INTO dbo.SAL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,
          ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR, SPECIFICATIONS,
          MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,ITEM_TYPE)
       SELECT ''+@BILLNO+'','1',ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR,
          SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,'0','0',ITEM_TYPE
       FROM dbo.VI_SAL_ITEM_STOCK_DETAIL
       WHERE STOCK_CODE=@STOCK_CODE
       PRINT '全部导入'	  	
	  END
    ELSE 
      BEGIN
      --导入库存按类别进行盘点	
       INSERT INTO dbo.SAL_RECEIPT_DETAIL(BillNo,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,
                                   ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR, SPECIFICATIONS,
                                   MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,ITEM_TYPE)
       SELECT ''+@BILLNO+'','1',ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_COLOR,
          SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,'0','0',ITEM_TYPE
       FROM dbo.VI_SAL_ITEM_STOCK_DETAIL
       WHERE STOCK_CODE=@STOCK_CODE AND PARENT_ITEM_CODE=@ITEM_TYEP
        PRINT '类别导入'
      END
   select * from   dbo.SAL_RECEIPT_DETAIL
   SELECT * FROM    dbo.PUB_ITEM_LIST
      
--
----更改序号----
----
--declare @i int
--set @i=1
--while @i<(SELECT COUNT(*) ct FROM  SAL_RECEIPT_DETAIL WHERE BillNo=@BILLNO )
--begin
----insert into test (userid) values(@i)
--  UPDATE SAL_RECEIPT_DETAIL SET SEQUENCE = @i WHERE BillNo=@BILLNO 
--set @i=@i+1
--end
      
      
      





END
go


create procedure dbo.SP_SAL_ITEM_TONGBU @ITEM_INTERNAL_CODE VARCHAR(50)='',
 @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME  VARCHAR(50)='' as
BEGIN
	--1、20141231增加产品档案与库存记录同步 
  INSERT INTO SAL_ITEM_STOCK_DETAIL(STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,
	       ACTUAL_QTY )		
	   SELECT ''+@STOCK_CODE+'',''+@STOCK_NAME+'', ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,'0' FROM  PUB_ITEM_LIST  WHERE ITEM_INTERNAL_CODE not   IN 
	       (SELECT ITEM_INTERNAL_CODE  FROM SAL_ITEM_STOCK_DETAIL) 

 

	--2、SAL_ITEM_STOCK_DETAIL与产品档案修改同步
 UPDATE T1  SET T1.ITEM_NAME=T2.ITEM_NAME FROM 
  (SELECT   ITEM_INTERNAL_CODE,  ITEM_NAME FROM SAL_ITEM_STOCK_DETAIL) T1, 
  (SELECT  ITEM_INTERNAL_CODE,  ITEM_NAME      FROM     PUB_ITEM_LIST) T2 
  WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE  
   
                  	
   	--3、 dbo.SAL_RECEIPT_DETAIL单据与产品档案同步 (2014-12-30李文基)
   UPDATE T3    SET T3.ITEM_CODE=T4.ITEM_CODE,
   T3.ITEM_NAME=T4.ITEM_NAME,
   T3.PARENT_ITEM_CODE=T4.PARENT_ITEM_CODE,  
   T3.ITEM_TYPE=T4.ITEM_TYPE,    
   T3.ITEM_COLOR=T4.ITEM_COLOR, 
   T3.SPECIFICATIONS=T4.SPECIFICATIONS, 
   T3.MEASURE_UNIT=T4.MEASURE_UNIT,
   T3.NET_PRICE=T4.NET_PRICE     
   FROM 
  (SELECT   ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE FROM SAL_RECEIPT_DETAIL) T3, 
  (SELECT  ITEM_INTERNAL_CODE,ITEM_CODE,  ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE    FROM     PUB_ITEM_LIST) T4 
  WHERE  T3.ITEM_INTERNAL_CODE=T4.ITEM_INTERNAL_CODE             	
               	
END
go


create procedure dbo.SP_SAL_JXC @Begindate char(12)='2001-01-01',
 @Enddate char(12)='2088-02-01',
 @STOCK_CODE  varchar(60)='',
 @ITEM_CODE varchar(100)='' ,
 @PARENT_ITEM_CODE VARCHAR(100)='',
 @filterfield VARCHAR(200)='',
 @groupbyfield VARCHAR(200)='',
 @sType int=0   
           --0是专卖店 
           --STOCK_CODE as
BEGIN   
	
	CREATE TABLE  #TempJXC( 
	[STOCK_CODE] [nvarchar](80),
	[STOCK_NAME] [nvarchar](80),
	[ITEM_INTERNAL_CODE] [nvarchar](200),
	[ITEM_CODE] [nvarchar](80),
	[ITEM_NAME] [nvarchar](80),
	[PARENT_ITEM_CODE] [nvarchar](80) ,
	[ITEM_TYPE] [nvarchar](80) ,
	[SPECIFICATIONS] [nvarchar](250),
	[ITEM_COLOR] [nvarchar](50),	 
	[MEASURE_UNIT] [char](6),
    [NET_PRICE] [float] NULL,
    [PRICE] [float] NULL,  
	[BeginQty] [float] NULL ,
	[InQty] [float] NULL ,
	[inPayAmount] [float] NULL ,
	[OutQty] [float] NULL ,
	[OutPayAmount] [float] NULL,
	[KHTHQty] [float] NULL ,
	[KHTHPayAmount] [float] NULL,
	[retQty] [float] NULL ,	
	[retPayAmount] [float] NULL,
	[DBOUTQty] [float] NULL , --调出数量	
	[DBOUTPayAmount] [float] NULL, --调出金额	
	[DBINQty] [float] NULL ,	--调入数量
	[DBINPayAmount] [float] NULL,--调入金额
	[OrtherINQty] [float] NULL ,     --盘点时盘盈 
	[OrtherOUTQty] [float] NULL ,	--盘点时盘亏
	[ACTUAL_QTY] [float] NULL,
	[LOSSQty] [float] NULL,
	[LOSSPayAmount] [float] NULL  )
	
		
	
	
--convert(varchar(10),@Begindate,120)	

DECLARE @sql_str varchar(8000) 
--====导入专卖店上月期初库存
SET @sql_str='INSERT INTO  #TempJXC( STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE, BeginQty)
SELECT     STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE, PRICE,ACTUAL_QTY
FROM    VI_SAL_ITEM_STOCK_DETAIL_BEGIN
 where substring(convert(varchar(10),CREATE_DATE,120),1,7)='''+SUBSTRING(convert(varchar(10),@Begindate,120),1,7)+''''
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''

--PRINT  @sql_str         
EXEC (@sql_str) 
	

--==导入专卖店实际库存
    SET @sql_str='INSERT INTO  #TempJXC( STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE, PRICE,ACTUAL_QTY)
SELECT S.STOCK_CODE, S.STOCK_NAME, I.ITEM_INTERNAL_CODE, I.ITEM_CODE, I.ITEM_NAME, I.SPECIFICATIONS,I.PARENT_ITEM_CODE,I.ITEM_TYPE,I.ITEM_COLOR, I.MEASURE_UNIT,I.NET_PRICE,I.PRICE,S.ACTUAL_QTY 
FROM SAL_ITEM_STOCK_DETAIL AS S  INNER JOIN dbo.PUB_ITEM_LIST AS I
     ON I.ITEM_INTERNAL_CODE=S.ITEM_INTERNAL_CODE
 where 1=1'
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and S.STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and I.PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and I.ITEM_CODE='''+@ITEM_CODE+''''
PRINT  @sql_str           
EXEC (@sql_str) 
      
    
--== convert(varchar(10),billdate,120) 日期字段转换字符串  
--===专卖店进仓单 where billtype=''IN'' and  convert(varchar(10),billdate,120)>='''+@Begindate+''' and convert(varchar(10),billdate,120)<='''+ @Enddate+''' '
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, InQty,inPayAmount)
SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE,sum(Quantity) as Quantity , sum(PayAmount) as PayAmount  
FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''IN'' and  convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' '
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 
                 SET @sql_str=@sql_str+' GROUP BY  STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE' 
                
 PRINT @SQL_STR             
 EXEC (@sql_str)   
                          
                   
----===专卖店销售单
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,PRICE, OutQty,outPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE,
       sum(Quantity) as Quantity, sum(PayAmount) as PayAmount 
 FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''OUT''  and  convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'                              
 PRINT @SQL_STR  
 EXEC (@sql_str)
 
 --====专卖退客户退货(billtype=''KHTH'')
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,PRICE, KHTHQty,KHTHPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE,
       sum(Quantity) as Quantity, sum(PayAmount) as PayAmount 
 FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''KHTH''  and   convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'                              
 PRINT @SQL_STR  
 EXEC (@sql_str)



  --====专卖退货单()
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE, ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE, InQty,inPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, -sum(Quantity) as Quantity, -sum(PayAmount) as PayAmount FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''RET''  and   convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE'
  PRINT @SQL_STR                           
 EXEC (@sql_str) 
 

--===专卖店调拔(调入--INSTOCK_CODE)
 SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, DBINQty,DBINPayAmount)
 SELECT INSTOCK_CODE,INSTOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(Quantity) as Quantity, sum(PayAmount) as PayAmount FROM VI_SAL_RECEIPT_DETAIL 
 where billtype=''DB''  and    convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and INSTOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   inSTOCK_CODE,inSTOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'
 PRINT @SQL_STR                             
 EXEC (@sql_str)           
 
 
   
--------专卖店调拔(调出--STOCK_CODE) 
----                
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, DBOUTQty,DBOUTPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(Quantity) as Quantity, sum(PayAmount) as PayAmount FROM   VI_SAL_RECEIPT_DETAIL 
where billtype=''DB''  and   convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE, ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE'
  PRINT @SQL_STR                             
 EXEC (@sql_str)
 


-----专卖店盘点单(盘盈就是其它入库)
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT, NET_PRICE, PRICE,OrtherINQty)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(YKQUANTITY) as Quantity  FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''PD''  and  YKQUANTITY>0 and   convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE, ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE'
 PRINT @sql_str                            
 EXEC (@sql_str) 
 

 
-- ----==专卖店盘点单(盘亏就是其它出库)
SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, OrtherOUTQty)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE, PRICE,abs(sum(YKQUANTITY)) as Quantity  FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''PD''  and  YKQUANTITY<0 and    convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'
 PRINT @sql_str                             
 EXEC (@sql_str) 



-- ----==专卖店报废-----
 --
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, LOSSQty,LOSSPayAmount)
SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE,sum(Quantity) as Quantity , sum(PayAmount) as PayAmount  FROM VI_SAL_RECEIPT_DETAIL 
where billtype=''BF'' and  convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' '
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 
                 SET @sql_str=@sql_str+' GROUP BY  STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE' 
                
 PRINT @SQL_STR             
 EXEC (@sql_str)           
                    
 
 ---专卖店进销存---2014-3-29 日改的
 SELECT  STOCK_CODE AS 门店编号, STOCK_NAME as 门店名称,  
    ITEM_CODE as 产品编号, ITEM_NAME as 产品名称,ISNULL(SPECIFICATIONS,'') as 规格型号,
    ITEM_TYPE as 类别名称 ,ITEM_COLOR AS 颜色, MEASURE_UNIT as 单位, 
     NET_PRICE  as 成本价,PRICE as 销售价, 
	 sum(isnull(BeginQty,0))                AS 本月期初数量,
	 sum(isnull(BeginQty,0))*NET_PRICE       AS 本月期初金额,
     sum(isnull(InQty,0))                   AS 本月入仓数量,
     sum(isnull(inPayAmount,0))             AS 本月入仓金额,
     sum(isnull(OutQty,0))                  AS 本月销售数量,        
     sum(isnull(outPayAmount,0))            AS 本月销售金额,     
     sum(isnull(KHTHQty,0))                  AS 客户退货数量,        
     sum(isnull(KHTHPayAmount,0))            AS 客户退货金额,   
     sum(isnull(DBOUTQty,0))                AS 本月调出数量,        
     sum(isnull(DBOUTPayAmount,0))          AS 本月调出金额,
     sum(isnull(DBINQty,0))                 AS 本月调入数量,        
     sum(isnull(DBINPayAmount,0))           AS 本月调入金额,
     sum(isnull(retQty,0))                  AS 本月退仓数量,        
     sum(isnull(retPayAmount,0))            AS 本月退仓金额, 
     sum(isnull(OrtherINQty,0))             AS 其它入库数量, --盘点时产生       
     sum(isnull(OrtherOUTQty,0))            AS 其它出库数量, --盘点时产生
     sum(isnull(LOSSQty,0))                 AS 本月报废数量,     
     sum(isnull(LOSSPayAmount,0))           AS 本月报废金额,  
     sum(isnull(ACTUAL_QTY,0))              AS 本月结存数量,
     sum(isnull(ACTUAL_QTY,0))*PRICE    AS 本月结存金额
     FROM #TempJXC  
     WHERE 1=1 and  
      BeginQty>0 OR InQty>0 OR inPayAmount>0   OR  OutQty>0   
      OR outPayAmount>0 OR DBOUTQty>0 OR DBOUTPayAmount>0 OR  DBINQty>0
      OR DBINPayAmount>0 OR retQty>0 OR retPayAmount>0   OR OrtherINQty>0
      OR OrtherOUTQty>0 OR  LOSSQty>0 OR LOSSPayAmount>0  OR ACTUAL_QTY>0
      OR KHTHQty>0       
     GROUP BY 
      STOCK_CODE,
      STOCK_NAME, 
      ITEM_CODE,
      ITEM_NAME,
      ISNULL(SPECIFICATIONS,''),
      ITEM_TYPE,
      ITEM_COLOR,
      MEASURE_UNIT,
      NET_PRICE,
      PRICE 	





END
go


create procedure dbo.SP_SAL_JXC_STOCK_DETAIL_BEGIN @begindate VARCHAR(10)='1991-01-01',
 @STOCK_CODE VARCHAR(50)='',
 @User_Name VARCHAR(50)='' as
BEGIN
--===判断是否存在导入期初库存
 DECLARE @SQL_STR VARCHAR(8000)
 SET @SQL_STR='INSERT INTO SAL_ITEM_STOCK_DETAIL_BEGIN
	(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, ACTUAL_QTY, CREATE_DATE)
SELECT STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, ACTUAL_QTY, '''+CONVERT(varchar, DATEADD(DD,1,@begindate), 23 )+''' 
FROM  SAL_ITEM_STOCK_DETAIL 
WHERE  STOCK_CODE='''+@STOCK_CODE+'''';
PRINT @SQL_STR
EXEC (@SQL_STR)

-----增加结帐记录-------------------------------------------------

 SET @SQL_STR='Insert into SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD(STOCK_CODE,CREATE_DATE,CREATE_NAME) 
values('''+@STOCK_CODE+''','''+@begindate+''','''+@User_Name+''')'
PRINT @SQL_STR
EXEC  (@SQL_STR)


  

  
    
  

END
go


create procedure dbo.SP_SAL_RECEIPT_REPORT @Begindate char(10)='2008-01-01',
 @Enddate char(10)='2088-01-01',
 @COMPANY_CODE VARCHAR(50)='',
 @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME VARCHAR(50)='',
 @BILLNO varchar(50)='',
 @CUSTOM_NAME varchar(50)='',
 @sITEM_CODE  varchar(50)='',			--货号
 @sPARENT_ITEM_CODE   varchar(50)='',      --类型
 @sTYPE VARCHAR(50)=''         
                        --IN-- 进仓报表                           
                        --RET--退货报表                                        
                        --OUT--出仓报表                                        
                        --DB---调出报表 
                        --PD---盘点报表
                        --LOS--报废报表 as
BEGIN

--=======创建监时表================================================================================

DECLARE   @SQL_STR VARCHAR(8000)
CREATE TABLE  #TEMP_REPORT(COMPANY_CODE       VARCHAR(50) ,
                           STOCK_CODE         VARCHAR(50),
                           STOCK_NAME         VARCHAR(50),
                           BILLNO             VARCHAR(200),
                           ITEM_INTERNAL_CODE VARCHAR(50),
                           ITEM_CODE          VARCHAR(50),
                           ITEM_NAME          VARCHAR(50),
                           ITEM_COLOR         VARCHAR(50),
                           PARENT_ITEM_CODE   VARCHAR(30),
                           SPECIFICATIONS     VARCHAR(50),                           
                           MEASURE_UNIT       VARCHAR(20),
                           BARCODE            VARCHAR(20),
                           NET_PRICE          FLOAT,
                           PRICE              FLOAT ,
                           QUANTITY           FLOAT,
                           PAYAMOUNT          FLOAT
                      
)

--COMPANY_CODE, CUSTOM_NAME,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,
--PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,QUANTITY,PAYAMOUNT


--=========专卖店进仓报表========================================================================
IF @sTYPE='IN'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE )
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO, ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,Quantity,PayAmount,BARCODE from  VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''IN'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
    PRINT @SQL_STR
    exec(@sql_str)
  	
  END



--=================================专卖店退货报表=========================================================
IF @sTYPE='RET'
  BEGIN

  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,BILLNO,ITEM_CODE,STOCK_NAME,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE )
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE  from  VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''RET'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
  PRINT @SQL_STR
   exec(@sql_str)
  	
  END







--=========专卖店出仓报表========================================================================
IF @sTYPE='OUT'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE )
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE from  VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''OUT'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
  PRINT @SQL_STR
   exec(@sql_str)
  	
  END
  

--=========专卖店调出报表========================================================================
IF @sTYPE='DB'
   BEGIN
   	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE)
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE FROM   VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''DB'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
  PRINT @SQL_STR
   exec(@sql_str)
   END
  
  



--========专卖店盘点报表===========================================================================
IF @sTYPE='PD'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE )
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE FROM   VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''PD'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
  PRINT @SQL_STR
   exec(@sql_str)
  	
  END



--===================================专卖店报废报表=========================================================
IF @sTYPE='LOS'
  BEGIN
  	SET @SQL_STR= 'INSERT INTO #TEMP_REPORT(COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE)
               SELECT COMPANY_CODE,STOCK_CODE,STOCK_NAME,BILLNO,ITEM_CODE,ITEM_NAME,ITEM_COLOR,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,PRICE,QUANTITY,PAYAMOUNT,BARCODE FROM   VI_SAL_RECEIPT_DETAIL 
               WHERE   BillDate >='''+ @Begindate  +''' AND BillDate <=''' +@Enddate+ '''   and BILL_STATUS=''1'' AND BILLTYPE=''LOS'' '
    IF @STOCK_CODE <>''
       SET  @sql_str=@sql_str+' AND  STOCK_CODE ='''+@STOCK_CODE+''' '
    IF @BILLNO<>'' 
       SET  @sql_str=@sql_str+' AND  BILLNO='''+@BILLNO+''' '
    IF @sITEM_CODE<>'' 
        SET  @sql_str=@sql_str+' AND ITEM_CODE='''+@sITEM_CODE+''' '
    IF  @sPARENT_ITEM_CODE<>'' 
    SET  @sql_str=@sql_str+' AND PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    --set  @sql_str=@sql_str+' group by  ItemNo,ItemName,Specifications,TYPEName,Unit,Price '
  PRINT @SQL_STR
   exec(@sql_str)
  	
  END






SELECT  BILLNO               AS  单号 ,
        ITEM_CODE            AS  产品编号,
        ITEM_NAME            AS  产品名称,
        ITEM_COLOR           AS  颜色,
        SPECIFICATIONS       AS  产品规格,
        PARENT_ITEM_CODE     AS  类别,
        MEASURE_UNIT         AS  单位,
        PRICE                AS  单价,
        QUANTITY             AS  数量,
        PAYAMOUNT            AS  金额,
        STOCK_CODE           AS  专卖店编号,
        STOCK_NAME           AS  专卖店名称, 
        BARCODE              AS  条码      
FROM    #TEMP_REPORT
ORDER BY ITEM_CODE, ITEM_NAME, SPECIFICATIONS

	


	
	

	







END
go


create procedure dbo.SP_SAL_ROW @STOCK_CODE VARCHAR(50)='',
 @ITEM_CODE VARCHAR(50)='' as
BEGIN
	
--建临时表	
  CREATE TABLE #tempsale(
  	STOCK_CODE VARCHAR(50),
    STOCK_NAME varchar(50),
    ITEM_CODE VARCHAR(50),
    SPECIFICATIONS VARCHAR(50),
    ITEM_TYPE VARCHAR(50),
    ACTUAL_QTY FLOAT	
  )
--SQL_STR 即是SQL字符串
  declare @SQL_STR VARCHAR(8000)
  SET @SQL_STR='INSERT INTO  #tempsale(STOCK_CODE ,STOCK_NAME,ITEM_CODE ,SPECIFICATIONS,ITEM_TYPE,ACTUAL_QTY)
               SELECT  S.STOCK_CODE, S.STOCK_NAME,  I.ITEM_CODE, I.SPECIFICATIONS,I.ITEM_TYPE, S.ACTUAL_QTY
               FROM  dbo.PUB_ITEM_LIST AS I INNER JOIN
                     dbo.SAL_ITEM_STOCK_DETAIL AS S 
                     ON I.ITEM_INTERNAL_CODE = S.ITEM_INTERNAL_CODE   
               WHERE  1=1 '
  IF @STOCK_CODE<>'' 
     BEGIN
    	SET @SQL_STR=@SQL_STR+' and S.STOCK_CODE='''+@STOCK_CODE+''''
     END
  IF @ITEM_CODE<>'' 
     BEGIN
     	SET @SQL_STR=@SQL_STR+' and I.ITEM_CODE LIKE  '''+'%'+@ITEM_CODE+'%'+''''
     END
     	
 	
PRINT @SQL_STR --打印出来	
EXEC (@SQL_STR)	--执行SQL 
--SELECT ITEM_CODE,SPECIFICATIONS,ACTUAL_QTY FROM  #tempsale   ORDER BY ITEM_CODE,SPECIFICATIONS
	
	
	
	SELECT 
	ITEM_TYPE      AS  产品类别,
    ITEM_CODE  AS  产品编号,
    SPECIFICATIONS AS  产品名称,  
    ACTUAL_QTY     AS  库存,
    STOCK_CODE AS  仓库编号,
    STOCK_NAME AS  仓库名称
    FROM  #tempsale   ORDER BY ITEM_CODE,SPECIFICATIONS



----/*==========店铺货号尺码行转为列显示(ITEM_CODE(货号)，SPECIFICATIONS(尺码),库存, */ 
--  IF @ITEM_CODE<>''
--   BEGIN
--   	DECLARE  @sql varchar(8000) 
--        select  @sql=isnull(@sql+',','')+' max(case SPECIFICATIONS when '''+SPECIFICATIONS+''' then ACTUAL_QTY else 0 end) ['+SPECIFICATIONS+']'
--        from(select distinct SPECIFICATIONS  from #tempsale) as a   
--    set @sql='select ITEM_CODE as 货号,'+@sql+' from #tempsale group by ITEM_CODE'   
--    exec(@sql)
--   END
--   ELSE
--   	BEGIN
--   	  SELECT ITEM_TYPE AS 类别,ITEM_CODE AS 货号,  SPECIFICATIONS as 尺码,  ACTUAL_QTY as  库存
--   	  FROM  #tempsale 
--   	  WHERE  ACTUAL_QTY>0
--   	  ORDER BY ITEM_CODE,SPECIFICATIONS	
--   	END



--实列 
--姓名       数学        物理        语文 
------------ ----------- ----------- -----------
--李四        84          94          74
--张三        83          93          74



END
go


create procedure dbo.SP_SAL_SCAN_BARCODE @Billno VARCHAR(50)='',
 @BARCODE VARCHAR(50)='' as
BEGIN
	



  DECLARE @sequence int,@ct int
--序号
  SET @sequence=(SELECT  COUNT(sequence)+1 AS ct   FROM  SAL_RECEIPT_DETAIL WHERE BillNo=''+@Billno+'') 

--首先相判断单据中是否有相同产品，同记录累加，否则增加记录
 -- SET @ct=(SELECT BillNo,BARCODE,count(*) AS ct FROM  SAL_Receipt_Detail   where BillNo=''+@Billno+'' and BARCODE=''+@BARCODE+'' GROUP BY BillNo,BARCODE)
--
--扫条码

      INSERT INTO SAL_RECEIPT_DETAIL(billno,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,Quantity,PAYAMOUNT,BARCODE)
      SELECT ''+@Billno+'',''+@sequence+'',ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,Specifications,PARENT_ITEM_CODE,ITEM_TYPE,MEASURE_UNIT,NET_PRICE,Price,'1',Price,''+@BARCODE+'' FROM dbo.PUB_ITEM_LIST
      WHERE BARCODE=''+@BARCODE+'' 	


 END
go


create procedure dbo.SP_STEEL_DA_BEGIN @CREATE_NAME VARCHAR(50)='',
 @BEGIN_DATE VARCHAR(50)='' as
BEGIN 
---系统每月最后一天自动月结2014-09-22李文基
 declare @DTDATE     varchar(50),
         @LAST_DATE  varchar(50)
 --当天日期
 SET  @DTDATE=(SELECT  CONVERT(varchar(10), getdate(), 23)) 
 --本月最后一天
 SET @LAST_DATE=(SELECT CONVERT(varchar(10), dateadd(month,1,getdate())-day(dateadd(month,1,getdate())), 23)) 
  IF @BEGIN_DATE=@LAST_DATE
 --IF @DTDATE=@LAST_DATE
   BEGIN   	
    ---导入期初库存
   	 INSERT INTO STEEL_DA_BEGIN(
   	 	    ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE, ACTUAL_QTY, CREATE_DATE)
     SELECT ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE, ACTUAL_QTY, CONVERT(CHAR(10),DATEADD(m,1,DATEADD(dd,-DAY(GETDATE())+1,GETDATE())),23)
     FROM STEEL_DA   
      
    ---标记导入时间------------------
     Insert into STEEL_DA_BEGIN_RECORD(CREATE_DATE,CREATE_NAME)
      VALUES(''+CONVERT(varchar(10), dateadd(month,1,getdate())-day(dateadd(month,1,getdate())), 23)+'',''+@CREATE_NAME+'')
     
   END   
   
   
   
   
   
END
go


create procedure dbo.SP_STEEL_JXC @Begindate char(10)='2008-01-01',
 @Enddate   char(10)='2088-01-01',
 @sITEM_CODE   varchar(200)='',			--材料编号                          		
 @sITEM_NAME    varchar(200)='',         --材料名称                                                         
 @sPARENT_ITEM_CODE varchar(200)='',             --类别
 @sType  int=0                                  
                            --1--(到材料编号)                                        
                            --2--到材料名称)                                        
                            --3--(类别) as
BEGIN
declare @sql_str varchar(8000)



CREATE TABLE #TempJXC
    (
    [ITEM_INTERNAL_CODE]  VARCHAR(50),
	[ITEM_CODE] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[ITEM_NAME] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[SPECIFICATIONS] [varchar](200) COLLATE Chinese_PRC_CI_AS NULL,		
	[PARENT_ITEM_CODE] [nvarchar](200) COLLATE Chinese_PRC_CI_AS NULL,
	[MEASURE_UNIT] [nvarchar](6),
    [NET_PRICE] [float] NULL,
    [PRICE] [float] NULL,
	[beginQty] [float] NULL,	
    [InQty] [float] NULL ,
    [InPayAmount] [float] NULL ,
	[OutQty] [float] NULL ,
	[RetQty] [float] NULL ,
	[losQTY] [float] NULL ,
	[OrtherINQty] [float] NULL ,     --盘点时盘盈(其它入库) 
	[OrtherOUTQty] [float] NULL ,	--盘点时盘亏(其它出库)
	[Actual_Qty] [float] NULL
    ) 
    
      
    

---上月期初库存导入#TempJXC  --期初库存表CL_ItemStockDetail_begin
set @sql_str='insert into #TempJXC
             (ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,beginQty,InQty,OutQty,RetQty,LOSQty,Actual_Qty )
             SELECT S.ITEM_INTERNAL_CODE, S.ITEM_CODE, S.ITEM_NAME, S.SPECIFICATIONS,S.PARENT_ITEM_CODE,S.MEASURE_UNIT,S.NET_PRICE,B.Actual_Qty,''0'',''0'',''0'',''0'',''0'' 
             FROM   dbo.STEEL_DA AS S 
             INNER JOIN dbo.STEEL_DA_BEGIN AS B 
             ON S.ITEM_CODE = B.ITEM_CODE
             WHERE  substring(CONVERT(varchar, B.CREATE_DATE, 23 ),1,7)='''+SUBSTRING(''+@Begindate+'',1,7)+''' '
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and S.ITEM_CODE='''+@sITEM_CODE+''''      	   	
     END
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and S.ITEM_NAME='''+@sITEM_NAME+''''
    END         
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and S.PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END 
    
PRINT @sql_str
exec (@sql_str)











---本月实际库存导入#TempJXC
set @sql_str='insert into #TempJXC
             (ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,beginQty,InQty,OutQty,RetQty,LOSQty,Actual_Qty )
             SELECT ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,''0'',''0'',''0'',''0'',''0'',Actual_Qty 
             FROM  STEEL_DA'

 IF @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' where ITEM_CODE='''+@sITEM_CODE+''''      	   	
     END
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' where ITEM_NAME='''+@sITEM_NAME+''''
    END         
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' where PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END 
 --   PRINT @sql_str
exec (@sql_str)




---插入进仓
set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,InQty,inPayAmount )
              select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE,SUM(Quantity) AS Quantity,sum(PayAmount) as JE from   Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''IN'''
 IF  @sITEM_CODE <>'' 
     BEGIN
     	set @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME <>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''''
    END            
             
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'             

exec (@sql_str)
--print @sql_str




--======插入出仓===========================================================
set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,outQty )
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,SUM(Quantity) AS Quantity from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''OUT'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END               
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'             

--PRINT @sql_str
exec (@sql_str)



--======插入退仓===========================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,outQty )
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,-SUM(Quantity) AS Quantity from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''TC'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END               
SET  @sql_str=@sql_str+'GROUP BY ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'             

--PRINT @sql_str
exec (@sql_str)






---插入退货()RetQty--InQty================================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,InQty,inPayAmount) 
             select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,-SUM(Quantity) AS Quantity,-sum(PayAmount) as JE from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''RET'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END            
             
SET  @sql_str=@sql_str+'GROUP BY  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'             
--PRINT @sql_str
exec (@sql_str)




---报损数量==============================================================================================================================

set @sql_str='insert into #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,LOSQty )
             select ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE, SUM(Quantity) AS Quantity from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+''' and BILL_STATUS=''1'' AND billtype=''LOS'''
 IF  @sITEM_CODE<>'' 
     BEGIN
     	SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
    BEGIN
    	SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
    END           
 IF @sPARENT_ITEM_CODE<>'' 
    BEGIN
    	SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
    END            
             
SET  @sql_str=@sql_str+'GROUP BY  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'             
--PRINT @sql_str
exec (@sql_str)



---盘点会产生(盘盈的就是其它入库)Quantity-Actual_Qty >0
SET @sql_str='INSERT INTO  #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE, OrtherINQty)
  select ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE, ABS(SUM(Quantity-Actual_Qty))  AS YKQuantity from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+'''
             and Quantity-Actual_Qty >''0'' 
             and BILL_STATUS=''1''
             and billtype=''PD'' ' 
 IF  @sITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
     END           
 IF @sPARENT_ITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
     END 
                 SET @sql_str=@sql_str+' group by  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'
  
-- PRINT @sql_str                            
 EXEC (@sql_str) 


 ----==盘点会产生(盘亏的就是其它出库)Quantity-Actual_Qty <0  
SET @sql_str='INSERT INTO  #TempJXC(ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE, OrtherOUTQty)
  select ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, PARENT_ITEM_CODE,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE, ABS(SUM(Quantity-Actual_Qty))  AS YKQuantity from Vi_STEEL_RECEIPT_DETAIL
             where billdate>='''+ltrim(rtrim(@Begindate))+''' and billdate<='''+ltrim(rtrim(@Enddate))+'''
             and Quantity-Actual_Qty <''0'' 
             and BILL_STATUS=''1''
             and billtype=''PD'' ' 
 IF  @sITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_CODE='''+@sITEM_CODE+''''
     END 
 IF @sITEM_NAME<>''
     BEGIN
     SET @sql_str=@sql_str+' and ITEM_NAME='''+@sITEM_NAME+''''
     END           
 IF @sPARENT_ITEM_CODE<>'' 
     BEGIN
     SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@sPARENT_ITEM_CODE+''' '
     END 
                 SET @sql_str=@sql_str+' group by  ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE, SPECIFICATIONS,MEASURE_UNIT,NET_PRICE'
 -- PRINT @sql_str                             
 EXEC (@sql_str) 




if @sType=0
   begin
     select ITEM_CODE AS 铁料编号,ITEM_NAME as 铁料名称,SPECIFICATIONS as 规格型号,PARENT_ITEM_CODE as 供应商,MEASURE_UNIT as 单位,NET_PRICE as 单价, 
     sum(isnull(beginQty,0))	          AS  上月结存,
     sum(isnull(beginQty,0))* NET_PRICE	  AS  上月金额,
     sum(ISNULL(InQty,0))                 AS  本月进,
     sum(ISNULL(InPayAmount,0))           AS  本月进金额,
     sum(ISNULL(OutQty,0))                AS  本月出,
     sum(ISNULL(OutQty,0))*NET_PRICE      AS  本月出金额,
     sum(ISNULL(LOSQty,0))                AS  本月报废,
     sum(ISNULL(LOSQty,0))*NET_PRICE      AS  本月报废金额,
     sum(isnull(OrtherINQty,0))           AS  本月其它入库, --盘点时产生盘盈       
     sum(isnull(OrtherOUTQty,0))          AS  本月其它出库, --盘点时产生盘亏
     sum(ISNULL(Actual_Qty,0))            AS  本月结存,    
     sum(ISNULL(Actual_Qty,0))*NET_PRICE  AS  结存金额
     from  #TempJXC
     group by ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE 
   end
   
 --不显示单价 
if @sType=1
   begin
     select ITEM_CODE AS 铁料编号,ITEM_NAME as 铁料名称,SPECIFICATIONS as 规格型号,PARENT_ITEM_CODE as 供应商,MEASURE_UNIT as 单位,NET_PRICE as 单价, 
     sum(isnull(beginQty,0))	          AS  上月结存,    
     sum(ISNULL(InQty,0))                 AS  本月进,   
     sum(ISNULL(OutQty,0))                AS  本月出, 
     sum(ISNULL(LOSQty,0))                AS  本月报废,   
     sum(isnull(OrtherINQty,0))           AS  本月其它入库, --盘点时产生盘盈       
     sum(isnull(OrtherOUTQty,0))          AS  本月其它出库, --盘点时产生盘亏
     sum(ISNULL(Actual_Qty,0))            AS  本月结存
     from  #TempJXC
     group by ITEM_CODE,ITEM_NAME,SPECIFICATIONS,PARENT_ITEM_CODE,MEASURE_UNIT,NET_PRICE 
   end













   


END
go


create procedure dbo.SP_STEEL_TONGBU @ITEM_INTERNAL_CODE VARCHAR(50)='' as
BEGIN
------供应商同步-------
  -- UPDATE T1    SET T1.SUPPLY_CODE=T2.SUPPLY_CODE,
  -- T1.SUPPLY_NAME=T2.SUPPLY_NAME   
  -- FROM 
  --(SELECT  SUPPLY_CODE,SUPPLY_NAME FROM dbo.STEEL_DA) T1, 
  --(SELECT  SUPPLY_CODE,SUPPLY_NAME FROM     dbo.PUB_SUPPLY)  T2 
  --WHERE  T1.SUPPLY_CODE=T2.SUPPLY_CODE  


            	
------dbo.SAL_RECEIPT_DETAIL单据与产品档案同步 
   UPDATE T3    SET T3.ITEM_CODE=T4.ITEM_CODE,
   T3.ITEM_NAME=T4.ITEM_NAME,
   T3.PARENT_ITEM_CODE=T4.PARENT_ITEM_CODE,  
   T3.ITEM_TYPE=T4.ITEM_TYPE,    
   T3.ITEM_COLOR=T4.ITEM_COLOR, 
   T3.SPECIFICATIONS=T4.SPECIFICATIONS, 
   T3.MEASURE_UNIT=T4.MEASURE_UNIT
   
   FROM 
  (SELECT   ITEM_INTERNAL_CODE,ITEM_CODE, ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT FROM STEEL_RECEIPT_DETAIL) T3, 
  (SELECT  ITEM_INTERNAL_CODE,ITEM_CODE,  ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT FROM     STEEL_DA)  T4 
  WHERE  T3.ITEM_INTERNAL_CODE=T4.ITEM_INTERNAL_CODE             	
               	
END
go


create procedure dbo.SP_SYS_DATA_CLEAR as
BEGIN
	--材料管理 
	DELETE FROM dbo.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD
	DELETE FROM CL_ITEM_STOCK_DETAIL_BEGIN
	DELETE FROM  CL_RECEIPT_MASTER
---DELETE FROM  CL_RECEIPT_DETAIL BILLNO 已进行联级





 ---专卖店管理 单据清空

 DELETE  FROM  SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD
 DELETE FROM   SAL_ITEM_STOCK_DETAIL_BEGIN
 DELETE  FROM  SAL_RECEIPT_MASTER 
--DELETE  FROM  SAL_RECEIPT_DETAIL   BILLNO 已进行联级
 

 
 
 
 
END
go


create procedure dbo.SP_WL_DA_SYNCHRONOUS @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME VARCHAR(50)='' as
BEGIN
	DECLARE @SQL_STR VARCHAR(8000)
	
	---===材料档案导入到物料档案中2012-11-22 
	 INSERT INTO WL_DA(ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,[DESCRIPTION],ITEM_COLOR,PARENT_ITEM_CODE,[TYPE_NAME],ITEM_JZ,ITEM_HZ,ITEM_GYLC,MEASURE_UNIT,NET_PRICE,MIN_QTY,MAX_QTY,POSITION,Actual_Qty,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE)
	 SELECT  ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,SPECIFICATIONS, [DESCRIPTION],ITEM_COLOR,PARENT_ITEM_CODE,[TYPE_NAME],ITEM_JZ,ITEM_HZ,ITEM_GYLC,MEASURE_UNIT,NET_PRICE,MIN_QTY,MAX_QTY,POSITION,Actual_Qty,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE FROM  CL_ITEM_STOCK_DETAIL
	 WHERE ITEM_INTERNAL_CODE NOT IN 
	 (SELECT  ITEM_INTERNAL_CODE from WL_DA) 


	

	
	----单据记录同步2012-11-22 
	-- INSERT INTO WL_STOCK_DETAIL(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, Actual_Qty)
	-- SELECT ''+@STOCK_CODE+'',''+@STOCK_NAME+'', ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, '0' FROM WL_DA
	-- WHERE ITEM_INTERNAL_CODE NOT IN 
	-- (SELECT  ITEM_INTERNAL_CODE from WL_STOCK_DETAIL 
	-- WHERE STOCK_CODE=@STOCK_CODE )
	
	
	----同步更新--------------------------------------------
	UPDATE T1  SET T1.ITEM_CODE=T2.ITEM_CODE, 
	 T1.ITEM_NAME=T2.ITEM_NAME,
	 T1.SPECIFICATIONS=T2.SPECIFICATIONS, 
	 T1.[DESCRIPTION]=T2.[DESCRIPTION], 
	 T1.ITEM_COLOR=T2.ITEM_COLOR, 
	 T1.PARENT_ITEM_CODE=T2.PARENT_ITEM_CODE, 
	 T1.[TYPE_NAME]=T2.[TYPE_NAME] ,
	 T1.ITEM_JZ=T2.ITEM_JZ ,
	 T1.ITEM_HZ=T2.ITEM_HZ ,
	 T1.ITEM_GYLC=T2.ITEM_GYLC, 
	 T1.NET_PRICE=T2.NET_PRICE ,
	 T1.MIN_QTY=T2.MIN_QTY ,
	 T1.MAX_QTY=T2.MAX_QTY,
	 T1.POSITION_CODE=T2.POSITION_CODE,
	 T1.POSITION=T2.POSITION,
	 T1.CREATE_NAME=T2.CREATE_NAME,
	 T1.CREATE_DATE=T2.CREATE_DATE,
	 T1.UPDATE_NAME=T2.UPDATE_NAME,
	 T1.UPDATE_DATE=T2.UPDATE_DATE
    from 
    (SELECT   ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,SPECIFICATIONS, [DESCRIPTION],ITEM_COLOR,PARENT_ITEM_CODE,[TYPE_NAME],ITEM_JZ,ITEM_HZ,ITEM_GYLC,MEASURE_UNIT,NET_PRICE,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,Actual_Qty,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE
     FROM     WL_DA) T1,
    (SELECT ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME,SPECIFICATIONS, [DESCRIPTION],ITEM_COLOR,PARENT_ITEM_CODE,[TYPE_NAME],ITEM_JZ,ITEM_HZ,ITEM_GYLC,MEASURE_UNIT,NET_PRICE,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,Actual_Qty,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE
     FROM  CL_ITEM_STOCK_DETAIL   ) T2
	 WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE   
	 



	  


END
go


create procedure dbo.SP_WL_DA_SYNCHRONOUS_WL_STOCK_DETAIL @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME VARCHAR(50)='' as
BEGIN
	DECLARE @SQL_STR VARCHAR(8000)
	
	--===库存表与档案记录同步2012-11-22 
	 INSERT INTO WL_STOCK_DETAIL(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, Actual_Qty)
	 SELECT ''+@STOCK_CODE+'',''+@STOCK_NAME+'', ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, '0' FROM WL_DA
	 WHERE ITEM_INTERNAL_CODE NOT IN 
	 (SELECT  ITEM_INTERNAL_CODE from WL_STOCK_DETAIL 
	 WHERE STOCK_CODE=@STOCK_CODE )
	
	
	--=====更新货名===============
	UPDATE T1  set   T1.ITEM_NAME=T2.ITEM_NAME 
    from 
    (SELECT   ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     WL_STOCK_DETAIL) T1,
    (SELECT  ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     WL_DA) T2
	 WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE   
	 



	  


END
go


create procedure dbo.SP_WL_DA_TONGBU @STOCK_CODE VARCHAR(50)='',
 @STOCK_NAME VARCHAR(50)='' as
BEGIN
	DECLARE @SQL_STR VARCHAR(8000)	
	--===更新库存表2012-11-22 
	 INSERT INTO SAL_ITEM_STOCK_DETAIL(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, Actual_Qty)
	 SELECT ''+@STOCK_CODE+'',''+@STOCK_NAME+'', ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, '0' FROM STE_PROCESS_DA
	 WHERE ITEM_INTERNAL_CODE NOT IN 
	 (SELECT  ITEM_INTERNAL_CODE from STE_PROCESS_STOCK_DETAIL 
	 WHERE STOCK_CODE=@STOCK_CODE )
	
	
----=====更新货名===============
	UPDATE T1  set   T1.ITEM_NAME=T2.ITEM_NAME 
    from 
    (SELECT   ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     STE_PROCESS_STOCK_DETAIL) T1,
    (SELECT  ITEM_INTERNAL_CODE,  ITEM_NAME
     FROM     STE_PROCESS_DA) T2
	 WHERE  T1.ITEM_INTERNAL_CODE=T2.ITEM_INTERNAL_CODE   


	 



	  


END
go


create procedure dbo.SP_WL_JXC @Begindate char(12)='2001-01-01',
 @Enddate char(12)='2088-02-01',
 @STOCK_CODE  varchar(60)='',
 @ITEM_CODE varchar(100)='' ,
 @sITEM_NAME varchar(100)='' ,
 @SPECIFICATIONS varchar(100)='' ,
 @PARENT_ITEM_CODE VARCHAR(100)='',
 @filterfield VARCHAR(200)='',
 @groupbyfield VARCHAR(200)='',
 @sType int=0   
           --0是专卖店 
           --STOCK_CODE as
BEGIN   
	
	CREATE TABLE  #TempJXC( 
	[STOCK_CODE] [nvarchar](80),
	[STOCK_NAME] [nvarchar](80),
	[ITEM_INTERNAL_CODE] [nvarchar](200),
	[ITEM_CODE] [nvarchar](80),
	[ITEM_NAME] [nvarchar](80),
	[PARENT_ITEM_CODE] [nvarchar](80) ,
	[ITEM_TYPE] [nvarchar](80) ,
	[SPECIFICATIONS] [nvarchar](250),
	[ITEM_COLOR] [nvarchar](50),	 
	[MEASURE_UNIT] [char](6),
    [NET_PRICE] [float] NULL,
    [PRICE] [float] NULL,  
	[BeginQty] [float] NULL ,
	[InQty] [float] NULL ,
	[inPayAmount] [float] NULL ,
	[OutQty] [float] NULL ,
	[OutPayAmount] [float] NULL,
	[KHTHQty] [float] NULL ,
	[KHTHPayAmount] [float] NULL,
	[retQty] [float] NULL ,	
	[retPayAmount] [float] NULL,
	[DBOUTQty] [float] NULL , --调出数量	
	[DBOUTPayAmount] [float] NULL, --调出金额	
	[DBINQty] [float] NULL ,	--调入数量
	[DBINPayAmount] [float] NULL,--调入金额
	[OrtherINQty] [float] NULL ,     --盘点时盘盈 
	[OrtherOUTQty] [float] NULL ,	--盘点时盘亏
	[ACTUAL_QTY] [float] NULL,
	[LOSSQty] [float] NULL,
	[LOSSPayAmount] [float] NULL  )
	
		
	
	
--convert(varchar(10),@Begindate,120)	

DECLARE @sql_str varchar(8000) 
--====导入仓库上月期初库存
SET @sql_str='INSERT INTO  #TempJXC( STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE, BeginQty)
SELECT     STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE, PRICE,ACTUAL_QTY
FROM    Vi_WL_STOCK_DETAIL_BEGIN
 where substring(convert(varchar(10),CREATE_DATE,120),1,7)='''+SUBSTRING(convert(varchar(10),@Begindate,120),1,7)+''''
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                         
                       

PRINT  @sql_str         
EXEC (@sql_str) 

	

--==导入专卖店实际库存
    SET @sql_str='INSERT INTO  #TempJXC( STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE, PRICE,ACTUAL_QTY)
SELECT S.STOCK_CODE, S.STOCK_NAME, I.ITEM_INTERNAL_CODE, I.ITEM_CODE, I.ITEM_NAME, I.SPECIFICATIONS,I.PARENT_ITEM_CODE,I.ITEM_TYPE,I.ITEM_COLOR, I.MEASURE_UNIT,I.NET_PRICE,I.PRICE,S.ACTUAL_QTY 
FROM WL_STOCK_DETAIL AS S  INNER JOIN dbo.WL_DA AS I
     ON I.ITEM_INTERNAL_CODE=S.ITEM_INTERNAL_CODE
 where 1=1'
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and S.STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and I.PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and I.ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''  
--PRINT  @sql_str           
EXEC (@sql_str) 
      
    
--== convert(varchar(10),billdate,120) 日期字段转换字符串  
--===专卖店进仓单 where billtype=''IN'' and  convert(varchar(10),billdate,120)>='''+@Begindate+''' and convert(varchar(10),billdate,120)<='''+ @Enddate+''' '
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, InQty,inPayAmount)
SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE,sum(Quantity) as Quantity , sum(PayAmount) as PayAmount  
FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''IN'' and  convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' '
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                 
                 SET @sql_str=@sql_str+' GROUP BY  STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE' 
                
 --PRINT @SQL_STR             
 EXEC (@sql_str)   
                          
                   
----===专卖店销售单
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,PRICE, OutQty,outPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE,
       sum(Quantity) as Quantity, sum(PayAmount) as PayAmount 
 FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''OUT''  and  convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                 
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'                              
-- PRINT @SQL_STR  
 EXEC (@sql_str)
 
 --====物料退仓单2015-05-18
    SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT,NET_PRICE,PRICE, retQty,retPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT,NET_PRICE,PRICE,
       sum(Quantity) as Quantity, sum(PayAmount) as PayAmount 
 FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''TC''  and   convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+'''' 
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'                              
--PRINT @SQL_STR  
 EXEC (@sql_str)
 

--===专卖店调拔(调入--INSTOCK_CODE)
 SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, DBINQty,DBINPayAmount)
 SELECT INSTOCK_CODE,INSTOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(Quantity) as Quantity, sum(PayAmount) as PayAmount FROM Vi_WL_RECEIPT_DETAIL 
 where billtype=''DB''  and    convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and INSTOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                 
                 SET @sql_str=@sql_str+' GROUP BY   inSTOCK_CODE,inSTOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'
 --PRINT @SQL_STR                             
 EXEC (@sql_str)           
 
 
   
--------专卖店调拔(调出--STOCK_CODE) 
----                
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, DBOUTQty,DBOUTPayAmount)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(Quantity) as Quantity, sum(PayAmount) as PayAmount FROM   Vi_WL_RECEIPT_DETAIL 
where billtype=''DB''  and   convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE, ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE'
  --PRINT @SQL_STR                             
 EXEC (@sql_str)
 


-----专卖店盘点单(盘盈就是其它入库)
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE, ITEM_TYPE,ITEM_COLOR,MEASURE_UNIT, NET_PRICE, PRICE,OrtherINQty)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, sum(YKQUANTITY) as Quantity  FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''PD''  and  YKQUANTITY>0 and   convert(varchar(10),billdate,120) between  '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                  
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE, ITEM_COLOR,MEASURE_UNIT, NET_PRICE,PRICE'
-- PRINT @sql_str                            
 EXEC (@sql_str) 
 

 
-- ----==专卖店盘点单(盘亏就是其它出库)
SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE, STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, OrtherOUTQty)
 SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE,ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE, PRICE,abs(sum(YKQUANTITY)) as Quantity  FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''PD''  and  YKQUANTITY<0 and    convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' ' 
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                
                 SET @sql_str=@sql_str+' GROUP BY   STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE'
 --PRINT @sql_str                             
 EXEC (@sql_str) 



-- ----==专卖店报废-----
 --
     SET @sql_str='INSERT INTO  #TempJXC(STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS, PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE, LOSSQty,LOSSPayAmount)
SELECT STOCK_CODE,STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE,sum(Quantity) as Quantity , sum(PayAmount) as PayAmount  FROM Vi_WL_RECEIPT_DETAIL 
where billtype=''LOS'' and  convert(varchar(10),billdate,120) between '''+@Begindate+''' and '''+ @Enddate+''' '
                 IF @STOCK_CODE<>'' 
                 SET @sql_str=@sql_str+' and STOCK_CODE='''+@STOCK_CODE+''' '
                 IF @PARENT_ITEM_CODE<>''
                 SET @sql_str=@sql_str+' and PARENT_ITEM_CODE='''+@PARENT_ITEM_CODE+''''
                 IF @ITEM_CODE<>'' 
                 SET @sql_str=@sql_str+' and ITEM_CODE='''+@ITEM_CODE+''''
                 IF @sITEM_NAME<>'' 
                 SET @sql_str=@sql_str+' and ITEM_NAME like '''+'%'+@sITEM_NAME+'%'+''''
                 IF @SPECIFICATIONS<>'' 
                 SET @sql_str=@sql_str+' and SPECIFICATIONS  like '''+'%'+@SPECIFICATIONS+'%'+''''                  
                 SET @sql_str=@sql_str+' GROUP BY  STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, SPECIFICATIONS,  PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR, MEASURE_UNIT, NET_PRICE,PRICE' 
                
 --PRINT @SQL_STR             
 EXEC (@sql_str)
            
                    
if  @sType=0 -----显示单价
   begin
 ---专卖店进销存---2014-3-29 日改的
 SELECT   ITEM_CODE as 产品编号, ITEM_NAME as 产品名称,ISNULL(SPECIFICATIONS,'') as 规格型号,
    ITEM_TYPE as 类别名称 ,ITEM_COLOR AS 颜色, MEASURE_UNIT as 单位, 
     NET_PRICE  as 成本价,PRICE as 销售价, 
	 SUM(isnull(BeginQty,0))                AS  上存数,
	 SUM(isnull(BeginQty,0))*NET_PRICE       AS 上存金额,
     SUM(isnull(InQty,0))                   AS 本月进,
     SUM(isnull(inPayAmount,0))             AS 进金额,
     SUM(isnull(OutQty,0))                  AS 本月出,        
     SUM(isnull(outPayAmount,0))            AS 出金额,   
     SUM(isnull(DBOUTQty,0))                AS 本月调出,        
     SUM(isnull(DBOUTPayAmount,0))          AS 调出金额,
     SUM(isnull(DBINQty,0))                 AS 本月调入,        
     SUM(isnull(DBINPayAmount,0))           AS 调入金额,
     SUM(isnull(retQty,0))                  AS 本月退仓,        
     SUM(isnull(retPayAmount,0))            AS 退仓金额, 
     SUM(isnull(OrtherINQty,0))             AS 本月盘盈, --盘点时盘盈       
     SUM(isnull(OrtherOUTQty,0))            AS 本月盘亏, --盘点时盘亏
     SUM(isnull(LOSSQty,0))                 AS 本月报废,     
     SUM(isnull(LOSSPayAmount,0))           AS 报废金额,  
     SUM(isnull(ACTUAL_QTY,0))              AS 本月结存,
     SUM(isnull(ACTUAL_QTY,0))*PRICE        AS 结存金额,
     STOCK_CODE AS 仓库编号, STOCK_NAME as 仓库名称
     FROM #TempJXC  
     WHERE 1=1 and  
      BeginQty>0 OR InQty>0 OR inPayAmount>0   OR  OutQty>0   
      OR outPayAmount>0 OR DBOUTQty>0 OR DBOUTPayAmount>0 OR  DBINQty>0
      OR DBINPayAmount>0 OR retQty>0 OR retPayAmount>0   OR OrtherINQty>0
      OR OrtherOUTQty>0 OR  LOSSQty>0 OR LOSSPayAmount>0  OR ACTUAL_QTY>0
      OR KHTHQty>0       
     GROUP BY 
      STOCK_CODE,
      STOCK_NAME, 
      ITEM_CODE,
      ITEM_NAME,
      ISNULL(SPECIFICATIONS,''),
      ITEM_TYPE,
      ITEM_COLOR,
      MEASURE_UNIT,
      NET_PRICE,
      PRICE 	
 end
 
 
 
 if  @sType=1 -----不显示单价
   begin
 ---专卖店进销存---2014-3-29 日改的
 SELECT  ITEM_CODE as 产品编号, ITEM_NAME as 产品名称,ISNULL(SPECIFICATIONS,'') as 规格型号,
    ITEM_TYPE as 类别名称 ,ITEM_COLOR AS 颜色, MEASURE_UNIT as 单位,
	 SUM(isnull(BeginQty,0))                AS 上存数,	
     SUM(isnull(InQty,0))                   AS 本月进,
     SUM(isnull(OutQty,0))                  AS 本月出,     
     --SUM(isnull(KHTHQty,0))                  AS 客户退数,          
     SUM(isnull(DBOUTQty,0))                AS 本月调出,        
     SUM(isnull(DBINQty,0))                 AS 本月调入,        
     SUM(isnull(retQty,0))                  AS 本月退仓,         
     SUM(isnull(OrtherINQty,0))             AS 本月盘盈, --盘点时盘盈产生       
     SUM(isnull(OrtherOUTQty,0))            AS 本月盘亏, --盘点时盘亏产生
     SUM(isnull(LOSSQty,0))                 AS 本月报废,      
     SUM(isnull(ACTUAL_QTY,0))              AS 本月结存,
     STOCK_CODE AS 仓库编号, STOCK_NAME as 仓库名称
     FROM #TempJXC  
     WHERE 1=1 and  
      BeginQty>0 OR InQty>0 OR inPayAmount>0   OR  OutQty>0   
      OR outPayAmount>0 OR DBOUTQty>0 OR DBOUTPayAmount>0 OR  DBINQty>0
      OR DBINPayAmount>0 OR retQty>0 OR retPayAmount>0   OR OrtherINQty>0
      OR OrtherOUTQty>0 OR  LOSSQty>0 OR LOSSPayAmount>0  OR ACTUAL_QTY>0
      OR KHTHQty>0       
     GROUP BY 
      STOCK_CODE,
      STOCK_NAME, 
      ITEM_CODE,
      ITEM_NAME,
      ISNULL(SPECIFICATIONS,''),
      ITEM_TYPE,
      ITEM_COLOR,
      MEASURE_UNIT
 end
 




END
go


create procedure dbo.SP_WL_JXC_BEGIN @BEGIN_DATE VARCHAR(10)='1991-01-01',
 @STOCK_CODE VARCHAR(50)='',
 @USER_NAME VARCHAR(50)='' as
BEGIN
--===判断是否存在导入期初库存
 DECLARE @SQL_STR VARCHAR(8000)
 SET @SQL_STR='INSERT INTO WL_STOCK_BEGIN
	(STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, ACTUAL_QTY, CREATE_DATE)
SELECT STOCK_CODE, STOCK_NAME, ITEM_INTERNAL_CODE, ITEM_CODE, ITEM_NAME, ACTUAL_QTY, '''+CONVERT(varchar, DATEADD(DD,1,@BEGIN_DATE), 23 )+''' 
FROM  SAL_ITEM_STOCK_DETAIL 
WHERE  STOCK_CODE='''+@STOCK_CODE+'''';
PRINT @SQL_STR
EXEC (@SQL_STR)


-----增加月结记录-------------------------------------------------
 SET @SQL_STR='Insert into WL_STOCK_BEGIN_RECORD(STOCK_CODE,CREATE_DATE,CREATE_NAME) 
values('''+@STOCK_CODE+''','''+@BEGIN_DATE+''','''+@USER_NAME+''')'
PRINT @SQL_STR
EXEC  (@SQL_STR)


  

  
    
  

END
go


create procedure dbo.dt_setpropertybyid @id int,
 	@property varchar(64),
 	@value varchar(255),
 	@lvalue image as
set nocount on
	declare @uvalue nvarchar(255) 
	set @uvalue = convert(nvarchar(255), @value) 
	if exists (select * from dbo.dtproperties 
			where objectid=@id and property=@property)
	begin
		--
		-- bump the version count for this row as we update it
		--
		update dbo.dtproperties set value=@value, uvalue=@uvalue, lvalue=@lvalue, version=version+1
			where objectid=@id and property=@property
	end
	else
	begin
		--
		-- version count is auto-set to 0 on initial insert
		--
		insert dbo.dtproperties (property, objectid, value, uvalue, lvalue)
			values (@property, @id, @value, @uvalue, @lvalue)
	end
go


create procedure dbo.dt_displayoaerror @iObject int,
     @iresult int as
set nocount on

declare @vchOutput      varchar(255)
declare @hr             int
declare @vchSource      varchar(255)
declare @vchDescription varchar(255)

    exec @hr = sp_OAGetErrorInfo @iObject, @vchSource OUT, @vchDescription OUT

    select @vchOutput = @vchSource + ': ' + @vchDescription
    raiserror (@vchOutput,16,-1)

    return
go


create procedure dbo.dt_adduserobject_vcs @vchProperty varchar(64) as
set nocount on

declare @iReturn int
    /*
    ** Create the user object if it does not exist already
    */
    begin transaction
        select @iReturn = objectid from dbo.dtproperties where property = @vchProperty
        if @iReturn IS NULL
        begin
            insert dbo.dtproperties (property) VALUES (@vchProperty)
            update dbo.dtproperties set objectid=@@identity
                    where id=@@identity and property=@vchProperty
            select @iReturn = @@identity
        end
    commit
    return @iReturn
go


create procedure dbo.dt_addtosourcecontrol @vchSourceSafeINI varchar(255) = '',
     @vchProjectName   varchar(255) ='',
     @vchComment       varchar(255) ='',
     @vchLoginName     varchar(255) ='',
     @vchPassword      varchar(255) ='' as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId = 0

declare @iStreamObjectId int
select @iStreamObjectId = 0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

declare @vchDatabaseName varchar(255)
select @vchDatabaseName = db_name()

declare @iReturnValue int
select @iReturnValue = 0

declare @iPropertyObjectId int
declare @vchParentId varchar(255)

declare @iObjectCount int
select @iObjectCount = 0

    exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
    if @iReturn <> 0 GOTO E_OAError


    /* Create Project in SS */
    exec @iReturn = sp_OAMethod @iObjectId,
                                'AddProjectToSourceSafe',
                                NULL,
                                @vchSourceSafeINI,
                                @vchProjectName output,
                                @@SERVERNAME,
                                @vchDatabaseName,
                                @vchLoginName,
                                @vchPassword,
                                @vchComment


    if @iReturn <> 0 GOTO E_OAError

    exec @iReturn = sp_OAGetProperty @iObjectId, 'GetStreamObject', @iStreamObjectId OUT

    if @iReturn <> 0 GOTO E_OAError

    /* Set Database Properties */

    begin tran SetProperties

    /* add high level object */

    exec @iPropertyObjectId = dbo.dt_adduserobject_vcs 'VCSProjectID'

    select @vchParentId = CONVERT(varchar(255),@iPropertyObjectId)

    exec dbo.dt_setpropertybyid @iPropertyObjectId, 'VCSProjectID', @vchParentId , NULL
    exec dbo.dt_setpropertybyid @iPropertyObjectId, 'VCSProject' , @vchProjectName , NULL
    exec dbo.dt_setpropertybyid @iPropertyObjectId, 'VCSSourceSafeINI' , @vchSourceSafeINI , NULL
    exec dbo.dt_setpropertybyid @iPropertyObjectId, 'VCSSQLServer', @@SERVERNAME, NULL
    exec dbo.dt_setpropertybyid @iPropertyObjectId, 'VCSSQLDatabase', @vchDatabaseName, NULL

    if @@error <> 0 GOTO E_General_Error

    commit tran SetProperties

    declare cursorProcNames cursor for
        select convert(varchar(255), name) from sysobjects where type = 'P' and name not like 'dt_%'
    open cursorProcNames

    while 1 = 1
    begin
        declare @vchProcName varchar(255)
        fetch next from cursorProcNames into @vchProcName
        if @@fetch_status <> 0
            break

        select colid, text into #ProcLines
        from syscomments
        where id = object_id(@vchProcName)
        order by colid

        declare @iCurProcLine int
        declare @iProcLines int
        select @iCurProcLine = 1
        select @iProcLines = (select count(*) from #ProcLines)
        while @iCurProcLine <= @iProcLines
        begin
            declare @pos int
            select @pos = 1
            declare @iCurLineSize int
            select @iCurLineSize = len((select text from #ProcLines where colid = @iCurProcLine))
            while @pos <= @iCurLineSize
            begin
                declare @vchProcLinePiece varchar(255)
                select @vchProcLinePiece = convert(varchar(255),
                    substring((select text from #ProcLines where colid = @iCurProcLine),
                              @pos, 255 ))
                exec @iReturn = sp_OAMethod @iStreamObjectId, 'AddStream', @iReturnValue OUT, @vchProcLinePiece
                if @iReturn <> 0 GOTO E_OAError
                select @pos = @pos + 255
            end
            select @iCurProcLine = @iCurProcLine + 1
        end
        drop table #ProcLines

        exec @iReturn = sp_OAMethod @iObjectId,
                                    'CheckIn_StoredProcedure',
                                    NULL,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sServerName = @@SERVERNAME,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sObjectName = @vchProcName,
                                    @sComment = @vchComment,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword,
                                    @iVCSFlags = 0,
                                    @iActionFlag = 0,
                                    @sStream = ''

        if @iReturn = 0 select @iObjectCount = @iObjectCount + 1

    end

CleanUp:
	close cursorProcNames
	deallocate cursorProcNames
    select @vchProjectName
    select @iObjectCount
    return

E_General_Error:
    /* this is an all or nothing.  No specific error messages */
    goto CleanUp

E_OAError:
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_generateansiname (@name varchar(255) output) as
declare @prologue varchar(20) 
	declare @indexstring varchar(20) 
	declare @index integer 
 
	set @prologue = 'MSDT-A-' 
	set @index = 1 
 
	while 1 = 1 
	begin 
		set @indexstring = cast(@index as varchar(20)) 
		set @name = @prologue + @indexstring 
		if not exists (select value from dtproperties where value = @name) 
			break 
		 
		set @index = @index + 1 
 
		if (@index = 10000) 
			goto TooMany 
	end 
 
Leave: 
 
	return 
 
TooMany: 
 
	set @name = 'DIAGRAM' 
	goto Leave
go


create procedure dbo.dt_setpropertybyid_u @id int,
 	@property varchar(64),
 	@uvalue nvarchar(255),
 	@lvalue image as
set nocount on
	-- 
	-- If we are writing the name property, find the ansi equivalent. 
	-- If there is no lossless translation, generate an ansi name. 
	-- 
	declare @avalue varchar(255) 
	set @avalue = null 
	if (@uvalue is not null) 
	begin 
		if (convert(nvarchar(255), convert(varchar(255), @uvalue)) = @uvalue) 
		begin 
			set @avalue = convert(varchar(255), @uvalue) 
		end 
		else 
		begin 
			if 'DtgSchemaNAME' = @property 
			begin 
				exec dbo.dt_generateansiname @avalue output 
			end 
		end 
	end 
	if exists (select * from dbo.dtproperties 
			where objectid=@id and property=@property)
	begin
		--
		-- bump the version count for this row as we update it
		--
		update dbo.dtproperties set value=@avalue, uvalue=@uvalue, lvalue=@lvalue, version=version+1
			where objectid=@id and property=@property
	end
	else
	begin
		--
		-- version count is auto-set to 0 on initial insert
		--
		insert dbo.dtproperties (property, objectid, value, uvalue, lvalue)
			values (@property, @id, @avalue, @uvalue, @lvalue)
	end
go


create procedure dbo.dt_displayoaerror_u @iObject int,
     @iresult int as
set nocount on

declare @vchOutput      nvarchar(255)
declare @hr             int
declare @vchSource      nvarchar(255)
declare @vchDescription nvarchar(255)

    exec @hr = sp_OAGetErrorInfo @iObject, @vchSource OUT, @vchDescription OUT

    select @vchOutput = @vchSource + ': ' + @vchDescription
    raiserror (@vchOutput,16,-1)

    return
go


create procedure dbo.dt_addtosourcecontrol_u @vchSourceSafeINI nvarchar(255) = '',
     @vchProjectName   nvarchar(255) ='',
     @vchComment       nvarchar(255) ='',
     @vchLoginName     nvarchar(255) ='',
     @vchPassword      nvarchar(255) ='' as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId = 0

declare @iStreamObjectId int
select @iStreamObjectId = 0

declare @VSSGUID nvarchar(100)
select @VSSGUID = N'SQLVersionControl.VCS_SQL'

declare @vchDatabaseName varchar(255)
select @vchDatabaseName = db_name()

declare @iReturnValue int
select @iReturnValue = 0

declare @iPropertyObjectId int
declare @vchParentId nvarchar(255)

declare @iObjectCount int
select @iObjectCount = 0

    exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
    if @iReturn <> 0 GOTO E_OAError


    /* Create Project in SS */
    exec @iReturn = sp_OAMethod @iObjectId,
                                'AddProjectToSourceSafe',
                                NULL,
                                @vchSourceSafeINI,
                                @vchProjectName output,
                                @@SERVERNAME,
                                @vchDatabaseName,
                                @vchLoginName,
                                @vchPassword,
                                @vchComment


    if @iReturn <> 0 GOTO E_OAError

    exec @iReturn = sp_OAGetProperty @iObjectId, N'GetStreamObject', @iStreamObjectId OUT

    if @iReturn <> 0 GOTO E_OAError

    /* Set Database Properties */

    begin tran SetProperties

    /* add high level object */

    exec @iPropertyObjectId = dbo.dt_adduserobject_vcs 'VCSProjectID'

    select @vchParentId = CONVERT(nvarchar(255),@iPropertyObjectId)

    exec dbo.dt_setpropertybyid_u @iPropertyObjectId, 'VCSProjectID', @vchParentId , NULL
    exec dbo.dt_setpropertybyid_u @iPropertyObjectId, 'VCSProject' , @vchProjectName , NULL
    exec dbo.dt_setpropertybyid_u @iPropertyObjectId, 'VCSSourceSafeINI' , @vchSourceSafeINI , NULL
    exec dbo.dt_setpropertybyid_u @iPropertyObjectId, 'VCSSQLServer', @@SERVERNAME, NULL
    exec dbo.dt_setpropertybyid_u @iPropertyObjectId, 'VCSSQLDatabase', @vchDatabaseName, NULL

    if @@error <> 0 GOTO E_General_Error

    commit tran SetProperties

    declare cursorProcNames cursor for
        select convert(nvarchar(255), name) from sysobjects where type = N'P' and name not like N'dt_%'
    open cursorProcNames

    while 1 = 1
    begin
        declare @vchProcName nvarchar(255)
        fetch next from cursorProcNames into @vchProcName
        if @@fetch_status <> 0
            break

        select colid, text into #ProcLines
        from syscomments
        where id = object_id(@vchProcName)
        order by colid

        declare @iCurProcLine int
        declare @iProcLines int
        select @iCurProcLine = 1
        select @iProcLines = (select count(*) from #ProcLines)
        while @iCurProcLine <= @iProcLines
        begin
            declare @pos int
            select @pos = 1
            declare @iCurLineSize int
            select @iCurLineSize = len((select text from #ProcLines where colid = @iCurProcLine))
            while @pos <= @iCurLineSize
            begin
                declare @vchProcLinePiece nvarchar(255)
                select @vchProcLinePiece = convert(nvarchar(255),
                    substring((select text from #ProcLines where colid = @iCurProcLine),
                              @pos, 255 ))
                exec @iReturn = sp_OAMethod @iStreamObjectId, N'AddStream', @iReturnValue OUT, @vchProcLinePiece
                if @iReturn <> 0 GOTO E_OAError
                select @pos = @pos + 255
            end
            select @iCurProcLine = @iCurProcLine + 1
        end
        drop table #ProcLines

        exec @iReturn = sp_OAMethod @iObjectId,
                                    'CheckIn_StoredProcedure',
                                    NULL,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sServerName = @@SERVERNAME,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sObjectName = @vchProcName,
                                    @sComment = @vchComment,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword,
                                    @iVCSFlags = 0,
                                    @iActionFlag = 0,
                                    @sStream = ''

        if @iReturn = 0 select @iObjectCount = @iObjectCount + 1

    end

CleanUp:
	close cursorProcNames
	deallocate cursorProcNames
    select @vchProjectName
    select @iObjectCount
    return

E_General_Error:
    /* this is an all or nothing.  No specific error messages */
    goto CleanUp

E_OAError:
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_adduserobject as
set nocount on
	/*
	** Create the user object if it does not exist already
	*/
	begin transaction
		insert dbo.dtproperties (property) VALUES ('DtgSchemaOBJECT')
		update dbo.dtproperties set objectid=@@identity 
			where id=@@identity and property='DtgSchemaOBJECT'
	commit
	return @@identity
go


create procedure dbo.dt_getpropertiesbyid_vcs @id       int,
     @property varchar(64),
     @value    varchar(255) = NULL OUT as
set nocount on

    select @value = (
        select value
                from dbo.dtproperties
                where @id=objectid and @property=property
                )
go


create procedure dbo.dt_checkinobject @chObjectType  char(4),
     @vchObjectName varchar(255),
     @vchComment    varchar(255)='',
     @vchLoginName  varchar(255),
     @vchPassword   varchar(255)='',
     @iVCSFlags     int = 0,
     @iActionFlag   int = 0,   /* 0 => AddFile, 1 => CheckIn */
     @txStream1     Text = '', /* There is a bug that if items are NULL they do not pass to OLE servers */
     @txStream2     Text = '',
     @txStream3     Text = '' as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId = 0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'


declare @iPropertyObjectId int
select @iPropertyObjectId  = 0

    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   varchar(255)
    declare @vchSourceSafeINI varchar(255)
    declare @vchServerName    varchar(255)
    declare @vchDatabaseName  varchar(255)
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        if @iActionFlag = 1
        begin
            /* Procedure Can have up to three streams
            Drop Stream, Create Stream, GRANT stream */

            begin tran compile_all

            /* try to compile the streams */
            exec (@txStream1)
            if @@error <> 0 GOTO E_Compile_Fail

            exec (@txStream2)
            if @@error <> 0 GOTO E_Compile_Fail

            exec (@txStream3)
            if @@error <> 0 GOTO E_Compile_Fail
        end

        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
        if @iReturn <> 0 GOTO E_OAError

        if @iActionFlag = 1
        begin
            exec @iReturn = sp_OAMethod @iObjectId,
                                        'CheckIn_StoredProcedure',
                                        NULL,
                                        @sProjectName = @vchProjectName,
                                        @sSourceSafeINI = @vchSourceSafeINI,
                                        @sServerName = @vchServerName,
                                        @sDatabaseName = @vchDatabaseName,
                                        @sObjectName = @vchObjectName,
                                        @sComment = @vchComment,
                                        @sLoginName = @vchLoginName,
                                        @sPassword = @vchPassword,
                                        @iVCSFlags = @iVCSFlags,
                                        @iActionFlag = @iActionFlag,
                                        @sStream = @txStream2
        end
        else
        begin
            declare @iStreamObjectId int
            declare @iReturnValue int

            exec @iReturn = sp_OAGetProperty @iObjectId, 'GetStreamObject', @iStreamObjectId OUT
            if @iReturn <> 0 GOTO E_OAError

            select colid, text into #ProcLines
            from syscomments
            where id = object_id(@vchObjectName)
            order by colid

            declare @iCurProcLine int
            declare @iProcLines int
            select @iCurProcLine = 1
            select @iProcLines = (select count(*) from #ProcLines)
            while @iCurProcLine <= @iProcLines
            begin
                declare @pos int
                select @pos = 1
                declare @iCurLineSize int
                select @iCurLineSize = len((select text from #ProcLines where colid = @iCurProcLine))
                while @pos <= @iCurLineSize
                begin
                    declare @vchProcLinePiece varchar(255)
                    select @vchProcLinePiece = convert(varchar(255),
                        substring((select text from #ProcLines where colid = @iCurProcLine),
                                  @pos, 255 ))
                    exec @iReturn = sp_OAMethod @iStreamObjectId, 'AddStream', @iReturnValue OUT, @vchProcLinePiece
                    if @iReturn <> 0 GOTO E_OAError
                    select @pos = @pos + 255
                end
                select @iCurProcLine = @iCurProcLine + 1
            end
            drop table #ProcLines

            exec @iReturn = sp_OAMethod @iObjectId,
                                        'CheckIn_StoredProcedure',
                                        NULL,
                                        @sProjectName = @vchProjectName,
                                        @sSourceSafeINI = @vchSourceSafeINI,
                                        @sServerName = @vchServerName,
                                        @sDatabaseName = @vchDatabaseName,
                                        @sObjectName = @vchObjectName,
                                        @sComment = @vchComment,
                                        @sLoginName = @vchLoginName,
                                        @sPassword = @vchPassword,
                                        @iVCSFlags = @iVCSFlags,
                                        @iActionFlag = @iActionFlag,
                                        @sStream = ''
        end

        if @iReturn <> 0 GOTO E_OAError

        if @iActionFlag = 1
        begin
            commit tran compile_all
            if @@error <> 0 GOTO E_Compile_Fail
        end

    end

CleanUp:
    return

E_Compile_Fail:
    declare @lerror int
    select @lerror = @@error
    rollback tran compile_all
    RAISERROR (@lerror,16,-1)
    goto CleanUp

E_OAError:
    if @iActionFlag = 1 rollback tran compile_all
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_getpropertiesbyid_vcs_u @id       int,
     @property varchar(64),
     @value    nvarchar(255) = NULL OUT as
set nocount on

    select @value = (
        select uvalue
                from dbo.dtproperties
                where @id=objectid and @property=property
                )
go


create procedure dbo.dt_checkinobject_u @chObjectType  char(4),
     @vchObjectName nvarchar(255),
     @vchComment    nvarchar(255)='',
     @vchLoginName  nvarchar(255),
     @vchPassword   nvarchar(255)='',
     @iVCSFlags     int = 0,
     @iActionFlag   int = 0,   /* 0 => AddFile, 1 => CheckIn */
     @txStream1     Text = '', /* There is a bug that if items are NULL they do not pass to OLE servers */
     @txStream2     Text = '',
     @txStream3     Text = '' as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId = 0

declare @VSSGUID nvarchar(100)
select @VSSGUID = N'SQLVersionControl.VCS_SQL'


declare @iPropertyObjectId int
select @iPropertyObjectId  = 0

    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   nvarchar(255)
    declare @vchSourceSafeINI nvarchar(255)
    declare @vchServerName    nvarchar(255)
    declare @vchDatabaseName  nvarchar(255)
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        if @iActionFlag = 1
        begin
            /* Procedure Can have up to three streams
            Drop Stream, Create Stream, GRANT stream */

            begin tran compile_all

            /* try to compile the streams */
            exec (@txStream1)
            if @@error <> 0 GOTO E_Compile_Fail

            exec (@txStream2)
            if @@error <> 0 GOTO E_Compile_Fail

            exec (@txStream3)
            if @@error <> 0 GOTO E_Compile_Fail
        end

        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
        if @iReturn <> 0 GOTO E_OAError

        if @iActionFlag = 1
        begin
            exec @iReturn = sp_OAMethod @iObjectId,
                                        N'CheckIn_StoredProcedure',
                                        NULL,
                                        @sProjectName = @vchProjectName,
                                        @sSourceSafeINI = @vchSourceSafeINI,
                                        @sServerName = @vchServerName,
                                        @sDatabaseName = @vchDatabaseName,
                                        @sObjectName = @vchObjectName,
                                        @sComment = @vchComment,
                                        @sLoginName = @vchLoginName,
                                        @sPassword = @vchPassword,
                                        @iVCSFlags = @iVCSFlags,
                                        @iActionFlag = @iActionFlag,
                                        @sStream = @txStream2
        end
        else
        begin
            declare @iStreamObjectId int
            declare @iReturnValue int

            exec @iReturn = sp_OAGetProperty @iObjectId, N'GetStreamObject', @iStreamObjectId OUT
            if @iReturn <> 0 GOTO E_OAError

            select colid, text into #ProcLines
            from syscomments
            where id = object_id(@vchObjectName)
            order by colid

            declare @iCurProcLine int
            declare @iProcLines int
            select @iCurProcLine = 1
            select @iProcLines = (select count(*) from #ProcLines)
            while @iCurProcLine <= @iProcLines
            begin
                declare @pos int
                select @pos = 1
                declare @iCurLineSize int
                select @iCurLineSize = len((select text from #ProcLines where colid = @iCurProcLine))
                while @pos <= @iCurLineSize
                begin
                    declare @vchProcLinePiece nvarchar(255)
                    select @vchProcLinePiece = convert(nvarchar(255),
                        substring((select text from #ProcLines where colid = @iCurProcLine),
                                  @pos, 255 ))
                    exec @iReturn = sp_OAMethod @iStreamObjectId, N'AddStream', @iReturnValue OUT, @vchProcLinePiece
                    if @iReturn <> 0 GOTO E_OAError
                    select @pos = @pos + 255
                end
                select @iCurProcLine = @iCurProcLine + 1
            end
            drop table #ProcLines

            exec @iReturn = sp_OAMethod @iObjectId,
                                        N'CheckIn_StoredProcedure',
                                        NULL,
                                        @sProjectName = @vchProjectName,
                                        @sSourceSafeINI = @vchSourceSafeINI,
                                        @sServerName = @vchServerName,
                                        @sDatabaseName = @vchDatabaseName,
                                        @sObjectName = @vchObjectName,
                                        @sComment = @vchComment,
                                        @sLoginName = @vchLoginName,
                                        @sPassword = @vchPassword,
                                        @iVCSFlags = @iVCSFlags,
                                        @iActionFlag = @iActionFlag,
                                        @sStream = ''
        end

        if @iReturn <> 0 GOTO E_OAError

        if @iActionFlag = 1
        begin
            commit tran compile_all
            if @@error <> 0 GOTO E_Compile_Fail
        end

    end

CleanUp:
    return

E_Compile_Fail:
    declare @lerror int
    select @lerror = @@error
    rollback tran compile_all
    RAISERROR (@lerror,16,-1)
    goto CleanUp

E_OAError:
    if @iActionFlag = 1 rollback tran compile_all
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_checkoutobject @chObjectType  char(4),
     @vchObjectName varchar(255),
     @vchComment    varchar(255),
     @vchLoginName  varchar(255),
     @vchPassword   varchar(255),
     @iVCSFlags     int = 0,
     @iActionFlag   int = 0/* 0 => Checkout, 1 => GetLatest, 2 => UndoCheckOut */ as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

declare @iReturnValue int
select @iReturnValue = 0

declare @vchTempText varchar(255)

/* this is for our strings */
declare @iStreamObjectId int
select @iStreamObjectId = 0

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   varchar(255)
    declare @vchSourceSafeINI varchar(255)
    declare @vchServerName    varchar(255)
    declare @vchDatabaseName  varchar(255)
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        /* Procedure Can have up to three streams
           Drop Stream, Create Stream, GRANT stream */

        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAMethod @iObjectId,
                                    'CheckOut_StoredProcedure',
                                    NULL,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sObjectName = @vchObjectName,
                                    @sServerName = @vchServerName,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sComment = @vchComment,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword,
                                    @iVCSFlags = @iVCSFlags,
                                    @iActionFlag = @iActionFlag

        if @iReturn <> 0 GOTO E_OAError


        exec @iReturn = sp_OAGetProperty @iObjectId, 'GetStreamObject', @iStreamObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        create table #commenttext (id int identity, sourcecode varchar(255))


        select @vchTempText = 'STUB'
        while @vchTempText IS NOT NULL
        begin
            exec @iReturn = sp_OAMethod @iStreamObjectId, 'GetStream', @iReturnValue OUT, @vchTempText OUT
            if @iReturn <> 0 GOTO E_OAError

            if (@vchTempText IS NOT NULL) insert into #commenttext (sourcecode) select @vchTempText
        end

        select 'VCS'=sourcecode from #commenttext order by id
        select 'SQL'=text from syscomments where id = object_id(@vchObjectName) order by colid

    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.dt_checkoutobject_u @chObjectType  char(4),
     @vchObjectName nvarchar(255),
     @vchComment    nvarchar(255),
     @vchLoginName  nvarchar(255),
     @vchPassword   nvarchar(255),
     @iVCSFlags     int = 0,
     @iActionFlag   int = 0/* 0 => Checkout, 1 => GetLatest, 2 => UndoCheckOut */ as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID nvarchar(100)
select @VSSGUID = N'SQLVersionControl.VCS_SQL'

declare @iReturnValue int
select @iReturnValue = 0

declare @vchTempText nvarchar(255)

/* this is for our strings */
declare @iStreamObjectId int
select @iStreamObjectId = 0

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   nvarchar(255)
    declare @vchSourceSafeINI nvarchar(255)
    declare @vchServerName    nvarchar(255)
    declare @vchDatabaseName  nvarchar(255)
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        /* Procedure Can have up to three streams
           Drop Stream, Create Stream, GRANT stream */

        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAMethod @iObjectId,
                                    N'CheckOut_StoredProcedure',
                                    NULL,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sObjectName = @vchObjectName,
                                    @sServerName = @vchServerName,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sComment = @vchComment,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword,
                                    @iVCSFlags = @iVCSFlags,
                                    @iActionFlag = @iActionFlag

        if @iReturn <> 0 GOTO E_OAError


        exec @iReturn = sp_OAGetProperty @iObjectId, N'GetStreamObject', @iStreamObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        create table #commenttext (id int identity, sourcecode nvarchar(255))


        select @vchTempText = N'STUB'
        while @vchTempText IS NOT NULL
        begin
            exec @iReturn = sp_OAMethod @iStreamObjectId, N'GetStream', @iReturnValue OUT, @vchTempText OUT
            if @iReturn <> 0 GOTO E_OAError

            if (@vchTempText IS NOT NULL) insert into #commenttext (sourcecode) select @vchTempText
        end

        select N'VCS'=sourcecode from #commenttext order by id
        select N'SQL'=text from syscomments where id = object_id(@vchObjectName) order by colid

    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.dt_droppropertiesbyid @id int,
 	@property varchar(64) as
set nocount on

	if (@property is null) or (@property = '')
		delete from dbo.dtproperties where objectid=@id
	else
		delete from dbo.dtproperties 
			where objectid=@id and property=@property
go


create procedure dbo.dt_dropuserobjectbyid @id int as
set nocount on
	delete from dbo.dtproperties where objectid=@id
go


create procedure dbo.dt_getobjwithprop @property varchar(30),
 	@value varchar(255) as
set nocount on

	if (@property is null) or (@property = '')
	begin
		raiserror('Must specify a property name.',-1,-1)
		return (1)
	end

	if (@value is null)
		select objectid id from dbo.dtproperties
			where property=@property

	else
		select objectid id from dbo.dtproperties
			where property=@property and value=@value
go


create procedure dbo.dt_getobjwithprop_u @property varchar(30),
 	@uvalue nvarchar(255) as
set nocount on

	if (@property is null) or (@property = '')
	begin
		raiserror('Must specify a property name.',-1,-1)
		return (1)
	end

	if (@uvalue is null)
		select objectid id from dbo.dtproperties
			where property=@property

	else
		select objectid id from dbo.dtproperties
			where property=@property and uvalue=@uvalue
go


create procedure dbo.dt_getpropertiesbyid @id int,
 	@property varchar(64) as
set nocount on

	if (@property is null) or (@property = '')
		select property, version, value, lvalue
			from dbo.dtproperties
			where  @id=objectid
	else
		select property, version, value, lvalue
			from dbo.dtproperties
			where  @id=objectid and @property=property
go


create procedure dbo.dt_getpropertiesbyid_u @id int,
 	@property varchar(64) as
set nocount on

	if (@property is null) or (@property = '')
		select property, version, uvalue, lvalue
			from dbo.dtproperties
			where  @id=objectid
	else
		select property, version, uvalue, lvalue
			from dbo.dtproperties
			where  @id=objectid and @property=property
go


create procedure dbo.dt_isundersourcecontrol @vchLoginName varchar(255) = '',
     @vchPassword  varchar(255) = '',
     @iWhoToo      int = 0 /* 0 => Just check project; 1 => get list of objs */ as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId = 0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

declare @iReturnValue int
select @iReturnValue = 0

declare @iStreamObjectId int
select @iStreamObjectId   = 0

declare @vchTempText varchar(255)

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   varchar(255)
    declare @vchSourceSafeINI varchar(255)
    declare @vchServerName    varchar(255)
    declare @vchDatabaseName  varchar(255)
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if (@vchProjectName IS NULL) or (@vchSourceSafeINI  IS NULL) or (@vchServerName IS NULL) or (@vchDatabaseName IS NULL)
    begin
        RAISERROR('Not Under Source Control',16,-1)
        return
    end

    if @iWhoToo = 1
    begin

        /* Get List of Procs in the project */
        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAMethod @iObjectId,
                                    'GetListOfObjects',
                                    NULL,
                                    @vchProjectName,
                                    @vchSourceSafeINI,
                                    @vchServerName,
                                    @vchDatabaseName,
                                    @vchLoginName,
                                    @vchPassword

        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAGetProperty @iObjectId, 'GetStreamObject', @iStreamObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        create table #ObjectList (id int identity, vchObjectlist varchar(255))

        select @vchTempText = 'STUB'
        while @vchTempText IS NOT NULL
        begin
            exec @iReturn = sp_OAMethod @iStreamObjectId, 'GetStream', @iReturnValue OUT, @vchTempText OUT
            if @iReturn <> 0 GOTO E_OAError

            if (@vchTempText IS NOT NULL) insert into #ObjectList (vchObjectlist ) select @vchTempText
        end

        select vchObjectlist from #ObjectList order by id
    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_isundersourcecontrol_u @vchLoginName nvarchar(255) = '',
     @vchPassword  nvarchar(255) = '',
     @iWhoToo      int = 0 /* 0 => Just check project; 1 => get list of objs */ as
set nocount on

	declare @iReturn int
	declare @iObjectId int
	select @iObjectId = 0

	declare @VSSGUID nvarchar(100)
	select @VSSGUID = N'SQLVersionControl.VCS_SQL'

	declare @iReturnValue int
	select @iReturnValue = 0

	declare @iStreamObjectId int
	select @iStreamObjectId   = 0

	declare @vchTempText nvarchar(255)

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   nvarchar(255)
    declare @vchSourceSafeINI nvarchar(255)
    declare @vchServerName    nvarchar(255)
    declare @vchDatabaseName  nvarchar(255)
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if (@vchProjectName IS NULL) or (@vchSourceSafeINI  IS NULL) or (@vchServerName IS NULL) or (@vchDatabaseName IS NULL)
    begin
        RAISERROR(N'Not Under Source Control',16,-1)
        return
    end

    if @iWhoToo = 1
    begin

        /* Get List of Procs in the project */
        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAMethod @iObjectId,
                                    N'GetListOfObjects',
                                    NULL,
                                    @vchProjectName,
                                    @vchSourceSafeINI,
                                    @vchServerName,
                                    @vchDatabaseName,
                                    @vchLoginName,
                                    @vchPassword

        if @iReturn <> 0 GOTO E_OAError

        exec @iReturn = sp_OAGetProperty @iObjectId, N'GetStreamObject', @iStreamObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        create table #ObjectList (id int identity, vchObjectlist nvarchar(255))

        select @vchTempText = N'STUB'
        while @vchTempText IS NOT NULL
        begin
            exec @iReturn = sp_OAMethod @iStreamObjectId, N'GetStream', @iReturnValue OUT, @vchTempText OUT
            if @iReturn <> 0 GOTO E_OAError

            if (@vchTempText IS NOT NULL) insert into #ObjectList (vchObjectlist ) select @vchTempText
        end

        select vchObjectlist from #ObjectList order by id
    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    goto CleanUp
go


create procedure dbo.dt_removefromsourcecontrol as
set nocount on

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    exec dbo.dt_droppropertiesbyid @iPropertyObjectId, null

    /* -1 is returned by dt_droppopertiesbyid */
    if @@error <> 0 and @@error <> -1 return 1

    return 0
go


create procedure dbo.dt_validateloginparams @vchLoginName  varchar(255),
     @vchPassword   varchar(255) as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchSourceSafeINI varchar(255)
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT

    exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
    if @iReturn <> 0 GOTO E_OAError

    exec @iReturn = sp_OAMethod @iObjectId,
                                'ValidateLoginParams',
                                NULL,
                                @sSourceSafeINI = @vchSourceSafeINI,
                                @sLoginName = @vchLoginName,
                                @sPassword = @vchPassword
    if @iReturn <> 0 GOTO E_OAError

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.dt_validateloginparams_u @vchLoginName  nvarchar(255),
     @vchPassword   nvarchar(255) as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID nvarchar(100)
select @VSSGUID = N'SQLVersionControl.VCS_SQL'

    declare @iPropertyObjectId int
    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchSourceSafeINI nvarchar(255)
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT

    exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
    if @iReturn <> 0 GOTO E_OAError

    exec @iReturn = sp_OAMethod @iObjectId,
                                N'ValidateLoginParams',
                                NULL,
                                @sSourceSafeINI = @vchSourceSafeINI,
                                @sLoginName = @vchLoginName,
                                @sPassword = @vchPassword
    if @iReturn <> 0 GOTO E_OAError

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.dt_vcsenabled as
set nocount on

declare @iObjectId int
select @iObjectId = 0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

    declare @iReturn int
    exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT
    if @iReturn <> 0 raiserror('', 16, -1) /* Can't Load Helper DLLC */
go


create procedure dbo.dt_verstamp006 as
select 7000
go


create procedure dbo.dt_whocheckedout @chObjectType  char(4),
         @vchObjectName varchar(255),
         @vchLoginName  varchar(255),
         @vchPassword   varchar(255) as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID varchar(100)
select @VSSGUID = 'SQLVersionControl.VCS_SQL'

    declare @iPropertyObjectId int

    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   varchar(255)
    declare @vchSourceSafeINI varchar(255)
    declare @vchServerName    varchar(255)
    declare @vchDatabaseName  varchar(255)
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        declare @vchReturnValue varchar(255)
        select @vchReturnValue = ''

        exec @iReturn = sp_OAMethod @iObjectId,
                                    'WhoCheckedOut',
                                    @vchReturnValue OUT,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sObjectName = @vchObjectName,
                                    @sServerName = @vchServerName,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword

        if @iReturn <> 0 GOTO E_OAError

        select @vchReturnValue

    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.dt_whocheckedout_u @chObjectType  char(4),
         @vchObjectName nvarchar(255),
         @vchLoginName  nvarchar(255),
         @vchPassword   nvarchar(255) as
set nocount on

declare @iReturn int
declare @iObjectId int
select @iObjectId =0

declare @VSSGUID nvarchar(100)
select @VSSGUID = N'SQLVersionControl.VCS_SQL'

    declare @iPropertyObjectId int

    select @iPropertyObjectId = (select objectid from dbo.dtproperties where property = 'VCSProjectID')

    declare @vchProjectName   nvarchar(255)
    declare @vchSourceSafeINI nvarchar(255)
    declare @vchServerName    nvarchar(255)
    declare @vchDatabaseName  nvarchar(255)
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSProject',       @vchProjectName   OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSourceSafeINI', @vchSourceSafeINI OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLServer',     @vchServerName    OUT
    exec dbo.dt_getpropertiesbyid_vcs_u @iPropertyObjectId, 'VCSSQLDatabase',   @vchDatabaseName  OUT

    if @chObjectType = 'PROC'
    begin
        exec @iReturn = sp_OACreate @VSSGUID, @iObjectId OUT

        if @iReturn <> 0 GOTO E_OAError

        declare @vchReturnValue nvarchar(255)
        select @vchReturnValue = ''

        exec @iReturn = sp_OAMethod @iObjectId,
                                    N'WhoCheckedOut',
                                    @vchReturnValue OUT,
                                    @sProjectName = @vchProjectName,
                                    @sSourceSafeINI = @vchSourceSafeINI,
                                    @sObjectName = @vchObjectName,
                                    @sServerName = @vchServerName,
                                    @sDatabaseName = @vchDatabaseName,
                                    @sLoginName = @vchLoginName,
                                    @sPassword = @vchPassword

        if @iReturn <> 0 GOTO E_OAError

        select @vchReturnValue

    end

CleanUp:
    return

E_OAError:
    exec dbo.dt_displayoaerror_u @iObjectId, @iReturn
    GOTO CleanUp
go


create procedure dbo.lwj as
begin
  select USER_CODE,USER_NAME,PASSWORD  from  dbo.SYS_USER
   select * from    data.dbo.SYS_USER 
END
go


create procedure dbo.p_createjob @jobname   varchar(100), --作业名称   
    @sql   varchar(8000), --要执行的命令   
    @dbname   sysname='', --默认为当前的数据库名   
    @freqtype   varchar(6)='day', --时间周期,month   月,week   周,day   日   
    @fsinterval   int=1, --相对于每日的重复次数   
    @time   int=170000 --开始执行时间,对于重复执行的作业,将从0点到23:59分 as
if   isnull(@dbname,'')=''   set   @dbname=db_name()   
     
   --创建作业   
   exec   msdb..sp_add_job   @job_name=@jobname   
     
   --创建作业步骤   
   exec   msdb..sp_add_jobstep   @job_name=@jobname,   
   @step_name   =   '数据处理',   
   @subsystem   =   'TSQL',   
   @database_name=@dbname,   
   @command   =   @sql,   
   @retry_attempts   =   5,   --重试次数   
   @retry_interval   =   5     --重试间隔   
     
   --创建调度   
   declare   @ftype   int,@fstype   int,@ffactor   int   
   select   @ftype=case   @freqtype   when   'day'   then   4   
   when   'week'   then   8   
   when   'month'   then   16   end   
   ,@fstype=case   @fsinterval   when   1   then   0   else   8   end   
   if   @fsinterval<>1   set   @time=0   
   set   @ffactor=case   @freqtype   when   'day'   then   0   else   1   end   
     
   EXEC   msdb..sp_add_jobschedule   @job_name=@jobname,     
   @name   =   '时间安排',   
   @freq_type=@ftype   ,   --每天,8   每周,16   每月   
   @freq_interval=1, --重复执行次数   
   @freq_subday_type=@fstype, --是否重复执行   
   @freq_subday_interval=@fsinterval,   --重复周期   
   @freq_recurrence_factor=@ffactor,   
   @active_start_time=@time     --下午17:00:00分执行   
     
   --   添加目标服务器   
   EXEC   msdb.dbo.sp_add_jobserver     
   @job_name   =   '数据处理'   ,   
   @server_name   =   N'(local)'
go

