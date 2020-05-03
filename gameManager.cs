using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    public void gameOver()
    {
        
        print("GAME OVER.");
        Invoke("reloadScene", 3);
        Invoke("sbros", 3);
       
    }
    public void gameWin()
    {
        Invoke("konec", 3);
    }

    void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void sbros()
    {
        lifeScript.lifeValue = 1;
        winScript.winValue = 0;
    }
    void endgame()
    {
        lifeScript.lifeValue = 1;
    }

    void konec()
    {
        Application.LoadLevel("gameover");
    }

}
