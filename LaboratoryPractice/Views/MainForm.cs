using System.Reflection;
using LaboratoryPractice.Views;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        private bool isAnalysisSuccessful = false; // ���� ��� ������������ ��������� �������

        public MainForm()
        {
            InitializeComponent();
        }

        private void lowLevelCalculate_Click(object sender, EventArgs e)
        {
            // �������� ������� �����
            if (!int.TryParse(inputLowLevelFirst.Text, out int a))
            {
                MessageBox.Show(
                    "����������, ������� ���������� ����� � ������ ����.",
                    "������ �����",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // �������� ������� �����
            if (!int.TryParse(inputLowLevelSecond.Text, out int b))
            {
                MessageBox.Show(
                    "����������, ������� ���������� ����� �� ������ ����.",
                    "������ �����",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // �������� ������� �� ����
            if (b == 0)
            {
                MessageBox.Show(
                    "������� �� ���� ����������. ����������, ������� ��������� �������� �� ������ ����.",
                    "������ �������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

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

        private void analyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;

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

                    isAnalysisSuccessful = false; // ���� ���� ������, ������ ���������
                    return;
                }

                // �������� �� ������� ����� while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show(
                        "������� ���� while!",
                        "��������������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    isAnalysisSuccessful = false; // ���� ��� ����� while, ������ ���������
                    return;
                }

                // ���� ������ ���
                outputAnalyze.Text = "������ �� ����������";
                isAnalysisSuccessful = true; // �������� ������
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "��������� ������ �������: " + ex.Message;
                isAnalysisSuccessful = false; // � ������ ���������� ������ ���������
            }
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            if (!isAnalysisSuccessful)
            {
                // ���� ������ �� ��� �������� ��� ���� ������
                MessageBox.Show(
                    "����������, ������� ��������� �������� ������, ����� �� ������ '������'.",
                    "��������������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string userCode = inputAnalyze.Text;

            try
            {
                // ������ �������� ���������� ����� while (��� � ����� ����)
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // ���� ���� while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show(
                        "������� ���� while!",
                        "��������������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // �������� ������� �����
                var condition = whileStatement.Condition.ToString();

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
                    MessageBox.Show(
                        "���� ���������� ���� �� ���.",
                        "�������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "���� �� ���������� �� ����.",
                        "�������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "��������� ������ �������: " + ex.Message,
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

        private void inputAnalyze_TextChanged(object sender, EventArgs e)
        {
            outputAnalyze.Clear();
            isAnalysisSuccessful = false; // ���������� ���� ��� ��������� ������
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            Form addRecordForm = new AddRecord();
            addRecordForm.Show();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            Form editRecordForm = new EditRecord();
            editRecordForm.Show();
        }
    }
}
