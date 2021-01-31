using DebugHelper;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is example of DebugHelper usage
/// </summary>
public class ExampleLog : MonoBehaviour
{
    [SerializeField] private Button _testBtn;
    [SerializeField] private InputField _inputField;

    Debugger debug;

    void Start()
    {
        _testBtn.onClick.AddListener(OnBtnTestClicked);

        //Get singleton reference
        debug = Debugger.Instance;
    }

    /// <summary>
    /// Get text from input field and display to Debugger
    /// </summary>
    void OnBtnTestClicked()
    {
        string txt = _inputField.text;

        debug.Log(txt);
    }
}
