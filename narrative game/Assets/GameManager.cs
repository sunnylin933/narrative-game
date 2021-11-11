using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gameState;
    void Start()
    {
        gameState = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case 0://default 

                break;

            case 1://selecting state

                    break;

            case 2://dialogue state

                break;

        }
    }
}
