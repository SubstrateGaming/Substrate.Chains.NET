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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 401 - Composite[up_data_structs.Collection]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Collection : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> mode
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode _mode;
        
        /// <summary>
        /// >> name
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 _name;
        
        /// <summary>
        /// >> description
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 _description;
        
        /// <summary>
        /// >> token_prefix
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT15 _tokenPrefix;
        
        /// <summary>
        /// >> sponsorship
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState _sponsorship;
        
        /// <summary>
        /// >> limits
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionLimits _limits;
        
        /// <summary>
        /// >> permissions
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions _permissions;
        
        /// <summary>
        /// >> flags
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Types.Base.Arr1U8 _flags;
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Owner
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
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT15 TokenPrefix
        {
            get
            {
                return this._tokenPrefix;
            }
            set
            {
                this._tokenPrefix = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState Sponsorship
        {
            get
            {
                return this._sponsorship;
            }
            set
            {
                this._sponsorship = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionLimits Limits
        {
            get
            {
                return this._limits;
            }
            set
            {
                this._limits = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions Permissions
        {
            get
            {
                return this._permissions;
            }
            set
            {
                this._permissions = value;
            }
        }
        
        public Substrate.Unique.NET.NetApiExt.Generated.Types.Base.Arr1U8 Flags
        {
            get
            {
                return this._flags;
            }
            set
            {
                this._flags = value;
            }
        }
        
        public override string TypeName()
        {
            return "Collection";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Mode.Encode());
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(TokenPrefix.Encode());
            result.AddRange(Sponsorship.Encode());
            result.AddRange(Limits.Encode());
            result.AddRange(Permissions.Encode());
            result.AddRange(Flags.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Mode = new Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode();
            Mode.Decode(byteArray, ref p);
            Name = new Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13();
            Name.Decode(byteArray, ref p);
            Description = new Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14();
            Description.Decode(byteArray, ref p);
            TokenPrefix = new Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT15();
            TokenPrefix.Decode(byteArray, ref p);
            Sponsorship = new Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState();
            Sponsorship.Decode(byteArray, ref p);
            Limits = new Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionLimits();
            Limits.Decode(byteArray, ref p);
            Permissions = new Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions();
            Permissions.Decode(byteArray, ref p);
            Flags = new Substrate.Unique.NET.NetApiExt.Generated.Types.Base.Arr1U8();
            Flags.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}