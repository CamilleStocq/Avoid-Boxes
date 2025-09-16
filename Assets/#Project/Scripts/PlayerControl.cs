using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // [SerializeField] private InputAction jump;

    [SerializeField] private InputActionAsset actions;
    [SerializeField] private float speed = 1f; // vitesse du cube
    // [SerializeField] private float jumpForce = 3f; // puissance du saut

    // private Rigidbody rb;
    private InputAction xAxis;
    // private bool isGrounded = true;
    private PlayerControl playerControl;

    void Awake()
    {
        xAxis = actions.FindActionMap("CubeActionsMap").FindAction("XAxis");

        // //Jump
        // jump = actions.FindAction("Jump");
        // jump.performed += ctx => OnJump();
        // rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        // jump.performed += x => { OnJump(); };
        playerControl = GetComponent<PlayerControl>();
    }

    void OnEnable()
    {
        actions.FindActionMap("CubeActionsMap").Enable();
        // jump.Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("CubeActionsMap").Disable();
        // jump.Disable();
    }

    void Update()
    {
        MoveX();
        MoveZ();
    }

    void MoveZ()
    {
        transform.position += speed * Time.deltaTime* transform.forward; // move de l'avant
    }

    private void MoveX()
    {
        float xMove = xAxis.ReadValue<float>();
        transform.position += speed * Time.deltaTime * xMove * transform.right; // move de gauche à droite
    }

    // private void OnJump()
    // {
    //     // Debug.Log("Jump !");
    //     if (isGrounded) // si il touche le sol
    //     {
    //         rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // ajoute de la force pour qu'il saute
    //         isGrounded = false; // donc il ne touche plus le sol et on peut pas faire de double saut
    //     }
    // }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Ground"))// si contact avec un objet qui a un tag "ground" alors contact est vrai
    //     {
    //         isGrounded = true;
    //     }
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Finish"))
    //     {
    //         playerControl.speed = 0;
    //     }
    // }
}
