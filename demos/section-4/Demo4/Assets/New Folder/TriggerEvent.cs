using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class trigger : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = " " + score;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        RingtossRing ring = other.attachedRigidbody?.GetComponent<RingtossRing>();
        if (ring != null)
        {
            GameObject.Destroy(ring.gameObject);
            score += 1;
            scoreText.text = " " + score;
        }
    }
}
