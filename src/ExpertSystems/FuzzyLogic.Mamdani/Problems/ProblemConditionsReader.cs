using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using FuzzyLogic.Mamdani.Exceptions;
using FuzzyLogic.Mamdani.Statements;

namespace FuzzyLogic.Mamdani.Problems
{
    internal class ProblemConditionsReader
    {
        internal static ProblemConditions ReadFromXmlStream(Stream stream)
        {
            var xdoc = XDocument.Load(new XmlTextReader(stream));
            return ReadFromXDocument(xdoc);
        }

        internal static ProblemConditions ReadFromXmlString(string xmlString)
        {
            var xdoc = XDocument.Parse(xmlString);
            return ReadFromXDocument(xdoc);
        }

        internal static ProblemConditions ReadFromXDocument(XDocument xdoc)
        {
            if (xdoc.Root == null)
            {
                return null;
            }
            var conditionsNode = GetElement(xdoc.Root, StringResources.ProblemConditionsNodeName);

            var variablesNode = GetElement(conditionsNode, StringResources.VariablesNodeName);
            var variables = ReadVariables(variablesNode);

            var rulesNode = GetElement(conditionsNode, StringResources.RulesNodeName);
            var rules = ReadRules(rulesNode, variables);

            return new ProblemConditions(variables, rules);
        }

        private static XElement GetElement(XElement parent, string elementName)
        {
            if (parent.Name.LocalName == elementName)
            {
                return parent;
            }
            var element = parent.Element(elementName);
            if (element == null)
            {
                throw new ProblemConditionsParseException("Не найден элемент " + elementName);
            }
            return element;
        }

        private static XAttribute GetAttriute(XElement element, string attributeName)
        {
            var attribute = element.Attribute(attributeName);
            if (attribute == null || string.IsNullOrEmpty(attribute.Value))
            {
                throw new ProblemConditionsParseException("Не найден атрибут " + attributeName + " элемента " + element.Name.LocalName);
            }
            return attribute;
        }

        private static bool GetAttributeBoolValue(XElement element, string attributeName)
        {
            var attribute = element.Attribute(attributeName);
            if (attribute == null || string.IsNullOrEmpty(attribute.Value))
            {
                return false;
            }
            return attribute.Value.ToLower() == "true";
        }

        private static double ParseDouble(XAttribute attribute)
        {
            double result;
            if (!double.TryParse(attribute.Value.Replace(".", ","), out result))
            {
                throw new ProblemConditionsParseException("Значение атрибута " + attribute.Name.LocalName + " элемента " + attribute.Parent.Name.LocalName + " должно быть числовым.");
            }
            return result;
        }

        private static FuzzyVariable GetVariable(List<FuzzyVariable> variables, string name)
        {
            var variable = variables.FirstOrDefault(x => x.Name == name);
            if (variable == null)
            {
                throw new ProblemConditionsParseException("Не найдена нечеткая переменная " + name + " для правила");
            }
            return variable;
        }

        private static Term GetTerm(FuzzyVariable variable, string name)
        {
            var term = variable.Terms.FirstOrDefault(x => x.Name == name);
            if (term == null)
            {
                throw new ProblemConditionsParseException("Не найдено значение " + name + " нечеткой переменной " + variable.Name);
            }
            return term;
        }

