using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ass8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
       while (true){
        int rrandom =Random.Range(1,21);
       // Debug.Log(rrandom);
        if (rrandom ==5){
            continue;
        }
        if (rrandom == 15)
        {
            break;
        }
        Debug.Log(rrandom);  
       }; 

    string[] funywords = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
    string funy = "";
    int count = 0;

    while (count < 7){
        string word = funywords[Random.Range(0, funywords.Length)];
        funy += word + " ";
        count++;
    }

    Debug.Log(funy.Trim()); 
    }

  
}
