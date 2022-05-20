using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
   public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Ezlevel1":
                SceneManager.LoadScene("level1");
                break;
            case "Ezlevel2":
                SceneManager.LoadScene("level2");
                break;
            case "Ezlevel3":
                SceneManager.LoadScene("level3");
                break;
            case "Ezlevel4":
                SceneManager.LoadScene("level4");
                break;
            case "Ezlevel5":
                SceneManager.LoadScene("level5");
                break;
            case "Easy":
                SceneManager.LoadScene("SelectLevelEz");
                break;
            case "Hlevel1":
                SceneManager.LoadScene("hard1");
                break;
            case "Hlevel2":
                SceneManager.LoadScene("hard2");
                break;
            case "Hlevel3":
                SceneManager.LoadScene("hard3");
                break;
            case "Hlevel4":
                SceneManager.LoadScene("hard4");
                break;
            case "Hlevel5":
                SceneManager.LoadScene("hard5");
                break;
            case "Hard":
                SceneManager.LoadScene("SelectLevelHard");
                break;
        }
    }
}
