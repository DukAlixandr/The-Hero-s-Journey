using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CardManager : MonoBehaviour
{
    private List<GameObject> _playerCardsOnLocation = new List<GameObject> ();
    private Vector2 mousePosition;
    [SerializeField] float moveSpeed = 0.1f;
    private Vector3 CardStartPosition;
    private bool CardMovmentActive;
    [SerializeField] private int _cardPower;
    private int _cardOnLocation;

    private void Start()
    {
        CardStartPosition = new Vector3 (this.transform.position.x, this.transform.position.y,this.transform.position.z);
    }
    private void OnMouseDown() {
        CardMovmentActive=true;
        this.gameObject.AddComponent<SortingGroup>(); 
        this.gameObject.GetComponent<SortingGroup>().sortingOrder = 100;
    }
    private void Update()
    {
        if (CardMovmentActive==true){
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.position = Vector3.Lerp(transform.position, new Vector3 (mousePosition.x, mousePosition.y, 90), moveSpeed);
        
        }

         
    }
    
    private void OnMouseUp() {
        CardMovmentActive=false;
        this.transform.position =CardStartPosition;
        Destroy(this.GetComponent<SortingGroup>());
         if(int.Parse(LocationScript.CardAddToLoсaction)==1){
            _playerCardsOnLocation.Add(this.gameObject);
            this.transform.position = new Vector3 (_playerCardsOnLocation.Count, _playerCardsOnLocation.Count, 0);
            this.transform.localScale =new Vector3(0.6f,0.6f,0f); 
            Destroy(this.GetComponent<BoxCollider2D>());
       

        }
    
    
    }
    private void Attack (GameObject AttackObject){
        AttackObject=GameObject.Find("AttackGameObject");
        //if()
        AttackObject.GetComponent<SortingGroup>().sortingOrder = 100;
        AttackObject.transform.position = new Vector3 (_playerCardsOnLocation.Count, _playerCardsOnLocation.Count, 0);
        this.gameObject.GetComponent<Animation>().Play("AttackAnimation");
        AttackObject.GetComponent<SortingGroup>().sortingOrder = 1;


}
}
