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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details
{
    
    
    /// <summary>
    /// >> 304 - Composite[did.did_details.DidAuthorizedCallOperation]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DidAuthorizedCallOperation : BaseType
    {
        
        /// <summary>
        /// >> did
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _did;
        
        /// <summary>
        /// >> tx_counter
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _txCounter;
        
        /// <summary>
        /// >> call
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.spiritnet_runtime.EnumRuntimeCall _call;
        
        /// <summary>
        /// >> block_number
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _blockNumber;
        
        /// <summary>
        /// >> submitter
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _submitter;
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Did
        {
            get
            {
                return this._did;
            }
            set
            {
                this._did = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 TxCounter
        {
            get
            {
                return this._txCounter;
            }
            set
            {
                this._txCounter = value;
            }
        }
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.spiritnet_runtime.EnumRuntimeCall Call
        {
            get
            {
                return this._call;
            }
            set
            {
                this._call = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 BlockNumber
        {
            get
            {
                return this._blockNumber;
            }
            set
            {
                this._blockNumber = value;
            }
        }
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Submitter
        {
            get
            {
                return this._submitter;
            }
            set
            {
                this._submitter = value;
            }
        }
        
        public override string TypeName()
        {
            return "DidAuthorizedCallOperation";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Did.Encode());
            result.AddRange(TxCounter.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(BlockNumber.Encode());
            result.AddRange(Submitter.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Did = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Did.Decode(byteArray, ref p);
            TxCounter = new Substrate.NetApi.Model.Types.Primitive.U64();
            TxCounter.Decode(byteArray, ref p);
            Call = new Substrate.KILT.NET.NetApiExt.Generated.Model.spiritnet_runtime.EnumRuntimeCall();
            Call.Decode(byteArray, ref p);
            BlockNumber = new Substrate.NetApi.Model.Types.Primitive.U64();
            BlockNumber.Decode(byteArray, ref p);
            Submitter = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Submitter.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
