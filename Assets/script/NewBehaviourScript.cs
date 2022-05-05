using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score;
    public Text scoreText;
    public Text wintext;
    public Text timertext;
    public int timeleft;
    private bool playable;
    public GameObject retry1;
    public GameObject next1;
    public GameObject menu1;
    IEnumerator Losttime()
    {
        while (timeleft > 0)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playable = true;
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        wintext.text = "";
        StartCoroutine("Losttime");
        retry1.SetActive(false);
        next1.SetActive(false);
        menu1.SetActive(false);
    }
    void SetScoreText()
    {
        scoreText.text = "Score=" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timertext.text = "Time= " + timeleft;
        if (timeleft <= 0 && score <= 100)
        {
            wintext.text = "YOU LOSE";
            playable = false;
            retry1.SetActive(true);
            menu1.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (playable)
        {
            rb.AddForce(movement * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
           
            other.gameObject.SetActive(false);
            score += 1;
            SetScoreText();
            if (score >= 100)
            {
                wintext.text = "YOU WIN";
                playable = false;
                StopCoroutine("Losttime");
                retry1.SetActive(true);
                next1.SetActive(true);
                menu1.SetActive(true);
            }
        }
    }
}