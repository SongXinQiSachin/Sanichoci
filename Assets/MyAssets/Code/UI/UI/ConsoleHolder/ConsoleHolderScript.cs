using Sanichoci.ConsoleCommand;
using Sanichoci.Kits;
using Sanichoci.Logic.Arithmetic;
using Sanichoci.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sanichoci.UI
{
    public class ConsoleHolderScript : MonoBehaviour
    {
        public bool isConsoleEnable = true;
        bool isConsoleInAnimation = false;
        private bool isConsoleVisible = false;

        Transform _holderTransform;
        RectTransform rt_holderRectTransform;

        Transform consoleOutput;
        Transform commandInput;

        Text tx_consoleOutput;
        InputField if_commandInput;

        float holderHeight;

        private void Awake()
        {
        }

        private void Start()
        {
            _holderTransform = transform;
            rt_holderRectTransform = GetComponent<RectTransform>();

            consoleOutput = _holderTransform.FindChild("ConsoleOutput");
            commandInput = _holderTransform.FindChild("CommandInput");

            tx_consoleOutput = consoleOutput.GetComponent<Text>();
            if_commandInput = commandInput.GetComponent<InputField>();

            holderHeight = rt_holderRectTransform.rect.height;

            ConsoleCommandManager.Instance.AddConsoleShowMessageFunc(AppendTextToConsole);

            StartCoroutine(SwitchConsoleVisible());
        }

        public void OnCommandEndEdit(String str)
        {
            if (InputManager.Instance.IsKeyDown(KeyCode.Return) && isConsoleVisible)
            {
                string cmd = if_commandInput.text;
                if (!IsCommandVaild(cmd))
                {
                    AppendTextToConsole(cmd + " is not a vaild command");
                }
                else
                {
                    AppendTextToConsole(cmd);
                    ICommand command = ParseCommand(cmd);

                    if (command == null)
                    {
                        AppendTextToConsole("Cannot find command \"" + cmd + "\"");
                    }
                    else
                    {
                        command.Run();
                    }
                }

                if_commandInput.text = "";
                SetFocusOnInputfield();
            }
        }

        public bool IsCommandVaild(string cmd)
        {
            if (cmd[0] != '-')
            {
                return false;
            }

            return true;
        }

        public void AppendTextToConsole(string text)
        {
            if (tx_consoleOutput.text.Length > 0)
            {
                tx_consoleOutput.text += "\n";
            }
            tx_consoleOutput.text += (">" + text);
        }

        public ICommand ParseCommand(string cmd)
        {
            int divideIndex = cmd.IndexOf(" ");
            string cmdMain = "";
            string cmdParameter = "";
            if (0 > divideIndex)
            {
                cmdMain = cmd.Substring(1, cmd.Length - 1);
            }
            else
            {
                cmdMain = cmd.Substring(1, divideIndex - 1);
                cmdParameter = cmd.Substring(divideIndex + 1, cmd.Length - divideIndex - 1);
            }

            return ConsoleCommandManager.Instance.CreateCommandInstance(cmdMain, cmdParameter);
        }


        IEnumerator SwitchConsoleVisible()
        {
            while (!GameManager.Instance.IsExit)
            {
                if (IsConsoleNeedSwitched())
                {
                    if (!isConsoleInAnimation)
                    {
                        ConsoleAnimation();
                    }

                    if (isConsoleVisible)
                    {
                        SetFocusOnInputfield();
                    }
                    else
                    {
                        RemoveFocusFromInputfield();
                    }
                    RemoveBackslashFromCommand();
                }

                yield return null;
            }

            yield return null;
        }

        public void SetFocusOnInputfield()
        {
            if (isConsoleEnable)
            {
                if_commandInput.ActivateInputField();
                //if_commandInput.Select();
            }
        }

        public void RemoveFocusFromInputfield()
        {
            if_commandInput.OnDeselect(new BaseEventData(EventSystem.current));
        }


        bool IsConsoleNeedSwitched()
        {
            return InputManager.Instance.IsKeyDown(KeyCode.Backslash);
        }

        void RemoveBackslashFromCommand()
        {
            string cmd = if_commandInput.text;
            if (cmd.Length != 0)
            {
                char lastCharOfCmd = cmd[cmd.Length - 1];
                if (lastCharOfCmd.Equals('\\'))
                {
                    if_commandInput.text = cmd.Substring(0, cmd.Length - 1);
                }
            }
        }

        private void ConsoleAnimation()
        {

            Vector3 oldPos = _holderTransform.localPosition;
            Vector3 newPos = oldPos;

            IArithmetic arithmetic = new Arithmetic(new DecelerateInterpolator(1.618f), 1);
            float time = 0;
            arithmetic.Start(
                () =>
                {
                    isConsoleVisible = !isConsoleVisible;
                    isConsoleInAnimation = true;
                },
                (percent) =>
                {
                    time += TimeKits.deltaTime();
                    newPos.y = isConsoleVisible ? oldPos.y - percent * holderHeight : oldPos.y + percent * holderHeight;
                    _holderTransform.localPosition = newPos;
                },
                () =>
                {
                    _holderTransform.localPosition = oldPos - (isConsoleVisible ? new Vector3(0, holderHeight, 0) : new Vector3(0, -holderHeight, 0));

                    isConsoleInAnimation = false;
                }
            );
        }
    }
}
