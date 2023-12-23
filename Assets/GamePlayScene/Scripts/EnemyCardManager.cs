using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using Random = System.Random;

public class EnemyCardManager : MonoBehaviour
{
    [SerializeField] private GameObject [] _enemydeck = new GameObject [8];
    private List<GameObject> _enemyhand = new List<GameObject> ();
    [SerializeField] private GameObject _enemyhandObject;
    public  SqliteConnection dbConnection;
    private string path;
    private string [] _enemyDeck= new string [8];
    private string _currentBoss = "Larry"; // получить из предыдущей сцены, заменить при старте
    
   private void Start() 
    {
      FillDeckFromSQL();
      ShuffleCards();
    }
    private void AddSomeCadsToPlayerHand(int i)
    {
      //_enemyhand[i].transform.position= new Vector3 (0f,0f,0f);
      Instantiate( _enemyhand[i], new Vector3(-1.5f+(i*1.5f), 5.2f, 90), Quaternion.identity, _enemyhandObject.transform);
    }
    private void ShuffleCards(){
     for (int i=0; i<_enemydeck.Length; i++)
    {
        Random randNum=new Random();
        int j = randNum.Next(i + 1);
        var temp = _enemydeck[j];
        _enemydeck[j] = _enemydeck[i];
        _enemydeck[i] = temp;  
    }
     for(int i=0; i<3; i++)
    {
        _enemyhand.Add(_enemydeck[i]);
        AddSomeCadsToPlayerHand(i);
        _enemydeck[i]=null;
    }
    }
    private void FillDeckFromSQL()
    {
     path = Application.dataPath + "/DataBase/MainDB.db";
     dbConnection = new SqliteConnection("URI=file:" + path);
     dbConnection.Open();
     SqliteCommand cmd = new SqliteCommand();
     cmd.CommandText="SELECT "+_currentBoss+" FROM EnemyBots ;";
     cmd.Connection = dbConnection;
     SqliteDataReader r = cmd.ExecuteReader();
     for(int i=0; i<8; i++)
     {
        r.Read();
        _enemyDeck[i]=r.GetString(0);
        _enemydeck[i]=GameObject.FindGameObjectWithTag(_enemyDeck[i]);
     }
    }


}

