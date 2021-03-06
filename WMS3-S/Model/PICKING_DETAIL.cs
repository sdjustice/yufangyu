//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PICKING_DETAIL
    {
        public string GUID { get; set; }
        public string ORDER_DETAIL_GUID { get; set; }
        public string ORDER_BATCH_DETAIL_GUID { get; set; }
        public string ORDER_NO { get; set; }
        public string ORDER_BATCH_NO { get; set; }
        public string PICKING_NO { get; set; }
        public Nullable<decimal> ASSIGN_QTY { get; set; }
        public Nullable<decimal> PICK_QTY { get; set; }
        public string RECEIVE_NO { get; set; }
        public string RECEIVE_BATCH_NO { get; set; }
        public string PUTAWAY_NO { get; set; }
        public string PLT_NO { get; set; }
        public string WH_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string SKU { get; set; }
        public string CONSIGNEE_CODE { get; set; }
        public string CONSIGNEE_SKU { get; set; }
        public string NOTIFY_CODE { get; set; }
        public string NOTIFY_SKU { get; set; }
        public string LOT_NO { get; set; }
        public string INV_NO { get; set; }
        public string PO_NO { get; set; }
        public string COUNTRY { get; set; }
        public Nullable<System.DateTime> DATECODE { get; set; }
        public string CUSTOMER_REF_NO { get; set; }
        public string CONSIGNEE_REF_NO { get; set; }
        public string NOTIFY_REF_NO { get; set; }
        public Nullable<decimal> PIRCE { get; set; }
        public Nullable<decimal> UNIT_GW { get; set; }
        public Nullable<decimal> UNIT_NW { get; set; }
        public Nullable<decimal> UNIT_VOLUME { get; set; }
        public string REWORK_FLAG { get; set; }
        public string WORK_STATUS { get; set; }
        public string QC_STATUS { get; set; }
        public string ZONE_CODE { get; set; }
        public string AREA_CODE { get; set; }
        public string LOC_CODE { get; set; }
        public string DAMAGE_FLAG { get; set; }
        public string LOCKING_FLAG { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string UDF6 { get; set; }
        public string UDF7 { get; set; }
        public string UDF8 { get; set; }
        public string UDF9 { get; set; }
        public string UDF10 { get; set; }
        public Nullable<decimal> PACK1 { get; set; }
        public Nullable<decimal> PACK2 { get; set; }
        public Nullable<decimal> PACK3 { get; set; }
        public Nullable<decimal> PACK4 { get; set; }
        public Nullable<decimal> PACK5 { get; set; }
        public Nullable<decimal> PACK6 { get; set; }
        public string PACK1_UNIT { get; set; }
        public string PACK2_UNIT { get; set; }
        public string PACK3_UNIT { get; set; }
        public string PACK4_UNIT { get; set; }
        public string PACK5_UNIT { get; set; }
        public string PACK6_UNIT { get; set; }
        public string INVENTORY_GUID { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string TS_VERSION { get; set; }
        public string RECEIVE_BATCH_DETAIL_GUID { get; set; }
        public string ORDER_PLT_NO { get; set; }
        public string ORDER_PACK_NO { get; set; }
        public Nullable<decimal> G_NO { get; set; }
        public string HSCODE { get; set; }
        public string HSNAME { get; set; }
        public string SB_UNIT { get; set; }
        public string ONE_UNIT { get; set; }
        public string TWO_UNIT { get; set; }
        public string CURRENCY_CODE { get; set; }
        public Nullable<decimal> TOTAL_GW { get; set; }
        public Nullable<decimal> TOTAL_NW { get; set; }
        public Nullable<decimal> TOTAL_VOLUME { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public Nullable<decimal> BATCH_LINE_NO { get; set; }
        public Nullable<decimal> PACK_MAX { get; set; }
        public string PACK_UNIT_MAX { get; set; }
        public string PACK_MEASURE { get; set; }
        public string PACK_NO { get; set; }
        public string TEMP { get; set; }
        public string SHIPPER_CODE { get; set; }
        public Nullable<decimal> RECIEVE_BATCH_LINE_NO { get; set; }
        public Nullable<System.DateTime> PUTAWAY_DATE { get; set; }
        public string PACK_STR { get; set; }
        public Nullable<System.DateTime> SHIP_DATE { get; set; }
        public string INV_ACCOUNT_CODE { get; set; }
        public string INV_PRICE_CODE { get; set; }
        public string EXE_MEMO { get; set; }
        public Nullable<System.DateTime> EXE_DATE { get; set; }
        public string EXE_ID { get; set; }
        public string GOODS_PACK_NO { get; set; }
        public string ORDER_GOODS_PACK_NO { get; set; }
        public string LOAD_FLAG { get; set; }
        public string DELIVERY_NO { get; set; }
        public string ORDER_PLT_UNIT { get; set; }
        public Nullable<decimal> RECEIVE_QTY { get; set; }
        public string EMS_NO { get; set; }
        public Nullable<decimal> YB_LINE_NO { get; set; }
        public string UNIQUE_CODE { get; set; }
        public string GET_CONTROL { get; set; }
        public Nullable<System.DateTime> CUSTOMER_SHIP_DATE { get; set; }
        public string SPEC { get; set; }
        public string MATERIAL { get; set; }
        public string PACKAGE_NO { get; set; }
        public string OWN_NO { get; set; }
        public string IS_CONTROL { get; set; }
        public string ORDER_PLT_SNUM { get; set; }
        public Nullable<System.DateTime> SM_RECHECK_DATE { get; set; }
        public string SM_RECHECK_USER { get; set; }
        public Nullable<System.DateTime> SM_XJ_DATE { get; set; }
        public string SM_XJ_USER { get; set; }
        public Nullable<decimal> ORDER_SJ_GW { get; set; }
        public Nullable<decimal> ORDER_SJ_NW { get; set; }
        public Nullable<decimal> ORDER_SJ_VOLUME { get; set; }
        public Nullable<decimal> ORDER_PLT_VOLUME { get; set; }
        public Nullable<decimal> ORDER_PLT_AREA { get; set; }
        public string ORDER_PLT_SIZE { get; set; }
        public Nullable<decimal> ORDER_PLT_GW { get; set; }
        public string IS_SPLIT { get; set; }
        public string ORDER_PACK_UNIT { get; set; }
        public string IS_SPLIT_PLT { get; set; }
        public string UDF11 { get; set; }
        public string UDF12 { get; set; }
        public string UDF13 { get; set; }
        public string UDF14 { get; set; }
        public string UDF15 { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
