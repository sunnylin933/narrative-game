using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{

    private bool isClicked = false;
    public Transform Trans;
    Vector3 _cam;
    public GameObject camera;
    public float CamMoveSpeed = 5f;
    public static string zoomActive = "n";
    public int areaState;
    public GameObject dialogue1;
    public Color mycolor;
    public MeshRenderer mymeshrenderer;
    // Start is called before the first frame update
    void Start()
    {
        _cam = Trans.position;
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
            isClicked = true;
            GameManager.gameState = 2;

            
        }
        zoom();

    }
    
    private void OnMouseExit()
    {
        mymeshrenderer.material.SetColor("_Color", mycolor);
    }
   

    private void zoom()
    {

        if (isClicked == true)
        {
            float yinput = this.GetComponent<Transform>().position.y;

            _cam = new Vector3(this.GetComponent<Transform>().position.x, yinput + 70, this.GetComponent<Transform>().position.z) ;

            //zoomActive = "y";
            camera.GetComponent<Transform>().position = Vector3.Lerp(camera.GetComponent<Transform>().position, _cam, CamMoveSpeed * Time.deltaTime);

        }
    }

}
