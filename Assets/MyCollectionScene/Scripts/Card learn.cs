using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class Card : MonoBehaviour
{
    [SerializeField] private GameObject _textShowerCanvas;
    [SerializeField] private Text _cardText;
    private static GameObject _card;
    private static GameObject _baseParentObject;
    private static Vector3 _baseCardPosition;
    private void Start()
    {
        _baseCardPosition=new Vector3(0f,0f);
    }
    public void ShowCardText()
    {
        _textShowerCanvas.SetActive(true);    
        string cmd = "SELECT "+Translater.Language+" FROM AllCharacters WHERE Name='"+this.gameObject.name+"'";
        Translater translater =new Translater();
        _cardText.text =translater.ReturnerSomeTextFromDB(cmd);
        DemonstrateCard();
    }
    private void OnMouseDown()
    {
       ShowCardText();
    }
    private void DemonstrateCard()
    {
        _card=this.gameObject;
        _baseCardPosition=this.transform.localPosition;
        _baseParentObject=this.transform.parent.gameObject;
        this.gameObject.transform.SetParent(_textShowerCanvas.transform);
        this.transform.localPosition= new Vector3(0f,418f,0f);//count from UI
        this.transform.localScale= new Vector3(2.6f,2.6f,2.6f);//count from UI
        this.GetComponentInChildren<SortingGroup>().sortingOrder=10;
        this.GetComponentInChildren<Canvas>().sortingOrder=10;
       //this.gameObject.transform.SetParent(_baseParentObject.transform);
       
    }
    public void getBackToMyCollection()
    {
        _card.gameObject.transform.SetParent(_baseParentObject.transform);
        _card.GetComponentInChildren<SortingGroup>().sortingOrder=2;
        _card.GetComponentInChildren<Canvas>().sortingOrder=2;
        _textShowerCanvas.SetActive(false);    
        _card.transform.localPosition=_baseCardPosition;
        _baseCardPosition=new Vector3(0f,0f);
        _card.transform.localScale= new Vector3(1f,1f,1f);//count from UI


    }

    
}
