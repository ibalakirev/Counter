using System.Collections;
using UnityEngine;

[RequireComponent(typeof(InputReader))]

public class Counter : MonoBehaviour
{
    private InputReader _inputReader;
    private Coroutine _coroutine;
    private float _count;
    private bool _isStartCounter = false;

    void Start()
    {
        _inputReader = GetComponent<InputReader>();
    }

    private void Update()
    {
        if (_inputReader.GetInputMouse() == true)
        {
            SwitchCounter();
        }
    }

    private void SwitchCounter()
    {
        _isStartCounter = !_isStartCounter;

        if (_isStartCounter == true)
        {
            _coroutine = StartCoroutine(WaitCounter());
        }
        else
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator WaitCounter(float delay = 0.5f)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        while (enabled)
        {
            _count++;

            Debug.Log(_count);

            yield return wait;
        }
    }
}
