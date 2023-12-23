using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using Random = System.Random;

public class DeckManager : MonoBehaviour
{
    [SerializeField] private GameObject [] _deck = new GameObject [8];
    private List<GameObject> _hand = new List<GameObject> ();
    [SerializeField] private GameObject _handObject;
    public  SqliteConnection dbConnection;
    private string path;
    private string [] _playerDeck= new string [8];
    
    

 private void Start() 
    {
      FillDeckFromSQL();
      ShuffleCards();
    }
    private void AddSomeCadsToPlayerHand(int i)
    {
      _hand[i].transform.position= new Vector3 (0f,0f,0f);
      Instantiate( _hand[i], new Vector3(-1.5f+(i*1.5f), -3.6f, 90), Quaternion.identity, _handObject.transform);
    }
    private void ShuffleCards(){
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
    private void FillDeckFromSQL()
    {
     path = Application.dataPath + "/DataBase/MainDB.db";
     dbConnection = new SqliteConnection("URI=file:" + path);
     dbConnection.Open();
     SqliteCommand cmd = new SqliteCommand();
     cmd.CommandText="SELECT BaseTag FROM AllCharacters WHERE InPlayerCurrentDeck =1;";
     cmd.Connection = dbConnection;
     SqliteDataReader r = cmd.ExecuteReader();
     for(int i=0; i<8; i++)
     {
        r.Read();
        _playerDeck[i]=r.GetString(0);
        _deck[i]=GameObject.FindGameObjectWithTag(_playerDeck[i]);
     }
    }


}

