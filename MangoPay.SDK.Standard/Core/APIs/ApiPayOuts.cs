﻿using MangoPay.SDK.Core.Enumerations;
using MangoPay.SDK.Entities.GET;
using MangoPay.SDK.Entities.POST;
using System;

namespace MangoPay.SDK.Core.APIs
{
    /// <summary>API for pay-outs.</summary>
    public class ApiPayOuts : ApiBase
    {
        /// <summary>Instantiates new ApiPayOuts object.</summary>
        /// <param name="root">Root/parent instance that holds the OAuthToken and Configuration instance.</param>
        public ApiPayOuts(MangoPayApi root) : base(root) { }

        /// <summary>Creates new PayOut object.</summary>
        /// <param name="payOut">The PayOut object to be created.</param>
        /// <returns>Created PayOut object returned from API.</returns>
        public PayOutBankWireDTO CreateBankWire(PayOutBankWirePostDTO payOut)
        {
            return CreateBankWire(null, payOut);
        }

		/// <summary>Creates new PayOut object.</summary>
		/// <param name="idempotencyKey">Idempotency key for this request.</param>
		/// <param name="payOut">The PayOut object to be created.</param>
		/// <returns>Created PayOut object returned from API.</returns>
		public PayOutBankWireDTO CreateBankWire(String idempotencyKey, PayOutBankWirePostDTO payOut)
		{
			return this.CreateObject<PayOutBankWireDTO, PayOutBankWirePostDTO>(idempotencyKey, MethodKey.PayoutsBankwireCreate, payOut);
		}

        /// <summary>Gets PayOut entity by its identifier.</summary>
        /// <param name="payOutId">PayOut identifier.</param>
        /// <returns>PayOut instance returned from API.</returns>
        public PayOutDTO Get(String payOutId)
        {
            return this.GetObject<PayOutDTO>(MethodKey.PayoutsGet, payOutId);
        }

        /// <summary>Gets PayOut entity by its identifier.</summary>
        /// <param name="payOutId">PayOutBankWire identifier.</param>
        /// <returns>PayOutBankWire instance returned from API.</returns>
        public PayOutBankWireDTO GetBankWire(String payOutId)
        {
            return this.GetObject<PayOutBankWireDTO>(MethodKey.PayoutsGet, payOutId);
        }
    }
}
