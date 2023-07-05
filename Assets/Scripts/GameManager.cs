using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public BallBase ballBase;

   public static GameManager Instantiate;

    public void ResetBallPositon(){
        ballBase.ResetBall();
    }

    public void Awake() {
        Instantiate = this;
    }

    public void StartGame(){
      ballBase.CanMove(true);
   }
}
