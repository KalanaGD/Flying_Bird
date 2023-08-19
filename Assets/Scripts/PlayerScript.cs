using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{

    [SerializeField] private float _jumpForce = 5f;
    private Rigidbody2D _rb;
    private int coins = 0;

    [SerializeField] private Text coinText;
    public GameObject gameoverpanel;


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

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "coin")
        {
            Destroy(target.gameObject);
            coins++;
            coinText.text = "Score : " + coins;
           
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "bounder")
        {
            Destroy(this.gameObject);
            gameoverpanel.SetActive(true);

        }
    }




}
