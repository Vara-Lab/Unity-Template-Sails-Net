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


namespace Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet
{
    
    
    /// <summary>
    /// >> ConfigOp
    /// </summary>
    public enum ConfigOp
    {
        
        /// <summary>
        /// >> Noop
        /// </summary>
        Noop = 0,
        
        /// <summary>
        /// >> Set
        /// </summary>
        Set = 1,
        
        /// <summary>
        /// >> Remove
        /// </summary>
        Remove = 2,
    }
    
    /// <summary>
    /// >> 120 - Variant[pallet_staking.pallet.pallet.ConfigOp]
    /// </summary>
    public sealed class EnumConfigOp : BaseEnumRust<ConfigOp>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumConfigOp()
        {
				AddTypeDecoder<BaseVoid>(ConfigOp.Noop);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perbill>(ConfigOp.Set);
				AddTypeDecoder<BaseVoid>(ConfigOp.Remove);
        }
    }
}
