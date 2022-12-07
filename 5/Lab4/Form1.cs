using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FiguresLib;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();

        int sq_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();
                try
                {
                    string sourceExpression = textBoxInputString.Text.Replace(" ", "");
                    for (int i = 0; i < sourceExpression.Length; i++)
                    {
                        if (IsNotOperation(sourceExpression[i]))
                        {
                            if (!Char.IsDigit(sourceExpression[i]))
                            {
                                operands.Push(new Operand(sourceExpression[i]));
                                while (i < sourceExpression.Length - 1 && IsNotOperation(sourceExpression[i + 1]))
                                {
                                    string temp_str = operands.Pop().value.ToString() + sourceExpression[i + 1].ToString();
                                    operands.Push(new Operand(temp_str));
                                    i++;
                                }
                            }
                            else if (Char.IsDigit(sourceExpression[i]))
                            {
                                operands.Push(new Operand(sourceExpression[i].ToString()));
                                while (i < sourceExpression.Length - 1 && Char.IsDigit(sourceExpression[i + 1])
                                    && IsNotOperation(sourceExpression[i + 1]))
                                {
                                    int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                        (int)Char.GetNumericValue(sourceExpression[i + 1]);
                                    operands.Push(new Operand(temp_num.ToString()));
                                    i++;
                                }
                            }
                        }

                        else if (sourceExpression[i] == 'S')
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                            }
                        }
                        else if (sourceExpression[i] == 'M')
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                            }
                        }
                        else if (sourceExpression[i] == 'D')
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                            }
                        }
                        else if (sourceExpression[i] == 'R')
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                            }
                        }
                        else if (sourceExpression[i] == '(')
                        {
                            operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                        }
                        else if (sourceExpression[i] == ')')
                        {
                            do
                            {
                                if (operators.Peek().symbolOperator == '(')
                                {
                                    operators.Pop();
                                    break;
                                }
                                if (operators.Count == 0)
                                {
                                    break;
                                }
                            }
                            while (operators.Peek().symbolOperator != '(');
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Параметры введены некорректно.");
                    comboBox1.Items.Add("Параметры введены некорректно.");
                }
                try
                {
                    SelectingPerformingOperation(operators.Peek());
                }
                catch
                {
                    MessageBox.Show("Введенной операции не существует.");
                    comboBox1.Items.Add("Введенной операции не существует.");
                }
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'R')
            {
                if (operands.Count == 4)
                {
                    Square figure = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    int angle = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Figure f in ShapeContainer.figureList)
                    {
                        if (f.n_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (AngledShiftCheck(figure.x, figure.y, x, y, angle))
                        {
                            double angleRadian = angle * Math.PI / 180;
                            figure.DeleteF(figure, false);
                            figure.matrix.RotateAt(angle, new PointF(x, y));
                            figure.Draw();
                            figure.x = (int)((figure.x - x) * Math.Cos(angleRadian) - (figure.y - y) * Math.Sin(angleRadian) + x);
                            figure.y = (int)((figure.x - x) * Math.Sin(angleRadian) + (figure.y - y) * Math.Cos(angleRadian) + y);
                            comboBox1.Items.Add($"Квадрат {figure.n_name} повернут.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор R принимает 4 параметра.");
                    comboBox1.Items.Add("Неверное число параметров для оператора R.");
                }
            }
            else if (op.symbolOperator == 'S')
            {
                if (operands.Count == 4)
                {
                    sq_count += 1;
                    int a = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (Init.Coords_check(x, y, a, a))
                    {
                        Square figure = new Square(sq_count, x, y, a, name);
                        op = new Operator(figure.Draw, 'S');
                        ShapeContainer.AddFigure(figure);
                        comboBox1.Items.Add($"Квадрат {figure.n_name} отрисован");
                        op.operatorMethod();
                    }
                    else
                    {
                        MessageBox.Show("Фигура вышла за границы.");
                        comboBox1.Items.Add("Фигура вышла за границы.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор S принимает 4 параметра.");
                    comboBox1.Items.Add("Неверное число параметров для оператора S.");
                }
            }
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Square figure = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Figure f in ShapeContainer.figureList)
                    {
                        if(f.n_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                            comboBox1.Items.Add($"Фигура {figure.n_name} успешно перемещена");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 параметра.");
                    comboBox1.Items.Add("Неверное число параметров для оператора M.");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Square figure = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Figure f in ShapeContainer.figureList)
                    {
                        if (f.n_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        figure.DeleteF(figure, true);
                        comboBox1.Items.Add($"Фигура {figure.n_name} успешно удалена");
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 параметр.");
                    comboBox1.Items.Add("Неверное число параметров для оператора D.");
                }
            }
        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'R' || item == 'D' || item == 'M' || item == 'S' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool AngledShiftCheck(int x, int y, int x0, int y0, int angle)
        {
            double angleRadian = angle * Math.PI / 180;
            float res_x = (float)((x - x0) * Math.Cos(angleRadian) - (y - y0) * Math.Sin(angleRadian) + x0);
            float res_y = (float)((x - x0) * Math.Sin(angleRadian) + (y - y0) * Math.Cos(angleRadian) + y0);
            if ((res_x > 0) && (res_y > 0) && (res_x < Init.pictureBox.Width) && (res_y < Init.pictureBox.Height))
            {
                return true;
            }
            else return false;
        }
    }
}
