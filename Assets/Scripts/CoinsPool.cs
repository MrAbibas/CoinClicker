using System.Collections.Generic;
using UnityEngine;

public class CoinsPool : MonoBehaviour
{
    private Stack<Coin> coins;
    [SerializeField]
    private int _startSize;
    [SerializeField]
    private Coin _coinPrefab;
    public int Size => coins.Count;
    private void Start()
    {
        coins = new Stack<Coin>();
        for (int i = 0; i < _startSize; i++)
            AddCoinToStack();
    }
    public void Push(Coin coin)
    {
        coin.ToStartPosition();
        coins.Push(coin);
    }
    public Coin Pop()
    {
        if (coins.Count == 0)
            AddCoinToStack();
        return coins.Pop();
    }
    private void AddCoinToStack()
    {
        Coin newCoin = Instantiate(_coinPrefab, transform.position,Quaternion.identity);
        coins.Push(newCoin);
    }
}
