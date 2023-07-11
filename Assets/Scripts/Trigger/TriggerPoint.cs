using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    [Header("Tag")]
    public string tagToCheck = "Ball";

    public Player player;


    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.transform.tag == tagToCheck){
            CountPoint();
        }
    }

    private void CountPoint(){
        player.AddPoint();
        StateMachine.Instance.ResetPosition();
    }
}
