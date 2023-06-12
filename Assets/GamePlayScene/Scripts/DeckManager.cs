using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class DeckManager : MonoBehaviour
{
    [SerializeField] private GameObject [] _deck = new GameObject [8];
    [SerializeField] private List<GameObject> _hand = new List<GameObject> ();
    [SerializeField] private GameObject _handObject;
    
    
private void StartGame()
 {
     for (int i=0; i==_deck.Length; i++)
     {
        Random randNum=new Random();
        int j = randNum.Next(i + 1);
        var temp = _deck[j];
        _deck[j] = _deck[i];
        _deck[i] = temp;

     }
 }
 private void Start() {
    for (int i=0; i<_deck.Length; i++)
     {
        Random randNum=new Random();
        int j = randNum.Next(i + 1);
        var temp = _deck[j];
        _deck[j] = _deck[i];
        _deck[i] = temp;  
     }
     for(int i=0; i<3; i++)
    {
        _hand.Add(_deck[i]);
        AddSomeCadsToPlayerHand(i);
        _deck[i]=null;
    }
    }
    private void AddSomeCadsToPlayerHand(int i)
    {
      _hand[i].transform.position= new Vector3 (0f,0f,0f);
      Instantiate( _hand[i], new Vector3(-1.5f+(i*1.5f), -3.6f, 90), Quaternion.identity, _handObject.transform);
    }
}

