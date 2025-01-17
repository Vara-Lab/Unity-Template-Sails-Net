#nullable disable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.finality_grandpa
{
    
    
    /// <summary>
    /// >> 85 - Composite[finality_grandpa.Prevote]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Prevote : BaseType
    {
        
        /// <summary>
        /// >> target_hash
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.primitive_types.H256 TargetHash { get; set; }
        /// <summary>
        /// >> target_number
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 TargetNumber { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Prevote";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TargetHash.Encode());
            result.AddRange(TargetNumber.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TargetHash = new Substrate.Gear.Api.Generated.Model.primitive_types.H256();
            TargetHash.Decode(byteArray, ref p);
            TargetNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            TargetNumber.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
