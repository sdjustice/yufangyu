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
    
    public partial class WORK_ORDER
    {
        public string GUID { get; set; }
        public string WORK_NO { get; set; }
        public string WH_CODE { get; set; }
        public string STATUS { get; set; }
        public string BUSINESS_TYPE { get; set; }
        public Nullable<System.DateTime> CONFIRM_DATE { get; set; }
        public string CONSIGNOR_CODE { get; set; }
        public string BILLING_OBJ { get; set; }
        public string JOB_USER { get; set; }
        public string REWORK_COMPANY { get; set; }
        public string LOCKING_REASON { get; set; }
        public string WORK_EXPLAIN { get; set; }
        public string WORK_REASON { get; set; }
        public string WORK_STATUS { get; set; }
        public string MEMO { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string TS_VERSION { get; set; }
        public string BILLING_AP { get; set; }
        public string CUSTOMER_JOB_NO { get; set; }
        public string BALANCE_MEMO { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}