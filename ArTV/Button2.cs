using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
public class Button2 : MonoBehaviour
{

    public static Button2 curr;
    public GameObject s1, s2, s3, b1, b2, b3;
    public Material redMat, greenMat;
    public bool active;
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();


    private void Awake()
    {

        curr = this;


    }



    //initialization
    void Start()
    {

        definedButton = this.gameObject;

        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        active = false;


    }

    //Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                
                if (active == false)
                {
                    s1.SetActive(false);
                    s2.SetActive(true);
                    s3.SetActive(false);

                    b1.GetComponent<MeshRenderer>().material = redMat;
                    b2.GetComponent<MeshRenderer>().material = greenMat;
                    b3.GetComponent<MeshRenderer>().material = redMat;

                    active = true;
                    Button1.curr.active = false;
                    Button3.curr.active = false;
                }
                else
                {
                    b2.GetComponent<MeshRenderer>().material = redMat;
                    s2.SetActive(false);

                    active = false;

                }


            }
        }
    }


}

