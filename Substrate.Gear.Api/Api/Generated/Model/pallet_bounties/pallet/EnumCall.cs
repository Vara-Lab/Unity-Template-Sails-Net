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


namespace Substrate.Gear.Api.Generated.Model.pallet_bounties.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> propose_bounty
        /// Propose a new bounty.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Payment: `TipReportDepositBase` will be reserved from the origin account, as well as
        /// `DataDepositPerByte` for each byte in `reason`. It will be unreserved upon approval,
        /// or slashed when rejected.
        /// 
        /// - `curator`: The curator account whom will manage this bounty.
        /// - `fee`: The curator fee.
        /// - `value`: The total payment amount of this bounty, curator fee included.
        /// - `description`: The description of this bounty.
        /// </summary>
        propose_bounty = 0,
        
        /// <summary>
        /// >> approve_bounty
        /// Approve a bounty proposal. At a later time, the bounty will be funded and become active
        /// and the original deposit will be returned.
        /// 
        /// May only be called from `T::SpendOrigin`.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        approve_bounty = 1,
        
        /// <summary>
        /// >> propose_curator
        /// Propose a curator to a funded bounty.
        /// 
        /// May only be called from `T::SpendOrigin`.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        propose_curator = 2,
        
        /// <summary>
        /// >> unassign_curator
        /// Unassign curator from a bounty.
        /// 
        /// This function can only be called by the `RejectOrigin` a signed origin.
        /// 
        /// If this function is called by the `RejectOrigin`, we assume that the curator is
        /// malicious or inactive. As a result, we will slash the curator when possible.
        /// 
        /// If the origin is the curator, we take this as a sign they are unable to do their job and
        /// they willingly give up. We could slash them, but for now we allow them to recover their
        /// deposit and exit without issue. (We may want to change this if it is abused.)
        /// 
        /// Finally, the origin can be anyone if and only if the curator is "inactive". This allows
        /// anyone in the community to call out that a curator is not doing their due diligence, and
        /// we should pick a new curator. In this case the curator should also be slashed.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        unassign_curator = 3,
        
        /// <summary>
        /// >> accept_curator
        /// Accept the curator role for a bounty.
        /// A deposit will be reserved from curator and refund upon successful payout.
        /// 
        /// May only be called from the curator.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        accept_curator = 4,
        
        /// <summary>
        /// >> award_bounty
        /// Award bounty to a beneficiary account. The beneficiary will be able to claim the funds
        /// after a delay.
        /// 
        /// The dispatch origin for this call must be the curator of this bounty.
        /// 
        /// - `bounty_id`: Bounty ID to award.
        /// - `beneficiary`: The beneficiary account whom will receive the payout.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        award_bounty = 5,
        
        /// <summary>
        /// >> claim_bounty
        /// Claim the payout from an awarded bounty after payout delay.
        /// 
        /// The dispatch origin for this call must be the beneficiary of this bounty.
        /// 
        /// - `bounty_id`: Bounty ID to claim.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        claim_bounty = 6,
        
        /// <summary>
        /// >> close_bounty
        /// Cancel a proposed or active bounty. All the funds will be sent to treasury and
        /// the curator deposit will be unreserved if possible.
        /// 
        /// Only `T::RejectOrigin` is able to cancel a bounty.
        /// 
        /// - `bounty_id`: Bounty ID to cancel.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        close_bounty = 7,
        
        /// <summary>
        /// >> extend_bounty_expiry
        /// Extend the expiry time of an active bounty.
        /// 
        /// The dispatch origin for this call must be the curator of this bounty.
        /// 
        /// - `bounty_id`: Bounty ID to extend.
        /// - `remark`: additional information.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        extend_bounty_expiry = 8,
    }
    
    /// <summary>
    /// >> 255 - Variant[pallet_bounties.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>(Call.propose_bounty);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.approve_bounty);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.propose_curator);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.unassign_curator);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.accept_curator);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.award_bounty);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.claim_bounty);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.close_bounty);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>(Call.extend_bounty_expiry);
        }
    }
}
