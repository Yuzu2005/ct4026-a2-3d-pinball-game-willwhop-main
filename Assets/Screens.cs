using UnityEngine;
using UnityEngine.SceneManagement;

public class Screens : MonoBehaviour {        
    void Awake() {
        //locks cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;                   
    }
    //goes to level that is written on the on click
    public void GoToLevel(string destinationLevel) {
        SceneManager.LoadScene(destinationLevel);
    }
    //loads the secret level
    public void GoToSecretLevel2() {
        SceneManager.LoadScene("GoToSecretLevel2");
    }
    public void GoToLevel2() {
        SceneManager.LoadScene("GoToLevel2");
    }
    public void GoToMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame() {
        Application.Quit();
    }
    //used for changing resolution
    public void ScreenRes(string Index) {
        switch (Index) {
            case "res1":
                Screen.SetResolution(1920, 3520, true);
                break;
            case "res2":
                Screen.SetResolution(1920, 4180, true);
                break;
            case "res3":
                Screen.SetResolution(1920, 4246, true);
                break;            
        }
    }
}
