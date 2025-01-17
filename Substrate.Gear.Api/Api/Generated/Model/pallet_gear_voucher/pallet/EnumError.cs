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


namespace Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> BadOrigin
        /// The origin is not eligible to execute call.
        /// </summary>
        BadOrigin = 0,
        
        /// <summary>
        /// >> BalanceTransfer
        /// Error trying transfer balance to/from voucher account.
        /// </summary>
        BalanceTransfer = 1,
        
        /// <summary>
        /// >> InappropriateDestination
        /// Destination program is not in whitelisted set for voucher.
        /// </summary>
        InappropriateDestination = 2,
        
        /// <summary>
        /// >> InexistentVoucher
        /// Voucher with given identifier doesn't exist for given spender id.
        /// </summary>
        InexistentVoucher = 3,
        
        /// <summary>
        /// >> IrrevocableYet
        /// Voucher still valid and couldn't be revoked.
        /// </summary>
        IrrevocableYet = 4,
        
        /// <summary>
        /// >> MaxProgramsLimitExceeded
        /// Try to whitelist more programs than allowed.
        /// </summary>
        MaxProgramsLimitExceeded = 5,
        
        /// <summary>
        /// >> UnknownDestination
        /// Failed to query destination of the prepaid call.
        /// </summary>
        UnknownDestination = 6,
        
        /// <summary>
        /// >> VoucherExpired
        /// Voucher has expired and couldn't be used.
        /// </summary>
        VoucherExpired = 7,
        
        /// <summary>
        /// >> DurationOutOfBounds
        /// Voucher issue/prolongation duration out of [min; max] constants.
        /// </summary>
        DurationOutOfBounds = 8,
        
        /// <summary>
        /// >> CodeUploadingEnabled
        /// Voucher update function tries to cut voucher ability of code upload.
        /// </summary>
        CodeUploadingEnabled = 9,
        
        /// <summary>
        /// >> CodeUploadingDisabled
        /// Voucher is disabled for code uploading, but requested.
        /// </summary>
        CodeUploadingDisabled = 10,
    }
    
    /// <summary>
    /// >> 638 - Variant[pallet_gear_voucher.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
