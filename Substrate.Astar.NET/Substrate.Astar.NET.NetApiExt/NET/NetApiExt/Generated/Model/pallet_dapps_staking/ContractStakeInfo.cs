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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_dapps_staking
{
    
    
    /// <summary>
    /// >> 229 - Composite[pallet_dapps_staking.ContractStakeInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ContractStakeInfo : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> _total;
        
        /// <summary>
        /// >> number_of_stakers
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _numberOfStakers;
        
        /// <summary>
        /// >> contract_reward_claimed
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _contractRewardClaimed;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> NumberOfStakers
        {
            get
            {
                return this._numberOfStakers;
            }
            set
            {
                this._numberOfStakers = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool ContractRewardClaimed
        {
            get
            {
                return this._contractRewardClaimed;
            }
            set
            {
                this._contractRewardClaimed = value;
            }
        }
        
        public override string TypeName()
        {
            return "ContractStakeInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(NumberOfStakers.Encode());
            result.AddRange(ContractRewardClaimed.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            NumberOfStakers = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            NumberOfStakers.Decode(byteArray, ref p);
            ContractRewardClaimed = new Substrate.NetApi.Model.Types.Primitive.Bool();
            ContractRewardClaimed.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
