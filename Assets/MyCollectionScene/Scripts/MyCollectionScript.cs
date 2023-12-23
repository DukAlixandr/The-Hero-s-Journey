using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCollectionScript : MonoBehaviour
{
    [SerializeField] private GameObject _darkClan;
    [SerializeField] private GameObject _lightClan;
    [SerializeField] private GameObject _dragonClan;
    // Start is called before the first frame update
    void Start()
    {
        //Get MyCollection from BD 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowDarkCards()
    {
       ChangeVisibleXCards(_darkClan);
    }
    public void ShowLightCards()
    {
       ChangeVisibleXCards(_lightClan);
    }
    public void ShowDragonCards()
    {
       ChangeVisibleXCards(_dragonClan);
    }
    private void ChangeVisibleXCards(GameObject i)
    {
        _dragonClan.SetActive(false);
       _darkClan.SetActive(false);
       _lightClan.SetActive(false);
        i.transform.localPosition= new Vector3(0f,-166.89f,0f);//count from UI
        i.SetActive(true);
    }
    
}
