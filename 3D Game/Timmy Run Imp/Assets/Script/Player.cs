using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 30f;
    [SerializeField]
    private Rigidbody rb;
    public bool jump = false;
    public bool slide = false;
    private TextMeshProUGUI scoreText;
    public int score;
    public Transform holder;
    private Transform transform;
    [SerializeField]
    private AudioClip EatSound;
    private AudioSource audioSource;
    public GameObject disDisplay;
    static public bool canMove = false;
    public Animator animator;
    // Start is called before the first frame update

    void Start()
    {
        levelStarter starter = GetComponent<levelStarter>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        transform = GetComponent<Transform>();
        scoreText = holder.Find("score").GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score :" + score;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > levelBoundry.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < levelBoundry.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed * -1);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            slide = true;
        }
        else
        {
            slide = false;
        }

        if (jump == true)
        {
            animator.SetBool("isJump", jump); transform.Translate(0, 0.35f, 0.05f);
        }
        else if (jump == false)
        {
            animator.SetBool("isJump", jump);
        }
        if (slide == true)
        {
            animator.SetBool("isSlide", slide); transform.Translate(0, 0, 0.3f);
        }
        else if (slide == false)
        {
            animator.SetBool("isSlide", slide);
        }


    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.CompareTag("coins"))
        {
            score += 10;
            scoreText.text = ("Score = " + score);
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            speed = 0;
            animator.SetBool("isDead", true);
            StartCoroutine(Lose());
        } 
        if (collision.collider.CompareTag("EndPoint"))
        {
            speed = 0;
            transform.Rotate(0, 180, 0);
            animator.SetBool("isWin", true);
            StartCoroutine(Win());
        }

    }

    private IEnumerator Lose()
    {
        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene("loser");

    }
    private IEnumerator Win()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Win");

    }

}
