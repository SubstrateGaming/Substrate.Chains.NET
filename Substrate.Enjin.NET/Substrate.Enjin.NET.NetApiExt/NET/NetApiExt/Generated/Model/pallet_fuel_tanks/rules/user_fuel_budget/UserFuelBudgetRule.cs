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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.rules.user_fuel_budget
{
    
    
    /// <summary>
    /// >> 916 - Composite[pallet_fuel_tanks.rules.user_fuel_budget.UserFuelBudgetRule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UserFuelBudgetRule : BaseType
    {
        
        /// <summary>
        /// >> budget
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.Budget Budget { get; set; }
        /// <summary>
        /// >> user_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> UserCount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UserFuelBudgetRule";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Budget.Encode());
            result.AddRange(UserCount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Budget = new Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.Budget();
            Budget.Decode(byteArray, ref p);
            UserCount = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            UserCount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
