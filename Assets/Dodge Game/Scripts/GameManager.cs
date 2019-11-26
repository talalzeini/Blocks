using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float slow = 10f;
    public GameObject GameOver;


    public void EndGame()

    {
        StartCoroutine(RestartLevel());
    }
    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slow;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slow;
        yield return new WaitForSeconds(4f / slow);
        Time.fixedDeltaTime = Time.fixedDeltaTime * slow;
        GameOver.SetActive(true);
        Time.timeScale = 0f;

    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Dodge");
    }
    public void BThemes()
    {
        SceneManager.LoadScene("Themes");
    }
    public void LoadRed()
    {
        SceneManager.LoadScene("Red");
        Time.timeScale = 1f;
    }
    public void LoadGreen()
    {
        SceneManager.LoadScene("Green");
        Time.timeScale = 1f;
    }
    public void LoadOrange()
    {
        SceneManager.LoadScene("Orange");
        Time.timeScale = 1f;
    }
    public void LoadPurple()
    {
        SceneManager.LoadScene("Purple");
        Time.timeScale = 1f;
    }
    public void LoadYellow()
    {
        SceneManager.LoadScene("Yellow");
        Time.timeScale = 1f;
    }
  public void RMenu()
    {
        SceneManager.LoadScene("RedMenu");
    }
    public void RThemes()
    {
        SceneManager.LoadScene("RedT");
    }
    public void YMenu()
    {
        SceneManager.LoadScene("YellowMenu");
    }
    public void YThemes()
    {
        SceneManager.LoadScene("YellowT");
    }
    public void GMenu()
    {
        SceneManager.LoadScene("GreenMenu");
    }
    public void GThemes()
    {
        SceneManager.LoadScene("GreenT");
    }
    public void OMenu()
    {
        SceneManager.LoadScene("OrangeMenu");
    }
    public void OThemes()
    {
        SceneManager.LoadScene("OrangeT");
    }
    public void PMenu()
    {
        SceneManager.LoadScene("PurpleMenu");
    }
    public void PThemes()
    {
        SceneManager.LoadScene("PurpleT");
    }
}
