using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Her har vi lavet en variabel med transform som hedder target
    public Vector3 offset; // Her er der lavet en variabel med en Vector3 som kaldes offset
    [Range(1,10)] // Her er der en range som vælger mellem 1 og 10
    public float smoothFactor; // Og her er en variabel som kaldes smoothFactor, som vi skal justere senere hen i processen.

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset; // Her fortæller koden at vores Vector3 target er = med vores target.position + vores offset som er lavet af denne her Vector3 variabel.
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition,smoothFactor*Time.fixedDeltaTime); // Her har vi så lavet vores Vector3 smoothPosition som er lavet af vores Vector3 Lerp med vores variabler.

        transform.position = smoothPosition; // Og her fortæller vores kode at transform.position er = med vores smoothPosition
    }
}
