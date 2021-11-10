using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gameState;
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
                Debug.DrawRay(Camera.main.transform.position, Input.mousePosition,Color.green);
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000.0f, LayerMask.GetMask("Area")))
                {
                    hit.transform.gameObject.GetComponent<Area>().areaState = 2;
                    if (Input.GetMouseButtonDown(0))
                    {
                        hit.transform.gameObject.GetComponent < Area>().areaState = 1;
                        gameState = 2;
                    }
                }
                    break;

            case 2://dialogue state

                break;

        }
    }
}
