﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace myStore.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("[MKTPO-8435]", Description="\t目的: 在頁面上瀏覽訂單清單\r\n\t角色: 賣家\r\n\t結果: 取得符合條件的訂單清單", SourceFile="[MKTPO-8435].feature", SourceLine=2)]
    public partial class MKTPO_8435Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "[MKTPO-8435].feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("zh-TW"), "[MKTPO-8435]", "\t目的: 在頁面上瀏覽訂單清單\r\n\t角色: 賣家\r\n\t結果: 取得符合條件的訂單清單", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("取得訂單清單", new string[] {
                "manageItems"}, SourceLine=8)]
        public virtual void 取得訂單清單()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("取得訂單清單", null, new string[] {
                        "manageItems"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.When("我發出一個Request(Get)到orders api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "當");
#line 11
 testRunner.Then("應該要回傳整個訂單清單", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "那麼");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("取得特定訂單", new string[] {
                "manageItems"}, SourceLine=13)]
        public virtual void 取得特定訂單()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("取得特定訂單", null, new string[] {
                        "manageItems"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.When("我發出一個Request(Get)到orders api,其中包含參數1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "當");
#line 16
 testRunner.Then("應該要回傳訂單item1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "那麼");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion