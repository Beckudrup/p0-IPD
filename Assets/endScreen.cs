using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{

    public string[] con1;
    public string[] con15;
    public string[] con2;
    public string[] con3;
 
    public string usertypeIntro;
   
    public Image meme;
    public Sprite[] memebillede;
   
    public TextMeshProUGUI answerDisplay;
    public TextMeshProUGUI answerDisplay2;
    public TextMeshProUGUI answerDisplay3;

    
    public TextMeshProUGUI userType;


    // Start is called before the first frame update
    void Start()
    {
        userType.text = usertypeIntro + con1[manager.instance.questionAnswerList[0]];
        meme.sprite = memebillede[manager.instance.questionAnswerList[0]];
        answerDisplay.text = con15[manager.instance.questionAnswerList[0]];
        



        answerDisplay2.text = con2[manager.instance.questionAnswerList[1]];
        
        answerDisplay3.text = con3[manager.instance.questionAnswerList[2]];



    }

    // Update is called once per frame
    void Update()
    {
        


    }





}
