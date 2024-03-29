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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_nomination_pools.types
{
    
    
    /// <summary>
    /// >> 766 - Composite[pallet_nomination_pools.types.BonusCycle]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BonusCycle : BaseType
    {
        
        /// <summary>
        /// >> previous_start
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> PreviousStart { get; set; }
        /// <summary>
        /// >> start
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Start { get; set; }
        /// <summary>
        /// >> end
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> End { get; set; }
        /// <summary>
        /// >> pending_duration
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> PendingDuration { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BonusCycle";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PreviousStart.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(End.Encode());
            result.AddRange(PendingDuration.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PreviousStart = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            PreviousStart.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Start.Decode(byteArray, ref p);
            End = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            End.Decode(byteArray, ref p);
            PendingDuration = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            PendingDuration.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
