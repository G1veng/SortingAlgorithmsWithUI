using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    static int compares = 0;
    static int changes = 0;
    static int globalSizeOfArray = 0;
      static int[] bubble_sort(int[] array)
      {
      compares = 0;
      changes = 0;
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
          for (int j = i + 1; j < array.Length; j++)
          {
          if (array[i] > array[j])
          {
            compares++;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            changes++;
          }
          else
            compares++;
          }
        }
        return array;
      }

    static void Swap(ref int e1, ref int e2)
    {
      var temp = e1;
      e1 = e2;
      e2 = temp;
    }
    static int[] insert_sort(int[] array)
    {
      int[] result = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        int j = i;
        while (j > 0 && result[j - 1] > array[i])
        {
          result[j] = result[j - 1];
          j--;
          changes++;
        }
        //if(j != 0 || i != 0)
        compares++;
        result[j] = array[i];
      }
      return result;
    }
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
          var left = lowIndex;
          var right = middleIndex + 1;
          var tempArray = new int[highIndex - lowIndex + 1];
          var index = 0;

          while ((left <= middleIndex) && (right <= highIndex))
          {
          if (array[left] < array[right])
            {
              compares++;
              tempArray[index] = array[left];
              left++;
              changes++;
            }
            else
            {
              compares++;
              tempArray[index] = array[right];
              right++;
              changes++;
        }

            index++;
          }

          for (var i = left; i <= middleIndex; i++)
          {
            tempArray[index] = array[i];
            index++;
            changes++;
          }

          for (var i = right; i <= highIndex; i++)
          {
            tempArray[index] = array[i];
            index++;
            changes++;
          }

          for (var i = 0; i < tempArray.Length; i++)
          {
            array[lowIndex + i] = tempArray[i];
          }
        }

        //сортировка слиянием
        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
          if (lowIndex < highIndex)
          {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middleIndex);
            MergeSort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
          }

          return array;
        }

        static int[] MergeSort(int[] array)
        {
          return MergeSort(array, 0, array.Length - 1);
        }

      static int add2pyramid(int[] arr, int i, int N)
      {
        int imax;
        int buf;
        if ((2 * i + 2) < N)
        {
          if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
          else imax = 2 * i + 1;
          compares++;
        }
        else imax = 2 * i + 1;
        if (imax >= N) return i;
        if (arr[i] < arr[imax])
        {
          compares++;
          buf = arr[i];
          arr[i] = arr[imax];
          arr[imax] = buf;
          changes++;
          if (imax < N / 2) i = imax;
        }
        else
        {
          compares++;
        }
        return i;
      }
    public static void sorting(int[] arr, int len)
    {
      //step 1: building the pyramid
      for (int i = len / 2 - 1; i >= 0; --i)
      {
        int prev_i = i;
        i = add2pyramid(arr, i, len);
        if (prev_i != i) ++i;
      }

      //step 2: sorting
      int buf;
      for (int k = len - 1; k > 0; --k)
      {
        changes++;
        buf = arr[0];
        arr[0] = arr[k];
        arr[k] = buf;
        int i = 0, prev_i = -1;
        while (i != prev_i)
        {
          prev_i = i;
          i = add2pyramid(arr, i, k);
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {

      textBox1.Clear();
      textBox2.Clear();
      textBox3.Clear();
      textBox4.Clear();
      textBox5.Clear();
      int sizeOfArrayInt = 0;
      int[] array = null;
      int[] sortedArray = null;
      if (toolStripTextBox1.Text == "")
      {
        string sizeOfArrayString = toolStripComboBox1.Text;
        sizeOfArrayInt = Int32.Parse(sizeOfArrayString);
        globalSizeOfArray = sizeOfArrayInt;
        array = new int[sizeOfArrayInt];
        sortedArray = new int[sizeOfArrayInt];
      }
      else
      {
        List<int> listArray = new List<int>();
        string stringArray = "";
        string number = "";
        stringArray = toolStripTextBox1.Text;
        for (int i = 0; i <= stringArray.Length; i++)
        {
          if (i != stringArray.Length)
          {
            if ((stringArray[i] == ' ' || i == stringArray.Length) && number != "")
            {
              listArray.Add(Int32.Parse(number));
              sizeOfArrayInt++;
              number = "";
            }
          }
          if(i == stringArray.Length)
          {
            if (i == stringArray.Length && number != "")
            {
              listArray.Add(Int32.Parse(number));
              sizeOfArrayInt++;
              number = "";
            }
          }
          if (i != stringArray.Length && stringArray[i] != ' ')
          {
            number += stringArray[i];
          }
        }
        globalSizeOfArray = sizeOfArrayInt;
        array = new int[sizeOfArrayInt];
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          array[i] = listArray[i];
        }
      }
      int[] copyOfArray = new int[sizeOfArrayInt];
      //textBox1.Text = sizeOfArrayInt.ToString();
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
      {
        List<int> membersOfArray = new List<int>();
        Random rnd = new Random();
        int value = 0;
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          membersOfArray.Add(i);
        }
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          value = rnd.Next(0, sizeOfArrayInt - i - 1);
          array[i] = membersOfArray[value];
          membersOfArray.RemoveAt(value);
        }
      }
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
      {
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          array[i] = i;
        }
      }
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
      {
        for (int i = sizeOfArrayInt - 1; i >= 0; i--)
        {
          array[sizeOfArrayInt - i - 1] = i;
        }
      }
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
      {
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          array[i] = i;
        }
        Random rnd = new Random();
        int value = 0;
        for(int i = 0; i < 2; i++) 
        { 
          value = rnd.Next(1, sizeOfArrayInt - 1);
          int temp = array[value];
          array[value] = array[value - 1];
          array[value - 1] = temp;
        }
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox5.Text += array[i].ToString() + ' ';
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        copyOfArray[i] = array[i];
      }
      if (bubbleToolStripMenuItem1.CheckState == CheckState.Checked)
      {
        sortedArray = bubble_sort(copyOfArray);
        for(int i = 0; i < sizeOfArrayInt; i++)
        {
          //textBox1.Text += sortedArray[i].ToString() + ' ';
        }
        textBox1.Text += "Bubble sort: ";
        textBox1.Text += "\r\n";
        textBox1.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox1.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
      }
      if (insertToolStripMenuItem1.CheckState == CheckState.Checked)
      {
        sortedArray = insert_sort(copyOfArray);
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          //textBox2.Text += sortedArray[i].ToString() + ' ';
        }
        textBox2.Text += "Insert sort: \r\n";
        textBox2.Text += "Count of compares: " + (compares-1).ToString() + "\r\n";
        textBox2.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
      }
      if (mergeToolStripMenuItem1.CheckState == CheckState.Checked)
      {
        sortedArray = MergeSort(copyOfArray);
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          //textBox3.Text += sortedArray[i].ToString() + ' ';
        }
        textBox3.Text += "Merge sort: \r\n";
        textBox3.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox3.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
      }
      if (tryangleToolStripMenuItem1.CheckState == CheckState.Checked)
      {
        sorting(copyOfArray, sizeOfArrayInt);
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          //textBox4.Text += array[i].ToString() + ' ';
        }
        textBox4.Text += "Pyramid sort: \r\n";
        textBox4.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox4.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
      }
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
      {
        sortedArray = bubble_sort(copyOfArray);
        /*for (int i = 0; i < sizeOfArrayInt; i++)
        {
          textBox1.Text += sortedArray[i].ToString() + ' ';
        }*/
        textBox1.Text += "Bubble sort: \r\n";
        textBox1.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox1.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          copyOfArray[i] = array[i];
        }
        sortedArray = insert_sort(copyOfArray);
        /*for (int i = 0; i < sizeOfArrayInt; i++)
        {
          textBox2.Text += sortedArray[i].ToString() + ' ';
        }*/
        textBox2.Text += "Insert sort: \r\n";
        textBox2.Text += "Count of compares: " + (compares-1).ToString() + "\r\n";
        textBox2.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          copyOfArray[i] = array[i];
        }
        sortedArray = MergeSort(copyOfArray);
        /*for (int i = 0; i < sizeOfArrayInt; i++)
        {
          textBox3.Text += sortedArray[i].ToString() + ' ';
        }*/
        textBox3.Text += "Merge sort: \r\n";
        textBox3.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox3.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
        for (int i = 0; i < sizeOfArrayInt; i++)
        {
          copyOfArray[i] = array[i];
        }
        sorting(copyOfArray, sizeOfArrayInt);
        /*for (int i = 0; i < sizeOfArrayInt; i++)
        {
          textBox4.Text += array[i].ToString() + ' ';
        }*/
        textBox4.Text += "Pyramid sort: \r\n";
        textBox4.Text += "Count of compares: " + compares.ToString() + "\r\n";
        textBox4.Text += "Count of changes: " + changes.ToString() + "\r\n";
        compares = 0;
        changes = 0;
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void shooseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void randomArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
        randomArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      else randomArrayToolStripMenuItem.CheckState = CheckState.Checked;
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        almostSortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void menuToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void sortedArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      else sortedArrayToolStripMenuItem.CheckState = CheckState.Checked;
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
        randomArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        almostSortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;

    }

    private void sortedBackwardsArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      else sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Checked;
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        almostSortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
        randomArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void almostSortedArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        almostSortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      else almostSortedArrayToolStripMenuItem.CheckState = CheckState.Checked;
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
        randomArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void enterArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripTextBox1_Click(object sender, EventArgs e)
    {
      if (randomArrayToolStripMenuItem.CheckState == CheckState.Checked)
        randomArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (sortedBackwardsArrayToolStripMenuItem.CheckState == CheckState.Checked)
        sortedBackwardsArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
      if (almostSortedArrayToolStripMenuItem.CheckState == CheckState.Checked)
        almostSortedArrayToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void bubbleToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (bubbleToolStripMenuItem1.CheckState == CheckState.Checked)
        bubbleToolStripMenuItem1.CheckState = CheckState.Unchecked;
      else bubbleToolStripMenuItem1.CheckState = CheckState.Checked;
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
        allTypesToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (insertToolStripMenuItem1.CheckState == CheckState.Checked)
        insertToolStripMenuItem1.CheckState = CheckState.Unchecked;
      else insertToolStripMenuItem1.CheckState = CheckState.Checked;
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
        allTypesToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void mergeToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (mergeToolStripMenuItem1.CheckState == CheckState.Checked)
        mergeToolStripMenuItem1.CheckState = CheckState.Unchecked;
      else mergeToolStripMenuItem1.CheckState = CheckState.Checked;
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
        allTypesToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void tryangleToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (tryangleToolStripMenuItem1.CheckState == CheckState.Checked)
        tryangleToolStripMenuItem1.CheckState = CheckState.Unchecked;
      else tryangleToolStripMenuItem1.CheckState = CheckState.Checked;
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
        allTypesToolStripMenuItem.CheckState = CheckState.Unchecked;
    }

    private void allTypesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (allTypesToolStripMenuItem.CheckState == CheckState.Checked)
        allTypesToolStripMenuItem.CheckState = CheckState.Unchecked;
      else allTypesToolStripMenuItem.CheckState = CheckState.Checked;
      if (bubbleToolStripMenuItem1.CheckState == CheckState.Checked)
        bubbleToolStripMenuItem1.CheckState = CheckState.Unchecked;
      if (insertToolStripMenuItem1.CheckState == CheckState.Checked)
        insertToolStripMenuItem1.CheckState = CheckState.Unchecked;
      if (mergeToolStripMenuItem1.CheckState == CheckState.Checked)
        mergeToolStripMenuItem1.CheckState = CheckState.Unchecked;
      if (tryangleToolStripMenuItem1.CheckState == CheckState.Checked)
        tryangleToolStripMenuItem1.CheckState = CheckState.Unchecked;
    }

    private void toolStripComboBox1_Click(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void testToolStripMenuItem_Click(object sender, EventArgs e)
    {
      textBox1.Clear();
      textBox2.Clear();
      textBox3.Clear();
      textBox4.Clear();
      textBox5.Clear();
      int sizeOfArrayInt = 10;
      int[] array = new int[sizeOfArrayInt];
      int[] copyOfArray = new int[sizeOfArrayInt];
      int[] sortedArray = new int[sizeOfArrayInt];
      List<int> membersOfArray = new List<int>();
      Random rnd = new Random();
      int value = 0;
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        membersOfArray.Add(i);
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        value = rnd.Next(0, sizeOfArrayInt - i - 1);
        array[i] = membersOfArray[value];
        membersOfArray.RemoveAt(value);
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox5.Text += array[i].ToString() + ' ';
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        copyOfArray[i] = array[i];
      }
      sortedArray = bubble_sort(copyOfArray);
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox1.Text += sortedArray[i].ToString() + ' ';
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        copyOfArray[i] = array[i];
      }
      sortedArray = insert_sort(copyOfArray);
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox2.Text += sortedArray[i].ToString() + ' ';
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        copyOfArray[i] = array[i];
      }
      sortedArray = MergeSort(copyOfArray);
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox3.Text += sortedArray[i].ToString() + ' ';
      }
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        copyOfArray[i] = array[i];
      }
      sorting(copyOfArray, sizeOfArrayInt);
      for (int i = 0; i < sizeOfArrayInt; i++)
      {
        textBox4.Text += copyOfArray[i].ToString() + ' ';
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = saveFileDialog1.FileName;
      System.IO.File.WriteAllText(filename, "Size of array: " + globalSizeOfArray.ToString() + textBox1.Text + textBox2.Text 
        + textBox3.Text + textBox4.Text);
      /*System.IO.File.WriteAllText(filename, "\n");*/
      MessageBox.Show("Файл сохранен");
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
