using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnetToServer : MonoBehaviourPunCallbacks
{
   
    void Start()
    {
        //conectarse al servidor
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("CONECTANDO AL SERVIDOR");
    }

    //Cuando estemos conectado al servidor todo el codigo que este en esta funcion se ejecutara
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    //Este metodo nos conectamos a la scene the game
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

}
