using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Minseok.Main
{
    public class Main_VideoOption : MonoBehaviour
    {
        FullScreenMode _screenMode;
        public TMP_Dropdown _resolutionDropdown;
        public Toggle _fullscreenBtn;
        List<Resolution> resolutions = new List<Resolution>();
        int _resolutionNum;

        void Start()
        {
            InitUI();
        }

        void InitUI()
        {
            resolutions.AddRange(Screen.resolutions);
            resolutions.Reverse();
            _resolutionDropdown.options.Clear();

            int optionNum = 0;
            foreach (Resolution item in resolutions)
            {
                TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
                option.text = item.width + "x" + item.height;
                _resolutionDropdown.options.Add(option);

                if (item.width == Screen.width && item.height == Screen.height)
                    _resolutionDropdown.value = optionNum;
                optionNum++;
            }

            _resolutionDropdown.RefreshShownValue();

            _fullscreenBtn.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
        }

        public void DropboxOptionChange(int x)
        {
            _resolutionNum = x;
        }

        public void FullScreenBtn(bool isFull)
        {
            _screenMode = isFull ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
        }

        public void OkBtnClick()
        {
            Screen.SetResolution(resolutions[_resolutionNum].width, resolutions[_resolutionNum].height, _screenMode);
        }
    }
}

