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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types
{
    
    
    /// <summary>
    /// >> 583 - Composite[pallet_parachain_staking.types.ParachainBondConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParachainBondConfig : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Account { get; set; }
        /// <summary>
        /// >> percent
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Percent Percent { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ParachainBondConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Percent.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Account.Decode(byteArray, ref p);
            Percent = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Percent();
            Percent.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}