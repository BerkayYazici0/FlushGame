using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public LevelManager LevelManager;
    public PipeSystem[] PipeSystems;
    public GameObject SuccessOil;



    private void Update()
    {
        if (LevelManager.isClickValve)
        {
            if (LevelManager.Levels[0].activeInHierarchy)
            {
                if (!PipeSystems[0].isCorrectRot || !PipeSystems[1].isCorrectRot)
                {
                    PipeSystems[0].Oil.SetActive(true);
                }
                if (!PipeSystems[2].isCorrectRot)
                {
                    PipeSystems[2].Oil.SetActive(true);
                }
                if (!PipeSystems[3].isCorrectRot)
                {
                    PipeSystems[3].Oil.SetActive(true);
                }
                if (!PipeSystems[4].isCorrectRot)
                {
                    PipeSystems[4].Oil.SetActive(true);
                }
                if (!PipeSystems[5].isCorrectRot)
                {
                    PipeSystems[5].Oil.SetActive(true);
                }
                if (LevelManager.LevelScore == LevelManager.TargetScores[0])
                {
                    SuccessOil.SetActive(true);
                }
            }
            else if (LevelManager.Levels[1].activeInHierarchy)
            {
                if (!PipeSystems[0].isCorrectRot)
                {
                    PipeSystems[0].Oil.SetActive(true);
                }
                if (!PipeSystems[1].isCorrectRot)
                {
                    PipeSystems[1].Oil.SetActive(true);
                }
                if (!PipeSystems[3].isCorrectRot)
                {
                    PipeSystems[3].Oil.SetActive(true);
                }
                if (!PipeSystems[4].isCorrectRot || !PipeSystems[5].isCorrectRot)
                {
                    PipeSystems[4].Oil.SetActive(true);
                }
                if (LevelManager.LevelScore == LevelManager.TargetScores[1])
                {
                    SuccessOil.SetActive(true);
                }
            }
            else if (LevelManager.Levels[2].activeInHierarchy)
            {
                if (!PipeSystems[0].isCorrectRot && !PipeSystems[6].isCorrectRot)
                {
                    PipeSystems[0].Oil.SetActive(true);
                }
                if (!PipeSystems[1].isCorrectRot)
                {
                    PipeSystems[1].Oil.SetActive(true);
                }
                if (!PipeSystems[2].isCorrectRot)
                {
                    PipeSystems[2].Oil.SetActive(true);
                }
                if (!PipeSystems[3].isCorrectRot && !PipeSystems[7].isCorrectRot)
                {
                    PipeSystems[3].Oil.SetActive(true);
                }
                if (!PipeSystems[4].isCorrectRot && !PipeSystems[5].isCorrectRot)
                {
                    PipeSystems[4].Oil.SetActive(true);
                }
                if (LevelManager.LevelScore == LevelManager.TargetScores[2])
                {
                    SuccessOil.SetActive(true);
                }
            }
            else if (LevelManager.Levels[3].activeInHierarchy)
            {
                if (!PipeSystems[0].isCorrectRot)
                {
                    PipeSystems[0].Oil.SetActive(true);
                }
                if (!PipeSystems[1].isCorrectRot)
                {
                    PipeSystems[1].Oil.SetActive(true);
                }
                if (!PipeSystems[2].isCorrectRot)
                {
                    PipeSystems[2].Oil.SetActive(true);
                }
                if (!PipeSystems[3].isCorrectRot)
                {
                    PipeSystems[3].Oil.SetActive(true);
                }
                if (!PipeSystems[4].isCorrectRot && !PipeSystems[5].isCorrectRot)
                {
                    PipeSystems[4].Oil.SetActive(true);
                }
                if (!PipeSystems[6].isCorrectRot)
                {
                    PipeSystems[6].Oil.SetActive(true);
                }
                if (!PipeSystems[7].isCorrectRot)
                {
                    PipeSystems[7].Oil.SetActive(true);
                }
                if (LevelManager.LevelScore == LevelManager.TargetScores[3])
                {
                    SuccessOil.SetActive(true);
                }
            }
            else if (LevelManager.Levels[4].activeInHierarchy)
            {
                if (!PipeSystems[0].isCorrectRot)
                {
                    PipeSystems[0].Oil.SetActive(true);
                }
                if (!PipeSystems[1].isCorrectRot)
                {
                    PipeSystems[1].Oil.SetActive(true);
                }
                if (!PipeSystems[2].isCorrectRot)
                {
                    PipeSystems[2].Oil.SetActive(true);
                }
                if (!PipeSystems[3].isCorrectRot && !PipeSystems[5].isCorrectRot)
                {
                    PipeSystems[3].Oil.SetActive(true);
                }
                if (!PipeSystems[4].isCorrectRot)
                {
                    PipeSystems[4].Oil.SetActive(true);
                }
                if (!PipeSystems[6].isCorrectRot)
                {
                    PipeSystems[6].Oil.SetActive(true);
                }
                if (!PipeSystems[7].isCorrectRot)
                {
                    PipeSystems[7].Oil.SetActive(true);
                }
                if (!PipeSystems[8].isCorrectRot)
                {
                    PipeSystems[8].Oil.SetActive(true);
                }
                if (LevelManager.LevelScore == LevelManager.TargetScores[4])
                {
                    SuccessOil.SetActive(true);
                }
            }
        }
    }
}
