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
    
    public partial class ORDER_VEHICLE
    {
        public string GUID { get; set; }
        public string ORDER_NO { get; set; }
        public string DELIVERY_COMPANY { get; set; }
        public string CAR_NO { get; set; }
        public string CAR_TYPE { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public string MEMO { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string DELIVERY_NO { get; set; }
        public string BOX_NO { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
