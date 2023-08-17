using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private float _jumpForce = 5f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }//Start


    void Update()
    {
        PlayerControll();

    }//Update

    private void PlayerControll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

        }

    }//PlayerControll
}
