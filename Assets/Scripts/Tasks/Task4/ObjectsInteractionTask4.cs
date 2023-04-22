using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    [SerializeField] private Toaster _toaster;
    [SerializeField] private Transform _waffleRoot;
    [SerializeField] private GameObject _wafflePrefab;

    private void Awake()
    {
        _toaster.TimerIsUp += ToasterOnTimerIsUp;
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= ToasterOnTimerIsUp;
    }

    private void ToasterOnTimerIsUp()
    {
        Instantiate(_wafflePrefab, _waffleRoot);
    }
}