//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Enjin.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> FuelTanksStorage
    /// </summary>
    public sealed class FuelTanksStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> FuelTanksStorage Constructor
        /// </summary>
        public FuelTanksStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FuelTanks", "Tanks"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.FuelTank)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FuelTanks", "Accounts"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.UserAccount)));
        }
        
        /// <summary>
        /// >> TanksParams
        ///  Mapping of Fuel Tanks accounts to their data
        /// </summary>
        public static string TanksParams(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("FuelTanks", "Tanks", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TanksDefault
        /// Default value as hex string
        /// </summary>
        public static string TanksDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Tanks
        ///  Mapping of Fuel Tanks accounts to their data
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.FuelTank> Tanks(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = FuelTanksStorage.TanksParams(key);
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.FuelTank>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AccountsParams
        ///  Mapping of Fuel Tanks and their user Accounts to account data
        /// </summary>
        public static string AccountsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("FuelTanks", "Accounts", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> AccountsDefault
        /// Default value as hex string
        /// </summary>
        public static string AccountsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Accounts
        ///  Mapping of Fuel Tanks and their user Accounts to account data
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.UserAccount> Accounts(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = FuelTanksStorage.AccountsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.UserAccount>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> FuelTanksCalls
    /// </summary>
    public sealed class FuelTanksCalls
    {
        
        /// <summary>
        /// >> create_fuel_tank
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateFuelTank(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.FuelTankDescriptor descriptor)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(descriptor.Encode());
            return new Method(254, "FuelTanks", 0, "create_fuel_tank", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> mutate_fuel_tank
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MutateFuelTank(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.impls.DefaultTankMutation mutation)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(mutation.Encode());
            return new Method(254, "FuelTanks", 1, "mutate_fuel_tank", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> add_account
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddAccount(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress user_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_id.Encode());
            return new Method(254, "FuelTanks", 2, "add_account", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_account
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveAccount(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress user_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_id.Encode());
            return new Method(254, "FuelTanks", 3, "remove_account", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_account_rule_data
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveAccountRuleData(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress user_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.rules.EnumDispatchRuleKind rule_kind)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(rule_kind.Encode());
            return new Method(254, "FuelTanks", 4, "remove_account_rule_data", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Dispatch(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.enjin_runtime.EnumRuntimeCall call, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.DispatchSettings> settings)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(settings.Encode());
            return new Method(254, "FuelTanks", 5, "dispatch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch_and_touch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DispatchAndTouch(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.enjin_runtime.EnumRuntimeCall call, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.DispatchSettings> settings)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(settings.Encode());
            return new Method(254, "FuelTanks", 6, "dispatch_and_touch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> mutate_freeze_state
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MutateFreezeState(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> rule_set_id, Substrate.NetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(254, "FuelTanks", 7, "mutate_freeze_state", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> insert_rule_set
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InsertRuleSet(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22 rules)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(rules.Encode());
            return new Method(254, "FuelTanks", 8, "insert_rule_set", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_rule_set
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveRuleSet(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            return new Method(254, "FuelTanks", 9, "remove_rule_set", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> batch_add_account
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method BatchAddAccount(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 user_ids)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_ids.Encode());
            return new Method(254, "FuelTanks", 10, "batch_add_account", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> batch_remove_account
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method BatchRemoveAccount(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 user_ids)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_ids.Encode());
            return new Method(254, "FuelTanks", 11, "batch_remove_account", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_set_consumption
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceSetConsumption(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress> user_id, Substrate.NetApi.Model.Types.Primitive.U32 rule_set_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.Consumption consumption)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_id.Encode());
            byteArray.AddRange(rule_set_id.Encode());
            byteArray.AddRange(consumption.Encode());
            return new Method(254, "FuelTanks", 12, "force_set_consumption", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> destroy_fuel_tank
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DestroyFuelTank(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(tank_id.Encode());
            return new Method(254, "FuelTanks", 13, "destroy_fuel_tank", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_create_fuel_tank
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCreateFuelTank(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress owner, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.FuelTankDescriptor descriptor)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(descriptor.Encode());
            return new Method(254, "FuelTanks", 14, "force_create_fuel_tank", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_batch_add_account
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceBatchAddAccount(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress owner, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress tank_id, Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 user_ids)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(tank_id.Encode());
            byteArray.AddRange(user_ids.Encode());
            return new Method(254, "FuelTanks", 15, "force_batch_add_account", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> FuelTanksConstants
    /// </summary>
    public sealed class FuelTanksConstants
    {
        
        /// <summary>
        /// >> Salt
        ///  The salt used for address generation
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8 Salt()
        {
            var result = new Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8();
            result.Create("0x6566696E69747979");
            return result;
        }
        
        /// <summary>
        /// >> MaxWhitelistedCallers
        ///  The maximum number of whitelisted callers per fuel tank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxWhitelistedCallers()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxRuleSets
        ///  The maximum number of rule sets per fuel tank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxRuleSets()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x0A000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxRulesPerSet
        ///  Maximum number of rules in a ruleset
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxRulesPerSet()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x0A000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxAccountRuleDataLength
        ///  Max length of data a rule can store per account
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxAccountRuleDataLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCallFilters
        ///  The maximum number of permitted calls
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCallFilters()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x14000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxWhitelistedCollections
        ///  Maximum number of whitelisted collections for a fuel tank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxWhitelistedCollections()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00010000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCallSize
        ///  The maximum number of rule sets per fuel tank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCallSize()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xE8030000");
            return result;
        }
        
        /// <summary>
        /// >> MaxUserHistorySize
        ///  The maximum number of user history that can be stored
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUserHistorySize()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x10270000");
            return result;
        }
        
        /// <summary>
        /// >> MaxBatchAccounts
        ///  The maximum number of accounts for batch operations
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxBatchAccounts()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxFuelTankNameLength
        ///  The maximum length for fuel tank name
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxFuelTankNameLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x20000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxExtrinsicNameLength
        ///  The maximum length for extrinsics for PermittedExtrinsic rule
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxExtrinsicNameLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxPermittedExtrinsicLength
        ///  The maximum number of extrinsics to allow for PermittedExtrinsic rule
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxPermittedExtrinsicLength()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> TankCreationDeposit
        ///  Deposit for creating a new fuel tank
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TankCreationDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00007A22C1C8B1220000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> AccountCreationDeposit
        ///  Deposit for creating an account
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 AccountCreationDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00008A5D784563010000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ReserveIdentifier
        ///  The identifier used for currency reserves
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8 ReserveIdentifier()
        {
            var result = new Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.Arr8U8();
            result.Create("0x6675656C74616E6B");
            return result;
        }
        
        /// <summary>
        /// >> LevyScale
        ///  value of a unit of the independant variable in EFI for the levy discount according to
        ///  f(x) = (1/2)^x. Cannot be 0.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LevyScale()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xB80B0000");
            return result;
        }
        
        /// <summary>
        /// >> Levy
        ///  The Levy applied to all transactions in Matrix.
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill Levy()
        {
            var result = new Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            result.Create("0x8017B42C");
            return result;
        }
    }
    
    /// <summary>
    /// >> FuelTanksErrors
    /// </summary>
    public enum FuelTanksErrors
    {
        
        /// <summary>
        /// >> FuelTankNotFound
        /// Fuel Tank not found
        /// </summary>
        FuelTankNotFound,
        
        /// <summary>
        /// >> FuelTankAlreadyExists
        /// Fuel Tank already exists
        /// </summary>
        FuelTankAlreadyExists,
        
        /// <summary>
        /// >> InsufficientBalance
        /// Not enough funds to perform operation
        /// </summary>
        InsufficientBalance,
        
        /// <summary>
        /// >> UsageRestricted
        /// Fuel tank cannot be used due to restrictions
        /// </summary>
        UsageRestricted,
        
        /// <summary>
        /// >> FuelTankOutOfFunds
        /// Fuel tank doesnt have enough funds
        /// </summary>
        FuelTankOutOfFunds,
        
        /// <summary>
        /// >> RuleSetNotFound
        /// The rule set does not exist
        /// </summary>
        RuleSetNotFound,
        
        /// <summary>
        /// >> RuleNotFound
        /// The rule is missing
        /// </summary>
        RuleNotFound,
        
        /// <summary>
        /// >> NoPermission
        /// User does not have permission to perform operation
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> AccountAlreadyExists
        /// The account already exists
        /// </summary>
        AccountAlreadyExists,
        
        /// <summary>
        /// >> AccountNotFound
        /// The account was not found
        /// </summary>
        AccountNotFound,
        
        /// <summary>
        /// >> DestroyWithExistingAccounts
        /// Destroying fuel tank is not possible while it has existing accounts attached
        /// </summary>
        DestroyWithExistingAccounts,
        
        /// <summary>
        /// >> DestroyUnfrozenTank
        /// Destroying fuel tank is not possible while it is not frozen
        /// </summary>
        DestroyUnfrozenTank,
        
        /// <summary>
        /// >> MaxRuleSetsExceeded
        /// Max number of rules sets per fuel tank was exceeded
        /// </summary>
        MaxRuleSetsExceeded,
        
        /// <summary>
        /// >> UserRuleDataExceededMaxSize
        /// The size of the user rule data is greater than the allowed amount
        /// </summary>
        UserRuleDataExceededMaxSize,
        
        /// <summary>
        /// >> DecodeUserRuleDataFailed
        /// The user rule data could not be decoded
        /// </summary>
        DecodeUserRuleDataFailed,
        
        /// <summary>
        /// >> RequiresFrozenTankOrRuleset
        /// Either the tank or ruleset must be frozen for this operation
        /// </summary>
        RequiresFrozenTankOrRuleset,
        
        /// <summary>
        /// >> RequiresFrozenTank
        /// The fuel tank must be frozen for this operation
        /// </summary>
        RequiresFrozenTank,
        
        /// <summary>
        /// >> MissingRequiredRule
        /// A rule that is required for this operation does not exist
        /// </summary>
        MissingRequiredRule,
        
        /// <summary>
        /// >> MissingRequiredRuleUserData
        /// User data for the required rule does not exist
        /// </summary>
        MissingRequiredRuleUserData,
        
        /// <summary>
        /// >> InvalidRuleSet
        /// The rule set of the fuel tank is misconfigured. This error should never occur.
        /// </summary>
        InvalidRuleSet,
        
        /// <summary>
        /// >> AccountContainsRuleData
        /// A user cannot remove an account that is storing data for a rule
        /// </summary>
        AccountContainsRuleData,
        
        /// <summary>
        /// >> CannotRemoveRuleThatIsStoringAccountData
        /// A rule cannot be removed from a rule set if it is storing data on any account
        /// </summary>
        CannotRemoveRuleThatIsStoringAccountData,
        
        /// <summary>
        /// >> DuplicateRuleKinds
        /// A fuel tank cannot have more than one rule of the same kind
        /// </summary>
        DuplicateRuleKinds,
        
        /// <summary>
        /// >> DepositCalculationError
        /// Problems calculating the deposit for a call
        /// </summary>
        DepositCalculationError,
        
        /// <summary>
        /// >> FuelTankFrozen
        /// The fuel tank is frozen
        /// </summary>
        FuelTankFrozen,
        
        /// <summary>
        /// >> CallerDoesNotHaveRuleSetTokenBalance
        /// The user does not have the token required by rule set
        /// </summary>
        CallerDoesNotHaveRuleSetTokenBalance,
        
        /// <summary>
        /// >> NoDataToRemove
        /// The user does not have any data stored for rule set
        /// </summary>
        NoDataToRemove,
    }
}