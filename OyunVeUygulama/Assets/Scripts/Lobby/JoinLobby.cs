using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Authentication;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class JoinLobby : MonoBehaviour
{
    public TMP_InputField inputField;
    
    public async void JoinLobbyWithCode()
    {
        var codeString = inputField.text;
        try
        {
            JoinLobbyByCodeOptions options = new JoinLobbyByCodeOptions();
            options.Player = new Player(AuthenticationService.Instance.PlayerId);
            options.Player.Data = new Dictionary<string, PlayerDataObject>()
            {
                {"PlayerLevel", new PlayerDataObject(PlayerDataObject.VisibilityOptions.Public, "8")}
            };

            Lobby lobby = await LobbyService.Instance.JoinLobbyByCodeAsync(codeString, options);
            Debug.Log("Joined lobby with code: " + codeString);
            DontDestroyOnLoad(this);
            GetComponent<CurrentLobby>().currentLobby = lobby;
            LobbyStatic.LogPlayersInLobby(lobby);
            LobbyStatic.LoadLobbyRoom();
        }
        catch (LobbyServiceException e)
        {
            Debug.LogException(e);
        }

    }

        public async void JoinLobbyWithID(string lobbyID)
    {
        try
        {
            JoinLobbyByIdOptions options = new JoinLobbyByIdOptions();
            options.Player = new Player(AuthenticationService.Instance.PlayerId);
            options.Player.Data = new Dictionary<string, PlayerDataObject>()
            {
                {"PlayerLevel", new PlayerDataObject(PlayerDataObject.VisibilityOptions.Public, "8")}
            };
            Lobby lobby = await LobbyService.Instance.JoinLobbyByIdAsync(lobbyID, options);
            Debug.Log("Joined lobby with ID: " + lobbyID);
            Debug.LogWarning("Lobby Code: " + lobby.LobbyCode);
            DontDestroyOnLoad(this);
            GetComponent<CurrentLobby>().currentLobby = lobby;
            LobbyStatic.LogPlayersInLobby(lobby);
            LobbyStatic.LoadLobbyRoom();
        }
        catch (LobbyServiceException e)
        {
            Debug.LogException(e);
        }
    }

    public async void QuickJoinMethod()
    {
        try
        {
            Lobby lobby = await LobbyService.Instance.QuickJoinLobbyAsync();
            DontDestroyOnLoad(this);
            GetComponent<CurrentLobby>().currentLobby = lobby;
            Debug.Log("Joined lobby with Quick Join: " + lobby.Id);
            Debug.LogWarning("Lobby Code: " + lobby.LobbyCode);
            LobbyStatic.LoadLobbyRoom();
        }
        catch (LobbyServiceException e)
        {
            Debug.LogError(e);
        }
    }
}
