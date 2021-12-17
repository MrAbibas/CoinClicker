using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoinCounter : MonoBehaviour
{
    public UnityEvent<int> onCoinCountChanged;
    [SerializeField]
    private int _startCoinCount;
    private int _coinCount;
    private int coinCount
    {
        get => _coinCount;
        set
        {
            _coinCount = value;
            onCoinCountChanged?.Invoke(value);
        }
    }
    private void Awake()
    {
        onCoinCountChanged = new UnityEvent<int>();
    }
    private IEnumerator Start()
    {
        FindObjectOfType<CoinSpawner>().onCoinSpawned.AddListener(OnCoinSpawned);
        yield return null;
        coinCount = _startCoinCount;
    }
    private void OnCoinSpawned()
    {
        coinCount--;
        if (coinCount == 0)
            coinCount = _startCoinCount;
    }
}
