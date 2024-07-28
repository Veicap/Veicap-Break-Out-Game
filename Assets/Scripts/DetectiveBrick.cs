using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DetectiveBrick : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private int score;
    private void Start()
    {
        score = 0;
        text.text = "Score: " + score;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BrickObject brick  = collision.gameObject.GetComponent<BrickObject>();  
        if(brick != null )
        {
            brick.DestroyObject();
            score++;
            text.text = "Score: " + score;
        }
    }
}
