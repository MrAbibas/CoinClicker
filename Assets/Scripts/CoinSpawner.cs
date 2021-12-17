using UnityEngine;
using UnityEngine.Events;

public class CoinSpawner : MonoBehaviour
{
    public UnityEvent onCoinSpawned;
    [SerializeField]
    private CoinsPool _coinsPool;
    private void Awake()
    {
        onCoinSpawned = new UnityEvent();
    }
    public void Spawn()
    {
        Coin coin = _coinsPool.Pop();
        coin.Fall(transform.position);
        onCoinSpawned?.Invoke();
    }
}
