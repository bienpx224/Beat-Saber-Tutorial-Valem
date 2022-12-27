using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCubeController : MonoBehaviour
{
    [SerializeField] private GameObject[] _cubePrefab;
    [SerializeField] private Transform[] _points;
    private float _countDownTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _countDownTime -= Time.deltaTime;
        if (_countDownTime < 0f)
        {
            _countDownTime = Random.Range(3,8);
            int rd = Random.Range(0, _cubePrefab.Length);
            Debug.Log("Spawning cube index:" + rd);
            var cube = Instantiate(_cubePrefab[rd], _points[Random.Range(0, _points.Length)].position, transform.rotation);
            
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
        }

    }
}
