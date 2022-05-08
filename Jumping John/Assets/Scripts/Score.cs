using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public static float myScore; // Her laver vi en publib static float som vi kalder for myScore, fordi det skal symboler at det er vores score.   
    public TMP_Text Tekst; // Så laver vi en variabel til vores TMP_Text som vi egentlig bare kalder Tekst, så det er nemt at have gøre med.
    public Canvas Counter; // Og så laver vi en variabel til vores Canvas som vi kalder for Counter.

    void Start()
    {

        Tekst.text = ControllerPlayer.tal.ToString(); // Her fortæller koden blot at den skal starte med en string til vores player og vores Canvas ville være slået til med Counteren.
        Counter.enabled = true;

    }

    void Update()
    {

        Tekst.text = ControllerPlayer.tal.ToString() + " m"; // Her fortæller koden at vores string skal være et mellemrum efterfulgt med "m" som skal symbolere meter, så når du kommer op i luften ville counteren tælles op.

    }
}
