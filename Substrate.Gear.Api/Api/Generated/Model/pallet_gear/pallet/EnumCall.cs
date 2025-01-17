#nullable disable
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


namespace Substrate.Gear.Api.Generated.Model.pallet_gear.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> upload_code
        /// Saves program `code` in storage.
        /// 
        /// The extrinsic was created to provide _deploy program from program_ functionality.
        /// Anyone who wants to define a "factory" logic in program should first store the code and metadata for the "child"
        /// program in storage. So the code for the child will be initialized by program initialization request only if it exists in storage.
        /// 
        /// More precisely, the code and its metadata are actually saved in the storage under the hash of the `code`. The code hash is computed
        /// as Blake256 hash. At the time of the call the `code` hash should not be in the storage. If it was stored previously, call will end up
        /// with an `CodeAlreadyExists` error. In this case user can be sure, that he can actually use the hash of his program's code bytes to define
        /// "program factory" logic in his program.
        /// 
        /// Parameters
        /// - `code`: wasm code of a program as a byte vector.
        /// 
        /// Emits the following events:
        /// - `SavedCode(H256)` - when the code is saved in storage.
        /// </summary>
        upload_code = 0,
        
        /// <summary>
        /// >> upload_program
        /// Creates program initialization request (message), that is scheduled to be run in the same block.
        /// 
        /// There are no guarantees that initialization message will be run in the same block due to block
        /// gas limit restrictions. For example, when it will be the message's turn, required gas limit for it
        /// could be more than remaining block gas limit. Therefore, the message processing will be postponed
        /// until the next block.
        /// 
        /// `ProgramId` is computed as Blake256 hash of concatenated bytes of `code` + `salt`. (todo #512 `code_hash` + `salt`)
        /// Such `ProgramId` must not exist in the Program Storage at the time of this call.
        /// 
        /// There is the same guarantee here as in `upload_code`. That is, future program's
        /// `code` and metadata are stored before message was added to the queue and processed.
        /// 
        /// The origin must be Signed and the sender must have sufficient funds to pay
        /// for `gas` and `value` (in case the latter is being transferred).
        /// 
        /// Gear runtime guarantees that an active program always has an account to store value.
        /// If the underlying account management platform (e.g. Substrate's System pallet) requires
        /// an existential deposit to keep an account alive, the related overhead is considered an
        /// extra cost related with a program instantiation and is charged to the program's creator
        /// and is released back to the creator when the program is removed.
        /// In context of the above, the `value` parameter represents the so-called `reducible` balance
        /// a program should have at its disposal upon instantiation. It is not used to offset the
        /// existential deposit required for an account creation.
        /// 
        /// Parameters:
        /// - `code`: wasm code of a program as a byte vector.
        /// - `salt`: randomness term (a seed) to allow programs with identical code
        ///   to be created independently.
        /// - `init_payload`: encoded parameters of the wasm module `init` function.
        /// - `gas_limit`: maximum amount of gas the program can spend before it is halted.
        /// - `value`: balance to be transferred to the program once it's been created.
        /// 
        /// Emits the following events:
        /// - `InitMessageEnqueued(MessageInfo)` when init message is placed in the queue.
        /// 
        /// # Note
        /// Faulty (uninitialized) programs still have a valid addresses (program ids) that can deterministically be derived on the
        /// caller's side upfront. It means that if messages are sent to such an address, they might still linger in the queue.
        /// 
        /// In order to mitigate the risk of users' funds being sent to an address,
        /// where a valid program should have resided, while it's not,
        /// such "failed-to-initialize" programs are not silently deleted from the
        /// program storage but rather marked as "ghost" programs.
        /// Ghost program can be removed by their original author via an explicit call.
        /// The funds stored by a ghost program will be release to the author once the program
        /// has been removed.
        /// </summary>
        upload_program = 1,
        
        /// <summary>
        /// >> create_program
        /// Creates program via `code_id` from storage.
        /// 
        /// Parameters:
        /// - `code_id`: wasm code id in the code storage.
        /// - `salt`: randomness term (a seed) to allow programs with identical code
        ///   to be created independently.
        /// - `init_payload`: encoded parameters of the wasm module `init` function.
        /// - `gas_limit`: maximum amount of gas the program can spend before it is halted.
        /// - `value`: balance to be transferred to the program once it's been created.
        /// 
        /// Emits the following events:
        /// - `InitMessageEnqueued(MessageInfo)` when init message is placed in the queue.
        /// 
        /// # NOTE
        /// 
        /// For the details of this extrinsic, see `upload_code`.
        /// </summary>
        create_program = 2,
        
        /// <summary>
        /// >> send_message
        /// Sends a message to a program or to another account.
        /// 
        /// The origin must be Signed and the sender must have sufficient funds to pay
        /// for `gas` and `value` (in case the latter is being transferred).
        /// 
        /// To avoid an undefined behavior a check is made that the destination address
        /// is not a program in uninitialized state. If the opposite holds true,
        /// the message is not enqueued for processing.
        /// 
        /// Parameters:
        /// - `destination`: the message destination.
        /// - `payload`: in case of a program destination, parameters of the `handle` function.
        /// - `gas_limit`: maximum amount of gas the program can spend before it is halted.
        /// - `value`: balance to be transferred to the program once it's been created.
        /// 
        /// Emits the following events:
        /// - `DispatchMessageEnqueued(MessageInfo)` when dispatch message is placed in the queue.
        /// </summary>
        send_message = 3,
        
        /// <summary>
        /// >> send_reply
        /// Send reply on message in `Mailbox`.
        /// 
        /// Removes message by given `MessageId` from callers `Mailbox`:
        /// rent funds become free, associated with the message value
        /// transfers from message sender to extrinsic caller.
        /// 
        /// Generates reply on removed message with given parameters
        /// and pushes it in `MessageQueue`.
        /// 
        /// NOTE: source of the message in mailbox guaranteed to be a program.
        /// 
        /// NOTE: only user who is destination of the message, can claim value
        /// or reply on the message from mailbox.
        /// </summary>
        send_reply = 4,
        
        /// <summary>
        /// >> claim_value
        /// Claim value from message in `Mailbox`.
        /// 
        /// Removes message by given `MessageId` from callers `Mailbox`:
        /// rent funds become free, associated with the message value
        /// transfers from message sender to extrinsic caller.
        /// 
        /// NOTE: only user who is destination of the message, can claim value
        /// or reply on the message from mailbox.
        /// </summary>
        claim_value = 5,
        
        /// <summary>
        /// >> run
        /// Process message queue
        /// </summary>
        run = 6,
        
        /// <summary>
        /// >> set_execute_inherent
        /// Sets `ExecuteInherent` flag.
        /// 
        /// Requires root origin (eventually, will only be set via referendum)
        /// </summary>
        set_execute_inherent = 7,
        
        /// <summary>
        /// >> claim_value_to_inheritor
        /// Transfers value from chain of terminated or exited programs to its final inheritor.
        /// 
        /// `depth` parameter is how far to traverse to inheritor.
        /// A value of 10 is sufficient for most cases.
        /// 
        /// # Example of chain
        /// 
        /// - Program #1 exits (e.g `gr_exit syscall) with argument pointing to user.
        /// Balance of program #1 has been sent to user.
        /// - Program #2 exits with inheritor pointing to program #1.
        /// Balance of program #2 has been sent to exited program #1.
        /// - Program #3 exits with inheritor pointing to program #2
        /// Balance of program #1 has been sent to exited program #2.
        /// 
        /// So chain of inheritors looks like: Program #3 -> Program #2 -> Program #1 -> User.
        /// 
        /// We have programs #1 and #2 with stuck value on their balances.
        /// The balances should've been transferred to user (final inheritor) according to the chain.
        /// But protocol doesn't traverse the chain automatically, so user have to call this extrinsic.
        /// </summary>
        claim_value_to_inheritor = 8,
    }
    
    /// <summary>
    /// >> 270 - Variant[pallet_gear.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>(Call.upload_code);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.upload_program);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.CodeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.create_program);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.send_message);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.send_reply);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId>(Call.claim_value);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>>(Call.run);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.Bool>(Call.set_execute_inherent);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.Gear.Api.Generated.Types.Base.NonZeroU32>>(Call.claim_value_to_inheritor);
        }
    }
}
