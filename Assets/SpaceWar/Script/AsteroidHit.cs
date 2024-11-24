using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AsteroidHit : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosion;
    [SerializeField] private GameController gameController;
    [SerializeField] private GameObject popupCanvas;

    private void Awake()
    {
            gameController = FindObjectOfType<GameController>();
    }

    public void AsteroidDestroyed()
    {
        Instantiate(asteroidExplosion, transform.position, transform.rotation);

        // calculate the score for hitting this asteroid
        float distanceFromPlayer = Vector3.Distance(transform.position, Vector3.zero);
        int bonusPoints= (int)distanceFromPlayer;

        int asteroidScore = 10 * bonusPoints;

        //Set our text for the popup -  then instiate the popup
        popupCanvas.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = asteroidScore.ToString();
        Instantiate(popupCanvas, transform.position, Quaternion.identity);

        //pass score to GameController 
        gameController.UpdatePlayerScore(asteroidScore);

        Destroy(this.gameObject);
    }
}
