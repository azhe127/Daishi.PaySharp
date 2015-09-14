namespace Daishi.PaySharp {
    /// <summary>Represents PayPal customer details returned by
    ///     <c>GetExpressCheckoutDetails</c>.</summary>
    public class CustomerDetails {
        public string AccessToken { get; set; }
        public string BillingAgreementAcceptedStatus { get; set; }
        public string CheckoutStatus { get; set; }
        public string TimeStamp { get; set; }
        public string CorrelationID { get; set; }
        public string Ack { get; set; }
        public string Version { get; set; }
        public string Build { get; set; }
        public string Email { get; set; }
        public string PayerID { get; set; }
        public string PayerStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryCode { get; set; }
        public string BillingName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }
        public string AddressID { get; set; }
        public string AddressStatus { get; set; }
        public string CurrencyCode { get; set; }
        public string Amt { get; set; }
        public string ItemAmt { get; set; }
        public string ShippingAmt { get; set; }
        public string HandlingAmt { get; set; }
        public string TaxAmt { get; set; }
        public string InsuranceAmt { get; set; }
        public string ShipDiscAmt { get; set; }
        public string LName { get; set; }
        public string LQuantity { get; set; }
        public string LTaxAmt { get; set; }
        public string LAmt { get; set; }
        public string LDescription { get; set; }
        public string LItemWeightValue { get; set; }
        public string LItemLengthValue { get; set; }
        public string LItemWidthValue { get; set; }
        public string LItemHeightValue { get; set; }
        public string PaymentRequestCurrencyCode { get; set; }
        public string PaymentRequestAmt { get; set; }
        public string PaymentRequestItemAmt { get; set; }
        public string PaymentRequestShippingAmt { get; set; }
        public string PaymentRequestHandlingAmt { get; set; }
        public string PaymentRequestTaxAmt { get; set; }
        public string PaymentRequestInsuranceAmt { get; set; }
        public string PaymentRequestShipDiscAmt { get; set; }
        public string PaymentRequestTransactionID { get; set; }
        public string PaymentRequestInsuranceOptionOffered { get; set; }
        public string PaymentRequestAddressNormalisationStatus { get; set; }
        public string LPaymentRequestName { get; set; }
        public string LPaymentRequestQuantity { get; set; }
        public string LPaymentRequestTaxAmt { get; set; }
        public string LPaymentRequestAmt { get; set; }
        public string LPaymentRequestDescription { get; set; }
        public string LPaymentRequestItemWeightValue { get; set; }
        public string LPaymentRequestItemLengthValue { get; set; }
        public string LPaymentRequestItemWidthValue { get; set; }
        public string LPaymentRequestItemHeightValue { get; set; }
        public string PaymentRequestInfoTransactionID { get; set; }
        public string PaymentRequestInfoErrorCode { get; set; }

        #region Sandbox-only properties

        public string PaymentRequestShipToName { get; set; }
        public string PaymentRequestShipToStreet { get; set; }
        public string PaymentRequestShipToCity { get; set; }
        public string PaymentRequestShipToState { get; set; }
        public string PaymentRequestShipToZip { get; set; }
        public string PaymentRequestShipToCountryCode { get; set; }
        public string PaymentRequestShipToCountryName { get; set; }
        public string ShipToName { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountryCode { get; set; }
        public string ShipToCountryName { get; set; }

        #endregion
    }
}