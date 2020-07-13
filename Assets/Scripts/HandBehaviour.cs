using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehaviour : MonoBehaviour
{
    public GameObject indicator;
    public bool isActive = false;
    public string tgTag = "Grabbable";
    public List<GameObject> targets;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tgTag))
        {
            targets.Remove(other.gameObject);
            if(targets.Count == 0)
            {
                isActive = false;
                if (indicator)
                {
                    indicator.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tgTag))
        {
            isActive = true;
            targets.Add(other.gameObject);
            if (indicator)
            {
                indicator.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }



}
