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
    
    public partial class INVENTORY_SNAP_LOG
    {
        public string GUID { get; set; }
        public Nullable<System.DateTime> INV_DATE { get; set; }
        public string SUCCESS_FLAG { get; set; }
        public string PROCESS_FLAG { get; set; }
        public Nullable<System.DateTime> UPDATE_START_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_END_DATE { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CZ_PROCESS_FLAG { get; set; }
        public string CZ_SUCCESS_FLAG { get; set; }
        public string TRANSFER_FLAG { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}