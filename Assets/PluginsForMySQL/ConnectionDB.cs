using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class ConnectionDB : MonoBehaviour
{
    public  SqliteConnection dbConnection;
    private string path;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setConnection(){
        path = Application.dataPath + "/DataBase/MainDB.db";
        dbConnection = new SqliteConnection("URI=file:" + path);
        dbConnection.Open();
        if (dbConnection.State == ConnectionState.Open){
             SqliteCommand cmd = new SqliteCommand();
             cmd.Connection = dbConnection;
             //cmd.CommandText = "INSERT INTO CharactersInGame (name, WhereInGame) VALUES ('Tom', 39)";
             //cmd.CommandText = "SELECT "+this.gameObject.name+", FROM CharactersInGame";
             cmd.CommandText = "SELECT "+this.gameObject.name+" FROM CharactersInGame";
             //cmd.CommandText = "SELECT * FROM CharactersInGame";
             SqliteDataReader r = cmd.ExecuteReader();
             while (r.Read())
            Debug.Log (String.Format("{0} {1} ", r[0], r[1]));
        }
        else{Debug.Log("Error Connection");}
    }

}
