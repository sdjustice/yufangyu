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
    
    public partial class MMS_CONDITION
    {
        public string GUID { get; set; }
        public string CONN_GUID { get; set; }
        public string ELEMENT_CODE { get; set; }
        public string SET_VALUE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<decimal> BEGIN_DATA { get; set; }
        public Nullable<decimal> END_DATA { get; set; }
        public string BEGIN_FLAG { get; set; }
        public string END_FLAG { get; set; }
    }
}