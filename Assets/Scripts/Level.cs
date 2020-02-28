using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float Delay = 2f;
    [SerializeField] int Next;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadNext()
    {
        StartCoroutine(NextScene());
    }
    public void LoadGameOver()
    {
        StartCoroutine(Wait());
    }
    public void Quit()
    {
        Application.Quit();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene("GameOver");
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene(Next);
    }
}
