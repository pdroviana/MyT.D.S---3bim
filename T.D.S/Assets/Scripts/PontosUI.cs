using UnityEngine;
using TMPro;

public class PontosUI : MonoBehaviour
{
   public TMP_Text pontosText;


   void Update()
   {
      pontosText.text = "Pontos: " + PontosManager.pontos;
   }
}