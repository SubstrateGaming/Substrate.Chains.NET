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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_multi_tokens.policy.mint
{
    
    
    /// <summary>
    /// >> 211 - Composite[ep_multi_tokens.policy.mint.DefaultMintPolicy]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DefaultMintPolicy : BaseType
    {
        
        /// <summary>
        /// >> max_token_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> MaxTokenCount { get; set; }
        /// <summary>
        /// >> max_token_supply
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> MaxTokenSupply { get; set; }
        /// <summary>
        /// >> force_single_mint
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool ForceSingleMint { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DefaultMintPolicy";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxTokenCount.Encode());
            result.AddRange(MaxTokenSupply.Encode());
            result.AddRange(ForceSingleMint.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxTokenCount = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>();
            MaxTokenCount.Decode(byteArray, ref p);
            MaxTokenSupply = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            MaxTokenSupply.Decode(byteArray, ref p);
            ForceSingleMint = new Substrate.NetApi.Model.Types.Primitive.Bool();
            ForceSingleMint.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}