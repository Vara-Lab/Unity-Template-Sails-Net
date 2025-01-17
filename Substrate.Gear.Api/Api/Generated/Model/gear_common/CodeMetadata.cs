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


namespace Substrate.Gear.Api.Generated.Model.gear_common
{
    
    
    /// <summary>
    /// >> 574 - Composite[gear_common.CodeMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CodeMetadata : BaseType
    {
        
        /// <summary>
        /// >> author
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.primitive_types.H256 Author { get; set; }
        /// <summary>
        /// >> block_number
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> BlockNumber { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CodeMetadata";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Author.Encode());
            result.AddRange(BlockNumber.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Author = new Substrate.Gear.Api.Generated.Model.primitive_types.H256();
            Author.Decode(byteArray, ref p);
            BlockNumber = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            BlockNumber.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
