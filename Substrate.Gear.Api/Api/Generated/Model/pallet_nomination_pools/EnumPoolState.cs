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


namespace Substrate.Gear.Api.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> PoolState
    /// </summary>
    public enum PoolState
    {
        
        /// <summary>
        /// >> Open
        /// </summary>
        Open = 0,
        
        /// <summary>
        /// >> Blocked
        /// </summary>
        Blocked = 1,
        
        /// <summary>
        /// >> Destroying
        /// </summary>
        Destroying = 2,
    }
    
    /// <summary>
    /// >> 259 - Variant[pallet_nomination_pools.PoolState]
    /// </summary>
    public sealed class EnumPoolState : BaseEnum<PoolState>
    {
    }
}
