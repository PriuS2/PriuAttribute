using System;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
namespace PriuAttribute
{
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class ButtonAttributeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            // 타겟 MonoBehaviour 객체 가져오기
            MonoBehaviour targetMonoBehaviour = (MonoBehaviour)target;
            Type targetType = targetMonoBehaviour.GetType();

            // MonoBehaviour의 모든 메서드 탐색
            foreach (var methodInfo in targetType.GetMethods(
                         System.Reflection.BindingFlags.Instance |
                         System.Reflection.BindingFlags.Public |
                         System.Reflection.BindingFlags.NonPublic))
            {
                // ButtonAttribute가 붙은 메서드만 필터링
                var buttonAttribute = (ButtonAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(ButtonAttribute));
                if (buttonAttribute != null)
                {
                    // 버튼 이름 설정
                    string buttonName = !string.IsNullOrEmpty(buttonAttribute.ButtonName) 
                        ? buttonAttribute.ButtonName 
                        : methodInfo.Name;

                    // 버튼 렌더링
                    if (GUILayout.Button(buttonName))
                    {
                        try
                        {
                            // 메서드 호출
                            methodInfo.Invoke(targetMonoBehaviour, buttonAttribute.Parameters);
                        }
                        catch (Exception e)
                        {
                            Debug.LogError($"Failed to invoke method '{methodInfo.Name}': {e.Message}");
                        }
                    }
                }
            }
        }
    }
}
#endif
