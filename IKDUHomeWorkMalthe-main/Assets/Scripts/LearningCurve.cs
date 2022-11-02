using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 55;
    // Start is called before the first frame update
    void Start()
    {
        string myText = "Hello World";

        int startAge = 10;
        int ageIncrement = 5;
        float pi = 3.14f;
        //int incrementedAge;
        




        pi = startAge;
        startAge = (int)pi;
        pi = startAge + pi;

        //currentAge = startAge + ageIncrement;

        Debug.Log(currentAge);
        Debug.Log($"My initial age was {startAge}, and my current age is {currentAge}");
        Debug.Log(myText);
    }


    // Update is called once per frame
    void Update()
    {

    }
    


}
