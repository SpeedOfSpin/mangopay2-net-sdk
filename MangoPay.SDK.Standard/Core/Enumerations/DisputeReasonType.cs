﻿
namespace MangoPay.SDK.Core.Enumerations
{
	public enum DisputeReasonType
	{
		/// <summary>Not specified.</summary>
		NotSpecified,

		DUPLICATE, 
		
		FRAUD, 
		
		PRODUCT_UNACCEPTABLE, 
		
		UNKNOWN, 
		
		OTHER, 
		
		REFUND_CONVERSION_RATE,
		
		LATE_FAILURE_INSUFFICIENT_FUNDS, 
		
		LATE_FAILURE_CONTACT_USER, 
		
		LATE_FAILURE_BANKACCOUNT_CLOSED, 
		
		LATE_FAILURE_BANKACCOUNT_INCOMPATIBLE, 
		
		LATE_FAILURE_BANKACCOUNT_INCORRECT,
		
		AUTHORISATION_DISPUTED,

		TRANSACTION_NOT_RECOGNIZED,

		PRODUCT_NOT_PROVIDED,

		CANCELED_REOCCURING_TRANSACTION,

		REFUND_NOT_PROCESSED
	}
}
