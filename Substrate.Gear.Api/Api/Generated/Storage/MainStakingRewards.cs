#nullable disable
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


namespace Substrate.Gear.Api.Generated.Storage
{
    
    
    /// <summary>
    /// >> StakingRewardsStorage
    /// </summary>
    public sealed class StakingRewardsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> StakingRewardsStorage Constructor
        /// </summary>
        public StakingRewardsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StakingRewards", "TargetInflation"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StakingRewards", "IdealStakingRatio"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StakingRewards", "NonStakeableShare"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StakingRewards", "FilteredAccounts"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Gear.Api.Generated.Types.Base.BTreeSetT3)));
        }
        
        /// <summary>
        /// >> TargetInflationParams
        ///  Target inflation (at ideal stake)
        /// </summary>
        public static string TargetInflationParams()
        {
            return RequestGenerator.GetStorage("StakingRewards", "TargetInflation", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TargetInflationDefault
        /// Default value as hex string
        /// </summary>
        public static string TargetInflationDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> TargetInflation
        ///  Target inflation (at ideal stake)
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill> TargetInflation(string blockhash, CancellationToken token)
        {
            string parameters = StakingRewardsStorage.TargetInflationParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> IdealStakingRatioParams
        ///  Ideal staking ratio
        /// </summary>
        public static string IdealStakingRatioParams()
        {
            return RequestGenerator.GetStorage("StakingRewards", "IdealStakingRatio", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> IdealStakingRatioDefault
        /// Default value as hex string
        /// </summary>
        public static string IdealStakingRatioDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> IdealStakingRatio
        ///  Ideal staking ratio
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill> IdealStakingRatio(string blockhash, CancellationToken token)
        {
            string parameters = StakingRewardsStorage.IdealStakingRatioParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NonStakeableShareParams
        ///  The current share of issued tokens that cannot be staked (e.g. being vested)
        ///  This value is guaranteed to remain unchanged for the first year until vesting kicks in.
        ///  Subsequently, the non-stakeable share should be calculated based on the vesting balances.
        /// </summary>
        public static string NonStakeableShareParams()
        {
            return RequestGenerator.GetStorage("StakingRewards", "NonStakeableShare", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NonStakeableShareDefault
        /// Default value as hex string
        /// </summary>
        public static string NonStakeableShareDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> NonStakeableShare
        ///  The current share of issued tokens that cannot be staked (e.g. being vested)
        ///  This value is guaranteed to remain unchanged for the first year until vesting kicks in.
        ///  Subsequently, the non-stakeable share should be calculated based on the vesting balances.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill> NonStakeableShare(string blockhash, CancellationToken token)
        {
            string parameters = StakingRewardsStorage.NonStakeableShareParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> FilteredAccountsParams
        ///  List of accounts whose locked balance (due to incomplete vesting) should be excluded from
        ///  the total stakeable quantity.
        ///  During the 1st year the non-stakeable amount is accounted for as a fixed fraction of TTS.
        /// </summary>
        public static string FilteredAccountsParams()
        {
            return RequestGenerator.GetStorage("StakingRewards", "FilteredAccounts", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> FilteredAccountsDefault
        /// Default value as hex string
        /// </summary>
        public static string FilteredAccountsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> FilteredAccounts
        ///  List of accounts whose locked balance (due to incomplete vesting) should be excluded from
        ///  the total stakeable quantity.
        ///  During the 1st year the non-stakeable amount is accounted for as a fixed fraction of TTS.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Types.Base.BTreeSetT3> FilteredAccounts(string blockhash, CancellationToken token)
        {
            string parameters = StakingRewardsStorage.FilteredAccountsParams();
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Types.Base.BTreeSetT3>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> StakingRewardsCalls
    /// </summary>
    public sealed class StakingRewardsCalls
    {
        
        /// <summary>
        /// >> refill
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Refill(Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            return new Method(106, "StakingRewards", 0, "refill", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_refill
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceRefill(Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress from, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(from.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(106, "StakingRewards", 1, "force_refill", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> withdraw
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Withdraw(Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress to, Substrate.NetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(to.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(106, "StakingRewards", 2, "withdraw", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> align_supply
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AlignSupply(Substrate.NetApi.Model.Types.Primitive.U128 target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            return new Method(106, "StakingRewards", 3, "align_supply", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> StakingRewardsConstants
    /// </summary>
    public sealed class StakingRewardsConstants
    {
        
        /// <summary>
        /// >> PalletId
        ///  The staking rewards' pallet id, used for deriving its sovereign account ID.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Substrate.Gear.Api.Generated.Model.frame_support.PalletId();
            result.Create("0x70792F7374727764");
            return result;
        }
        
        /// <summary>
        /// >> MillisecondsPerYear
        ///  Milliseconds per year to calculate inflation.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 MillisecondsPerYear()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x00C3FA5807000000");
            return result;
        }
        
        /// <summary>
        /// >> MinInflation
        ///  Minimum annual inflation.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill MinInflation()
        {
            var result = new Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill();
            result.Create("0x0000C16FF2862300");
            return result;
        }
        
        /// <summary>
        /// >> MaxROI
        ///  ROI cap.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill MaxROI()
        {
            var result = new Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill();
            result.Create("0x00009E1869D02904");
            return result;
        }
        
        /// <summary>
        /// >> Falloff
        ///  Exponential decay (fall-off) parameter.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill Falloff()
        {
            var result = new Substrate.Gear.Api.Generated.Model.sp_arithmetic.per_things.Perquintill();
            result.Create("0x000082DFE40D4700");
            return result;
        }
    }
    
    /// <summary>
    /// >> StakingRewardsErrors
    /// </summary>
    public enum StakingRewardsErrors
    {
        
        /// <summary>
        /// >> FailureToRefillPool
        /// Pool not replenished due to error.
        /// </summary>
        FailureToRefillPool,
        
        /// <summary>
        /// >> FailureToWithdrawFromPool
        /// Failure to withdraw funds from the rewards pool.
        /// </summary>
        FailureToWithdrawFromPool,
    }
}
