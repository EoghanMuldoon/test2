using System;
using System.Collections.Generic;
using System.Text;

namespace TimeApp
{
    class myTimeChangeingClass
    {
        // properties
        public string InputUnits { get; set; }
        public string OutputUnits { get; set; }

        public string[] TimeChange = {"GMT - PST",
                                             "GMT - CST",
                                             "GMT - EST",
                                             "PST - CST",
                                             "PST - EST",
                                             "PST - GMT",
                                             "CST - PST",
                                             "CST - EST",
                                             "CST - GMT",
                                             "EST - PST",
                                             "EST - CST",
                                             "EST - GMT"};


        // methods
        public double convert(double inputV, int cType)
        {
            double answer = 0;
            // need to choose the conversion
            switch (cType)
            {
                case 0: // GMT - PST
                    answer = inputV - 8;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "GMT Time";
                        OutputUnits = "PST Time The day before";
                    }
                    else
                    {
                        InputUnits = "GMT Time";
                        OutputUnits = "PST Time";
                    }
                    break;
                case 1: // GMT - CST
                    answer = inputV - 6;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "GMT Time";
                        OutputUnits = "CST Time The day before";
                    }
                    else
                    {
                        InputUnits = "GMT Time";
                        OutputUnits = "CST Time";
                    }
                    break;
                case 2: //  GMT - EST
                    answer = inputV - 5;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "GMT Time";
                        OutputUnits = "EST Time The day before";
                    }
                    else
                    {
                        InputUnits = "GMT Time";
                        OutputUnits = "EST Time";
                    }

                    break;
                case 3: // PST - CST
                    answer = inputV + 2;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "PST Time";
                        OutputUnits = "CST Time is the day ahead";
                    }
                    else
                    {
                        InputUnits = "PST Time";
                        OutputUnits = "CST Time";
                    }

                    break;

                case 4: // PST - EST
                    answer = inputV + 3;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "PST Time";
                        OutputUnits = "EST Time is the day ahead";
                    }

                    else
                    {
                        InputUnits = "PST Time";
                        OutputUnits = "EST Time";
                    }
                    ;
                    break;
                case 5: //PST - GMT
                    answer = inputV + 8;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "PST Time";
                        OutputUnits = "GMT Time is the day ahead";
                    }

                    else
                    {
                        InputUnits = "PST Time";
                        OutputUnits = "GMT Time";
                    }

                    break;
                case 6: //CST - PST
                    answer = inputV - 2;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "CST Time";
                        OutputUnits = "PST Time is a day behind";
                    }
                    else
                    {
                        InputUnits = "CST Time";
                        OutputUnits = "PST Time";
                    }
                    InputUnits = "CST Time";
                    OutputUnits = "PST Time";
                    break;

                case 7: // CST - EST
                    answer = inputV + 1;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "CST Time";
                        OutputUnits = "EST Time is the day ahead";
                    }

                    else
                    {
                        InputUnits = "CST Time";
                        OutputUnits = "EST Time";
                    }

                    break;
                case 8: //CST - GMT
                    answer = inputV + 6;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "CST Time";
                        OutputUnits = "GMT Time is the day ahead";
                    }

                    else
                    {
                        InputUnits = "CST Time";
                        OutputUnits = "GMT Time";
                    }
                    break;
                case 9: //EST - PST
                    answer = inputV - 3;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "EST Time";
                        OutputUnits = "PST Time is a day behind";
                    }
                    else
                    {
                        InputUnits = "EST Time";
                        OutputUnits = "PST Time";
                    }

                    break;

                case 10: //EST - CST
                    answer = inputV - 1;

                    if (answer < 0)
                    {
                        answer = answer + 24;
                        InputUnits = "EST Time";
                        OutputUnits = "CST Time is the day behind";
                    }
                    else
                    {
                        InputUnits = "EST Time";
                        OutputUnits = "CST Time";
                    }
                    InputUnits = "EST Time";
                    OutputUnits = "CST Time";
                    break;
                case 11: //EST - GMT
                    answer = inputV + 5;
                    if (answer >= 24)
                    {
                        answer = answer - 24;
                        InputUnits = "EST Time";
                        OutputUnits = "GMT Time is the day ahead";
                    }

                    else
                    {
                        InputUnits = "EST Time";
                        OutputUnits = "GMT Time";
                    }
                    break;


                default:
                    break;
            }



            return answer;
        }

    }
}
