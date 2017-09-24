using UnityEngine;
using System.Collections;

public class TransformLookAt : MonoBehaviour 
{
    [SerializeField] private Transform Target;	
    Vector3 Diff;

    void Update()
    {
        Diff = Target.position - transform.position;    
        float atan2 = Mathf.Atan2 ( Diff.y, Diff.x );
        transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg );
    }
}
