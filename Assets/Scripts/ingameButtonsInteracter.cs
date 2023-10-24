using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Android;

public class ingameButtonsInteracter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void BluePress()
    {       
        if (GameObject.FindGameObjectsWithTag("Blue Piece").Length > 0)
        {
            //Destroy(GameObject);
            Debug.Log("Blue");
        }
        else
        {
            Debug.Log("not found");
        }
        
    }

    public void GreenPress()
    {
        if (GameObject.FindGameObjectsWithTag("Green Piece").Length > 0)
        {
            Debug.Log("Green");
        }
        else
        {
            Debug.Log("not found");
        }
    }

    public void RedPress()
    {
        if (GameObject.FindGameObjectsWithTag("Red Piece").Length > 0)
        {
            Debug.Log("Red");
        }
        else
        {
            Debug.Log("not found");
        }
    }

    public void YellowPress()
    {
        if (GameObject.FindGameObjectsWithTag("Yellow Piece").Length > 0)
        {
            Debug.Log("Yellow");
        }
        else
        {
            Debug.Log("not found");
        }
    }
}
