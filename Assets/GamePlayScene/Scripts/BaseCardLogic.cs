using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCardLogic : MonoBehaviour
{
    private int _baseCardPower;
    private int _currentCardPower;
    private string _cardTag;
    private string _cardText;

    private void ButtleCry()
    {
        // отослать команды на метод FindSomeCard

    }
    private void Attack ()
    {
        //Найти тег карты находящейся на одной локации с текущей картой 
        //Найти карту на сцене на этой локации 
        //Построить конечную точку анимации атаки
    }
    private void Death()
    {
        // После завершения хода, если ХП карты меньше 0 убрать карту с локации по тегу и сместить все карты на локации для удобного отображения пользователю
        string cmd = "SELECT WhereInGame FROM CharactersInGame WHERE Name='"+this.gameObject.name+"'";
        //Translater translater =new Translater();
    }
    private void FindSomeCard(string cmd)
    {

    }

}
