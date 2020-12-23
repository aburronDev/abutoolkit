using UnityEngine;

namespace aburron.abutoolkit
{
    [CreateAssetMenu(fileName = "NewStringTextArea", menuName = "aburron/abutoolkit/Variables/StringTextArea")]
    public class StringTextArea : ScriptableObject
    {
        [TextArea]
        public string currentValue;
    }
}
