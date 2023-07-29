using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public BallBase ballBase;

   public float timeToRelease = 1f;

   public StateMachine stateMachine;

   public static GameManager Instantiate;

   [Header ("Menus")]
   public GameObject uiMainMenu;


    public void ResetBall(){
        ballBase.CanMove(false);
        ballBase.ResetBall();
        Invoke(nameof(SetBallFree), timeToRelease);
    }

    private void SetBallFree(){
        ballBase.CanMove(true);

    }


    public void Awake() {
        Instantiate = this;
    }

    public void StartGame(){
      ballBase.CanMove(true);
   }

   public void ShowMainMenu(){
    uiMainMenu.SetActive(true);
    ballBase.CanMove(false);
   }

   public void EndGame(){
    stateMachine.SwitchStates(StateMachine.States.endGame);
   }
}
