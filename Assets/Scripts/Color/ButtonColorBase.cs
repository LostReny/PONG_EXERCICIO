using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ButtonColorBase : MonoBehaviour
{
   public Color color;

   [Header ("Reference")]
   public Image uiImage;

   public void OnValidate() {
    uiImage = GetComponent<Image>();
   }

   public void Start() {
     uiImage.color = color;
   }

   public void OnClick(){
    
   }
}
