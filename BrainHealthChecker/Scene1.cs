﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Applications;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Xaml;

namespace BrainHealthChecker
{
    public class Scene1 : NUIApplication
    {
        public static View g_pre_view = null;
        override protected void OnCreate()
        {
            base.OnCreate();

            // NOTE To use theme.xaml, uncomment below line.
            // ThemeManager.ApplyTheme(new Theme(Tizen.Applications.Application.Current.DirectoryInfo.Resource + "theme/theme.xaml"));
            View view = new Scene1Page();
            g_pre_view = view;
            GetDefaultWindow().Add(view); // 시작화면
            //GetDefaultWindow().Add(new Scene2Page()); // login창용
            //GetDefaultWindow().Add(new Scene3Page()); // 서비스선택창
            //GetDefaultWindow().Add(new QuestionPage()); // 질문창
            //GetDefaultWindow().Add(new ResultPage());

            GetDefaultWindow().KeyEvent += OnScene1KeyEvent;
        }

        private void OnScene1KeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        override protected void OnPause()
        {
            base.OnPause();
        }

        override protected void OnResume()
        {
            base.OnResume();
        }

        override protected void OnTerminate()
        {
            base.OnTerminate();
        }

        override protected void OnAppControlReceived(AppControlReceivedEventArgs e)
        {
            base.OnAppControlReceived(e);
        }
    }
}
