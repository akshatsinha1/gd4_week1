using UnityEngine;

public class TestScript : MonoBehaviour
{
    //string, integer, floating point variable, boolean

    //Information about a car
     public string modelName = "Lightening McQueen";
     int manufactureYear = 2006;
     float topSpeed = 350.5f;
     public bool trappedInRadiatorSprings = true;
   

     public float moveSpeed = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(modelName);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(modelName);

        

        if(trappedInRadiatorSprings == true)
        {
            if(moveSpeed > 15)
            {
                //move object forward by moveSpeed 
                transform.Translate(0, 0, moveSpeed * Time.deltaTime);
            }
           
        }
    }
}
