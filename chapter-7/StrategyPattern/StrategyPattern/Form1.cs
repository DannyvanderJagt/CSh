using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        int[] randomArray;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            randomArray = new int[10];
            createRandomArray();
            printArray("New random array:", randomArray);
        }

        //Create a random array
        public void createRandomArray()
        {
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(randomArray.Length * 2);
            }
        }

        //Print an array to the ListBox
        public void printArray(string title, int[] array)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(title);
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i].ToString());
            }
            listBox1.Items.Add("");
        }

        private void newArray_Click(object sender, EventArgs e)
        {
            createRandomArray();
            printArray("New random array:", randomArray);
        }

        //The Context
        void ButtonClick(object sender, EventArgs e)
        {
            Button control = sender as Button;
            SortStrategy strategy = null;

            switch (control.Name)
            {
                case "bubbleSort":
                    strategy = new BubbleSort();
                    break;
                case "insertionSort":
                    strategy = new InsertionSort();
                    break;
                case "selectionSort":
                    strategy = new SelectionSort();
                    break;
            }

            int[] sortedArray = strategy.Sort(randomArray);
            printArray(strategy.GetType() + " results:", sortedArray);
        }
    }

    //Strategy Interface
    interface SortStrategy
    {
        int[] Sort(int[] array);
    }

    //Strategy 1
    class BubbleSort : SortStrategy
    {
        public int[] Sort(int[] array)
        {
            int[] newArray = (int[])array.Clone();
            for (int outer = newArray.Length - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (newArray[inner].CompareTo(newArray[inner + 1]) > 0)
                    {
                        int temp = newArray[inner];
                        newArray[inner] = newArray[inner + 1];
                        newArray[inner + 1] = temp;
                    }
                }
            }
            return newArray;
        }
    }

    //Strategy 2
    class InsertionSort : SortStrategy
    {
        public int[] Sort(int[] array)
        {
            int[] newArray = (int[])array.Clone();
            int inner;
            for (int outer = 1; outer < newArray.Length; outer++)
            {
                int temp = newArray[outer];
                inner = outer;
                while (inner > 0 && newArray[inner - 1].CompareTo(temp) >= 0)
                {
                    newArray[inner] = newArray[inner - 1];
                    inner--;
                }
                newArray[inner] = temp;
            }
            return newArray;
        }
    }

    //Strategy 3
    class SelectionSort : SortStrategy
    {
        public int[] Sort(int[] array)
        {
            int[] newArray = (int[])array.Clone();
            int min;
            for (int outer = 0; outer < newArray.Length; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner < newArray.Length; inner++)
                    if (newArray[inner].CompareTo(newArray[min]) < 0)
                        min = inner;
                int temp = newArray[outer];
                newArray[outer] = newArray[min];
                newArray[min] = temp;
            }
            return newArray;
        }
    }
}
