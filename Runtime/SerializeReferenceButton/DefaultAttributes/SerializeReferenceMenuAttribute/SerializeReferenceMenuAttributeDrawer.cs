﻿#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace ME.ECS.Essentials.GOAP {

    [CustomPropertyDrawer(typeof(SerializeReferenceMenuAttribute))]
    public class SerializeReferenceMenuAttributeDrawer : PropertyDrawer {

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return EditorGUI.GetPropertyHeight(property, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);

            var typeRestrictions = SerializedReferenceUIDefaultTypeRestrictions.GetAllBuiltInTypeRestrictions(fieldInfo);
            property.ShowContextMenuForManagedReferenceOnMouseMiddleButton(position, typeRestrictions);

            EditorGUI.PropertyField(position, property, true);
            EditorGUI.EndProperty();
        }

    }

}
#endif

