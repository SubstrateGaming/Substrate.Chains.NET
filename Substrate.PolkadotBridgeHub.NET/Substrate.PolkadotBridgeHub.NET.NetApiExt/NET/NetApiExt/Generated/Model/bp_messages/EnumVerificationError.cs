//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages
{
    
    
    /// <summary>
    /// >> VerificationError
    /// </summary>
    public enum VerificationError
    {
        
        /// <summary>
        /// >> EmptyMessageProof
        /// </summary>
        EmptyMessageProof = 0,
        
        /// <summary>
        /// >> HeaderChain
        /// </summary>
        HeaderChain = 1,
        
        /// <summary>
        /// >> InboundLaneStorage
        /// </summary>
        InboundLaneStorage = 2,
        
        /// <summary>
        /// >> InvalidMessageWeight
        /// </summary>
        InvalidMessageWeight = 3,
        
        /// <summary>
        /// >> MessagesCountMismatch
        /// </summary>
        MessagesCountMismatch = 4,
        
        /// <summary>
        /// >> MessageStorage
        /// </summary>
        MessageStorage = 5,
        
        /// <summary>
        /// >> MessageTooLarge
        /// </summary>
        MessageTooLarge = 6,
        
        /// <summary>
        /// >> OutboundLaneStorage
        /// </summary>
        OutboundLaneStorage = 7,
        
        /// <summary>
        /// >> StorageProof
        /// </summary>
        StorageProof = 8,
        
        /// <summary>
        /// >> Other
        /// </summary>
        Other = 9,
    }
    
    /// <summary>
    /// >> 432 - Variant[bp_messages.VerificationError]
    /// </summary>
    public sealed class EnumVerificationError : BaseEnumRust<VerificationError>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVerificationError()
        {
				AddTypeDecoder<BaseVoid>(VerificationError.EmptyMessageProof);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_header_chain.EnumHeaderChainError>(VerificationError.HeaderChain);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime.storage_proof.EnumError>(VerificationError.InboundLaneStorage);
				AddTypeDecoder<BaseVoid>(VerificationError.InvalidMessageWeight);
				AddTypeDecoder<BaseVoid>(VerificationError.MessagesCountMismatch);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime.storage_proof.EnumError>(VerificationError.MessageStorage);
				AddTypeDecoder<BaseVoid>(VerificationError.MessageTooLarge);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime.storage_proof.EnumError>(VerificationError.OutboundLaneStorage);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime.storage_proof.EnumError>(VerificationError.StorageProof);
				AddTypeDecoder<BaseVoid>(VerificationError.Other);
        }
    }
}