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


namespace Substrate.Coretime.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue
{
    
    
    /// <summary>
    /// >> 251 - Composite[cumulus_pallet_xcmp_queue.OutboundChannelDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OutboundChannelDetails : BaseType
    {
        
        /// <summary>
        /// >> recipient
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id Recipient { get; set; }
        /// <summary>
        /// >> state
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumOutboundState State { get; set; }
        /// <summary>
        /// >> signals_exist
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool SignalsExist { get; set; }
        /// <summary>
        /// >> first_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 FirstIndex { get; set; }
        /// <summary>
        /// >> last_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 LastIndex { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "OutboundChannelDetails";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Recipient.Encode());
            result.AddRange(State.Encode());
            result.AddRange(SignalsExist.Encode());
            result.AddRange(FirstIndex.Encode());
            result.AddRange(LastIndex.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Recipient = new Substrate.Coretime.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
            Recipient.Decode(byteArray, ref p);
            State = new Substrate.Coretime.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumOutboundState();
            State.Decode(byteArray, ref p);
            SignalsExist = new Substrate.NetApi.Model.Types.Primitive.Bool();
            SignalsExist.Decode(byteArray, ref p);
            FirstIndex = new Substrate.NetApi.Model.Types.Primitive.U16();
            FirstIndex.Decode(byteArray, ref p);
            LastIndex = new Substrate.NetApi.Model.Types.Primitive.U16();
            LastIndex.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}