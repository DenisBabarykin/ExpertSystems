using System.Collections.Generic;
using System.Xml.Linq;

namespace FuzzyLogic.Mamdani.Problems
{
    internal class ProblemConditionsWriter
    {
        internal static void WriteXmlToFile(ProblemConditions conditions, string filePath)
        {
            var doc = WriteToXDocument(conditions);
            doc.Save(filePath);
        }

        private static XDocument WriteToXDocument(ProblemConditions conditions)
        {
            var xdoc = new XDocument();
            var conditionsNode = new XElement(StringResources.ProblemConditionsNodeName);

            var variablesNode = new XElement(StringResources.VariablesNodeName);
            FillVariablesNode(variablesNode, conditions.Variables);

            var rulesNode = new XElement(StringResources.RulesNodeName);
            FillRulesNode(rulesNode, conditions.Rules);

            conditionsNode.Add(variablesNode, rulesNode);

            xdoc.Add(conditionsNode);
            return xdoc;
        }

        private static void FillRulesNode(XElement rulesNode, List<Rule> rules)
        {
            foreach (var rule in rules)
            {
                var ruleNode = new XElement(StringResources.RuleNodeName);
                var inputsNode = new XElement(StringResources.RuleNodeInputSectionName);
                foreach (var condition in rule.Conditions)
                {
                    inputsNode.Add(
                        new XElement(StringResources.RuleVariableNodeName,
                            new XAttribute(StringResources.RuleVariableNodeNameAttribute, condition.FuzzyVariable.Name),
                            new XAttribute(StringResources.RuleVariableNodeValueAttribute, condition.Term.Name)
                        )
                    );
                }

                var outputsNode = new XElement(StringResources.RuleNodeOutputSectionName,
                    new XElement(StringResources.RuleVariableNodeName,
                        new XAttribute(StringResources.RuleVariableNodeNameAttribute, rule.Conclusion.FuzzyVariable.Name),
                        new XAttribute(StringResources.RuleVariableNodeValueAttribute, rule.Conclusion.Term.Name)
                    )
                );

                ruleNode.Add(inputsNode, outputsNode);
                rulesNode.Add(ruleNode);
            }
        }

        private static void FillVariablesNode(XElement variablesNode, List<FuzzyVariable> variables)
        {
            foreach (var variable in variables)
            {
                var variableNode = new XElement(StringResources.VariableNodeName,
                    new XAttribute(StringResources.VariableNodeNameAttribute, variable.Name),
                    new XAttribute(StringResources.VariableNodeLingNameAtttribute, variable.LingName),
                    new XAttribute(StringResources.VariableNodeIsResultAttribute, variable.IsResult.ToString())
                );

                foreach (var term in variable.Terms)
                {
                    variableNode.Add(
                        new XElement(StringResources.TermNodeName,
                            new XAttribute(StringResources.TermNodeNameAttribute, term.Name),
                            new XAttribute(StringResources.TermAPointAttributeName, ((TrapFunc)term.AccessoryFunc).A),
                            new XAttribute(StringResources.TermBPointAttributeName, ((TrapFunc)term.AccessoryFunc).B),
                            new XAttribute(StringResources.TermCPointAttributeName, ((TrapFunc)term.AccessoryFunc).C),
                            new XAttribute(StringResources.TermDPointAttributeName, ((TrapFunc)term.AccessoryFunc).D)
                        )
                    );
                }

                variablesNode.Add(variableNode);
            }
        }
    }
}
