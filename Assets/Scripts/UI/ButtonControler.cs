using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControler : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    float fadeAnimationDuration = 1f;

    public void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Play()
    {
        StartCoroutine(LoadSceneWFade(SceneManager.GetActiveScene().buildIndex + 1));
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    IEnumerator LoadSceneWFade(int sceneIndex)
    {
        animator.SetTrigger("FadeScreen");
        yield return new WaitForSeconds(fadeAnimationDuration);
        SceneManager.LoadScene(sceneIndex);
    }
}