        private static List<FuzzyVariable> ReadVariables(XElement node)
        {
            var result = new List<FuzzyVariable>();
            foreach (var variableNode in node.Elements(StringResources.VariableNodeName))
            {
                var variableNameAttribute = GetAttriute(variableNode, StringResources.VariableNodeNameAttribute);
                var variableName = variableNameAttribute.Value;

                var variableLingNameAttribute = GetAttriute(variableNode, StringResources.VariableNodeLingNameAtttribute);
                var variableLingName = variableLingNameAttribute.Value;

                var isResultVariable = GetAttributeBoolValue(variableNode, StringResources.VariableNodeIsResultAttribute);

                var terms = new List<Term>();

                foreach (var termNode in variableNode.Elements(StringResources.TermNodeName))
                {
                    var termNameAttribute = GetAttriute(termNode, StringResources.TermNodeNameAttribute);
                    var termName = termNameAttribute.Value;

                    var termAPointAttribute = GetAttriute(termNode, StringResources.TermAPointAttributeName);
                    var termAPointValue = ParseDouble(termAPointAttribute);

                    var termBPointAttribute = GetAttriute(termNode, StringResources.TermBPointAttributeName);
                    var termBPointValue = ParseDouble(termBPointAttribute);

                    var termCPointAttribute = GetAttriute(termNode, StringResources.TermCPointAttributeName);
                    var termCPointValue = ParseDouble(termCPointAttribute);

                    var termDPointAttribute = GetAttriute(termNode, StringResources.TermDPointAttributeName);
                    var termDPointValue = ParseDouble(termDPointAttribute);

                    var term = new Term(termName, termAPointValue, termBPointValue, termCPointValue, termDPointValue);
                    terms.Add(term);
                }

                var variable = new FuzzyVariable(variableName, variableLingName, terms, isResultVariable);
                result.Add(variable);
            }
            if (result.Count == 0)
            {
                throw new ProblemConditionsParseException("Не найдено ни одного элемента " + StringResources.VariableNodeName);
            }

            return result;
        }

        private static List<Rule> ReadRules(XElement node, List<FuzzyVariable> variables)
        {
            var result = new List<Rule>();

            foreach (var ruleNode in node.Elements(StringResources.RuleNodeName))
            {
                var inputs = GetElement(ruleNode, StringResources.RuleNodeInputSectionName);
                var conditions = new List<Condition>();
                foreach (var inputVariableNode in inputs.Elements(StringResources.RuleVariableNodeName))
                {
                    var inputVariableNameAttribute = GetAttriute(inputVariableNode, StringResources.RuleVariableNodeNameAttribute);
                    var inputVariableName = inputVariableNameAttribute.Value;

                    var variable = GetVariable(variables, inputVariableName);

                    var inputVariableValueAttribute = GetAttriute(inputVariableNode, StringResources.RuleVariableNodeValueAttribute);
                    var inputVariableValue = inputVariableValueAttribute.Value;

                    var term = GetTerm(variable, inputVariableValue);
                    var condition = new Condition(variable, term);
                    conditions.Add(condition);
                }

                var outputs = GetElement(ruleNode, StringResources.RuleNodeOutputSectionName);
                Conclusion conclusion = null;
                foreach (var outputVariableNode in outputs.Elements(StringResources.RuleVariableNodeName))
                {
                    var outputVariableNameAttribute = GetAttriute(outputVariableNode, StringResources.RuleVariableNodeNameAttribute);
                    var outputVariableName = outputVariableNameAttribute.Value;

                    var variable = GetVariable(variables, outputVariableName);

                    var outputVariableValueAttribute = GetAttriute(outputVariableNode, StringResources.RuleVariableNodeValueAttribute);
                    var outputVariableValue = outputVariableValueAttribute.Value;

                    var term = GetTerm(variable, outputVariableValue);
                    conclusion = new Conclusion(variable, term);
                }

                if (conclusion == null)
                {
                    throw new ProblemConditionsParseException("В правиле должно быть задано заключение, т.е. элемент " + StringResources.RuleVariableNodeName + " в секции " + StringResources.RuleNodeOutputSectionName);
                }

                if (conditions.Any(x => x.FuzzyVariable.Name == conclusion.FuzzyVariable.Name))
                {
                    throw new ProblemConditionsParseException("В правиле переменные условия и заключения не должны пересекаться.");
                }

                var rule = new Rule(conditions, conclusion);
                result.Add(rule);
            }

            if (result.Count == 0)
            {
                throw new ProblemConditionsParseException("Не найдено ни одного элемента " + StringResources.RuleNodeName);    
            }

            return result;
        }
    }
}
