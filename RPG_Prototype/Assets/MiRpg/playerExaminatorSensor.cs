using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerExaminatorSensor : MonoBehaviour
{
    public GameObject target;
    [Tooltip("Distancia a la que se pueden examinar los objetos")]
    public float examinationMaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.SphereCast(transform.position,0.3f,transform.forward,out hit,examinationMaxDistance))
        {
            target=hit.collider.gameObject;
        }
        else
            target = null;

        
    }
}
