using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class Translater : MonoBehaviour
{

  public  SqliteConnection dbConnection;
  private string path;
  public static string Language ="DiscriptionEng";

  public string ReturnerSomeTextFromDB(string i)
  {
    Debug.Log(i);
     path = Application.dataPath + "/DataBase/MainDB.db";
     dbConnection = new SqliteConnection("URI=file:" + path);
     dbConnection.Open();
     SqliteCommand cmd = new SqliteCommand();
     cmd.CommandText=i;
     cmd.Connection = dbConnection;
     SqliteDataReader r = cmd.ExecuteReader();
     while (r.Read())
     i=String.Format("{0}  ", r[0]);
     return i;
  }
}
