using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerCardManager : CardManager
{
    private static List<GameObject> _playerCardsOnLocation1 = new List<GameObject> ();
    private static List<GameObject> _playerCardsOnLocation2 = new List<GameObject> ();
    [SerializeField] float moveSpeed = 0.1f;
    private bool CardMovmentActive;
    private Vector3 CardStartPosition;
    private Vector2 mousePosition;

    void Start()
    {
         CardStartPosition = new Vector3 (this.transform.position.x, this.transform.position.y,this.transform.position.z);
    }

    void Update()
    {
        if (CardMovmentActive==true){
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.position = Vector3.Lerp(transform.position, new Vector3 (mousePosition.x, mousePosition.y, 90), moveSpeed);
        }
        
    }
     private void OnMouseDown() {
        CardMovmentActive=true;
        this.gameObject.AddComponent<SortingGroup>(); 
        this.gameObject.GetComponent<SortingGroup>().sortingOrder = 100;
    }

    private void OnMouseUp() {
        CardMovmentActive=false;
        this.transform.position =CardStartPosition;
        Destroy(this.GetComponent<SortingGroup>());
         if(int.Parse(LocationScript.CardAddToLoсaction)==1){
            _playerCardsOnLocation1.Add(this.gameObject);
            this.transform.SetParent(GameObject.FindGameObjectWithTag("Location1").transform); 
            this.transform.localPosition = new Vector3 (LocationScript.CardsPositionLocation1[_playerCardsOnLocation1.Count-1].x,LocationScript.CardsPositionLocation1[_playerCardsOnLocation1.Count-1].y, 90);
            this.transform.localScale =new Vector3(0.7f,0.7f,0f); 
            Destroy(this.GetComponent<BoxCollider2D>());}
         else if(int.Parse(LocationScript.CardAddToLoсaction)==2){
            this.transform.SetParent(GameObject.FindGameObjectWithTag("Location2").transform); 
            _playerCardsOnLocation2.Add(this.gameObject);
            this.transform.localPosition = new Vector3 ((LocationScript.CardsPositionLocation1[_playerCardsOnLocation2.Count-1]).x,LocationScript.CardsPositionLocation1[_playerCardsOnLocation2.Count-1].y, 90);
            this.transform.localScale =new Vector3(0.7f,0.7f,0f);
            Destroy(this.GetComponent<BoxCollider2D>());

       
         
        }
}
}
