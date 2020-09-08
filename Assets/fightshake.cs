using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightshake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.activeSelf)
            StartCoroutine(Shake(2f, .4f));
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
        gameObject.SetActive(false);
    }
}
