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


namespace Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.types
{
    
    
    /// <summary>
    /// >> 133 - Composite[pallet_broker.types.ScheduleItem]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ScheduleItem : BaseType
    {
        
        /// <summary>
        /// >> mask
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.core_mask.CoreMask Mask { get; set; }
        /// <summary>
        /// >> assignment
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.coretime_interface.EnumCoreAssignment Assignment { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ScheduleItem";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mask.Encode());
            result.AddRange(Assignment.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mask = new Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.core_mask.CoreMask();
            Mask.Decode(byteArray, ref p);
            Assignment = new Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_broker.coretime_interface.EnumCoreAssignment();
            Assignment.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
