using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class TestServerRPC : NetworkBehaviour
{
    /*
    public override void OnNetworkSpawn()
    {
        if(!IsServer)
        {
            TestServerRpc(0);
        }
    }

    [ClientRpc]
    void TestClientRpc(int value)
    {
        if(IsClient)
        {
            Debug.Log("Client received the RPC #" + value);
            TestServerRpc(value + 1);
        }
    }

    [ServerRpc]
    void TestServerRpc(int value)
    {
        Debug.Log("Server received the RPC #" + value);
        TestClientRpc(value);
    }
    */
}