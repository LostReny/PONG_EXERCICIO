using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    //variables
    public float speed = 10f;

    [Header("Key Setup")]
    public KeyCode KeyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode KeyCodeMoveDown = KeyCode.DownArrow;

    [Header("Points")]
    public int currentPoints;

    [Header("Rigdbody")]
    public Rigidbody2D myRigid;

    [Header("TextPoints")]
    public TextMeshProUGUI uiTextPoints;

    void Update() {
        if(Input.GetKey(KeyCodeMoveUp)){
            myRigid.MovePosition(transform.position + transform.up * speed);
        }
        else if(Input.GetKey(KeyCodeMoveDown)){
            myRigid.MovePosition(transform.position + transform.up * speed * -1);
        }
    }

    public void AddPoint(){
        currentPoints ++;
        UpdateUi();
    }

    public void ResetPlayer(){
        currentPoints = 0;
        UpdateUi();
    }

    private void Awake() {
        ResetPlayer();
    }

    private void UpdateUi(){
        uiTextPoints.text = currentPoints.ToString();
    }
}
