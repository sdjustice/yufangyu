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
    
    public partial class SSO_NODE
    {
        public string NODEID { get; set; }
        public string CODE { get; set; }
        public string FULLNAME { get; set; }
        public string SHORTNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string PARENTID { get; set; }
        public string COMPANYID { get; set; }
        public Nullable<decimal> STATUS { get; set; }
        public Nullable<decimal> TYPE { get; set; }
        public string CREATEUSER { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string LASTMODIFYUSER { get; set; }
        public Nullable<System.DateTime> LASTMODIFYTIME { get; set; }
    }
}
