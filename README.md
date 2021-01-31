# debug-helper

Debug helper in ui screen

## Example

### Code 

```c#
public class ExampleLog : MonoBehaviour
{
    [SerializeField] private Button _testBtn;
    [SerializeField] private InputField _inputField;

    Debugger debug;

    void Start()
    {
        _testBtn.onClick.AddListener(OnBtnTestClicked);

        debug = Debugger.Instance;
    }

    void OnBtnTestClicked()
    {
        string txt = _inputField.text;

        debug.Log(txt);
    }
}
```
