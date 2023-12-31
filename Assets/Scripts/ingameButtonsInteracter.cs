using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public PieceMove[] allPieces = new PieceMove[100];
    float[] allPiecesY = new float[100];
    public Score score;
    int toKill = 1;

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

                if (blueArray[carryOver].gameObject.name == toKill.ToString())
                {
                    Destroy(blueArray[carryOver]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }

            }
            else
            {
                if (blueArray[0].gameObject.name == toKill.ToString())
                {
                    Destroy(blueArray[0]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
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

                if (greenArray[carryOver].gameObject.name == toKill.ToString())
                {
                    Destroy(greenArray[carryOver]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
            }
            else
            {
                if (greenArray[0].gameObject.name == toKill.ToString())
                {
                    Destroy(greenArray[0]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
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

                if (redArray[carryOver].gameObject.name == toKill.ToString())
                {
                    Destroy(redArray[carryOver]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
            }
            else
            {
                if (redArray[0].gameObject.name == toKill.ToString())
                {
                    Destroy(redArray[0]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
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

                if (yellowArray[carryOver].gameObject.name == toKill.ToString())
                {
                    Destroy(yellowArray[carryOver]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
            }
            else
            {
                if (yellowArray[0].gameObject.name == toKill.ToString())
                {
                    Destroy(yellowArray[0]);
                    toKill++;
                    score.Addscore();
                }
                else
                {
                    
                }
            }
        }
        else
        {
            Debug.Log("not found");
        }
    }
}
