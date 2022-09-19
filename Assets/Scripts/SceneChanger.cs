using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{

    private int nextScreen;
    private int prevScreen;
    private bool egg = false;
    // Start is called before the first frame update
    void Start()
    {
        nextScreen = SceneManager.GetActiveScene().buildIndex+1;
        prevScreen = SceneManager.GetActiveScene().buildIndex-1;
        Debug.Log("mit scnene lige nu er: "+ SceneManager.GetActiveScene().buildIndex+1);

    }

    // Update is called once per frame
    void Update()
    {


      }  
    

public void nextslide(){
    SceneManager.LoadScene(nextScreen);



}

public void prevside(){

        SceneManager.LoadScene(prevScreen);
        
}
public void backToBasics(){


        SceneManager.LoadScene(1);

}

public bool returEgg(){

egg=true;
return egg;

}
}
