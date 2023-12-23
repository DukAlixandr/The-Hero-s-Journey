using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
      public static int _turnCounter;
      private static int _playerHP;
      private static int _enemyHP;
      private void StartGame()
      {
          Fillplayerhand();
          //заполнить таблицу ingamecharacters
          //заполнить List GameObject карт в руке и карт в колоде
          //создать карты в руке из префабов и создать GO колоды 
      }
      private void Fillplayerhand(){
          
      }
      private void EndTurn()
      {
            EnemyCardPlace();
            // из таблицы ingamecharacters отобрать все карты наход на 1 и 2 локации для игрока и энеми, сформировать лист массив из этих карт, чтобы у каждой карты проигрался боевой клич
            // После того, как проиграются боевыве кличи всех карт, обновить информацию в таблице ingamecharacters
            CardsAttack();
            
            


      }

      private void EnemyCardPlace()
      {

      }
      private void CardsAttack()
      {
            if(_turnCounter!=0){
                  // Если это не первый ход, то провести Атаку карт следующим образом:
                  // 1. Сформировать Лист массив карт, используя теги, которым нужно атаковать, взять информацию из таблицы ingamecharacters
                  // 2. После того, как каждая карта из массива атакует, изменить информацию о Силе карты и о ее местонахождении
            }

      }
}
