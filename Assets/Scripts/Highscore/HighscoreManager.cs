using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreManager : MonoBehaviour
{

    public static HighscoreManager Instantiate;

    public string keyToSafe = "keyHighscore";

    [Header("References")]
    public TextMeshProUGUI UITextMeshPro;

     public void Awake() {
        Instantiate = this;
    }

    private void OnEnable() {
        UpdateText();
    }

    private void UpdateText(){
     UITextMeshPro.text = PlayerPrefs.GetString(keyToSafe, "sem highscore");

    }

    public void SavePlayerWin(Player p){
        if(p.playerName == "") return;
        PlayerPrefs.SetString(keyToSafe, p.playerName);
        UpdateText();
    }
}
