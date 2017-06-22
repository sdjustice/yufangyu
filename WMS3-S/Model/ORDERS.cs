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
    
    public partial class ORDERS
    {
        public string GUID { get; set; }
        public string ORDER_NO { get; set; }
        public string WH_CODE { get; set; }
        public string STATUS { get; set; }
        public string BUSINESS_TYPE { get; set; }
        public string DAMAGE_FLAG { get; set; }
        public Nullable<decimal> URGENT { get; set; }
        public string DOC_SOURCE { get; set; }
        public string CONSIGNOR_DOC_NO { get; set; }
        public string CUSTOMER_REF_NO { get; set; }
        public string WH_REF_NO { get; set; }
        public string SYS_REF_NO1 { get; set; }
        public string SYS_REF_NO2 { get; set; }
        public string EXTERNAL_NO1 { get; set; }
        public string EXTERNAL_NO2 { get; set; }
        public string EXTERNAL_KEY { get; set; }
        public string BILLING_OBJ { get; set; }
        public Nullable<System.DateTime> REQUEST_SHIP_DATE { get; set; }
        public Nullable<System.DateTime> ORDER_DATE { get; set; }
        public Nullable<System.DateTime> ASSIGN_DATE { get; set; }
        public Nullable<System.DateTime> PICK_DATE { get; set; }
        public Nullable<System.DateTime> RELEASE_DATE { get; set; }
        public Nullable<System.DateTime> CLOSE_DATE { get; set; }
        public string PICK_EXPLAIN { get; set; }
        public Nullable<System.DateTime> INVALID_DATE { get; set; }
        public string DELIVERY_PLAN { get; set; }
        public string MARKS { get; set; }
        public string MEMO { get; set; }
        public string DECLARE_NO { get; set; }
        public string ADVANCE_INPUT_DATE { get; set; }
        public string CUSTOMS_COMPANY { get; set; }
        public Nullable<System.DateTime> CUSTOMS_DATE { get; set; }
        public Nullable<System.DateTime> CUSTOMS_LEAVE_DATE { get; set; }
        public string CUSTOMS_JOB_NO { get; set; }
        public string CUSTOMS_REGION { get; set; }
        public string MBL_NO { get; set; }
        public string HBL_NO { get; set; }
        public string BL_NO { get; set; }
        public string JOB_NO { get; set; }
        public string TARIFF_NO { get; set; }
        public string CUSTOMS_DESC { get; set; }
        public string DELIVERY_NO { get; set; }
        public string DELIVERY_COMPANY { get; set; }
        public string DELIVERY_MODE { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public string CAR_NO { get; set; }
        public string PERSON { get; set; }
        public string TEL { get; set; }
        public Nullable<decimal> CAR_NUM { get; set; }
        public string DELIVERY_REF_NO { get; set; }
        public string DELIVERY_TYPE { get; set; }
        public string DELIVERY_CONTRACT { get; set; }
        public string CONTAINER_NO { get; set; }
        public Nullable<System.DateTime> ETD_DATE { get; set; }
        public Nullable<System.DateTime> ETA_DATE { get; set; }
        public string DELIVERY_ADDRESS1 { get; set; }
        public string DELIVERY_ADDRESS2 { get; set; }
        public string DELIVERY_EXPLAIN { get; set; }
        public Nullable<decimal> EXPECTED_PIECES { get; set; }
        public string PIECES_UNIT { get; set; }
        public Nullable<decimal> EXPECTED_AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public Nullable<decimal> EXPECTED_GW { get; set; }
        public Nullable<decimal> EXPECTED_NW { get; set; }
        public Nullable<int> WEIGHT_UNIT { get; set; }
        public Nullable<decimal> EXPECTED_VOLUME { get; set; }
        public string VOLUME_UNIT { get; set; }
        public Nullable<decimal> EXPECTED_CTN { get; set; }
        public Nullable<decimal> EXPECTED_PLT { get; set; }
        public string CREATE_USER { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CONSIGNEE_CODE { get; set; }
        public short MAX_BATCH_NO { get; set; }
        public string TS_VERSION { get; set; }
        public Nullable<System.DateTime> ORDER_CONFIRM_DATE { get; set; }
        public string MEMBER_NO { get; set; }
        public string POST_CODE { get; set; }
        public string HDFK { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<decimal> AMOUNT_ZK { get; set; }
        public string NEED_INVOICE { get; set; }
        public string INVOICE_MEMO { get; set; }
        public string EMS_NO { get; set; }
        public string BG_MODE { get; set; }
        public string ORDER_INVOICE { get; set; }
        public string DEC_OP_NO { get; set; }
        public Nullable<decimal> CC_DEC_PIAO { get; set; }
        public Nullable<decimal> CC_DEC_ZHANG { get; set; }
        public Nullable<decimal> QY_DEC_PIAO { get; set; }
        public Nullable<decimal> QY_DEC_ZHANG { get; set; }
        public Nullable<decimal> RETURN_QTY { get; set; }
        public Nullable<decimal> DELETE_QTY { get; set; }
        public Nullable<decimal> CHANGE_QTY { get; set; }
        public string INV_ACCOUNT_TYPE { get; set; }
        public string INVALID_USER { get; set; }
        public string INVALID_MEMO { get; set; }
        public string INV_ACCOUNT_CODE_QIQO { get; set; }
        public string INV_ACCOUNT_PRICE_QIQO { get; set; }
        public string OP_BG_MODEL { get; set; }
        public string IS_BJ { get; set; }
        public string IS_FJ { get; set; }
        public string WH_TYPE { get; set; }
        public Nullable<System.DateTime> CLOCASE_DATE { get; set; }
        public string CLOCASE_USER { get; set; }
        public string CAR_TYPE1 { get; set; }
        public Nullable<short> CAR_NUMBER1 { get; set; }
        public string CAR_TYPE2 { get; set; }
        public Nullable<short> CAR_NUMBER2 { get; set; }
        public string CAR_TYPE3 { get; set; }
        public Nullable<short> CAR_NUMBER3 { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string UDF6 { get; set; }
        public string BALANCE_MEMO { get; set; }
        public Nullable<System.DateTime> RECHECK_DATE { get; set; }
        public Nullable<System.DateTime> OUT_DATE { get; set; }
        public string INCOTERMS { get; set; }
        public string HFD_NO { get; set; }
        public string BRAGAINON_ARTICLE { get; set; }
        public string END_PORT { get; set; }
        public string END_COUNTRY { get; set; }
        public string CONTRACT_NO { get; set; }
        public Nullable<System.DateTime> QY_RETURN_DATA { get; set; }
        public Nullable<System.DateTime> QY_RETURN_CUSTOMER_DATA { get; set; }
        public string OP_DECLARE_NO { get; set; }
        public string BSK_NO { get; set; }
        public string BSK_APP_STATUS { get; set; }
        public string BSK_WAY { get; set; }
        public Nullable<decimal> USD_RATE { get; set; }
        public string INCOTERM_TYPE { get; set; }
        public Nullable<decimal> ZZ_RATE { get; set; }
        public Nullable<System.DateTime> BSK_SX_DATE { get; set; }
        public string IS_BANKING { get; set; }
        public string BILLING_TYPE { get; set; }
        public string IS_XCCJ { get; set; }
        public string CUSTOMER_EMS_NO { get; set; }
        public string CUSTOMER_SYS { get; set; }
        public Nullable<System.DateTime> BACK_DATE { get; set; }
        public string BACK_REASON { get; set; }
        public string BACK_BEFORE_STATUS { get; set; }
        public Nullable<decimal> BACK_SETTLE_QTY { get; set; }
        public string BACK_MEMO { get; set; }
        public Nullable<System.DateTime> BACK_TZ_DATE { get; set; }
        public string BACK_USER { get; set; }
        public string DELIVERY_PAY_TYPE { get; set; }
        public Nullable<decimal> DELIVERY_FEE { get; set; }
        public string DELIVERY_COM { get; set; }
        public string DELIVERY_POSTCODE { get; set; }
        public string DELIVERY_ADDR1 { get; set; }
        public string DELIVERY_ADDR2 { get; set; }
        public string DELIVERY_ADDR3 { get; set; }
        public string IS_LOCK { get; set; }
        public string MDPRICE_FLAG { get; set; }
        public string EXP_PERSON { get; set; }
        public string EXP_TEL { get; set; }
        public string EXP_ADDRESS { get; set; }
        public string IS_BS { get; set; }
        public string QY_INCOTERMS { get; set; }
        public string OP_NUCLEAR_NO { get; set; }
        public string NUCLEAR_NO { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
    }
}
