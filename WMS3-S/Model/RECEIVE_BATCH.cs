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
    
    public partial class RECEIVE_BATCH
    {
        public string GUID { get; set; }
        public string RECEIVE_NO { get; set; }
        public string RECEIVE_BATCH_NO { get; set; }
        public string WH_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> RECEIVED_DATE { get; set; }
        public Nullable<System.DateTime> CHECK_DATE { get; set; }
        public Nullable<System.DateTime> PUTAWAY_DATE { get; set; }
        public Nullable<decimal> TOTAL_PIECE { get; set; }
        public Nullable<decimal> TOTAL_GW { get; set; }
        public Nullable<decimal> TOTAL_NW { get; set; }
        public Nullable<decimal> TOTAL_CTN { get; set; }
        public Nullable<decimal> TOTAL_PLT { get; set; }
        public Nullable<decimal> TOTAL_VOLUME { get; set; }
        public string CHECK_USER { get; set; }
        public string RECEIVE_USER { get; set; }
        public string CHECK_REMARK { get; set; }
        public string MEMO { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string CHECK_STATUS { get; set; }
        public string TS_VERSION { get; set; }
        public string BILLING_OBJ { get; set; }
        public string EMS_NO { get; set; }
        public string NEED_CHECK { get; set; }
        public string PIECES_UNIT { get; set; }
        public string SHIPPER_CODE { get; set; }
        public string INVALID_USER { get; set; }
        public Nullable<System.DateTime> INVALID_DATE { get; set; }
        public string INVALID_MEMO { get; set; }
        public string PUTAWAY_REQUEST { get; set; }
        public string CHECK_REQUEST { get; set; }
        public string RF_STATUS { get; set; }
        public string WH_TYPE { get; set; }
        public Nullable<System.DateTime> RECHECK_DATE { get; set; }
        public Nullable<System.DateTime> EX_RECEIVED_DATE { get; set; }
        public string ABNORMAL { get; set; }
        public Nullable<decimal> NUMBER1 { get; set; }
        public string UNIT1 { get; set; }
        public Nullable<decimal> NUMBER2 { get; set; }
        public string UNIT2 { get; set; }
        public Nullable<decimal> NUMBER3 { get; set; }
        public string UNIT3 { get; set; }
        public string PIECES_UNIT_NEW { get; set; }
        public string STORE_USER { get; set; }
        public string VOYAGE { get; set; }
        public string WH_WHARF { get; set; }
        public string DELIVERY_DRIVER { get; set; }
        public string BOX_NO { get; set; }
        public string ORDER_NO { get; set; }
        public string DELIVERY_COMPANY { get; set; }
        public string IS_ZS { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}