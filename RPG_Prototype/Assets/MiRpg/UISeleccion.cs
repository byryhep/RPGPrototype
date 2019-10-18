using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISeleccion : MonoBehaviour
{
    public GameObject panelExaminar;
    public Text txtNombre;
    public Text txtDescripcion;
    playerExaminatorSensor sensor;
    // Start is called before the first frame update
    void Start()
    {
        sensor = FindObjectOfType<playerExaminatorSensor>();
    }

    // Update is called once per frame
    void Update()
    {
        panelExaminar.SetActive(false);
        if(sensor)
        {
            if (sensor.target)
            {
                examinable script = sensor.target.GetComponent<examinable>();
                if (script)
                {
                    txtNombre.text = script.nombre;
                    txtDescripcion.text = script.descripcion;
                    panelExaminar.SetActive(true);
                }
            }
        }
    }
}
