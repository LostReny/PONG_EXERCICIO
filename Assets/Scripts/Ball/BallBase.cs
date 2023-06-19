using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    [Header("Ball speed")]
    public Vector3 speed = new Vector3(1,1,0);

    public string tagToCheck = "myPlayer";

    [Header("Random")]
    public Vector2 randSpeedY = new Vector2(1,3);
    public Vector2 randSpeedX = new Vector2(1,3);


    // movimento de inversão quando a bola toca em uma colisão
    public void OnCollisionEnter2D(Collision2D collision) {
      if(collision.gameObject.tag == tagToCheck){
        OnPlayerCollision();
      }
      else {
        speed.y = speed.y * -1;
      }
    
    }

    public void OnPlayerCollision(){
        speed.x = speed.x *-1;

        float rand= Random.Range(randSpeedX.x, randSpeedX.y);
            
            if(speed.x < 0)
            rand = -rand;

            speed.x = rand;

        rand= Random.Range(randSpeedY.x, randSpeedX.y);
        speed.y = rand;
    }

    void Update()
    {
       transform.Translate(speed);
    }
}
