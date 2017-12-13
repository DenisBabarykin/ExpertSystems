using ExpertSystem.Test;
using FuzzyLogic.Mamdani;
using FuzzyLogic.Mamdani.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Test
{
    [TestClass]
    public class MamdaniServiceTest
    {
        [TestMethod]
        public void MamdaniServiceTestMethod1()
        {
            var solveResultPattern = 0.34375;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.6, 0.8 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod2()
        {
            var solveResultPattern = 0.129;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.3, 0.8 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
           // Assert.AreEqual(solveResult.Data, solveResultPattern);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod3()
        {
            var solveResultPattern = 0.336;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.5, 0.5 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
           // Assert.AreEqual(solveResult.Data, solveResultPattern);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod4()
        {
            var solveResultPattern = 0.129;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.1, 0.1 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
          //  Assert.AreEqual(solveResult.Data, solveResultPattern);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod5()
        {
            var solveResultPattern = 0.129;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.2, 0.9 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
           // Assert.AreEqual(solveResult.Data, solveResultPattern);
             Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod6()
        {
            var solveResultPattern = 0.34375;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.6, 0.1 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
           // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod7()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
           // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod8()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod9()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod10()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod11()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod12()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod13()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod14()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }

        [TestMethod]
        public void MamdaniServiceTestMethod15()
        {
            var solveResultPattern = 0.736;
            var result = ProblemConditionsHelper.ReadConditionsFromXmlString(Resources.input);
            var mamdaniService = new MamdaniService();
            ProblemConditions conditions = new ProblemConditions() { Rules = result.Data.Rules, Variables = result.Data.Variables };

            var problem = new Problem()
            {
                InputData = new double[] { 0.7, 0.4 },
                ProblemConditions = conditions
            };

            var solveResult = mamdaniService.SolveProblem(problem);
            Assert.IsTrue(Math.Abs(solveResult.Data - solveResultPattern) < 1e-3);
            // Assert.AreEqual(solveResult.Data, solveResultPattern);
        }
    }
}
