using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CardManager : MonoBehaviour
{
    private void Attack (GameObject AttackObject){
        AttackObject=GameObject.Find("AttackGameObject");
        //if()
        AttackObject.GetComponent<SortingGroup>().sortingOrder = 100;
        //AttackObject.transform.position = new Vector3 (_playerCardsOnLocation1.Count, _playerCardsOnLocation1.Count, 0);
        this.gameObject.GetComponent<Animation>().Play("AttackAnimation");
        AttackObject.GetComponent<SortingGroup>().sortingOrder = 1;


}
}

