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
    
    public partial class CHECK_INVENTORY
    {
        public string GUID { get; set; }
        public string CHECK_NO { get; set; }
        public string WH_CODE { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> CHECK_DATE { get; set; }
        public Nullable<int> GROUP_NUM { get; set; }
        public string REMARK { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<System.DateTime> C_CHECK_DATE { get; set; }
        public string C_CHECK_USER { get; set; }
        public Nullable<System.DateTime> F_CHECK_DATE { get; set; }
        public string F_CHECK_USER { get; set; }
        public Nullable<System.DateTime> CLOSE_DATE { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}