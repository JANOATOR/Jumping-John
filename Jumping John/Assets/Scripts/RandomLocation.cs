using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour
{
    private int[] LocationX = {2, 3, -2, 1}; // Her har vi lavet en "int" variable, som gøre at vi har en masse koordinatere som den skal kunne flytte sig hen senere hen i koden.
    public float LocationY; // Her har vi lavet en variable som hedder LocationY i dette tilfælde. Dette skal symbolere at det er Y-axen vi skal lege med her.
    public float LocationZ; // Her har vi lavet en variable som hedder LocationZ i dette tilfælde. Det er for at symbolere at vi skal lege med Z koordinaten. 
    public int i; // Her er der lavet en int-variable som vi kalder "i"
    public int PlatformNumber; // Her er der lavet en int variable mere som vi kalder for "PlatformNumber" 
    
    
    void Start()
    {
        PlatformNumber = (Random.Range(0, 4));  // Denne her fortæller at vores PlatformNumber vælger en random range mellem 0 og 4
        LocationY = transform.position.y; // Her forbinder vi vores float med vores transform.position i de forskellige koordinater så de kan fungere.
        LocationZ = transform.position.z; // Det samme som oven men i det her tilfælde er det bare med z koordinaten.
        transform.position = new Vector3(LocationX[PlatformNumber], LocationY, LocationZ); // Og her samler vi det i en Vector3 med alle vores Location's samt vores PlatformNumber

    }

  
}
