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
    /// >> 284 - Composite[did.did_details.DidCreationDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DidCreationDetails : BaseType
    {
        
        /// <summary>
        /// >> did
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _did;
        
        /// <summary>
        /// >> submitter
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _submitter;
        
        /// <summary>
        /// >> new_key_agreement_keys
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 _newKeyAgreementKeys;
        
        /// <summary>
        /// >> new_attestation_key
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey> _newAttestationKey;
        
        /// <summary>
        /// >> new_delegation_key
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey> _newDelegationKey;
        
        /// <summary>
        /// >> new_service_details
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint> _newServiceDetails;
        
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
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 NewKeyAgreementKeys
        {
            get
            {
                return this._newKeyAgreementKeys;
            }
            set
            {
                this._newKeyAgreementKeys = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey> NewAttestationKey
        {
            get
            {
                return this._newAttestationKey;
            }
            set
            {
                this._newAttestationKey = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey> NewDelegationKey
        {
            get
            {
                return this._newDelegationKey;
            }
            set
            {
                this._newDelegationKey = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint> NewServiceDetails
        {
            get
            {
                return this._newServiceDetails;
            }
            set
            {
                this._newServiceDetails = value;
            }
        }
        
        public override string TypeName()
        {
            return "DidCreationDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Did.Encode());
            result.AddRange(Submitter.Encode());
            result.AddRange(NewKeyAgreementKeys.Encode());
            result.AddRange(NewAttestationKey.Encode());
            result.AddRange(NewDelegationKey.Encode());
            result.AddRange(NewServiceDetails.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Did = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Did.Decode(byteArray, ref p);
            Submitter = new Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Submitter.Decode(byteArray, ref p);
            NewKeyAgreementKeys = new Substrate.KILT.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1();
            NewKeyAgreementKeys.Decode(byteArray, ref p);
            NewAttestationKey = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey>();
            NewAttestationKey.Decode(byteArray, ref p);
            NewDelegationKey = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.EnumDidVerificationKey>();
            NewDelegationKey.Decode(byteArray, ref p);
            NewServiceDetails = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint>();
            NewServiceDetails.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}