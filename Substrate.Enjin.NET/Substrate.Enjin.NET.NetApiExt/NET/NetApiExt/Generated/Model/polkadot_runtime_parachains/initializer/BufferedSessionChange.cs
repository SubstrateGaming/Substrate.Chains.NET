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
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.initializer
{
    
    
    /// <summary>
    /// >> 827 - Composite[polkadot_runtime_parachains.initializer.BufferedSessionChange]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BufferedSessionChange : BaseType
    {
        
        /// <summary>
        /// >> validators
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.validator_app.Public> Validators { get; set; }
        /// <summary>
        /// >> queued
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.validator_app.Public> Queued { get; set; }
        /// <summary>
        /// >> session_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SessionIndex { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BufferedSessionChange";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Validators.Encode());
            result.AddRange(Queued.Encode());
            result.AddRange(SessionIndex.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Validators = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.validator_app.Public>();
            Validators.Decode(byteArray, ref p);
            Queued = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.validator_app.Public>();
            Queued.Decode(byteArray, ref p);
            SessionIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            SessionIndex.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}