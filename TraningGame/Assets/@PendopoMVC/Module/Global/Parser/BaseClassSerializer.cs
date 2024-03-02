using UnityEngine;
using System;
using System.Reflection;

namespace Pendopo.Core.Parser
{
    public abstract class BaseClassSerializer
    {
        public void SetValueByName(string propertyName, object value, bool _debug = false)
        {
            // Get the type of this class
            Type type = this.GetType();

            // Get the property info based on the propertyName
            PropertyInfo property = type.GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);

            // If the property is found, set its value
            if (property != null)
            {
                property.SetValue(this, Convert.ChangeType(value, property.PropertyType));
                if (!_debug) return;
                Debug.Log($"Value {value} set to property {propertyName}");
                Debug.Log(property.GetValue(this));
            }
            else
            {
                if (!_debug) return;
                Debug.Log($"Property {propertyName} not found.");
            }
        }


        public abstract void Initialize();
    }
}

