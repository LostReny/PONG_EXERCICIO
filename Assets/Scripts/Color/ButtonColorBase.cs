using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ButtonColorBase : MonoBehaviour
{
   public Color color;
   public Player myPlayer;

   [Header ("Reference")]
   public Image uiImage;

   public void OnValidate() {
    uiImage = GetComponent<Image>();
   }

   public void Start() {
     uiImage.color = color;
   }

   public void OnClick(){
    myPlayer.ChangeColor(color);
   }
}
