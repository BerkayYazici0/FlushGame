using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePipe : MonoBehaviour
{
    public Camera mainCam;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10.0f)) // shoots raycast
            {
                if (hit.transform.gameObject.CompareTag("Pipe"))
                {
                    hit.transform.gameObject.GetComponent<PipeSystem>().RotatePipe();
                }
            }
        }
    }
}
