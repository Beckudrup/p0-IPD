using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    //G�r s� man altid kan finde den
    public static manager instance;
    public List<int> questionAnswerList = new List<int>();
    /// <summary>
    /// Det f�rste der k�re n�r den bliver lavet
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
