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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship
{
    
    
    /// <summary>
    /// >> 249 - Composite[pallet_core_fellowship.ParamsType]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParamsType : BaseType
    {
        
        /// <summary>
        /// >> active_salary
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U128 ActiveSalary { get; set; }
        /// <summary>
        /// >> passive_salary
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U128 PassiveSalary { get; set; }
        /// <summary>
        /// >> demotion_period
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U32 DemotionPeriod { get; set; }
        /// <summary>
        /// >> min_promotion_period
        /// </summary>
        public Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U32 MinPromotionPeriod { get; set; }
        /// <summary>
        /// >> offboard_timeout
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 OffboardTimeout { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ParamsType";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ActiveSalary.Encode());
            result.AddRange(PassiveSalary.Encode());
            result.AddRange(DemotionPeriod.Encode());
            result.AddRange(MinPromotionPeriod.Encode());
            result.AddRange(OffboardTimeout.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ActiveSalary = new Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U128();
            ActiveSalary.Decode(byteArray, ref p);
            PassiveSalary = new Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U128();
            PassiveSalary.Decode(byteArray, ref p);
            DemotionPeriod = new Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U32();
            DemotionPeriod.Decode(byteArray, ref p);
            MinPromotionPeriod = new Substrate.Collectives.NET.NetApiExt.Generated.Types.Base.Arr9U32();
            MinPromotionPeriod.Decode(byteArray, ref p);
            OffboardTimeout = new Substrate.NetApi.Model.Types.Primitive.U32();
            OffboardTimeout.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}