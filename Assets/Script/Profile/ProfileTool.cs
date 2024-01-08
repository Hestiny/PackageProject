using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

public class ProfileTool : MonoBehaviour
{
    public Canvas[] canvas;
    public Button btn;
    

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            StartCoroutine(Test());
        });
    }

    private IEnumerator Test()
    {
        SetSiblingTest();
        yield return new WaitForSeconds(1f);
        SetOrderTest();
    }

    private void SetSiblingTest()
    {
        Profiler.BeginSample("====SetSiblingTest");
        for (int i = 0; i < 10000; i++)
        {
            foreach (var item in canvas)
            {
                item.transform.SetSiblingIndex(0);
            }
        }
        Profiler.EndSample();
    }

    private void SetOrderTest()
    {
        Profiler.BeginSample("====SetOrderTest");
        for (int i = 0; i < 10000; i++)
        {
            foreach (var item in canvas)
            {
                item.sortingOrder += 10;
            }
        }
        Profiler.EndSample();
    }
}