using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {

    public PlayerController playerController;

    void OnTriggerEnter()
    {
        playerController.Gameoverlevel();
    }

}
