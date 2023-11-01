using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Android;

public class ingameButtonsInteracter : MonoBehaviour
{
    GameObject[] blueArray;
    float[] posOfBlue = new float[20];
    GameObject[] redArray;
    float[] posOfRed = new float[20];
    GameObject[] greenArray;
    float[] posOfGreen = new float[20];
    GameObject[] yellowArray;
    float[] posOfYellow = new float[20];

    public Score score;
    // Update is called once per frame
    void Update()
    {
        


    }

    public void BluePress()
    {
        blueArray = GameObject.FindGameObjectsWithTag("Blue Piece");
        if (blueArray.Length > 0)
        {
            int carryOver = 100;
            if (blueArray.Length > 1)
            {
                
                for (int i = 0; i < blueArray.Length; i++)
                {
                    posOfBlue[i] = blueArray[i].transform.position.y;

                    
                }
                for (int i = 0; i < blueArray.Length; i++)
                {
                    if(carryOver < blueArray.Length)
                    {
                        if (posOfBlue[carryOver] <= posOfBlue[i])
                        {
                            continue;
                        }
                    }

                    if(posOfBlue[i] < posOfBlue[i + 1])
                    {
                        carryOver = i;

                    }
                    else if(posOfBlue[i] > posOfBlue[i + 1])
                    {
                        carryOver = i + 1;
                    }

                }

                Destroy(blueArray[carryOver]);
                score.Addscore();

            }
            else
            {
                Destroy(blueArray[0]);
                score.Addscore();
            }
        }
        else
        {
            Debug.Log("not found");
        }
        
    }

    public void GreenPress()
    {
        greenArray = GameObject.FindGameObjectsWithTag("Green Piece");
        if (greenArray.Length > 0)
        {
            int carryOver = 100;
            if (greenArray.Length > 1)
            {

                for (int i = 0; i < greenArray.Length; i++)
                {
                    posOfGreen[i] = greenArray[i].transform.position.y;


                }
                for (int i = 0; i < greenArray.Length; i++)
                {
                    if (carryOver < greenArray.Length)
                    {
                        if (posOfGreen[carryOver] <= posOfGreen[i])
                        {
                            continue;
                        }
                    }

                    if (posOfGreen[i] < posOfGreen[i + 1])
                    {
                        carryOver = i;

                    }
                    else if (posOfGreen[i] > posOfGreen[i + 1])
                    {
                        carryOver = i + 1;
                    }

                }
          
                Destroy(greenArray[carryOver]);
                score.Addscore();

            }
            else
            {
                Destroy(greenArray[0]);
                score.Addscore();
            }
        }
        else
        {
            Debug.Log("not found");
        }
    }

    public void RedPress()
    {
        redArray = GameObject.FindGameObjectsWithTag("Red Piece");
        if (redArray.Length > 0)
        {
            int carryOver = 100;
            if (redArray.Length > 1)
            {

                for (int i = 0; i < redArray.Length; i++)
                {
                    posOfRed[i] = redArray[i].transform.position.y;


                }
                for (int i = 0; i < redArray.Length; i++)
                {
                    if (carryOver < redArray.Length)
                    {
                        if (posOfRed[carryOver] <= posOfRed[i])
                        {
                            continue;
                        }
                    }

                    if (posOfRed[i] < posOfRed[i + 1])
                    {
                        carryOver = i;

                    }
                    else if (posOfRed[i] > posOfRed[i + 1])
                    {
                        carryOver = i + 1;
                    }

                }

                Destroy(redArray[carryOver]);
                score.Addscore();

            }
            else
            {
                Destroy(redArray[0]);
                score.Addscore();
            }
        }
        else
        {
            Debug.Log("not found");
        }
    }

    public void YellowPress()
    {
        yellowArray = GameObject.FindGameObjectsWithTag("Yellow Piece");
        if (yellowArray.Length > 0)
        {
            int carryOver = 100;
            if (yellowArray.Length > 1)
            {

                for (int i = 0; i < yellowArray.Length; i++)
                {
                    posOfYellow[i] = yellowArray[i].transform.position.y;


                }
                for (int i = 0; i < yellowArray.Length; i++)
                {
                    if (carryOver < yellowArray.Length)
                    {
                        if (posOfYellow[carryOver] <= posOfYellow[i])
                        {
                            continue;
                        }
                    }

                    if (posOfYellow[i] < posOfYellow[i + 1])
                    {
                        carryOver = i;

                    }
                    else if (posOfYellow[i] > posOfYellow[i + 1])
                    {
                        carryOver = i + 1;
                    }

                }

                Destroy(yellowArray[carryOver]);
                score.Addscore();

            }
            else
            {
                Destroy(yellowArray[0]);
                score.Addscore();
            }
        }
        else
        {
            Debug.Log("not found");
        }
    }
}
