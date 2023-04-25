using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Reference to the player's GameObject
    public GameObject player;

    // Reference to the box collider on the object that triggers the scene change
    public BoxCollider2D sceneTriggerCollider;

    // The name of the scene to load
    public string sceneToLoad;

    // Detects collision with the player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            // Load the scene when collision occurs
            Debug.Log("testing");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
