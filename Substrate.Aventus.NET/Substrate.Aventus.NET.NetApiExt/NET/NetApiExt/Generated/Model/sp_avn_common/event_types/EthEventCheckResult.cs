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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types
{
    
    
    /// <summary>
    /// >> 343 - Composite[sp_avn_common.event_types.EthEventCheckResult]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EthEventCheckResult : BaseType
    {
        
        /// <summary>
        /// >> event
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EthEvent _event;
        
        /// <summary>
        /// >> result
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EnumCheckResult _result;
        
        /// <summary>
        /// >> checked_by
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _checkedBy;
        
        /// <summary>
        /// >> checked_at_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _checkedAtBlock;
        
        /// <summary>
        /// >> ready_for_processing_after_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _readyForProcessingAfterBlock;
        
        /// <summary>
        /// >> min_challenge_votes
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _minChallengeVotes;
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EthEvent Event
        {
            get
            {
                return this._event;
            }
            set
            {
                this._event = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EnumCheckResult Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 CheckedBy
        {
            get
            {
                return this._checkedBy;
            }
            set
            {
                this._checkedBy = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 CheckedAtBlock
        {
            get
            {
                return this._checkedAtBlock;
            }
            set
            {
                this._checkedAtBlock = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ReadyForProcessingAfterBlock
        {
            get
            {
                return this._readyForProcessingAfterBlock;
            }
            set
            {
                this._readyForProcessingAfterBlock = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MinChallengeVotes
        {
            get
            {
                return this._minChallengeVotes;
            }
            set
            {
                this._minChallengeVotes = value;
            }
        }
        
        public override string TypeName()
        {
            return "EthEventCheckResult";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Event.Encode());
            result.AddRange(Result.Encode());
            result.AddRange(CheckedBy.Encode());
            result.AddRange(CheckedAtBlock.Encode());
            result.AddRange(ReadyForProcessingAfterBlock.Encode());
            result.AddRange(MinChallengeVotes.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Event = new Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EthEvent();
            Event.Decode(byteArray, ref p);
            Result = new Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types.EnumCheckResult();
            Result.Decode(byteArray, ref p);
            CheckedBy = new Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            CheckedBy.Decode(byteArray, ref p);
            CheckedAtBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            CheckedAtBlock.Decode(byteArray, ref p);
            ReadyForProcessingAfterBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            ReadyForProcessingAfterBlock.Decode(byteArray, ref p);
            MinChallengeVotes = new Substrate.NetApi.Model.Types.Primitive.U32();
            MinChallengeVotes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
