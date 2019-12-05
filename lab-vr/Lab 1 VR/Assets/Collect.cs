using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collect : MonoBehaviour
{
    public Text countText;
    public Text winText;
    private int count;
    private object col;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 2)
        {
            winText.text = "You Win!";
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Pick Up")
        {
            Destroy(gameObject);
        }
    }
}
