using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5;
    float horizontalMovement;

    // Update is called once per frame
    void Update()
    {
        //gets input from the player
        horizontalMovement = Input.GetAxis("Horizontal");

       
        
       

        //uses the input to move the player character
        transform.Translate(moveSpeed * Time.deltaTime * horizontalMovement, 0, 0);

        if(horizontalMovement < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (horizontalMovement > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
