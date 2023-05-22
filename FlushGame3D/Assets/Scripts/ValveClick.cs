using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ValveClick : MonoBehaviour
{
    public Camera mainCam;
    public GameObject Truck;
    public float TruckXPos;
    public LevelManager LevelManager;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10.0f)) // shoots raycast
            {
                if (hit.transform.gameObject.CompareTag("Valve"))
                {
                    Truck.transform.DOMoveX(TruckXPos, .5f);
                    LevelManager.CheckLevelStatus();
                    LevelManager.isClickValve = true;
                }
            }
        }
    }
}
