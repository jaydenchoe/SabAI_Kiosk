//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("BrainHealthChecker.QuestionPage.xaml", "QuestionPage.xaml", typeof(global::BrainHealthChecker.QuestionPage))]

namespace BrainHealthChecker {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("QuestionPage.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class QuestionPage : global::Tizen.NUI.BaseComponents.View {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.View QVirtView1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.ImageView QimgView1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel questionTitleLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.View QVirtView2;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel questionLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.Components.RadioButton RadioYes;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.Components.RadioButton RadioNo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.Components.Button NextButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private object eXamlData;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void InitializeComponent() {
            eXamlData = global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            QVirtView1 = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.View>(this, "QVirtView1");
            QimgView1 = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.ImageView>(this, "QimgView1");
            questionTitleLabel = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "questionTitleLabel");
            QVirtView2 = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.View>(this, "QVirtView2");
            questionLabel = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "questionLabel");
            RadioYes = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.RadioButton>(this, "RadioYes");
            RadioNo = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.RadioButton>(this, "RadioNo");
            NextButton = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.Button>(this, "NextButton");
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private string GetEXamlPath() {
            return default(string);
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void RemoveEventsInXaml() {
            global::Tizen.NUI.EXaml.EXamlExtensions.RemoveEventsInXaml(eXamlData);
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void ExitXaml() {
            RemoveEventsInXaml();
            global::Tizen.NUI.EXaml.EXamlExtensions.DisposeXamlElements(this);
        }
    }
}