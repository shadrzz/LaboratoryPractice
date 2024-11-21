using System.Reflection;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение входных значений
                int a = int.Parse(comboBox1.Text);
                int b = int.Parse(comboBox2.Text);
                MessageBox.Show($"{comboBox1.Text}/{comboBox2.Text}");

                // Динамическая загрузка библиотеки
                Assembly asm = Assembly.LoadFrom("AsmFunc.dll");

                // Получение типа класса Func из библиотеки
                Type myType = asm.GetType("AsmFunc.Func", true);

                // Создание экземпляра класса Func
                object obj = Activator.CreateInstance(myType);

                // Получение метода Divide
                MethodInfo method = myType.GetMethod("Divide");

                // Вызов метода Divide с параметрами
                object result = method.Invoke(obj, new object[] { a, b });

                // Отображение результата
                textBox2.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
