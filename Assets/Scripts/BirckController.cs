using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirckController : MonoBehaviour
{
    [SerializeField] GameObject brick;
    private GameObject brickClone;
    public float offsetX = 1.7f;
    public float offsetY = -1.6f;
    private int columns = 10;
    private int rows = 5;
    private void Start()
    {
        Color[] colors = {Color.blue, Color.red, Color.green, Color.cyan, Color.yellow};
        Vector3 startPos = brick.transform.position;
        
        for(int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if(i == 0 && j == 0)
                {
                    brickClone = brick as GameObject;
                }
                else
                {
                    brickClone = Instantiate(brick) as GameObject;
                    float posX = startPos.x + offsetX * i;
                    float posY = startPos.y + offsetY * j;
                    brickClone.transform.position = new Vector3(posX, posY, startPos.z);
                }

                brickClone.GetComponent<BrickObject>().SetColor(colors[j]);
            }
        }
    }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");
    }
}
