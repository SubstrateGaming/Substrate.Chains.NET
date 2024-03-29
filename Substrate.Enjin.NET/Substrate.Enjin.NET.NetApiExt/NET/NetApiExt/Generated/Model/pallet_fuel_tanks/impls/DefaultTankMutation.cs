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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.impls
{
    
    
    /// <summary>
    /// >> 255 - Composite[pallet_fuel_tanks.impls.DefaultTankMutation]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DefaultTankMutation : BaseType
    {
        
        /// <summary>
        /// >> user_account_management
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.types.EnumShouldMutate UserAccountManagement { get; set; }
        /// <summary>
        /// >> provides_deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.Bool> ProvidesDeposit { get; set; }
        /// <summary>
        /// >> account_rules
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11> AccountRules { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DefaultTankMutation";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UserAccountManagement.Encode());
            result.AddRange(ProvidesDeposit.Encode());
            result.AddRange(AccountRules.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UserAccountManagement = new Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.types.EnumShouldMutate();
            UserAccountManagement.Decode(byteArray, ref p);
            ProvidesDeposit = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.Bool>();
            ProvidesDeposit.Decode(byteArray, ref p);
            AccountRules = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>();
            AccountRules.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
