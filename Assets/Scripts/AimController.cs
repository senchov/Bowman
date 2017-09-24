using UnityEngine;
using System.Collections;

public class AimController : MonoBehaviour 
{
    [SerializeField] private InputManager InManager;
    [SerializeField] private Targets _Targets;
	
    private float Gipo;

    private void Start ()
    {
        Gipo = Vector3.Distance (_Targets.ArrowDir.position, _Targets.StartCurvePoint.position);
    }

	void Update () 
    {
        if (InManager.IsAiming)
        {
            
            float a = InManager.GetSinus () * Gipo;
            a = a == float.NaN ? _Targets.ArrowDir.localPosition.y : a;
            _Targets.ArrowDir.localPosition = new Vector3 (_Targets.ArrowDir.localPosition.x, -a, _Targets.ArrowDir.localPosition.z);
        }
	}

    [System.Serializable]
    private class Targets
    {
        public Transform ArrowDir;
        public Transform StartCurvePoint;
    }
}
