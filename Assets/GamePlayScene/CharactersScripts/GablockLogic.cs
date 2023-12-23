using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GablockLogic : PlayerCardManager
{
    [SerializeField] private Text _cardCurrentPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //_cardCurrentPower.text=GablockLogic.CurrentCardPower.ToString();
        _cardCurrentPower.text=PlayerCardManager.CurrentCardPower.ToString();
        //_cardCurrentPower.tag="";
    }
    public void OnWasPlayed()
    {
            //GameObject.FindGameObjectWithTag("Location1").GetComponentInChildren<PlayerCardManager>();
             //this.transform.SetParent(GameObject.FindGameObjectWithTag("Location1").transform); 
             
            // GablockLogic.CurrentCardPower=1;


    }
}
