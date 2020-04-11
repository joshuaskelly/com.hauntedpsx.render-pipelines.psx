using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using HauntedPSX.RenderPipelines.PSX.Runtime;

namespace HauntedPSX.RenderPipelines.PSX.Editor
{
    [CanEditMultipleObjects]
    [VolumeComponentEditor(typeof(QualityOverrideVolume))]
    public class QualityOverrideVolumeEditor : VolumeComponentEditor
    {
        SerializedDataParameter m_IsPSXQualityEnabled;

        public override void OnEnable()
        {
            var o = new PropertyFetcher<QualityOverrideVolume>(serializedObject);
            m_IsPSXQualityEnabled = Unpack(o.Find(x => x.isPSXQualityEnabled));
        }

        public override void OnInspectorGUI()
        {
            PropertyField(m_IsPSXQualityEnabled, EditorGUIUtility.TrTextContent("Is PSX Quality Enabled", "Controls whether or not the PSX + CRT simulation is rendering."));
        }
    }
}