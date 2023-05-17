﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BillingAndPatientCreationTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AsAUserIWantTheVisitCreationAccessRightsSoThatICanCreateVisitsOfDifferentTypes_DemoUsingSCENARIOOUTLINESEXAMPLESANDDataTablesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "As a User I want the visit creation access rights so that I can create visits of different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables (1).feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "As a User I want the visit creation access rights so that I can create visits of " +
                    "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables", "This implementation will enable hospital staff to create visits of type - Ambulat" +
                    "ory,Inpatient,Outpatient via UI and HL7 Inbound. ", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "As a User I want the visit creation access rights so that I can create visits of " +
                            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")))
            {
                global::BillingAndPatientCreationTests.Features.AsAUserIWantTheVisitCreationAccessRightsSoThatICanCreateVisitsOfDifferentTypes_DemoUsingSCENARIOOUTLINESEXAMPLESANDDataTablesFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "AddVisitSecRight",
                        "TRUE"});
            table1.AddRow(new string[] {
                        "IsFullRegEP",
                        "TRUE"});
            table1.AddRow(new string[] {
                        "Username",
                        "jongmore"});
            table1.AddRow(new string[] {
                        "Password",
                        "pass"});
#line 10
testRunner.Given("User has the following config data  set up", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        public virtual void AbilityForUserToCreateVisitsOfAllTypes(string testDescription, string visitType, string careLevel, string service, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "Priority1",
                    "PlannedForAutomation",
                    "UITest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Test Description", testDescription);
            argumentsOfScenario.Add("VisitType", visitType);
            argumentsOfScenario.Add("CareLevel", careLevel);
            argumentsOfScenario.Add("Service", service);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ability for User to create visits of all types", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 25
testRunner.When(string.Format("User to create visit of type {0} where Care level is {1} and Service is {2}", visitType, careLevel, service), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
testRunner.Then(string.Format("the visit is registered and data persisted in the DB  with Visit type as  {0} and" +
                            " Care level equal to {1} and Service equal to :{2}", visitType, careLevel, service), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ability for User to create visits of all types: Ambulatory Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a User I want the visit creation access rights so that I can create visits of " +
            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Smoke")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Priority1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PlannedForAutomation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UITest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Ambulatory Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Test Description", "Ambulatory Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:VisitType", "Ambulatory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CareLevel", "Ambulatory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Service", "ICU")]
        public void AbilityForUserToCreateVisitsOfAllTypes_AmbulatoryVisCreation()
        {
#line 24
this.AbilityForUserToCreateVisitsOfAllTypes("Ambulatory Vis Creation", "Ambulatory", "Ambulatory", "ICU", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ability for User to create visits of all types: Inpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a User I want the visit creation access rights so that I can create visits of " +
            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Smoke")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Priority1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PlannedForAutomation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UITest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Inpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Test Description", "Inpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:VisitType", "Inpatient")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CareLevel", "Acute")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Service", "GenMedicine")]
        public void AbilityForUserToCreateVisitsOfAllTypes_InpatientVisCreation()
        {
#line 24
this.AbilityForUserToCreateVisitsOfAllTypes("Inpatient Vis Creation", "Inpatient", "Acute", "GenMedicine", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ability for User to create visits of all types: Outpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a User I want the visit creation access rights so that I can create visits of " +
            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Smoke")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Priority1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PlannedForAutomation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UITest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Outpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Test Description", "Outpatient Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:VisitType", "Outpatient")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CareLevel", "cl1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Service", "CTScan")]
        public void AbilityForUserToCreateVisitsOfAllTypes_OutpatientVisCreation()
        {
#line 24
this.AbilityForUserToCreateVisitsOfAllTypes("Outpatient Vis Creation", "Outpatient", "cl1", "CTScan", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Ability for User to create visits of all types: Emergency Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a User I want the visit creation access rights so that I can create visits of " +
            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Smoke")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Priority1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PlannedForAutomation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UITest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Emergency Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Test Description", "Emergency Vis Creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:VisitType", "Emergency")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CareLevel", "critical")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Service", "dialysis")]
        public void AbilityForUserToCreateVisitsOfAllTypes_EmergencyVisCreation()
        {
#line 24
this.AbilityForUserToCreateVisitsOfAllTypes("Emergency Vis Creation", "Emergency", "critical", "dialysis", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Calculation of Billing amount if ailment service availed is MRI and age is greate" +
            "r than 60")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a User I want the visit creation access rights so that I can create visits of " +
            "different types. Demo using SCENARIO OUTLINES EXAMPLES AND Data Tables")]
        public void CalculationOfBillingAmountIfAilmentServiceAvailedIsMRIAndAgeIsGreaterThan60()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculation of Billing amount if ailment service availed is MRI and age is greate" +
                    "r than 60", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table2.AddRow(new string[] {
                            "ailmentservice",
                            "MRI"});
                table2.AddRow(new string[] {
                            "age",
                            "61"});
#line 36
testRunner.Given("User has availed", ((string)(null)), table2, "Given ");
#line hidden
#line 40
testRunner.When("patient takes out the MRI", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table3.AddRow(new string[] {
                            "billingamount",
                            "600 DOLLARS"});
#line 41
testRunner.Then("billing amount is", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
