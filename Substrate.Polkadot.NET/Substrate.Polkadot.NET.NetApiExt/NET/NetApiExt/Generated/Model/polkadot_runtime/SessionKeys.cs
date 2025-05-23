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
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime
{
    
    
    /// <summary>
    /// >> 134 - Composite[polkadot_runtime.SessionKeys]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SessionKeys : BaseType
    {
        
        /// <summary>
        /// >> grandpa
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public Grandpa { get; set; }
        /// <summary>
        /// >> babe
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.app.Public Babe { get; set; }
        /// <summary>
        /// >> para_validator
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public ParaValidator { get; set; }
        /// <summary>
        /// >> para_assignment
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public ParaAssignment { get; set; }
        /// <summary>
        /// >> authority_discovery
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public AuthorityDiscovery { get; set; }
        /// <summary>
        /// >> beefy
        /// </summary>
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_beefy.ecdsa_crypto.Public Beefy { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SessionKeys";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Grandpa.Encode());
            result.AddRange(Babe.Encode());
            result.AddRange(ParaValidator.Encode());
            result.AddRange(ParaAssignment.Encode());
            result.AddRange(AuthorityDiscovery.Encode());
            result.AddRange(Beefy.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Grandpa = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public();
            Grandpa.Decode(byteArray, ref p);
            Babe = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.app.Public();
            Babe.Decode(byteArray, ref p);
            ParaValidator = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.validator_app.Public();
            ParaValidator.Decode(byteArray, ref p);
            ParaAssignment = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.assignment_app.Public();
            ParaAssignment.Decode(byteArray, ref p);
            AuthorityDiscovery = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_authority_discovery.app.Public();
            AuthorityDiscovery.Decode(byteArray, ref p);
            Beefy = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_beefy.ecdsa_crypto.Public();
            Beefy.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
