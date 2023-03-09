using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.ViewModel
{
    internal partial class CalculatorVM : ObservableObject
    {
        public CalculatorVM() 
        {
            number1 = 0;
            number2 = 0;
            result = 0;
            numberSt = "0";
            regneart = null;
            calculated = false;
        }

        [ObservableProperty]
        private float number1;
        
        [ObservableProperty]
        private string numberSt;


        [ObservableProperty]
        private float number2;

        [ObservableProperty] 
        private string regneart;

        [ObservableProperty]
        private bool calculated;

        [ObservableProperty]
        private float result;

        [RelayCommand]
        public void button1()
        {
            
            if (Regneart == null)
            {
                if(Number1 != 0)
                {
                    NumberSt = NumberSt + "1";
                }
                else
                {
                    NumberSt = "1";
                }
            }
            else
            {
                if(Number2 != 0)
                {
                    NumberSt = NumberSt + "1";
                }
                else
                {
                    NumberSt = "1";
                }
            }
        }

        [RelayCommand] 
        public void button2() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "2";
                }
                else
                {
                    NumberSt = "2";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "2";
                }
                else
                {
                    NumberSt = "2";
                }
            }
        }

        [RelayCommand] 
        public void button3() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "3";
                }
                else
                {
                    NumberSt = "3";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "3";
                }
                else
                {
                    NumberSt = "3";
                }
            }
        }

        [RelayCommand] 
        public void button4() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "4";
                }
                else
                {
                    NumberSt = "4";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "4";
                }
                else
                {
                    NumberSt = "4";
                }
            }
        }
        
        [RelayCommand] 
        public void button5() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "5";
                }
                else
                {
                    NumberSt = "5";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "5";
                }
                else
                {
                    NumberSt = "5";
                }
            }
        }
        
        [RelayCommand] 
        public void button6() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "6";
                }
                else
                {
                    NumberSt = "6";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "6";
                }
                else
                {
                    NumberSt = "6";
                }
            }
        }
        
        [RelayCommand] 
        public void button7() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "7";
                }
                else
                {
                    NumberSt = "7";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "7";
                }
                else
                {
                    NumberSt = "7";
                }
            }
        }
        
        [RelayCommand] 
        public void button8() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "8";
                }
                else
                {
                    NumberSt = "8";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "8";
                }
                else
                {
                    NumberSt = "8";
                }
            }
        }
        
        [RelayCommand] 
        public void button9() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "9";
                }
                else
                {
                    NumberSt = "9";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "9";
                }
                else
                {
                    NumberSt = "9";
                }
            }
        }
        
        [RelayCommand] 
        public void button0() 
        {
            if (Regneart == null)
            {
                if (Number1 != 0)
                {
                    NumberSt = NumberSt + "0";
                }
            }
            else
            {
                if (Number2 != 0)
                {
                    NumberSt = NumberSt + "0";
                }
            }
        }
        
        [RelayCommand]
        public void ac()
        {
            Calculated = false;
            Number1 = 0; 
            Number2 = 0;
            Result = 0;
            NumberSt = "0";
            Regneart = null;
        }

        [RelayCommand]
        public void comma()
        {
            if (Regneart == null)
            {
                NumberSt = Number1.ToString();
                foreach(char c in NumberSt)
                {
                    if(c == '.')
                    {
                        return;
                    }
                }
                
                NumberSt = NumberSt + ".";
            }
            else
            {
                foreach(char c in NumberSt)
                {
                    if (c == '.')
                    {
                        return;
                    }
                }
                
                NumberSt = NumberSt + ".";
            }
        }

        [RelayCommand]
        public void calculate()
        {
            
            if (Calculated == false)
            {
                Number2 = float.Parse(NumberSt);
                switch (Regneart)
                {
                    case "-":
                        Result = Number1 - Number2;
                        break;
                    case "+":
                        Result = Number1 + Number2;
                        break;
                    case "*":
                        Result = Number1 * Number2;
                        break;
                    case "/":
                        Result = Number1 / Number2;
                        break;
                
                }
            }
            else
            {
                switch (Regneart)
                {
                    case "-":
                        Result = Result - Number2;
                        break;
                    case "+":
                        Result = Result + Number2;
                        break;
                    case "*":
                        Result = Result * Number2;
                        break;
                    case "/":
                        Result = Result / Number2;
                        break;

                }
            }



        }

       
    }
}
