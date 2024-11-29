using System;
using UnityEngine;

namespace PriuAttribute
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class ButtonAttribute : PropertyAttribute
    {
        public string ButtonName { get; private set; }
        public object[] Parameters { get; private set; }

        public ButtonAttribute(string buttonName = null, params object[] parameters)
        {
            ButtonName = buttonName;
            Parameters = parameters;
        }
    }
}
