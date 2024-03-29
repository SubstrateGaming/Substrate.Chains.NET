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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime
{
    
    
    /// <summary>
    /// >> 224 - Composite[moonsama_runtime.SessionKeys]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SessionKeys : BaseType
    {
        
        /// <summary>
        /// >> aura
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public _aura;
        
        /// <summary>
        /// >> vrf
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.session_keys_primitives.vrf.vrf_crypto.Public _vrf;
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public Aura
        {
            get
            {
                return this._aura;
            }
            set
            {
                this._aura = value;
            }
        }
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.session_keys_primitives.vrf.vrf_crypto.Public Vrf
        {
            get
            {
                return this._vrf;
            }
            set
            {
                this._vrf = value;
            }
        }
        
        public override string TypeName()
        {
            return "SessionKeys";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Aura.Encode());
            result.AddRange(Vrf.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Aura = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
            Aura.Decode(byteArray, ref p);
            Vrf = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.session_keys_primitives.vrf.vrf_crypto.Public();
            Vrf.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
