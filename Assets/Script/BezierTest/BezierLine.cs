using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BezierLine : MonoBehaviour
{
    public Transform[] waypoints;     // 贝塞尔曲线的控制点
    public int resolution;            // 曲线的分辨率
    public LineRenderer lineRenderer; // LineRenderer 组件
    public Transform go;              // 用于显示当前位置的物体

    void Start()
    {
        // 获取控制点的位置
        Vector3[] positions = new Vector3[waypoints.Length];
        for (int i = 0; i < waypoints.Length; i++)
        {
            positions[i] = waypoints[i].position;
        }

        go.DOPath(positions, 5f, PathType.CubicBezier, PathMode.TopDown2D, resolution, Color.red).SetEase(Ease.Linear).SetLookAt(0);
        // 获取贝塞尔曲线的绘制点
        // Vector3[] drawPoints = DOTween.PathGetDrawPoints(positions, resolution, PathType.CatmullRom);
        // 将绘制点赋值给 LineRenderer
        // lineRenderer.positionCount = drawPoints.Length;
        // lineRenderer.SetPositions(drawPoints);
    }
}