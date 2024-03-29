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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> 335 - Composite[ethereum.transaction.LegacyTransaction]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class LegacyTransaction : BaseType
    {
        
        /// <summary>
        /// >> nonce
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 _nonce;
        
        /// <summary>
        /// >> gas_price
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 _gasPrice;
        
        /// <summary>
        /// >> gas_limit
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 _gasLimit;
        
        /// <summary>
        /// >> action
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionAction _action;
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 _value;
        
        /// <summary>
        /// >> input
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _input;
        
        /// <summary>
        /// >> signature
        /// </summary>
        private Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.TransactionSignature _signature;
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 Nonce
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
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 GasPrice
        {
            get
            {
                return this._gasPrice;
            }
            set
            {
                this._gasPrice = value;
            }
        }
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 GasLimit
        {
            get
            {
                return this._gasLimit;
            }
            set
            {
                this._gasLimit = value;
            }
        }
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionAction Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Input
        {
            get
            {
                return this._input;
            }
            set
            {
                this._input = value;
            }
        }
        
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.TransactionSignature Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }
        
        public override string TypeName()
        {
            return "LegacyTransaction";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Nonce.Encode());
            result.AddRange(GasPrice.Encode());
            result.AddRange(GasLimit.Encode());
            result.AddRange(Action.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Input.Encode());
            result.AddRange(Signature.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Nonce = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256();
            Nonce.Decode(byteArray, ref p);
            GasPrice = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256();
            GasPrice.Decode(byteArray, ref p);
            GasLimit = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256();
            GasLimit.Decode(byteArray, ref p);
            Action = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionAction();
            Action.Decode(byteArray, ref p);
            Value = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types.U256();
            Value.Decode(byteArray, ref p);
            Input = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Input.Decode(byteArray, ref p);
            Signature = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.ethereum.transaction.TransactionSignature();
            Signature.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
