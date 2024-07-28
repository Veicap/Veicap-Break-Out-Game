using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickObject : MonoBehaviour
{
    
    public void SetColor(Color color)
    {      
        GetComponent<SpriteRenderer>().color = color;
    }
    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
