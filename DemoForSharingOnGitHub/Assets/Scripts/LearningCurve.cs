using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 55; 
    //int ageIncrement = 5;

    // Start is called before the first frame update
    void Start()
    {
        int startAge = 10;
     
        int ageIncrement = 5;
        float pi = 3.14f;

        int incrementedAge;

        incrementedAge = ComputeAge(currentAge, ageIncrement);
        Debug.Log(incrementedAge);
        
        

        pi = startAge;   // pi <- startAge; pi := startAge 

        // startAge + pi = pi; TOTAL NONSENSE!!!
        
        startAge = (int)pi;

        pi = startAge + pi;
        //Debug.Log(currentAge);
        currentAge = startAge + ageIncrement;
        Debug.Log($"My initial age was {startAge}, and my current age is {currentAge}");
    }

    // Update is called once per frame
    void Update()
    {
        float startAge = 123.3f;
        //Debug.Log(startAge);
    }

    /// <summary>
    /// Computes modified age
    /// </summary>
    int ComputeAge(int c, int a)
    {
        int result = c+a;
        Debug.Log(result);
        return result;
    }
        
  void ComputeAge(int c,  float a)
    {
        Debug.Log(c + a );
    }
}
