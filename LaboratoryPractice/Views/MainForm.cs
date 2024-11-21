using System.Reflection;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lowLevelCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� ������� ��������
                int a = int.Parse(inputLowLevelFirst.Text);
                int b = int.Parse(inputLowLevelSecond.Text);
                MessageBox.Show($"{inputLowLevelFirst.Text}/{inputLowLevelSecond.Text}");

                // ������������ �������� ����������
                Assembly asm = Assembly.LoadFrom("AsmFunc.dll");

                // ��������� ���� ������ Func �� ����������
                Type myType = asm.GetType("AsmFunc.Func", true);

                // �������� ���������� ������ Func
                object obj = Activator.CreateInstance(myType);

                // ��������� ������ Divide
                MethodInfo method = myType.GetMethod("Divide");

                // ����� ������ Divide � �����������
                object result = method.Invoke(obj, new object[] { a, b });

                // ����������� ����������
                outputLowLevelResult.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}");
            }
        }

        private void analyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;
            outputAnalyze.Clear();

            try
            {
                // �������� ����������
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // �������� �� ������� �������������� ������
                var diagnostics = syntaxTree.GetDiagnostics();
                if (diagnostics.Any())
                {
                    foreach (var diagnostic in diagnostics)
                    {
                        var lineSpan = diagnostic.Location.GetLineSpan();
                        int line = lineSpan.StartLinePosition.Line + 1; // ����� ������
                        string errorMessage = $"����� ������ {line}. ����� ������: {diagnostic.Id}, '{diagnostic.GetMessage()}'";
                        outputAnalyze.AppendText(errorMessage + Environment.NewLine);
                    }
                    return;
                }

                // �������� �� ������� ����� while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show("������� ���� while!");
                    return;
                }

                // ���� ������ ���
                outputAnalyze.Text = "������ �� ����������";
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "��������� ������ �������: " + ex.Message;
            }
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;
            outputAnalyze.Clear();

            try
            {
                // ������ ��� � �������������� ������
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // ���� ���� while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show("������� ���� while!");
                    return;
                }

                // �������� ������� �����
                var condition = whileStatement.Condition.ToString();

                // ������� �������� �� ��������� ��������
                if (condition == "true")
                {
                    outputAnalyze.Text = "���� ���������� ����������.";
                    return;
                }
                else if (condition == "false")
                {
                    outputAnalyze.Text = "���� �� ���������� �� ����.";
                    return;
                }

                // ��������� ��������� ��������� �������� � ��������� �������
                var initialStatements = root.DescendantNodes().OfType<LocalDeclarationStatementSyntax>();
                Dictionary<string, int> variables = new Dictionary<string, int>();

                foreach (var statement in initialStatements)
                {
                    var declaration = statement.Declaration;
                    foreach (var variable in declaration.Variables)
                    {
                        // ������ ���������� ���� "int i = 0;"
                        if (variable.Initializer != null && int.TryParse(variable.Initializer.Value.ToString(), out int value))
                        {
                            variables[variable.Identifier.Text] = value;
                        }
                    }
                }

                // ��������� �������
                if (EvaluateCondition(condition, variables))
                {
                    outputAnalyze.Text = "���� ���������� ���� �� ���.";
                }
                else
                {
                    outputAnalyze.Text = "���� �� ���������� �� ����.";
                }
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "��������� ������ �������: " + ex.Message;
            }
        }

        private bool EvaluateCondition(string condition, Dictionary<string, int> variables)
        {
            // ����������� ������ ������� ��� ���� "i < 3"
            foreach (var variable in variables)
            {
                condition = condition.Replace(variable.Key, variable.Value.ToString());
            }

            try
            {
                // ��������� ������� � ������� DataTable
                var table = new System.Data.DataTable();
                var result = table.Compute(condition, string.Empty);
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false; // ���� ������� �� ������� ����������
            }
        }
    }
}
