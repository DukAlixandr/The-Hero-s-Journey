using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationScript : MonoBehaviour
{
     private List<GameObject> _playerCardsOnLOcation1 = new List<GameObject> ();
     private List<GameObject> _playerCardsOnLOcation2 = new List<GameObject> ();
     public float [,] _location1positions = new float [3,3];
     public static readonly Vector2 [] CardsPositionLocation1 = new Vector2 [4] {new Vector2(-160,200),new Vector2 (160,200),new Vector2(-160,-195),new Vector2 (160,-195)};
     public static string CardAddToLoсaction;

     
     private void OnMouseEnter() {
          if (_playerCardsOnLOcation1.Count<=4 ||  _playerCardsOnLOcation2.Count<=4){
               CardAddToLoсaction=this.gameObject.name;
               
          }
        
     }
     private void OnMouseExit() {
       CardAddToLoсaction=0.ToString();
          
     }
   

}
