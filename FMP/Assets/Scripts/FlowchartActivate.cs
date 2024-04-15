using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowchartActivate : MonoBehaviour
{
    [SerializeField] GameObject leonidasFlowchart;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            leonidasFlowchart.SetActive(true);
        }
    }
}
