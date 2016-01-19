﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace STTest.BehaviorTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ParseUnit")]
    public partial class ParseUnitFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ParseUnit.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ParseUnit", "In order to make data readable\r\nAs a support\r\nI want to convert data in a specifi" +
                    "c unit", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Eikon3 Convert data in a specific unit")]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "112", "10", "10 ms", "10", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "124", "51200", "50 MB", "0.05", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "3", "2933", "2.9 GHz", "2.9", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "39", "3", "Drive C: has 9.33 GB of free space.", "9553.92", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "4", "2147483648;2147016704", "2 GB (usable 2.0 GB)", "2048", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "6", "32", "32 bits.", "32", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "95", "50000", "50000 bps", "48.83", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "96", "60000", "60000 bps", "58.59", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "runmode", "", "", "auto", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "total", "", "", "81", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "pass", "", "", "28", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "info", "", "", "39", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "warn", "", "", "5[90,18,95,96,112]", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "alert", "", "", "9[4,63,77,42,40,111,93,59,60]", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "fail", "", "", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "other", "", "", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "product", "", "", "est", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "servname", "", "", "US1I-CTKUITK01", null)]
        [NUnit.Framework.TestCaseAttribute("ST3.xml", "envname", "", "", "AppEngine", null)]
        public virtual void Eikon3ConvertDataInASpecificUnit(string xMLResult, string statName, string statValue, string statDesc, string expectedValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Eikon3 Convert data in a specific unit", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("The Testcases are generated from {0}, {1} and {2}", statName, statValue, statDesc), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When(string.Format("Load xml result from {0}", xMLResult), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.And("Convert Testcases to TestResult object prepared for json converter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then(string.Format("The test result value for {0} should be {1}", statName, expectedValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Eikon4 Convert data in a specific unit")]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "141", "2", "2", "2", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "124", "PASS", "250 MB", "0.24", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "3", "CPUSpeedOK", "3.4 GHz", "3.4", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "39", "PREINSTALL_OK", "Drive C: has 7.51 GB of free space.", "7690.24", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "4", "memoryOK", "16 GB (15.9 GB usable)", "16384", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "6", "color_depth_ok", "32-bit", "32", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "95", "WARNING", "Download Bandwidth cannot be measured.", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "96", "WARNING", "Upload Bandwidth cannot be measured.", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "runmode", "", "", "manual", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "total", "", "", "76", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "pass", "", "", "34", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "info", "", "", "38", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "warn", "", "", "3[95,96,112]", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "alert", "", "", "1[138]", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "fail", "", "", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "other", "", "", "0", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "product", "", "", "ewm", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "servname", "", "", "US1I-CTKUITK01", null)]
        [NUnit.Framework.TestCaseAttribute("ST4.xml", "envname", "", "", "AppEngine", null)]
        [NUnit.Framework.TestCaseAttribute("ST4_1.xml", "warn", "", "", "13[36,137,21,110,1004,7,8,19,11,124,95", null)]
        [NUnit.Framework.TestCaseAttribute("ST4_1.xml", "warn.1", "", "", ",96,112]", null)]
        [NUnit.Framework.TestCaseAttribute("ST4_1.xml", "alert", "", "", "2[136,138]", null)]
        [NUnit.Framework.TestCaseAttribute("ST4_1.xml", "fail", "", "", "0", null)]
        public virtual void Eikon4ConvertDataInASpecificUnit(string xMLResult, string statName, string statValue, string statDesc, string expectedValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Eikon4 Convert data in a specific unit", exampleTags);
#line 33
 this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given(string.Format("The Testcases are generated from {0}, {1} and {2}", statName, statValue, statDesc), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.When(string.Format("Load xml result from {0}", xMLResult), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("Convert Testcases to TestResult object prepared for json converter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then(string.Format("The test result value for {0} should be {1}", statName, expectedValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
