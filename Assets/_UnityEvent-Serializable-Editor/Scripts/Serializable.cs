using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// [HelpURL("http://lmgtfy.com/?q=rick%20roll")]
[HelpURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ")]
public class Serializable : DualBehaviour
{
    #region Public Members

    public UnityEvent m_myOtherEvent = new UnityEvent();

    [System.Serializable]
    public class Life : UnityEvent<int> { }

    public Life m_myEvent = new Life();

    public Student m_student = new Student();
    
    //
    // CAUTION: Creates the object THEN set values: Can't call onValidate on instanciation (values not set yet)
    //   -> Instead, use your getter/setter directly here
    //
    public Student m_student2 = new Student() { m_test = 200 };

    #endregion

    #region Public void

    #endregion

    #region System

    public void OnValidate()
    {
        // When using the inspector, it doesn't use the getter/setter automatically

        m_student.OnValidate();
        m_student2.OnValidate();
    }

    #endregion

    #region Class Methods

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}

[System.Serializable]
public class Student
{
    // public so it appears in the inspector (Did that because the getter/setter doesn't show up)
    public int _test;

    public int m_test
    {
        get { return _test; }
        set
        {
            _test = Mathf.Clamp(value, 0, 100);
        }
    }

    public void OnValidate()
    {
        // Student doesn't herit from MonoBehaviour. Called by parent onValidate

        // Force validation through its getter/setter
        m_test = m_test;
    }
}
