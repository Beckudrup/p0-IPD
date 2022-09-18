using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class questionManager : MonoBehaviour
{
    int questionIndex;
    public TextMeshProUGUI[] button;
 
    public TextMeshProUGUI answerDisplay;
    public Image[] buttonImage;
    public questionsRow[] questions;
    int endScene=2;
    // Start is called before the first frame update
    void Start()
    {
        displayUpdate();
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void displayUpdate()
    {
        for(int i = 0; i < button.Length; ++i)
        {
            buttonImage[i].sprite = questions[questionIndex].questions[i].buttonImage;
            button[i].text = questions[questionIndex].questions[i].answer;

        }
        answerDisplay.text = questions[questionIndex].question;

    }
    //Gemmer hvor langt vi er 
    public void buttonClick(int i)
    {
        manager.instance.questionAnswerList.Add(i);
        questionIndex++;
        if (questionIndex >= questions.Length)
        {
            SceneManager.LoadScene(endScene);
            
        }
        else
        {
            displayUpdate();
        }

    }

}
//Gør så Unity genkender class'en
[Serializable]
public class questionsRow
{
    public string question;
    public question[] questions;





}
[Serializable]

public class question
{

    public string answer;
    public Color answerColor;
    public Sprite buttonImage;


}