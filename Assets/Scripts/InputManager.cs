using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{	
    private Vector3 StartPoint, EndPoint;

    private Camera MyCamera;
    private float SinA;
    public bool IsAiming;

    private void Start () 
    {
        MyCamera = Camera.main;
    }

    public float GetSinus ()
    {
        return SinA;
    }  

	void Update ()
    {
        if (Input.GetMouseButtonDown (0)) 
        {
            StartPoint = MyCamera.ScreenToWorldPoint (Input.mousePosition);
            IsAiming = true;
        }

        if (Input.GetMouseButton (0))
        {
            EndPoint = MyCamera.ScreenToWorldPoint (Input.mousePosition);
            float gipo = Vector3.Distance (StartPoint, EndPoint);
            gipo = (gipo > 0) ? gipo : 1;
            float a =  StartPoint.y - EndPoint.y;
            SinA = Mathf.Clamp (a / gipo, -1, 1);
            float arcsin = Mathf.Asin (SinA) * 180 / Mathf.PI;
            print (SinA + " arc=" + arcsin);
        }

        if (Input.GetMouseButtonUp (0))
        {
            IsAiming = false;
        }
	}   


}
