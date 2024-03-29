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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.parachain_staking.inflation
{
    
    
    /// <summary>
    /// >> 226 - Composite[parachain_staking.inflation.StakingInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class StakingInfo : BaseType
    {
        
        /// <summary>
        /// >> max_rate
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perquintill _maxRate;
        
        /// <summary>
        /// >> reward_rate
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.parachain_staking.inflation.RewardRate _rewardRate;
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perquintill MaxRate
        {
            get
            {
                return this._maxRate;
            }
            set
            {
                this._maxRate = value;
            }
        }
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.parachain_staking.inflation.RewardRate RewardRate
        {
            get
            {
                return this._rewardRate;
            }
            set
            {
                this._rewardRate = value;
            }
        }
        
        public override string TypeName()
        {
            return "StakingInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxRate.Encode());
            result.AddRange(RewardRate.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxRate = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perquintill();
            MaxRate.Decode(byteArray, ref p);
            RewardRate = new Substrate.KILT.NET.NetApiExt.Generated.Model.parachain_staking.inflation.RewardRate();
            RewardRate.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
