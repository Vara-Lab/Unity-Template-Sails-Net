using System;
using Substrate.NetApi;
using Substrate.NetApi.Model.Types;

public static class AccountService
{
    /// <summary>
    /// Genera una cuenta Substrate (sr25519) a partir de una semilla en formato hexadecimal.
    /// </summary>
    /// <param name="hexSeed">Semilla en formato hex de 32 bytes (ej: "0xe5be...").</param>
    /// <returns>Un objeto Account con llaves sr25519.</returns>
    public static Account GenerateAccount(string hexSeed)
    {
        // Convertir la semilla hex a un arreglo de bytes
        var seedBytes = Utils.HexToByteArray(hexSeed);
        if (seedBytes == null || seedBytes.Length != 32)
        {
            throw new ArgumentException("La semilla hex no es válida. Se requieren exactamente 32 bytes.");
        }

        // Crear la cuenta directamente desde la semilla con llaves sr25519
        return Account.FromSeed(KeyType.Sr25519, seedBytes);
    }
}
