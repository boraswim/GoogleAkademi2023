using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;
using UnityEngine.UI;

public class GetLobby : MonoBehaviour
{
    public GameObject buttonPrefab;
    public GameObject buttonContainer;
    // Start is called before the first frame update
    async void Start()
    {
        await UnityServices.InitializeAsync();
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    public async void GetLobbiesTest()
    {
        ClearContainer();
        try
        {
            QueryLobbiesOptions options = new();
            Debug.LogWarning("QueryLobbiesTest");
            
            options.Count = 25;

            options.Filters = new List<QueryFilter>()
            {
                new QueryFilter(QueryFilter.FieldOptions.AvailableSlots, "0", QueryFilter.OpOptions.GT),
            };

            options.Order = new List<QueryOrder>()
            {
                new QueryOrder(true, QueryOrder.FieldOptions.Created)
            };

            /*
            options.Count = 25;
            options.Filters = new List<QueryFilter>()
            {
                new QueryFilter
                (
                    field: QueryFilter.FieldOptions.AvailableSlots,
                    op: QueryFilter.OpOptions.GT,
                    value: "0"
                )
            };

            options.Order = new List<QueryOrder>()
            {
                new QueryOrder
                (
                    asc: false,
                    field: QueryOrder.FieldOptions.Created
                )
            };
            */

            QueryResponse lobbies = await Lobbies.Instance.QueryLobbiesAsync(options);
            Debug.LogWarning("Get Lobbies Done COUNT: " + lobbies.Results.Count);

            foreach (Lobby foundLobby in lobbies.Results)
            {
                LobbyStatic.LogLobby(foundLobby);
                CreateLobbyButton(foundLobby);
            }

            // GetComponent<JoinLobby>().JoinLobbyWithID(lobbies.Results[0].Id);

        }
        catch (LobbyServiceException e)
        {
            Debug.LogError(e);
        }
    }

    private void CreateLobbyButton(Lobby lobby)
    {
        var button = Instantiate(buttonPrefab, Vector3.zero, Quaternion.identity);
        button.name = lobby.Name + "_Button";
        button.GetComponentInChildren<TextMeshProUGUI>().text = lobby.Name;
        var rectTransform = button.GetComponent<RectTransform>();
        rectTransform.SetParent(buttonContainer.transform);
        button.GetComponent<Button>().onClick.AddListener(delegate() {Lobby_OnClick(lobby);});
    }

    public void Lobby_OnClick(Lobby lobby)
    {
        Debug.Log("Clicked lobby: " + lobby.Name);
        GetComponent<JoinLobby>().JoinLobbyWithID(lobby.Id);
    }

    private void ClearContainer()
    {
        if(buttonContainer is not null && buttonContainer.transform.childCount > 0)
        {
            foreach(Transform variable in buttonContainer.transform)
            Destroy(variable.gameObject);
        }
    }
}
