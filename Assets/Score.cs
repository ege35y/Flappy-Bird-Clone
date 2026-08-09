using Unity.VisualScripting;
using UnityEngine;
public class Score : MonoBehaviour
{
    [SerializeField] private int scorePoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Score>(out Score score))
        {
            scorePoint++;
        }
        
    }
}
