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


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.gamedao_battlepass.types
{
    
    
    /// <summary>
    /// >> 602 - Composite[gamedao_battlepass.types.BattlepassInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BattlepassInfo : BaseType
    {
        
        /// <summary>
        /// >> count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Count { get; set; }
        /// <summary>
        /// >> active
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256> Active { get; set; }
        /// <summary>
        /// >> bot
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Bot { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BattlepassInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Count.Encode());
            result.AddRange(Active.Encode());
            result.AddRange(Bot.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Count = new Substrate.NetApi.Model.Types.Primitive.U32();
            Count.Decode(byteArray, ref p);
            Active = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.primitive_types.H256>();
            Active.Decode(byteArray, ref p);
            Bot = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.GameDAO.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Bot.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
