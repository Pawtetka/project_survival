using System;
using UnityEngine;

namespace Infrastructure.GameLogic.Input
{
    public class InputModel
    {
        public Vector3 MousePosition => OnGetMousePosition?.Invoke() ?? Vector3.zero;
        public float VerticalAxisInput => OnGetVerticalAxisInput?.Invoke() ?? 0;
        public float HorizontalAxisInput => OnGetHorizontalAxisInput?.Invoke() ?? 0;

        public event Func<Vector3> OnGetMousePosition;
        public event Func<float> OnGetVerticalAxisInput;
        public event Func<float> OnGetHorizontalAxisInput;
    }
}