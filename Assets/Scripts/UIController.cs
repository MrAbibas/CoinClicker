using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Button _spawnButton;
    [SerializeField]
    private TMP_Text _coinCountText;
    private CoinCounter _coinCounter;
    private CoinSpawner _coinSpawner;
    private void Start()
    {
        _coinSpawner = FindObjectOfType<CoinSpawner>();
        _coinCounter = FindObjectOfType<CoinCounter>();

        _coinCounter.onCoinCountChanged.AddListener((x) => _coinCountText.text = x.ToString());
        _spawnButton.onClick.AddListener(_coinSpawner.Spawn);
    }
}
