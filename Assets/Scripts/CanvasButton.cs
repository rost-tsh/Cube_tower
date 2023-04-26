using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasButton : MonoBehaviour
{


    public Sprite musicOn, musicOff;

    private void Start()
    {
        if (PlayerPrefs.GetString("music") == "No" && gameObject.name == "Music")
            GetComponent<Image>().sprite = musicOff;
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();

    }
    public void RestartGame()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
            
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadVK() {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        Application.OpenURL("https://vk.com/id497053466");

    }

    public void MusicWork()
    {
        
        // Сейчас музыка выключена и её нужно включить
        if (PlayerPrefs.GetString("music") == "No") { 
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetString("music", "Yes");
            GetComponent<Image>().sprite = musicOn;
        } else
        {
            PlayerPrefs.SetString("music", "No");
            GetComponent<AudioSource>().Stop();
            
            GetComponent<Image>().sprite = musicOff;
        }

    }
}
