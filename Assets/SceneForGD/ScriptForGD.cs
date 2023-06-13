using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForGD : MonoBehaviour
{
    [SerializeField] private GameObject [] _deck = new GameObject [30];
    [SerializeField] private GameObject _spaceOfCards;
    [SerializeField] private GameObject _createdObject;
    private static int _GDCouner=-1;

    private void Start()
    {
        ShowNextCard();
    }

    public void ShowNextCard()
    {
        _GDCouner++;
        Destroy(_createdObject);
        _createdObject = Instantiate( _deck[_GDCouner], new Vector3(0f, 1f, 90), Quaternion.identity, _spaceOfCards.transform);
        _createdObject.GetComponent<BoxCollider2D>().enabled=false;
        _createdObject.transform.localScale = new Vector3(2.5f,2.5f,0f);

        
    }
    public void ShowPreviousCard ()
    {
        _GDCouner--;
        Destroy(_createdObject);
        _createdObject = Instantiate( _deck[_GDCouner], new Vector3(0f, 1f, 90), Quaternion.identity, _spaceOfCards.transform);
        _createdObject.GetComponent<BoxCollider2D>().enabled=false;
        _createdObject.transform.localScale = new Vector3(2.5f,2.5f,0f);

    }
}
