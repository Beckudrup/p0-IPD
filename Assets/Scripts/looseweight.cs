using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class looseweight : MonoBehaviour{

private float weight;
private string myName;
private int myAge;

    // Start is called before the first frame update
    void Start()
    {
     myAge = 21;
     myName = "Christoffer Beck Oudrup";
     weight = 60.7f;
     Debug.Log("Min vægt er: "+ weight);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loseweight(float weightToGain){
        
        weight = weight + weightToGain;
        Debug.Log("Min nye vægt efter jeg spiste er: "+ weight);


    }



}
