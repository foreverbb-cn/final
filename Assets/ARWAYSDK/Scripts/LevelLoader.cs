using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void LoadNextLevel(int index)
    {
        StartCoroutine(LoadLevel(index));
    }

    IEnumerator LoadLevel(int SceneIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(SceneIndex);
    }
}