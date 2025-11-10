// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Custom MyList<T> class using arrays as the underlying data structure.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      var myList = new MyList<int> ();
      string print = "Elements in MyList after", print1 = "Elements in my list: ";
      myList.Add (8);
      myList.Add (15);
      myList.Add (23);
      myList.Add (42);
      WriteLine ($"{print1}");
      PrintList (myList);
      myList.Insert (2, 16);
      WriteLine ($"{print} Insert(2, 16): ");
      PrintList (myList);
      myList.RemoveAt (0);
      WriteLine ($"{print} RemoveAt (0): ");
      PrintList (myList);
      myList.Remove (16);
      WriteLine ($"{print} Remove (16): ");
      PrintList (myList);
      myList[1] = 88;
      WriteLine ($"{print} Index [1] = 88: ");
      PrintList (myList);
      WriteLine ($"{print} Index [13] = 6 (out of range index): ");
      myList[13] = 6;
      PrintList (myList);
      WriteLine ($"{print} RemoveAt (13) (out of range RemoveAt method): ");
      myList.RemoveAt (13);
      PrintList (myList);
      WriteLine ($"{print} Insert (7, 13) (out of range Insert method): ");
      myList.Insert (7, 13);
      PrintList (myList);
      myList.Clear ();
      WriteLine ($"{print} Clear method: ");
      PrintList (myList);
      myList.Add (99);
      WriteLine ($"{print} Add (99): ");
      PrintList (myList);
      WriteLine ($"Count: {myList.Count}\nCapacity: {myList.Capacity}\n\n");

      var strList = new MyList<string> ();
      strList.Add ("Hello");
      strList.Add ("There!");
      strList.Add ("How");
      strList.Add ("Are");
      strList.Add ("You?");
      WriteLine ($"{print1}");
      PrintList (strList);
      strList.Insert (2, "Good");
      strList.Insert (3, "Morning.");
      WriteLine ($"{print} Insert (2, \"Good\") and Insert (3, \"Morning.\"): ");
      PrintList (strList);
      strList.Remove ("There!");
      WriteLine ($"{print} Remove (\"There!\"): ");
      PrintList (strList);
      strList.RemoveAt (1);
      WriteLine ($"{print} RemoveAt (1): ");
      PrintList (strList);
      WriteLine ($"{print} Insert (8, \"Great\") (out of range Insert method): ");
      strList.Insert (8, "Great");
      PrintList (strList);
      WriteLine ($"{print} RemoveAt (5) (out of range RemoveAt method): ");
      strList.RemoveAt (5);
      PrintList (strList);
      WriteLine ($"{print} Index [6] = \"Hey\" (out of range index): ");
      strList[6] = "Hey";
      PrintList (strList);
      strList.Clear ();
      WriteLine ($"{print} Clear method: ");
      PrintList (strList);
      strList.Add ("Bye");
      WriteLine ($"{print} Add (\"Bye\"): ");
      PrintList (strList);
      WriteLine ($"Count: {strList.Count}\nCapacity: {strList.Capacity}\n\n");

      var dblList = new MyList<double> ();
      dblList.Add (1);
      dblList.Add (2.1230);
      dblList.Add (12344.56789);
      dblList.Add (8.88888);
      WriteLine ($"{print1}");
      PrintList (dblList);
      dblList.Insert (3, 2876.667);
      WriteLine ($"{print} Insert (3, 2876.667): ");
      PrintList (dblList);
      dblList.Remove (1);
      WriteLine ($"{print} Remove (1): ");
      PrintList (dblList);
      dblList.RemoveAt (2);
      WriteLine ($"{print} RemoveAt (2): ");
      PrintList (dblList);
      WriteLine ($"{print} RemoveAt (3) (out of range RemoveAt method): ");
      dblList.RemoveAt (3);
      PrintList (dblList);
      WriteLine ($"{print} Insert (4,4) (out of range Insert method): ");
      dblList.Insert (4, 4);
      PrintList (dblList);
      WriteLine ($"{print} Index [5] (out of range index): ");
      dblList[5] = 12.9987;
      PrintList (dblList);
      dblList.Clear ();
      WriteLine ($"{print} Clear method: ");
      PrintList (dblList);
      dblList.Add (39.3939);
      WriteLine ($"{print} Add (39.3939): ");
      PrintList (dblList);
      WriteLine ($"Count: {dblList.Count}\nCapacity: {dblList.Capacity}");
   }

   //Prints the elements of list
   static void PrintList<T> (MyList<T> list) {
      for (int i = 0; i < list.Count; i++) Write ($"{list[i]} ");
      WriteLine ();
   }
}

#region class MyList ------------------------------------------------------------------------------

// Custom generic list class
class MyList<T> {
   #region Constructor ----------------------------------------------------------------------------
   public MyList () {
      mItems = new T[4];
      mCount = 0;
   }
   #endregion

   #region Properties -----------------------------------------------------------------------------
   // Properties to get count and capacity
   public int Count => mCount;

   public int Capacity => mItems.Length;
   #endregion

   #region Public methods -------------------------------------------------------------------------
   // Add an item to the list
   public void Add (T a) {
      EnsureCapacity ();
      mItems[mCount++] = a;
   }

   // Clear the list
   public void Clear () {
      mItems = new T[4];
      mCount = 0;
   }

   // Indexer to access elements
   public T this[int index] {
      get {
         try {
            if (index < 0 || index >= mCount)
               throw new IndexOutOfRangeException ("Index out of range."); return mItems[index];
         } catch (IndexOutOfRangeException ex) {
            WriteLine (ex.Message);
            return default!;
         }
      }
      set {
         try {
            if (index < 0 || index >= mCount)
               throw new IndexOutOfRangeException ("Index out of range."); mItems[index] = value;
         } catch (IndexOutOfRangeException ex) {
            WriteLine (ex.Message);
         }
      }
   }

   // Insert an item at a specific index
   public void Insert (int index, T a) {
      try {
         if (index < 0 || index > mCount)
            throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for insert.");
         EnsureCapacity ();
         for (int i = mCount; i > index; i--)
            mItems[i] = mItems[i - 1];
         mItems[index] = a;
         mCount++;
      } catch (ArgumentOutOfRangeException ex) {
         WriteLine (ex.Message);
      }
   }

   // Remove an item from the list
   public bool Remove (T a) {
      int index = IndexOf (a);
      if (index == -1) return false;
      RemoveAt (index);
      return true;
   }

   // Remove an item at a specific index and throws exception if index is invalid
   public void RemoveAt (int index) {
      try {
         if (index < 0 || index >= mCount)
            throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for remove.");
         for (int i = index; i < mCount - 1; i++)
            mItems[i] = mItems[i + 1];
         mCount--;
         mItems[mCount] = default!;
      } catch (ArgumentOutOfRangeException ex) {
         WriteLine (ex.Message);
      }
   }
   #endregion

   #region Private helper methods -----------------------------------------------------------------
   // Ensure the list has enough capacity
   private void EnsureCapacity () {
      if (mCount >= Capacity) {
         T[] newArray = new T[Capacity * 2];
         Array.Copy (mItems, newArray, mCount);
         mItems = newArray;
      }
   }

   // Find the index of an item
   private int IndexOf (T a) {
      for (int i = 0; i < mCount; i++) if (Equals (mItems[i], a)) return i;
      return -1;
   }
   #endregion

   #region Private fields -------------------------------------------------------------------------
   T[] mItems;
   int mCount;
   #endregion
}
#endregion