﻿using NeuroFuzzy.membership;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroFuzzy
{
    public static class ANFISBuilder<R>
        where R : IRule, new()
    {
        static Logger _log = LogManager.GetLogger("ABuilder");
        public static ANFIS Build(double[][] input, double[][] output, IRuleExtractor RuleExtractor, ITraining trainer, int MaxIterations)
        {
            InMemoryLogger.PrintMessage("Start...");
            InMemoryLogger.PrintMessage($"Constructing initial rule set with [{RuleExtractor.GetType().Name}]");
            var ruleBase = RuleSetFactory<R>.Build(input, output, RuleExtractor).Select(z => z as IRule).ToList();
            InMemoryLogger.PrintMessage($"Get {ruleBase.Count} initial rules.");
            int epoch = 0;

            double trnError = 0.0;
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                trnError = trainer.Iteration(input, output, ruleBase);
                InMemoryLogger.PrintMessage($"Epoch {epoch}, training error {trnError}");

                if (double.IsNaN(trnError))
                {
                    InMemoryLogger.PrintMessage("Failure! Training error is NAN.");
                    throw new Exception("Failure! Bad system design.");
                }
            } while (!trainer.isTrainingstoped() && epoch++ < MaxIterations);


            ANFIS fis = new ANFIS(ruleBase);
            InMemoryLogger.PrintMessage("Done");
            return fis;
        }
    }
}
