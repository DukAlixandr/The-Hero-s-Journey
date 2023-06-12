using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationScript : MonoBehaviour
{
     private List<GameObject> _playerCardsOnLOcation1 = new List<GameObject> ();
     public static string CardAddToLoсaction;
     
     private void OnMouseEnter() {
          Debug.Log("123");
          if (_playerCardsOnLOcation1.Count<=4){
               CardAddToLoсaction=this.gameObject.name;
               
          }
        
     }
     private void OnMouseExit() {
          
     }
   

}
