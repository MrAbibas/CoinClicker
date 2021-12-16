using UnityEngine;
using UnityEngine.Events;

public class CoinSpawner : MonoBehaviour
{
    public UnityEvent onCoinSpawned;
    [SerializeField]
    private CoinsPool _coinsPool;
    void Start()
    {
        onCoinSpawned = new UnityEvent();
        Spawn();
    }
    public void Spawn()
    {
        Coin coin = _coinsPool.Pop();
        coin.Fall(transform.position);
        onCoinSpawned?.Invoke();
    }
}
