using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class CodeAnalysisController
{
    public static (bool isSuccessful, string outputMessage) AnalyzeCode(string userCode)
    {
        try
        {
            // Проверка синтаксиса
            var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
            var root = syntaxTree.GetRoot();

            // Проверка на наличие синтаксических ошибок
            var diagnostics = syntaxTree.GetDiagnostics();
            if (diagnostics.Any())
            {
                var errorMessages = diagnostics.Select(diagnostic =>
                {
                    var lineSpan = diagnostic.Location.GetLineSpan();
                    int line = lineSpan.StartLinePosition.Line + 1; // Номер строки
                    return $"Номер строки {line}. Номер ошибки: {diagnostic.Id}, '{diagnostic.GetMessage()}'";
                });

                return (false, string.Join(Environment.NewLine, errorMessages));
            }

            // Проверка на наличие цикла while
            var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
            if (whileStatement == null)
            {
                return (false, "Введите цикл while!");
            }

            // Если ошибок нет
            return (true, "Ошибок не обнаружено");
        }
        catch (Exception ex)
        {
            return (false, $"Произошла ошибка анализа: {ex.Message}");
        }
    }
}
