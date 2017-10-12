using NeuroFuzzy;
using NeuroFuzzy.membership;
using NeuroFuzzy.misc;
using NeuroFuzzy.rextractors;
using NeuroFuzzy.training;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANFIS.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            InMemoryLogger.OnPrintMessage += OnPrintMessage;
        }

        private double[][] input;
        private double[][] output;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    (input, output) = FileReader.ReadFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SampleData(double[][] input, double[][] output, int TrainingSetSize, out double[][] x, out double[][] y, out double[][] tx, out double[][] ty)
        {
            var seq = input.Select((z, i) => i).ToArray();
            seq.Shuffle();

            x = new double[TrainingSetSize][];
            y = new double[TrainingSetSize][];
            tx = new double[input.Length - TrainingSetSize][];
            ty = new double[input.Length - TrainingSetSize][];

            int count = Math.Min(seq.Length, TrainingSetSize);
            for (int i = 0; i < count; i++)
            {
                x[i] = input[seq[i]];
                y[i] = output[seq[i]];
            }

            for (int i = count; i < input.Length; i++)
            {
                tx[i - count] = input[seq[i]];
                ty[i - count] = output[seq[i]];
            }

        }

        private async void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double[][] x;
                double[][] y;
                double[][] tx;
                double[][] ty;
                SampleData(input, output, input.Count() - int.Parse(txtbxTestCount.Text), out x, out y, out tx, out ty);

                Backprop bprop = new Backprop(1e-2, abstol: 1e-4, reltol: 1e-7, adjustThreshold: 1e-20);
                bprop.UnknownCaseFaced += AddRule<GaussianRule2>;

                await Task.Run(() => Solve(x, y, tx, ty, bprop));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddRule<T>(IList<IRule> RuleBase, double[] centroid, double[] consequence, double[] neighbourhood) where T : IRule, new()
        {
            T rule = new T();
            rule.Init(centroid, consequence, neighbourhood);
            RuleBase.Add(rule);
        }

        private void Solve(double[][] x, double[][] y, double[][] tx, double[][] ty, ITraining bprop)
        {
            KMEANSExtractorI extractor = new KMEANSExtractorI(int.Parse(txtbxRulesCount.Text));
            var timer = Stopwatch.StartNew();
            var fis = ANFISBuilder<GaussianRule2>.Build(x, y, extractor, bprop, int.Parse(txtbxMaxIterCount.Text));
            timer.Stop();

            double err = bprop.Error(tx, ty, fis.RuleBase);

            double correctClass = 0;
            for (int i = 0; i < tx.Length; i++)
            {
                double[] o = fis.Inference(tx[i]);
                for (int j = 0; j < ty[i].Length; j++)
                    if (ty[i][j] == 1.0 && o[j] == o.Max())
                        correctClass++;
            }

            InMemoryLogger.PrintMessage(string.Format("Correct answers {5}\tClassification Error {4}\tElapsed {2}\tRuleBase {3}", err, bprop.GetType().Name, timer.Elapsed, fis.RuleBase.Length, 1.0 - correctClass / ty.Length, correctClass));
        }

        private void OnPrintMessage(object sender, LoggerEventArgs args)
        {
            Invoke((MethodInvoker)delegate
            {
                txtbxOut.AppendText(args.Meassage);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxOut.Clear();
        }
    }
}
