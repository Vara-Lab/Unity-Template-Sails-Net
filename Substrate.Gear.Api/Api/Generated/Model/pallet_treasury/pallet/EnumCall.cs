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
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> spend_local
        /// Propose and approve a spend of treasury funds.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be [`Config::SpendOrigin`] with the `Success` value being at least `amount`.
        /// 
        /// ### Details
        /// NOTE: For record-keeping purposes, the proposer is deemed to be equivalent to the
        /// beneficiary.
        /// 
        /// ### Parameters
        /// - `amount`: The amount to be transferred from the treasury to the `beneficiary`.
        /// - `beneficiary`: The destination account for the transfer.
        /// 
        /// ## Events
        /// 
        /// Emits [`Event::SpendApproved`] if successful.
        /// </summary>
        spend_local = 3,
        
        /// <summary>
        /// >> remove_approval
        /// Force a previously approved proposal to be removed from the approval queue.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be [`Config::RejectOrigin`].
        /// 
        /// ## Details
        /// 
        /// The original deposit will no longer be returned.
        /// 
        /// ### Parameters
        /// - `proposal_id`: The index of a proposal
        /// 
        /// ### Complexity
        /// - O(A) where `A` is the number of approvals
        /// 
        /// ### Errors
        /// - [`Error::ProposalNotApproved`]: The `proposal_id` supplied was not found in the
        ///   approval queue, i.e., the proposal has not been approved. This could also mean the
        ///   proposal does not exist altogether, thus there is no way it would have been approved
        ///   in the first place.
        /// </summary>
        remove_approval = 4,
        
        /// <summary>
        /// >> spend
        /// Propose and approve a spend of treasury funds.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be [`Config::SpendOrigin`] with the `Success` value being at least
        /// `amount` of `asset_kind` in the native asset. The amount of `asset_kind` is converted
        /// for assertion using the [`Config::BalanceConverter`].
        /// 
        /// ## Details
        /// 
        /// Create an approved spend for transferring a specific `amount` of `asset_kind` to a
        /// designated beneficiary. The spend must be claimed using the `payout` dispatchable within
        /// the [`Config::PayoutPeriod`].
        /// 
        /// ### Parameters
        /// - `asset_kind`: An indicator of the specific asset class to be spent.
        /// - `amount`: The amount to be transferred from the treasury to the `beneficiary`.
        /// - `beneficiary`: The beneficiary of the spend.
        /// - `valid_from`: The block number from which the spend can be claimed. It can refer to
        ///   the past if the resulting spend has not yet expired according to the
        ///   [`Config::PayoutPeriod`]. If `None`, the spend can be claimed immediately after
        ///   approval.
        /// 
        /// ## Events
        /// 
        /// Emits [`Event::AssetSpendApproved`] if successful.
        /// </summary>
        spend = 5,
        
        /// <summary>
        /// >> payout
        /// Claim a spend.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be signed
        /// 
        /// ## Details
        /// 
        /// Spends must be claimed within some temporal bounds. A spend may be claimed within one
        /// [`Config::PayoutPeriod`] from the `valid_from` block.
        /// In case of a payout failure, the spend status must be updated with the `check_status`
        /// dispatchable before retrying with the current function.
        /// 
        /// ### Parameters
        /// - `index`: The spend index.
        /// 
        /// ## Events
        /// 
        /// Emits [`Event::Paid`] if successful.
        /// </summary>
        payout = 6,
        
        /// <summary>
        /// >> check_status
        /// Check the status of the spend and remove it from the storage if processed.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be signed.
        /// 
        /// ## Details
        /// 
        /// The status check is a prerequisite for retrying a failed payout.
        /// If a spend has either succeeded or expired, it is removed from the storage by this
        /// function. In such instances, transaction fees are refunded.
        /// 
        /// ### Parameters
        /// - `index`: The spend index.
        /// 
        /// ## Events
        /// 
        /// Emits [`Event::PaymentFailed`] if the spend payout has failed.
        /// Emits [`Event::SpendProcessed`] if the spend payout has succeed.
        /// </summary>
        check_status = 7,
        
        /// <summary>
        /// >> void_spend
        /// Void previously approved spend.
        /// 
        /// ## Dispatch Origin
        /// 
        /// Must be [`Config::RejectOrigin`].
        /// 
        /// ## Details
        /// 
        /// A spend void is only possible if the payout has not been attempted yet.
        /// 
        /// ### Parameters
        /// - `index`: The spend index.
        /// 
        /// ## Events
        /// 
        /// Emits [`Event::AssetSpendVoided`] if successful.
        /// </summary>
        void_spend = 8,
    }
    
    /// <summary>
    /// >> 128 - Variant[pallet_treasury.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.spend_local);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.remove_approval);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseTuple, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.spend);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.payout);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.check_status);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.void_spend);
        }
    }
}
