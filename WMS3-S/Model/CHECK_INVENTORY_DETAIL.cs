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
    
    public partial class CHECK_INVENTORY_DETAIL
    {
        public string GUID { get; set; }
        public string CHECK_NO { get; set; }
        public string WH_CODE { get; set; }
        public string GROUP_NO { get; set; }
        public string ZONE_CODE { get; set; }
        public string AREA_CODE { get; set; }
        public string LOC_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string SKU { get; set; }
        public string CONSIGNEE_CODE { get; set; }
        public string CONSIGNEE_SKU { get; set; }
        public string NOTIFY_CODE { get; set; }
        public string NOTIFY_SKU { get; set; }
        public string LOT_NO { get; set; }
        public string INV_NO { get; set; }
        public Nullable<System.DateTime> DATECODE { get; set; }
        public string PLT_NO { get; set; }
        public string DAMAGE_FLAG { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public Nullable<decimal> FIRST_QTY { get; set; }
        public Nullable<decimal> FIRST_DIF { get; set; }
        public Nullable<decimal> SECOND_QTY { get; set; }
        public Nullable<decimal> SECOND_DIF { get; set; }
        public string MEMO { get; set; }
        public Nullable<decimal> LINE_NO { get; set; }
        public string PACK_NO { get; set; }
        public string PACK_STR { get; set; }
        public string SHIPPER_CODE { get; set; }
        public string HSCODE { get; set; }
        public string HSNAME { get; set; }
        public string SB_UNIT { get; set; }
        public string DIF_REASON { get; set; }
        public string DIF_ENTRY_USER { get; set; }
        public Nullable<System.DateTime> DIF_ENTRY_DATE { get; set; }
        public string INVENTORY_GUID { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
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
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string EMS_NO { get; set; }
        public Nullable<decimal> G_NO { get; set; }
        public string F_RFID { get; set; }
        public string S_RFID { get; set; }
        public string E_RFID { get; set; }
        public string GOODS_PACK_NO { get; set; }
        public Nullable<System.DateTime> SM_RECHECK_DATE { get; set; }
        public string SM_RECHECK_USER { get; set; }
        public Nullable<System.DateTime> SM_F_DATE { get; set; }
        public string SM_F_USER { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
