using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    [SerializeField] private Shelf _shelf;
    private int _countSpawnedObjects;

    private void Awake()
    {
        _shelf.ItemSpawned += OnItemSpawned;
    }

    private void OnDestroy()
    {
        _shelf.ItemSpawned -= OnItemSpawned;
    }
    private void OnItemSpawned()
    {
        _countSpawnedObjects++;

        if (_countSpawnedObjects >= 3)
        {
            _shelf.Fall();
        }
    }
}