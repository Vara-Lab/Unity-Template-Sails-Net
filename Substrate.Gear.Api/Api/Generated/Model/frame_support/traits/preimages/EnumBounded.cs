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


namespace Substrate.Gear.Api.Generated.Model.frame_support.traits.preimages
{
    
    
    /// <summary>
    /// >> Bounded
    /// </summary>
    public enum Bounded
    {
        
        /// <summary>
        /// >> Legacy
        /// </summary>
        Legacy = 0,
        
        /// <summary>
        /// >> Inline
        /// </summary>
        Inline = 1,
        
        /// <summary>
        /// >> Lookup
        /// </summary>
        Lookup = 2,
    }
    
    /// <summary>
    /// >> 64 - Variant[frame_support.traits.preimages.Bounded]
    /// </summary>
    public sealed class EnumBounded : BaseEnumRust<Bounded>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumBounded()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.primitive_types.H256>(Bounded.Legacy);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>(Bounded.Inline);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>>(Bounded.Lookup);
        }
    }
}
