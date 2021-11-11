using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public int areaState;
    public GameObject dialogue1;
    public Color mycolor;
    public MeshRenderer mymeshrenderer;
    // Start is called before the first frame update
    void Start()
    {
        areaState = 0;
        mycolor = this.gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
        mymeshrenderer = this.gameObject.GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        if (GameManager.gameState == 1)
        {
            mymeshrenderer.material.SetColor("_Color", Color.yellow);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dialogue1.SetActive(true);
            GameManager.gameState = 2;

        }
    }

    private void OnMouseExit()
    {
        mymeshrenderer.material.SetColor("_Color", mycolor);
    }
}
