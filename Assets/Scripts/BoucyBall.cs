using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoucyBall : MonoBehaviour
{
    public float maxY = -4.5f;
    public float maxVelocity = 15f;
    private Rigidbody2D rb;
    private int lives = 5;
    public GameObject[] livesObject;
    [SerializeField] GameObject panelObject;
    private void Start()
    {
        panelObject.SetActive(false);   
        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Update()
    {
        if(transform.position.y < maxY)
        {
            if(lives <= 0)
            {
                GameOver();
            }
            else
            {
                transform.position = Vector3.zero;
                rb.velocity = Vector3.zero;
                lives--;
                livesObject[lives].SetActive(false);
            }
            
        }
        if(rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }
    }
    private void GameOver()
    {
        Time.timeScale = 0;
        panelObject.SetActive(true);
        Destroy(gameObject);
    }
}
