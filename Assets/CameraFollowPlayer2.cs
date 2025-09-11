using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    //private Camera cam;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 pos = new Vector3(0f, 5f, -10f);
    [SerializeField] private float speed = 5f;

    //void Start()
    //{
    //    cam = this.gameObject.GetComponent<Camera>();
    //}

    void Update()
    {
        if (player == null) return;

        Vector3 endPosition = player.position + offset;
        Vector3 posLerp = Vector3.Lerp(transform.position, endPosition, speed * Time.deltaTime); // transition douce
        transform.position = posLerp; // position actuelle == nouvelle position
        transform.LookAt(player); // toujouurs regarder le player
    }
}