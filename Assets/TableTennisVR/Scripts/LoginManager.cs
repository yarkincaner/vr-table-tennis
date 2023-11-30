using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class LoginManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConnectToPhoton()
    {
        PhotonNetwork.NickName = " Deneme" + Random.Range(0, 10000);
        PhotonNetwork.ConnectUsingSettings();
    }
    // # Photon Callback Methods
    public override void OnConnected()
    {
        Debug.Log("OnConnected is called. The server is available!");
    }
    // # this callback method is called when the user is 
    // successfully connected to the Photon server. 
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master server- Nickname: " + PhotonNetwork.NickName);
        PhotonNetwork.JoinLobby();

        var foundCanvasObjects = FindObjectsOfType<TextMeshProUGUI>();
        if (foundCanvasObjects != null)
        {
            Debug.Log("TextMeshProUGUI Object lists: " + foundCanvasObjects.Length);
            foreach (TextMeshProUGUI g in foundCanvasObjects)
            {
                if (g.text.Equals("Connect Photon"))
                {
                    g.SetText(PhotonNetwork.NickName);
                }

            }
        }
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Connected to Lobby ");
    }


}















