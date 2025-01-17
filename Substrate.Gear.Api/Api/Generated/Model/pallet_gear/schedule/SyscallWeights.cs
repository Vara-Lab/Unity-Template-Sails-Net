#nullable disable
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


namespace Substrate.Gear.Api.Generated.Model.pallet_gear.schedule
{
    
    
    /// <summary>
    /// >> 625 - Composite[pallet_gear.schedule.SyscallWeights]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SyscallWeights : BaseType
    {
        
        /// <summary>
        /// >> alloc
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight Alloc { get; set; }
        /// <summary>
        /// >> free
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight Free { get; set; }
        /// <summary>
        /// >> free_range
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight FreeRange { get; set; }
        /// <summary>
        /// >> free_range_per_page
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight FreeRangePerPage { get; set; }
        /// <summary>
        /// >> gr_reserve_gas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReserveGas { get; set; }
        /// <summary>
        /// >> gr_unreserve_gas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrUnreserveGas { get; set; }
        /// <summary>
        /// >> gr_system_reserve_gas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSystemReserveGas { get; set; }
        /// <summary>
        /// >> gr_gas_available
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrGasAvailable { get; set; }
        /// <summary>
        /// >> gr_message_id
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrMessageId { get; set; }
        /// <summary>
        /// >> gr_program_id
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrProgramId { get; set; }
        /// <summary>
        /// >> gr_source
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSource { get; set; }
        /// <summary>
        /// >> gr_value
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrValue { get; set; }
        /// <summary>
        /// >> gr_value_available
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrValueAvailable { get; set; }
        /// <summary>
        /// >> gr_size
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSize { get; set; }
        /// <summary>
        /// >> gr_read
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrRead { get; set; }
        /// <summary>
        /// >> gr_read_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReadPerByte { get; set; }
        /// <summary>
        /// >> gr_env_vars
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrEnvVars { get; set; }
        /// <summary>
        /// >> gr_block_height
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrBlockHeight { get; set; }
        /// <summary>
        /// >> gr_block_timestamp
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrBlockTimestamp { get; set; }
        /// <summary>
        /// >> gr_random
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrRandom { get; set; }
        /// <summary>
        /// >> gr_reply_deposit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyDeposit { get; set; }
        /// <summary>
        /// >> gr_send
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSend { get; set; }
        /// <summary>
        /// >> gr_send_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendPerByte { get; set; }
        /// <summary>
        /// >> gr_send_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendWgas { get; set; }
        /// <summary>
        /// >> gr_send_wgas_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendWgasPerByte { get; set; }
        /// <summary>
        /// >> gr_send_init
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendInit { get; set; }
        /// <summary>
        /// >> gr_send_push
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendPush { get; set; }
        /// <summary>
        /// >> gr_send_push_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendPushPerByte { get; set; }
        /// <summary>
        /// >> gr_send_commit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendCommit { get; set; }
        /// <summary>
        /// >> gr_send_commit_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendCommitWgas { get; set; }
        /// <summary>
        /// >> gr_reservation_send
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationSend { get; set; }
        /// <summary>
        /// >> gr_reservation_send_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationSendPerByte { get; set; }
        /// <summary>
        /// >> gr_reservation_send_commit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationSendCommit { get; set; }
        /// <summary>
        /// >> gr_reply_commit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyCommit { get; set; }
        /// <summary>
        /// >> gr_reply_commit_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyCommitWgas { get; set; }
        /// <summary>
        /// >> gr_reservation_reply
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationReply { get; set; }
        /// <summary>
        /// >> gr_reservation_reply_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationReplyPerByte { get; set; }
        /// <summary>
        /// >> gr_reservation_reply_commit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReservationReplyCommit { get; set; }
        /// <summary>
        /// >> gr_reply_push
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyPush { get; set; }
        /// <summary>
        /// >> gr_reply
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReply { get; set; }
        /// <summary>
        /// >> gr_reply_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyPerByte { get; set; }
        /// <summary>
        /// >> gr_reply_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyWgas { get; set; }
        /// <summary>
        /// >> gr_reply_wgas_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyWgasPerByte { get; set; }
        /// <summary>
        /// >> gr_reply_push_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyPushPerByte { get; set; }
        /// <summary>
        /// >> gr_reply_to
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyTo { get; set; }
        /// <summary>
        /// >> gr_signal_code
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSignalCode { get; set; }
        /// <summary>
        /// >> gr_signal_from
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSignalFrom { get; set; }
        /// <summary>
        /// >> gr_reply_input
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyInput { get; set; }
        /// <summary>
        /// >> gr_reply_input_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyInputWgas { get; set; }
        /// <summary>
        /// >> gr_reply_push_input
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyPushInput { get; set; }
        /// <summary>
        /// >> gr_reply_push_input_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyPushInputPerByte { get; set; }
        /// <summary>
        /// >> gr_send_input
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendInput { get; set; }
        /// <summary>
        /// >> gr_send_input_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendInputWgas { get; set; }
        /// <summary>
        /// >> gr_send_push_input
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendPushInput { get; set; }
        /// <summary>
        /// >> gr_send_push_input_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrSendPushInputPerByte { get; set; }
        /// <summary>
        /// >> gr_debug
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrDebug { get; set; }
        /// <summary>
        /// >> gr_debug_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrDebugPerByte { get; set; }
        /// <summary>
        /// >> gr_reply_code
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrReplyCode { get; set; }
        /// <summary>
        /// >> gr_exit
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrExit { get; set; }
        /// <summary>
        /// >> gr_leave
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrLeave { get; set; }
        /// <summary>
        /// >> gr_wait
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrWait { get; set; }
        /// <summary>
        /// >> gr_wait_for
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrWaitFor { get; set; }
        /// <summary>
        /// >> gr_wait_up_to
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrWaitUpTo { get; set; }
        /// <summary>
        /// >> gr_wake
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrWake { get; set; }
        /// <summary>
        /// >> gr_create_program
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgram { get; set; }
        /// <summary>
        /// >> gr_create_program_payload_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgramPayloadPerByte { get; set; }
        /// <summary>
        /// >> gr_create_program_salt_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgramSaltPerByte { get; set; }
        /// <summary>
        /// >> gr_create_program_wgas
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgramWgas { get; set; }
        /// <summary>
        /// >> gr_create_program_wgas_payload_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgramWgasPayloadPerByte { get; set; }
        /// <summary>
        /// >> gr_create_program_wgas_salt_per_byte
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight GrCreateProgramWgasSaltPerByte { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SyscallWeights";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Alloc.Encode());
            result.AddRange(Free.Encode());
            result.AddRange(FreeRange.Encode());
            result.AddRange(FreeRangePerPage.Encode());
            result.AddRange(GrReserveGas.Encode());
            result.AddRange(GrUnreserveGas.Encode());
            result.AddRange(GrSystemReserveGas.Encode());
            result.AddRange(GrGasAvailable.Encode());
            result.AddRange(GrMessageId.Encode());
            result.AddRange(GrProgramId.Encode());
            result.AddRange(GrSource.Encode());
            result.AddRange(GrValue.Encode());
            result.AddRange(GrValueAvailable.Encode());
            result.AddRange(GrSize.Encode());
            result.AddRange(GrRead.Encode());
            result.AddRange(GrReadPerByte.Encode());
            result.AddRange(GrEnvVars.Encode());
            result.AddRange(GrBlockHeight.Encode());
            result.AddRange(GrBlockTimestamp.Encode());
            result.AddRange(GrRandom.Encode());
            result.AddRange(GrReplyDeposit.Encode());
            result.AddRange(GrSend.Encode());
            result.AddRange(GrSendPerByte.Encode());
            result.AddRange(GrSendWgas.Encode());
            result.AddRange(GrSendWgasPerByte.Encode());
            result.AddRange(GrSendInit.Encode());
            result.AddRange(GrSendPush.Encode());
            result.AddRange(GrSendPushPerByte.Encode());
            result.AddRange(GrSendCommit.Encode());
            result.AddRange(GrSendCommitWgas.Encode());
            result.AddRange(GrReservationSend.Encode());
            result.AddRange(GrReservationSendPerByte.Encode());
            result.AddRange(GrReservationSendCommit.Encode());
            result.AddRange(GrReplyCommit.Encode());
            result.AddRange(GrReplyCommitWgas.Encode());
            result.AddRange(GrReservationReply.Encode());
            result.AddRange(GrReservationReplyPerByte.Encode());
            result.AddRange(GrReservationReplyCommit.Encode());
            result.AddRange(GrReplyPush.Encode());
            result.AddRange(GrReply.Encode());
            result.AddRange(GrReplyPerByte.Encode());
            result.AddRange(GrReplyWgas.Encode());
            result.AddRange(GrReplyWgasPerByte.Encode());
            result.AddRange(GrReplyPushPerByte.Encode());
            result.AddRange(GrReplyTo.Encode());
            result.AddRange(GrSignalCode.Encode());
            result.AddRange(GrSignalFrom.Encode());
            result.AddRange(GrReplyInput.Encode());
            result.AddRange(GrReplyInputWgas.Encode());
            result.AddRange(GrReplyPushInput.Encode());
            result.AddRange(GrReplyPushInputPerByte.Encode());
            result.AddRange(GrSendInput.Encode());
            result.AddRange(GrSendInputWgas.Encode());
            result.AddRange(GrSendPushInput.Encode());
            result.AddRange(GrSendPushInputPerByte.Encode());
            result.AddRange(GrDebug.Encode());
            result.AddRange(GrDebugPerByte.Encode());
            result.AddRange(GrReplyCode.Encode());
            result.AddRange(GrExit.Encode());
            result.AddRange(GrLeave.Encode());
            result.AddRange(GrWait.Encode());
            result.AddRange(GrWaitFor.Encode());
            result.AddRange(GrWaitUpTo.Encode());
            result.AddRange(GrWake.Encode());
            result.AddRange(GrCreateProgram.Encode());
            result.AddRange(GrCreateProgramPayloadPerByte.Encode());
            result.AddRange(GrCreateProgramSaltPerByte.Encode());
            result.AddRange(GrCreateProgramWgas.Encode());
            result.AddRange(GrCreateProgramWgasPayloadPerByte.Encode());
            result.AddRange(GrCreateProgramWgasSaltPerByte.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Alloc = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            Alloc.Decode(byteArray, ref p);
            Free = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            Free.Decode(byteArray, ref p);
            FreeRange = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            FreeRange.Decode(byteArray, ref p);
            FreeRangePerPage = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            FreeRangePerPage.Decode(byteArray, ref p);
            GrReserveGas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReserveGas.Decode(byteArray, ref p);
            GrUnreserveGas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrUnreserveGas.Decode(byteArray, ref p);
            GrSystemReserveGas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSystemReserveGas.Decode(byteArray, ref p);
            GrGasAvailable = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrGasAvailable.Decode(byteArray, ref p);
            GrMessageId = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrMessageId.Decode(byteArray, ref p);
            GrProgramId = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrProgramId.Decode(byteArray, ref p);
            GrSource = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSource.Decode(byteArray, ref p);
            GrValue = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrValue.Decode(byteArray, ref p);
            GrValueAvailable = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrValueAvailable.Decode(byteArray, ref p);
            GrSize = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSize.Decode(byteArray, ref p);
            GrRead = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrRead.Decode(byteArray, ref p);
            GrReadPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReadPerByte.Decode(byteArray, ref p);
            GrEnvVars = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrEnvVars.Decode(byteArray, ref p);
            GrBlockHeight = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrBlockHeight.Decode(byteArray, ref p);
            GrBlockTimestamp = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrBlockTimestamp.Decode(byteArray, ref p);
            GrRandom = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrRandom.Decode(byteArray, ref p);
            GrReplyDeposit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyDeposit.Decode(byteArray, ref p);
            GrSend = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSend.Decode(byteArray, ref p);
            GrSendPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendPerByte.Decode(byteArray, ref p);
            GrSendWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendWgas.Decode(byteArray, ref p);
            GrSendWgasPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendWgasPerByte.Decode(byteArray, ref p);
            GrSendInit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendInit.Decode(byteArray, ref p);
            GrSendPush = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendPush.Decode(byteArray, ref p);
            GrSendPushPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendPushPerByte.Decode(byteArray, ref p);
            GrSendCommit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendCommit.Decode(byteArray, ref p);
            GrSendCommitWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendCommitWgas.Decode(byteArray, ref p);
            GrReservationSend = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationSend.Decode(byteArray, ref p);
            GrReservationSendPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationSendPerByte.Decode(byteArray, ref p);
            GrReservationSendCommit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationSendCommit.Decode(byteArray, ref p);
            GrReplyCommit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyCommit.Decode(byteArray, ref p);
            GrReplyCommitWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyCommitWgas.Decode(byteArray, ref p);
            GrReservationReply = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationReply.Decode(byteArray, ref p);
            GrReservationReplyPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationReplyPerByte.Decode(byteArray, ref p);
            GrReservationReplyCommit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReservationReplyCommit.Decode(byteArray, ref p);
            GrReplyPush = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyPush.Decode(byteArray, ref p);
            GrReply = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReply.Decode(byteArray, ref p);
            GrReplyPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyPerByte.Decode(byteArray, ref p);
            GrReplyWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyWgas.Decode(byteArray, ref p);
            GrReplyWgasPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyWgasPerByte.Decode(byteArray, ref p);
            GrReplyPushPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyPushPerByte.Decode(byteArray, ref p);
            GrReplyTo = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyTo.Decode(byteArray, ref p);
            GrSignalCode = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSignalCode.Decode(byteArray, ref p);
            GrSignalFrom = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSignalFrom.Decode(byteArray, ref p);
            GrReplyInput = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyInput.Decode(byteArray, ref p);
            GrReplyInputWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyInputWgas.Decode(byteArray, ref p);
            GrReplyPushInput = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyPushInput.Decode(byteArray, ref p);
            GrReplyPushInputPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyPushInputPerByte.Decode(byteArray, ref p);
            GrSendInput = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendInput.Decode(byteArray, ref p);
            GrSendInputWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendInputWgas.Decode(byteArray, ref p);
            GrSendPushInput = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendPushInput.Decode(byteArray, ref p);
            GrSendPushInputPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrSendPushInputPerByte.Decode(byteArray, ref p);
            GrDebug = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrDebug.Decode(byteArray, ref p);
            GrDebugPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrDebugPerByte.Decode(byteArray, ref p);
            GrReplyCode = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrReplyCode.Decode(byteArray, ref p);
            GrExit = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrExit.Decode(byteArray, ref p);
            GrLeave = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrLeave.Decode(byteArray, ref p);
            GrWait = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrWait.Decode(byteArray, ref p);
            GrWaitFor = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrWaitFor.Decode(byteArray, ref p);
            GrWaitUpTo = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrWaitUpTo.Decode(byteArray, ref p);
            GrWake = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrWake.Decode(byteArray, ref p);
            GrCreateProgram = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgram.Decode(byteArray, ref p);
            GrCreateProgramPayloadPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgramPayloadPerByte.Decode(byteArray, ref p);
            GrCreateProgramSaltPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgramSaltPerByte.Decode(byteArray, ref p);
            GrCreateProgramWgas = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgramWgas.Decode(byteArray, ref p);
            GrCreateProgramWgasPayloadPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgramWgasPayloadPerByte.Decode(byteArray, ref p);
            GrCreateProgramWgasSaltPerByte = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            GrCreateProgramWgasSaltPerByte.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
