using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5;
    float horizontalMovement;

    public GameObject[] spawnObject;

    // Update is called once per frame
    void Update()
    {
        //gets input from the player
        horizontalMovement = Input.GetAxis("Horizontal");

       
        if(transform.position.y < -4.5f)
        {
            SceneManager.LoadScene(0);
        }
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnObject[0], new Vector3(0, 0, 0), Quaternion.identity);
        }

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            Debug.Log("Collided with Ground");
        }

        if (collision.transform.tag == "collectible")
        {
            //increase score
        }
        if (collision.transform.tag == "enemy")
        {
            //deal damage
        }
    }
}
