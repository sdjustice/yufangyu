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
    
    public partial class PRODUCT_LOTTABLE_CUT
    {
        public string GUID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string SKU { get; set; }
        public string PRODUCT_GUID { get; set; }
        public string LOTCODE_FROM { get; set; }
        public string LOTCODE_TO { get; set; }
        public string CREATE_USER { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public string SPLIT_PARAM { get; set; }
        public Nullable<decimal> START_NUM { get; set; }
        public Nullable<decimal> FIELD_LENGTH { get; set; }
        public string FIELD_FORMAT { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
