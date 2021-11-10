using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public int areaState;
    public GameObject dialogue1;
    public Color mycolor;
    // Start is called before the first frame update
    void Start()
    {
        areaState = 0;
        mycolor = this.gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
        switch (areaState)
        {
            case 0://default 
                this.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", mycolor);
                break;

            case 1://isClicked 
                dialogue1.SetActive(true);
                areaState = 0;
                break;

            case 2://default 
                this.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
                areaState = 0;
                break;
        }
        }
}
