using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourerDialogueTrigger : MonoBehaviour
{
    [SerializeField] GameObject ArmourerFlowchart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ArmourerFlowchart.SetActive(true);
        }
    }
}
