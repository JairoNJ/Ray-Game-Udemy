using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject player;
    [Range(-30,30)]
    public float minX, minY, minZ, maxX, maxY, maxZ;

    private void Start()
    {
        Vector2 randomPostion = new Vector3(Random.Range(minX,maxX), Random.Range(minY, maxY), Random.Range(minZ,maxZ));
        PhotonNetwork.Instantiate(player.name, randomPostion, Quaternion.identity);
    }

}
