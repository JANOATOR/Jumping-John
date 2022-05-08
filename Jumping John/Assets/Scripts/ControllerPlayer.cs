using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{

    private float fart = 6; // Her laver vi en variable på selve fart floatet på vores karakter
    private float hop = 175; // Her laver vi en variable om selve højden som vores karakter skal hoppe
    private bool Right; // Her laver vi en variable om den vej han skal hen, i dette tilfælde er det højre.
    private bool Left; // Her laver vi en variable om den anden vej han skal gå og det er venstre side.
    public Rigidbody rb; // Her laver vi en variable til vores Rigidbody2D som ligesom er den som er med til at give ham tyngdekraften.
    public bool inAir = false; // Her laver vi en variable som hedder inAir, som skal symboler at når han er i luften ville den blive tjekket.
    public static int tal; // Her laver vi en variable til vores int som vi i dette tilfælde kalder for tal
    public static string up = "w"; // Her laver vi en variable til vores strings i dette tilfælde er det "w" vi har at gøre med fordi det skal være vores hoppe knap
    public static string rightmove = "d"; // Her laver vi endnu en variable til vores strings og denne her er "d" fordi den skal vi bruge til når vi skal gå til høire
    public static string leftmove = "a"; // Og denne her er også en variable ligesom den over men hvor denne her bare er til at gå til venstre.
    public Animator animator; // Og dette er en variable til vores animator, da vores karakter har en animation til når han hopper.

    void Update()
    
    {
        if ((Left == true) || (Right == true))
        {
            transform.Translate(Vector3.left * Time.deltaTime * fart);
        }


        if (Input.GetKeyDown(rightmove)) // Her kan du se et if-statement som viser at ligeså snart at vores knap er nede så ville "Right" være true og så ville han gå til højre.
        {
            Right = true;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (Input.GetKeyUp(rightmove)) // Her viser den så et if-statement til ligeså snart at vi ikke længere holder knappen nede at så slår den "Right" fra så den ikke går mod højre mere.
        {
            Right = false;
        }

        if (Input.GetKeyDown(leftmove)) // Og her er det egentlig det samme som i linje 29 bare hvor det gælder venstre i stedet for når knappen holdes nede.
        {
            Left = true;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (Input.GetKeyUp(leftmove)) // Og her viser den at ligeså snart at knappen er oppe så stopper den med at gå til venstre.
        {
            Left = false;
        }

        if (Input.GetKeyDown(up)) // Her viser koden egentlig bare at ligeså snart du ikke holder knappen nede på "w" så ville den ikke hoppe og "inAir" ville være slået fra.
        {
            if (inAir == false)
            {
                rb.AddForce(Vector2.up * hop);
                inAir = true;
                animator.SetFloat("Hop", 1);
            }
            
        }

        if (transform.position.y > -3.25f)
        {
            Score.myScore = (transform.position.y + 3.25f);
            int i = (int)Mathf.Round(Score.myScore);
            tal = i;
        }

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            inAir = false;
            animator.SetFloat("Hop", 0);
        }
    }
}
