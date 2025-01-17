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


namespace Substrate.Gear.Api.Generated.Model.pallet_preimage
{
    
    
    /// <summary>
    /// >> RequestStatus
    /// </summary>
    public enum RequestStatus
    {
        
        /// <summary>
        /// >> Unrequested
        /// </summary>
        Unrequested = 0,
        
        /// <summary>
        /// >> Requested
        /// </summary>
        Requested = 1,
    }
    
    /// <summary>
    /// >> 495 - Variant[pallet_preimage.RequestStatus]
    /// </summary>
    public sealed class EnumRequestStatus : BaseEnumRust<RequestStatus>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRequestStatus()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.Gear.Api.Generated.Model.frame_support.traits.tokens.fungible.HoldConsideration>, Substrate.NetApi.Model.Types.Primitive.U32>>(RequestStatus.Unrequested);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.Gear.Api.Generated.Model.frame_support.traits.tokens.fungible.HoldConsideration>>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(RequestStatus.Requested);
        }
    }
}
