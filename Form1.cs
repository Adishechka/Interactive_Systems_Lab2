using System.Diagnostics;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Границы области тестирования
        public int lineLeft = 20;
        public int lineTop = 50;
        public int lineRight = 900;
        public int lineBottom = 400;

        // Переменные для подстановки в формулу Фиттса
        public int a = 1;
        public double b = 0.5;
        public double D = 1;
        public double W = 1;


        // Кол-во кликов
        public const int countClicks = 10;
        public int countClicksNow = 0;

        // Массив хранения реального времени реакции User'а
        public double[] arr = new double[countClicks];
        public double[] arrFitts = new double[countClicks];

        // Фиксация режима
        public int comboBoxModeFixed = -1;

        // Минимальное и максимально время для клика в мс
        public int minRandomTimeSet = 1000;
        public int maxRandomTimeSet = 3000;



        public bool flagStopWatch;
        private Stopwatch _stopWatch;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMode.SelectedIndex = 0;
            //Cursor.Position = new Point(Location.X + 400, Location.Y + 270);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPenRect = new Pen(Color.Black, 2);

            Rectangle rect = new Rectangle(lineLeft, lineTop, lineRight, lineBottom);

            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(Color.Gray);
            g.FillRectangle(blueBrush, rect);
            g.DrawRectangle(myPenRect, rect);


            

            //g.DrawLine(myPen, 1, 1, 45, 65);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Определение режима
            switch(comboBoxMode.SelectedIndex)
            {
                case 0:
                    comboBoxModeFixed = 0;
                    break;
                case 1:
                    comboBoxModeFixed = 1;
                    break;
                case 2:
                    comboBoxModeFixed = 2;
                    break;
            }

            // Информирование о запущенном режиме
            countClicksNow = 0;
            buttonClick.Text = "Кликай";
            textBox1.Text += "Режим " + (int)(comboBoxMode.SelectedIndex + 1) + " запущен...\r\n";

            // Задаём случайный таймер от 1 до 3 секунд (в мс)
            Random rnd = new Random();
            timer1.Interval = rnd.Next(minRandomTimeSet, maxRandomTimeSet);
            timer1.Enabled = true;
        }

        // Режим 1
        public static void SetRandomPositionCursorMode0()
        {
            MessageBox.Show("Hello");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (comboBoxModeFixed == 0)
            {
                Cursor.Position = new Point(Location.X + buttonClick.Right + 200, Location.Y + buttonClick.Bottom + 30);

                // Поскольку задаётся расстояние от кнопки вручную, то просто задаём фиксированное - 200
                D = 200;
                W = buttonClick.Right - buttonClick.Left; 

            }
            else if (comboBoxModeFixed == 1)
            {
                Random randHorizontal2 = new Random();

                int randNext = randHorizontal2.Next(buttonClick.Right + 10, lineRight + 5 - Location.X);

                Cursor.Position = new Point(Location.X + randNext, Location.Y + buttonClick.Bottom + 30);


                // Расстояние от позиции курсора до нажимаемой кнопки
                D = randNext - buttonClick.Right;
                W = buttonClick.Right - buttonClick.Left;
            }
            else if (comboBoxModeFixed == 2)
            {
                Random buttonSizeWidth = new Random();
                Random buttonSizeHeight = new Random();

                buttonClick.Width = buttonSizeWidth.Next(40, 120);
                buttonClick.Height = buttonSizeHeight.Next(40, 120);
                //Random randHorizontal = new Random();
                //Random randHorizontal = new Random();
                //Cursor.Position = new Point(Location.X + randHorizontal2.Next(buttonClick.Right + 10, lineRight + 5 - Location.X), Location.Y + buttonClick.Bottom + 30);

                Random randHorizontal = new Random();
                Random randVertical = new Random();

                int posX = randHorizontal.Next(lineLeft + 10, lineRight + 25);
                int posY = randVertical.Next(lineTop + 30, lineBottom + 80);
                while (
                           (posX >= (buttonClick.Left + 10) && posX <= (buttonClick.Right + 10)) 
                        || (posY >= (buttonClick.Top + 30) && posY <= (buttonClick.Bottom + 30))
                      )
                {
                    //textBox1.Text += buttonClick.Left.ToString() + " "
                    //               + buttonClick.Right.ToString() + " "
                    //               + buttonClick.Top.ToString() + " "
                    //               + buttonClick.Bottom.ToString() + "\r\n";
                    posX = randHorizontal.Next(lineLeft + 10, lineRight + 25);
                    posY = randVertical.Next(lineTop + 30, lineBottom + 80);
                }

                //Cursor.Position = new Point(Location.X + randHorizontal2.Next(buttonClick.Right + 10, lineRight + 5 - Location.X), Location.Y + buttonClick.Bottom + 30);
                Cursor.Position = new Point(Location.X + posX, Location.Y + posY);

            }



            Random rnd = new Random();
            _stopWatch = new Stopwatch();
            flagStopWatch = true;
            _stopWatch.Start();

        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            //Cursor.Position = new Point(Location.X + buttonClick.Right + 10, Location.Y + buttonClick.Top + 30);

            //textBox1.Text += buttonClick.Left.ToString() + "\r\n";
            //textBox1.Text += buttonClick.Right.ToString() + "\r\n";
            //textBox1.Text += buttonClick.Top.ToString() + "\r\n";
            //textBox1.Text += buttonClick.Bottom.ToString() + "\r\n";
            //Cursor.Position = new Point(Location.X + buttonClick.Right + 10, Location.Y + buttonClick.Top + 30);

            //Random randHorizontal2 = new Random();
            //Cursor.Position = new Point(Location.X + randHorizontal2.Next(buttonClick.Right + 10, 905 - Location.X), Location.Y + buttonClick.Bottom + 30);
            if (comboBoxModeFixed == -1)
            {
                textBox1.Text += "Никакой из режимов не запущен\r\n";
            }
            else
            {
                if (!flagStopWatch)
                {
                    textBox1.Text += "Дождись смещения курсора\r\n";
                    return;
                }
                else 
                {
                    _stopWatch.Stop();
                    flagStopWatch = false;
                    double timeReaction = Math.Round(_stopWatch.Elapsed.TotalSeconds, 3);

                    D /= 37.936267;
                    W /= 37.936267;

                    double timeReactionFitts = Math.Round(a + b * Math.Log2(D / W  + 1), 3);

                    textBox1.Text += "Кнопка нажата за " + timeReaction.ToString() + " реальных секунд (" + (countClicksNow + 1).ToString() + ")\r\n";

                    if (comboBoxModeFixed == 0 || comboBoxModeFixed == 1)
                    {
                        textBox1.Text += "Кнопка нажата за " + timeReactionFitts.ToString() + " секунд по формуле Фиттса (" + (countClicksNow + 1).ToString() + ")\r\n";
                        D = 1;
                        W = 1;
                    }


                    arr[countClicksNow] = timeReaction;
                    arrFitts[countClicksNow] = timeReactionFitts;
                    countClicksNow++;

                    


                    if (countClicksNow == countClicks) 
                    {
                        buttonClick.Text = "НЕ кликай";
                        timer1.Enabled = false;

                        double avgResult = 0;
                        foreach (var item in arr)
                        {
                            avgResult += item;
                        }
                        avgResult = Math.Round(avgResult / countClicksNow, 3);

                        double avgResultFitts = 0;
                        foreach (var item in arrFitts)
                        {
                            avgResultFitts += item;
                        }
                        avgResultFitts = Math.Round(avgResultFitts / countClicksNow, 3);

                        PrintStatistics(false, comboBoxModeFixed, countClicksNow, avgResult, avgResultFitts);
                        comboBoxModeFixed = -1;
                        countClicksNow = 0;
                        System.Array.Clear(arr);
                        System.Array.Clear(arrFitts);
                        buttonClick.Width = 80;
                        buttonClick.Height = 80;
                    }
                    else
                    {
                        // Задаём случайный таймер от 1 до 3 секунд(в мс) и продолжаем выполнение режима
                        Random rnd = new Random();
                        timer1.Interval = rnd.Next(minRandomTimeSet, maxRandomTimeSet);
                        timer1.Enabled = true;
                    }

                }



            }

        }

        private void buttonClearTextBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonClick.Text = "НЕ кликай";
            timer1.Enabled = false;
            if (comboBoxModeFixed != -1)
            {

                double avgResult = 0;
                foreach (var item in arr)
                {
                    avgResult += item;
                }
                avgResult = Math.Round(avgResult / countClicksNow, 3);

                double avgResultFitts = 0;
                foreach (var item in arrFitts)
                {
                    avgResultFitts += item;
                }
                avgResultFitts = Math.Round(avgResultFitts / countClicksNow, 3);

                PrintStatistics(true, comboBoxModeFixed, countClicksNow, avgResult, avgResultFitts);
            }
            comboBoxModeFixed = -1;
            countClicksNow = 0;
            System.Array.Clear(arr);
            System.Array.Clear(arrFitts);
            buttonClick.Width = 80;
            buttonClick.Height = 80;


            //_stopWatch.Stop();
        }

        private void PrintStatistics(bool methodStop, int modeNumber, int totalTestCount, double avgResult, double avgResultFitts)
        {


            // Если остановлено вручную
            if (methodStop)
            {
                textBox1.Text += "\r\nРежим " + (modeNumber + 1).ToString() + " завершён принудительно.";
            }
            else
            {
                textBox1.Text += "\r\nРежим " + (modeNumber + 1).ToString() + " подошёл к концу.";
            }

            // Доп. информация выводится только в случае нажатия хотя бы нескольких кнопок
            if (countClicksNow > 0)
            {
                textBox1.Text += "\r\nВсего тестов: " + totalTestCount.ToString();
                textBox1.Text += "\r\nСреднее реальное время нажатия кнопки: " + avgResult + " секунд.";

                if (comboBoxModeFixed == 0 || comboBoxModeFixed == 1)
                {
                    textBox1.Text += "\r\nСреднее время нажатия кнопки по Фиттсу: " + avgResultFitts + " секунд.";
                }
            }
            textBox1.Text += "\r\n";

        }

    }
}
