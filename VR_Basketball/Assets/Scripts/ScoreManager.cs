using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScroe;

    [Header("分數")]
    public int score;

    [Header("投進分數")]
    public int scorein =2;

    [Header("進球音效")]
    public AudioClip soundin;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "籃球"　&& other.transform.position.y>4)
        {
            AddScroe();
        }
        if (other.transform.root.name =="Player")
        {
            scorein = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name =="Player")
        {
            scorein = 2;

        }
    }
    private void AddScroe()
    {
        score += scorein;
        textScroe.text = "分數:" + score;
        aud.PlayOneShot(soundin, Random.Range(1f, 10f));

    }
}
