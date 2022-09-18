using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{

    public string[] con1;
    public string[] con2;
    public string usertypeIntro;
    public TextMeshProUGUI answerDisplay;
    public TextMeshProUGUI userType;


    // Start is called before the first frame update
    void Start()
    {


        answerDisplay.text = con2[manager.instance.questionAnswerList[1]];
        userType.text = usertypeIntro + con1[manager.instance.questionAnswerList[0]];




    }

    // Update is called once per frame
    void Update()
    {
        


    }





}
