﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutor.Array
{
    public class ArrayLecture
    {
        public string[] studentName = new string[10];

        public int[] studentAge = new int[10];

        public string[] GetArrayData()
        {
            studentName[0] = "Kene";
            studentName[1] = "Sonmto";
            studentName[2] = "Kinglsy";

            studentAge[0] = 20;
            studentAge[1] = 10;

            studentName[9] = "Kinglsy";//Line 
            return studentName;
        }

        public int[] GetArrayDataAge()
        {
            
            studentAge[0] = 20;
            studentAge[1] = 10;

            return studentAge;
        }

        //Write a C# program to ask the user for marks for 20 pupils (2 groups of 10, using a two-dimensional array), and display the average for each group.

    }
}
