using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels;
    public int[] TargetScores;
    public int LevelScore = 0;
    public GameObject NextLevelPanel;
    public GameObject RestartLevelPanel;
    public GameObject Truck;
    public bool isClickValve = false;
    private Level levelScript;
    public int Level;
    public int CurrentLevel;
    public PipeSystem[] AllPipes;
    private void Awake()
    {
        isClickValve = false;
        var CurLevel = PlayerPrefs.GetInt("Level");
        CurrentLevel = CurLevel;
        for (int i = 0; i < Levels.Length; i++)
        {
            Levels[i].SetActive(false);
        }
        if(CurLevel > Levels.Length - 1)
        {
            var i = Random.Range(0, 4);
            Levels[i].SetActive(true);
            levelScript = Levels[i].GetComponent<Level>();
            Level = i;
        }
        else
        {
            Levels[CurLevel].SetActive(true);
            levelScript = Levels[CurLevel].GetComponent<Level>();
            Level = CurLevel;  //Levellarý restartta doðru açýlara getirir.
        }
        for (int i = 0; i < levelScript.PipeSystems.Length; i++)
        {
            levelScript.PipeSystems[i].transform.rotation = Quaternion.Euler(levelScript.PipeSystems[i].DefaultPipeRot);
        }
    }
    public void CheckLevelStatus()
    {
        if (LevelScore == TargetScores[Level])
        {
            LevelSuccess();
            Debug.Log("Success");
        }
        else
        {
            LevelFail();
            Debug.Log("Fail");
        }
    }

    public void LevelSuccess()
    {
        //level up paneli aç
        NextLevelPanel.SetActive(true);
        RestartLevelPanel.SetActive(false);
    }

    public void LevelFail()
    {
        RestartLevelPanel.SetActive(true);
        NextLevelPanel.SetActive(false);
    }

    public void NextLevel()
    {
        var CurLevel = PlayerPrefs.GetInt("Level");
        CurrentLevel = CurLevel;
        for (int i = 0; i < Levels.Length; i++)
        {
            Levels[i].SetActive(false);
        }
        for (int i = 0; i < Levels.Length; i++)
        {
            Levels[i].GetComponent<Level>().SuccessOil.SetActive(false);
        }
        for (int i = 0; i < Levels[Level].GetComponent<Level>().PipeSystems.Length; i++)
        {
            Levels[Level].GetComponent<Level>().PipeSystems[i].PreparePipe();
        }
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        if (CurLevel < Levels.Length)
        {
            Level = CurLevel;
            Levels[CurLevel].SetActive(true);
            for (int i = 0; i < Levels[CurLevel].GetComponent<Level>().PipeSystems.Length; i++)
            {
                Levels[CurLevel].GetComponent<Level>().PipeSystems[i].PreparePipe();
            }
        }
        else
        {
            Level = Random.Range(0, Levels.Length);
            Levels[Level].SetActive(true);
            for (int i = 0; i < Levels[Level].GetComponent<Level>().PipeSystems.Length; i++)
            {
                Levels[Level].GetComponent<Level>().PipeSystems[i].PreparePipe();
            }
        }
        NextLevelPanel.SetActive(false);
        Truck.transform.position = new Vector3(-5.5f, Truck.transform.position.y, Truck.transform.position.z);
        isClickValve = false;
        LevelScore = 0;

        for (int i = 0; i < AllPipes.Length; i++)
        {
            AllPipes[i].PreparePipe();
        }
    }
    public void RestartLevel()
    {
        var levelScript = Levels[Level].GetComponent<Level>(); //Levellarý restartta doðru açýlara getirir.
        for (int i = 0; i < levelScript.PipeSystems.Length; i++)
        {
            levelScript.PipeSystems[i].transform.rotation = Quaternion.Euler(levelScript.PipeSystems[i].DefaultPipeRot);
            levelScript.PipeSystems[i].PreparePipe();
        }
        RestartLevelPanel.SetActive(false);
        Truck.transform.position = new Vector3(-5.5f, Truck.transform.position.y, Truck.transform.position.z);
        isClickValve = false;
        LevelScore = 0;
    }
}
