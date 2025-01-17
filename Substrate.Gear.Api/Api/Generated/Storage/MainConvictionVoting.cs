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
    /// >> ConvictionVotingStorage
    /// </summary>
    public sealed class ConvictionVotingStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ConvictionVotingStorage Constructor
        /// </summary>
        public ConvictionVotingStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ConvictionVoting", "VotingFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>), typeof(Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.EnumVoting)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ConvictionVoting", "ClassLocksFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Gear.Api.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16)));
        }
        
        /// <summary>
        /// >> VotingForParams
        ///  All voting for a particular voter in a particular voting class. We store the balance for the
        ///  number of votes that we have recorded.
        /// </summary>
        public static string VotingForParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16> key)
        {
            return RequestGenerator.GetStorage("ConvictionVoting", "VotingFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VotingForDefault
        /// Default value as hex string
        /// </summary>
        public static string VotingForDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000000000000000000" +
                "00000000000000000000000000000";
        }
        
        /// <summary>
        /// >> VotingFor
        ///  All voting for a particular voter in a particular voting class. We store the balance for the
        ///  number of votes that we have recorded.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.EnumVoting> VotingFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16> key, string blockhash, CancellationToken token)
        {
            string parameters = ConvictionVotingStorage.VotingForParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.EnumVoting>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ClassLocksForParams
        ///  The voting classes which have a non-zero lock requirement and the lock amounts which they
        ///  require. The actual amount locked on behalf of this pallet should always be the maximum of
        ///  this list.
        /// </summary>
        public static string ClassLocksForParams(Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("ConvictionVoting", "ClassLocksFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ClassLocksForDefault
        /// Default value as hex string
        /// </summary>
        public static string ClassLocksForDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ClassLocksFor
        ///  The voting classes which have a non-zero lock requirement and the lock amounts which they
        ///  require. The actual amount locked on behalf of this pallet should always be the maximum of
        ///  this list.
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16> ClassLocksFor(Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = ConvictionVotingStorage.ClassLocksForParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ConvictionVotingCalls
    /// </summary>
    public sealed class ConvictionVotingCalls
    {
        
        /// <summary>
        /// >> vote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Vote(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> poll_index, Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.vote.EnumAccountVote vote)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(vote.Encode());
            return new Method(16, "ConvictionVoting", 0, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> delegate
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Delegate(Substrate.NetApi.Model.Types.Primitive.U16 @class, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress to, Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.conviction.EnumConviction conviction, Substrate.NetApi.Model.Types.Primitive.U128 balance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(to.Encode());
            byteArray.AddRange(conviction.Encode());
            byteArray.AddRange(balance.Encode());
            return new Method(16, "ConvictionVoting", 1, "delegate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> undelegate
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Undelegate(Substrate.NetApi.Model.Types.Primitive.U16 @class)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            return new Method(16, "ConvictionVoting", 2, "undelegate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unlock
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Unlock(Substrate.NetApi.Model.Types.Primitive.U16 @class, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(target.Encode());
            return new Method(16, "ConvictionVoting", 3, "unlock", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_vote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveVote(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U16> @class, Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(16, "ConvictionVoting", 4, "remove_vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_other_vote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveOtherVote(Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target, Substrate.NetApi.Model.Types.Primitive.U16 @class, Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(16, "ConvictionVoting", 5, "remove_other_vote", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ConvictionVotingConstants
    /// </summary>
    public sealed class ConvictionVotingConstants
    {
        
        /// <summary>
        /// >> MaxVotes
        ///  The maximum number of concurrent votes an account may have.
        /// 
        ///  Also used to compute weight, an overly large value can lead to extrinsics with large
        ///  weight estimation: see `delegate` for instance.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxVotes()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00020000");
            return result;
        }
        
        /// <summary>
        /// >> VoteLockingPeriod
        ///  The minimum period of vote locking.
        /// 
        ///  It should be no shorter than enactment period to ensure that in the case of an approval,
        ///  those successful voters are locked into the consequences that their votes entail.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 VoteLockingPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80130300");
            return result;
        }
    }
    
    /// <summary>
    /// >> ConvictionVotingErrors
    /// </summary>
    public enum ConvictionVotingErrors
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Poll is not ongoing.
        /// </summary>
        NotOngoing,
        
        /// <summary>
        /// >> NotVoter
        /// The given account did not vote on the poll.
        /// </summary>
        NotVoter,
        
        /// <summary>
        /// >> NoPermission
        /// The actor has no permission to conduct the action.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NoPermissionYet
        /// The actor has no permission to conduct the action right now but will do in the future.
        /// </summary>
        NoPermissionYet,
        
        /// <summary>
        /// >> AlreadyDelegating
        /// The account is already delegating.
        /// </summary>
        AlreadyDelegating,
        
        /// <summary>
        /// >> AlreadyVoting
        /// The account currently has votes attached to it and the operation cannot succeed until
        /// these are removed through `remove_vote`.
        /// </summary>
        AlreadyVoting,
        
        /// <summary>
        /// >> InsufficientFunds
        /// Too high a balance was provided that the account cannot afford.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> NotDelegating
        /// The account is not currently delegating.
        /// </summary>
        NotDelegating,
        
        /// <summary>
        /// >> Nonsense
        /// Delegation to oneself makes no sense.
        /// </summary>
        Nonsense,
        
        /// <summary>
        /// >> MaxVotesReached
        /// Maximum number of votes reached.
        /// </summary>
        MaxVotesReached,
        
        /// <summary>
        /// >> ClassNeeded
        /// The class must be supplied since it is not easily determinable from the state.
        /// </summary>
        ClassNeeded,
        
        /// <summary>
        /// >> BadClass
        /// The class ID supplied is invalid.
        /// </summary>
        BadClass,
    }
}
