using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Authentication;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopulateUI : MonoBehaviour
{
    public TextMeshProUGUI lobbyName;
    public TextMeshProUGUI lobbyCode;
    public TextMeshProUGUI lobbyGameMode;
    public TMP_InputField newName;
    public TMP_InputField newPlayerLevel;
    public GameObject playerInfoContainer;
    public GameObject playerInfoPrefab;
    private CurrentLobby _currentLobby;
    // Start is called before the first frame update
    void Start()
    {
        _currentLobby = GameObject.Find("LobbyManager").GetComponent<CurrentLobby>();
        PopulateUIElements();
        InvokeRepeating(nameof(PollForLobbyUpdate), 1.1f, 3f);
        LobbyStatic.LogPlayersInLobby(_currentLobby.currentLobby);
    }

    void PopulateUIElements()
    {
        lobbyName.text = _currentLobby.currentLobby.Name;
        lobbyCode.text = _currentLobby.currentLobby.LobbyCode;
        lobbyGameMode.text = _currentLobby.currentLobby.Data["GameMode"].Value;
        ClearContainer();
        foreach(Player player in _currentLobby.currentLobby.Players)
        {
            CreatePlayerInfoCard(player);
        }
    }

    void CreatePlayerInfoCard(Player player)
    {
        var text = Instantiate(playerInfoPrefab, Vector3.zero, Quaternion.identity);
        text.name = player.Joined.ToShortTimeString();
        text.GetComponent<TextMeshProUGUI>().text = player.Id + ":" + player.Data["PlayerLevel"].Value;
        var rectTransform = text.GetComponent<RectTransform>();
        rectTransform.SetParent(playerInfoContainer.transform, false);
    }
    
        private void ClearContainer()
    {
        if(playerInfoContainer is not null && playerInfoContainer.transform.childCount > 0)
        {
            foreach(Transform variable in playerInfoContainer.transform)
            Destroy(variable.gameObject);
        }
    }


    async void PollForLobbyUpdate()
    {
        _currentLobby.currentLobby = await LobbyService.Instance.GetLobbyAsync(_currentLobby.currentLobby.Id);
        PopulateUIElements(); 
    }

    // Button events
    public async void ChangeLobbyName()
    {
        var newLobbyName = newName.text;
        try
        {
            UpdateLobbyOptions options = new UpdateLobbyOptions();
            options.Name = newLobbyName;
            _currentLobby.currentLobby = await Lobbies.Instance.UpdateLobbyAsync(_currentLobby.currentLobby.Id, options);
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e);
        }
    }

        public async void ChangePlayerName()
    {
        var playerLevel = newPlayerLevel.text;
        try
        {
            UpdatePlayerOptions options = new UpdatePlayerOptions();
            options.Data = new Dictionary<string, PlayerDataObject>()
            {
                {"PlayerLevel", new PlayerDataObject(PlayerDataObject.VisibilityOptions.Public, playerLevel)}
            };
            await LobbyService.Instance.UpdatePlayerAsync(_currentLobby.currentLobby.Id, AuthenticationService.Instance.PlayerId, options);
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e);
        }
    }
}
