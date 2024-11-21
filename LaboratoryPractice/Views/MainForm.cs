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
                // ��������� ������� ��������
                int a = int.Parse(comboBox1.Text);
                int b = int.Parse(comboBox2.Text);
                MessageBox.Show($"{comboBox1.Text}/{comboBox2.Text}");

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
                textBox2.Text = result.ToString();
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
    }
}
