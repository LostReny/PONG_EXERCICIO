using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeName : MonoBehaviour
{
    [Header("ChangeName")]
    public TextMeshProUGUI UITextMeshPro;
    public TMP_InputField inputField;
    public GameObject changeNameInput;
    
    private string playerName;

    public void ChangePlayerName(){
        playerName = inputField.text;
        UITextMeshPro.text = playerName;
        changeNameInput.SetActive(false);
    }

}
