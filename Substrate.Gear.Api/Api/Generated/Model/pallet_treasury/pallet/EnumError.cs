#nullable disable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.pallet_treasury.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// Error for the treasury pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InvalidIndex
        /// No proposal, bounty or spend at that index.
        /// </summary>
        InvalidIndex = 0,
        
        /// <summary>
        /// >> TooManyApprovals
        /// Too many approvals in the queue.
        /// </summary>
        TooManyApprovals = 1,
        
        /// <summary>
        /// >> InsufficientPermission
        /// The spend origin is valid but the amount it is allowed to spend is lower than the
        /// amount to be spent.
        /// </summary>
        InsufficientPermission = 2,
        
        /// <summary>
        /// >> ProposalNotApproved
        /// Proposal has not been approved.
        /// </summary>
        ProposalNotApproved = 3,
        
        /// <summary>
        /// >> FailedToConvertBalance
        /// The balance of the asset kind is not convertible to the balance of the native asset.
        /// </summary>
        FailedToConvertBalance = 4,
        
        /// <summary>
        /// >> SpendExpired
        /// The spend has expired and cannot be claimed.
        /// </summary>
        SpendExpired = 5,
        
        /// <summary>
        /// >> EarlyPayout
        /// The spend is not yet eligible for payout.
        /// </summary>
        EarlyPayout = 6,
        
        /// <summary>
        /// >> AlreadyAttempted
        /// The payment has already been attempted.
        /// </summary>
        AlreadyAttempted = 7,
        
        /// <summary>
        /// >> PayoutError
        /// There was some issue with the mechanism of payment.
        /// </summary>
        PayoutError = 8,
        
        /// <summary>
        /// >> NotAttempted
        /// The payout was not yet attempted/claimed.
        /// </summary>
        NotAttempted = 9,
        
        /// <summary>
        /// >> Inconclusive
        /// The payment has neither failed nor succeeded yet.
        /// </summary>
        Inconclusive = 10,
    }
    
    /// <summary>
    /// >> 444 - Variant[pallet_treasury.pallet.Error]
    /// Error for the treasury pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
