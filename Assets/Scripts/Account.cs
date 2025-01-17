
using UnityEngine;

public class AccountExample : MonoBehaviour
{
   
    async void Start()
    {
       
       
        string hexSeed = "0x496f9222372eca011351630ad276c7d44768a593cecea73685299e06acef8c0a";

        // Generar la cuenta a partir de la semilla.
        var aliceAccount = AccountService.GenerateAccount(hexSeed);

         Debug.Log($"Address: {aliceAccount}");

        // Crear una instancia de IRemoting a partir del IRemotingProvider y la cuenta de Alice.
        var remoting = remotingProvider.CreateRemoting(aliceAccount);

        // Crear la instancia de PingPong.
         //var pingPong = new PingPong(remoting);

        // Preparar la llamada "Ping" con el mensaje "ping".
        //ICall<BaseResult<Str, Str>> call = pingPong.Ping((Str)"ping");

        // Enviar el mensaje al programa remoto y obtener un IReply<BaseResult<Str, Str>>.
        //IReply<BaseResult<Str, Str>> reply = await call.MessageAsync(programId, CancellationToken.None);

        // Esperar la respuesta remota.
        //BaseResult<Str, Str> pingReply = await reply.ReceiveAsync(CancellationToken.None);


    }

    void Update()
    {

    }
}
