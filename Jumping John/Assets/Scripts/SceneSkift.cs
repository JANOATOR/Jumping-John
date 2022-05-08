using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkift : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Her fortæller koden egentlig bare at når vores spilscene lægger som 1 i vores buildindex ville den skifte fra vores Start-screen til vores spil-screen.
    }
}
