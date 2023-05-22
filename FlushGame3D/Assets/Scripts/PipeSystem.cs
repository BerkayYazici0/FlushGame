using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PipeSystem : MonoBehaviour
{
    [Header("Pipe Stats")]
    public Vector3 CorrectPipeRot;
    public Vector3 DefaultPipeRot;
    public bool isCorrectRot = false;
    
    [Header("Other Variables")]
    [SerializeField] private ParticleSystem SmokeEffect;
    public LevelManager LevelManager;
    public GameObject Oil;

    private void Awake()
    {
        isCorrectRot = false;
        Oil.SetActive(false);
        transform.GetComponent<BoxCollider>().enabled = true;
    }

    public void PreparePipe()
    {
        isCorrectRot = false;
        Oil.SetActive(false);
        transform.GetComponent<BoxCollider>().enabled = true;
        transform.DORotate(DefaultPipeRot, 0.1f);
    }
    public void CheckPipe()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
        Vector3 PipeRot = transform.rotation.eulerAngles;
        if(PipeRot.z < CorrectPipeRot.z + 5 && CorrectPipeRot.z - 5 < PipeRot.z) // x + 5 < piperot < x - 5
        {
            LevelManager.LevelScore++;
            isCorrectRot = true;
            SmokeEffect.Play();
            transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public void RotatePipe()
    {
        var clickRot = new Vector3(0, 0, 90);
        var destinationRot = clickRot + transform.rotation.eulerAngles;
        transform.GetComponent<BoxCollider>().enabled = false;
        transform.DORotate(destinationRot, 1f).OnComplete(() => CheckPipe());
    }
}
