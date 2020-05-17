using UnityEngine;

public class Movment : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardSpeed = 600f;
    public float rightleftSpeed = 600f;
    bool gameStarted = false;
    public GameObject StartUI;


    void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            gameStarted = true;
        }
        if(gameStarted == true) {

            StartUI.SetActive(false);

            rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);

            if (Input.GetKey("a"))
            {
                rb.AddForce(-(rightleftSpeed * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(rightleftSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            if(rb.position.y < -1f)
            {
                FindObjectOfType<GameMenager>().EndGame();
            }
        
        }
    }
}
