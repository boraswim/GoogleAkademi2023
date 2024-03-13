using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Authentication;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;
using UnityEngine.UI;

public class CreateLobby : MonoBehaviour
{
    public TMP_InputField lobbyNameInput;
    public TMP_InputField lobbyCode;
    public TMP_Dropdown maxPlayersDropdown;
    public TMP_Dropdown gameModeDropdown;
    public Toggle isLobbyPrivate;
    // Start is called before the first frame update

    public async void CreateLobbyMethod()
    {
        string lobbyName = lobbyNameInput.text;
        int maxPlayers = Convert.ToInt32(maxPlayersDropdown.options[maxPlayersDropdown.value].text);
        CreateLobbyOptions options = new CreateLobbyOptions();
        options.IsPrivate = isLobbyPrivate.isOn;

        // Player Creation
        options.Player = new Player(AuthenticationService.Instance.PlayerId);
        options.Player.Data = new Dictionary<string, PlayerDataObject>()
        {
            {"PlayerLevel", new PlayerDataObject(PlayerDataObject.VisibilityOptions.Public, "5")}
        };

        // Lobby Data

        options.Data = new Dictionary<string, DataObject>()
        {
            {
                "GameMode", new DataObject(DataObject.VisibilityOptions.Public, gameModeDropdown.options[gameModeDropdown.value].text, DataObject.IndexOptions.S1)
            }
        };

        Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
        
        DontDestroyOnLoad(this);
        GetComponent<CurrentLobby>().currentLobby = lobby;
        Debug.Log("Create lobby done");

        LobbyStatic.LogLobby(lobby);
        LobbyStatic.LogPlayersInLobby(lobby);
        lobbyCode.text = lobby.LobbyCode;

        StartCoroutine(HeartBeatLobbyCoroutine(lobby.Id, 15f));

        LobbyStatic.LogPlayersInLobby(lobby);
        LobbyStatic.LoadLobbyRoom();
    }

    IEnumerator HeartBeatLobbyCoroutine(string lobbyID, float waitTimeSeconds)
    {
        var delay = new WaitForSeconds(waitTimeSeconds);
        while(true)
        {
            LobbyService.Instance.SendHeartbeatPingAsync(lobbyID);
            yield return delay;
        }
    }

    void LogPlayersInLobby(Lobby lobby)
    {
        foreach(Player player in lobby.Players)
        {
            Debug.Log("Player ID= " + player.Id);
        }
    }

}
