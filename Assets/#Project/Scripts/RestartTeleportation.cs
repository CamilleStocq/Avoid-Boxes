using UnityEngine;

public class RestartTeleportation : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //est ce que c'est le player qui est detecté ?
        {
            // Debug.Log(" un cube touché");
            other.transform.position = spawnPoint.position; // si c'est le player on le teleporte au spawnPoint
        }
    }
}
