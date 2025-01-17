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


namespace Substrate.Gear.Api.Generated.Model.pallet_referenda.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> submit
        /// Propose a referendum on a privileged action.
        /// 
        /// - `origin`: must be `SubmitOrigin` and the account must have `SubmissionDeposit` funds
        ///   available.
        /// - `proposal_origin`: The origin from which the proposal should be executed.
        /// - `proposal`: The proposal.
        /// - `enactment_moment`: The moment that the proposal should be enacted.
        /// 
        /// Emits `Submitted`.
        /// </summary>
        submit = 0,
        
        /// <summary>
        /// >> place_decision_deposit
        /// Post the Decision Deposit for a referendum.
        /// 
        /// - `origin`: must be `Signed` and the account must have funds available for the
        ///   referendum's track's Decision Deposit.
        /// - `index`: The index of the submitted referendum whose Decision Deposit is yet to be
        ///   posted.
        /// 
        /// Emits `DecisionDepositPlaced`.
        /// </summary>
        place_decision_deposit = 1,
        
        /// <summary>
        /// >> refund_decision_deposit
        /// Refund the Decision Deposit for a closed referendum back to the depositor.
        /// 
        /// - `origin`: must be `Signed` or `Root`.
        /// - `index`: The index of a closed referendum whose Decision Deposit has not yet been
        ///   refunded.
        /// 
        /// Emits `DecisionDepositRefunded`.
        /// </summary>
        refund_decision_deposit = 2,
        
        /// <summary>
        /// >> cancel
        /// Cancel an ongoing referendum.
        /// 
        /// - `origin`: must be the `CancelOrigin`.
        /// - `index`: The index of the referendum to be cancelled.
        /// 
        /// Emits `Cancelled`.
        /// </summary>
        cancel = 3,
        
        /// <summary>
        /// >> kill
        /// Cancel an ongoing referendum and slash the deposits.
        /// 
        /// - `origin`: must be the `KillOrigin`.
        /// - `index`: The index of the referendum to be cancelled.
        /// 
        /// Emits `Killed` and `DepositSlashed`.
        /// </summary>
        kill = 4,
        
        /// <summary>
        /// >> nudge_referendum
        /// Advance a referendum onto its next logical state. Only used internally.
        /// 
        /// - `origin`: must be `Root`.
        /// - `index`: the referendum to be advanced.
        /// </summary>
        nudge_referendum = 5,
        
        /// <summary>
        /// >> one_fewer_deciding
        /// Advance a track onto its next logical state. Only used internally.
        /// 
        /// - `origin`: must be `Root`.
        /// - `track`: the track to be advanced.
        /// 
        /// Action item for when there is now one fewer referendum in the deciding phase and the
        /// `DecidingCount` is not yet updated. This means that we should either:
        /// - begin deciding another referendum (and leave `DecidingCount` alone); or
        /// - decrement `DecidingCount`.
        /// </summary>
        one_fewer_deciding = 6,
        
        /// <summary>
        /// >> refund_submission_deposit
        /// Refund the Submission Deposit for a closed referendum back to the depositor.
        /// 
        /// - `origin`: must be `Signed` or `Root`.
        /// - `index`: The index of a closed referendum whose Submission Deposit has not yet been
        ///   refunded.
        /// 
        /// Emits `SubmissionDepositRefunded`.
        /// </summary>
        refund_submission_deposit = 7,
        
        /// <summary>
        /// >> set_metadata
        /// Set or clear metadata of a referendum.
        /// 
        /// Parameters:
        /// - `origin`: Must be `Signed` by a creator of a referendum or by anyone to clear a
        ///   metadata of a finished referendum.
        /// - `index`:  The index of a referendum to set or clear metadata for.
        /// - `maybe_hash`: The hash of an on-chain stored preimage. `None` to clear a metadata.
        /// </summary>
        set_metadata = 8,
    }
    
    /// <summary>
    /// >> 137 - Variant[pallet_referenda.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.vara_runtime.EnumOriginCaller, Substrate.Gear.Api.Generated.Model.frame_support.traits.preimages.EnumBounded, Substrate.Gear.Api.Generated.Model.frame_support.traits.schedule.EnumDispatchTime>>(Call.submit);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.place_decision_deposit);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.refund_decision_deposit);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.cancel);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.kill);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.nudge_referendum);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U16>(Call.one_fewer_deciding);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.refund_submission_deposit);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.primitive_types.H256>>>(Call.set_metadata);
        }
    }
}
