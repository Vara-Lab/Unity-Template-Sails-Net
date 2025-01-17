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


namespace Substrate.Gear.Api.Generated.Model.gear_common.gas_provider.node
{
    
    
    /// <summary>
    /// >> 620 - Composite[gear_common.gas_provider.node.ChildrenRefs]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ChildrenRefs : BaseType
    {
        
        /// <summary>
        /// >> spec_refs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SpecRefs { get; set; }
        /// <summary>
        /// >> unspec_refs
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UnspecRefs { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ChildrenRefs";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecRefs.Encode());
            result.AddRange(UnspecRefs.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecRefs = new Substrate.NetApi.Model.Types.Primitive.U32();
            SpecRefs.Decode(byteArray, ref p);
            UnspecRefs = new Substrate.NetApi.Model.Types.Primitive.U32();
            UnspecRefs.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
