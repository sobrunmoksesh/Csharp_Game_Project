using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public PlayerController playerController;

    void OnTriggerEnter()
    {
        playerController.CompleteLevel();
        
    }
	
}
