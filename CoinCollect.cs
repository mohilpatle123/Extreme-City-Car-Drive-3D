using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int coins = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
            Debug.Log("Coins: " + coins);
        }
    }
}
