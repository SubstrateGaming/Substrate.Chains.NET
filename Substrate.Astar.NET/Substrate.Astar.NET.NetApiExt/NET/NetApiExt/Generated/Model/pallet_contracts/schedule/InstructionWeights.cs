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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.pallet_contracts.schedule
{
    
    
    /// <summary>
    /// >> 428 - Composite[pallet_contracts.schedule.InstructionWeights]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InstructionWeights : BaseType
    {
        
        /// <summary>
        /// >> version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _version;
        
        /// <summary>
        /// >> fallback
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _fallback;
        
        /// <summary>
        /// >> i64const
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64const;
        
        /// <summary>
        /// >> i64load
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64load;
        
        /// <summary>
        /// >> i64store
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64store;
        
        /// <summary>
        /// >> select
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _select;
        
        /// <summary>
        /// >> r#if
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _rHif;
        
        /// <summary>
        /// >> br
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _br;
        
        /// <summary>
        /// >> br_if
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _brIf;
        
        /// <summary>
        /// >> br_table
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _brTable;
        
        /// <summary>
        /// >> br_table_per_entry
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _brTablePerEntry;
        
        /// <summary>
        /// >> call
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _call;
        
        /// <summary>
        /// >> call_indirect
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _callIndirect;
        
        /// <summary>
        /// >> call_indirect_per_param
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _callIndirectPerParam;
        
        /// <summary>
        /// >> call_per_local
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _callPerLocal;
        
        /// <summary>
        /// >> local_get
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _localGet;
        
        /// <summary>
        /// >> local_set
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _localSet;
        
        /// <summary>
        /// >> local_tee
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _localTee;
        
        /// <summary>
        /// >> global_get
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _globalGet;
        
        /// <summary>
        /// >> global_set
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _globalSet;
        
        /// <summary>
        /// >> memory_current
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _memoryCurrent;
        
        /// <summary>
        /// >> memory_grow
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _memoryGrow;
        
        /// <summary>
        /// >> i64clz
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64clz;
        
        /// <summary>
        /// >> i64ctz
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64ctz;
        
        /// <summary>
        /// >> i64popcnt
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64popcnt;
        
        /// <summary>
        /// >> i64eqz
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64eqz;
        
        /// <summary>
        /// >> i64extendsi32
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64extendsi32;
        
        /// <summary>
        /// >> i64extendui32
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64extendui32;
        
        /// <summary>
        /// >> i32wrapi64
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i32wrapi64;
        
        /// <summary>
        /// >> i64eq
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64eq;
        
        /// <summary>
        /// >> i64ne
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64ne;
        
        /// <summary>
        /// >> i64lts
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64lts;
        
        /// <summary>
        /// >> i64ltu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64ltu;
        
        /// <summary>
        /// >> i64gts
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64gts;
        
        /// <summary>
        /// >> i64gtu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64gtu;
        
        /// <summary>
        /// >> i64les
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64les;
        
        /// <summary>
        /// >> i64leu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64leu;
        
        /// <summary>
        /// >> i64ges
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64ges;
        
        /// <summary>
        /// >> i64geu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64geu;
        
        /// <summary>
        /// >> i64add
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64add;
        
        /// <summary>
        /// >> i64sub
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64sub;
        
        /// <summary>
        /// >> i64mul
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64mul;
        
        /// <summary>
        /// >> i64divs
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64divs;
        
        /// <summary>
        /// >> i64divu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64divu;
        
        /// <summary>
        /// >> i64rems
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64rems;
        
        /// <summary>
        /// >> i64remu
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64remu;
        
        /// <summary>
        /// >> i64and
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64and;
        
        /// <summary>
        /// >> i64or
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64or;
        
        /// <summary>
        /// >> i64xor
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64xor;
        
        /// <summary>
        /// >> i64shl
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64shl;
        
        /// <summary>
        /// >> i64shrs
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64shrs;
        
        /// <summary>
        /// >> i64shru
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64shru;
        
        /// <summary>
        /// >> i64rotl
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64rotl;
        
        /// <summary>
        /// >> i64rotr
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _i64rotr;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Fallback
        {
            get
            {
                return this._fallback;
            }
            set
            {
                this._fallback = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64const
        {
            get
            {
                return this._i64const;
            }
            set
            {
                this._i64const = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64load
        {
            get
            {
                return this._i64load;
            }
            set
            {
                this._i64load = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64store
        {
            get
            {
                return this._i64store;
            }
            set
            {
                this._i64store = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Select
        {
            get
            {
                return this._select;
            }
            set
            {
                this._select = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 RHif
        {
            get
            {
                return this._rHif;
            }
            set
            {
                this._rHif = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Br
        {
            get
            {
                return this._br;
            }
            set
            {
                this._br = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 BrIf
        {
            get
            {
                return this._brIf;
            }
            set
            {
                this._brIf = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 BrTable
        {
            get
            {
                return this._brTable;
            }
            set
            {
                this._brTable = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 BrTablePerEntry
        {
            get
            {
                return this._brTablePerEntry;
            }
            set
            {
                this._brTablePerEntry = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Call
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
        
        public Substrate.NetApi.Model.Types.Primitive.U32 CallIndirect
        {
            get
            {
                return this._callIndirect;
            }
            set
            {
                this._callIndirect = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 CallIndirectPerParam
        {
            get
            {
                return this._callIndirectPerParam;
            }
            set
            {
                this._callIndirectPerParam = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 CallPerLocal
        {
            get
            {
                return this._callPerLocal;
            }
            set
            {
                this._callPerLocal = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalGet
        {
            get
            {
                return this._localGet;
            }
            set
            {
                this._localGet = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalSet
        {
            get
            {
                return this._localSet;
            }
            set
            {
                this._localSet = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 LocalTee
        {
            get
            {
                return this._localTee;
            }
            set
            {
                this._localTee = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 GlobalGet
        {
            get
            {
                return this._globalGet;
            }
            set
            {
                this._globalGet = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 GlobalSet
        {
            get
            {
                return this._globalSet;
            }
            set
            {
                this._globalSet = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MemoryCurrent
        {
            get
            {
                return this._memoryCurrent;
            }
            set
            {
                this._memoryCurrent = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MemoryGrow
        {
            get
            {
                return this._memoryGrow;
            }
            set
            {
                this._memoryGrow = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64clz
        {
            get
            {
                return this._i64clz;
            }
            set
            {
                this._i64clz = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ctz
        {
            get
            {
                return this._i64ctz;
            }
            set
            {
                this._i64ctz = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64popcnt
        {
            get
            {
                return this._i64popcnt;
            }
            set
            {
                this._i64popcnt = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64eqz
        {
            get
            {
                return this._i64eqz;
            }
            set
            {
                this._i64eqz = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extendsi32
        {
            get
            {
                return this._i64extendsi32;
            }
            set
            {
                this._i64extendsi32 = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64extendui32
        {
            get
            {
                return this._i64extendui32;
            }
            set
            {
                this._i64extendui32 = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I32wrapi64
        {
            get
            {
                return this._i32wrapi64;
            }
            set
            {
                this._i32wrapi64 = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64eq
        {
            get
            {
                return this._i64eq;
            }
            set
            {
                this._i64eq = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ne
        {
            get
            {
                return this._i64ne;
            }
            set
            {
                this._i64ne = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64lts
        {
            get
            {
                return this._i64lts;
            }
            set
            {
                this._i64lts = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ltu
        {
            get
            {
                return this._i64ltu;
            }
            set
            {
                this._i64ltu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64gts
        {
            get
            {
                return this._i64gts;
            }
            set
            {
                this._i64gts = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64gtu
        {
            get
            {
                return this._i64gtu;
            }
            set
            {
                this._i64gtu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64les
        {
            get
            {
                return this._i64les;
            }
            set
            {
                this._i64les = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64leu
        {
            get
            {
                return this._i64leu;
            }
            set
            {
                this._i64leu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64ges
        {
            get
            {
                return this._i64ges;
            }
            set
            {
                this._i64ges = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64geu
        {
            get
            {
                return this._i64geu;
            }
            set
            {
                this._i64geu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64add
        {
            get
            {
                return this._i64add;
            }
            set
            {
                this._i64add = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64sub
        {
            get
            {
                return this._i64sub;
            }
            set
            {
                this._i64sub = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64mul
        {
            get
            {
                return this._i64mul;
            }
            set
            {
                this._i64mul = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64divs
        {
            get
            {
                return this._i64divs;
            }
            set
            {
                this._i64divs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64divu
        {
            get
            {
                return this._i64divu;
            }
            set
            {
                this._i64divu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rems
        {
            get
            {
                return this._i64rems;
            }
            set
            {
                this._i64rems = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64remu
        {
            get
            {
                return this._i64remu;
            }
            set
            {
                this._i64remu = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64and
        {
            get
            {
                return this._i64and;
            }
            set
            {
                this._i64and = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64or
        {
            get
            {
                return this._i64or;
            }
            set
            {
                this._i64or = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64xor
        {
            get
            {
                return this._i64xor;
            }
            set
            {
                this._i64xor = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shl
        {
            get
            {
                return this._i64shl;
            }
            set
            {
                this._i64shl = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shrs
        {
            get
            {
                return this._i64shrs;
            }
            set
            {
                this._i64shrs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64shru
        {
            get
            {
                return this._i64shru;
            }
            set
            {
                this._i64shru = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rotl
        {
            get
            {
                return this._i64rotl;
            }
            set
            {
                this._i64rotl = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 I64rotr
        {
            get
            {
                return this._i64rotr;
            }
            set
            {
                this._i64rotr = value;
            }
        }
        
        public override string TypeName()
        {
            return "InstructionWeights";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Version.Encode());
            result.AddRange(Fallback.Encode());
            result.AddRange(I64const.Encode());
            result.AddRange(I64load.Encode());
            result.AddRange(I64store.Encode());
            result.AddRange(Select.Encode());
            result.AddRange(RHif.Encode());
            result.AddRange(Br.Encode());
            result.AddRange(BrIf.Encode());
            result.AddRange(BrTable.Encode());
            result.AddRange(BrTablePerEntry.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(CallIndirect.Encode());
            result.AddRange(CallIndirectPerParam.Encode());
            result.AddRange(CallPerLocal.Encode());
            result.AddRange(LocalGet.Encode());
            result.AddRange(LocalSet.Encode());
            result.AddRange(LocalTee.Encode());
            result.AddRange(GlobalGet.Encode());
            result.AddRange(GlobalSet.Encode());
            result.AddRange(MemoryCurrent.Encode());
            result.AddRange(MemoryGrow.Encode());
            result.AddRange(I64clz.Encode());
            result.AddRange(I64ctz.Encode());
            result.AddRange(I64popcnt.Encode());
            result.AddRange(I64eqz.Encode());
            result.AddRange(I64extendsi32.Encode());
            result.AddRange(I64extendui32.Encode());
            result.AddRange(I32wrapi64.Encode());
            result.AddRange(I64eq.Encode());
            result.AddRange(I64ne.Encode());
            result.AddRange(I64lts.Encode());
            result.AddRange(I64ltu.Encode());
            result.AddRange(I64gts.Encode());
            result.AddRange(I64gtu.Encode());
            result.AddRange(I64les.Encode());
            result.AddRange(I64leu.Encode());
            result.AddRange(I64ges.Encode());
            result.AddRange(I64geu.Encode());
            result.AddRange(I64add.Encode());
            result.AddRange(I64sub.Encode());
            result.AddRange(I64mul.Encode());
            result.AddRange(I64divs.Encode());
            result.AddRange(I64divu.Encode());
            result.AddRange(I64rems.Encode());
            result.AddRange(I64remu.Encode());
            result.AddRange(I64and.Encode());
            result.AddRange(I64or.Encode());
            result.AddRange(I64xor.Encode());
            result.AddRange(I64shl.Encode());
            result.AddRange(I64shrs.Encode());
            result.AddRange(I64shru.Encode());
            result.AddRange(I64rotl.Encode());
            result.AddRange(I64rotr.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Version = new Substrate.NetApi.Model.Types.Primitive.U32();
            Version.Decode(byteArray, ref p);
            Fallback = new Substrate.NetApi.Model.Types.Primitive.U32();
            Fallback.Decode(byteArray, ref p);
            I64const = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64const.Decode(byteArray, ref p);
            I64load = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64load.Decode(byteArray, ref p);
            I64store = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64store.Decode(byteArray, ref p);
            Select = new Substrate.NetApi.Model.Types.Primitive.U32();
            Select.Decode(byteArray, ref p);
            RHif = new Substrate.NetApi.Model.Types.Primitive.U32();
            RHif.Decode(byteArray, ref p);
            Br = new Substrate.NetApi.Model.Types.Primitive.U32();
            Br.Decode(byteArray, ref p);
            BrIf = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrIf.Decode(byteArray, ref p);
            BrTable = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrTable.Decode(byteArray, ref p);
            BrTablePerEntry = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrTablePerEntry.Decode(byteArray, ref p);
            Call = new Substrate.NetApi.Model.Types.Primitive.U32();
            Call.Decode(byteArray, ref p);
            CallIndirect = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallIndirect.Decode(byteArray, ref p);
            CallIndirectPerParam = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallIndirectPerParam.Decode(byteArray, ref p);
            CallPerLocal = new Substrate.NetApi.Model.Types.Primitive.U32();
            CallPerLocal.Decode(byteArray, ref p);
            LocalGet = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalGet.Decode(byteArray, ref p);
            LocalSet = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalSet.Decode(byteArray, ref p);
            LocalTee = new Substrate.NetApi.Model.Types.Primitive.U32();
            LocalTee.Decode(byteArray, ref p);
            GlobalGet = new Substrate.NetApi.Model.Types.Primitive.U32();
            GlobalGet.Decode(byteArray, ref p);
            GlobalSet = new Substrate.NetApi.Model.Types.Primitive.U32();
            GlobalSet.Decode(byteArray, ref p);
            MemoryCurrent = new Substrate.NetApi.Model.Types.Primitive.U32();
            MemoryCurrent.Decode(byteArray, ref p);
            MemoryGrow = new Substrate.NetApi.Model.Types.Primitive.U32();
            MemoryGrow.Decode(byteArray, ref p);
            I64clz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64clz.Decode(byteArray, ref p);
            I64ctz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ctz.Decode(byteArray, ref p);
            I64popcnt = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64popcnt.Decode(byteArray, ref p);
            I64eqz = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64eqz.Decode(byteArray, ref p);
            I64extendsi32 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extendsi32.Decode(byteArray, ref p);
            I64extendui32 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64extendui32.Decode(byteArray, ref p);
            I32wrapi64 = new Substrate.NetApi.Model.Types.Primitive.U32();
            I32wrapi64.Decode(byteArray, ref p);
            I64eq = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64eq.Decode(byteArray, ref p);
            I64ne = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ne.Decode(byteArray, ref p);
            I64lts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64lts.Decode(byteArray, ref p);
            I64ltu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ltu.Decode(byteArray, ref p);
            I64gts = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64gts.Decode(byteArray, ref p);
            I64gtu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64gtu.Decode(byteArray, ref p);
            I64les = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64les.Decode(byteArray, ref p);
            I64leu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64leu.Decode(byteArray, ref p);
            I64ges = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64ges.Decode(byteArray, ref p);
            I64geu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64geu.Decode(byteArray, ref p);
            I64add = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64add.Decode(byteArray, ref p);
            I64sub = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64sub.Decode(byteArray, ref p);
            I64mul = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64mul.Decode(byteArray, ref p);
            I64divs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64divs.Decode(byteArray, ref p);
            I64divu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64divu.Decode(byteArray, ref p);
            I64rems = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rems.Decode(byteArray, ref p);
            I64remu = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64remu.Decode(byteArray, ref p);
            I64and = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64and.Decode(byteArray, ref p);
            I64or = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64or.Decode(byteArray, ref p);
            I64xor = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64xor.Decode(byteArray, ref p);
            I64shl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shl.Decode(byteArray, ref p);
            I64shrs = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shrs.Decode(byteArray, ref p);
            I64shru = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64shru.Decode(byteArray, ref p);
            I64rotl = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rotl.Decode(byteArray, ref p);
            I64rotr = new Substrate.NetApi.Model.Types.Primitive.U32();
            I64rotr.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}