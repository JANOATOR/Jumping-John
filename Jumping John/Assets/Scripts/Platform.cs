using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float tjek = 0; // Her laver vi en variable som float og i denne gang har vi navngivet den tjek.

    void Update()
    {
        if (tjek == 0)
        {
            if (transform.position.x < 2.65f) // Her laver den et if-statement for at hvis vores transform.position i x-aksen er mindre end 2.65f så ville vores transform translate gange vores Vector3.right med vores DeltaTime og gange det med 4
            {
                transform.Translate(Vector3.right * Time.deltaTime * 4);
            }
            else if (transform.position.x > 2.64f) // Og her er der et if-statement for hvis vores transform position i x-aksen er højrer end 2.64f så ville vores tjek float blive 1
            {
                tjek = 1;
            }
        }
        else if (tjek == 1)
        {
            if (transform.position.x > -3.0f) // Hernede gøre den egentlig det samme som de forrige if-statements over men denne her gang er vores tjek på 1 og ikke på 0 som den er i oppe i den anden kode.
            {
                transform.Translate(Vector3.left * Time.deltaTime * 4);
            }
            else if (transform.position.x < -2.99f)
            {
                tjek = 0;
            }
        }
    }
}
