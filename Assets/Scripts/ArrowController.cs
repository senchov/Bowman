using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour 
{
    [SerializeField] private QuadraticBezierCurveMover ArrowDir;
    [SerializeField] private QuadraticBezierCurveMover ArrwoWrap;
    [SerializeField] [Range (0,1.0f)] private float Distance;
    [SerializeField] private float DiffInDistance;
    [SerializeField] private float MaxValue = 0.99f; 
    [SerializeField] private bool IsShoot = false;

    private void Update () 
    {
        if (IsShoot) 
        {        
            Distance = Distance > MaxValue ? MaxValue : Distance;
            ArrowDir.SetDistance = Distance + DiffInDistance;
            ArrwoWrap.SetDistance = Distance ;
        }
    }

	
}
