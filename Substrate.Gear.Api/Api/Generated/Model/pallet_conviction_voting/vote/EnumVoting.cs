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


namespace Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote
{
    
    
    /// <summary>
    /// >> Voting
    /// </summary>
    public enum Voting
    {
        
        /// <summary>
        /// >> Casting
        /// </summary>
        Casting = 0,
        
        /// <summary>
        /// >> Delegating
        /// </summary>
        Delegating = 1,
    }
    
    /// <summary>
    /// >> 447 - Variant[pallet_conviction_voting.vote.Voting]
    /// </summary>
    public sealed class EnumVoting : BaseEnumRust<Voting>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVoting()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.Casting>(Voting.Casting);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.Delegating>(Voting.Delegating);
        }
    }
}
