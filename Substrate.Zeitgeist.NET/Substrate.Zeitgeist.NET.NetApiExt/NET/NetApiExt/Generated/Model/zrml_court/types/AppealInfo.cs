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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.types
{
    
    
    /// <summary>
    /// >> 72 - Composite[zrml_court.types.AppealInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AppealInfo : BaseType
    {
        
        /// <summary>
        /// >> backer
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Backer { get; set; }
        /// <summary>
        /// >> bond
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Bond { get; set; }
        /// <summary>
        /// >> appealed_vote_item
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.types.EnumVoteItem AppealedVoteItem { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AppealInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Backer.Encode());
            result.AddRange(Bond.Encode());
            result.AddRange(AppealedVoteItem.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Backer = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Backer.Decode(byteArray, ref p);
            Bond = new Substrate.NetApi.Model.Types.Primitive.U128();
            Bond.Decode(byteArray, ref p);
            AppealedVoteItem = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_court.types.EnumVoteItem();
            AppealedVoteItem.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
