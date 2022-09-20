using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    //Gør så man altid kan finde den
    public static manager instance;
    public List<int> questionAnswerList = new List<int>();
    /// <summary>
    /// Det første der køre når den bliver lavet
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    
    }


}
