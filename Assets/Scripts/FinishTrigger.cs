using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour

{
    public GameObject EndGameScore;
    public GameObject PlayAgain;

    void OnTriggerEnter() //Triggers on finish
    {
        EndGameScore.SetActive(true);
        PlayAgain.SetActive(true);
    }

}