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


namespace Substrate.Gear.Api.Generated.Model.pallet_proxy.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> proxy
        /// Dispatch the given `call` from an account that the sender is authorised for through
        /// `add_proxy`.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `real`: The account that the proxy will make a call on behalf of.
        /// - `force_proxy_type`: Specify the exact proxy type to be used and checked for this call.
        /// - `call`: The call to be made by the `real` account.
        /// </summary>
        proxy = 0,
        
        /// <summary>
        /// >> add_proxy
        /// Register a proxy account for the sender that is able to make calls on its behalf.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `proxy`: The account that the `caller` would like to make a proxy.
        /// - `proxy_type`: The permissions allowed for this proxy account.
        /// - `delay`: The announcement period required of the initial proxy. Will generally be
        /// zero.
        /// </summary>
        add_proxy = 1,
        
        /// <summary>
        /// >> remove_proxy
        /// Unregister a proxy account for the sender.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `proxy`: The account that the `caller` would like to remove as a proxy.
        /// - `proxy_type`: The permissions currently enabled for the removed proxy account.
        /// </summary>
        remove_proxy = 2,
        
        /// <summary>
        /// >> remove_proxies
        /// Unregister all proxy accounts for the sender.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// WARNING: This may be called on accounts created by `pure`, however if done, then
        /// the unreserved fees will be inaccessible. **All access to this account will be lost.**
        /// </summary>
        remove_proxies = 3,
        
        /// <summary>
        /// >> create_pure
        /// Spawn a fresh new account that is guaranteed to be otherwise inaccessible, and
        /// initialize it with a proxy of `proxy_type` for `origin` sender.
        /// 
        /// Requires a `Signed` origin.
        /// 
        /// - `proxy_type`: The type of the proxy that the sender will be registered as over the
        /// new account. This will almost always be the most permissive `ProxyType` possible to
        /// allow for maximum flexibility.
        /// - `index`: A disambiguation index, in case this is called multiple times in the same
        /// transaction (e.g. with `utility::batch`). Unless you're using `batch` you probably just
        /// want to use `0`.
        /// - `delay`: The announcement period required of the initial proxy. Will generally be
        /// zero.
        /// 
        /// Fails with `Duplicate` if this has already been called in this transaction, from the
        /// same sender, with the same parameters.
        /// 
        /// Fails if there are insufficient funds to pay for deposit.
        /// </summary>
        create_pure = 4,
        
        /// <summary>
        /// >> kill_pure
        /// Removes a previously spawned pure proxy.
        /// 
        /// WARNING: **All access to this account will be lost.** Any funds held in it will be
        /// inaccessible.
        /// 
        /// Requires a `Signed` origin, and the sender account must have been created by a call to
        /// `pure` with corresponding parameters.
        /// 
        /// - `spawner`: The account that originally called `pure` to create this account.
        /// - `index`: The disambiguation index originally passed to `pure`. Probably `0`.
        /// - `proxy_type`: The proxy type originally passed to `pure`.
        /// - `height`: The height of the chain when the call to `pure` was processed.
        /// - `ext_index`: The extrinsic index in which the call to `pure` was processed.
        /// 
        /// Fails with `NoPermission` in case the caller is not a previously created pure
        /// account whose `pure` call has corresponding parameters.
        /// </summary>
        kill_pure = 5,
        
        /// <summary>
        /// >> announce
        /// Publish the hash of a proxy-call that will be made in the future.
        /// 
        /// This must be called some number of blocks before the corresponding `proxy` is attempted
        /// if the delay associated with the proxy relationship is greater than zero.
        /// 
        /// No more than `MaxPending` announcements may be made at any one time.
        /// 
        /// This will take a deposit of `AnnouncementDepositFactor` as well as
        /// `AnnouncementDepositBase` if there are no other pending announcements.
        /// 
        /// The dispatch origin for this call must be _Signed_ and a proxy of `real`.
        /// 
        /// Parameters:
        /// - `real`: The account that the proxy will make a call on behalf of.
        /// - `call_hash`: The hash of the call to be made by the `real` account.
        /// </summary>
        announce = 6,
        
        /// <summary>
        /// >> remove_announcement
        /// Remove a given announcement.
        /// 
        /// May be called by a proxy account to remove a call they previously announced and return
        /// the deposit.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `real`: The account that the proxy will make a call on behalf of.
        /// - `call_hash`: The hash of the call to be made by the `real` account.
        /// </summary>
        remove_announcement = 7,
        
        /// <summary>
        /// >> reject_announcement
        /// Remove the given announcement of a delegate.
        /// 
        /// May be called by a target (proxied) account to remove a call that one of their delegates
        /// (`delegate`) has announced they want to execute. The deposit is returned.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `delegate`: The account that previously announced the call.
        /// - `call_hash`: The hash of the call to be made.
        /// </summary>
        reject_announcement = 8,
        
        /// <summary>
        /// >> proxy_announced
        /// Dispatch the given `call` from an account that the sender is authorized for through
        /// `add_proxy`.
        /// 
        /// Removes any corresponding announcement(s).
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `real`: The account that the proxy will make a call on behalf of.
        /// - `force_proxy_type`: Specify the exact proxy type to be used and checked for this call.
        /// - `call`: The call to be made by the `real` account.
        /// </summary>
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 188 - Variant[pallet_proxy.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType>, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumRuntimeCall>>(Call.proxy);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.add_proxy);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.remove_proxy);
				AddTypeDecoder<BaseVoid>(Call.remove_proxies);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>>(Call.create_pure);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.kill_pure);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.primitive_types.H256>>(Call.announce);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.primitive_types.H256>>(Call.remove_announcement);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.primitive_types.H256>>(Call.reject_announcement);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.vara_runtime.EnumProxyType>, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumRuntimeCall>>(Call.proxy_announced);
        }
    }
}
