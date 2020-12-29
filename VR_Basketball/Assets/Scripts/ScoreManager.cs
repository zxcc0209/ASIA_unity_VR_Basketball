using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScroe;

    [Header("分數")]
    public int score;

    [Header("投進分數")]
    public int scorein;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "籃球")
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

    }
}
