using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BezierLine : MonoBehaviour
{
    public Transform start;           // 起点
    public Transform[] waypoints;     // 贝塞尔曲线的控制点
    public int resolution;            // 曲线的分辨率
    public LineRenderer lineRenderer; // LineRenderer 组件
    public Transform go;              // 用于显示当前位置的物体
    public Button[] btn;


    public Transform[] waypoints_short;

    private void Awake()
    {
        btn[0].onClick.AddListener(Click1);
        btn[1].onClick.AddListener(Click2);
        btn[2].onClick.AddListener(Click3);
    }

    void Click1()
    {
        go.position = start.position;
        // 获取控制点的位置
        Vector3[] positions = new Vector3[waypoints.Length];
        for (int i = 0; i < waypoints.Length; i++)
        {
            positions[i] = waypoints[i].position;
        }

        go.DOPath(positions, 5f, PathType.CubicBezier, PathMode.TopDown2D, resolution, Color.red).SetEase(Ease.Linear)
            .SetLookAt(0, Vector3.forward, Vector3.right);
    }

    void Click2()
    {
        go.position = start.position;
        // 获取控制点的位置
        Vector3[] positions = new Vector3[waypoints_short.Length];
        for (int i = 0; i < waypoints_short.Length; i++)
        {
            positions[i] = waypoints_short[i].position;
        }

        go.DOPath(positions, 5f, PathType.CubicBezier, PathMode.TopDown2D, resolution, Color.red).SetEase(Ease.Linear)
            .SetLookAt(0, Vector3.forward, Vector3.right);
    }

    void Click3()
    {
        go.position = start.position;
        Vector3 endPos = new Vector3(start.position.x, start.position.y + 20f, start.position.z);
        Vector3 one = new Vector3(start.position.x + 3f, start.position.y + 20f / 3, start.position.z);
        Vector3 two = new Vector3(start.position.x - 3f, start.position.y + 20f / 3 * 2, start.position.z);
        go.DOPath(new Vector3[] { endPos, one, two }, 5f, PathType.CubicBezier, PathMode.TopDown2D, resolution,
                Color.red)
            .SetEase(Ease.Linear)
            .SetLookAt(0, Vector3.forward, Vector3.right);
    }

    void Start()
    {
        // 获取贝塞尔曲线的绘制点
        // Vector3[] drawPoints = DOTween.PathGetDrawPoints(positions, resolution, PathType.CatmullRom);
        // 将绘制点赋值给 LineRenderer
        // lineRenderer.positionCount = drawPoints.Length;
        // lineRenderer.SetPositions(drawPoints);
    }
}