using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables
    public float speed = 10f;

    [Header("Key Setup")]
    public KeyCode KeyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode KeyCodeMoveDown = KeyCode.DownArrow;

    [Header("Rigdbody")]
    public Rigidbody2D myRigid; 

    void Update() {
        if(Input.GetKey(KeyCodeMoveUp)){
            myRigid.MovePosition(transform.position + transform.up * speed);
        }
        else if(Input.GetKey(KeyCodeMoveDown)){
            myRigid.MovePosition(transform.position + transform.up * speed * -1);
        }
    }
}
