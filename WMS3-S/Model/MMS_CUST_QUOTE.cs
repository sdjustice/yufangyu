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
    
    public partial class MMS_CUST_QUOTE
    {
        public string PRICE_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public Nullable<System.DateTime> BEGIN_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string MEMO { get; set; }
        public string CREATE_USER { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public Nullable<System.DateTime> SEND_DATE { get; set; }
        public Nullable<System.DateTime> AUDIT_DATE { get; set; }
        public string OP_TYPE { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string STATUS { get; set; }
        public string AUDIT_USER { get; set; }
        public string SEND_USER { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
