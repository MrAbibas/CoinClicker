using UnityEngine;
using UnityEngine.Events;

public class CoinCounter : MonoBehaviour
{
    public UnityEvent<int> onCoinCountChanged;
    [SerializeField]
    private int _startCoinCount;
    private int _cointCount;
    private int coinCount
    {
        get => _cointCount;
        set
        {
            _cointCount = value;
            onCoinCountChanged?.Invoke(value);
        }
    }
    private void Start()
    {
        _cointCount = _startCoinCount;
        FindObjectOfType<CoinSpawner>().onCoinSpawned.AddListener(OnCoinSpawned);
    }
    private void OnCoinSpawned()
    {
        _cointCount--;
        if (_cointCount == 0)
            _cointCount = _startCoinCount;
    }
}
