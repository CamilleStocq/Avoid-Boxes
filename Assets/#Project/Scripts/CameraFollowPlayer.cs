using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float position;

    void Start()
    {
        cam = this.gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        
    }
}
