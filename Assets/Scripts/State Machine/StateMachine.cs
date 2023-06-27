using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StateMachine : MonoBehaviour
{
    public enum States{
        menu,
        playing,
        resetPosition,
        endGame
    }

    public Dictionary<States, StateBase> DictionaryState;
    private StateBase _currentState;
    public Player player;
    public float timeToStartGame = 1f;


    private void Awake() {
        DictionaryState = new Dictionary<States, StateBase>();
        DictionaryState.Add(States.menu, new StateBase());
        DictionaryState.Add(States.playing, new StateBase());
        DictionaryState.Add(States.resetPosition, new StateBase());
        DictionaryState.Add(States.endGame, new StateBase());
        SwitchStates(States.menu);
    }

    private void Start(){
        SwitchStates(States.menu);
    }
    
    private void SwitchStates(States state)
   {
      if (_currentState != null)
      {
         _currentState.OnStateExit();
      }

      _currentState = DictionaryState[state];
      _currentState.OnStateEnter(player);
   }

   private void Update()
   {
      if (_currentState != null)
      {
         _currentState.OnStateStay();
      }

     /* if (Input.GetKeyDown(KeyCode.Q))
      {
         SwitchStates(States.playing);
      }*/
   }
    
}
