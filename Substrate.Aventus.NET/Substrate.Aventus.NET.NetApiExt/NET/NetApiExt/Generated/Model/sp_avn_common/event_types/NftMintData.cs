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
    /// >> 348 - Composite[sp_avn_common.event_types.NftMintData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class NftMintData : BaseType
    {
        
        /// <summary>
        /// >> batch_id
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 _batchId;
        
        /// <summary>
        /// >> t2_owner_public_key
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256 _t2OwnerPublicKey;
        
        /// <summary>
        /// >> op_id
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _opId;
        
        /// <summary>
        /// >> t1_contract_issuer
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 _t1ContractIssuer;
        
        /// <summary>
        /// >> sale_index
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _saleIndex;
        
        /// <summary>
        /// >> unique_external_ref
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _uniqueExternalRef;
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 BatchId
        {
            get
            {
                return this._batchId;
            }
            set
            {
                this._batchId = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256 T2OwnerPublicKey
        {
            get
            {
                return this._t2OwnerPublicKey;
            }
            set
            {
                this._t2OwnerPublicKey = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 OpId
        {
            get
            {
                return this._opId;
            }
            set
            {
                this._opId = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 T1ContractIssuer
        {
            get
            {
                return this._t1ContractIssuer;
            }
            set
            {
                this._t1ContractIssuer = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 SaleIndex
        {
            get
            {
                return this._saleIndex;
            }
            set
            {
                this._saleIndex = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> UniqueExternalRef
        {
            get
            {
                return this._uniqueExternalRef;
            }
            set
            {
                this._uniqueExternalRef = value;
            }
        }
        
        public override string TypeName()
        {
            return "NftMintData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BatchId.Encode());
            result.AddRange(T2OwnerPublicKey.Encode());
            result.AddRange(OpId.Encode());
            result.AddRange(T1ContractIssuer.Encode());
            result.AddRange(SaleIndex.Encode());
            result.AddRange(UniqueExternalRef.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BatchId = new Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256();
            BatchId.Decode(byteArray, ref p);
            T2OwnerPublicKey = new Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256();
            T2OwnerPublicKey.Decode(byteArray, ref p);
            OpId = new Substrate.NetApi.Model.Types.Primitive.U64();
            OpId.Decode(byteArray, ref p);
            T1ContractIssuer = new Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160();
            T1ContractIssuer.Decode(byteArray, ref p);
            SaleIndex = new Substrate.NetApi.Model.Types.Primitive.U64();
            SaleIndex.Decode(byteArray, ref p);
            UniqueExternalRef = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            UniqueExternalRef.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}