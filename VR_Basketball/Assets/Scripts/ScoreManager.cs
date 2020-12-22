using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text text;
    [Header("分數")]
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}
