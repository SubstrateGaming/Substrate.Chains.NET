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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_nft_manager.nft_data
{
    
    
    /// <summary>
    /// >> 403 - Composite[pallet_nft_manager.nft_data.Nft]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Nft : BaseType
    {
        
        /// <summary>
        /// >> nft_id
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 _nftId;
        
        /// <summary>
        /// >> info_id
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 _infoId;
        
        /// <summary>
        /// >> unique_external_ref
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _uniqueExternalRef;
        
        /// <summary>
        /// >> nonce
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _nonce;
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> is_locked
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _isLocked;
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 NftId
        {
            get
            {
                return this._nftId;
            }
            set
            {
                this._nftId = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256 InfoId
        {
            get
            {
                return this._infoId;
            }
            set
            {
                this._infoId = value;
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
        
        public Substrate.NetApi.Model.Types.Primitive.U64 Nonce
        {
            get
            {
                return this._nonce;
            }
            set
            {
                this._nonce = value;
            }
        }
        
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool IsLocked
        {
            get
            {
                return this._isLocked;
            }
            set
            {
                this._isLocked = value;
            }
        }
        
        public override string TypeName()
        {
            return "Nft";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(NftId.Encode());
            result.AddRange(InfoId.Encode());
            result.AddRange(UniqueExternalRef.Encode());
            result.AddRange(Nonce.Encode());
            result.AddRange(Owner.Encode());
            result.AddRange(IsLocked.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            NftId = new Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256();
            NftId.Decode(byteArray, ref p);
            InfoId = new Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.U256();
            InfoId.Decode(byteArray, ref p);
            UniqueExternalRef = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            UniqueExternalRef.Decode(byteArray, ref p);
            Nonce = new Substrate.NetApi.Model.Types.Primitive.U64();
            Nonce.Decode(byteArray, ref p);
            Owner = new Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            IsLocked = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsLocked.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
