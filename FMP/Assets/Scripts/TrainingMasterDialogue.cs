using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingMasterDialogue : MonoBehaviour
{
    [SerializeField] GameObject TrainingMasterFlowchart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TrainingMasterFlowchart.SetActive(true);
        }
    }
}
